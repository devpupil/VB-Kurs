<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Begruessung
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
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtMessage2 = New System.Windows.Forms.TextBox()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.Blue
        Me.txtMessage.Location = New System.Drawing.Point(-1, 117)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(884, 125)
        Me.txtMessage.TabIndex = 1
        Me.txtMessage.Text = "t"
        Me.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMessage2
        '
        Me.txtMessage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage2.ForeColor = System.Drawing.Color.Red
        Me.txtMessage2.Location = New System.Drawing.Point(167, 248)
        Me.txtMessage2.Multiline = True
        Me.txtMessage2.Name = "txtMessage2"
        Me.txtMessage2.ReadOnly = True
        Me.txtMessage2.Size = New System.Drawing.Size(548, 80)
        Me.txtMessage2.TabIndex = 2
        Me.txtMessage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_text
        '
        Me.lbl_text.AutoSize = True
        Me.lbl_text.Location = New System.Drawing.Point(60, 23)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Size = New System.Drawing.Size(10, 13)
        Me.lbl_text.TabIndex = 3
        Me.lbl_text.Text = "t"
        '
        'frm_Begruessung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 506)
        Me.Controls.Add(Me.lbl_text)
        Me.Controls.Add(Me.txtMessage2)
        Me.Controls.Add(Me.txtMessage)
        Me.Name = "frm_Begruessung"
        Me.Text = "Hinweis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_text As System.Windows.Forms.Label

End Class
