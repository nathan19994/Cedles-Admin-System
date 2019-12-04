Public Class FrmSections

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs)
        FrmStudents.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnTeachers_Click(sender As Object, e As EventArgs)
        FrmSubjectAssignment.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs)
        FrmAccounts.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        FrmHome.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class