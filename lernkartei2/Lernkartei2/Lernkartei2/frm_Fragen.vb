﻿Public Class frm_Fragen

    Private Sub Tbl_FragenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_FragenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_FragenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lernkartei2DataSet)

    End Sub

    Private Sub frm_Fragen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "Lernkartei2DataSet.tbl_kategorie". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Tbl_kategorieTableAdapter.Fill(Me.Lernkartei2DataSet.tbl_kategorie)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "Lernkartei2DataSet.tbl_Fragen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Tbl_FragenTableAdapter.Fill(Me.Lernkartei2DataSet.tbl_Fragen)

    End Sub

   
    Private Sub btnFragenFilterLoeschen_Click(sender As Object, e As EventArgs) Handles btnFragenFilterLoeschen.Click
        ' Filter wieder löschen
        Me.Tbl_FragenBindingSource.RemoveFilter()

    End Sub

    Private Sub btnFragenFilter_Click(sender As Object, e As EventArgs) Handles btnFragenFilter.Click
        ' Eigenschaften ändern
        ' Labelfeld
        frm_Filter.Label1.Text = "Bitte den Suchbegriff eingeben"
        ' Caption
        frm_Filter.Text = "Fragen filtern"

        frm_Filter.ShowDialog()

        If frm_Filter.DialogResult = Windows.Forms.DialogResult.OK Then
            ' Filter SQL Strings
            Dim FilterTag1 As String = "frage LIKE '*" & frm_Filter.txtSuche.Text & "*'"
            Dim FilterTag2 As String = "antwortFrei LIKE '*" & frm_Filter.txtSuche.Text & "*'"

            ' Suchstring zusammenbauen und im FragenBindingSource suchen
            Me.Tbl_FragenBindingSource.Filter = FilterTag1 & " OR " & FilterTag2
        End If

        frm_Filter.Dispose()
    End Sub

    'Private Sub AntwortFreiTextBox_LostFocus(sender As Object, e As EventArgs) Handles AntwortFreiTextBox.LostFocus
    '    ' Das Panel mit den Multichoice Anworten unsichtbar schalten bzw. deaktivieren
    '    If AntwortFreiTextBox.Text.Length > 0 Then
    '        TableLayoutPanel1.Enabled = False
    '    Else
    '        TableLayoutPanel1.Enabled = True
    '    End If
    'End Sub

   
   

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "" Then
            Tbl_FragenBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Tbl_FragenBindingSource.Filter = "cat_id=" & ComboBox1.SelectedValue
    End Sub

    Private Sub AntwortFreiTextBox_TextChanged(sender As Object, e As EventArgs) Handles AntwortFreiTextBox.TextChanged
        If AntwortFreiTextBox.Text.Length > 0 Then
            TableLayoutPanel1.Enabled = False
        Else
            TableLayoutPanel1.Enabled = True
        End If
    End Sub

    Private Sub btnBildHolen_Click(sender As Object, e As EventArgs) Handles btnBildHolen.Click
        'Variable für Dateiinformationen
        Dim information As System.IO.FileInfo

        'Filter fuer die Dateiauswahl auf Bilder stellen
        BildHolen.Filter = "Bilder (*.jpg) |*.jpg|*.png|*.bmp|All Files|*.*"

        If BildHolen.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Bildnamen in der Datenbank speichern
            BildTextBox.Text = BildHolen.SafeFileName

            'Prüfen ob wir eine Datei mit dem selblen Namen schon gespeichert haben
            If IO.File.Exists(My.Settings.BilderPfad & "\" & BildHolen.SafeFileName) Then
                MessageBox.Show("Die Datei exisiert bereits!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'Kopieren des Bildes
                FileCopy(BildHolen.FileName, My.Settings.BilderPfad & "\" & BildHolen.SafeFileName)

                ' Datei in einer Picturebox darstellen, dafür muss sichergestellt werden, dass die Datei auch ein Bild ist.
                ' Auslesen der Dateiinformationen
                information = My.Computer.FileSystem.GetFileInfo(My.Settings.BilderPfad & "\" & BildHolen.SafeFileName)

                ' Filtern nach Dateiendung und Anzeigen der Datei in der Picturebox
                Select Case LCase(information.Extension)
                    Case ".jpg", ".png", ".bmp"
                        pictBox.Image = New Bitmap(My.Settings.BilderPfad & "\" & BildHolen.SafeFileName)
                End Select
                ' Warum ??
                BildHolen.Dispose()
            End If
        End If
    End Sub

   
End Class
