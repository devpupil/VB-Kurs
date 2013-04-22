Imports System.Windows.Forms
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class frmFehler

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmFehler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = Application.ProductName & " ist beunruhigt"
    End Sub

    
    Private Sub btnPrintError_Click(sender As Object, e As EventArgs) Handles btnPrintError.Click
        ' Verweis hinzufügen Microsoft.VisualBasic.Powerpacks.Vs
        ' Import des Printing hinzufügen 
        ' Imports Microsoft.VisualBasic.PowerPacks.Printing

        'Objektvariable anlegen
        Dim pf As New PrintForm

        ' Welches Formular soll gedruckt werden
        pf.Form = Me

        ' Wie soll gedruckt werden Vorschau, Drucken, Datei
        pf.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview

        ' Das Formular für den Ausdruck vorbereiten
        ' Buttons ausblenden, Textbox vergrößern
        TableLayoutPanel1.Visible = False
        Me.Height = Me.Height + 300
        Me.txtErrorPrintStackTrace.Height = Me.txtErrorPrintStackTrace.Height + 300

        ' Zeit geben um die vorhergehenden Befehle abzuarbeiten
        Application.DoEvents()

        ' Druckvorgang auslösen
        pf.Print()

        ' Buttons wieder einschalten, Formular verkleinern, Textbox verkleinern
        TableLayoutPanel1.Visible = True
        Me.Height = Me.Height - 300
        Me.txtErrorPrintStackTrace.Height = Me.txtErrorPrintStackTrace.Height - 300

    End Sub
End Class
