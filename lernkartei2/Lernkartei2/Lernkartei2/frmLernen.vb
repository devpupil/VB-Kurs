Imports System.Data.OleDb
Public Class frmLernen
    '
    ' private Variablen nur für diese Klasse ereichbar anlegen
    Private da As OleDbDataAdapter = Nothing
    Private dt As DataTable = Nothing
    ' Den Bindingsource bs mit weiteren Eigenschaften erweitern
    Private WithEvents bs As New BindingSource
    Private Schalter As Boolean = False
    Private Lernzeit As Integer = 30
    Private Gesamtzeit As Integer = Lernzeit

   

    Private Sub frmLernen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            '
            ' Objektvariablen anlegen für die Datenbankverbindung, der Connectionstring wird als Parameter übergeben
            '
            Dim con As New OleDbConnection(My.Settings.lernkartei2ConnectionString)

            ' SQL String für die Abfrage
            Dim sqlStr As String = "SELECT tbl_Fragen.* FROM tbl_Fragen WHERE tbl_Fragen.cat_id=" & My.Settings.KatWahl & ";"

            ' Die Connection und der SQL String werden auf den Data Adapter geladen
            da = New OleDbDataAdapter(sqlStr, con)

            ' Schemadataadapter für Spalten der Tabellen und Primärschlüssel
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey

            ' Commandbuilder für Löschen, Neuanlegen, Update der Daten
            Dim cb = New OleDbCommandBuilder(da)

            ' neue Datentabelle anelgen, der String muss nicht mit dem Tabellennamen übereinstimmen
            dt = New DataTable("tblFragen")

            ' die Verbindung zu Datenbank öffnen
            con.Open()

            ' Die Datentabelle füllen
            da.Fill(dt)

            ' Die Verbindung wieder beenden
            con.Close()

            ' Die Databindingsource mit der Datenquelle belegen
            bs.DataSource = dt

            ' Jedes Element auf dem Formular muss mit dem Bindingsource gebunden werden
            txtID.DataBindings.Add("text", bs, "ID")

            FrageTextBox.DataBindings.Add("text", bs, "frage")
            prAntwortFreiTextBox.DataBindings.Add("text", bs, "pr_antwortFrei")
            ' Zum Auswerten brauchen wir auch die LehererAntwoert
            AntwortFreiTextBox.DataBindings.Add("text", bs, "antwortFrei")

            ' Multiple Choice
            Mc_anwort1TextBox.DataBindings.Add("text", bs, "mc_anwort1")
            Mc_check1CheckBox.DataBindings.Add("Checked", bs, "mc_check1")

            Mc_anwort2TextBox.DataBindings.Add("text", bs, "mc_anwort2")
            Mc_check2CheckBox.DataBindings.Add("Checked", bs, "mc_check2")

            Mc_anwort3TextBox.DataBindings.Add("text", bs, "mc_anwort3")
            Mc_check3CheckBox.DataBindings.Add("Checked", bs, "mc_check3")

            Mc_anwort4TextBox.DataBindings.Add("text", bs, "mc_anwort4")
            Mc_check4CheckBox.DataBindings.Add("Checked", bs, "mc_check4")

            Mc_anwort5TextBox.DataBindings.Add("text", bs, "mc_anwort5")
            Mc_check5CheckBox.DataBindings.Add("Checked", bs, "mc_check5")

            ' Zurückstellen der Frage
            ZurueckstellenCheckBox.DataBindings.Add("Checked", bs, "zurueckstellen")

            ' Anbinden der Lehrer Antworten
            pr_mc_checkbox1.DataBindings.Add("Checked", bs, "pr_mc_check1")
            pr_mc_checkbox2.DataBindings.Add("Checked", bs, "pr_mc_check2")
            pr_mc_checkbox3.DataBindings.Add("Checked", bs, "pr_mc_check3")
            pr_mc_checkbox4.DataBindings.Add("Checked", bs, "pr_mc_check4")
            pr_mc_checkbox5.DataBindings.Add("Checked", bs, "pr_mc_check5")

            ' Liest alle Datensätze in das Formular ein, man kann zählen wieviele es gibt
            bs.MoveLast()
            bs.MoveFirst()

            ' Tooltip

            ' Timer
            Timer1.Start()


        Catch ex As Exception
            ' Aufruf unserer Fehlerroutine
            If FehlerAnezige(ex) Then
                MsgBox("Anwendung wird beendet")
                Me.Close()
            End If
        End Try

    End Sub

    Private Sub btnErster_Click(sender As Object, e As EventArgs) Handles btnErster.Click
        ' den aktuellen Datensatz aus dem Speicher löschen
        ' bs.RemoveCurrent()
        ' Anwendung der Änderung in der Datenquelle
        bs.EndEdit()
        da.Update(dt)
        ' Den Bindingsource auf den ersten Datensatz  stellen
        bs.MoveFirst()

    End Sub

    Private Sub btnZurück_Click(sender As Object, e As EventArgs) Handles btnZurück.Click

        ' Anwendung der Änderung in der Datenquelle
        bs.EndEdit()
        da.Update(dt)

        bs.MovePrevious()
    End Sub

    Private Sub btnNächster_Click(sender As Object, e As EventArgs) Handles btnNächster.Click

        ' Anwendung der Änderung in der Datenquelle
        bs.EndEdit()
        da.Update(dt)

        ' Fragen auswerten
        ' Punktezähler aufrufen
        punktezaehler()

        bs.MoveNext()
    End Sub

    Private Sub btnLetzter_Click(sender As Object, e As EventArgs) Handles btnLetzter.Click

        ' Anwendung der Änderung in der Datenquelle
        bs.EndEdit()
        da.Update(dt)

        bs.MoveLast()
    End Sub

    Private Sub btnRueckNochmal_Click(sender As Object, e As EventArgs) Handles btnRueckNochmal.Click
        ' Schalter Variable anlegen in Klassenkopf
        If Schalter = True Then
            btnRueckNochmal.Text = "Zurückgestellte"
            bs.RemoveFilter()
        Else
            btnRueckNochmal.Text = "Gefiltert"
            bs.Filter = "zurueckstellen=True"

            ' Umschalten schaltet die Textboxen oder das Panel Sichtbar
            umschalten()
        End If
        ' Variable zurücksetzen
        Schalter = Not Schalter
    End Sub

    Private Sub bs_CurrentChanged(sender As Object, e As EventArgs) Handles bs.CurrentChanged
        ' Funktion umschalten
        ' Wenn der Datensatzzeiger gewechselt hat, ermittle ob es eine 
        ' freie Antwort oder MC Antwort ist, und schalte die entsprechenden Objekte visible oder nicht
        umschalten()
    End Sub

    Private Sub umschalten()
        ' sub prozedur = keine Rückgabe
        'Abfrage ob freie Antwort oder nicht
        If AntwortFreiTextBox.Text.Length > 0 Then
            TableLayoutPanel1.Visible = False
            prAntwortFreiTextBox.Visible = True
        Else
            TableLayoutPanel1.Visible = True
            prAntwortFreiTextBox.Visible = False
        End If

    End Sub
    Private Function auswerten_mc() As Integer
        ' Punktezähler
        Dim punkte As Integer = 0

        ' Abfragen
        ' Beide nicht angehackt, dann keine Punkte
        ' Eins nicht angehackt, dann keine Punkte
        ' Richtig angehackt, dann ein Punkt
        ' jedes falsch angehackte dann - ein Punkt

        If pr_mc_checkbox1.Checked = True And Mc_check1CheckBox.Checked = True Then
            punkte += 1
        ElseIf pr_mc_checkbox1.Checked = False And Mc_check1CheckBox.Checked = True Then
            punkte -= 1
        End If

        If pr_mc_checkbox2.Checked = True And Mc_check2CheckBox.Checked = True Then
            punkte += 1
        ElseIf pr_mc_checkbox2.Checked = False And Mc_check2CheckBox.Checked = True Then
            punkte -= 1
        End If

        If pr_mc_checkbox3.Checked = True And Mc_check3CheckBox.Checked = True Then
            punkte += 1
        ElseIf pr_mc_checkbox3.Checked = False And Mc_check3CheckBox.Checked = True Then
            punkte -= 1
        End If

        If pr_mc_checkbox4.Checked = True And Mc_check4CheckBox.Checked = True Then
            punkte += 1
        ElseIf pr_mc_checkbox4.Checked = False And Mc_check4CheckBox.Checked = True Then
            punkte -= 1
        End If

        If pr_mc_checkbox5.Checked = True And Mc_check5CheckBox.Checked = True Then
            punkte += 1
        ElseIf pr_mc_checkbox5.Checked = False And Mc_check5CheckBox.Checked = True Then
            punkte -= 1
        End If

        ' Wenn die Punkte im Minus sind dann 0 ausgeben
        ' Punkte Gesamt < 1 dann = punkte
        If punkte < 0 Then
            punkte = 0
        End If

        'Rückgabe
        Return punkte
    End Function

    Private Sub btnAuswerten_Click(sender As Object, e As EventArgs) Handles btnAuswerten.Click
        MsgBox(auswerten_mc.ToString() + " Punkte erzielt")
    End Sub

    Private Function auswerten_FA() As Array
        Dim antwort(3) As Integer
        'Dim punkte As Integer = 0
        Dim i As Integer
        Dim j As Integer
        Dim zaehler As Integer = 0
        Dim richtigeAntwort As Integer = 0
        Dim maxPunkte As Integer = 0

        ' Die Antworten in Arrays einlesen und gegenseitig auswerten
        ' Schuelerantwort
        Dim prantwort() As String = Split(prAntwortFreiTextBox.Text, " ")
        ' Lehrerantwort
        Dim frantwort() As String = Split(AntwortFreiTextBox.Text, " ")

        'For i = 0 To UBound(antwort)
        '   MsgBox(antwort(i))
        'Next

        For i = 0 To UBound(antwort)
            For j = 0 To UBound(prantwort)
                If String.Compare(frantwort(i), prantwort(j), True) = 0 Then
                    zaehler += 1
                End If
            Next j
        Next i


        richtigeAntwort = zaehler

        'If ((100 / (antwort).Length) * zaehler) >= 75 Then
        '    MsgBox("Der Schüler hat " + zaehler.ToString("#,###0.00") + " Punkte erreicht")
        'End If

        If ((100 / (antwort).Length) * zaehler) >= 75 Then
            'punkte = richtigeAntworten
        End If

        Return antwort
    End Function

    Private Sub btnAuswertenFrei_Click(sender As Object, e As EventArgs) Handles btnAuswertenFrei.Click
        MsgBox(auswerten_FA())
    End Sub

    Private Sub punktezaehler()
        ' Auswerten ob freie Frage oder Multiple Choice
        If AntwortFreiTextBox.Text.Length > 0 Then
            auswerten_FA()
        Else
            auswerten_mc()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Timer wird beim Form_load gestartet

        Dim txtMinuten As Integer = 0
        Dim txtSekunden As Integer = 0

        ' Der Timer läuft rückwärts, pro Durchlauf wird 1 abgezogen, bei Interval 1000 ist das 1 Sekunde
        Lernzeit -= 1

        ' Rote und fette Ausgabe wenn nur noch 10 % der Gesamtzeit vorhanden
        If Lernzeit <= ((Gesamtzeit / 100) * 10) Then
            lblRestzeit.ForeColor = Color.Red
            lblRestzeit.Font = New Font(lblRestzeit.Font, FontStyle.Bold)
        End If

        ' Debug Ausgabe zum Testen
        'Debug.Print (Lernzeit)

        ' Formatierte Ausgabe durch Funktion IntToDateStr
        lblRestzeit.Text = IntToDateStr(Lernzeit)

        ' Progressbar 
        'Dim percent As Integer = CInt(((CDbl(lblProgress.Value) / CDbl(lblProgress.Maximum)) * 100))


        'lblProgress.Value -= 1

        ' Beenden des Timers wenn die 0 erreicht ist.
        If Lernzeit = 0 Then
            Timer1.Stop()
            MessageBox.Show("Die Zeit ist abgelaufen:", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ' me.close()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTimeDate.Text = FormatDateTime(Now, DateFormat.ShortDate) & " " & FormatDateTime(Now, DateFormat.ShortTime)

        ' Numlock aktiviert oder nicht
        If My.Computer.Keyboard.NumLock = True Then
            lblNum.Text = "Numlock ON"
        Else
            lblNum.Text = "Numlock Off"
        End If

        ' Capslock testen
        If My.Computer.Keyboard.CapsLock = True Then
            lblCaps.Text = "Capslock ON"
        Else
            lblCaps.Text = "Capslock Off"
        End If



    End Sub

End Class