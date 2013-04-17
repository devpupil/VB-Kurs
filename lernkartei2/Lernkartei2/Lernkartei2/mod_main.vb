Module mod_main
    Sub main()
        SplashScreen1.ShowDialog()

        ' Argumente abfangen und Programm entsprechend starten
        If Command() = "/admin" Or Command() = "-admin" Then
            Application.Run(New MDIMain)

        Else
            frm_KategorieWahl.ShowDialog()

            If frm_KategorieWahl.DialogResult = DialogResult.OK Then

                ' Kategoriewahl in den Settings speichern
                My.Settings.KatWahl = frm_KategorieWahl.ComboBox1.SelectedValue
                My.Settings.Save()

                ' Starten des Formulares als eigenständige Anwendung
                Application.Run(New frm_Lernen)
            End If

        End If



    End Sub
End Module
