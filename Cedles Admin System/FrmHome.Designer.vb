<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
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
        Me.Header1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnTeachers = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header1
        '
        Me.Header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Header1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Header1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header1.ForeColor = System.Drawing.Color.White
        Me.Header1.Location = New System.Drawing.Point(1, 1)
        Me.Header1.Name = "Header1"
        Me.Header1.Size = New System.Drawing.Size(794, 29)
        Me.Header1.TabIndex = 389
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
        Me.BtnClose.Location = New System.Drawing.Point(793, 1)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(37, 29)
        Me.BtnClose.TabIndex = 388
        Me.BtnClose.Text = " ✖"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnTeachers
        '
        Me.BtnTeachers.BackColor = System.Drawing.Color.White
        Me.BtnTeachers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTeachers.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTeachers.ForeColor = System.Drawing.Color.Gray
        Me.BtnTeachers.Location = New System.Drawing.Point(331, 30)
        Me.BtnTeachers.Name = "BtnTeachers"
        Me.BtnTeachers.Size = New System.Drawing.Size(167, 56)
        Me.BtnTeachers.TabIndex = 397
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
        Me.BtnStudents.Location = New System.Drawing.Point(166, 30)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(166, 56)
        Me.BtnStudents.TabIndex = 396
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
        Me.btnHome.Location = New System.Drawing.Point(1, 30)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(166, 56)
        Me.btnHome.TabIndex = 395
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
        Me.btnOut.Location = New System.Drawing.Point(663, 30)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(167, 56)
        Me.btnOut.TabIndex = 394
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
        Me.BtnAccounts.Location = New System.Drawing.Point(497, 30)
        Me.BtnAccounts.Name = "BtnAccounts"
        Me.BtnAccounts.Size = New System.Drawing.Size(167, 56)
        Me.BtnAccounts.TabIndex = 393
        Me.BtnAccounts.Text = "ACCOUNTS"
        Me.BtnAccounts.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.Cedles_Admin_System.My.Resources.Resources.CEDLES_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(829, 539)
        Me.PictureBox1.TabIndex = 398
        Me.PictureBox1.TabStop = False
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(831, 626)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTeachers)
        Me.Controls.Add(Me.BtnStudents)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.BtnAccounts)
        Me.Controls.Add(Me.Header1)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmHome"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header1 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnTeachers As Button
    Friend WithEvents BtnStudents As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
