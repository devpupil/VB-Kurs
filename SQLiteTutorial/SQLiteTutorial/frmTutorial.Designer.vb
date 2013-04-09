<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorial
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_createdb = New System.Windows.Forms.Button()
        Me.btn_createtables = New System.Windows.Forms.Button()
        Me.btn_osversion = New System.Windows.Forms.Button()
        Me.btn_dbtest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_createdb
        '
        Me.btn_createdb.Location = New System.Drawing.Point(62, 12)
        Me.btn_createdb.Name = "btn_createdb"
        Me.btn_createdb.Size = New System.Drawing.Size(247, 88)
        Me.btn_createdb.TabIndex = 0
        Me.btn_createdb.Text = "Datenbank erstellen"
        Me.btn_createdb.UseVisualStyleBackColor = True
        '
        'btn_createtables
        '
        Me.btn_createtables.Location = New System.Drawing.Point(61, 121)
        Me.btn_createtables.Name = "btn_createtables"
        Me.btn_createtables.Size = New System.Drawing.Size(248, 87)
        Me.btn_createtables.TabIndex = 1
        Me.btn_createtables.Text = "Tabellen anlegen"
        Me.btn_createtables.UseVisualStyleBackColor = True
        '
        'btn_osversion
        '
        Me.btn_osversion.Location = New System.Drawing.Point(64, 233)
        Me.btn_osversion.Name = "btn_osversion"
        Me.btn_osversion.Size = New System.Drawing.Size(244, 83)
        Me.btn_osversion.TabIndex = 2
        Me.btn_osversion.Text = "OS Version"
        Me.btn_osversion.UseVisualStyleBackColor = True
        '
        'btn_dbtest
        '
        Me.btn_dbtest.Location = New System.Drawing.Point(361, 12)
        Me.btn_dbtest.Name = "btn_dbtest"
        Me.btn_dbtest.Size = New System.Drawing.Size(180, 87)
        Me.btn_dbtest.TabIndex = 3
        Me.btn_dbtest.Text = "Datenbanktest"
        Me.btn_dbtest.UseVisualStyleBackColor = True
        '
        'frmTutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 390)
        Me.Controls.Add(Me.btn_dbtest)
        Me.Controls.Add(Me.btn_osversion)
        Me.Controls.Add(Me.btn_createtables)
        Me.Controls.Add(Me.btn_createdb)
        Me.Name = "frmTutorial"
        Me.Text = "SQLite Tutorial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_createdb As System.Windows.Forms.Button
    Friend WithEvents btn_createtables As System.Windows.Forms.Button
    Friend WithEvents btn_osversion As System.Windows.Forms.Button
    Friend WithEvents btn_dbtest As System.Windows.Forms.Button

End Class
