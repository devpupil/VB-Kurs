Imports System.Windows.Forms

Public Class frm_Filter

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub frm_Filter_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.txtSuche.TabIndex = 0
        Me.txtSuche.Focus()
        Me.txtSuche.SelectAll()
    End Sub
End Class
