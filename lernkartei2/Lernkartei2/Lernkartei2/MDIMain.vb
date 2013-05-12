Imports System.Windows.Forms

Public Class MDIMain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Neue Instanz des untergeordneten Formulars erstellen.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Vor der Anzeige dem MDI-Formular unterordnen.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Fenster " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Hier Code zum Öffnen der Datei hinzufügen
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Hier Code einfügen, um den aktuellen Inhalt des Formulars in einer Datei zu speichern
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Mithilfe von My.Computer.Clipboard.GetText() oder My.Computer.Clipboard.GetData Informationen aus der Zwischenablage abrufen
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Alle untergeordneten Formulare des übergeordneten Formulars schließen
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.winState <> FormWindowState.Minimized Then
            My.Settings.posLeft = Me.Left
            My.Settings.posTop = Me.Top
            My.Settings.posWidth = Me.Width
            My.Settings.posHeigth = Me.Height
        End If
        My.Settings.winState = Me.WindowState
        My.Settings.Save()
    End Sub

    Private Sub MDIMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.winState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.Left = My.Settings.posLeft
            Me.Top = My.Settings.posTop
            Me.Width = My.Settings.posWidth
            Me.Height = My.Settings.posHeigth
        End If
    End Sub

    Private Sub FragenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FragenToolStripMenuItem.Click
        frm_Fragen.MdiParent = Me
        frm_Fragen.WindowState = FormWindowState.Maximized
        frm_Fragen.Show()
    End Sub

    Private Sub KategoreienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoreienToolStripMenuItem.Click
        frm_Kategorien.MdiParent = Me
        frm_Kategorien.WindowState = FormWindowState.Maximized
        frm_Kategorien.Show()
    End Sub

    Private Sub ZurücksetzenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZurücksetzenToolStripMenuItem.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Wollen sie wirklich die Prüfungsantworten zurücksetzen?", "Achtung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        ' Falls nein dann wird die Prozedur beendet
        If dr = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        ' Datenbankverbindung wird aufgebaut
        Dim con As New OleDb.OleDbConnection(My.Settings.lernkartei2ConnectionString)
        ' Command
        Dim cmd As New OleDb.OleDbCommand
        ' Die Connection auf den Command legen
        cmd.Connection = con

        'SQL Befehl zum Update der Prüfungsfragen, mit Access zusammengebaut
        cmd.CommandText = "UPDATE tbl_Fragen SET tbl_Fragen.pr_antwortFrei = """", tbl_Fragen.pr_mc_check1 = False, tbl_Fragen.pr_mc_check2 = False, tbl_Fragen.pr_mc_check4 = False, tbl_Fragen.pr_mc_check5 = False, tbl_Fragen.zurueckstellen = False;"

        Try
            'Datenbank öffnen
            con.Open()
            ' Ausführen des SQL Befehls und Rückgabe der bearbeiteten Datensätze mit Ausgabe durch MsgBox
            MsgBox(cmd.ExecuteNonQuery().ToString() + " Datensätze wurden bearbeitet")
            ' Verbindung schliessen
            con.Close()
        Catch ex As Exception
            If FehlerAnezige(ex) Then
                MsgBox("Das Programm wird geschlossen")
                Me.Close()
            End If

        End Try

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        frmOption.MdiParent = Me
        frmOption.Show()
        frmOption.WindowState = FormWindowState.Maximized
    End Sub
End Class
