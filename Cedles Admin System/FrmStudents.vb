Public Class FrmStudents
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FrmHome.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnSections_Click(sender As Object, e As EventArgs)
        FrmSections.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnTeachers_Click(sender As Object, e As EventArgs)
        FrmTeachers.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click
        FrmAccounts.Show()
    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        End
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Header1_Click(sender As Object, e As EventArgs) Handles Header1.Click

    End Sub

    Private Sub FrmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentsInfoViewing()
        studentinfoclear()
        studentdefault()
        initializestudentbuttons()
    End Sub

    Private Sub Studentsdisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Studentsdisplay.SelectedIndexChanged
        selectstudent()
        selectedstudentbuttons()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        studentinfoclear()
        studentdefault()
        StudentsInfoViewing()
        initializestudentbuttons()
    End Sub

    Private Sub Btnaddstudent_Click(sender As Object, e As EventArgs) Handles btnaddstudent.Click
        addstudentbuttons()
        studentinfoenabled()
        mode = "new"
    End Sub

    Private Sub Btneditstudent_Click(sender As Object, e As EventArgs) Handles btneditstudent.Click
        addstudentbuttons()
        studentinfoenabled()
        mode = "edit"
    End Sub

    Private Sub Btndeletestudent_Click(sender As Object, e As EventArgs) Handles btndeletestudent.Click
        studentdelete()
        initializestudentbuttons()
        studentdefault()
        studentinfoclear()
        StudentsInfoViewing()
    End Sub

    Private Sub Btnsavestudent_Click(sender As Object, e As EventArgs) Handles btnsavestudent.Click
        StudentSave()
    End Sub

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click

    End Sub
End Class