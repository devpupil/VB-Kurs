<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.btnSteuerElemente = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnWerte = New System.Windows.Forms.Button()
        Me.btnPanelMove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSteuerElemente
        '
        Me.btnSteuerElemente.Location = New System.Drawing.Point(19, 12)
        Me.btnSteuerElemente.Name = "btnSteuerElemente"
        Me.btnSteuerElemente.Size = New System.Drawing.Size(114, 43)
        Me.btnSteuerElemente.TabIndex = 0
        Me.btnSteuerElemente.Text = "Steuerelemente"
        Me.btnSteuerElemente.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(18, 430)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Beenden"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnWerte
        '
        Me.btnWerte.Location = New System.Drawing.Point(20, 65)
        Me.btnWerte.Name = "btnWerte"
        Me.btnWerte.Size = New System.Drawing.Size(112, 40)
        Me.btnWerte.TabIndex = 2
        Me.btnWerte.Text = "Wertebereich"
        Me.btnWerte.UseVisualStyleBackColor = True
        '
        'btnPanelMove
        '
        Me.btnPanelMove.Location = New System.Drawing.Point(20, 111)
        Me.btnPanelMove.Name = "btnPanelMove"
        Me.btnPanelMove.Size = New System.Drawing.Size(112, 47)
        Me.btnPanelMove.TabIndex = 3
        Me.btnPanelMove.Text = "Panel Bewegen"
        Me.btnPanelMove.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(185, 481)
        Me.Controls.Add(Me.btnPanelMove)
        Me.Controls.Add(Me.btnWerte)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSteuerElemente)
        Me.Name = "frmStart"
        Me.Text = "frmStart"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSteuerElemente As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnWerte As System.Windows.Forms.Button
    Friend WithEvents btnPanelMove As System.Windows.Forms.Button
End Class
