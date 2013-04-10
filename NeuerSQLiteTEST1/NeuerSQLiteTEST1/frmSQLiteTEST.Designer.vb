<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLiteTEST
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
        Me.btn_createtable = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_createdb
        '
        Me.btn_createdb.Location = New System.Drawing.Point(18, 17)
        Me.btn_createdb.Name = "btn_createdb"
        Me.btn_createdb.Size = New System.Drawing.Size(187, 61)
        Me.btn_createdb.TabIndex = 0
        Me.btn_createdb.Text = "DB erstellen"
        Me.btn_createdb.UseVisualStyleBackColor = True
        '
        'btn_createtable
        '
        Me.btn_createtable.Location = New System.Drawing.Point(13, 100)
        Me.btn_createtable.Name = "btn_createtable"
        Me.btn_createtable.Size = New System.Drawing.Size(191, 74)
        Me.btn_createtable.TabIndex = 1
        Me.btn_createtable.Text = "Tabellen erstellen"
        Me.btn_createtable.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 76)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Tabelle füllen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmSQLiteTEST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 369)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_createtable)
        Me.Controls.Add(Me.btn_createdb)
        Me.Name = "frmSQLiteTEST"
        Me.Text = "SQLite TEST"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_createdb As System.Windows.Forms.Button
    Friend WithEvents btn_createtable As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
