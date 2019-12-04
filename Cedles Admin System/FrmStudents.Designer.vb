<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudents
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
        Me.txtstudentfilter = New System.Windows.Forms.MaskedTextBox()
        Me.AccountFilter = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.PictureBox()
        Me.btndeletestudent = New System.Windows.Forms.PictureBox()
        Me.btnsavestudent = New System.Windows.Forms.PictureBox()
        Me.btneditstudent = New System.Windows.Forms.PictureBox()
        Me.btnaddstudent = New System.Windows.Forms.PictureBox()
        Me.Studentsdisplay = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtstudentnumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtguardiancontactnumber = New System.Windows.Forms.TextBox()
        Me.txtguardianname = New System.Windows.Forms.TextBox()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.txtgname = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSubjectAssignment = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSectionAssignment = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.Header1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.BtnSections = New System.Windows.Forms.Button()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndeletestudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsavestudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneditstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnaddstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtstudentfilter
        '
        Me.txtstudentfilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentfilter.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtstudentfilter.Location = New System.Drawing.Point(6, 109)
        Me.txtstudentfilter.Mask = "AAAAAAAAAAAAAAAAAA"
        Me.txtstudentfilter.Name = "txtstudentfilter"
        Me.txtstudentfilter.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtstudentfilter.ResetOnSpace = False
        Me.txtstudentfilter.Size = New System.Drawing.Size(131, 29)
        Me.txtstudentfilter.TabIndex = 422
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
        Me.AccountFilter.TabIndex = 420
        Me.AccountFilter.Tag = ""
        Me.AccountFilter.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(5, 89)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(66, 20)
        Me.Label44.TabIndex = 421
        Me.Label44.Text = "Search"
        '
        'btncancel
        '
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Location = New System.Drawing.Point(2, 355)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(168, 53)
        Me.btncancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncancel.TabIndex = 427
        Me.btncancel.TabStop = False
        '
        'btndeletestudent
        '
        Me.btndeletestudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeletestudent.Location = New System.Drawing.Point(2, 303)
        Me.btndeletestudent.Name = "btndeletestudent"
        Me.btndeletestudent.Size = New System.Drawing.Size(168, 53)
        Me.btndeletestudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btndeletestudent.TabIndex = 426
        Me.btndeletestudent.TabStop = False
        '
        'btnsavestudent
        '
        Me.btnsavestudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavestudent.Location = New System.Drawing.Point(2, 251)
        Me.btnsavestudent.Name = "btnsavestudent"
        Me.btnsavestudent.Size = New System.Drawing.Size(168, 53)
        Me.btnsavestudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsavestudent.TabIndex = 425
        Me.btnsavestudent.TabStop = False
        '
        'btneditstudent
        '
        Me.btneditstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditstudent.Location = New System.Drawing.Point(2, 199)
        Me.btneditstudent.Name = "btneditstudent"
        Me.btneditstudent.Size = New System.Drawing.Size(168, 53)
        Me.btneditstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btneditstudent.TabIndex = 424
        Me.btneditstudent.TabStop = False
        '
        'btnaddstudent
        '
        Me.btnaddstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddstudent.Location = New System.Drawing.Point(2, 147)
        Me.btnaddstudent.Name = "btnaddstudent"
        Me.btnaddstudent.Size = New System.Drawing.Size(168, 53)
        Me.btnaddstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnaddstudent.TabIndex = 423
        Me.btnaddstudent.TabStop = False
        '
        'Studentsdisplay
        '
        Me.Studentsdisplay.BackColor = System.Drawing.Color.Gray
        Me.Studentsdisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.Studentsdisplay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Studentsdisplay.ForeColor = System.Drawing.Color.Black
        Me.Studentsdisplay.FullRowSelect = True
        Me.Studentsdisplay.GridLines = True
        Me.Studentsdisplay.HideSelection = False
        Me.Studentsdisplay.LabelEdit = True
        Me.Studentsdisplay.Location = New System.Drawing.Point(170, 324)
        Me.Studentsdisplay.Name = "Studentsdisplay"
        Me.Studentsdisplay.Size = New System.Drawing.Size(1014, 325)
        Me.Studentsdisplay.TabIndex = 428
        Me.Studentsdisplay.UseCompatibleStateImageBehavior = False
        Me.Studentsdisplay.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Student Number"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 149
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Year Level"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader19.Width = 116
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Section"
        Me.ColumnHeader14.Width = 159
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Given Name"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 250
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Middle Name"
        Me.ColumnHeader1.Width = 129
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Last Name"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Address"
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Guardian Name"
        Me.ColumnHeader4.Width = 300
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Guardian Contact Number"
        Me.ColumnHeader5.Width = 100
        '
        'txtstudentnumber
        '
        Me.txtstudentnumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentnumber.Location = New System.Drawing.Point(233, 141)
        Me.txtstudentnumber.Name = "txtstudentnumber"
        Me.txtstudentnumber.Size = New System.Drawing.Size(175, 29)
        Me.txtstudentnumber.TabIndex = 444
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(229, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 23)
        Me.Label4.TabIndex = 445
        Me.Label4.Text = "Student Number"
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(749, 138)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(153, 29)
        Me.txtmname.TabIndex = 442
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(745, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 443
        Me.Label3.Text = "Middle Name"
        '
        'txtguardiancontactnumber
        '
        Me.txtguardiancontactnumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguardiancontactnumber.Location = New System.Drawing.Point(548, 288)
        Me.txtguardiancontactnumber.Name = "txtguardiancontactnumber"
        Me.txtguardiancontactnumber.Size = New System.Drawing.Size(223, 29)
        Me.txtguardiancontactnumber.TabIndex = 441
        '
        'txtguardianname
        '
        Me.txtguardianname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguardianname.Location = New System.Drawing.Point(233, 289)
        Me.txtguardianname.Name = "txtguardianname"
        Me.txtguardianname.Size = New System.Drawing.Size(294, 29)
        Me.txtguardianname.TabIndex = 439
        '
        'txtsname
        '
        Me.txtsname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(922, 138)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(152, 29)
        Me.txtsname.TabIndex = 433
        '
        'txtgname
        '
        Me.txtgname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgname.Location = New System.Drawing.Point(433, 138)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(295, 29)
        Me.txtgname.TabIndex = 432
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(918, 115)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(99, 23)
        Me.Label38.TabIndex = 434
        Me.Label38.Text = "Last Name"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(429, 115)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(112, 23)
        Me.Label39.TabIndex = 435
        Me.Label39.Text = "Given Name"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(229, 265)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(141, 23)
        Me.Label41.TabIndex = 436
        Me.Label41.Text = "Guardian Name"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(544, 265)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(227, 23)
        Me.Label43.TabIndex = 438
        Me.Label43.Text = "Guardian Contact Number"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(233, 210)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(741, 29)
        Me.txtaddress.TabIndex = 451
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(229, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 450
        Me.Label7.Text = "Address"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.BtnSubjectAssignment.TabIndex = 465
        Me.BtnSubjectAssignment.Text = "SUBJECT ASSIGNMENT"
        Me.BtnSubjectAssignment.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 573)
        Me.PictureBox1.TabIndex = 464
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
        Me.BtnSectionAssignment.TabIndex = 463
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
        Me.BtnStudents.TabIndex = 462
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
        Me.btnHome.TabIndex = 461
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
        Me.btnOut.TabIndex = 460
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
        Me.BtnAccounts.TabIndex = 459
        Me.BtnAccounts.Text = "ACCOUNTS"
        Me.BtnAccounts.UseVisualStyleBackColor = False
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Header1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Header1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header1.ForeColor = System.Drawing.Color.White
        Me.Header1.Location = New System.Drawing.Point(-3, -3)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(1105, 29)
        Me.Header1.TabIndex = 458
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
        Me.BtnClose.Size = New System.Drawing.Size(82, 26)
        Me.BtnClose.TabIndex = 457
        Me.BtnClose.Text = " ✖"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(59, 626)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(44, 21)
        Me.lblTime.TabIndex = 469
        Me.lblTime.Text = "TIME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 596)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 466
        Me.Label1.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 626)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 467
        Me.Label2.Text = "TIME:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(58, 596)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 21)
        Me.lblDate.TabIndex = 468
        Me.lblDate.Text = "DATE"
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
        Me.BtnSections.TabIndex = 470
        Me.BtnSections.Text = "SECTIONS"
        Me.BtnSections.UseVisualStyleBackColor = False
        '
        'FrmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 650)
        Me.Controls.Add(Me.BtnSections)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.BtnSubjectAssignment)
        Me.Controls.Add(Me.BtnSectionAssignment)
        Me.Controls.Add(Me.BtnStudents)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.BtnAccounts)
        Me.Controls.Add(Me.Header1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtstudentnumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtguardiancontactnumber)
        Me.Controls.Add(Me.txtguardianname)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.txtgname)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Studentsdisplay)
        Me.Controls.Add(Me.txtstudentfilter)
        Me.Controls.Add(Me.AccountFilter)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndeletestudent)
        Me.Controls.Add(Me.btnsavestudent)
        Me.Controls.Add(Me.btneditstudent)
        Me.Controls.Add(Me.btnaddstudent)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmStudents"
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndeletestudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsavestudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneditstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnaddstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstudentfilter As MaskedTextBox
    Friend WithEvents AccountFilter As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents btncancel As PictureBox
    Friend WithEvents btndeletestudent As PictureBox
    Friend WithEvents btnsavestudent As PictureBox
    Friend WithEvents btneditstudent As PictureBox
    Friend WithEvents btnaddstudent As PictureBox
    Friend WithEvents Studentsdisplay As ListView
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents txtstudentnumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtguardiancontactnumber As TextBox
    Friend WithEvents txtguardianname As TextBox
    Friend WithEvents txtsname As TextBox
    Friend WithEvents txtgname As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnSubjectAssignment As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSectionAssignment As Button
    Friend WithEvents BtnStudents As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents Header1 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents BtnSections As Button
End Class
