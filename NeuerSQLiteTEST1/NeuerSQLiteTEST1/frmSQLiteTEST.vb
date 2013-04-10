Public Class frmSQLiteTEST

    Private Sub btn_createdb_Click(sender As Object, e As EventArgs) Handles btn_createdb.Click
        ' Öffnet Datei speichern
        Dim f As New SaveFileDialog
        f.Filter = "SQLite 3 (*.db3) |*.db3|All Files|"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' Datenbankdatei erstellen
            Dim SQLconnect As New SQLite.SQLiteConnection()

            ' Die Datenbank existiert noch nicht, Wir erstellen den Pfad
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()
            SQLconnect.Close()

        Else
            MsgBox("Abbrechen gedrückt")
        End If
    End Sub

    Private Sub btn_createtable_Click(sender As Object, e As EventArgs) Handles btn_createtable.Click
        Dim f As New OpenFileDialog
        f.Filter = "SQLite 3 (*.db3) |*.db3|All Files|*.*"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim SQLconnect As New SQLite.SQLiteConnection
            Dim SQLcommand As SQLite.SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()

            SQLcommand = SQLconnect.CreateCommand

            ' SQL Query um die Tabellen anzulegen
            SQLcommand.CommandText = "CREATE TABLE tbl_adressen(id INTEGER PRIMARY KEY AUTOINCREMENT, vorname TEXT, nachname TEXT, strasse TEXT, plz TEXT, ort TEXT, bild BLOB);"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
        Else
            MsgBox("Abrechen gedrückt")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New OpenFileDialog
        Dim zaehler As Integer
        f.Filter = "SQLite 3 (*.db3) |*.db3|All Files|*.*"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim SQLconnect As New SQLite.SQLiteConnection
            Dim SQLcommand As SQLite.SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()

            SQLcommand = SQLconnect.CreateCommand

            ' Zaehler einlesen um die Datenbank zu füllen
            frmDBFuel.txt_datasets.Focus()
            frmDBFuel.txt_datasets.SelectAll()
            frmDBFuel.ShowDialog()

            If frmDBFuel.DialogResult = Windows.Forms.DialogResult.OK Then

                zaehler = Int(frmDBFuel.txt_datasets.Text)
                ' SQL Query um die Tabellen mit einer bestimmten Anzahl an Datensätzen zu füllen

                For i As Integer = 0 To zaehler
                    ' SQL Query String
                    Dim sqlquery As String = "INSERT INTO tbl_adressen (vorname, nachname, strasse, plz, ort) VALUES('Max" & i & "','Muster" & i & "','Strasse" & i & "','11111','Musterstadt" & i & "');"

                    SQLcommand.CommandText = sqlquery
                    SQLcommand.ExecuteNonQuery()
                Next
                MsgBox(zaehler & " Datensätze gespeichert")
            Else
                MsgBox("Keinen Zähler eingegeben")
            End If
            SQLcommand.Dispose()
            SQLconnect.Close()
        Else
            MsgBox("Abrechen gedrückt")
        End If
    End Sub
End Class
