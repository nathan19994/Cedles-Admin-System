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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSubjectAssignment = New System.Windows.Forms.Button()
        Me.BtnSectionAssignment = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnAccounts = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSections = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.Cedles_Admin_System.My.Resources.Resources.CEDLES_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1184, 565)
        Me.PictureBox1.TabIndex = 398
        Me.PictureBox1.TabStop = False
        '
        'BtnSubjectAssignment
        '
        Me.BtnSubjectAssignment.BackColor = System.Drawing.Color.White
        Me.BtnSubjectAssignment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubjectAssignment.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnSubjectAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubjectAssignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubjectAssignment.ForeColor = System.Drawing.Color.Gray
        Me.BtnSubjectAssignment.Location = New System.Drawing.Point(676, 29)
        Me.BtnSubjectAssignment.Name = "BtnSubjectAssignment"
        Me.BtnSubjectAssignment.Size = New System.Drawing.Size(170, 56)
        Me.BtnSubjectAssignment.TabIndex = 445
        Me.BtnSubjectAssignment.Text = "SUBJECT ASSIGNMENT"
        Me.BtnSubjectAssignment.UseVisualStyleBackColor = False
        '
        'BtnSectionAssignment
        '
        Me.BtnSectionAssignment.BackColor = System.Drawing.Color.White
        Me.BtnSectionAssignment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSectionAssignment.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnSectionAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSectionAssignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSectionAssignment.ForeColor = System.Drawing.Color.Gray
        Me.BtnSectionAssignment.Location = New System.Drawing.Point(507, 29)
        Me.BtnSectionAssignment.Name = "BtnSectionAssignment"
        Me.BtnSectionAssignment.Size = New System.Drawing.Size(170, 56)
        Me.BtnSectionAssignment.TabIndex = 444
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
        Me.BtnStudents.Location = New System.Drawing.Point(169, 29)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(170, 56)
        Me.BtnStudents.TabIndex = 443
        Me.BtnStudents.Text = "STUDENTS"
        Me.BtnStudents.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Gray
        Me.Button4.Location = New System.Drawing.Point(0, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 56)
        Me.Button4.TabIndex = 442
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.White
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.Gray
        Me.BtnLogout.Location = New System.Drawing.Point(1014, 29)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(170, 56)
        Me.BtnLogout.TabIndex = 441
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnAccounts
        '
        Me.BtnAccounts.BackColor = System.Drawing.Color.White
        Me.BtnAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAccounts.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccounts.ForeColor = System.Drawing.Color.Gray
        Me.BtnAccounts.Location = New System.Drawing.Point(845, 29)
        Me.BtnAccounts.Name = "BtnAccounts"
        Me.BtnAccounts.Size = New System.Drawing.Size(170, 56)
        Me.BtnAccounts.TabIndex = 440
        Me.BtnAccounts.Text = "ACCOUNTS"
        Me.BtnAccounts.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1102, 29)
        Me.Label1.TabIndex = 439
        Me.Label1.Text = "CEDLES "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BtnClose.TabIndex = 438
        Me.BtnClose.Text = " ✖"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSections
        '
        Me.BtnSections.BackColor = System.Drawing.Color.White
        Me.BtnSections.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSections.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSections.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSections.ForeColor = System.Drawing.Color.Gray
        Me.BtnSections.Location = New System.Drawing.Point(338, 29)
        Me.BtnSections.Name = "BtnSections"
        Me.BtnSections.Size = New System.Drawing.Size(170, 56)
        Me.BtnSections.TabIndex = 446
        Me.BtnSections.Text = "SECTIONS"
        Me.BtnSections.UseVisualStyleBackColor = False
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 650)
        Me.Controls.Add(Me.BtnSections)
        Me.Controls.Add(Me.BtnSubjectAssignment)
        Me.Controls.Add(Me.BtnSectionAssignment)
        Me.Controls.Add(Me.BtnStudents)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnAccounts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSubjectAssignment As Button
    Friend WithEvents BtnSectionAssignment As Button
    Friend WithEvents BtnStudents As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnAccounts As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSections As Button
End Class
