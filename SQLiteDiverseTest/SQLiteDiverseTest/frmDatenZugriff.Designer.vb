<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatenZugriff
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
        Me.btn_alleKunden = New System.Windows.Forms.Button()
        Me.listBoxAlle = New System.Windows.Forms.ListBox()
        Me.cmbOrt = New System.Windows.Forms.ComboBox()
        Me.btnAuswahl = New System.Windows.Forms.Button()
        Me.ListBoxFilter = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_alleKunden
        '
        Me.btn_alleKunden.Location = New System.Drawing.Point(21, 30)
        Me.btn_alleKunden.Name = "btn_alleKunden"
        Me.btn_alleKunden.Size = New System.Drawing.Size(251, 50)
        Me.btn_alleKunden.TabIndex = 0
        Me.btn_alleKunden.Text = "Alle anzeigen"
        Me.btn_alleKunden.UseVisualStyleBackColor = True
        '
        'listBoxAlle
        '
        Me.listBoxAlle.FormattingEnabled = True
        Me.listBoxAlle.Location = New System.Drawing.Point(19, 103)
        Me.listBoxAlle.Name = "listBoxAlle"
        Me.listBoxAlle.Size = New System.Drawing.Size(253, 147)
        Me.listBoxAlle.TabIndex = 1
        '
        'cmbOrt
        '
        Me.cmbOrt.FormattingEnabled = True
        Me.cmbOrt.Location = New System.Drawing.Point(293, 36)
        Me.cmbOrt.Name = "cmbOrt"
        Me.cmbOrt.Size = New System.Drawing.Size(232, 21)
        Me.cmbOrt.TabIndex = 2
        '
        'btnAuswahl
        '
        Me.btnAuswahl.Location = New System.Drawing.Point(296, 79)
        Me.btnAuswahl.Name = "btnAuswahl"
        Me.btnAuswahl.Size = New System.Drawing.Size(194, 45)
        Me.btnAuswahl.TabIndex = 3
        Me.btnAuswahl.Text = "Kunden nach Ort"
        Me.btnAuswahl.UseVisualStyleBackColor = True
        '
        'ListBoxFilter
        '
        Me.ListBoxFilter.FormattingEnabled = True
        Me.ListBoxFilter.Location = New System.Drawing.Point(295, 153)
        Me.ListBoxFilter.Name = "ListBoxFilter"
        Me.ListBoxFilter.Size = New System.Drawing.Size(229, 95)
        Me.ListBoxFilter.TabIndex = 4
        '
        'frmDatenZugriff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 462)
        Me.Controls.Add(Me.ListBoxFilter)
        Me.Controls.Add(Me.btnAuswahl)
        Me.Controls.Add(Me.cmbOrt)
        Me.Controls.Add(Me.listBoxAlle)
        Me.Controls.Add(Me.btn_alleKunden)
        Me.Name = "frmDatenZugriff"
        Me.Text = "Daten Zugriff"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_alleKunden As System.Windows.Forms.Button
    Friend WithEvents listBoxAlle As System.Windows.Forms.ListBox
    Friend WithEvents cmbOrt As System.Windows.Forms.ComboBox
    Friend WithEvents btnAuswahl As System.Windows.Forms.Button
    Friend WithEvents ListBoxFilter As System.Windows.Forms.ListBox

End Class
