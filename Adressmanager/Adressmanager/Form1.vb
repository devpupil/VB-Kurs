Public Class Form1

    Private Sub AdressenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdressenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdressenDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "AdressenDataSet.Adressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AdressenTableAdapter.Fill(Me.AdressenDataSet.Adressen)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "AdressenDataSet.Adressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AdressenTableAdapter.Fill(Me.AdressenDataSet.Adressen)

    End Sub

    Private Sub AdressenBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles AdressenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdressenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdressenDataSet)

    End Sub
End Class
