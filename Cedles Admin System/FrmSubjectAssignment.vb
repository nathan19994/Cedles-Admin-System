Public Class FrmSubjectAssignment
    Private Sub FrmSubjectAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSections()
        LoadSubjects()
        LoadTeachers()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Cmbteachers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbteachers.SelectedIndexChanged

    End Sub
End Class