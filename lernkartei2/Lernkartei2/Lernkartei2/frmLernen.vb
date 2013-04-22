Imports System.Data.OleDb
Public Class frmLernen
    '
    ' private Variablen nur für diese Klasse ereichbar anlegen
    Private da As OleDbDataAdapter = Nothing
    Private dt As DataTable = Nothing
    Private bs As New BindingSource

    Private Sub frmLernen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub
End Class