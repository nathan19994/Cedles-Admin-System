<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSectionAssignment
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnSections = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.BtnSubjectAssignment = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnTeachers = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.Header1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.txtstudentfilter = New System.Windows.Forms.MaskedTextBox()
        Me.AccountFilter = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.accountdisplay = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btncancel = New System.Windows.Forms.PictureBox()
        Me.btndeletestudent = New System.Windows.Forms.PictureBox()
        Me.btnsavestudent = New System.Windows.Forms.PictureBox()
        Me.btneditstudent = New System.Windows.Forms.PictureBox()
        Me.btnaddstudent = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtstudentnumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtgname = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cmbsections = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndeletestudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsavestudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneditstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnaddstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnSections.TabIndex = 482
        Me.BtnSections.Text = "SECTIONS"
        Me.BtnSections.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(58, 627)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(44, 21)
        Me.lblTime.TabIndex = 481
        Me.lblTime.Text = "TIME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 597)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 478
        Me.Label1.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 627)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 479
        Me.Label2.Text = "TIME:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(57, 597)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 21)
        Me.lblDate.TabIndex = 480
        Me.lblDate.Text = "DATE"
        '
        'BtnSubjectAssignment
        '
        Me.BtnSubjectAssignment.BackColor = System.Drawing.Color.White
        Me.BtnSubjectAssignment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubjectAssignment.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnSubjectAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubjectAssignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubjectAssignment.ForeColor = System.Drawing.Color.Gray
        Me.BtnSubjectAssignment.Location = New System.Drawing.Point(676, 26)
        Me.BtnSubjectAssignment.Name = "BtnSubjectAssignment"
        Me.BtnSubjectAssignment.Size = New System.Drawing.Size(170, 56)
        Me.BtnSubjectAssignment.TabIndex = 477
        Me.BtnSubjectAssignment.Text = "SUBJECT ASSIGNMENT"
        Me.BtnSubjectAssignment.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 573)
        Me.PictureBox1.TabIndex = 476
        Me.PictureBox1.TabStop = False
        '
        'BtnTeachers
        '
        Me.BtnTeachers.BackColor = System.Drawing.Color.White
        Me.BtnTeachers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTeachers.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTeachers.ForeColor = System.Drawing.Color.Gray
        Me.BtnTeachers.Location = New System.Drawing.Point(507, 26)
        Me.BtnTeachers.Name = "BtnTeachers"
        Me.BtnTeachers.Size = New System.Drawing.Size(170, 56)
        Me.BtnTeachers.TabIndex = 475
        Me.BtnTeachers.Text = "SECTION ASSIGNMENT"
        Me.BtnTeachers.UseVisualStyleBackColor = False
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
        Me.BtnStudents.TabIndex = 474
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
        Me.btnHome.TabIndex = 473
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
        Me.btnOut.TabIndex = 472
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
        Me.BtnAccounts.TabIndex = 471
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
        Me.Header1.TabIndex = 470
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
        Me.BtnClose.Location = New System.Drawing.Point(1102, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(82, 29)
        Me.BtnClose.TabIndex = 469
        Me.BtnClose.Text = " ✖"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'txtstudentfilter
        '
        Me.txtstudentfilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentfilter.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtstudentfilter.Location = New System.Drawing.Point(4, 100)
        Me.txtstudentfilter.Mask = "AAAAAAAAAAAAAAAAAA"
        Me.txtstudentfilter.Name = "txtstudentfilter"
        Me.txtstudentfilter.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtstudentfilter.ResetOnSpace = False
        Me.txtstudentfilter.Size = New System.Drawing.Size(131, 29)
        Me.txtstudentfilter.TabIndex = 485
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
        Me.AccountFilter.Location = New System.Drawing.Point(141, 101)
        Me.AccountFilter.Name = "AccountFilter"
        Me.AccountFilter.Size = New System.Drawing.Size(24, 28)
        Me.AccountFilter.TabIndex = 483
        Me.AccountFilter.Tag = ""
        Me.AccountFilter.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(3, 80)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(66, 20)
        Me.Label44.TabIndex = 484
        Me.Label44.Text = "Search"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'accountdisplay
        '
        Me.accountdisplay.BackColor = System.Drawing.Color.Gray
        Me.accountdisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader1})
        Me.accountdisplay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountdisplay.ForeColor = System.Drawing.Color.Black
        Me.accountdisplay.FullRowSelect = True
        Me.accountdisplay.GridLines = True
        Me.accountdisplay.HideSelection = False
        Me.accountdisplay.LabelEdit = True
        Me.accountdisplay.Location = New System.Drawing.Point(169, 257)
        Me.accountdisplay.Name = "accountdisplay"
        Me.accountdisplay.Size = New System.Drawing.Size(803, 396)
        Me.accountdisplay.TabIndex = 486
        Me.accountdisplay.UseCompatibleStateImageBehavior = False
        Me.accountdisplay.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Year Level"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Section Name"
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Student Number"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student Name"
        Me.ColumnHeader1.Width = 350
        '
        'btncancel
        '
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Location = New System.Drawing.Point(2, 361)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(168, 53)
        Me.btncancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncancel.TabIndex = 491
        Me.btncancel.TabStop = False
        '
        'btndeletestudent
        '
        Me.btndeletestudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeletestudent.Location = New System.Drawing.Point(2, 309)
        Me.btndeletestudent.Name = "btndeletestudent"
        Me.btndeletestudent.Size = New System.Drawing.Size(168, 53)
        Me.btndeletestudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btndeletestudent.TabIndex = 490
        Me.btndeletestudent.TabStop = False
        '
        'btnsavestudent
        '
        Me.btnsavestudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavestudent.Location = New System.Drawing.Point(2, 257)
        Me.btnsavestudent.Name = "btnsavestudent"
        Me.btnsavestudent.Size = New System.Drawing.Size(168, 53)
        Me.btnsavestudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsavestudent.TabIndex = 489
        Me.btnsavestudent.TabStop = False
        '
        'btneditstudent
        '
        Me.btneditstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditstudent.Location = New System.Drawing.Point(2, 205)
        Me.btneditstudent.Name = "btneditstudent"
        Me.btneditstudent.Size = New System.Drawing.Size(168, 53)
        Me.btneditstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btneditstudent.TabIndex = 488
        Me.btneditstudent.TabStop = False
        '
        'btnaddstudent
        '
        Me.btnaddstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddstudent.Location = New System.Drawing.Point(2, 153)
        Me.btnaddstudent.Name = "btnaddstudent"
        Me.btnaddstudent.Size = New System.Drawing.Size(168, 53)
        Me.btnaddstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnaddstudent.TabIndex = 487
        Me.btnaddstudent.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(381, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 23)
        Me.Label6.TabIndex = 494
        Me.Label6.Text = "Section Name"
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
        Me.ComboBox1.Items.AddRange(New Object() {"Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6"})
        Me.ComboBox1.Location = New System.Drawing.Point(198, 123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 28)
        Me.ComboBox1.TabIndex = 493
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(192, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 492
        Me.Label5.Text = "Year Level"
        '
        'txtstudentnumber
        '
        Me.txtstudentnumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentnumber.Location = New System.Drawing.Point(198, 192)
        Me.txtstudentnumber.Name = "txtstudentnumber"
        Me.txtstudentnumber.Size = New System.Drawing.Size(175, 29)
        Me.txtstudentnumber.TabIndex = 496
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(194, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 23)
        Me.Label4.TabIndex = 497
        Me.Label4.Text = "Student Number"
        '
        'txtgname
        '
        Me.txtgname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgname.Location = New System.Drawing.Point(385, 189)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(461, 29)
        Me.txtgname.TabIndex = 498
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(381, 166)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(131, 23)
        Me.Label39.TabIndex = 499
        Me.Label39.Text = "Student Name"
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
        Me.cmbsections.Location = New System.Drawing.Point(385, 126)
        Me.cmbsections.Name = "cmbsections"
        Me.cmbsections.Size = New System.Drawing.Size(256, 28)
        Me.cmbsections.TabIndex = 500
        '
        'FrmSectionAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 650)
        Me.Controls.Add(Me.cmbsections)
        Me.Controls.Add(Me.txtgname)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.txtstudentnumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndeletestudent)
        Me.Controls.Add(Me.btnsavestudent)
        Me.Controls.Add(Me.btneditstudent)
        Me.Controls.Add(Me.btnaddstudent)
        Me.Controls.Add(Me.accountdisplay)
        Me.Controls.Add(Me.txtstudentfilter)
        Me.Controls.Add(Me.AccountFilter)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.BtnSections)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.BtnSubjectAssignment)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTeachers)
        Me.Controls.Add(Me.BtnStudents)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.BtnAccounts)
        Me.Controls.Add(Me.Header1)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSectionAssignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSectionAssignment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndeletestudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsavestudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneditstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnaddstudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSections As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents BtnSubjectAssignment As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnTeachers As Button
    Friend WithEvents BtnStudents As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents Header1 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents txtstudentfilter As MaskedTextBox
    Friend WithEvents AccountFilter As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents accountdisplay As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btncancel As PictureBox
    Friend WithEvents btndeletestudent As PictureBox
    Friend WithEvents btnsavestudent As PictureBox
    Friend WithEvents btneditstudent As PictureBox
    Friend WithEvents btnaddstudent As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstudentnumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtgname As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents cmbsections As ComboBox
End Class
