Imports System.IO

Public Class reportForm

    Dim readFile As StreamReader

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        End
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub reportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim packageName, line, data() As String
        Dim senior, adult, child, countPackageA, countPackageB, countPackageC As Integer
        Dim packagePrice, addOnPrice, totalPrice, totalAll, totalAddOn, totalPackage, totalPkgA, totalPkgB, totalPkgC, addOnA, addOnB, addOnC As Decimal
        totalAddOn = 0.0
        totalPkgA = 0.0
        totalPkgB = 0.0
        totalPkgC = 0.0
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
                        totalPkgB = packagePrice
                        addOnB += addOnPrice
                    Else
                        countPackageC += (senior + adult + child)
                        totalPkgC += packagePrice
                        addOnC += addOnPrice
                    End If

                Loop
            Else
                MessageBox.Show("Booking file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class