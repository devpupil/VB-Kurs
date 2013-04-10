Public Class frm_Begruessung

    Private Sub frm_Begruessung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ansage1 As String = "Liebe Amalie und Liebe Josi " & vbCr & "da Ihr nicht brav in das Bett gegangen seid" & vbCr & " gibt es ein"
        Dim ansage2 As String = "Fernsehverbot"

        'lbl_text.ForeColor = Color.Red

        'lbl_text.Font = New Font("Arial", 30, FontStyle.Bold)
        'lbl_text.Text = ansage1

        txtMessage.Font = New Font("Arial", 30)
        txtMessage.ForeColor = Color.Blue
        txtMessage2.ForeColor = Color.Red

        txtMessage.Text = ansage1
        txtMessage2.Text = ansage2
    End Sub
End Class
