Module mod_error
    Public Function FehlerAnezige(ex As Exception) As Boolean
        frmFehler.txtErrorPrintStackTrace.Text = ex.StackTrace
        frmFehler.txtErrorNumber.Text = ex.HResult.ToString
        frmFehler.txtErrorSource.Text = ex.Source
        frmFehler.lblLinkError1.Text = ex.HelpLink
        frmFehler.txtErrorMessage.Text = ex.Message

        frmFehler.ShowDialog()

        If frmFehler.DialogResult = DialogResult.OK Then
            Return True
        Else
            Return False
        End If

    End Function
End Module
