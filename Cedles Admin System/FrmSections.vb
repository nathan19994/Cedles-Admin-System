﻿Public Class FrmSections
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FrmHome.Show()
        Me.Dispose()
    End Sub

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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        End
    End Sub
End Class