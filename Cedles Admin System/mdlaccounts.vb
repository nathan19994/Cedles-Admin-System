Module mdlaccounts
    Public mode As String
    Public Sub CreateAccountViewing()
        FrmAccounts.accountdisplay.Items.Clear()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from TblUsers order by Username ", con)
        con.Open()
        dr = cmd.ExecuteReader
        Dim x As Integer = 0
        While dr.Read
            FrmAccounts.accountdisplay.Items.Add(dr.GetValue(0).ToString())
            FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(1).ToString())
            FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(2).ToString())
            FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(3).ToString())
            FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(4).ToString())
            FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(5).ToString())
            FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(6).ToString())
            FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(7).ToString())
            x = x + 1
        End While
        con.Close()
    End Sub

    Public Sub selectaccount()
        Dim a As Integer = 0

        a = FrmAccounts.accountdisplay.FocusedItem().Index

        FrmAccounts.txtusername.Text = FrmAccounts.accountdisplay.Items(a).Text
        FrmAccounts.txtpassword.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(1).Text
        FrmAccounts.txtconfirmpassword.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(1).Text
        FrmAccounts.txtemail.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(2).Text
        FrmAccounts.txtphonenumber.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(3).Text
        FrmAccounts.txtgname.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(4).Text
        FrmAccounts.txtmname.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(5).Text
        FrmAccounts.txtsname.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(6).Text
        FrmAccounts.cmbusertypes.Text = FrmAccounts.accountdisplay.Items(a).SubItems.Item(7).Text
    End Sub
    Public Sub accountinfoclear()
        FrmAccounts.txtaccountfilter.Clear()
        FrmAccounts.txtsname.Clear()
        FrmAccounts.txtmname.Clear()
        FrmAccounts.txtgname.Clear()
        FrmAccounts.txtemail.Clear()
        FrmAccounts.txtphonenumber.Clear()
        FrmAccounts.txtusername.Clear()
        FrmAccounts.txtpassword.Clear()
        FrmAccounts.txtconfirmpassword.Clear()
    End Sub
    Public Sub accountdefault()
        FrmAccounts.txtaccountfilter.Enabled = True
        FrmAccounts.txtsname.Enabled = False
        FrmAccounts.txtmname.Enabled = False
        FrmAccounts.txtgname.Enabled = False
        FrmAccounts.txtemail.Enabled = False
        FrmAccounts.txtphonenumber.Enabled = False
        FrmAccounts.txtusername.Enabled = False
        FrmAccounts.txtpassword.Enabled = False
        FrmAccounts.txtconfirmpassword.Enabled = False
        FrmAccounts.cmbusertypes.Enabled = False
    End Sub
    Public Sub initializeaccountbuttons()
        FrmAccounts.btnaddaccount.Enabled = True
        FrmAccounts.btneditaccount.Enabled = False
        FrmAccounts.btndeleteaccount.Enabled = False
        FrmAccounts.btnsaveaccount.Enabled = False
        FrmAccounts.btncancel.Enabled = False
    End Sub
    Public Sub addaccountbuttons()
        FrmAccounts.btnaddaccount.Enabled = False
        FrmAccounts.btneditaccount.Enabled = False
        FrmAccounts.btndeleteaccount.Enabled = False
        FrmAccounts.btnsaveaccount.Enabled = True
        FrmAccounts.btncancel.Enabled = True
    End Sub
    Public Sub accountinfoenabled()
        FrmAccounts.txtaccountfilter.Enabled = False
        FrmAccounts.txtsname.Enabled = True
        FrmAccounts.txtgname.Enabled = True
        FrmAccounts.txtmname.Enabled = True
        FrmAccounts.txtemail.Enabled = True
        FrmAccounts.txtphonenumber.Enabled = True
        FrmAccounts.txtusername.Enabled = True
        FrmAccounts.txtpassword.Enabled = True
        FrmAccounts.txtconfirmpassword.Enabled = True
        FrmAccounts.cmbusertypes.Enabled = True
    End Sub
    Public Sub AccountSave()
        If Not FrmAccounts.txtsname.Text = " " Or Not FrmAccounts.txtgname.Text = " " Or Not FrmAccounts.txtusername.Text = " " Or Not FrmAccounts.txtpassword.Text = " " Then
            If FrmAccounts.txtpassword.Text = FrmAccounts.txtconfirmpassword.Text Then
                If mode = "new" Then
                    con.Open()
                    Dim cmd As New SqlClient.SqlCommand("insert into TblUsers (LastName,FirstName,MiddleName,Username,Password,Email,ContactNumber,UserType)values ('" & FrmAccounts.txtsname.Text & "','" & FrmAccounts.txtgname.Text & "','" & FrmAccounts.txtmname.Text & "','" & FrmAccounts.txtusername.Text & "','" & FrmAccounts.txtpassword.Text & "','" & FrmAccounts.txtemail.Text & "','" & FrmAccounts.txtphonenumber.Text & "','" & FrmAccounts.cmbusertypes.Text & "')", con)
                    Dim rowsaffected As Integer = cmd.ExecuteNonQuery()
                    If rowsaffected > 0 Then
                        MsgBox("Successfully added an Account!")
                        con.Close()
                        accountdefault()
                        accountinfoclear()
                        CreateAccountViewing()
                        initializeaccountbuttons()
                    Else
                        MsgBox("Cannot Add Account Properly")
                    End If

                ElseIf mode = "edit" Then
                    con.Open()
                    Dim cmd As New SqlClient.SqlCommand("Update TBlUsers set LastName='" & FrmAccounts.txtsname.Text & "',Firstname='" & FrmAccounts.txtgname.Text & "',MiddleName='" & FrmAccounts.txtmname.Text & "',Password='" & FrmAccounts.txtpassword.Text & "',Email ='" & FrmAccounts.txtemail.Text & "',ContactNumber='" & FrmAccounts.txtphonenumber.Text & "',UserType='" & FrmAccounts.cmbusertypes.Text & "'where Username ='" & FrmAccounts.txtusername.Text & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    accountdefault()
                    accountinfoclear()
                    CreateAccountViewing()
                    initializeaccountbuttons()

                End If
            Else
                MsgBox("Password are not the same!")
            End If
        Else
            MsgBox("Please Fill all Fields")
        End If
    End Sub
    Public Sub accountdelete()
        con.Open()
        Dim cmd As New SqlClient.SqlCommand("delete from TblUsers where Username='" & FrmAccounts.txtusername.Text & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub CreateAccountFilter()
        FrmAccounts.accountdisplay.Items.Clear()
        Dim dr As SqlClient.SqlDataReader
        If FrmAccounts.txtaccountfilter.Text = "" Then
            Dim cmd As New SqlClient.SqlCommand("select * from TblUsers order by Username ", con)
            con.Open()
            dr = cmd.ExecuteReader
            Dim x As Integer = 0
            While dr.Read
                FrmAccounts.accountdisplay.Items.Add(dr.GetValue(0).ToString())
                FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(1).ToString())
                FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(2).ToString())
                FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(3).ToString())
                x = x + 1
            End While
            con.Close()
        Else
            Dim cmd As New SqlClient.SqlCommand("select * from TblUsers where  LastName LIKE'" & FrmAccounts.txtaccountfilter.Text & "%" & "' or FirstName LIKE'" & FrmAccounts.txtaccountfilter.Text & "%" & "' or MiddleName LIKE'" & FrmAccounts.txtaccountfilter.Text & "%" & "' or Username LIKE'" & FrmAccounts.txtaccountfilter.Text & "%" & "' or UsetType LIKE'" & FrmAccounts.txtaccountfilter.Text & "%" & "'", con)
            con.Open()
            dr = cmd.ExecuteReader
            Dim x As Integer = 0
            While dr.Read
                FrmAccounts.accountdisplay.Items.Add(dr.GetValue(0).ToString())
                FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(1).ToString())
                FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(2).ToString())
                FrmAccounts.accountdisplay.Items(x).SubItems.Add(dr.GetValue(3).ToString())
                x = x + 1
            End While
            con.Close()
        End If
    End Sub

    Public Sub selectedaccountbuttons()
        FrmAccounts.btnaddaccount.Enabled = False
        FrmAccounts.btneditaccount.Enabled = True
        FrmAccounts.btndeleteaccount.Enabled = True
        FrmAccounts.btnsaveaccount.Enabled = False
        FrmAccounts.btncancel.Enabled = True
    End Sub

End Module
