Public Class displayForm

    Public totalPrice As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub displayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addOngroupA.Visible = False
        addOngroupB.Visible = False
        addOngroupC.Visible = False
        btnConfirm.Visible = False
        btnCancel.Visible = False
        totalPrice = 0.00
        priceLbl.Text = "CURRENT PRICE: " & totalPrice

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged

    End Sub

    Private Sub btnGroupA_Click(sender As Object, e As EventArgs) Handles btnGroupA.Click
        btnGroupA.Enabled = False
        addOngroupA.Visible = True
        btnGroupB.Enabled = False
        btnGroupC.Enabled = False
        btnConfirm.Visible = True
        btnCancel.Visible = True

        totalPrice = 500.0
        priceLbl.Text = "CURRENT PRICE: RM " & Format(totalPrice, "#,##00.00")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        addOngroupA.Visible = False
        addOngroupB.Visible = False
        addOngroupC.Visible = False
        btnConfirm.Visible = False
        btnCancel.Visible = False
        btnGroupA.Enabled = True
        btnGroupB.Enabled = True
        btnGroupC.Enabled = True
        totalPrice = 0.00
        priceLbl.Text = "CURRENT PRICE: " & totalPrice
    End Sub

    Private Sub btnGroupB_Click(sender As Object, e As EventArgs) Handles btnGroupB.Click
        btnGroupA.Enabled = False
        addOngroupB.Visible = True
        btnGroupB.Enabled = False
        btnGroupC.Enabled = False
        btnConfirm.Visible = True
        btnCancel.Visible = True

        totalPrice = 800.0
        priceLbl.Text = "CURRENT PRICE: RM " & Format(totalPrice, "#,##00.00")
    End Sub

    Private Sub btnGroupC_Click(sender As Object, e As EventArgs) Handles btnGroupC.Click
        btnGroupA.Enabled = False
        addOngroupC.Visible = True
        btnGroupB.Enabled = False
        btnGroupC.Enabled = False
        btnConfirm.Visible = True
        btnCancel.Visible = True

        totalPrice = 1000.0
        priceLbl.Text = "CURRENT PRICE: RM " & Format(totalPrice, "#,##00.00")
    End Sub
End Class
