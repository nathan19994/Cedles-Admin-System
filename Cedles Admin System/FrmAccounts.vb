Public Class FrmAccounts
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FrmHome.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click
        FrmStudents.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnTeachers_Click(sender As Object, e As EventArgs) Handles BtnTeachers.Click
        FrmSubjectAssignment.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        End
    End Sub

    Private Sub FrmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateAccountViewing()
        accountdefault()
        initializeaccountbuttons()
        accountinfoclear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM dd, yyyy")
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub Btnaddaccount_Click(sender As Object, e As EventArgs) Handles btnaddaccount.Click
        addaccountbuttons()
        accountinfoenabled()
        mode = "new"
    End Sub

    Private Sub Btneditaccount_Click(sender As Object, e As EventArgs) Handles btneditaccount.Click
        accountinfoenabled()
        addaccountbuttons()
        mode = "edit"
    End Sub

    Private Sub Btnsaveaccount_Click(sender As Object, e As EventArgs) Handles btnsaveaccount.Click
        AccountSave()
    End Sub

    Private Sub Btndeleteaccount_Click(sender As Object, e As EventArgs) Handles btndeleteaccount.Click
        accountdelete()
        initializeaccountbuttons()
        accountdefault()
        accountinfoclear()
        CreateAccountViewing()
    End Sub

    Private Sub AccountFilter_Click(sender As Object, e As EventArgs) Handles AccountFilter.Click
        CreateAccountFilter()
        btncancel.Enabled = True
    End Sub

    Private Sub Accountdisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles accountdisplay.SelectedIndexChanged
        selectedaccountbuttons()
        selectaccount()
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        CreateAccountViewing()
        accountdefault()
        initializeaccountbuttons()
        accountinfoclear()
    End Sub
    Private Sub BtnSections_Click(sender As Object, e As EventArgs) Handles BtnSections.Click
        FrmSections.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnSubjectAssignment_Click(sender As Object, e As EventArgs) Handles BtnSubjectAssignment.Click
        FrmSubjectAssignment.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub
End Class