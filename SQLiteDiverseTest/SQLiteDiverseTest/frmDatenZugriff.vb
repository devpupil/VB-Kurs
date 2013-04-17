Public Class frmDatenZugriff

    Private Sub btn_alleKunden_Click(sender As Object, e As EventArgs) Handles btn_alleKunden.Click
        Dim con As New SQLiteConnection
        Dim cmd As New SQLiteCommand
        Dim reader As SQLiteDataReader

        If My.Settings.DBPath <> "" Then
            'con.ConnectionString = "Data Source=kunden.db3"
            con.ConnectionString = "Data Source=" & My.Settings.DBPath
            cmd.Connection = con
            'cmd.CommandText = "SELECT * FROM tbl_adressen"
            cmd.CommandText = "SELECT tbl_adressen.vorname, tbl_ort.plz, tbl_ort.ort, tbl_adressen.nachname, tbl_adressen.strasse, tbl_adressen.id_ort FROM tbl_ort INNER JOIN tbl_adressen ON tbl_ort.[id] = tbl_adressen.[id_ort]"

            Try
                con.Open()
                reader = cmd.ExecuteReader()
                listBoxAlle.Items.Clear()

                listBoxAlle.Items.Add("Vorname # Nachname # Strasse # PLZ # Ort")

                Do While reader.Read()
                    listBoxAlle.Items.Add(
                        reader("vorname") & " # " &
                        reader("nachname") & " # " &
                        reader("strasse") & " # " &
                        reader("plz") & " # " &
                        reader("ort"))
                Loop
                reader.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub frmDatenZugriff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DBPath <> "" Then

            'Dim connString As String = "Data Source=kunden.db3"
            Dim connString As String = "Data Source=" & My.Settings.DBPath
            Dim conn As New SQLiteConnection(connString)

            Dim strSQL As String = "SELECT * FROM tbl_ort"
            Dim da As New SQLiteDataAdapter(strSQL, conn)
            Dim ds As New DataSet

            da.Fill(ds, "tbl_ort")

            With cmbOrt
                .DataSource = ds.Tables("tbl_ort")
                .DisplayMember = "ort"
                .ValueMember = "id"
                .SelectedIndex = 0

            End With
        End If
    End Sub

    Private Sub btnAuswahl_Click(sender As Object, e As EventArgs) Handles btnAuswahl.Click
        Dim con As New SQLiteConnection
        Dim cmd As New SQLiteCommand
        Dim reader As SQLiteDataReader

        Dim selOrt As String = cmbOrt.Text

        If My.Settings.DBPath <> "" Then

            'con.ConnectionString = "Data Source=kunden.db3"
            con.ConnectionString = "Data Source=" & My.Settings.DBPath

            cmd.Connection = con
            'cmd.CommandText = "SELECT * FROM tbl_adressen where ort = '" & selOrt & "'"
            cmd.CommandText = "SELECT tbl_adressen.vorname, tbl_ort.plz, tbl_ort.ort, tbl_adressen.nachname, tbl_adressen.strasse, tbl_adressen.id_ort FROM tbl_ort INNER JOIN tbl_adressen ON tbl_ort.[id] = tbl_adressen.[id_ort] where tbl_ort.ort = '" & selOrt & "'"

            Try
                con.Open()
                reader = cmd.ExecuteReader()
                ListBoxFilter.Items.Clear()

                ListBoxFilter.Items.Add("Vorname # Nachname # Strasse # PLZ # Ort")

                Do While reader.Read()
                    ListBoxFilter.Items.Add(
                        reader("vorname") & " # " &
                        reader("nachname") & " # " &
                        reader("strasse") & " # " &
                        reader("plz") & " # " &
                        reader("ort"))
                Loop
                reader.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub
End Class
