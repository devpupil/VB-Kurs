Imports System.Data.OleDb
Public Class frmLernen
    '
    ' private Variablen nur für diese Klasse ereichbar anlegen
    Private da As OleDbDataAdapter = Nothing
    Private dt As DataTable = Nothing
    Private dt1 As DataTable = Nothing
    Private bs As New BindingSource

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
            AntwortFreiTextBox.DataBindings.Add("text", bs, "pr_antwortFrei")

            ' Multiple Choice
            Mc_anwort1TextBox.DataBindings.Add("text", bs, "mc_anwort1")
            Mc_check1CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check1")

            Mc_anwort2TextBox.DataBindings.Add("text", bs, "mc_anwort2")
            Mc_check2CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check2")

            Mc_anwort3TextBox.DataBindings.Add("text", bs, "mc_anwort3")
            Mc_check3CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check3")

            Mc_anwort4TextBox.DataBindings.Add("text", bs, "mc_anwort4")
            Mc_check4CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check4")

            Mc_anwort5TextBox.DataBindings.Add("text", bs, "mc_anwort5")
            Mc_check5CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check5")

            ' Zurückstellen der Frage
            ZurueckstellenCheckBox.DataBindings.Add("Checked", bs, "zurueckstellen")

        Catch ex As Exception
            ' Aufruf unserer Fehlerroutine
            If FehlerAnezige(ex) = True Then
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

        bs.MoveNext()
    End Sub

    Private Sub btnLetzter_Click(sender As Object, e As EventArgs) Handles btnLetzter.Click
       
        ' Anwendung der Änderung in der Datenquelle
        bs.EndEdit()
        da.Update(dt)

        bs.MoveLast()
    End Sub

    Private Sub btnRueckNochmal_Click(sender As Object, e As EventArgs) Handles btnRueckNochmal.Click

        Try
            ' neue Datentabelle anelgen, der String muss nicht mit dem Tabellennamen übereinstimmen
            dt1 = New DataTable("tblFragenRueckgestellt")

            ' die Verbindung zu Datenbank öffnen
            'con.Open()

            ' Die Datentabelle füllen
            da.Fill(dt)

            ' Die Verbindung wieder beenden
            'con.Close()

            ' Die Databindingsource mit der Datenquelle belegen
            bs.DataSource = dt

            ' Jedes Element auf dem Formular muss mit dem Bindingsource gebunden werden
            txtID.DataBindings.Add("text", bs, "ID")
            FrageTextBox.DataBindings.Add("text", bs, "frage")
            AntwortFreiTextBox.DataBindings.Add("text", bs, "pr_antwortFrei")

            ' Multiple Choice
            Mc_anwort1TextBox.DataBindings.Add("text", bs, "mc_anwort1")
            Mc_check1CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check1")

            Mc_anwort2TextBox.DataBindings.Add("text", bs, "mc_anwort2")
            Mc_check2CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check2")

            Mc_anwort3TextBox.DataBindings.Add("text", bs, "mc_anwort3")
            Mc_check3CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check3")

            Mc_anwort4TextBox.DataBindings.Add("text", bs, "mc_anwort4")
            Mc_check4CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check4")

            Mc_anwort5TextBox.DataBindings.Add("text", bs, "mc_anwort5")
            Mc_check5CheckBox.DataBindings.Add("Checked", bs, "pr_mc_check5")

            ' Zurückstellen der Frage
            ZurueckstellenCheckBox.DataBindings.Add("Checked", bs, "zurueckstellen")

        Catch ex As Exception
            ' Aufruf unserer Fehlerroutine
            If FehlerAnezige(ex) = True Then
                MsgBox("Anwendung wird beendet")
                Me.Close()
            End If
        End Try


    End Sub
End Class