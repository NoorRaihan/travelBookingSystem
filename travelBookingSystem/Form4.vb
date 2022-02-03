Public Class packageForm

    Public packageName As String
    Public seniorPrice As Decimal
    Public adultPrice As Decimal
    Public childPrice As Decimal
    Private Sub packageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(1140, 840)
        confirmBtn.Visible = False
        cancelBtn.Visible = False
        seniorPrice = 0.00
        adultPrice = 0.00
        childPrice = 0.00
    End Sub

    Private Sub packageABtn_Click(sender As Object, e As EventArgs) Handles packageABtn.Click
        confirmBtn.Visible = True
        cancelBtn.Visible = True
        packageABtn.Enabled = False
        packageBBtn.Enabled = False
        packageCBtn.Enabled = False
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        cancelBtn.Visible = False
        confirmBtn.Visible = False
        packageABtn.Enabled = True
        packageBBtn.Enabled = True
        packageCBtn.Enabled = True
    End Sub

    Private Sub packageBBtn_Click(sender As Object, e As EventArgs) Handles packageBBtn.Click
        confirmBtn.Visible = True
        cancelBtn.Visible = True
        packageABtn.Enabled = False
        packageBBtn.Enabled = False
        packageCBtn.Enabled = False
    End Sub

    Private Sub packageCBtn_Click(sender As Object, e As EventArgs) Handles packageCBtn.Click
        confirmBtn.Visible = True
        cancelBtn.Visible = True
        packageABtn.Enabled = False
        packageBBtn.Enabled = False
        packageCBtn.Enabled = False
    End Sub
End Class