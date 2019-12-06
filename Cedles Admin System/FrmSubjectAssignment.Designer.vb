<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSubjectAssignment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtstudentfilter = New System.Windows.Forms.MaskedTextBox()
        Me.AccountFilter = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cmbsections = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbteachers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbsubjects = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSectionAssignment = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.Header1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.PictureBox()
        Me.btndeleteaccount = New System.Windows.Forms.PictureBox()
        Me.btnsaveaccount = New System.Windows.Forms.PictureBox()
        Me.btneditaccount = New System.Windows.Forms.PictureBox()
        Me.btnaddaccount = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.accountdisplay = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnSections = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndeleteaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsaveaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneditaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnaddaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtstudentfilter
        '
        Me.txtstudentfilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentfilter.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtstudentfilter.Location = New System.Drawing.Point(6, 107)
        Me.txtstudentfilter.Mask = "AAAAAAAAAAAAAAAAAA"
        Me.txtstudentfilter.Name = "txtstudentfilter"
        Me.txtstudentfilter.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtstudentfilter.ResetOnSpace = False
        Me.txtstudentfilter.Size = New System.Drawing.Size(131, 29)
        Me.txtstudentfilter.TabIndex = 427
        Me.txtstudentfilter.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'AccountFilter
        '
        Me.AccountFilter.AccessibleDescription = "Search"
        Me.AccountFilter.AccessibleName = ""
        Me.AccountFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.AccountFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AccountFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountFilter.ForeColor = System.Drawing.Color.White
        Me.AccountFilter.Location = New System.Drawing.Point(143, 108)
        Me.AccountFilter.Name = "AccountFilter"
        Me.AccountFilter.Size = New System.Drawing.Size(24, 28)
        Me.AccountFilter.TabIndex = 425
        Me.AccountFilter.Tag = ""
        Me.AccountFilter.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(5, 87)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(66, 20)
        Me.Label44.TabIndex = 426
        Me.Label44.Text = "Search"
        '
        'cmbsections
        '
        Me.cmbsections.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Teacher"})
        Me.cmbsections.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbsections.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsections.BackColor = System.Drawing.Color.White
        Me.cmbsections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsections.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsections.ForeColor = System.Drawing.Color.Black
        Me.cmbsections.FormattingEnabled = True
        Me.cmbsections.Location = New System.Drawing.Point(429, 136)
        Me.cmbsections.Name = "cmbsections"
        Me.cmbsections.Size = New System.Drawing.Size(161, 28)
        Me.cmbsections.TabIndex = 438
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(423, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 23)
        Me.Label6.TabIndex = 437
        Me.Label6.Text = "Sections"
        '
        'cmbteachers
        '
        Me.cmbteachers.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Teacher"})
        Me.cmbteachers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbteachers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbteachers.BackColor = System.Drawing.Color.White
        Me.cmbteachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbteachers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbteachers.ForeColor = System.Drawing.Color.Black
        Me.cmbteachers.FormattingEnabled = True
        Me.cmbteachers.Location = New System.Drawing.Point(429, 203)
        Me.cmbteachers.Name = "cmbteachers"
        Me.cmbteachers.Size = New System.Drawing.Size(294, 28)
        Me.cmbteachers.TabIndex = 440
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(423, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 23)
        Me.Label3.TabIndex = 439
        Me.Label3.Text = "Teacher Name"
        '
        'cmbsubjects
        '
        Me.cmbsubjects.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Teacher"})
        Me.cmbsubjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbsubjects.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubjects.BackColor = System.Drawing.Color.White
        Me.cmbsubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsubjects.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubjects.ForeColor = System.Drawing.Color.Black
        Me.cmbsubjects.FormattingEnabled = True
        Me.cmbsubjects.Location = New System.Drawing.Point(247, 203)
        Me.cmbsubjects.Name = "cmbsubjects"
        Me.cmbsubjects.Size = New System.Drawing.Size(161, 28)
        Me.cmbsubjects.TabIndex = 442
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(243, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 441
        Me.Label4.Text = "Subject"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(676, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 56)
        Me.Button1.TabIndex = 451
        Me.Button1.Text = "SUBJECT ASSIGNMENT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 573)
        Me.PictureBox1.TabIndex = 450
        Me.PictureBox1.TabStop = False
        '
        'BtnSectionAssignment
        '
        Me.BtnSectionAssignment.BackColor = System.Drawing.Color.White
        Me.BtnSectionAssignment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSectionAssignment.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnSectionAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSectionAssignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSectionAssignment.ForeColor = System.Drawing.Color.Gray
        Me.BtnSectionAssignment.Location = New System.Drawing.Point(507, 26)
        Me.BtnSectionAssignment.Name = "BtnSectionAssignment"
        Me.BtnSectionAssignment.Size = New System.Drawing.Size(170, 56)
        Me.BtnSectionAssignment.TabIndex = 449
        Me.BtnSectionAssignment.Text = "SECTION ASSIGNMENT"
        Me.BtnSectionAssignment.UseVisualStyleBackColor = False
        '
        'BtnStudents
        '
        Me.BtnStudents.BackColor = System.Drawing.Color.White
        Me.BtnStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStudents.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudents.ForeColor = System.Drawing.Color.Gray
        Me.BtnStudents.Location = New System.Drawing.Point(169, 26)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(170, 56)
        Me.BtnStudents.TabIndex = 448
        Me.BtnStudents.Text = "STUDENTS"
        Me.BtnStudents.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.White
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnHome.ForeColor = System.Drawing.Color.Gray
        Me.btnHome.Location = New System.Drawing.Point(0, 26)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(170, 56)
        Me.btnHome.TabIndex = 447
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnOut
        '
        Me.btnOut.BackColor = System.Drawing.Color.White
        Me.btnOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOut.ForeColor = System.Drawing.Color.Gray
        Me.btnOut.Location = New System.Drawing.Point(1014, 26)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(170, 56)
        Me.btnOut.TabIndex = 446
        Me.btnOut.Text = "LOGOUT"
        Me.btnOut.UseVisualStyleBackColor = False
        '
        'BtnAccounts
        '
        Me.BtnAccounts.BackColor = System.Drawing.Color.White
        Me.BtnAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAccounts.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccounts.ForeColor = System.Drawing.Color.Gray
        Me.BtnAccounts.Location = New System.Drawing.Point(845, 26)
        Me.BtnAccounts.Name = "BtnAccounts"
        Me.BtnAccounts.Size = New System.Drawing.Size(170, 56)
        Me.BtnAccounts.TabIndex = 445
        Me.BtnAccounts.Text = "ACCOUNTS"
        Me.BtnAccounts.UseVisualStyleBackColor = False
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Header1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Header1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header1.ForeColor = System.Drawing.Color.White
        Me.Header1.Location = New System.Drawing.Point(0, -3)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(1102, 29)
        Me.Header1.TabIndex = 444
        Me.Header1.Text = "CEDLES "
        Me.Header1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(1102, -3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(82, 29)
        Me.BtnClose.TabIndex = 443
        Me.BtnClose.Text = " ✖"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Image = Global.Cedles_Admin_System.My.Resources.Resources.cancel
        Me.btncancel.Location = New System.Drawing.Point(2, 351)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(168, 53)
        Me.btncancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncancel.TabIndex = 456
        Me.btncancel.TabStop = False
        '
        'btndeleteaccount
        '
        Me.btndeleteaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeleteaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.deleteaccount
        Me.btndeleteaccount.Location = New System.Drawing.Point(2, 301)
        Me.btndeleteaccount.Name = "btndeleteaccount"
        Me.btndeleteaccount.Size = New System.Drawing.Size(168, 53)
        Me.btndeleteaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btndeleteaccount.TabIndex = 455
        Me.btndeleteaccount.TabStop = False
        '
        'btnsaveaccount
        '
        Me.btnsaveaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsaveaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.saveaccount
        Me.btnsaveaccount.Location = New System.Drawing.Point(2, 249)
        Me.btnsaveaccount.Name = "btnsaveaccount"
        Me.btnsaveaccount.Size = New System.Drawing.Size(168, 53)
        Me.btnsaveaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsaveaccount.TabIndex = 454
        Me.btnsaveaccount.TabStop = False
        '
        'btneditaccount
        '
        Me.btneditaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.editaccount
        Me.btneditaccount.Location = New System.Drawing.Point(2, 197)
        Me.btneditaccount.Name = "btneditaccount"
        Me.btneditaccount.Size = New System.Drawing.Size(168, 53)
        Me.btneditaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btneditaccount.TabIndex = 453
        Me.btneditaccount.TabStop = False
        '
        'btnaddaccount
        '
        Me.btnaddaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.addaccount
        Me.btnaddaccount.Location = New System.Drawing.Point(2, 145)
        Me.btnaddaccount.Name = "btnaddaccount"
        Me.btnaddaccount.Size = New System.Drawing.Size(168, 55)
        Me.btnaddaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnaddaccount.TabIndex = 452
        Me.btnaddaccount.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(61, 627)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(44, 21)
        Me.lblTime.TabIndex = 460
        Me.lblTime.Text = "TIME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 597)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 457
        Me.Label1.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 627)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 458
        Me.Label2.Text = "TIME:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(60, 597)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 21)
        Me.lblDate.TabIndex = 459
        Me.lblDate.Text = "DATE"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Teacher"})
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(249, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 28)
        Me.ComboBox1.TabIndex = 462
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(243, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 461
        Me.Label5.Text = "Year Level"
        '
        'accountdisplay
        '
        Me.accountdisplay.BackColor = System.Drawing.Color.Gray
        Me.accountdisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader15, Me.ColumnHeader3, Me.ColumnHeader14, Me.ColumnHeader4})
        Me.accountdisplay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountdisplay.ForeColor = System.Drawing.Color.Black
        Me.accountdisplay.FullRowSelect = True
        Me.accountdisplay.GridLines = True
        Me.accountdisplay.HideSelection = False
        Me.accountdisplay.LabelEdit = True
        Me.accountdisplay.Location = New System.Drawing.Point(169, 307)
        Me.accountdisplay.Name = "accountdisplay"
        Me.accountdisplay.Size = New System.Drawing.Size(846, 344)
        Me.accountdisplay.TabIndex = 463
        Me.accountdisplay.UseCompatibleStateImageBehavior = False
        Me.accountdisplay.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Username"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 135
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Password"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader19.Width = 153
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Email"
        Me.ColumnHeader1.Width = 173
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contact Number"
        Me.ColumnHeader2.Width = 136
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Given Name"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 231
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middle Name"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Last Name"
        Me.ColumnHeader14.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "User Type"
        Me.ColumnHeader4.Width = 100
        '
        'BtnSections
        '
        Me.BtnSections.BackColor = System.Drawing.Color.White
        Me.BtnSections.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSections.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSections.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSections.ForeColor = System.Drawing.Color.Gray
        Me.BtnSections.Location = New System.Drawing.Point(338, 26)
        Me.BtnSections.Name = "BtnSections"
        Me.BtnSections.Size = New System.Drawing.Size(170, 56)
        Me.BtnSections.TabIndex = 464
        Me.BtnSections.Text = "SECTIONS"
        Me.BtnSections.UseVisualStyleBackColor = False
        '
        'FrmSubjectAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 650)
        Me.Controls.Add(Me.BtnSections)
        Me.Controls.Add(Me.accountdisplay)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndeleteaccount)
        Me.Controls.Add(Me.btnsaveaccount)
        Me.Controls.Add(Me.btneditaccount)
        Me.Controls.Add(Me.btnaddaccount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSectionAssignment)
        Me.Controls.Add(Me.BtnStudents)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.BtnAccounts)
        Me.Controls.Add(Me.Header1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.cmbsubjects)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbteachers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbsections)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtstudentfilter)
        Me.Controls.Add(Me.AccountFilter)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSubjectAssignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTeachers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndeleteaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsaveaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneditaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnaddaccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstudentfilter As MaskedTextBox
    Friend WithEvents AccountFilter As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents cmbsections As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbteachers As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbsubjects As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSectionAssignment As Button
    Friend WithEvents BtnStudents As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents Header1 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents btncancel As PictureBox
    Friend WithEvents btndeleteaccount As PictureBox
    Friend WithEvents btnsaveaccount As PictureBox
    Friend WithEvents btneditaccount As PictureBox
    Friend WithEvents btnaddaccount As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents accountdisplay As ListView
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BtnSections As Button
End Class
