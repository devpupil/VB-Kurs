Public Class frmStart

    Private Sub btnSteuerElemente_Click(sender As Object, e As EventArgs) Handles btnSteuerElemente.Click
        frmPos.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnWerte_Click(sender As Object, e As EventArgs) Handles btnWerte.Click
        frmWerte.ShowDialog()
    End Sub

    Private Sub btnPanelMove_Click(sender As Object, e As EventArgs) Handles btnPanelMove.Click
        frmPanel.ShowDialog()
    End Sub

    Private Sub btnZeitgeber_Click(sender As Object, e As EventArgs) Handles btnZeitgeber.Click
        frmZeit.ShowDialog()
    End Sub
End Class