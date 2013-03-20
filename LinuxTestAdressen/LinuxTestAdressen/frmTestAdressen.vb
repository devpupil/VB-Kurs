Public Class frmTestAdressen

    Private Sub AdressenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdressenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdressenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdressenDataSet)

    End Sub

    Private Sub frmTestAdressen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "AdressenDataSet.Adressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AdressenTableAdapter.Fill(Me.AdressenDataSet.Adressen)

    End Sub
End Class
