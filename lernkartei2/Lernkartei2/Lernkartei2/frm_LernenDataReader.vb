Imports System.Data.OleDb
Public Class frm_LernenDataReader

    Private Sub frm_Lernen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Für die SQL connection zur Datenbank
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader

        ' Variable zum Testen
        Dim Ergebnis As String = ""

        ' Die Verbindung aus den System.Settings holen
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gwallner\Repos\VB-Kurs\lernkartei2\Daten\lernkartei.accdb"
        'My.Settings.lernkartei2ConnectionString

        ' die Verbindung dem Command zuordnen
        cmd.Connection = con

        ' Den SQL Query zusammenbauen und auf eine Stringvariable setzen
        cmd.CommandText = "SELECT tbl_Fragen.* FROM tbl_Fragen WHERE tbl_Fragen.cat_id=" & My.Settings.KatWahl & ";"

        ' 
        Try
            con.Open()

            ' Auslesen der Datenbank über einen Reader
            reader = cmd.ExecuteReader

            ' auslesen der daten bis der Reader keine Daten mehr findet
            Do While reader.Read
                Ergebnis += reader("frage") + vbCr
            Loop
            MsgBox(Ergebnis)

        Catch ex As Exception
            If FehlerAnezige(ex) = True Then
                Me.Close()
            End If

        End Try
    End Sub
End Class