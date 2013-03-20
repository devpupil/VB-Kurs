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
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NachnameLabel As System.Windows.Forms.Label
        Dim StraßeLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim GeburtsdamLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim InternetLabel As System.Windows.Forms.Label
        Dim AnredeLabel1 As System.Windows.Forms.Label
        Dim BemerkungLabel As System.Windows.Forms.Label
        Me.AdressenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AdressenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.NachnameTextBox = New System.Windows.Forms.TextBox()
        Me.StraßeTextBox = New System.Windows.Forms.TextBox()
        Me.PLZTextBox = New System.Windows.Forms.TextBox()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.GeburtsdamDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MailLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.InternetLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AnredeTextBox = New System.Windows.Forms.TextBox()
        Me.BemerkungTextBox = New System.Windows.Forms.TextBox()
        Me.AdressenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdressenDataSet = New WindowsApplication1.adressenDataSet()
        Me.AdressenTableAdapter = New WindowsApplication1.adressenDataSetTableAdapters.AdressenTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.adressenDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NachnameLabel = New System.Windows.Forms.Label()
        StraßeLabel = New System.Windows.Forms.Label()
        PLZLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        GeburtsdamLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        InternetLabel = New System.Windows.Forms.Label()
        AnredeLabel1 = New System.Windows.Forms.Label()
        BemerkungLabel = New System.Windows.Forms.Label()
        CType(Me.AdressenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdressenBindingNavigator.SuspendLayout()
        CType(Me.AdressenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdressenBindingNavigator
        '
        Me.AdressenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdressenBindingNavigator.BindingSource = Me.AdressenBindingSource
        Me.AdressenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdressenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdressenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdressenBindingNavigatorSaveItem})
        Me.AdressenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdressenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdressenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdressenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdressenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdressenBindingNavigator.Name = "AdressenBindingNavigator"
        Me.AdressenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdressenBindingNavigator.Size = New System.Drawing.Size(376, 25)
        Me.AdressenBindingNavigator.TabIndex = 0
        Me.AdressenBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'AdressenBindingNavigatorSaveItem
        '
        Me.AdressenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdressenBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdressenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdressenBindingNavigatorSaveItem.Name = "AdressenBindingNavigatorSaveItem"
        Me.AdressenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AdressenBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(24, 47)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 44)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(24, 99)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(52, 13)
        VornameLabel.TabIndex = 5
        VornameLabel.Text = "Vorname:"
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(97, 96)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VornameTextBox.TabIndex = 6
        '
        'NachnameLabel
        '
        NachnameLabel.AutoSize = True
        NachnameLabel.Location = New System.Drawing.Point(24, 125)
        NachnameLabel.Name = "NachnameLabel"
        NachnameLabel.Size = New System.Drawing.Size(62, 13)
        NachnameLabel.TabIndex = 7
        NachnameLabel.Text = "Nachname:"
        '
        'NachnameTextBox
        '
        Me.NachnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Nachname", True))
        Me.NachnameTextBox.Location = New System.Drawing.Point(97, 122)
        Me.NachnameTextBox.Name = "NachnameTextBox"
        Me.NachnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NachnameTextBox.TabIndex = 8
        '
        'StraßeLabel
        '
        StraßeLabel.AutoSize = True
        StraßeLabel.Location = New System.Drawing.Point(24, 151)
        StraßeLabel.Name = "StraßeLabel"
        StraßeLabel.Size = New System.Drawing.Size(41, 13)
        StraßeLabel.TabIndex = 9
        StraßeLabel.Text = "Straße:"
        '
        'StraßeTextBox
        '
        Me.StraßeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Straße", True))
        Me.StraßeTextBox.Location = New System.Drawing.Point(97, 148)
        Me.StraßeTextBox.Name = "StraßeTextBox"
        Me.StraßeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StraßeTextBox.TabIndex = 10
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(24, 177)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 11
        PLZLabel.Text = "PLZ:"
        '
        'PLZTextBox
        '
        Me.PLZTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "PLZ", True))
        Me.PLZTextBox.Location = New System.Drawing.Point(97, 174)
        Me.PLZTextBox.Name = "PLZTextBox"
        Me.PLZTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PLZTextBox.TabIndex = 12
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(24, 203)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 13
        OrtLabel.Text = "Ort:"
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(97, 200)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OrtTextBox.TabIndex = 14
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(24, 229)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 15
        TelefonLabel.Text = "Telefon:"
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(97, 226)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonTextBox.TabIndex = 16
        '
        'GeburtsdamLabel
        '
        GeburtsdamLabel.AutoSize = True
        GeburtsdamLabel.Location = New System.Drawing.Point(24, 256)
        GeburtsdamLabel.Name = "GeburtsdamLabel"
        GeburtsdamLabel.Size = New System.Drawing.Size(67, 13)
        GeburtsdamLabel.TabIndex = 17
        GeburtsdamLabel.Text = "Geburtsdam:"
        '
        'GeburtsdamDateTimePicker
        '
        Me.GeburtsdamDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AdressenBindingSource, "Geburtsdam", True))
        Me.GeburtsdamDateTimePicker.Location = New System.Drawing.Point(97, 252)
        Me.GeburtsdamDateTimePicker.Name = "GeburtsdamDateTimePicker"
        Me.GeburtsdamDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.GeburtsdamDateTimePicker.TabIndex = 18
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(24, 275)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 19
        MailLabel.Text = "Mail:"
        '
        'MailLinkLabel
        '
        Me.MailLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Mail", True))
        Me.MailLinkLabel.Location = New System.Drawing.Point(97, 275)
        Me.MailLinkLabel.Name = "MailLinkLabel"
        Me.MailLinkLabel.Size = New System.Drawing.Size(200, 23)
        Me.MailLinkLabel.TabIndex = 20
        Me.MailLinkLabel.TabStop = True
        Me.MailLinkLabel.Text = "LinkLabel1"
        '
        'InternetLabel
        '
        InternetLabel.AutoSize = True
        InternetLabel.Location = New System.Drawing.Point(24, 298)
        InternetLabel.Name = "InternetLabel"
        InternetLabel.Size = New System.Drawing.Size(46, 13)
        InternetLabel.TabIndex = 21
        InternetLabel.Text = "Internet:"
        '
        'InternetLinkLabel
        '
        Me.InternetLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Internet", True))
        Me.InternetLinkLabel.Location = New System.Drawing.Point(97, 298)
        Me.InternetLinkLabel.Name = "InternetLinkLabel"
        Me.InternetLinkLabel.Size = New System.Drawing.Size(200, 23)
        Me.InternetLinkLabel.TabIndex = 22
        Me.InternetLinkLabel.TabStop = True
        Me.InternetLinkLabel.Text = "LinkLabel1"
        '
        'AnredeLabel1
        '
        AnredeLabel1.AutoSize = True
        AnredeLabel1.Location = New System.Drawing.Point(24, 70)
        AnredeLabel1.Name = "AnredeLabel1"
        AnredeLabel1.Size = New System.Drawing.Size(44, 13)
        AnredeLabel1.TabIndex = 22
        AnredeLabel1.Text = "Anrede:"
        '
        'AnredeTextBox
        '
        Me.AnredeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Anrede", True))
        Me.AnredeTextBox.Location = New System.Drawing.Point(97, 70)
        Me.AnredeTextBox.Name = "AnredeTextBox"
        Me.AnredeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AnredeTextBox.TabIndex = 23
        '
        'BemerkungLabel
        '
        BemerkungLabel.AutoSize = True
        BemerkungLabel.Location = New System.Drawing.Point(24, 331)
        BemerkungLabel.Name = "BemerkungLabel"
        BemerkungLabel.Size = New System.Drawing.Size(64, 13)
        BemerkungLabel.TabIndex = 23
        BemerkungLabel.Text = "Bemerkung:"
        '
        'BemerkungTextBox
        '
        Me.BemerkungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Bemerkung", True))
        Me.BemerkungTextBox.Location = New System.Drawing.Point(94, 328)
        Me.BemerkungTextBox.Name = "BemerkungTextBox"
        Me.BemerkungTextBox.Size = New System.Drawing.Size(203, 20)
        Me.BemerkungTextBox.TabIndex = 24
        '
        'AdressenBindingSource
        '
        Me.AdressenBindingSource.DataMember = "Adressen"
        Me.AdressenBindingSource.DataSource = Me.AdressenDataSet
        '
        'AdressenDataSet
        '
        Me.AdressenDataSet.DataSetName = "adressenDataSet"
        Me.AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdressenTableAdapter
        '
        Me.AdressenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdressenTableAdapter = Me.AdressenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.adressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 528)
        Me.Controls.Add(BemerkungLabel)
        Me.Controls.Add(Me.BemerkungTextBox)
        Me.Controls.Add(AnredeLabel1)
        Me.Controls.Add(Me.AnredeTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(VornameLabel)
        Me.Controls.Add(Me.VornameTextBox)
        Me.Controls.Add(NachnameLabel)
        Me.Controls.Add(Me.NachnameTextBox)
        Me.Controls.Add(StraßeLabel)
        Me.Controls.Add(Me.StraßeTextBox)
        Me.Controls.Add(PLZLabel)
        Me.Controls.Add(Me.PLZTextBox)
        Me.Controls.Add(OrtLabel)
        Me.Controls.Add(Me.OrtTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(GeburtsdamLabel)
        Me.Controls.Add(Me.GeburtsdamDateTimePicker)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailLinkLabel)
        Me.Controls.Add(InternetLabel)
        Me.Controls.Add(Me.InternetLinkLabel)
        Me.Controls.Add(Me.AdressenBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AdressenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdressenBindingNavigator.ResumeLayout(False)
        Me.AdressenBindingNavigator.PerformLayout()
        CType(Me.AdressenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdressenDataSet As WindowsApplication1.adressenDataSet
    Friend WithEvents AdressenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdressenTableAdapter As WindowsApplication1.adressenDataSetTableAdapters.AdressenTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.adressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdressenBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AdressenBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VornameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NachnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StraßeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLZTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeburtsdamDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MailLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents InternetLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents AnredeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BemerkungTextBox As System.Windows.Forms.TextBox

End Class
