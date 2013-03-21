Public Class frmPos

    Private Sub btnPositionRel_Click(sender As Object, e As EventArgs) Handles btnPositionRel.Click
        btnTest.Location = New Point(btnTest.Location.X + 20, btnTest.Location.Y)
    End Sub

    Private Sub btnPositionAbs_Click(sender As Object, e As EventArgs) Handles btnPositionAbs.Click
        btnTest.Location = New Point(100, 200)
    End Sub

    Private Sub btnGrößeRel_Click(sender As Object, e As EventArgs) Handles btnGrößeRel.Click
        btnTest.Size = New Size(btnTest.Size.Width + 20, btnTest.Size.Height)
    End Sub

    Private Sub btnGrößeAbs_Click(sender As Object, e As EventArgs) Handles btnGrößeAbs.Click
        btnTest.Size = New Size(50, 100)

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        btnTest.Location = New Point(21, 277)
        btnTest.Size = New Size(140, 50)
    End Sub

    Private Sub btnAnzeige_Click(sender As Object, e As EventArgs) Handles btnAnzeige.Click
        lblAnzeige.Text = "Position: X: " & btnTest.Location.X &
            ", Y: " & btnTest.Location.Y & vbCrLf &
            "Größe: Breite: " & btnTest.Size.Width &
            ", Höhe: " & btnTest.Size.Height
    End Sub

    Private Sub btnFarbe_Click(sender As Object, e As EventArgs) Handles btnFarbe.Click
        Me.BackColor = Color.Yellow
        lblAnzeige.BackColor = Color.FromArgb(192, 255, 0)
    End Sub
End Class
