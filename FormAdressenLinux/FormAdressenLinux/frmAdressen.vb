Public Class frmAdressen

    Private Sub AdressenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdressenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdressenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub frmAdressen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataSet1.Adressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AdressenTableAdapter.Fill(Me.DataSet1.Adressen)

    End Sub
End Class
