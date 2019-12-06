Module MdlStudents
    Public Sub StudentsInfoViewing()
        FrmStudents.Studentsdisplay.Items.Clear()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from TblStudents order by StudentNumber ", con)
        con.Open()
        dr = cmd.ExecuteReader
        Dim x As Integer = 0
        While dr.Read
            FrmStudents.Studentsdisplay.Items.Add(dr.GetValue(0).ToString())
            FrmStudents.Studentsdisplay.Items(x).SubItems.Add(dr.GetValue(1).ToString())
            FrmStudents.Studentsdisplay.Items(x).SubItems.Add(dr.GetValue(2).ToString())
            FrmStudents.Studentsdisplay.Items(x).SubItems.Add(dr.GetValue(3).ToString())
            FrmStudents.Studentsdisplay.Items(x).SubItems.Add(dr.GetValue(4).ToString())
            FrmStudents.Studentsdisplay.Items(x).SubItems.Add(dr.GetValue(5).ToString())
            FrmStudents.Studentsdisplay.Items(x).SubItems.Add(dr.GetValue(6).ToString())
            FrmStudents.Studentsdisplay.Items(x).SubItems.Add(dr.GetValue(7).ToString())
            x = x + 1
        End While
        con.Close()
    End Sub
    Public Sub selectstudent()
        Dim a As Integer = 0

        a = FrmStudents.Studentsdisplay.FocusedItem().Index

        FrmStudents.txtstudentnumber.Text = FrmStudents.Studentsdisplay.Items(a).Text
        FrmStudents.txtgname.Text = FrmStudents.Studentsdisplay.Items(a).SubItems.Item(3).Text
        FrmStudents.txtmname.Text = FrmStudents.Studentsdisplay.Items(a).SubItems.Item(4).Text
        FrmStudents.txtsname.Text = FrmStudents.Studentsdisplay.Items(a).SubItems.Item(5).Text
        FrmStudents.txtaddress.Text = FrmStudents.Studentsdisplay.Items(a).SubItems.Item(6).Text
        FrmStudents.txtguardianname.Text = FrmStudents.Studentsdisplay.Items(a).SubItems.Item(7).Text
        FrmStudents.txtguardiancontactnumber.Text = FrmStudents.Studentsdisplay.Items(a).SubItems.Item(8).Text

    End Sub
    Public Sub studentinfoclear()
        FrmStudents.txtstudentfilter.Clear()
        FrmStudents.txtstudentnumber.Clear()
        FrmStudents.txtgname.Clear()
        FrmStudents.txtmname.Clear()
        FrmStudents.txtsname.Clear()
        FrmStudents.txtaddress.Clear()
        FrmStudents.txtguardianname.Clear()
        FrmStudents.txtguardiancontactnumber.Clear()
    End Sub
    Public Sub studentdefault()
        FrmStudents.txtstudentfilter.Enabled = True
        FrmStudents.txtstudentnumber.Enabled = False
        FrmStudents.txtgname.Enabled = False
        FrmStudents.txtmname.Enabled = False
        FrmStudents.txtsname.Enabled = False
        FrmStudents.txtaddress.Enabled = False
        FrmStudents.txtguardianname.Enabled = False
        FrmStudents.txtguardiancontactnumber.Enabled = False
    End Sub
    Public Sub initializestudentbuttons()
        FrmStudents.btnaddstudent.Enabled = True
        FrmStudents.btneditstudent.Enabled = False
        FrmStudents.btndeletestudent.Enabled = False
        FrmStudents.btnsavestudent.Enabled = False
        FrmStudents.btncancel.Enabled = False
    End Sub
    Public Sub addstudentbuttons()
        FrmStudents.btnaddstudent.Enabled = False
        FrmStudents.btneditstudent.Enabled = False
        FrmStudents.btndeletestudent.Enabled = False
        FrmStudents.btnsavestudent.Enabled = True
        FrmStudents.btncancel.Enabled = True
    End Sub
    Public Sub studentinfoenabled()
        FrmStudents.txtstudentfilter.Enabled = False
        FrmStudents.txtstudentnumber.Enabled = True
        FrmStudents.txtgname.Enabled = True
        FrmStudents.txtmname.Enabled = True
        FrmStudents.txtsname.Enabled = True
        FrmStudents.txtaddress.Enabled = True
        FrmStudents.txtguardianname.Enabled = True
        FrmStudents.txtguardiancontactnumber.Enabled = True
    End Sub
    Public Sub selectedstudentbuttons()
        FrmStudents.btnaddstudent.Enabled = False
        FrmStudents.btneditstudent.Enabled = True
        FrmStudents.btndeletestudent.Enabled = True
        FrmStudents.btnsavestudent.Enabled = False
        FrmStudents.btncancel.Enabled = True
    End Sub
    Public Sub studentdelete()
        con.Open()
        Dim cmd As New SqlClient.SqlCommand("delete from TblStudents where StudentNumber='" & FrmStudents.txtstudentnumber.Text & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub StudentSave()
        If Not FrmStudents.txtstudentnumber.Text = " " Or Not FrmStudents.txtgname.Text = " " Or Not FrmStudents.txtmname.Text = " " Or Not FrmStudents.txtsname.Text = " " Or Not FrmStudents.txtaddress.Text = " " Or Not FrmStudents.txtguardianname.Text = " " Or Not FrmStudents.txtguardiancontactnumber.Text = " " Then
            If mode = "new" Then
                con.Open()
                Dim cmd As New SqlClient.SqlCommand("insert into TblStudents (StudentNumber,GivenName,MiddleName,LastName,Address,GuardianName,GuardianContactNumber)values ('" & FrmStudents.txtstudentnumber.Text & "','" & FrmStudents.txtgname.Text & "','" & FrmStudents.txtmname.Text & "','" & FrmStudents.txtsname.Text & "','" & FrmStudents.txtaddress.Text & "','" & FrmStudents.txtguardianname.Text & "','" & FrmStudents.txtguardiancontactnumber.Text & "')", con)
                Dim rowsaffected As Integer = cmd.ExecuteNonQuery()
                If rowsaffected > 0 Then
                    MsgBox("Successfully added an Account!")
                    con.Close()
                    studentdefault()
                    studentinfoclear()
                    StudentsInfoViewing()
                    initializestudentbuttons()
                Else
                    MsgBox("Cannot Add Account Properly")
                End If

            ElseIf mode = "edit" Then
                con.Open()
                Dim cmd As New SqlClient.SqlCommand("Update TblStudents set LastName='" & FrmStudents.txtsname.Text & "',GivenName='" & FrmStudents.txtgname.Text & "',MiddleName='" & FrmStudents.txtmname.Text & "',Address='" & FrmStudents.txtaddress.Text & "',GuardianName='" & FrmStudents.txtguardianname.Text & "',GuardianContactNumber='" & FrmStudents.txtguardiancontactnumber.Text & "'where StudentNumber ='" & FrmStudents.txtstudentnumber.Text & "'", con)
                cmd.ExecuteNonQuery()
                con.Close()
                studentdefault()
                studentinfoclear()
                StudentsInfoViewing()
                initializestudentbuttons()

            End If
        Else
            MsgBox("Please Fill all Fields")
        End If
    End Sub
End Module
