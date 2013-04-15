Public Class frm_database

    Private Sub btn_changeDB_Click(sender As Object, e As EventArgs) Handles btn_changeDB.Click
        Dim f As New OpenFileDialog
        f.Filter = "SQLite 3 (*.db3) |*.db3|All Files|"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.DBPath = f.FileName
            lbl_databaseCurrent.Text = My.Settings.DBPath
        Else
            '
        End If
        My.Settings.Save()
    End Sub

   

    Private Sub frm_database_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_databaseCurrent.Text = My.Settings.DBPath



        If lbl_databaseCurrent.Text <> "" Then
            Dim connString As String = "Data Source=" & lbl_databaseCurrent.Text
            Dim conn As New SQLiteConnection(connString)

            Dim sqlString As String = "SELECT * FROM tbl_ort"
            Dim da As New SQLiteDataAdapter(sqlString, conn)
            lstTables.Text = "TEST"
        Else
            lstTables.Text = "Bitte eine Datenbank auswählen / erstellen"
        End If

    End Sub
End Class