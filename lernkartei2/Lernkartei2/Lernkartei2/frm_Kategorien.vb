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
        frm_Filter.ShowDialog()

        ' Rückgabewert des OK Buttons auswerten
        If frm_Filter.DialogResult = Windows.Forms.DialogResult.OK Then

            ' Where Clause wird zusammengebaut und die tabelle durchsucht
            Me.Tbl_kategorieBindingSource.Filter = "kategorieName='" & frm_Filter.txtSuche.Text & "'"


        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Tbl_kategorieBindingSource.RemoveFilter()
        frm_Filter.txtSuche.Text = ""
    End Sub
End Class