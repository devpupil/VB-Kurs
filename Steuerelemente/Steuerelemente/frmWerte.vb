Public Class frmWerte

    Private Sub frmWerte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Bo As Boolean
        Dim By As Byte
        Dim Ch As Char
        Dim Dt As Date
        Dim Db As Double
        Dim It As Integer
        Dim Lg As Long
        Dim Sh As Short
        Dim Sg As Single
        Dim St As String

        Bo = True
        By = 200
        Ch = "a"
        Dt = "18.12.2012"
        Db = 1 / 7
        It = 2000000000
        Lg = 3000000000
        Sh = 30000
        Sg = 1 / 7
        St = "Zeichenkette"

        lblAnzeige.Text =
           "Boolean: " & Bo & vbCrLf &
           "Byte: " & By & vbCrLf &
           "Char: " & Ch & vbCrLf &
           "Double: " & Db & vbCrLf &
           "Date: " & Dt & vbCrLf &
           "Integer: " & It & vbCrLf &
           "Long: " & Lg & vbCrLf &
           "Short: " & Sh & vbCrLf &
           "Single: " & Sg & vbCrLf &
           "String: " & St
    End Sub
End Class