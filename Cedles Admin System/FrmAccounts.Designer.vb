<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAccounts
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
        Me.components = New System.ComponentModel.Container()
        Me.Header1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnTeachers = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtaccountfilter = New System.Windows.Forms.MaskedTextBox()
        Me.AccountFilter = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.accountdisplay = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.txtgname = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.PictureBox()
        Me.btndeleteaccount = New System.Windows.Forms.PictureBox()
        Me.btnsaveaccount = New System.Windows.Forms.PictureBox()
        Me.btneditaccount = New System.Windows.Forms.PictureBox()
        Me.btnaddaccount = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbusertypes = New System.Windows.Forms.ComboBox()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndeleteaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsaveaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneditaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnaddaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Header1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Header1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header1.ForeColor = System.Drawing.Color.White
        Me.Header1.Location = New System.Drawing.Point(0, 0)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(944, 29)
        Me.Header1.TabIndex = 395
        Me.Header1.Text = "CEDLES "
        Me.Header1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(944, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 29)
        Me.Button3.TabIndex = 394
        Me.Button3.Text = " ✖"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnTeachers
        '
        Me.BtnTeachers.BackColor = System.Drawing.Color.White
        Me.BtnTeachers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTeachers.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTeachers.ForeColor = System.Drawing.Color.Gray
        Me.BtnTeachers.Location = New System.Drawing.Point(408, 29)
        Me.BtnTeachers.Name = "BtnTeachers"
        Me.BtnTeachers.Size = New System.Drawing.Size(210, 56)
        Me.BtnTeachers.TabIndex = 401
        Me.BtnTeachers.Text = "TEACHERS"
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
        Me.BtnStudents.Location = New System.Drawing.Point(199, 29)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(210, 56)
        Me.BtnStudents.TabIndex = 400
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
        Me.btnHome.Size = New System.Drawing.Size(200, 56)
        Me.btnHome.TabIndex = 399
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
        Me.btnOut.Location = New System.Drawing.Point(826, 29)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(200, 56)
        Me.btnOut.TabIndex = 398
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
        Me.BtnAccounts.Location = New System.Drawing.Point(617, 29)
        Me.BtnAccounts.Name = "BtnAccounts"
        Me.BtnAccounts.Size = New System.Drawing.Size(210, 56)
        Me.BtnAccounts.TabIndex = 397
        Me.BtnAccounts.Text = "ACCOUNTS"
        Me.BtnAccounts.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(68, 614)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(60, 30)
        Me.lblTime.TabIndex = 406
        Me.lblTime.Text = "TIME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 584)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 30)
        Me.Label1.TabIndex = 403
        Me.Label1.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 614)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 30)
        Me.Label2.TabIndex = 404
        Me.Label2.Text = "TIME:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(67, 584)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(61, 30)
        Me.lblDate.TabIndex = 405
        Me.lblDate.Text = "DATE"
        '
        'txtaccountfilter
        '
        Me.txtaccountfilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccountfilter.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtaccountfilter.Location = New System.Drawing.Point(6, 107)
        Me.txtaccountfilter.Mask = "AAAAAAAAAAAAAAAAAA"
        Me.txtaccountfilter.Name = "txtaccountfilter"
        Me.txtaccountfilter.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtaccountfilter.ResetOnSpace = False
        Me.txtaccountfilter.Size = New System.Drawing.Size(164, 29)
        Me.txtaccountfilter.TabIndex = 409
        Me.txtaccountfilter.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
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
        Me.AccountFilter.Location = New System.Drawing.Point(176, 108)
        Me.AccountFilter.Name = "AccountFilter"
        Me.AccountFilter.Size = New System.Drawing.Size(24, 28)
        Me.AccountFilter.TabIndex = 407
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
        Me.Label44.TabIndex = 408
        Me.Label44.Text = "Search"
        '
        'accountdisplay
        '
        Me.accountdisplay.BackColor = System.Drawing.Color.Gray
        Me.accountdisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader15, Me.ColumnHeader3, Me.ColumnHeader14})
        Me.accountdisplay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountdisplay.ForeColor = System.Drawing.Color.Black
        Me.accountdisplay.FullRowSelect = True
        Me.accountdisplay.GridLines = True
        Me.accountdisplay.HideSelection = False
        Me.accountdisplay.LabelEdit = True
        Me.accountdisplay.Location = New System.Drawing.Point(207, 288)
        Me.accountdisplay.Name = "accountdisplay"
        Me.accountdisplay.Size = New System.Drawing.Size(819, 344)
        Me.accountdisplay.TabIndex = 415
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
        Me.ColumnHeader15.Width = 200
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
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpassword.Location = New System.Drawing.Point(580, 244)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(159, 29)
        Me.txtconfirmpassword.TabIndex = 423
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(414, 244)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(159, 29)
        Me.txtpassword.TabIndex = 422
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(230, 244)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(175, 29)
        Me.txtusername.TabIndex = 421
        '
        'txtsname
        '
        Me.txtsname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(721, 130)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(152, 29)
        Me.txtsname.TabIndex = 418
        '
        'txtgname
        '
        Me.txtgname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgname.Location = New System.Drawing.Point(229, 130)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(295, 29)
        Me.txtgname.TabIndex = 416
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(717, 107)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(99, 23)
        Me.Label38.TabIndex = 418
        Me.Label38.Text = "Last Name"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(225, 107)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(112, 23)
        Me.Label39.TabIndex = 419
        Me.Label39.Text = "Given Name"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(226, 220)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(95, 23)
        Me.Label41.TabIndex = 420
        Me.Label41.Text = "Username"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(410, 220)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(90, 23)
        Me.Label42.TabIndex = 421
        Me.Label42.Text = "Password"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(576, 221)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(161, 23)
        Me.Label43.TabIndex = 422
        Me.Label43.Text = "Confirm Password"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(229, 185)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(295, 29)
        Me.txtemail.TabIndex = 419
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(225, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 23)
        Me.Label4.TabIndex = 429
        Me.Label4.Text = "Email"
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphonenumber.Location = New System.Drawing.Point(545, 185)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(192, 29)
        Me.txtphonenumber.TabIndex = 420
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(541, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 431
        Me.Label5.Text = "Phone Number"
        '
        'btncancel
        '
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Image = Global.Cedles_Admin_System.My.Resources.Resources.cancel
        Me.btncancel.Location = New System.Drawing.Point(2, 353)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(198, 53)
        Me.btncancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncancel.TabIndex = 414
        Me.btncancel.TabStop = False
        '
        'btndeleteaccount
        '
        Me.btndeleteaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeleteaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.deleteaccount
        Me.btndeleteaccount.Location = New System.Drawing.Point(2, 301)
        Me.btndeleteaccount.Name = "btndeleteaccount"
        Me.btndeleteaccount.Size = New System.Drawing.Size(198, 53)
        Me.btndeleteaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btndeleteaccount.TabIndex = 413
        Me.btndeleteaccount.TabStop = False
        '
        'btnsaveaccount
        '
        Me.btnsaveaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsaveaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.saveaccount
        Me.btnsaveaccount.Location = New System.Drawing.Point(2, 249)
        Me.btnsaveaccount.Name = "btnsaveaccount"
        Me.btnsaveaccount.Size = New System.Drawing.Size(198, 53)
        Me.btnsaveaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsaveaccount.TabIndex = 412
        Me.btnsaveaccount.TabStop = False
        '
        'btneditaccount
        '
        Me.btneditaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.editaccount
        Me.btneditaccount.Location = New System.Drawing.Point(2, 197)
        Me.btneditaccount.Name = "btneditaccount"
        Me.btneditaccount.Size = New System.Drawing.Size(199, 53)
        Me.btneditaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btneditaccount.TabIndex = 411
        Me.btneditaccount.TabStop = False
        '
        'btnaddaccount
        '
        Me.btnaddaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddaccount.Image = Global.Cedles_Admin_System.My.Resources.Resources.addaccount
        Me.btnaddaccount.Location = New System.Drawing.Point(2, 145)
        Me.btnaddaccount.Name = "btnaddaccount"
        Me.btnaddaccount.Size = New System.Drawing.Size(198, 55)
        Me.btnaddaccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnaddaccount.TabIndex = 410
        Me.btnaddaccount.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(1, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 573)
        Me.PictureBox1.TabIndex = 402
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(545, 130)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(152, 29)
        Me.txtmname.TabIndex = 417
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(541, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 433
        Me.Label3.Text = "Middle Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(737, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 23)
        Me.Label6.TabIndex = 435
        Me.Label6.Text = "User Type"
        '
        'cmbusertypes
        '
        Me.cmbusertypes.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Teacher"})
        Me.cmbusertypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbusertypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusertypes.BackColor = System.Drawing.Color.White
        Me.cmbusertypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusertypes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusertypes.ForeColor = System.Drawing.Color.Black
        Me.cmbusertypes.FormattingEnabled = True
        Me.cmbusertypes.Items.AddRange(New Object() {"Admin", "Teachers"})
        Me.cmbusertypes.Location = New System.Drawing.Point(743, 185)
        Me.cmbusertypes.Name = "cmbusertypes"
        Me.cmbusertypes.Size = New System.Drawing.Size(161, 28)
        Me.cmbusertypes.TabIndex = 436
        '
        'FrmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 650)
        Me.Controls.Add(Me.cmbusertypes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtphonenumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.txtgname)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.accountdisplay)
        Me.Controls.Add(Me.txtaccountfilter)
        Me.Controls.Add(Me.AccountFilter)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndeleteaccount)
        Me.Controls.Add(Me.btnsaveaccount)
        Me.Controls.Add(Me.btneditaccount)
        Me.Controls.Add(Me.btnaddaccount)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTeachers)
        Me.Controls.Add(Me.BtnStudents)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.BtnAccounts)
        Me.Controls.Add(Me.Header1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAccounts"
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndeleteaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsaveaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneditaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnaddaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Header1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnTeachers As Button
    Friend WithEvents BtnStudents As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtaccountfilter As MaskedTextBox
    Friend WithEvents AccountFilter As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents btncancel As PictureBox
    Friend WithEvents btndeleteaccount As PictureBox
    Friend WithEvents btnsaveaccount As PictureBox
    Friend WithEvents btneditaccount As PictureBox
    Friend WithEvents btnaddaccount As PictureBox
    Friend WithEvents accountdisplay As ListView
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtsname As TextBox
    Friend WithEvents txtgname As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtmname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbusertypes As ComboBox
End Class
