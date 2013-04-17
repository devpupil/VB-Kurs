Public Class frm_Kategorien

    Private Sub Tbl_kategorieBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_kategorieBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_kategorieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lernkartei2DataSet)

    End Sub

    Private Sub frm_Kategorien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "Lernkartei2DataSet.tbl_kategorie". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Tbl_kategorieTableAdapter.Fill(Me.Lernkartei2DataSet.tbl_kategorie)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        ' Eigenschaften Filterformulars anpassen
        ' Labelfeld
        frm_Filter.Label1.Text = "Bitte geben Sie die gewünschte Kategorie an:"
        ' Caption
        frm_Filter.Text = "Kategorien filtern"



        frm_Filter.ShowDialog()

        ' Rückgabewert des OK Buttons auswerten
        If frm_Filter.DialogResult = Windows.Forms.DialogResult.OK Then

            ' Suchstring auf Variablen schreiben
            Dim FilterTag1 As String = "kategorieName LIKE '*" & frm_Filter.txtSuche.Text & "*'"
            Dim FilterTag2 As String = "kategorieBeschreibung LIKE '*" & frm_Filter.txtSuche.Text & "*'"

            ' Where Clause wird zusammengebaut und die tabelle durchsucht, mit Like und Platzhalter als Volltextsuche
            Me.Tbl_kategorieBindingSource.Filter = FilterTag1 & " OR " & FilterTag2

        End If
        frm_Filter.Dispose()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Tbl_kategorieBindingSource.RemoveFilter()
        frm_Filter.txtSuche.Text = ""
    End Sub
End Class