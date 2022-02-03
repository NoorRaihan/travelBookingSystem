Public Class Form8
    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showChk.CheckedChanged

        If showChk.Checked Then
            passTxt.PasswordChar = ""
        Else
            passTxt.PasswordChar = "*"
        End If
    End Sub
End Class