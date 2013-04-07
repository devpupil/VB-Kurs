Public Class Form1

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Dim f As New SaveFileDialog
        f.Filter = "Text (*.txt)|*.txt|All Files|"


        If f.ShowDialog = DialogResult.OK Then
            MsgBox("Speichern unter: " & f.FileName)
        Else
            MsgBox("Abgebrochen")
        End If


    End Sub
End Class
