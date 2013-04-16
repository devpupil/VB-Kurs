Public Class frm_database

    Private Sub btn_changeDB_Click(sender As Object, e As EventArgs) Handles btn_changeDB.Click
        Dim f As New OpenFileDialog
        f.Filter = "SQLite 3 (*.db3) |*.db3|All Files|"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.DBPath = f.FileName
            lbl_databaseCurrent.Text = My.Settings.DBPath

            ' Datenbanktabellen im Datagrid zeigen falls das Labeleld gefüllt ist
            fill_dbTableGrid()
        Else
            My.Settings.DBPath = ""
            lbl_databaseCurrent.Text = My.Settings.DBPath
            dbTableGrid.Visible = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub frm_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbTableGrid.Visible = False
        lbl_databaseCurrent.Text = My.Settings.DBPath
        fill_dbTableGrid()

    End Sub

    Sub fill_dbTableGrid()
        ' Datenbanktabellen im Datagrid zeigen falls das Labeleld gefüllt ist
        If lbl_databaseCurrent.Text <> "" Then
            dbTableGrid.Visible = True
            Dim connString As String = "Data Source=" & lbl_databaseCurrent.Text
            Dim conn As New SQLiteConnection(connString)

            conn.Open()

            Dim getTables As New SQLiteCommand("Select name From sqlite_master where type='table' order by name;", conn)
            Dim myCountAdapter As New SQLiteDataAdapter(getTables)
            Dim myCountDataSet As New DataSet()
            myCountAdapter.Fill(myCountDataSet, "name")

            dbTableGrid.DataSource = myCountDataSet
            dbTableGrid.DataMember = "name"
            conn.Close()
            dbTableGrid.Visible = True
        End If
    End Sub

End Class