Public Class frmTutorial
    Private Sub btn_createdb_Click(sender As Object, e As EventArgs) Handles btn_createdb.Click
        ' Öffnet Datei speichern
        Dim f As New SaveFileDialog
        f.Filter = "SQLite 3 (*.db3) |*.db3|All Files|"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' Datenbankdatei erstellen
            Dim SQLconnect As New SQLiteConnection()

            ' Die Datenbank existiert noch nicht, Wir erstellen den Pfad
            SQLconnect.ConnectionString = "Data Source=" & f.FileName & ";"
            SQLconnect.Open()
            SQLconnect.Close()

        Else
            MsgBox("Abbrechen gedrückt")
        End If
    End Sub

    Private Sub btn_createtables_Click(sender As Object, e As EventArgs) Handles btn_createtables.Click
        Dim f As New OpenFileDialog
        f.Filter = "SQLite 3 (*.db3) |*.db3|All Files|*.*"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim SQLconnect As New SQLiteConnection
            Dim SQLcommand As SQLiteCommand
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

    Private Sub btn_osversion_Click(sender As Object, e As EventArgs) Handles btn_osversion.Click
        MessageBox.Show(GetOSVersion)
    End Sub

    Private Sub frmTutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
