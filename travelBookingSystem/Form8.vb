Imports System.Data.OleDb

Public Class signForm
    Dim con As New OleDbConnection

    Private Sub signBtn_Click(sender As Object, e As EventArgs) Handles signBtn.Click
        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data source = " & Application.StartupPath & "\Login.accdb"
        con.Open()
        Dim logincmd As OleDbCommand = New OleDbCommand("Select * from Login where [USERNAME] = '" & nameTxt.Text & "' and [PASSWORD] ='" & passTxt.Text & "'", con)
        Dim loginrd As OleDbDataReader = logincmd.ExecuteReader
        If (loginrd.read() = True) Then
            Me.Hide()
            dashForm.Show()
            MessageBox.Show("Login Successful" & vbNewLine & "Login User : " & nameTxt.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Login Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub showChk_CheckedChanged(sender As Object, e As EventArgs) Handles showChk.CheckedChanged
        If showChk.Checked Then
            passTxt.PasswordChar = ""
        Else
            passTxt.PasswordChar = "*"
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        End
    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        Me.Hide()
        packageForm.Show()
    End Sub
End Class