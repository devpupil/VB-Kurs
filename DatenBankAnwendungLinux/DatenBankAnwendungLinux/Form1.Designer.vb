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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NachnameLabel As System.Windows.Forms.Label
        Dim StrasseLabel As System.Windows.Forms.Label
        Dim PlzLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Me.AdressenDataSet = New WindowsApplication1.AdressenDataSet()
        Me.Tbl_adressenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_adressenTableAdapter = New WindowsApplication1.AdressenDataSetTableAdapters.tbl_adressenTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AdressenDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_adressenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_adressenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.NachnameTextBox = New System.Windows.Forms.TextBox()
        Me.StrasseTextBox = New System.Windows.Forms.TextBox()
        Me.PlzTextBox = New System.Windows.Forms.TextBox()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NachnameLabel = New System.Windows.Forms.Label()
        StrasseLabel = New System.Windows.Forms.Label()
        PlzLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        CType(Me.AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_adressenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_adressenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_adressenBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdressenDataSet
        '
        Me.AdressenDataSet.DataSetName = "AdressenDataSet"
        Me.AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_adressenBindingSource
        '
        Me.Tbl_adressenBindingSource.DataMember = "tbl_adressen"
        Me.Tbl_adressenBindingSource.DataSource = Me.AdressenDataSet
        '
        'Tbl_adressenTableAdapter
        '
        Me.Tbl_adressenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_adressenTableAdapter = Me.Tbl_adressenTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_adressenBindingNavigator
        '
        Me.Tbl_adressenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_adressenBindingNavigator.BindingSource = Me.Tbl_adressenBindingSource
        Me.Tbl_adressenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_adressenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_adressenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_adressenBindingNavigatorSaveItem})
        Me.Tbl_adressenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_adressenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_adressenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_adressenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_adressenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_adressenBindingNavigator.Name = "Tbl_adressenBindingNavigator"
        Me.Tbl_adressenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_adressenBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Tbl_adressenBindingNavigator.TabIndex = 0
        Me.Tbl_adressenBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 15)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'Tbl_adressenBindingNavigatorSaveItem
        '
        Me.Tbl_adressenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_adressenBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_adressenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_adressenBindingNavigatorSaveItem.Name = "Tbl_adressenBindingNavigatorSaveItem"
        Me.Tbl_adressenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tbl_adressenBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(29, 37)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adressenBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 34)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(29, 63)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(43, 13)
        AnredeLabel.TabIndex = 3
        AnredeLabel.Text = "anrede:"
        '
        'AnredeTextBox
        '
        Me.AnredeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adressenBindingSource, "anrede", True))
        Me.AnredeTextBox.Location = New System.Drawing.Point(97, 60)
        Me.AnredeTextBox.Name = "AnredeTextBox"
        Me.AnredeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnredeTextBox.TabIndex = 4
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(29, 89)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(52, 13)
        VornameLabel.TabIndex = 5
        VornameLabel.Text = "Vorname:"
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adressenBindingSource, "Vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(97, 86)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VornameTextBox.TabIndex = 6
        '
        'NachnameLabel
        '
        NachnameLabel.AutoSize = True
        NachnameLabel.Location = New System.Drawing.Point(29, 115)
        NachnameLabel.Name = "NachnameLabel"
        NachnameLabel.Size = New System.Drawing.Size(62, 13)
        NachnameLabel.TabIndex = 7
        NachnameLabel.Text = "Nachname:"
        '
        'NachnameTextBox
        '
        Me.NachnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adressenBindingSource, "Nachname", True))
        Me.NachnameTextBox.Location = New System.Drawing.Point(97, 112)
        Me.NachnameTextBox.Name = "NachnameTextBox"
        Me.NachnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NachnameTextBox.TabIndex = 8
        '
        'StrasseLabel
        '
        StrasseLabel.AutoSize = True
        StrasseLabel.Location = New System.Drawing.Point(29, 141)
        StrasseLabel.Name = "StrasseLabel"
        StrasseLabel.Size = New System.Drawing.Size(43, 13)
        StrasseLabel.TabIndex = 9
        StrasseLabel.Text = "strasse:"
        '
        'StrasseTextBox
        '
        Me.StrasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adressenBindingSource, "strasse", True))
        Me.StrasseTextBox.Location = New System.Drawing.Point(97, 138)
        Me.StrasseTextBox.Name = "StrasseTextBox"
        Me.StrasseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StrasseTextBox.TabIndex = 10
        '
        'PlzLabel
        '
        PlzLabel.AutoSize = True
        PlzLabel.Location = New System.Drawing.Point(29, 167)
        PlzLabel.Name = "PlzLabel"
        PlzLabel.Size = New System.Drawing.Size(23, 13)
        PlzLabel.TabIndex = 11
        PlzLabel.Text = "plz:"
        '
        'PlzTextBox
        '
        Me.PlzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adressenBindingSource, "plz", True))
        Me.PlzTextBox.Location = New System.Drawing.Point(97, 164)
        Me.PlzTextBox.Name = "PlzTextBox"
        Me.PlzTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlzTextBox.TabIndex = 12
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(29, 193)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(22, 13)
        OrtLabel.TabIndex = 13
        OrtLabel.Text = "ort:"
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adressenBindingSource, "ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(97, 190)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrtTextBox.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(AnredeLabel)
        Me.Controls.Add(Me.AnredeTextBox)
        Me.Controls.Add(VornameLabel)
        Me.Controls.Add(Me.VornameTextBox)
        Me.Controls.Add(NachnameLabel)
        Me.Controls.Add(Me.NachnameTextBox)
        Me.Controls.Add(StrasseLabel)
        Me.Controls.Add(Me.StrasseTextBox)
        Me.Controls.Add(PlzLabel)
        Me.Controls.Add(Me.PlzTextBox)
        Me.Controls.Add(OrtLabel)
        Me.Controls.Add(Me.OrtTextBox)
        Me.Controls.Add(Me.Tbl_adressenBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_adressenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_adressenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_adressenBindingNavigator.ResumeLayout(False)
        Me.Tbl_adressenBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdressenDataSet As WindowsApplication1.AdressenDataSet
    Friend WithEvents Tbl_adressenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_adressenTableAdapter As WindowsApplication1.AdressenDataSetTableAdapters.tbl_adressenTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_adressenBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_adressenBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnredeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VornameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NachnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrtTextBox As System.Windows.Forms.TextBox

End Class
