<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_hallo = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_hallo
        '
        Me.btn_hallo.Location = New System.Drawing.Point(139, 107)
        Me.btn_hallo.Name = "btn_hallo"
        Me.btn_hallo.Size = New System.Drawing.Size(251, 56)
        Me.btn_hallo.TabIndex = 0
        Me.btn_hallo.Text = "Hallo"
        Me.btn_hallo.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(139, 169)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(251, 73)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "Entfernen"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 509)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_hallo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_hallo As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
