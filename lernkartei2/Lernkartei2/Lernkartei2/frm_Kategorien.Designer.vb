<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Kategorien
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim KategorieNameLabel As System.Windows.Forms.Label
        Dim KategorieBeschreibungLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Kategorien))
        Me.Lernkartei2DataSet = New Lernkartei2.lernkartei2DataSet()
        Me.Tbl_kategorieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_kategorieTableAdapter = New Lernkartei2.lernkartei2DataSetTableAdapters.tbl_kategorieTableAdapter()
        Me.TableAdapterManager = New Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_kategorieBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_kategorieBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.KategorieNameTextBox = New System.Windows.Forms.TextBox()
        Me.KategorieBeschreibungTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        KategorieNameLabel = New System.Windows.Forms.Label()
        KategorieBeschreibungLabel = New System.Windows.Forms.Label()
        CType(Me.Lernkartei2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_kategorieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_kategorieBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_kategorieBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(19, 46)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'KategorieNameLabel
        '
        KategorieNameLabel.AutoSize = True
        KategorieNameLabel.Location = New System.Drawing.Point(19, 72)
        KategorieNameLabel.Name = "KategorieNameLabel"
        KategorieNameLabel.Size = New System.Drawing.Size(85, 13)
        KategorieNameLabel.TabIndex = 3
        KategorieNameLabel.Text = "kategorie Name:"
        '
        'KategorieBeschreibungLabel
        '
        KategorieBeschreibungLabel.AutoSize = True
        KategorieBeschreibungLabel.Location = New System.Drawing.Point(19, 98)
        KategorieBeschreibungLabel.Name = "KategorieBeschreibungLabel"
        KategorieBeschreibungLabel.Size = New System.Drawing.Size(122, 13)
        KategorieBeschreibungLabel.TabIndex = 5
        KategorieBeschreibungLabel.Text = "kategorie Beschreibung:"
        '
        'Lernkartei2DataSet
        '
        Me.Lernkartei2DataSet.DataSetName = "lernkartei2DataSet"
        Me.Lernkartei2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_kategorieBindingSource
        '
        Me.Tbl_kategorieBindingSource.DataMember = "tbl_kategorie"
        Me.Tbl_kategorieBindingSource.DataSource = Me.Lernkartei2DataSet
        '
        'Tbl_kategorieTableAdapter
        '
        Me.Tbl_kategorieTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_FragenTableAdapter = Nothing
        Me.TableAdapterManager.tbl_kategorieTableAdapter = Me.Tbl_kategorieTableAdapter
        Me.TableAdapterManager.UpdateOrder = Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_kategorieBindingNavigator
        '
        Me.Tbl_kategorieBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_kategorieBindingNavigator.BindingSource = Me.Tbl_kategorieBindingSource
        Me.Tbl_kategorieBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_kategorieBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_kategorieBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_kategorieBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Tbl_kategorieBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_kategorieBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_kategorieBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_kategorieBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_kategorieBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_kategorieBindingNavigator.Name = "Tbl_kategorieBindingNavigator"
        Me.Tbl_kategorieBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_kategorieBindingNavigator.Size = New System.Drawing.Size(499, 25)
        Me.Tbl_kategorieBindingNavigator.TabIndex = 0
        Me.Tbl_kategorieBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_kategorieBindingNavigatorSaveItem
        '
        Me.Tbl_kategorieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_kategorieBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_kategorieBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_kategorieBindingNavigatorSaveItem.Name = "Tbl_kategorieBindingNavigatorSaveItem"
        Me.Tbl_kategorieBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_kategorieBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_kategorieBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(46, 43)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(25, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'KategorieNameTextBox
        '
        Me.KategorieNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_kategorieBindingSource, "kategorieName", True))
        Me.KategorieNameTextBox.Location = New System.Drawing.Point(147, 69)
        Me.KategorieNameTextBox.Name = "KategorieNameTextBox"
        Me.KategorieNameTextBox.Size = New System.Drawing.Size(300, 20)
        Me.KategorieNameTextBox.TabIndex = 4
        '
        'KategorieBeschreibungTextBox
        '
        Me.KategorieBeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_kategorieBindingSource, "kategorieBeschreibung", True))
        Me.KategorieBeschreibungTextBox.Location = New System.Drawing.Point(147, 95)
        Me.KategorieBeschreibungTextBox.Multiline = True
        Me.KategorieBeschreibungTextBox.Name = "KategorieBeschreibungTextBox"
        Me.KategorieBeschreibungTextBox.Size = New System.Drawing.Size(300, 81)
        Me.KategorieBeschreibungTextBox.TabIndex = 6
        '
        'frm_Kategorien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(499, 276)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(KategorieNameLabel)
        Me.Controls.Add(Me.KategorieNameTextBox)
        Me.Controls.Add(KategorieBeschreibungLabel)
        Me.Controls.Add(Me.KategorieBeschreibungTextBox)
        Me.Controls.Add(Me.Tbl_kategorieBindingNavigator)
        Me.Name = "frm_Kategorien"
        Me.Text = "Kategorien erfassen"
        CType(Me.Lernkartei2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_kategorieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_kategorieBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_kategorieBindingNavigator.ResumeLayout(False)
        Me.Tbl_kategorieBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lernkartei2DataSet As Lernkartei2.lernkartei2DataSet
    Friend WithEvents Tbl_kategorieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_kategorieTableAdapter As Lernkartei2.lernkartei2DataSetTableAdapters.tbl_kategorieTableAdapter
    Friend WithEvents TableAdapterManager As Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_kategorieBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_kategorieBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KategorieNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KategorieBeschreibungTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
