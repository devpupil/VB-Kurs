<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_database
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
        Me.lbl_databaseCurrent = New System.Windows.Forms.Label()
        Me.btn_changeDB = New System.Windows.Forms.Button()
        Me.lstTables = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbl_databaseCurrent
        '
        Me.lbl_databaseCurrent.AutoSize = True
        Me.lbl_databaseCurrent.Location = New System.Drawing.Point(188, 32)
        Me.lbl_databaseCurrent.Name = "lbl_databaseCurrent"
        Me.lbl_databaseCurrent.Size = New System.Drawing.Size(291, 13)
        Me.lbl_databaseCurrent.TabIndex = 1
        Me.lbl_databaseCurrent.Text = "Datenbankpfad                                                                    " & _
    "  "
        '
        'btn_changeDB
        '
        Me.btn_changeDB.Location = New System.Drawing.Point(29, 25)
        Me.btn_changeDB.Name = "btn_changeDB"
        Me.btn_changeDB.Size = New System.Drawing.Size(130, 26)
        Me.btn_changeDB.TabIndex = 2
        Me.btn_changeDB.Text = "Datenbank auwählen"
        Me.btn_changeDB.UseVisualStyleBackColor = True
        '
        'lstTables
        '
        Me.lstTables.FormattingEnabled = True
        Me.lstTables.Location = New System.Drawing.Point(29, 57)
        Me.lstTables.Name = "lstTables"
        Me.lstTables.Size = New System.Drawing.Size(643, 56)
        Me.lstTables.TabIndex = 3
        '
        'frm_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 696)
        Me.Controls.Add(Me.lstTables)
        Me.Controls.Add(Me.btn_changeDB)
        Me.Controls.Add(Me.lbl_databaseCurrent)
        Me.Name = "frm_database"
        Me.Text = "frm_database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_databaseCurrent As System.Windows.Forms.Label
    Friend WithEvents btn_changeDB As System.Windows.Forms.Button
    Friend WithEvents lstTables As System.Windows.Forms.ListBox
End Class
