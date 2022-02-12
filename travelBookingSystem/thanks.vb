Public Class thankForm
    Private Sub signoutBtn_Click(sender As Object, e As EventArgs) Handles signoutBtn.Click
        Me.Close()
        packageForm.Close()
        bookForm.Close()
        signForm.Show()
    End Sub
End Class