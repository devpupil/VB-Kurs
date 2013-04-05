<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SQLiteTest
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
        Me.btn_createDB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_createDB
        '
        Me.btn_createDB.Location = New System.Drawing.Point(15, 14)
        Me.btn_createDB.Name = "btn_createDB"
        Me.btn_createDB.Size = New System.Drawing.Size(117, 37)
        Me.btn_createDB.TabIndex = 0
        Me.btn_createDB.Text = "Datenbank erstellen"
        Me.btn_createDB.UseVisualStyleBackColor = True
        '
        'frm_SQLiteTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_createDB)
        Me.Name = "frm_SQLiteTest"
        Me.Text = "SQLiteTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_createDB As System.Windows.Forms.Button

End Class
