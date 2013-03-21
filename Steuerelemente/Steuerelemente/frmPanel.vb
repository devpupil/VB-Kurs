Public Class frmPanel

    Private Sub btnOben_Click(sender As Object, e As EventArgs) Handles btnOben.Click
        panMove.Location = New Point(panMove.Location.X, panMove.Location.Y - 10)
    End Sub

    Private Sub btnRechts_Click(sender As Object, e As EventArgs) Handles btnRechts.Click
        panMove.Location = New Point(panMove.Location.X + 10, panMove.Location.Y)
    End Sub

    Private Sub btnUnten_Click(sender As Object, e As EventArgs) Handles btnUnten.Click
        panMove.Location = New Point(panMove.Location.X, panMove.Location.Y + 10)
    End Sub

    Private Sub btnLinks_Click(sender As Object, e As EventArgs) Handles btnLinks.Click
        panMove.Location = New Point(panMove.Location.X - 10, panMove.Location.Y)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        frmSource.txtSource.Text = "Hier soll der Source Code stehen   "
        frmSource.ShowDialog()
    End Sub
End Class