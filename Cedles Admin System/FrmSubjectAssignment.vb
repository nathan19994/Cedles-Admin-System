Public Class FrmSubjectAssignment
    Private Sub FrmSubjectAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSections()
        LoadTeachers()
    End Sub


    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click
        FrmStudents.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnSections_Click(sender As Object, e As EventArgs) Handles BtnSections.Click
        FrmSections.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FrmHome.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnSectionAssignment_Click(sender As Object, e As EventArgs) Handles BtnSectionAssignment.Click
        FrmSectionAssignment.Show()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM dd, yyyy")
        lblTime.Text = TimeOfDay
    End Sub


End Class