Public Class frm_Fragen

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
End Class
