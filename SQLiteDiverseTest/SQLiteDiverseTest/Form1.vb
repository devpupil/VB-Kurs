﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dialog1.TopLevel = False
        Dialog1.TextBox1.Text = "hallo"
        Me.Panel1.Controls.Add(Dialog1)
        Dialog1.Show()

    End Sub

    Private Sub TableLayoutPanel1_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel1.Click
        Dialog1.TopLevel = False
        Dialog1.TextBox1.Text = "Label gedrückt Click"
        Me.Panel1.Controls.Add(Dialog1)
        Dialog1.Show()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class