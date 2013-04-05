Public Class frm_SQLiteTest

    Private Sub btn_createDB_Click(sender As Object, e As EventArgs) Handles btn_createDB.Click
        Dim f As New SaveFileDialog

        f.Filter = "SQLite 3 (*.db3) | *.db3|All Files|"
        f.ShowDialog()


    End Sub
End Class
