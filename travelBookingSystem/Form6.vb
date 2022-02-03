Public Class bookForm

    Dim addon(,) As String = {
        {"Scooter City Tour", "100.00"},
        {"Cruising at Bonsai", "300.00"},
        {"Cooking Class Phong", "150.00"},
        {"Skywalk at bitexco", "120.00"}
    }
    Private Sub bookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pkgLbl.Text = packageForm.packageName
        comboAddon1.Items.Add(addon(0, 0))
        comboAddon1.Items.Add(addon(1, 0))
        comboAddon2.Items.Add(addon(2, 0))
        comboAddon2.Items.Add(addon(3, 0))
        bookBtn.Visible = False
        cancelBtn.Visible = False
        comboAddon1.Enabled = False
        comboAddon2.Enabled = False
        seniorTxt.Text = 0
        adultTxt.Text = 0
        childTxt.Text = 0
        seniorTxt.Enabled = False
        adultTxt.Enabled = False
        childTxt.Enabled = False
    End Sub
End Class