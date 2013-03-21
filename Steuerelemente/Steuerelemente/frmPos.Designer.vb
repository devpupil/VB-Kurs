<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPos
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
        Me.btnPositionRel = New System.Windows.Forms.Button()
        Me.btnPositionAbs = New System.Windows.Forms.Button()
        Me.btnGrößeRel = New System.Windows.Forms.Button()
        Me.btnGrößeAbs = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnAnzeige = New System.Windows.Forms.Button()
        Me.lblAnzeige = New System.Windows.Forms.Label()
        Me.btnFarbe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPositionRel
        '
        Me.btnPositionRel.Location = New System.Drawing.Point(21, 28)
        Me.btnPositionRel.Name = "btnPositionRel"
        Me.btnPositionRel.Size = New System.Drawing.Size(163, 47)
        Me.btnPositionRel.TabIndex = 0
        Me.btnPositionRel.Text = "Position Rel"
        Me.btnPositionRel.UseVisualStyleBackColor = True
        '
        'btnPositionAbs
        '
        Me.btnPositionAbs.Location = New System.Drawing.Point(247, 36)
        Me.btnPositionAbs.Name = "btnPositionAbs"
        Me.btnPositionAbs.Size = New System.Drawing.Size(163, 47)
        Me.btnPositionAbs.TabIndex = 1
        Me.btnPositionAbs.Text = "Position Abs"
        Me.btnPositionAbs.UseVisualStyleBackColor = True
        '
        'btnGrößeRel
        '
        Me.btnGrößeRel.Location = New System.Drawing.Point(21, 123)
        Me.btnGrößeRel.Name = "btnGrößeRel"
        Me.btnGrößeRel.Size = New System.Drawing.Size(163, 47)
        Me.btnGrößeRel.TabIndex = 2
        Me.btnGrößeRel.Text = "Größe Rel"
        Me.btnGrößeRel.UseVisualStyleBackColor = True
        '
        'btnGrößeAbs
        '
        Me.btnGrößeAbs.Location = New System.Drawing.Point(247, 123)
        Me.btnGrößeAbs.Name = "btnGrößeAbs"
        Me.btnGrößeAbs.Size = New System.Drawing.Size(163, 47)
        Me.btnGrößeAbs.TabIndex = 3
        Me.btnGrößeAbs.Text = "Größe Abs"
        Me.btnGrößeAbs.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(21, 277)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(141, 52)
        Me.btnTest.TabIndex = 4
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnAnzeige
        '
        Me.btnAnzeige.Location = New System.Drawing.Point(268, 301)
        Me.btnAnzeige.Name = "btnAnzeige"
        Me.btnAnzeige.Size = New System.Drawing.Size(142, 36)
        Me.btnAnzeige.TabIndex = 5
        Me.btnAnzeige.Text = "Anzeige"
        Me.btnAnzeige.UseVisualStyleBackColor = True
        '
        'lblAnzeige
        '
        Me.lblAnzeige.AutoSize = True
        Me.lblAnzeige.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnzeige.Location = New System.Drawing.Point(59, 195)
        Me.lblAnzeige.Name = "lblAnzeige"
        Me.lblAnzeige.Size = New System.Drawing.Size(0, 25)
        Me.lblAnzeige.TabIndex = 6
        '
        'btnFarbe
        '
        Me.btnFarbe.Location = New System.Drawing.Point(266, 251)
        Me.btnFarbe.Name = "btnFarbe"
        Me.btnFarbe.Size = New System.Drawing.Size(143, 42)
        Me.btnFarbe.TabIndex = 7
        Me.btnFarbe.Text = "Farbe"
        Me.btnFarbe.UseVisualStyleBackColor = True
        '
        'frmPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 341)
        Me.Controls.Add(Me.btnFarbe)
        Me.Controls.Add(Me.lblAnzeige)
        Me.Controls.Add(Me.btnAnzeige)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnGrößeAbs)
        Me.Controls.Add(Me.btnGrößeRel)
        Me.Controls.Add(Me.btnPositionAbs)
        Me.Controls.Add(Me.btnPositionRel)
        Me.Name = "frmPos"
        Me.Text = "Position, Größe, Farbe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPositionRel As System.Windows.Forms.Button
    Friend WithEvents btnPositionAbs As System.Windows.Forms.Button
    Friend WithEvents btnGrößeRel As System.Windows.Forms.Button
    Friend WithEvents btnGrößeAbs As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnAnzeige As System.Windows.Forms.Button
    Friend WithEvents lblAnzeige As System.Windows.Forms.Label
    Friend WithEvents btnFarbe As System.Windows.Forms.Button

End Class
