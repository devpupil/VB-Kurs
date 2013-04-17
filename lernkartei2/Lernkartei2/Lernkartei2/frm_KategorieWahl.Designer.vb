<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_KategorieWahl
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
        Dim KategorieBeschreibungLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AbfAktiveKatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lernkartei2DataSet = New Lernkartei2.lernkartei2DataSet()
        Me.Abf_AktiveKatTableAdapter = New Lernkartei2.lernkartei2DataSetTableAdapters.Abf_AktiveKatTableAdapter()
        Me.TableAdapterManager = New Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager()
        Me.KategorieBeschreibungLabel1 = New System.Windows.Forms.Label()
        KategorieBeschreibungLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AbfAktiveKatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lernkartei2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KategorieBeschreibungLabel
        '
        KategorieBeschreibungLabel.AutoSize = True
        KategorieBeschreibungLabel.Location = New System.Drawing.Point(36, 82)
        KategorieBeschreibungLabel.Name = "KategorieBeschreibungLabel"
        KategorieBeschreibungLabel.Size = New System.Drawing.Size(0, 13)
        KategorieBeschreibungLabel.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(126, 206)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bitte gwünschtes Thema auswählen"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.AbfAktiveKatBindingSource
        Me.ComboBox1.DisplayMember = "kategorieName"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(33, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "cat_id"
        '
        'AbfAktiveKatBindingSource
        '
        Me.AbfAktiveKatBindingSource.DataMember = "Abf_AktiveKat"
        Me.AbfAktiveKatBindingSource.DataSource = Me.Lernkartei2DataSet
        '
        'Lernkartei2DataSet
        '
        Me.Lernkartei2DataSet.DataSetName = "lernkartei2DataSet"
        Me.Lernkartei2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Abf_AktiveKatTableAdapter
        '
        Me.Abf_AktiveKatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_FragenTableAdapter = Nothing
        Me.TableAdapterManager.tbl_kategorieTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KategorieBeschreibungLabel1
        '
        Me.KategorieBeschreibungLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbfAktiveKatBindingSource, "kategorieBeschreibung", True))
        Me.KategorieBeschreibungLabel1.Location = New System.Drawing.Point(36, 82)
        Me.KategorieBeschreibungLabel1.Name = "KategorieBeschreibungLabel1"
        Me.KategorieBeschreibungLabel1.Size = New System.Drawing.Size(100, 23)
        Me.KategorieBeschreibungLabel1.TabIndex = 4
        Me.KategorieBeschreibungLabel1.Text = "Label2"
        '
        'frm_KategorieWahl
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(284, 247)
        Me.Controls.Add(KategorieBeschreibungLabel)
        Me.Controls.Add(Me.KategorieBeschreibungLabel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_KategorieWahl"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kategorie wählen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AbfAktiveKatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lernkartei2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Lernkartei2DataSet As Lernkartei2.lernkartei2DataSet
    Friend WithEvents AbfAktiveKatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Abf_AktiveKatTableAdapter As Lernkartei2.lernkartei2DataSetTableAdapters.Abf_AktiveKatTableAdapter
    Friend WithEvents TableAdapterManager As Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents KategorieBeschreibungLabel1 As System.Windows.Forms.Label

End Class
