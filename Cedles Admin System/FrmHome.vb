Public Class FrmHome


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click
        FrmStudents.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnSections_Click(sender As Object, e As EventArgs)
        FrmSections.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click
        FrmAccounts.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub


End Class
