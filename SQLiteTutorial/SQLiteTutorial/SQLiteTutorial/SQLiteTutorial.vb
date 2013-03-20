Imports System.Data.SQLite
Imports System.IO

Public Class sqlitetutorial

    'Image BLOB Functions
    Private Function BlobToImage(ByVal blob)
        Dim mStream As New System.IO.MemoryStream
        Dim pData() As Byte = DirectCast(blob, Byte())
        mStream.Write(pData, 0, Convert.ToInt32(pData.Length))
        Dim bm As Bitmap = New Bitmap(mStream, False)
        mStream.Dispose()
        Return bm
    End Function

    Public Overloads Function ImageToBlob(ByVal id As String, ByVal filePath As String)
        Dim fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim bm() As Byte = br.ReadBytes(fs.Length)
        br.Close()
        fs.Close()
        'Create Parm
        Dim photo() As Byte = bm
        Dim SQLparm As New SQLiteParameter("@image", photo)
        SQLparm.DbType = DbType.Binary
        SQLparm.Value = photo
        Return SQLparm
    End Function

    Public Overloads Function ImageToBlob(ByVal id As String, ByVal image As Image)
        Dim ms As New MemoryStream()
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        'Create Parm
        Dim photo() As Byte = ms.ToArray()
        Dim SQLparm As New SQLiteParameter("@image", photo)
        SQLparm.DbType = DbType.Binary
        SQLparm.Value = photo
        Return SQLparm
    End Function

    'Refresh Tables
    Public Sub refreshTables(ByVal dbFile As String)
        If dbFile <> String.Empty Then
            Dim selectFirst As Boolean = False
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & dbFile & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            Dim SchemaTable = SQLconnect.GetSchema(SQLiteMetaDataCollectionNames.Tables)
            lst_tables.Items.Clear()
            cmb_insert_tables.Items.Clear()
            cmb_update_tables.Items.Clear()
            cmb_delete_tables.Items.Clear()
            For int As Integer = 0 To SchemaTable.Rows.Count - 1
                If SchemaTable.Rows(int)!TABLE_TYPE.ToString = "table" Then
                    lst_tables.Items.Add(SchemaTable.Rows(int)!TABLE_NAME.ToString())
                    cmb_insert_tables.Items.Add(SchemaTable.Rows(int)!TABLE_NAME.ToString())
                    cmb_update_tables.Items.Add(SchemaTable.Rows(int)!TABLE_NAME.ToString())
                    cmb_delete_tables.Items.Add(SchemaTable.Rows(int)!TABLE_NAME.ToString())
                    selectFirst = True
                End If
            Next
            SQLcommand.Dispose()
            SQLconnect.Close()
            If selectFirst Then
                cmb_insert_tables.SelectedIndex = 0
                cmb_update_tables.SelectedIndex = 0
                cmb_delete_tables.SelectedIndex = 0
            End If
        End If
    End Sub

    'Refresh Records
    Public Sub refreshRecords(ByVal dbFile As String)
        Dim selectFirst As Boolean
        If dbFile <> String.Empty And lst_tables.Items.Count >= 1 Then
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & dbFile & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            Dim SQLreader As SQLiteDataReader
            'Update Section
            If cmb_update_tables.SelectedIndex >= 0 Then
                selectFirst = False
                SQLcommand.CommandText = "SELECT * FROM " + cmb_update_tables.SelectedItem
                SQLreader = SQLcommand.ExecuteReader()
                cmb_update_records.Items.Clear()
                While SQLreader.Read()
                    cmb_update_records.Items.Add(String.Format("ID = {0}   Title = {1}, Description = {2}", SQLreader(0), SQLreader(1), SQLreader(2)))
                    selectFirst = True
                End While
                If selectFirst Then
                    cmb_update_records.SelectedIndex = 0
                End If
                SQLreader.Close()
            End If
            'End Update Section
            'Delete Section
            If cmb_delete_tables.SelectedIndex >= 0 Then
                selectFirst = False
                SQLcommand.CommandText = "SELECT * FROM " + cmb_delete_tables.SelectedItem
                SQLreader = SQLcommand.ExecuteReader()
                lst_delete_records.Items.Clear()
                While SQLreader.Read()
                    lst_delete_records.Items.Add(String.Format("ID = {0}   Title = {1}, Description = {2}", SQLreader(0), SQLreader(1), SQLreader(2)))
                    selectFirst = True
                End While
                If selectFirst Then
                    lst_delete_records.SelectedIndex = 0
                End If
                SQLreader.Close()
            End If
            'End Delete Section
            SQLcommand.Dispose()
            SQLconnect.Close()
        End If
    End Sub

    Private Sub btn_createdb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_createdb.Click
        'Show Save Dialog Box
        Dim f As New SaveFileDialog
        f.Filter = "SQLite 3 (*.db3)|*.db3|All Files|*.*"
        If f.ShowDialog() = DialogResult.OK Then
            'Create Database
            Dim SQLconnect As New SQLite.SQLiteConnection()
            'Database Doesn't Exist so Created at Path
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()
            SQLconnect.Close()
            'Fills the txt_dbpath text box.
            txt_dbpath.Text = f.FileName
            'Enables Tabs
            tab_container.TabPages(1).Enabled = True
            tab_container.TabPages(2).Enabled = True
            tab_container.TabPages(3).Enabled = True
            tab_container.TabPages(4).Enabled = True
        End If
        refreshTables(txt_dbpath.Text)
        refreshRecords(txt_dbpath.Text)
    End Sub

    Private Sub btn_opendb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_opendb.Click
        'Show Open Dialog Box
        Dim f As New OpenFileDialog
        f.Filter = "SQLite 3 (*.db3)|*.db3|All Files|*.*"
        If f.ShowDialog() = DialogResult.OK Then
            'Fills the txt_dbpath text box.
            txt_dbpath.Text = f.FileName
            'Enables Tabs
            tab_container.TabPages(1).Enabled = True
            tab_container.TabPages(2).Enabled = True
            tab_container.TabPages(3).Enabled = True
            tab_container.TabPages(4).Enabled = True
        End If
        refreshTables(txt_dbpath.Text)
        refreshRecords(txt_dbpath.Text)
    End Sub

    Private Sub btn_tables_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tables_create.Click
        If txt_tables_name.Text <> String.Empty Then
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & txt_dbpath.Text & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            'SQL query to Create Table
            SQLcommand.CommandText = "CREATE TABLE " & txt_tables_name.Text & "(id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, description TEXT, image BLOB);"
            If lst_tables.Items.Contains(txt_tables_name.Text) Then
                'Table Name Found
                txt_tables_name.Text = "_" & txt_tables_name.Text
            Else
                'Create Table
                SQLcommand.ExecuteNonQuery()
                'Empty Value
                txt_tables_name.Text = String.Empty
                'Refresh
                refreshTables(txt_dbpath.Text)
                refreshRecords(txt_dbpath.Text)
            End If
            SQLcommand.Dispose()
            SQLconnect.Close()
        End If
    End Sub

    Private Sub btn_insertimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insertimage.Click
        Dim f As New SaveFileDialog
        f.Filter = "SQLite 3 (*.db3)|*.db3|All Files|*.*"
        Dim d As New OpenFileDialog
        d.Filter = "Image (*.png)|*.png|All Files|*.*"
        If f.ShowDialog() = DialogResult.OK And d.ShowDialog() = DialogResult.OK Then
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            'SQL query to Create Table
            SQLcommand.CommandText = "CREATE TABLE foo(id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, description TEXT, image BLOB);"
            SQLcommand.ExecuteNonQuery()
            'Insert Image
            SQLcommand.CommandText = "INSERT INTO foo (image) VALUES(@image)"
            'Define @image
            SQLcommand.Parameters.Add(ImageToBlob("@image", d.FileName))
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
        End If
    End Sub

    Private Sub btn_viewimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_viewimage.Click
        Dim f As New OpenFileDialog
        f.Filter = "SQLite 3 (*.db3)|*.db3|All Files|*.*"
        If f.ShowDialog() = DialogResult.OK Then
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT image FROM foo WHERE id = '1'"
            Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
            While SQLreader.Read()
                'If you SELECT from * then Its the Column (Tutorial it would be 3).
                pic_viewimage.Image = BlobToImage(SQLreader(0))
            End While
            SQLcommand.Dispose()
            SQLconnect.Close()
        End If
    End Sub

    Private Sub btn_updateimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_updateimage.Click
        Dim f As New OpenFileDialog
        f.Filter = "SQLite 3 (*.db3)|*.db3|All Files|*.*"
        Dim d As New OpenFileDialog
        d.Filter = "Image (*.png)|*.png|All Files|*.*"
        If f.ShowDialog() = DialogResult.OK And d.ShowDialog() = DialogResult.OK Then
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "UPDATE foo SET image = @image WHERE id = '1'"
            SQLcommand.Parameters.Add(ImageToBlob("@image", d.FileName))
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
        End If
    End Sub

    Private Sub sqlitetutorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Disable Tabs Contents so Users Creates/Selects DB first.
        tab_container.TabPages(1).Enabled = False
        tab_container.TabPages(2).Enabled = False
        tab_container.TabPages(3).Enabled = False
        tab_container.TabPages(4).Enabled = False
    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        SQLconnect.ConnectionString = "Data Source=" & txt_dbpath.Text & ";"
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        '@image CANNOT be in single quotes
        SQLcommand.CommandText = "INSERT INTO " + cmb_insert_tables.SelectedItem + " (title, description, image) VALUES ('" + txt_insert_title.Text.Replace("'", "''") + "', '" + txt_insert_description.Text.Replace("'", "''") + "', @image)"
        'Sets the meaning of @image.
        SQLcommand.Parameters.Add(ImageToBlob("@image", btn_insert_select.Text))
        'Runs Query
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
        SQLconnect.Close()
        'Refreshes Records
        refreshRecords(txt_dbpath.Text)
        'Resets Values
        txt_insert_title.Text = String.Empty
        txt_insert_description.Text = String.Empty
        pic_insert_image.Image = Nothing
        btn_insert_select.Text = "Select Image File"
    End Sub

    Private Sub btn_insert_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert_select.Click
        Dim d As New OpenFileDialog
        d.Filter = "Image (*.png)|*.png|All Files|*.*"
        If d.ShowDialog() = DialogResult.OK Then
            pic_insert_image.Image = Image.FromFile(d.FileName)
            btn_insert_select.Text = d.FileName
        End If
    End Sub

    Private Sub cmb_update_records_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_update_records.SelectedIndexChanged
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        SQLconnect.ConnectionString = "Data Source=" & txt_dbpath.Text & ";"
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT * FROM " & cmb_update_tables.SelectedItem & " WHERE id = '" & (cmb_update_records.SelectedIndex + 1) & "'"
        Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        While SQLreader.Read()
            txt_update_title.Text = SQLreader("title")
            txt_update_description.Text = SQLreader("description")
            pic_update_image.Image = BlobToImage(SQLreader("image"))
        End While
        SQLcommand.Dispose()
        SQLconnect.Close()
        'Reset Button's Text
        btn_update_select.Text = "Select Image File"
    End Sub

    Private Sub cmb_update_tables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_update_tables.SelectedIndexChanged
        refreshRecords(txt_dbpath.Text)
    End Sub

    Private Sub btn_tables_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tables_delete.Click
        If lst_tables.SelectedIndex >= 0 Then
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & txt_dbpath.Text & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            'SQL query to Delete Table
            SQLcommand.CommandText = "DROP TABLE " & lst_tables.SelectedItem & ";"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
            refreshTables(txt_dbpath.Text)
        End If
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If lst_delete_records.SelectedIndex >= 0 Then
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & txt_dbpath.Text & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            'SQL query to Delete Table
            SQLcommand.CommandText = "DELETE FROM " & cmb_delete_tables.SelectedItem & " WHERE id = '" & (lst_delete_records.SelectedIndex + 1) & "';"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
            refreshTables(txt_dbpath.Text)
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim selIndex As Integer = cmb_update_records.SelectedIndex
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        SQLconnect.ConnectionString = "Data Source=" & txt_dbpath.Text & ";"
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        'Checks if image needs to be updated
        If btn_update_select.Text = "Select Image File" Then
            SQLcommand.CommandText = "UPDATE " & cmb_update_tables.SelectedItem & " SET title = '" & txt_update_title.Text.Replace("'", "''") & "', description =  '" & txt_update_description.Text.Replace("'", "\'") & "' WHERE id = '" & (cmb_update_records.SelectedIndex + 1) & "'"
        Else
            '@image CANNOT be in single quotes
            SQLcommand.CommandText = "UPDATE " & cmb_update_tables.SelectedItem & " SET title = '" & txt_update_title.Text.Replace("'", "''") & "', description =  '" & txt_update_description.Text.Replace("'", "\'") & "', image = @image WHERE id = '" & (cmb_update_records.SelectedIndex + 1) & "'"
            'Sets the meaning of @image.
            SQLcommand.Parameters.Add(ImageToBlob("@image", btn_update_select.Text))
        End If
        'Runs Query
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
        SQLconnect.Close()
        'Refreshes Records
        refreshRecords(txt_dbpath.Text)
        'Reselect the One You Updated
        cmb_update_records.SelectedIndex = selIndex
        'Resets Values
        btn_insert_select.Text = "Select Image File"
    End Sub

    Private Sub btn_update_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update_select.Click
        Dim d As New OpenFileDialog
        d.Filter = "Image (*.png)|*.png|All Files|*.*"
        If d.ShowDialog() = DialogResult.OK Then
            pic_update_image.Image = Image.FromFile(d.FileName)
            btn_update_select.Text = d.FileName
        End If
    End Sub

    Private Sub cmb_delete_tables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_delete_tables.SelectedIndexChanged
        refreshRecords(txt_dbpath.Text)
    End Sub
End Class
