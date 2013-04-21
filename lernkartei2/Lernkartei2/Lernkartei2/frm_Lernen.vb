Imports System.Data.OleDb
Public Class frm_Lernen

    Private Sub frm_Lernen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Für die SQL connection zur Datenbank
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand

        ' Die Verbindung aus den System.Settings holen
        con.ConnectionString = "C:\Users\gwallner\Source\Repos\VB-Kurs\lernkartei2\Daten"
        'My.Settings.lernkartei2ConnectionString

        ' die Verbindung dem Command zuordnen
        cmd.Connection = con

        ' Den SQL Query zusammenbauen und auf eine Stringvariable setzen
        cmd.CommandText = "SELECT tbl_Fragen.* FROM tbl_Fragen WHERE tbl_Fragen.cat_id=" & My.Settings.KatWahl & ";"

        ' 
        Try
            con.Open()

        Catch ex As Exception
            If FehlerAnezige(ex) = True Then
                Me.Close()
            End If

        End Try


    End Sub
End Class