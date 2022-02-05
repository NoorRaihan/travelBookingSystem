Public Class dashForm
    Private Sub IconButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        signForm.Show()
    End Sub

    Private Sub dashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeLbl.Text = "Welcome Sir, " & signForm.nameTxt.Text
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles manageBtn.Click
        Me.Hide()
        staffForm.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles repoBtn.Click
        Me.Hide()
        reportForm.Show()
    End Sub
End Class