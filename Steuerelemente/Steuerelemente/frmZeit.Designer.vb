<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZeit
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.timAnzeige = New System.Windows.Forms.Timer(Me.components)
        Me.lblAnzeige = New System.Windows.Forms.Label()
        Me.btnTetrisStart = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAnzeige)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 168)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnTetrisStart)
        Me.Panel2.Location = New System.Drawing.Point(9, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 156)
        Me.Panel2.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(27, 117)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(209, 33)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(258, 116)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(217, 33)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'timAnzeige
        '
        Me.timAnzeige.Interval = 500
        '
        'lblAnzeige
        '
        Me.lblAnzeige.AutoSize = True
        Me.lblAnzeige.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnzeige.ForeColor = System.Drawing.Color.Red
        Me.lblAnzeige.Location = New System.Drawing.Point(37, 23)
        Me.lblAnzeige.Name = "lblAnzeige"
        Me.lblAnzeige.Size = New System.Drawing.Size(0, 31)
        Me.lblAnzeige.TabIndex = 2
        '
        'btnTetrisStart
        '
        Me.btnTetrisStart.Location = New System.Drawing.Point(187, 16)
        Me.btnTetrisStart.Name = "btnTetrisStart"
        Me.btnTetrisStart.Size = New System.Drawing.Size(128, 38)
        Me.btnTetrisStart.TabIndex = 0
        Me.btnTetrisStart.Text = "Start Tetris"
        Me.btnTetrisStart.UseVisualStyleBackColor = True
        '
        'frmZeit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 406)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmZeit"
        Me.Text = "Zeittakter"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents timAnzeige As System.Windows.Forms.Timer
    Friend WithEvents lblAnzeige As System.Windows.Forms.Label
    Friend WithEvents btnTetrisStart As System.Windows.Forms.Button
End Class
