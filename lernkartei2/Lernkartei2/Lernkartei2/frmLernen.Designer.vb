<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLernen
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
        Dim Mc_anwort1Label As System.Windows.Forms.Label
        Dim Mc_anwort2Label As System.Windows.Forms.Label
        Dim Mc_anwort3Label As System.Windows.Forms.Label
        Dim Mc_anwort4Label As System.Windows.Forms.Label
        Dim Mc_anwort5Label As System.Windows.Forms.Label
        Dim FrageLabel As System.Windows.Forms.Label
        Dim AntwortFreiLabel As System.Windows.Forms.Label
        Dim PunkteLabel As System.Windows.Forms.Label
        Dim ThemenlinkLabel As System.Windows.Forms.Label
        Dim ZurueckstellenLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Mc_anwort1TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_check1CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_anwort2TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort3TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort5TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_anwort4TextBox = New System.Windows.Forms.TextBox()
        Me.Mc_check2CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_check3CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_check4CheckBox = New System.Windows.Forms.CheckBox()
        Me.Mc_check5CheckBox = New System.Windows.Forms.CheckBox()
        Me.FrageTextBox = New System.Windows.Forms.TextBox()
        Me.prAntwortFreiTextBox = New System.Windows.Forms.TextBox()
        Me.PunkteTextBox = New System.Windows.Forms.TextBox()
        Me.ThemenlinkTextBox = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ZurueckstellenCheckBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnErster = New System.Windows.Forms.Button()
        Me.btnZurück = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLetzter = New System.Windows.Forms.Button()
        Me.btnNächster = New System.Windows.Forms.Button()
        Me.btnRueckNochmal = New System.Windows.Forms.Button()
        Me.AntwortFreiTextBox = New System.Windows.Forms.TextBox()
        Me.tlpPrMcAntworten = New System.Windows.Forms.TableLayoutPanel()
        Me.pr_mc_checkbox1 = New System.Windows.Forms.CheckBox()
        Me.pr_mc_checkbox2 = New System.Windows.Forms.CheckBox()
        Me.pr_mc_checkbox3 = New System.Windows.Forms.CheckBox()
        Me.pr_mc_checkbox4 = New System.Windows.Forms.CheckBox()
        Me.pr_mc_checkbox5 = New System.Windows.Forms.CheckBox()
        Me.btnAuswerten = New System.Windows.Forms.Button()
        Me.btnAuswertenFrei = New System.Windows.Forms.Button()
        Mc_anwort1Label = New System.Windows.Forms.Label()
        Mc_anwort2Label = New System.Windows.Forms.Label()
        Mc_anwort3Label = New System.Windows.Forms.Label()
        Mc_anwort4Label = New System.Windows.Forms.Label()
        Mc_anwort5Label = New System.Windows.Forms.Label()
        FrageLabel = New System.Windows.Forms.Label()
        AntwortFreiLabel = New System.Windows.Forms.Label()
        PunkteLabel = New System.Windows.Forms.Label()
        ThemenlinkLabel = New System.Windows.Forms.Label()
        ZurueckstellenLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpPrMcAntworten.SuspendLayout()
        Me.SuspendLayout()
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
        'Mc_anwort2Label
        '
        Mc_anwort2Label.AutoSize = True
        Mc_anwort2Label.Location = New System.Drawing.Point(3, 78)
        Mc_anwort2Label.Name = "Mc_anwort2Label"
        Mc_anwort2Label.Size = New System.Drawing.Size(65, 13)
        Mc_anwort2Label.TabIndex = 13
        Mc_anwort2Label.Text = "mc anwort2:"
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
        'Mc_anwort4Label
        '
        Mc_anwort4Label.AutoSize = True
        Mc_anwort4Label.Location = New System.Drawing.Point(3, 156)
        Mc_anwort4Label.Name = "Mc_anwort4Label"
        Mc_anwort4Label.Size = New System.Drawing.Size(65, 13)
        Mc_anwort4Label.TabIndex = 17
        Mc_anwort4Label.Text = "mc anwort4:"
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
        'FrageLabel
        '
        FrageLabel.AutoSize = True
        FrageLabel.Location = New System.Drawing.Point(14, 12)
        FrageLabel.Name = "FrageLabel"
        FrageLabel.Size = New System.Drawing.Size(37, 13)
        FrageLabel.TabIndex = 48
        FrageLabel.Text = "Frage:"
        '
        'AntwortFreiLabel
        '
        AntwortFreiLabel.AutoSize = True
        AntwortFreiLabel.Location = New System.Drawing.Point(14, 76)
        AntwortFreiLabel.Name = "AntwortFreiLabel"
        AntwortFreiLabel.Size = New System.Drawing.Size(65, 13)
        AntwortFreiLabel.TabIndex = 50
        AntwortFreiLabel.Text = "antwort Frei:"
        '
        'PunkteLabel
        '
        PunkteLabel.AutoSize = True
        PunkteLabel.Location = New System.Drawing.Point(14, 431)
        PunkteLabel.Name = "PunkteLabel"
        PunkteLabel.Size = New System.Drawing.Size(43, 13)
        PunkteLabel.TabIndex = 52
        PunkteLabel.Text = "punkte:"
        '
        'ThemenlinkLabel
        '
        ThemenlinkLabel.AutoSize = True
        ThemenlinkLabel.Location = New System.Drawing.Point(14, 460)
        ThemenlinkLabel.Name = "ThemenlinkLabel"
        ThemenlinkLabel.Size = New System.Drawing.Size(65, 13)
        ThemenlinkLabel.TabIndex = 54
        ThemenlinkLabel.Text = "Themenlink:"
        '
        'ZurueckstellenLabel
        '
        ZurueckstellenLabel.AutoSize = True
        ZurueckstellenLabel.Location = New System.Drawing.Point(221, 615)
        ZurueckstellenLabel.Name = "ZurueckstellenLabel"
        ZurueckstellenLabel.Size = New System.Drawing.Size(99, 13)
        ZurueckstellenLabel.TabIndex = 58
        ZurueckstellenLabel.Text = "Frage zurückstellen"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.05547!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.968254!))
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 184)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(603, 238)
        Me.TableLayoutPanel1.TabIndex = 56
        '
        'Mc_anwort1TextBox
        '
        Me.Mc_anwort1TextBox.Location = New System.Drawing.Point(93, 42)
        Me.Mc_anwort1TextBox.Multiline = True
        Me.Mc_anwort1TextBox.Name = "Mc_anwort1TextBox"
        Me.Mc_anwort1TextBox.Size = New System.Drawing.Size(482, 33)
        Me.Mc_anwort1TextBox.TabIndex = 12
        '
        'Mc_check1CheckBox
        '
        Me.Mc_check1CheckBox.Location = New System.Drawing.Point(581, 42)
        Me.Mc_check1CheckBox.Name = "Mc_check1CheckBox"
        Me.Mc_check1CheckBox.Size = New System.Drawing.Size(19, 24)
        Me.Mc_check1CheckBox.TabIndex = 22
        Me.Mc_check1CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_anwort2TextBox
        '
        Me.Mc_anwort2TextBox.Location = New System.Drawing.Point(93, 81)
        Me.Mc_anwort2TextBox.Multiline = True
        Me.Mc_anwort2TextBox.Name = "Mc_anwort2TextBox"
        Me.Mc_anwort2TextBox.Size = New System.Drawing.Size(482, 33)
        Me.Mc_anwort2TextBox.TabIndex = 14
        '
        'Mc_anwort3TextBox
        '
        Me.Mc_anwort3TextBox.Location = New System.Drawing.Point(93, 120)
        Me.Mc_anwort3TextBox.Multiline = True
        Me.Mc_anwort3TextBox.Name = "Mc_anwort3TextBox"
        Me.Mc_anwort3TextBox.Size = New System.Drawing.Size(482, 33)
        Me.Mc_anwort3TextBox.TabIndex = 16
        '
        'Mc_anwort5TextBox
        '
        Me.Mc_anwort5TextBox.Location = New System.Drawing.Point(93, 198)
        Me.Mc_anwort5TextBox.Multiline = True
        Me.Mc_anwort5TextBox.Name = "Mc_anwort5TextBox"
        Me.Mc_anwort5TextBox.Size = New System.Drawing.Size(482, 33)
        Me.Mc_anwort5TextBox.TabIndex = 20
        '
        'Mc_anwort4TextBox
        '
        Me.Mc_anwort4TextBox.Location = New System.Drawing.Point(93, 159)
        Me.Mc_anwort4TextBox.Multiline = True
        Me.Mc_anwort4TextBox.Name = "Mc_anwort4TextBox"
        Me.Mc_anwort4TextBox.Size = New System.Drawing.Size(482, 33)
        Me.Mc_anwort4TextBox.TabIndex = 18
        '
        'Mc_check2CheckBox
        '
        Me.Mc_check2CheckBox.Location = New System.Drawing.Point(581, 81)
        Me.Mc_check2CheckBox.Name = "Mc_check2CheckBox"
        Me.Mc_check2CheckBox.Size = New System.Drawing.Size(19, 24)
        Me.Mc_check2CheckBox.TabIndex = 24
        Me.Mc_check2CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_check3CheckBox
        '
        Me.Mc_check3CheckBox.Location = New System.Drawing.Point(581, 120)
        Me.Mc_check3CheckBox.Name = "Mc_check3CheckBox"
        Me.Mc_check3CheckBox.Size = New System.Drawing.Size(19, 24)
        Me.Mc_check3CheckBox.TabIndex = 26
        Me.Mc_check3CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_check4CheckBox
        '
        Me.Mc_check4CheckBox.Location = New System.Drawing.Point(581, 159)
        Me.Mc_check4CheckBox.Name = "Mc_check4CheckBox"
        Me.Mc_check4CheckBox.Size = New System.Drawing.Size(19, 24)
        Me.Mc_check4CheckBox.TabIndex = 28
        Me.Mc_check4CheckBox.UseVisualStyleBackColor = True
        '
        'Mc_check5CheckBox
        '
        Me.Mc_check5CheckBox.Location = New System.Drawing.Point(581, 198)
        Me.Mc_check5CheckBox.Name = "Mc_check5CheckBox"
        Me.Mc_check5CheckBox.Size = New System.Drawing.Size(19, 24)
        Me.Mc_check5CheckBox.TabIndex = 30
        Me.Mc_check5CheckBox.UseVisualStyleBackColor = True
        '
        'FrageTextBox
        '
        Me.FrageTextBox.Location = New System.Drawing.Point(98, 12)
        Me.FrageTextBox.Multiline = True
        Me.FrageTextBox.Name = "FrageTextBox"
        Me.FrageTextBox.ReadOnly = True
        Me.FrageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FrageTextBox.Size = New System.Drawing.Size(500, 55)
        Me.FrageTextBox.TabIndex = 49
        '
        'prAntwortFreiTextBox
        '
        Me.prAntwortFreiTextBox.Location = New System.Drawing.Point(98, 73)
        Me.prAntwortFreiTextBox.Multiline = True
        Me.prAntwortFreiTextBox.Name = "prAntwortFreiTextBox"
        Me.prAntwortFreiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.prAntwortFreiTextBox.Size = New System.Drawing.Size(500, 105)
        Me.prAntwortFreiTextBox.TabIndex = 51
        '
        'PunkteTextBox
        '
        Me.PunkteTextBox.Location = New System.Drawing.Point(98, 428)
        Me.PunkteTextBox.Name = "PunkteTextBox"
        Me.PunkteTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PunkteTextBox.TabIndex = 53
        '
        'ThemenlinkTextBox
        '
        Me.ThemenlinkTextBox.Location = New System.Drawing.Point(98, 457)
        Me.ThemenlinkTextBox.Multiline = True
        Me.ThemenlinkTextBox.Name = "ThemenlinkTextBox"
        Me.ThemenlinkTextBox.Size = New System.Drawing.Size(500, 59)
        Me.ThemenlinkTextBox.TabIndex = 55
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Control
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Location = New System.Drawing.Point(20, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(36, 13)
        Me.txtID.TabIndex = 57
        '
        'ZurueckstellenCheckBox
        '
        Me.ZurueckstellenCheckBox.Location = New System.Drawing.Point(326, 610)
        Me.ZurueckstellenCheckBox.Name = "ZurueckstellenCheckBox"
        Me.ZurueckstellenCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.ZurueckstellenCheckBox.TabIndex = 59
        Me.ZurueckstellenCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ZurueckstellenCheckBox.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnErster, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnZurück, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(17, 598)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(185, 42)
        Me.TableLayoutPanel2.TabIndex = 60
        '
        'btnErster
        '
        Me.btnErster.Location = New System.Drawing.Point(3, 3)
        Me.btnErster.Name = "btnErster"
        Me.btnErster.Size = New System.Drawing.Size(86, 33)
        Me.btnErster.TabIndex = 0
        Me.btnErster.Text = "|< Erster"
        Me.btnErster.UseVisualStyleBackColor = True
        '
        'btnZurück
        '
        Me.btnZurück.Location = New System.Drawing.Point(95, 3)
        Me.btnZurück.Name = "btnZurück"
        Me.btnZurück.Size = New System.Drawing.Size(86, 33)
        Me.btnZurück.TabIndex = 1
        Me.btnZurück.Text = "<< Zurück"
        Me.btnZurück.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnLetzter, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnNächster, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(507, 598)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(185, 42)
        Me.TableLayoutPanel3.TabIndex = 61
        '
        'btnLetzter
        '
        Me.btnLetzter.Location = New System.Drawing.Point(95, 3)
        Me.btnLetzter.Name = "btnLetzter"
        Me.btnLetzter.Size = New System.Drawing.Size(86, 33)
        Me.btnLetzter.TabIndex = 2
        Me.btnLetzter.Text = "Letzter >|"
        Me.btnLetzter.UseVisualStyleBackColor = True
        '
        'btnNächster
        '
        Me.btnNächster.Location = New System.Drawing.Point(3, 3)
        Me.btnNächster.Name = "btnNächster"
        Me.btnNächster.Size = New System.Drawing.Size(86, 33)
        Me.btnNächster.TabIndex = 1
        Me.btnNächster.Text = "Nächster >>"
        Me.btnNächster.UseVisualStyleBackColor = True
        '
        'btnRueckNochmal
        '
        Me.btnRueckNochmal.Location = New System.Drawing.Point(395, 598)
        Me.btnRueckNochmal.Name = "btnRueckNochmal"
        Me.btnRueckNochmal.Size = New System.Drawing.Size(95, 42)
        Me.btnRueckNochmal.TabIndex = 62
        Me.btnRueckNochmal.Text = "Zurückgestellte"
        Me.btnRueckNochmal.UseVisualStyleBackColor = True
        '
        'AntwortFreiTextBox
        '
        Me.AntwortFreiTextBox.Location = New System.Drawing.Point(613, 76)
        Me.AntwortFreiTextBox.Multiline = True
        Me.AntwortFreiTextBox.Name = "AntwortFreiTextBox"
        Me.AntwortFreiTextBox.Size = New System.Drawing.Size(79, 91)
        Me.AntwortFreiTextBox.TabIndex = 63
        '
        'tlpPrMcAntworten
        '
        Me.tlpPrMcAntworten.ColumnCount = 1
        Me.tlpPrMcAntworten.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrMcAntworten.Controls.Add(Me.pr_mc_checkbox5, 0, 4)
        Me.tlpPrMcAntworten.Controls.Add(Me.pr_mc_checkbox4, 0, 3)
        Me.tlpPrMcAntworten.Controls.Add(Me.pr_mc_checkbox3, 0, 2)
        Me.tlpPrMcAntworten.Controls.Add(Me.pr_mc_checkbox2, 0, 1)
        Me.tlpPrMcAntworten.Controls.Add(Me.pr_mc_checkbox1, 0, 0)
        Me.tlpPrMcAntworten.Location = New System.Drawing.Point(632, 228)
        Me.tlpPrMcAntworten.Name = "tlpPrMcAntworten"
        Me.tlpPrMcAntworten.RowCount = 5
        Me.tlpPrMcAntworten.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrMcAntworten.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrMcAntworten.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrMcAntworten.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrMcAntworten.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrMcAntworten.Size = New System.Drawing.Size(26, 194)
        Me.tlpPrMcAntworten.TabIndex = 64
        '
        'pr_mc_checkbox1
        '
        Me.pr_mc_checkbox1.AutoSize = True
        Me.pr_mc_checkbox1.Location = New System.Drawing.Point(3, 3)
        Me.pr_mc_checkbox1.Name = "pr_mc_checkbox1"
        Me.pr_mc_checkbox1.Size = New System.Drawing.Size(20, 17)
        Me.pr_mc_checkbox1.TabIndex = 0
        Me.pr_mc_checkbox1.Text = "CheckBox1"
        Me.pr_mc_checkbox1.UseVisualStyleBackColor = True
        '
        'pr_mc_checkbox2
        '
        Me.pr_mc_checkbox2.AutoSize = True
        Me.pr_mc_checkbox2.Location = New System.Drawing.Point(3, 41)
        Me.pr_mc_checkbox2.Name = "pr_mc_checkbox2"
        Me.pr_mc_checkbox2.Size = New System.Drawing.Size(20, 17)
        Me.pr_mc_checkbox2.TabIndex = 1
        Me.pr_mc_checkbox2.Text = "CheckBox2"
        Me.pr_mc_checkbox2.UseVisualStyleBackColor = True
        '
        'pr_mc_checkbox3
        '
        Me.pr_mc_checkbox3.AutoSize = True
        Me.pr_mc_checkbox3.Location = New System.Drawing.Point(3, 79)
        Me.pr_mc_checkbox3.Name = "pr_mc_checkbox3"
        Me.pr_mc_checkbox3.Size = New System.Drawing.Size(20, 17)
        Me.pr_mc_checkbox3.TabIndex = 2
        Me.pr_mc_checkbox3.Text = "CheckBox3"
        Me.pr_mc_checkbox3.UseVisualStyleBackColor = True
        '
        'pr_mc_checkbox4
        '
        Me.pr_mc_checkbox4.AutoSize = True
        Me.pr_mc_checkbox4.Location = New System.Drawing.Point(3, 117)
        Me.pr_mc_checkbox4.Name = "pr_mc_checkbox4"
        Me.pr_mc_checkbox4.Size = New System.Drawing.Size(20, 17)
        Me.pr_mc_checkbox4.TabIndex = 3
        Me.pr_mc_checkbox4.Text = "CheckBox4"
        Me.pr_mc_checkbox4.UseVisualStyleBackColor = True
        '
        'pr_mc_checkbox5
        '
        Me.pr_mc_checkbox5.AutoSize = True
        Me.pr_mc_checkbox5.Location = New System.Drawing.Point(3, 155)
        Me.pr_mc_checkbox5.Name = "pr_mc_checkbox5"
        Me.pr_mc_checkbox5.Size = New System.Drawing.Size(20, 17)
        Me.pr_mc_checkbox5.TabIndex = 4
        Me.pr_mc_checkbox5.Text = "CheckBox5"
        Me.pr_mc_checkbox5.UseVisualStyleBackColor = True
        '
        'btnAuswerten
        '
        Me.btnAuswerten.Location = New System.Drawing.Point(599, 548)
        Me.btnAuswerten.Name = "btnAuswerten"
        Me.btnAuswerten.Size = New System.Drawing.Size(88, 31)
        Me.btnAuswerten.TabIndex = 65
        Me.btnAuswerten.Text = "Auswerten"
        Me.btnAuswerten.UseVisualStyleBackColor = True
        '
        'btnAuswertenFrei
        '
        Me.btnAuswertenFrei.Location = New System.Drawing.Point(491, 548)
        Me.btnAuswertenFrei.Name = "btnAuswertenFrei"
        Me.btnAuswertenFrei.Size = New System.Drawing.Size(90, 31)
        Me.btnAuswertenFrei.TabIndex = 66
        Me.btnAuswertenFrei.Text = "AuswertenFrei"
        Me.btnAuswertenFrei.UseVisualStyleBackColor = True
        '
        'frmLernen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 652)
        Me.Controls.Add(Me.btnAuswertenFrei)
        Me.Controls.Add(Me.btnAuswerten)
        Me.Controls.Add(Me.tlpPrMcAntworten)
        Me.Controls.Add(Me.AntwortFreiTextBox)
        Me.Controls.Add(Me.btnRueckNochmal)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(ZurueckstellenLabel)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ZurueckstellenCheckBox)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(FrageLabel)
        Me.Controls.Add(Me.FrageTextBox)
        Me.Controls.Add(AntwortFreiLabel)
        Me.Controls.Add(Me.prAntwortFreiTextBox)
        Me.Controls.Add(PunkteLabel)
        Me.Controls.Add(Me.PunkteTextBox)
        Me.Controls.Add(ThemenlinkLabel)
        Me.Controls.Add(Me.ThemenlinkTextBox)
        Me.Name = "frmLernen"
        Me.Text = "frmLernen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpPrMcAntworten.ResumeLayout(False)
        Me.tlpPrMcAntworten.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Mc_anwort1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_check1CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_anwort2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_anwort4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mc_check2CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_check3CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_check4CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mc_check5CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FrageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prAntwortFreiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PunkteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ThemenlinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents ZurueckstellenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnErster As System.Windows.Forms.Button
    Friend WithEvents btnZurück As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLetzter As System.Windows.Forms.Button
    Friend WithEvents btnNächster As System.Windows.Forms.Button
    Friend WithEvents btnRueckNochmal As System.Windows.Forms.Button
    Friend WithEvents AntwortFreiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tlpPrMcAntworten As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pr_mc_checkbox5 As System.Windows.Forms.CheckBox
    Friend WithEvents pr_mc_checkbox4 As System.Windows.Forms.CheckBox
    Friend WithEvents pr_mc_checkbox3 As System.Windows.Forms.CheckBox
    Friend WithEvents pr_mc_checkbox2 As System.Windows.Forms.CheckBox
    Friend WithEvents pr_mc_checkbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAuswerten As System.Windows.Forms.Button
    Friend WithEvents btnAuswertenFrei As System.Windows.Forms.Button
End Class
