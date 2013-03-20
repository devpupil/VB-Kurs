<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sqlitetutorial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sqlitetutorial))
        Me.btn_createdb = New System.Windows.Forms.Button
        Me.btn_tables_create = New System.Windows.Forms.Button
        Me.btn_insert = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.txt_tables_name = New System.Windows.Forms.TextBox
        Me.btn_insert_select = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_insert_title = New System.Windows.Forms.TextBox
        Me.txt_insert_description = New System.Windows.Forms.TextBox
        Me.pic_viewimage = New System.Windows.Forms.PictureBox
        Me.btn_insertimage = New System.Windows.Forms.Button
        Me.btn_updateimage = New System.Windows.Forms.Button
        Me.btn_viewimage = New System.Windows.Forms.Button
        Me.tab_container = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_dbpath = New System.Windows.Forms.TextBox
        Me.btn_opendb = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btn_tables_delete = New System.Windows.Forms.Button
        Me.lst_tables = New System.Windows.Forms.ListBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.cmb_insert_tables = New System.Windows.Forms.ComboBox
        Me.pic_insert_image = New System.Windows.Forms.PictureBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btn_update_select = New System.Windows.Forms.Button
        Me.cmb_update_records = New System.Windows.Forms.ComboBox
        Me.pic_update_image = New System.Windows.Forms.PictureBox
        Me.txt_update_description = New System.Windows.Forms.TextBox
        Me.txt_update_title = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_update = New System.Windows.Forms.Button
        Me.cmb_update_tables = New System.Windows.Forms.ComboBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.cmb_delete_tables = New System.Windows.Forms.ComboBox
        Me.lst_delete_records = New System.Windows.Forms.ListBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.pic_viewimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_container.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.pic_insert_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.pic_update_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_createdb
        '
        Me.btn_createdb.Location = New System.Drawing.Point(3, 3)
        Me.btn_createdb.Name = "btn_createdb"
        Me.btn_createdb.Size = New System.Drawing.Size(386, 35)
        Me.btn_createdb.TabIndex = 0
        Me.btn_createdb.Text = "Create New Database"
        Me.btn_createdb.UseVisualStyleBackColor = True
        '
        'btn_tables_create
        '
        Me.btn_tables_create.Location = New System.Drawing.Point(270, 233)
        Me.btn_tables_create.Name = "btn_tables_create"
        Me.btn_tables_create.Size = New System.Drawing.Size(119, 35)
        Me.btn_tables_create.TabIndex = 1
        Me.btn_tables_create.Text = "Create a New Table"
        Me.btn_tables_create.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(3, 236)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(386, 35)
        Me.btn_insert.TabIndex = 2
        Me.btn_insert.Text = "Insert Record"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(3, 236)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(386, 35)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete Record"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_tables_name
        '
        Me.txt_tables_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tables_name.Location = New System.Drawing.Point(3, 233)
        Me.txt_tables_name.Name = "txt_tables_name"
        Me.txt_tables_name.Size = New System.Drawing.Size(261, 35)
        Me.txt_tables_name.TabIndex = 6
        '
        'btn_insert_select
        '
        Me.btn_insert_select.Location = New System.Drawing.Point(4, 206)
        Me.btn_insert_select.Name = "btn_insert_select"
        Me.btn_insert_select.Size = New System.Drawing.Size(384, 23)
        Me.btn_insert_select.TabIndex = 7
        Me.btn_insert_select.Text = "Select Image File"
        Me.btn_insert_select.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Description"
        '
        'txt_insert_title
        '
        Me.txt_insert_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insert_title.Location = New System.Drawing.Point(3, 43)
        Me.txt_insert_title.Name = "txt_insert_title"
        Me.txt_insert_title.Size = New System.Drawing.Size(386, 35)
        Me.txt_insert_title.TabIndex = 10
        '
        'txt_insert_description
        '
        Me.txt_insert_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_insert_description.Location = New System.Drawing.Point(3, 97)
        Me.txt_insert_description.Name = "txt_insert_description"
        Me.txt_insert_description.Size = New System.Drawing.Size(386, 35)
        Me.txt_insert_description.TabIndex = 11
        '
        'pic_viewimage
        '
        Me.pic_viewimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_viewimage.Location = New System.Drawing.Point(3, 3)
        Me.pic_viewimage.Name = "pic_viewimage"
        Me.pic_viewimage.Size = New System.Drawing.Size(386, 227)
        Me.pic_viewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_viewimage.TabIndex = 14
        Me.pic_viewimage.TabStop = False
        '
        'btn_insertimage
        '
        Me.btn_insertimage.Location = New System.Drawing.Point(3, 236)
        Me.btn_insertimage.Name = "btn_insertimage"
        Me.btn_insertimage.Size = New System.Drawing.Size(118, 35)
        Me.btn_insertimage.TabIndex = 21
        Me.btn_insertimage.Text = "Create DB/Insert"
        Me.btn_insertimage.UseVisualStyleBackColor = True
        '
        'btn_updateimage
        '
        Me.btn_updateimage.Location = New System.Drawing.Point(127, 236)
        Me.btn_updateimage.Name = "btn_updateimage"
        Me.btn_updateimage.Size = New System.Drawing.Size(127, 35)
        Me.btn_updateimage.TabIndex = 22
        Me.btn_updateimage.Text = "Update"
        Me.btn_updateimage.UseVisualStyleBackColor = True
        '
        'btn_viewimage
        '
        Me.btn_viewimage.Location = New System.Drawing.Point(260, 236)
        Me.btn_viewimage.Name = "btn_viewimage"
        Me.btn_viewimage.Size = New System.Drawing.Size(129, 35)
        Me.btn_viewimage.TabIndex = 23
        Me.btn_viewimage.Text = "View"
        Me.btn_viewimage.UseVisualStyleBackColor = True
        '
        'tab_container
        '
        Me.tab_container.Controls.Add(Me.TabPage1)
        Me.tab_container.Controls.Add(Me.TabPage2)
        Me.tab_container.Controls.Add(Me.TabPage3)
        Me.tab_container.Controls.Add(Me.TabPage4)
        Me.tab_container.Controls.Add(Me.TabPage5)
        Me.tab_container.Controls.Add(Me.TabPage6)
        Me.tab_container.Controls.Add(Me.TabPage7)
        Me.tab_container.Location = New System.Drawing.Point(12, 12)
        Me.tab_container.Name = "tab_container"
        Me.tab_container.SelectedIndex = 0
        Me.tab_container.Size = New System.Drawing.Size(400, 300)
        Me.tab_container.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_dbpath)
        Me.TabPage1.Controls.Add(Me.btn_opendb)
        Me.TabPage1.Controls.Add(Me.btn_createdb)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(392, 274)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Select DB"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(371, 56)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Example Table Structure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "*Must be filled to use Tables/Insert/Update/Delete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Current Path"
        '
        'txt_dbpath
        '
        Me.txt_dbpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dbpath.Location = New System.Drawing.Point(3, 107)
        Me.txt_dbpath.Name = "txt_dbpath"
        Me.txt_dbpath.ReadOnly = True
        Me.txt_dbpath.Size = New System.Drawing.Size(386, 35)
        Me.txt_dbpath.TabIndex = 7
        '
        'btn_opendb
        '
        Me.btn_opendb.Location = New System.Drawing.Point(3, 44)
        Me.btn_opendb.Name = "btn_opendb"
        Me.btn_opendb.Size = New System.Drawing.Size(386, 35)
        Me.btn_opendb.TabIndex = 1
        Me.btn_opendb.Text = "Open Existing Database"
        Me.btn_opendb.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_tables_delete)
        Me.TabPage2.Controls.Add(Me.lst_tables)
        Me.TabPage2.Controls.Add(Me.txt_tables_name)
        Me.TabPage2.Controls.Add(Me.btn_tables_create)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(392, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tables"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_tables_delete
        '
        Me.btn_tables_delete.Location = New System.Drawing.Point(3, 185)
        Me.btn_tables_delete.Name = "btn_tables_delete"
        Me.btn_tables_delete.Size = New System.Drawing.Size(386, 35)
        Me.btn_tables_delete.TabIndex = 27
        Me.btn_tables_delete.Text = "Delete Selected Table From Database"
        Me.btn_tables_delete.UseVisualStyleBackColor = True
        '
        'lst_tables
        '
        Me.lst_tables.FormattingEnabled = True
        Me.lst_tables.Location = New System.Drawing.Point(3, 6)
        Me.lst_tables.Name = "lst_tables"
        Me.lst_tables.Size = New System.Drawing.Size(386, 173)
        Me.lst_tables.TabIndex = 26
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmb_insert_tables)
        Me.TabPage3.Controls.Add(Me.btn_insert_select)
        Me.TabPage3.Controls.Add(Me.pic_insert_image)
        Me.TabPage3.Controls.Add(Me.txt_insert_description)
        Me.TabPage3.Controls.Add(Me.txt_insert_title)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.btn_insert)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(392, 274)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Insert"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmb_insert_tables
        '
        Me.cmb_insert_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_insert_tables.FormattingEnabled = True
        Me.cmb_insert_tables.Location = New System.Drawing.Point(2, 3)
        Me.cmb_insert_tables.Name = "cmb_insert_tables"
        Me.cmb_insert_tables.Size = New System.Drawing.Size(386, 21)
        Me.cmb_insert_tables.TabIndex = 16
        '
        'pic_insert_image
        '
        Me.pic_insert_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_insert_image.Location = New System.Drawing.Point(3, 138)
        Me.pic_insert_image.Name = "pic_insert_image"
        Me.pic_insert_image.Size = New System.Drawing.Size(386, 92)
        Me.pic_insert_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_insert_image.TabIndex = 15
        Me.pic_insert_image.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btn_update_select)
        Me.TabPage4.Controls.Add(Me.cmb_update_records)
        Me.TabPage4.Controls.Add(Me.pic_update_image)
        Me.TabPage4.Controls.Add(Me.txt_update_description)
        Me.TabPage4.Controls.Add(Me.txt_update_title)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.btn_update)
        Me.TabPage4.Controls.Add(Me.cmb_update_tables)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(392, 274)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Update"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btn_update_select
        '
        Me.btn_update_select.Location = New System.Drawing.Point(4, 206)
        Me.btn_update_select.Name = "btn_update_select"
        Me.btn_update_select.Size = New System.Drawing.Size(384, 23)
        Me.btn_update_select.TabIndex = 24
        Me.btn_update_select.Text = "Select Image File"
        Me.btn_update_select.UseVisualStyleBackColor = True
        '
        'cmb_update_records
        '
        Me.cmb_update_records.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_update_records.FormattingEnabled = True
        Me.cmb_update_records.Location = New System.Drawing.Point(3, 30)
        Me.cmb_update_records.Name = "cmb_update_records"
        Me.cmb_update_records.Size = New System.Drawing.Size(386, 21)
        Me.cmb_update_records.TabIndex = 23
        '
        'pic_update_image
        '
        Me.pic_update_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_update_image.Location = New System.Drawing.Point(3, 165)
        Me.pic_update_image.Name = "pic_update_image"
        Me.pic_update_image.Size = New System.Drawing.Size(386, 65)
        Me.pic_update_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_update_image.TabIndex = 22
        Me.pic_update_image.TabStop = False
        '
        'txt_update_description
        '
        Me.txt_update_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_update_description.Location = New System.Drawing.Point(3, 124)
        Me.txt_update_description.Name = "txt_update_description"
        Me.txt_update_description.Size = New System.Drawing.Size(386, 35)
        Me.txt_update_description.TabIndex = 21
        '
        'txt_update_title
        '
        Me.txt_update_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_update_title.Location = New System.Drawing.Point(3, 70)
        Me.txt_update_title.Name = "txt_update_title"
        Me.txt_update_title.Size = New System.Drawing.Size(386, 35)
        Me.txt_update_title.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Title"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Description"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(3, 236)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(386, 35)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "Update Record"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'cmb_update_tables
        '
        Me.cmb_update_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_update_tables.FormattingEnabled = True
        Me.cmb_update_tables.Location = New System.Drawing.Point(3, 3)
        Me.cmb_update_tables.Name = "cmb_update_tables"
        Me.cmb_update_tables.Size = New System.Drawing.Size(386, 21)
        Me.cmb_update_tables.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.cmb_delete_tables)
        Me.TabPage5.Controls.Add(Me.lst_delete_records)
        Me.TabPage5.Controls.Add(Me.btn_delete)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(392, 274)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Delete"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'cmb_delete_tables
        '
        Me.cmb_delete_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_delete_tables.FormattingEnabled = True
        Me.cmb_delete_tables.Location = New System.Drawing.Point(3, 3)
        Me.cmb_delete_tables.Name = "cmb_delete_tables"
        Me.cmb_delete_tables.Size = New System.Drawing.Size(386, 21)
        Me.cmb_delete_tables.TabIndex = 6
        '
        'lst_delete_records
        '
        Me.lst_delete_records.FormattingEnabled = True
        Me.lst_delete_records.Location = New System.Drawing.Point(3, 30)
        Me.lst_delete_records.Name = "lst_delete_records"
        Me.lst_delete_records.Size = New System.Drawing.Size(386, 199)
        Me.lst_delete_records.TabIndex = 5
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btn_viewimage)
        Me.TabPage6.Controls.Add(Me.btn_insertimage)
        Me.TabPage6.Controls.Add(Me.btn_updateimage)
        Me.TabPage6.Controls.Add(Me.pic_viewimage)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(392, 274)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Image Example"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(392, 274)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "About"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(386, 197)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "By, Templarian"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(271, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "*All image BLOBs are converted to .png for consistancy."
        '
        'sqlitetutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 324)
        Me.Controls.Add(Me.tab_container)
        Me.Name = "sqlitetutorial"
        Me.Text = "SQLite Tutorial"
        CType(Me.pic_viewimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_container.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.pic_insert_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.pic_update_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_createdb As System.Windows.Forms.Button
    Friend WithEvents btn_tables_create As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents txt_tables_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_insert_select As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_insert_title As System.Windows.Forms.TextBox
    Friend WithEvents txt_insert_description As System.Windows.Forms.TextBox
    Friend WithEvents pic_viewimage As System.Windows.Forms.PictureBox
    Friend WithEvents btn_insertimage As System.Windows.Forms.Button
    Friend WithEvents btn_updateimage As System.Windows.Forms.Button
    Friend WithEvents btn_viewimage As System.Windows.Forms.Button
    Friend WithEvents tab_container As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btn_opendb As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lst_tables As System.Windows.Forms.ListBox
    Friend WithEvents btn_tables_delete As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lst_delete_records As System.Windows.Forms.ListBox
    Friend WithEvents pic_insert_image As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_update_tables As System.Windows.Forms.ComboBox
    Friend WithEvents pic_update_image As System.Windows.Forms.PictureBox
    Friend WithEvents txt_update_description As System.Windows.Forms.TextBox
    Friend WithEvents txt_update_title As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents txt_dbpath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_insert_tables As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_update_records As System.Windows.Forms.ComboBox
    Friend WithEvents btn_update_select As System.Windows.Forms.Button
    Friend WithEvents cmb_delete_tables As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
