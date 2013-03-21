<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanel
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
        Me.btnOben = New System.Windows.Forms.Button()
        Me.btnUnten = New System.Windows.Forms.Button()
        Me.btnLinks = New System.Windows.Forms.Button()
        Me.btnRechts = New System.Windows.Forms.Button()
        Me.panMove = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOben
        '
        Me.btnOben.Location = New System.Drawing.Point(244, 26)
        Me.btnOben.Name = "btnOben"
        Me.btnOben.Size = New System.Drawing.Size(138, 54)
        Me.btnOben.TabIndex = 0
        Me.btnOben.Text = "nach oben"
        Me.btnOben.UseVisualStyleBackColor = True
        '
        'btnUnten
        '
        Me.btnUnten.Location = New System.Drawing.Point(244, 404)
        Me.btnUnten.Name = "btnUnten"
        Me.btnUnten.Size = New System.Drawing.Size(138, 54)
        Me.btnUnten.TabIndex = 1
        Me.btnUnten.Text = "nach unten"
        Me.btnUnten.UseVisualStyleBackColor = True
        '
        'btnLinks
        '
        Me.btnLinks.Location = New System.Drawing.Point(20, 217)
        Me.btnLinks.Name = "btnLinks"
        Me.btnLinks.Size = New System.Drawing.Size(138, 54)
        Me.btnLinks.TabIndex = 2
        Me.btnLinks.Text = "nach Links"
        Me.btnLinks.UseVisualStyleBackColor = True
        '
        'btnRechts
        '
        Me.btnRechts.Location = New System.Drawing.Point(472, 217)
        Me.btnRechts.Name = "btnRechts"
        Me.btnRechts.Size = New System.Drawing.Size(138, 54)
        Me.btnRechts.TabIndex = 3
        Me.btnRechts.Text = "nach rechts"
        Me.btnRechts.UseVisualStyleBackColor = True
        '
        'panMove
        '
        Me.panMove.BackColor = System.Drawing.Color.Red
        Me.panMove.Location = New System.Drawing.Point(221, 171)
        Me.panMove.Name = "panMove"
        Me.panMove.Size = New System.Drawing.Size(184, 169)
        Me.panMove.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSource, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(446, 503)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(214, 43)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(3, 3)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(68, 31)
        Me.btnSource.TabIndex = 0
        Me.btnSource.Text = "Source"
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(110, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 32)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Beenden"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 553)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.panMove)
        Me.Controls.Add(Me.btnRechts)
        Me.Controls.Add(Me.btnLinks)
        Me.Controls.Add(Me.btnUnten)
        Me.Controls.Add(Me.btnOben)
        Me.Name = "frmPanel"
        Me.Text = "Panel bewegen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOben As System.Windows.Forms.Button
    Friend WithEvents btnUnten As System.Windows.Forms.Button
    Friend WithEvents btnLinks As System.Windows.Forms.Button
    Friend WithEvents btnRechts As System.Windows.Forms.Button
    Friend WithEvents panMove As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSource As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
