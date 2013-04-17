Imports System.Windows.Forms

Public Class frm_KategorieWahl

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_KategorieWahl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "Lernkartei2DataSet.Abf_AktiveKat". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Abf_AktiveKatTableAdapter.Fill(Me.Lernkartei2DataSet.Abf_AktiveKat)

        Me.ComboBox1.SelectedValue = My.Settings.KatWahl

    End Sub
End Class
