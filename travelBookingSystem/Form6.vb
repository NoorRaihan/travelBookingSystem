Imports System.IO

Public Class bookForm

    Dim writeFile As StreamWriter
    Dim addon(,) As String = {
        {"Scooter City Tour", "100.00"},
        {"Cruising at Bonsai", "300.00"},
        {"Cooking Class Phong", "150.00"},
        {"Skywalk at bitexco", "120.00"},
        {"None", "0.00"}
    }
    Dim totalSenior, totalAdult, totalChild, totalAddOn, totalPeople, totalAll As Decimal
    Dim countSenior, countAdult, countChild As Integer

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        packageForm.Show()
    End Sub

    Private Sub backtest_Click(sender As Object, e As EventArgs)
        Me.Hide()
        packageForm.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        packageForm.Show()
    End Sub

    Dim addOn1, addOn2, displayReceipt As String

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        clearAll()
    End Sub


    Private Sub bookBtn_Click(sender As Object, e As EventArgs) Handles bookBtn.Click
        Try
            writeFile = File.AppendText("booking.txt")
            writeFile.WriteLine("Package " & pkgLbl.Text & ";" & countSenior & ";" & countAdult & ";" & countChild & ";" & totalPeople & ";" & totalAddOn & ";" & totalAll)
            writeFile.Close()

            writeFile = File.AppendText("customer.txt")
            writeFile.WriteLine(receiptTxt.Text)
            writeFile.Close()

            Me.Hide()
            thankForm.Show()
        Catch ex As Exception
            MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboAddon1.Items.Add(addon(0, 0))
        comboAddon1.Items.Add(addon(1, 0))
        comboAddon1.Items.Add(addon(4, 0))
        comboAddon2.Items.Add(addon(2, 0))
        comboAddon2.Items.Add(addon(3, 0))
        comboAddon2.Items.Add(addon(4, 0))
        bookBtn.Visible = False
        cancelBtn.Visible = False
        seniorTxt.Text = 0
        adultTxt.Text = 0
        childTxt.Text = 0
        addOn1 = "None"
        addOn2 = "None"
        displayReceipt = vbNewLine & "=========================== RECEIPT HERE ===========================" & vbNewLine
        receiptTxt.Text = displayReceipt
        'seniorTxt.Enabled = False
        'adultTxt.Enabled = False
        'childTxt.Enabled = False
    End Sub

    Private Function validation() As Integer
        Dim validate As Integer = 1

        If String.IsNullOrEmpty(nameTxt.Text) Then
            MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If String.IsNullOrEmpty(emailTxt.Text) Then
            MessageBox.Show("Email is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        ElseIf Not emailTxt.Text.Contains("@") Then
            MessageBox.Show("Email is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If String.IsNullOrEmpty(icTxt.Text) Then
            MessageBox.Show("IC Number is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If String.IsNullOrEmpty(phoneTxt.Text) Then
            MessageBox.Show("Phone is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If String.IsNullOrEmpty(dateTxt.Text) Then
            MessageBox.Show("Date is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If String.IsNullOrEmpty(seniorTxt.Text) Then
            MessageBox.Show("Put 0 if no value in senior!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        ElseIf Not Integer.TryParse(seniorTxt.Text, 0) Then
            MessageBox.Show("Field must be in number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If String.IsNullOrEmpty(adultTxt.Text) Then
            MessageBox.Show("Put 0 if no value in adult!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        ElseIf Not Integer.TryParse(adultTxt.Text, 0) Then
            MessageBox.Show("Field must be in number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If String.IsNullOrEmpty(childTxt.Text) Then
            MessageBox.Show("Put 0 if no value in child!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        ElseIf Not Integer.TryParse(childTxt.Text, 0) Then
            MessageBox.Show("Field must be in number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If (Val(seniorTxt.Text) = 0 And Val(adultTxt.Text) = 0 And Val(childTxt.Text) = 0) Then
            MessageBox.Show("One of the people area must not be 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        Return 1

    End Function

    Private Sub clearAll()
        bookBtn.Visible = False
        cancelBtn.Visible = False
        seniorTxt.Text = 0
        adultTxt.Text = 0
        childTxt.Text = 0
        addOn1 = "None"
        addOn2 = "None"
        displayReceipt = vbNewLine & "=========================== RECEIPT HERE ===========================" & vbNewLine
        receiptTxt.Text = displayReceipt
        nameTxt.Clear()
        emailTxt.Clear()
        icTxt.Clear()
        phoneTxt.Clear()
        comboAddon1.Text = ""
        comboAddon2.Text = ""
    End Sub
    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click

        Dim valid As Integer = validation()
        Dim addOnprice1, addOnprice2 As Decimal
        addOnprice1 = 0
        addOnprice2 = 0

        If valid = 1 Then
            countSenior = Val(seniorTxt.Text)
            countAdult = Val(adultTxt.Text)
            countChild = Val(childTxt.Text)
            totalSenior = packageForm.seniorPrice * countSenior
            totalAdult = packageForm.adultPrice * countAdult
            totalChild = packageForm.childPrice * countChild
            totalPeople = totalSenior + totalAdult + totalChild
            bookBtn.Visible = True
            cancelBtn.Visible = True

            totalAddOn = 0.0
            If comboAddon1.SelectedItem = addon(0, 0) Then
                addOnprice1 = Val(addon(0, 1))
                addOn1 = addon(0, 0)
            ElseIf comboAddon1.SelectedItem = addon(1, 0) Then
                addOnprice1 = Val(addon(1, 1))
                addOn1 = addon(1, 0)
            ElseIf comboAddon1.SelectedItem = addon(4, 0) Then
                addOnprice1 = Val(addon(4, 1))
                addOn1 = addon(4, 0)
            End If

            If comboAddon2.SelectedItem = addon(2, 0) Then
                addOnprice2 = Val(addon(2, 1))
                addOn2 = addon(2, 0)
            ElseIf comboAddon2.SelectedItem = addon(3, 0) Then
                addOnprice2 = Val(addon(3, 1))
                addOn2 = addon(3, 0)
            ElseIf comboAddon2.SelectedItem = addon(4, 0) Then
                addOnprice2 = Val(addon(4, 1))
                addOn2 = addon(4, 0)
            End If

            totalAddOn = addOnprice1 + addOnprice2
            totalAll = totalPeople + totalAddOn

            displayReceipt &= "Name : " & nameTxt.Text & vbNewLine
            displayReceipt &= "Email : " & emailTxt.Text & vbNewLine
            displayReceipt &= "IC Number : " & icTxt.Text & vbNewLine
            displayReceipt &= "Phone : " & phoneTxt.Text & vbNewLine
            displayReceipt &= "Travel Date : " & dateTxt.Value.Date.ToString("dd/MM/yyyy") & vbNewLine
            displayReceipt &= vbNewLine & "=========================== SELECTED PACKAGE ===========================" & vbNewLine
            displayReceipt &= "Package : " & pkgLbl.Text & vbNewLine

            If (countSenior > 0) Then
                displayReceipt &= "Senior : " & Format(totalSenior, "RM#,####.00") & " (" & countSenior & "people)" & vbNewLine
            End If

            If (countAdult > 0) Then
                displayReceipt &= "Adult : " & Format(totalAdult, "RM#,####.00") & " (" & countAdult & "people)" & vbNewLine
            End If

            If (countChild > 0) Then
                displayReceipt &= "Child : " & Format(totalChild, "RM#,####.00") & " (" & countChild & "people)" & vbNewLine
            End If

            displayReceipt &= "Total Price People : " & Format(totalPeople, "RM#,####.00") & vbNewLine

            displayReceipt &= vbNewLine & "Add On 1 : " & addOn1 & " (" & Format(addOnprice1, "RM#,####.00") & ")" & vbNewLine
            displayReceipt &= "Add On 2 : " & addOn2 & " (" & Format(addOnprice2, "RM#,####.00") & ")" & vbNewLine
            displayReceipt &= "Total add on : " & Format(totalAddOn, "RM#,####.00") & vbNewLine
            displayReceipt &= "Total Price : " & Format(totalAll, "RM#,####.00")
            receiptTxt.Text = displayReceipt

            confirmBtn.Enabled = False
        End If
    End Sub
End Class