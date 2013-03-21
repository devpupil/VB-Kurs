Public Class frmZeit

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timAnzeige.Enabled = True
    End Sub

    Private Sub timAnzeige_Tick(sender As Object, e As EventArgs) Handles timAnzeige.Tick
        lblAnzeige.Text &= "x"
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timAnzeige.Enabled = False
    End Sub
End Class