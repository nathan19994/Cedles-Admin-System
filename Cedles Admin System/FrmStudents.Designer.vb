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
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.Header1 = New System.Windows.Forms.Label()
        Me.txtstudentfilter = New System.Windows.Forms.MaskedTextBox()
        Me.AccountFilter = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.PictureBox()
        Me.btndeletestudent = New System.Windows.Forms.PictureBox()
        Me.btnsavestudent = New System.Windows.Forms.PictureBox()
        Me.btneditstudent = New System.Windows.Forms.PictureBox()
        Me.btnaddstudent = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Studentsdisplay = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtyearlevel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.txtsection = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndeletestudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsavestudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneditstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnaddstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnStudents
        '
        Me.BtnStudents.BackColor = System.Drawing.Color.White
        Me.BtnStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStudents.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudents.ForeColor = System.Drawing.Color.Gray
        Me.BtnStudents.Location = New System.Drawing.Point(209, 29)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(210, 56)
        Me.BtnStudents.TabIndex = 384
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
        Me.btnHome.Location = New System.Drawing.Point(0, 29)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(210, 56)
        Me.btnHome.TabIndex = 383
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
        Me.btnOut.Location = New System.Drawing.Point(836, 29)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(210, 56)
        Me.btnOut.TabIndex = 382
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
        Me.BtnAccounts.Location = New System.Drawing.Point(627, 29)
        Me.BtnAccounts.Name = "BtnAccounts"
        Me.BtnAccounts.Size = New System.Drawing.Size(210, 56)
        Me.BtnAccounts.TabIndex = 381
        Me.BtnAccounts.Text = "ACCOUNTS"
        Me.BtnAccounts.UseVisualStyleBackColor = False
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Header1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Header1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header1.ForeColor = System.Drawing.Color.White
        Me.Header1.Location = New System.Drawing.Point(0, 0)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(964, 29)
        Me.Header1.TabIndex = 387
        Me.Header1.Text = "CEDLES "
        Me.Header1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtstudentfilter.Size = New System.Drawing.Size(173, 29)
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
        Me.AccountFilter.Location = New System.Drawing.Point(185, 109)
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
        Me.btncancel.Size = New System.Drawing.Size(207, 53)
        Me.btncancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncancel.TabIndex = 427
        Me.btncancel.TabStop = False
        '
        'btndeletestudent
        '
        Me.btndeletestudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeletestudent.Location = New System.Drawing.Point(2, 303)
        Me.btndeletestudent.Name = "btndeletestudent"
        Me.btndeletestudent.Size = New System.Drawing.Size(207, 53)
        Me.btndeletestudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btndeletestudent.TabIndex = 426
        Me.btndeletestudent.TabStop = False
        '
        'btnsavestudent
        '
        Me.btnsavestudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavestudent.Location = New System.Drawing.Point(2, 251)
        Me.btnsavestudent.Name = "btnsavestudent"
        Me.btnsavestudent.Size = New System.Drawing.Size(207, 53)
        Me.btnsavestudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsavestudent.TabIndex = 425
        Me.btnsavestudent.TabStop = False
        '
        'btneditstudent
        '
        Me.btneditstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditstudent.Location = New System.Drawing.Point(2, 199)
        Me.btneditstudent.Name = "btneditstudent"
        Me.btneditstudent.Size = New System.Drawing.Size(207, 53)
        Me.btneditstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btneditstudent.TabIndex = 424
        Me.btneditstudent.TabStop = False
        '
        'btnaddstudent
        '
        Me.btnaddstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddstudent.Location = New System.Drawing.Point(2, 147)
        Me.btnaddstudent.Name = "btnaddstudent"
        Me.btnaddstudent.Size = New System.Drawing.Size(207, 53)
        Me.btnaddstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnaddstudent.TabIndex = 423
        Me.btnaddstudent.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(88, 586)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(60, 30)
        Me.lblTime.TabIndex = 419
        Me.lblTime.Text = "TIME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 30)
        Me.Label1.TabIndex = 416
        Me.Label1.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 586)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 30)
        Me.Label2.TabIndex = 417
        Me.Label2.Text = "TIME:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(87, 556)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(61, 30)
        Me.lblDate.TabIndex = 418
        Me.lblDate.Text = "DATE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 568)
        Me.PictureBox1.TabIndex = 415
        Me.PictureBox1.TabStop = False
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
        Me.Studentsdisplay.Location = New System.Drawing.Point(215, 353)
        Me.Studentsdisplay.Name = "Studentsdisplay"
        Me.Studentsdisplay.Size = New System.Drawing.Size(830, 300)
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
        'txtyearlevel
        '
        Me.txtyearlevel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyearlevel.Location = New System.Drawing.Point(422, 125)
        Me.txtyearlevel.Name = "txtyearlevel"
        Me.txtyearlevel.Size = New System.Drawing.Size(192, 29)
        Me.txtyearlevel.TabIndex = 446
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(418, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 447
        Me.Label5.Text = "Year Level"
        '
        'txtstudentnumber
        '
        Me.txtstudentnumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentnumber.Location = New System.Drawing.Point(220, 125)
        Me.txtstudentnumber.Name = "txtstudentnumber"
        Me.txtstudentnumber.Size = New System.Drawing.Size(175, 29)
        Me.txtstudentnumber.TabIndex = 444
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(216, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 23)
        Me.Label4.TabIndex = 445
        Me.Label4.Text = "Student Number"
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(535, 177)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(153, 29)
        Me.txtmname.TabIndex = 442
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(531, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 443
        Me.Label3.Text = "Middle Name"
        '
        'txtguardiancontactnumber
        '
        Me.txtguardiancontactnumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguardiancontactnumber.Location = New System.Drawing.Point(535, 294)
        Me.txtguardiancontactnumber.Name = "txtguardiancontactnumber"
        Me.txtguardiancontactnumber.Size = New System.Drawing.Size(223, 29)
        Me.txtguardiancontactnumber.TabIndex = 441
        '
        'txtguardianname
        '
        Me.txtguardianname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguardianname.Location = New System.Drawing.Point(220, 295)
        Me.txtguardianname.Name = "txtguardianname"
        Me.txtguardianname.Size = New System.Drawing.Size(294, 29)
        Me.txtguardianname.TabIndex = 439
        '
        'txtsname
        '
        Me.txtsname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(708, 177)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(152, 29)
        Me.txtsname.TabIndex = 433
        '
        'txtgname
        '
        Me.txtgname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgname.Location = New System.Drawing.Point(219, 177)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(295, 29)
        Me.txtgname.TabIndex = 432
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(704, 154)
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
        Me.Label39.Location = New System.Drawing.Point(215, 154)
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
        Me.Label41.Location = New System.Drawing.Point(216, 271)
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
        Me.Label43.Location = New System.Drawing.Point(531, 271)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(227, 23)
        Me.Label43.TabIndex = 438
        Me.Label43.Text = "Guardian Contact Number"
        '
        'txtsection
        '
        Me.txtsection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsection.Location = New System.Drawing.Point(636, 125)
        Me.txtsection.Name = "txtsection"
        Me.txtsection.Size = New System.Drawing.Size(192, 29)
        Me.txtsection.TabIndex = 448
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(632, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 449
        Me.Label6.Text = "Section"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(219, 239)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(741, 29)
        Me.txtaddress.TabIndex = 451
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(215, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 450
        Me.Label7.Text = "Address"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(964, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 29)
        Me.Button3.TabIndex = 452
        Me.Button3.Text = " ✖"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Guardian Contact Number"
        Me.ColumnHeader5.Width = 100
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(418, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 56)
        Me.Button1.TabIndex = 453
        Me.Button1.Text = "SUBJECT ASSIGNMENT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1046, 673)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsection)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtyearlevel)
        Me.Controls.Add(Me.Label5)
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
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Header1)
        Me.Controls.Add(Me.BtnStudents)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.BtnAccounts)
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

    Friend WithEvents BtnStudents As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents Header1 As Label
    Friend WithEvents txtstudentfilter As MaskedTextBox
    Friend WithEvents AccountFilter As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents btncancel As PictureBox
    Friend WithEvents btndeletestudent As PictureBox
    Friend WithEvents btnsavestudent As PictureBox
    Friend WithEvents btneditstudent As PictureBox
    Friend WithEvents btnaddstudent As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Studentsdisplay As ListView
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents txtyearlevel As TextBox
    Friend WithEvents Label5 As Label
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
    Friend WithEvents txtsection As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
