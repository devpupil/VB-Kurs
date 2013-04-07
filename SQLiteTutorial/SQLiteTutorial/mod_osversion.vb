Module mod_osversion
    Public Function GetOSVersion() As String
        Select Case Environment.OSVersion.Platform
            Case PlatformID.Win32NT
                Select Case Environment.OSVersion.Version.Major
                    Case 5
                        Select Case Environment.OSVersion.Version.Minor
                            Case 0
                                Return "Windows 2000"
                            Case 1
                                Return "Windows XP"
                            Case 2
                                Return "Windows 2003"
                        End Select
                    Case 6
                        Select Case Environment.OSVersion.Version.Minor
                            Case 0
                                Return "Windows Vista/Windows 2008 Server"
                            Case 1
                                Return "Windows 7"
                        End Select
                End Select
            Case PlatformID.Unix
                Return "Linux"
            Case Else
                Return "Unbekannt"
        End Select
        Return vbNullString
    End Function
End Module
