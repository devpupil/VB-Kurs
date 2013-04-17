<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestFunktion
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
        Me.panButtons = New System.Windows.Forms.Panel()
        Me.panMain = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.panButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'panButtons
        '
        Me.panButtons.AutoSize = True
        Me.panButtons.Controls.Add(Me.Button6)
        Me.panButtons.Controls.Add(Me.Button5)
        Me.panButtons.Controls.Add(Me.Button4)
        Me.panButtons.Controls.Add(Me.Button3)
        Me.panButtons.Controls.Add(Me.Button2)
        Me.panButtons.Controls.Add(Me.Button1)
        Me.panButtons.Location = New System.Drawing.Point(3, 2)
        Me.panButtons.Name = "panButtons"
        Me.panButtons.Size = New System.Drawing.Size(172, 572)
        Me.panButtons.TabIndex = 0
        '
        'panMain
        '
        Me.panMain.AutoSize = True
        Me.panMain.Location = New System.Drawing.Point(178, 2)
        Me.panMain.Name = "panMain"
        Me.panMain.Size = New System.Drawing.Size(657, 571)
        Me.panMain.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 27)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 27)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 156)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 27)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(21, 189)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(138, 27)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmTestFunktion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 573)
        Me.Controls.Add(Me.panMain)
        Me.Controls.Add(Me.panButtons)
        Me.Name = "frmTestFunktion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testfunktionen"
        Me.panButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panButtons As System.Windows.Forms.Panel
    Friend WithEvents panMain As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
