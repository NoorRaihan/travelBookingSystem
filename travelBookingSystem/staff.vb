Imports System.Data.OleDb
Imports System.IO

Public Class staffForm
    Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data source =" & Application.StartupPath & "\db\Staff.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim rowcount As Integer
    Dim currentrow As Integer

    Private Sub dashBtn_Click(sender As Object, e As EventArgs) Handles dashBtn.Click
        Me.Hide()
        dashForm.Show()
    End Sub

    Private Sub repoBtn_Click(sender As Object, e As EventArgs) Handles repoBtn.Click
        Me.Hide()
        reportForm.Show()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        reportForm.Close()
        dashForm.Close()
        signForm.Show()
    End Sub

    Private Sub staffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            conLbl.Text = "Connected"
            conLbl.ForeColor = Color.Lime
        Catch ex As Exception
            conLbl.Text = "Disconnected"
            conLbl.ForeColor = Color.Red
        End Try
        con.Close()

        idTxt.Text = "[ AUTO ]"
        idTxt.Enabled = False

        loadingDataGridView()
    End Sub

    Sub loadingDataGridView()
        Try
            rowcount = 0
            dataGrid.Rows.Clear()
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from Staff", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dataGrid.Rows.Add(dr.Item("Staff_ID"), dr.Item("Staff Name"), dr.Item("Position"), dr.Item("Salary"), dr.Item("Hire of Date"))
                rowcount += 1
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
        con.Close()

    End Sub

    Sub clear()
        idTxt.Text = "[ AUTO ]"
        nameTxt.Clear()
        posTxt.Clear()
        salaryTxt.Clear()

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clear()
    End Sub

    Sub save()
        Dim dia As DialogResult

        dia = MessageBox.Show("Are you confirm to save data ?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try

            If dia = DialogResult.Yes Then
                con.Open()
                Dim cmd As New OleDb.OleDbCommand("Insert into STAFF(`Staff Name`,`Position`,`Salary`,`Hire of Date`) values (@STAFF_NAME, @POSITION, @SALARY, @HIRE_DATE)", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@STAFF_NAME", nameTxt.Text)
                cmd.Parameters.AddWithValue("@POSTION", posTxt.Text)
                cmd.Parameters.AddWithValue("@SALARY", salaryTxt.Text)
                cmd.Parameters.AddWithValue("@HIRE_DATE", hireDate.Value.ToString("d/MM/yyyy"))
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Data saved ! ", vbInformation, "INFO")
                Else
                    MsgBox("Failed ! ", vbCritical, "ERROR")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
        con.Close()

        loadingDataGridView()
        clear()

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim valid As Integer

        valid = validate()

        If valid = 1 Then
            save()
        End If

    End Sub

    Sub delete()
        Dim dia As DialogResult

        dia = MessageBox.Show("Are you confirm to delete data ?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try

            If dia = DialogResult.Yes Then
                con.Open()
                Dim cmd As New OleDb.OleDbCommand("Delete from STAFF where STAFF_ID = @STAFF_ID", con)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@STAFF_ID", idTxt.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Data deleted ! ", vbInformation, "INFO")
                Else
                    MsgBox("Failed ! ", vbCritical, "ERROR")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
        con.Close()

        loadingDataGridView()
        clear()
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        delete()
    End Sub

    Sub edit()
        Try
            con.Open()
            Dim cmd As New OleDb.OleDbCommand("Update STAFF set `Staff Name` = @STAFF_NAME,`Position` = @POSITION,`Salary` = @SALARY,`Hire of Date` = @HIRE_DATE where STAFF_ID = @ID", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@STAFF_NAME", nameTxt.Text)
            cmd.Parameters.AddWithValue("@POSTION", posTxt.Text)
            cmd.Parameters.AddWithValue("@SALARY", salaryTxt.Text)
            cmd.Parameters.AddWithValue("@HIRE_DATE", hireDate.Value.ToString("d/MM/yyyy"))
            cmd.Parameters.AddWithValue("@STAFF_ID", idTxt.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Data updated ! ", vbInformation, "INFO")
            Else
                MsgBox("Failed ! ", vbCritical, "ERROR")
            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
        con.Close()

        loadingDataGridView()
        clear()
    End Sub

    Private Sub updBtn_Click(sender As Object, e As EventArgs) Handles updBtn.Click
        Dim valid As Integer

        valid = validate()

        If valid = 1 Then
            edit()
        End If
    End Sub

    Private Sub firstBtn_Click(sender As Object, e As EventArgs) Handles firstBtn.Click
        dataGrid.CurrentCell = dataGrid.Rows(0).Cells(0)

        idTxt.Text = dataGrid.CurrentRow.Cells(0).Value
        nameTxt.Text = dataGrid.CurrentRow.Cells(1).Value
        posTxt.Text = dataGrid.CurrentRow.Cells(2).Value
        salaryTxt.Text = dataGrid.CurrentRow.Cells(3).Value
        hireDate.Value = dataGrid.CurrentRow.Cells(4).Value
    End Sub

    Private Sub lastBtn_Click(sender As Object, e As EventArgs) Handles lastBtn.Click
        dataGrid.CurrentCell = dataGrid.Rows(rowcount - 1).Cells(0)

        idTxt.Text = dataGrid.CurrentRow.Cells(0).Value
        nameTxt.Text = dataGrid.CurrentRow.Cells(1).Value
        posTxt.Text = dataGrid.CurrentRow.Cells(2).Value
        salaryTxt.Text = dataGrid.CurrentRow.Cells(3).Value
        hireDate.Value = dataGrid.CurrentRow.Cells(4).Value
    End Sub

    Private Sub prevBtn_Click(sender As Object, e As EventArgs) Handles prevBtn.Click
        currentrow = dataGrid.CurrentRow().Index

        If currentrow = 0 Then
            MsgBox("You have reached the first record !", vbExclamation, "WARNING")
        Else
            currentrow -= 1

            dataGrid.CurrentCell = dataGrid.Rows(currentrow).Cells(0)

            idTxt.Text = dataGrid.CurrentRow.Cells(0).Value
            nameTxt.Text = dataGrid.CurrentRow.Cells(1).Value
            posTxt.Text = dataGrid.CurrentRow.Cells(2).Value
            salaryTxt.Text = dataGrid.CurrentRow.Cells(3).Value
            hireDate.Value = dataGrid.CurrentRow.Cells(4).Value
        End If
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        currentrow = dataGrid.CurrentRow().Index

        If currentrow = rowcount - 1 Then
            MsgBox("You have reached the last record !", vbExclamation, "WARNING")
        Else
            currentrow += 1

            dataGrid.CurrentCell = dataGrid.Rows(currentrow).Cells(0)

            idTxt.Text = dataGrid.CurrentRow.Cells(0).Value
            nameTxt.Text = dataGrid.CurrentRow.Cells(1).Value
            posTxt.Text = dataGrid.CurrentRow.Cells(2).Value
            salaryTxt.Text = dataGrid.CurrentRow.Cells(3).Value
            hireDate.Value = dataGrid.CurrentRow.Cells(4).Value
        End If
    End Sub

    Private Sub dataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid.CellContentClick
        idTxt.Text = dataGrid.CurrentRow.Cells(0).Value
        nameTxt.Text = dataGrid.CurrentRow.Cells(1).Value
        posTxt.Text = dataGrid.CurrentRow.Cells(2).Value
        salaryTxt.Text = dataGrid.CurrentRow.Cells(3).Value
        hireDate.Value = dataGrid.CurrentRow.Cells(4).Value
    End Sub

    Private Function validate() As Integer
        If String.IsNullOrEmpty(nameTxt.Text) Then
            MsgBox("Name is required !", vbCritical, "ERROR")
            Return 0
        End If

        If String.IsNullOrEmpty(posTxt.Text) Then
            MsgBox("Position is required !", vbCritical, "ERROR")
            Return 0
        End If

        If String.IsNullOrEmpty(salaryTxt.Text) Then
            MsgBox("Salary is required !", vbCritical, "ERROR")
            Return 0
        ElseIf Not Integer.TryParse(salaryTxt.Text, 0) Then
            MsgBox("Salary must be a number !", vbCritical, "ERROR")
            Return 0
        End If

        Return 1
    End Function
End Class