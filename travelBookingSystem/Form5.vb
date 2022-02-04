Imports System.IO

Public Class reportForm

    Dim readFile As StreamReader

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        End
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub processCalc()
        Dim packageName, line, data() As String
        Dim senior, adult, child, countPackageA, countPackageB, countPackageC As Integer
        Dim packagePrice, addOnPrice, totalPrice, totalAll, totalAddOn, totalPackage, totalPkgA, totalPkgB, totalPkgC, addOnA, addOnB, addOnC As Decimal
        totalAddOn = 0.0
        totalPkgA = 0.0
        totalPkgB = 0.0
        totalPkgC = 0.0
        totalAll = 0.0
        totalPackage = 0.0
        addOnA = 0.0
        addOnB = 0.0
        addOnC = 0.0
        countPackageA = 0
        countPackageB = 0
        countPackageC = 0

        Try
            If File.Exists("booking.txt") Then
                readFile = File.OpenText("booking.txt")


                Do Until readFile.EndOfStream
                    line = readFile.ReadLine()
                    data = line.Split(";")

                    packageName = data(0)
                    senior = Val(data(1))
                    adult = Val(data(2))
                    child = Val(data(3))
                    packagePrice = Val(data(4))
                    addOnPrice = Val(data(5))
                    totalPrice = Val(data(6))

                    If (packageName = "Package Basic") Then
                        countPackageA += (senior + adult + child)
                        totalPkgA += packagePrice
                        addOnA += addOnPrice
                    ElseIf (packageName = "Package Deluxe") Then
                        countPackageB += (senior + adult + child)
                        totalPkgB += packagePrice
                        addOnB += addOnPrice
                    Else
                        countPackageC += (senior + adult + child)
                        totalPkgC += packagePrice
                        addOnC += addOnPrice
                    End If

                    totalAll += totalPrice
                Loop
                readFile.Close()

                totalPackage = totalPkgA + totalPkgB + totalPkgC
                totalAddOn = addOnA + addOnB + addOnC

                dueLbl.Text = Format(totalAll, "RM#,###0.00")
                pkgLbl.Text = Format(totalPackage, "RM#,###0.00")
                addOnLbl.Text = Format(totalAddOn, "RM#,###0.00")

                pkgALbl.Text = Format(totalPkgA, "RM#,###0.00")
                addOnAlbl.Text = Format(addOnA, "RM#,###0.00")
                countPkgA.Text = countPackageA

                pkgBlbl.Text = Format(totalPkgB, "RM#,###0.00")
                addOnBlbl.Text = Format(addOnB, "RM#,###0.00")
                countPkgB.Text = countPackageB

                pkgClbl.Text = Format(totalPkgC, "RM#,###0.00")
                addOnClbl.Text = Format(addOnC, "RM#,####.00")
                countPkgC.Text = countPackageC

                If (countPackageA > countPackageB And countPackageA > countPackageC) Then
                    highLbl.Text = "PACKAGE BASIC"
                ElseIf (countPackageB > countPackageA And countPackageB > countPackageC) Then
                    highLbl.Text = "PACKAGE DELUXE"
                Else
                    highLbl.Text = "PACKAGE PREMIUM"
                End If

                If (countPackageA < countPackageB And countPackageA < countPackageC) Then
                    lowLbl.Text = "PACKAGE BASIC"
                ElseIf (countPackageB < countPackageA And countPackageB < countPackageC) Then
                    lowLbl.Text = "PACKAGE DELUXE"
                Else
                    lowLbl.Text = "PACKAGE PREMIUM"
                End If
            Else
                MessageBox.Show("Booking file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub reportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        processCalc()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        processCalc()

    End Sub
End Class