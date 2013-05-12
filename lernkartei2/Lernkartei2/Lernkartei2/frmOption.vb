Imports System.Windows.Forms

Public Class frmOption
    ' Aufruf des Formulares aus dem MDIMain Menu unter dem Eintrag Optionen
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSuche_Click(sender As Object, e As EventArgs) Handles btnSuche.Click
        'Beschreibung des Dialogfensters
        Dokumentenpfad.Description = "Bitte den Speicherort der Bilder auswählen"
        'Vorgewählter Pfad aus den Settings einlesen. Variable muss vorher angelegt werden
        Dokumentenpfad.SelectedPath = My.Settings.BilderPfad

        'Nach öffnen des Dokumentenpfad Dialogs und Schliessen mit OK
        If Dokumentenpfad.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Pfad auf das Textfeld schreiben
            txtPfad.Text = Dokumentenpfad.SelectedPath
            'Pfad in den Settings speichern
            My.Settings.BilderPfad = Dokumentenpfad.SelectedPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub frmOption_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Beim Laden des Optionenformulares den Pfad aus den Settings in die Textbox schreiben
        txtPfad.Text = My.Settings.BilderPfad
    End Sub
End Class
