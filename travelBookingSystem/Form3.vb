Public Class dashForm
    Private Sub IconButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Hide()
        signForm.Show()
    End Sub

    Private Sub dashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeLbl.Text = "Welcome Sir, " & signForm.nameTxt.Text & " hesmes"
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        staffForm.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        reportForm.Show()
    End Sub
End Class