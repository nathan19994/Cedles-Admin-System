Module MdlSubjectAssignments
    Public Sub LoadSections()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from TblSections order by SectionName ", con)
        con.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            FrmSubjectAssignment.cmbsections.Items.Add(dr.GetValue(0).ToString())
        End While
        con.Close()
    End Sub
    Public Sub LoadSubjects()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from TblSubjects order by SubjectName ", con)
        con.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            FrmSubjectAssignment.cmbsubjects.Items.Add(dr.GetValue(0).ToString())
        End While
        con.Close()
    End Sub
    Public Sub LoadTeachers()
        Dim cmd As New SqlClient.SqlCommand("select CONCAT(RTRIM(FirstName),' ',RTRIM(MiddleName),' ',RTRIM(LastName)) from TblUsers where UserType='Teachers' ", con)
        con.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            FrmSubjectAssignment.cmbteachers.Items.Add(dr.GetValue(0).ToString())
        End While
        con.Close()
    End Sub
End Module
