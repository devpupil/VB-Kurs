Public Class Form1

    Private Sub Tbl_adressenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_adressenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_adressenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdressenDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "AdressenDataSet.tbl_adressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Tbl_adressenTableAdapter.Fill(Me.AdressenDataSet.tbl_adressen)

    End Sub
End Class
