<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWerte
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
        Me.lblAnzeige = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAnzeige
        '
        Me.lblAnzeige.AutoSize = True
        Me.lblAnzeige.Location = New System.Drawing.Point(19, 11)
        Me.lblAnzeige.Name = "lblAnzeige"
        Me.lblAnzeige.Size = New System.Drawing.Size(0, 13)
        Me.lblAnzeige.TabIndex = 0
        '
        'frmWerte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 410)
        Me.Controls.Add(Me.lblAnzeige)
        Me.Name = "frmWerte"
        Me.Text = "frmWerte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnzeige As System.Windows.Forms.Label
End Class
