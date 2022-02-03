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
        packageName = "Package Basic"
        seniorPrice = 350.0
        adultPrice = 450.0
        childPrice = 250.0
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        cancelBtn.Visible = False
        confirmBtn.Visible = False
        packageABtn.Enabled = True
        packageBBtn.Enabled = True
        packageCBtn.Enabled = True
        packageName = ""
        seniorPrice = 0.0
        adultPrice = 0.0
        childPrice = 0.0
    End Sub

    Private Sub packageBBtn_Click(sender As Object, e As EventArgs) Handles packageBBtn.Click
        confirmBtn.Visible = True
        cancelBtn.Visible = True
        packageABtn.Enabled = False
        packageBBtn.Enabled = False
        packageCBtn.Enabled = False
        packageName = "Package Deluxe"
        seniorPrice = 550.0
        adultPrice = 650.0
        childPrice = 450.0
    End Sub

    Private Sub packageCBtn_Click(sender As Object, e As EventArgs) Handles packageCBtn.Click
        confirmBtn.Visible = True
        cancelBtn.Visible = True
        packageABtn.Enabled = False
        packageBBtn.Enabled = False
        packageCBtn.Enabled = False
        packageName = "Package Premium"
        seniorPrice = 750.0
        adultPrice = 850.0
        childPrice = 650.0
    End Sub

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Me.Hide()
        bookForm.Show()
    End Sub
End Class