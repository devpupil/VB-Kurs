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
                Application.Run(New frmLernen)
            End If

        End If
    End Sub

    Public Function IntToDateStr(Sekunden As Long) As String
        ' Funktion für das Timelabel um die Zeit formatiert auszugeben
        ' Übergabe Sekunden
        ' Rückgabe String

        Dim rStd As Integer = Sekunden \ 3600
        Dim rMin As Integer = (Sekunden - rStd * 3600) \ 60
        Dim rSek As Integer = (Sekunden - rStd * 3600) - (rMin * 60)

        'Formatierte Rückgabe
        Return Format(rStd, "00") & ":" & Format(rMin, "00") & ":" & Format(rSek, "00")

    End Function
End Module
