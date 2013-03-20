Imports System.Windows.Forms

Public Class frmOption

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ' Alle Variablen werden belegt
        MwST = NumericUpDownMwST.Value
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'wird beim Öffnen aus der globalen Variablen gelesen und auf das Optionefeld geschrieben
        NumericUpDownMwST.Value = MwST
    End Sub
End Class
