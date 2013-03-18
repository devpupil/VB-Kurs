Public Class Form1

    Private Sub btn_hallo_Click(sender As Object, e As EventArgs) Handles btn_hallo.Click
        Label1.Text = "Hallo"
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Label1.Text = ""
    End Sub
End Class
