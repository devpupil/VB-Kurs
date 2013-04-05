Public Class frm_Fragen

    Private Sub Tbl_FragenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_FragenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_FragenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lernkartei2DataSet)

    End Sub

    Private Sub frm_Fragen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "Lernkartei2DataSet.tbl_Fragen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Tbl_FragenTableAdapter.Fill(Me.Lernkartei2DataSet.tbl_Fragen)

    End Sub
End Class
