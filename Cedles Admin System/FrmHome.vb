Public Class FrmHome
    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click
        FrmStudents.Show()
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

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        End
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnSections_Click(sender As Object, e As EventArgs) Handles BtnSections.Click
        FrmSections.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
