Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dialog1.TopLevel = False
        Dialog1.TextBox1.Text = "hallo"
        Me.Panel1.Controls.Add(Dialog1)
        Dialog1.Show()

    End Sub

    Private Sub TableLayoutPanel1_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel1.Click
        Dialog1.TopLevel = False
        Dialog1.TextBox1.Text = "Table Layout Panel1_Click"
        Me.Panel1.Controls.Add(Dialog1)
        Dialog1.Show()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub lblButtonTest_Click(sender As Object, e As EventArgs) Handles lblButtonTest.Click
        Dialog1.TopLevel = False
        Dialog1.TextBox1.Text = "Label klein gedrückt"
        Me.Panel1.Controls.Add(Dialog1)
        Dialog1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dialog1.TopLevel = False
        Dialog1.TextBox1.Text = "Button 3 gedrückt"
        Me.Panel1.Controls.Add(Dialog1)
        Dialog1.Show()
    End Sub
End Class