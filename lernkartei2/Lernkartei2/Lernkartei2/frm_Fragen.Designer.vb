<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Fragen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Fragen))
        Dim IDLabel As System.Windows.Forms.Label
        Dim Cat_idLabel As System.Windows.Forms.Label
        Dim FrageLabel As System.Windows.Forms.Label
        Dim AntwortFreiLabel As System.Windows.Forms.Label
        Dim Mc_anwort1Label As System.Windows.Forms.Label
        Dim Mc_anwort2Label As System.Windows.Forms.Label
        Dim Mc_anwort3Label As System.Windows.Forms.Label
        Dim Mc_anwort4Label As System.Windows.Forms.Label
        Dim Mc_anwort5Label As System.Windows.Forms.Label
        Dim PunkteLabel As System.Windows.Forms.Label
        Dim ThemenlinkLabel As System.Windows.Forms.Label
        Me.Lernkartei2DataSet = New Lernkartei2.lernkartei2DataSet()
        Me.Tbl_FragenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_FragenTableAdapter = New Lernkartei2.lernkartei2DataSetTableAdapters.tbl_FragenTableAdapter()
        Me.TableAdapterManager = New Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_FragenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_FragenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Cat_idTextBox = New System.Windows.Forms.TextBox()
        Me.FrageTextBox = New System.Windows.Forms.TextBox()
        Me.AntwortFreiTextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort1TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort2TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort3TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort4TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort5TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_check1CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_check2CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_check3CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_check4CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_check5CheckBox = New System.Windows.Forms.CheckBox()
        Me.PunkteTextBox = New System.Windows.Forms.TextBox()
        Me.ThemenlinkTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        IDLabel = New System.Windows.Forms.Label()
        Cat_idLabel = New System.Windows.Forms.Label()
        FrageLabel = New System.Windows.Forms.Label()
        AntwortFreiLabel = New System.Windows.Forms.Label()
        Mc_anwort1Label = New System.Windows.Forms.Label()
        Mc_anwort2Label = New System.Windows.Forms.Label()
        Mc_anwort3Label = New System.Windows.Forms.Label()
        Mc_anwort4Label = New System.Windows.Forms.Label()
        Mc_anwort5Label = New System.Windows.Forms.Label()
        PunkteLabel = New System.Windows.Forms.Label()
        ThemenlinkLabel = New System.Windows.Forms.Label()
        CType(Me.Lernkartei2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_FragenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_FragenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_FragenBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lernkartei2DataSet
        '
        Me.Lernkartei2DataSet.DataSetName = "lernkartei2DataSet"
        Me.Lernkartei2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_FragenBindingSource
        '
        Me.Tbl_FragenBindingSource.DataMember = "tbl_Fragen"
        Me.Tbl_FragenBindingSource.DataSource = Me.Lernkartei2DataSet
        '
        'Tbl_FragenTableAdapter
        '
        Me.Tbl_FragenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_FragenTableAdapter = Me.Tbl_FragenTableAdapter
        Me.TableAdapterManager.tbl_kategorieTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_FragenBindingNavigator
        '
        Me.Tbl_FragenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_FragenBindingNavigator.BindingSource = Me.Tbl_FragenBindingSource
        Me.Tbl_FragenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_FragenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_FragenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_FragenBindingNavigatorSaveItem})
        Me.Tbl_FragenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_FragenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_FragenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_FragenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_FragenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_FragenBindingNavigator.Name = "Tbl_FragenBindingNavigator"
        Me.Tbl_FragenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_FragenBindingNavigator.Size = New System.Drawing.Size(676, 25)
        Me.Tbl_FragenBindingNavigator.TabIndex = 0
        Me.Tbl_FragenBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_FragenBindingNavigatorSaveItem
        '
        Me.Tbl_FragenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_FragenBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_FragenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_FragenBindingNavigatorSaveItem.Name = "Tbl_FragenBindingNavigatorSaveItem"
        Me.Tbl_FragenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tbl_FragenBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(606, 31)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(633, 24)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(31, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'Cat_idLabel
        '
        Cat_idLabel.AutoSize = True
        Cat_idLabel.Location = New System.Drawing.Point(30, 31)
        Cat_idLabel.Name = "Cat_idLabel"
        Cat_idLabel.Size = New System.Drawing.Size(36, 13)
        Cat_idLabel.TabIndex = 3
        Cat_idLabel.Text = "cat id:"
        '
        'Cat_idTextBox
        '
        Me.Cat_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "cat_id", True))
        Me.Cat_idTextBox.Location = New System.Drawing.Point(64, 28)
        Me.Cat_idTextBox.Name = "Cat_idTextBox"
        Me.Cat_idTextBox.Size = New System.Drawing.Size(29, 20)
        Me.Cat_idTextBox.TabIndex = 4
        '
        'FrageLabel
        '
        FrageLabel.AutoSize = True
        FrageLabel.Location = New System.Drawing.Point(30, 51)
        FrageLabel.Name = "FrageLabel"
        FrageLabel.Size = New System.Drawing.Size(37, 13)
        FrageLabel.TabIndex = 5
        FrageLabel.Text = "Frage:"
        '
        'FrageTextBox
        '
        Me.FrageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "frage", True))
        Me.FrageTextBox.Location = New System.Drawing.Point(114, 48)
        Me.FrageTextBox.Multiline = True
        Me.FrageTextBox.Name = "FrageTextBox"
        Me.FrageTextBox.Size = New System.Drawing.Size(500, 76)
        Me.FrageTextBox.TabIndex = 6
        '
        'AntwortFreiLabel
        '
        AntwortFreiLabel.AutoSize = True
        AntwortFreiLabel.Location = New System.Drawing.Point(30, 133)
        AntwortFreiLabel.Name = "AntwortFreiLabel"
        AntwortFreiLabel.Size = New System.Drawing.Size(65, 13)
        AntwortFreiLabel.TabIndex = 7
        AntwortFreiLabel.Text = "antwort Frei:"
        '
        'AntwortFreiTextBox
        '
        Me.AntwortFreiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "antwortFrei", True))
        Me.AntwortFreiTextBox.Location = New System.Drawing.Point(114, 130)
        Me.AntwortFreiTextBox.Multiline = True
        Me.AntwortFreiTextBox.Name = "AntwortFreiTextBox"
        Me.AntwortFreiTextBox.Size = New System.Drawing.Size(500, 105)
        Me.AntwortFreiTextBox.TabIndex = 8
        '
        'Mc_anwort1Label
        '
        Mc_anwort1Label.AutoSize = True
        Mc_anwort1Label.Location = New System.Drawing.Point(3, 39)
        Mc_anwort1Label.Name = "Mc_anwort1Label"
        Mc_anwort1Label.Size = New System.Drawing.Size(65, 13)
        Mc_anwort1Label.TabIndex = 11
        Mc_anwort1Label.Text = "mc anwort1:"
        '
        'Mc_anwort1TextBox
        '
        Me.Mc_anwort1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "mc_anwort1", True))
        Me.Mc_anwort1TextBox.Location = New System.Drawing.Point(213, 42)
        Me.Mc_anwort1TextBox.Multiline = True
        Me.Mc_anwort1TextBox.Name = "Mc_anwort1TextBox"
        Me.Mc_anwort1TextBox.Size = New System.Drawing.Size(368, 33)
        Me.Mc_anwort1TextBox.TabIndex = 12
        '
        'Mc_anwort2Label
        '
        Mc_anwort2Label.AutoSize = True
        Mc_anwort2Label.Location = New System.Drawing.Point(3, 78)
        Mc_anwort2Label.Name = "Mc_anwort2Label"
        Mc_anwort2Label.Size = New System.Drawing.Size(65, 13)
        Mc_anwort2Label.TabIndex = 13
        Mc_anwort2Label.Text = "mc anwort2:"
        '
        'Mc_anwort2TextBox
        '
        Me.Mc_anwort2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "mc_anwort2", True))
        Me.Mc_anwort2TextBox.Location = New System.Drawing.Point(213, 81)
        Me.Mc_anwort2TextBox.Multiline = True
        Me.Mc_anwort2TextBox.Name = "Mc_anwort2TextBox"
        Me.Mc_anwort2TextBox.Size = New System.Drawing.Size(368, 33)
        Me.Mc_anwort2TextBox.TabIndex = 14
        '
        'Mc_anwort3Label
        '
        Mc_anwort3Label.AutoSize = True
        Mc_anwort3Label.Location = New System.Drawing.Point(3, 117)
        Mc_anwort3Label.Name = "Mc_anwort3Label"
        Mc_anwort3Label.Size = New System.Drawing.Size(65, 13)
        Mc_anwort3Label.TabIndex = 15
        Mc_anwort3Label.Text = "mc anwort3:"
        '
        'Mc_anwort3TextBox
        '
        Me.Mc_anwort3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "mc_anwort3", True))
        Me.Mc_anwort3TextBox.Location = New System.Drawing.Point(213, 120)
        Me.Mc_anwort3TextBox.Multiline = True
        Me.Mc_anwort3TextBox.Name = "Mc_anwort3TextBox"
        Me.Mc_anwort3TextBox.Size = New System.Drawing.Size(368, 33)
        Me.Mc_anwort3TextBox.TabIndex = 16
        '
        'Mc_anwort4Label
        '
        Mc_anwort4Label.AutoSize = True
        Mc_anwort4Label.Location = New System.Drawing.Point(3, 156)
        Mc_anwort4Label.Name = "Mc_anwort4Label"
        Mc_anwort4Label.Size = New System.Drawing.Size(65, 13)
        Mc_anwort4Label.TabIndex = 17
        Mc_anwort4Label.Text = "mc anwort4:"
        '
        'Mc_anwort4TextBox
        '
        Me.Mc_anwort4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "mc_anwort4", True))
        Me.Mc_anwort4TextBox.Location = New System.Drawing.Point(213, 159)
        Me.Mc_anwort4TextBox.Multiline = True
        Me.Mc_anwort4TextBox.Name = "Mc_anwort4TextBox"
        Me.Mc_anwort4TextBox.Size = New System.Drawing.Size(368, 33)
        Me.Mc_anwort4TextBox.TabIndex = 18
        '
        'Mc_anwort5Label
        '
        Mc_anwort5Label.AutoSize = True
        Mc_anwort5Label.Location = New System.Drawing.Point(3, 195)
        Mc_anwort5Label.Name = "Mc_anwort5Label"
        Mc_anwort5Label.Size = New System.Drawing.Size(65, 13)
        Mc_anwort5Label.TabIndex = 19
        Mc_anwort5Label.Text = "mc anwort5:"
        '
        'Mc_anwort5TextBox
        '
        Me.Mc_anwort5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "mc_anwort5", True))
        Me.Mc_anwort5TextBox.Location = New System.Drawing.Point(213, 198)
        Me.Mc_anwort5TextBox.Multiline = True
        Me.Mc_anwort5TextBox.Name = "Mc_anwort5TextBox"
        Me.Mc_anwort5TextBox.Size = New System.Drawing.Size(368, 33)
        Me.Mc_anwort5TextBox.TabIndex = 20
        '
        'Mc_check1CheckBox
        '
        Me.Mc_check1CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_FragenBindingSource, "mc_check1", True))
        Me.Mc_check1CheckBox.Location = New System.Drawing.Point(587, 42)
        Me.Mc_check1CheckBox.Name = "Mc_check1CheckBox"
        Me.Mc_check1CheckBox.Size = New System.Drawing.Size(41, 24)
        Me.Mc_check1CheckBox.TabIndex = 22
        Me.Mc_check1CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_check2CheckBox
        '
        Me.Mc_check2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_FragenBindingSource, "mc_check2", True))
        Me.Mc_check2CheckBox.Location = New System.Drawing.Point(587, 81)
        Me.Mc_check2CheckBox.Name = "Mc_check2CheckBox"
        Me.Mc_check2CheckBox.Size = New System.Drawing.Size(41, 24)
        Me.Mc_check2CheckBox.TabIndex = 24
        Me.Mc_check2CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_check3CheckBox
        '
        Me.Mc_check3CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_FragenBindingSource, "mc_check3", True))
        Me.Mc_check3CheckBox.Location = New System.Drawing.Point(587, 120)
        Me.Mc_check3CheckBox.Name = "Mc_check3CheckBox"
        Me.Mc_check3CheckBox.Size = New System.Drawing.Size(41, 24)
        Me.Mc_check3CheckBox.TabIndex = 26
        Me.Mc_check3CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_check4CheckBox
        '
        Me.Mc_check4CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_FragenBindingSource, "mc_check4", True))
        Me.Mc_check4CheckBox.Location = New System.Drawing.Point(587, 159)
        Me.Mc_check4CheckBox.Name = "Mc_check4CheckBox"
        Me.Mc_check4CheckBox.Size = New System.Drawing.Size(41, 24)
        Me.Mc_check4CheckBox.TabIndex = 28
        Me.Mc_check4CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_check5CheckBox
        '
        Me.Mc_check5CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_FragenBindingSource, "mc_check5", True))
        Me.Mc_check5CheckBox.Location = New System.Drawing.Point(587, 198)
        Me.Mc_check5CheckBox.Name = "Mc_check5CheckBox"
        Me.Mc_check5CheckBox.Size = New System.Drawing.Size(41, 24)
        Me.Mc_check5CheckBox.TabIndex = 30
        Me.Mc_check5CheckBox.UseVisualStyleBackColor = True
        '
        'PunkteLabel
        '
        PunkteLabel.AutoSize = True
        PunkteLabel.Location = New System.Drawing.Point(30, 488)
        PunkteLabel.Name = "PunkteLabel"
        PunkteLabel.Size = New System.Drawing.Size(43, 13)
        PunkteLabel.TabIndex = 41
        PunkteLabel.Text = "punkte:"
        '
        'PunkteTextBox
        '
        Me.PunkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "punkte", True))
        Me.PunkteTextBox.Location = New System.Drawing.Point(114, 485)
        Me.PunkteTextBox.Name = "PunkteTextBox"
        Me.PunkteTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PunkteTextBox.TabIndex = 42
        '
        'ThemenlinkLabel
        '
        ThemenlinkLabel.AutoSize = True
        ThemenlinkLabel.Location = New System.Drawing.Point(30, 517)
        ThemenlinkLabel.Name = "ThemenlinkLabel"
        ThemenlinkLabel.Size = New System.Drawing.Size(65, 13)
        ThemenlinkLabel.TabIndex = 45
        ThemenlinkLabel.Text = "Themenlink:"
        '
        'ThemenlinkTextBox
        '
        Me.ThemenlinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_FragenBindingSource, "Themenlink", True))
        Me.ThemenlinkTextBox.Location = New System.Drawing.Point(114, 514)
        Me.ThemenlinkTextBox.Multiline = True
        Me.ThemenlinkTextBox.Name = "ThemenlinkTextBox"
        Me.ThemenlinkTextBox.Size = New System.Drawing.Size(500, 59)
        Me.ThemenlinkTextBox.TabIndex = 46
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.42948!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.290016!))
        Me.TableLayoutPanel1.Controls.Add(Mc_anwort1Label, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_anwort1TextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_check1CheckBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Mc_anwort2Label, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Mc_anwort3Label, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Mc_anwort4Label, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Mc_anwort5Label, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_anwort2TextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_anwort3TextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_anwort5TextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_anwort4TextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_check2CheckBox, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_check3CheckBox, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_check4CheckBox, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Mc_check5CheckBox, 2, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(33, 241)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(631, 238)
        Me.TableLayoutPanel1.TabIndex = 47
        '
        'frm_Fragen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 585)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Cat_idLabel)
        Me.Controls.Add(Me.Cat_idTextBox)
        Me.Controls.Add(FrageLabel)
        Me.Controls.Add(Me.FrageTextBox)
        Me.Controls.Add(AntwortFreiLabel)
        Me.Controls.Add(Me.AntwortFreiTextBox)
        Me.Controls.Add(PunkteLabel)
        Me.Controls.Add(Me.PunkteTextBox)
        Me.Controls.Add(ThemenlinkLabel)
        Me.Controls.Add(Me.ThemenlinkTextBox)
        Me.Controls.Add(Me.Tbl_FragenBindingNavigator)
        Me.Name = "frm_Fragen"
        Me.Text = "Fragen erfassen"
        CType(Me.Lernkartei2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_FragenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_FragenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_FragenBindingNavigator.ResumeLayout(False)
        Me.Tbl_FragenBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lernkartei2DataSet As Lernkartei2.lernkartei2DataSet
    Friend WithEvents Tbl_FragenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_FragenTableAdapter As Lernkartei2.lernkartei2DataSetTableAdapters.tbl_FragenTableAdapter
    Friend WithEvents TableAdapterManager As Lernkartei2.lernkartei2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_FragenBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_FragenBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FrageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AntwortFreiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_check1CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_check2CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_check3CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_check4CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_check5CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PunkteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ThemenlinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
