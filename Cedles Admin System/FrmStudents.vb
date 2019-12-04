Public Class FrmStudents
    Private Sub BtnSections_Click(sender As Object, e As EventArgs) Handles BtnSections.Click
        FrmSections.Show()
        Me.Dispose()
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
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM dd, yyyy")
        lblTime.Text = TimeOfDay
    End Sub
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FrmHome.Show()
        Me.Dispose()
    End Sub
    Private Sub BtnSectionAssignment_Click(sender As Object, e As EventArgs) Handles BtnSectionAssignment.Click
        FrmSectionAssignment.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnSubjectAssignment_Click(sender As Object, e As EventArgs) Handles BtnSubjectAssignment.Click
        FrmSubjectAssignment.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click
        FrmAccounts.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        End
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub
End Class