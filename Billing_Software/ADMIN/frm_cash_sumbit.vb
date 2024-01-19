Imports MySql.Data.MySqlClient

Public Class frm_cash_sumbit
    Private Sub frm_cash_sumbit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        cashier_name.Text = "Cash Report"
        load_report_admin()

    End Sub
    Sub load_report_admin()
        DataGridView1.Rows.Clear()


        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT Date, Cashier_name, Amount, Cash_subcashier, Cashrec FROM cash_report", conn)

            dr = cmd.ExecuteReader

            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("Date"), dr.Item("Cashier_name"), dr.Item("Amount"), dr.Item("Cash_subcashier"), dr.Item("Cashrec"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if recive btn is clicked oro not'
        If e.ColumnIndex = DataGridView1.Columns(6).Index AndAlso e.RowIndex >= 0 Then
            '
            Dim datevalue As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim cashiername As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()

            Dim convertDate As DateTime
            If DateTime.TryParse(datevalue, convertDate) Then
                datevalue = convertDate.ToString("yyyy-MM-dd")
            End If
            ' Display a confirmation message box
            Dim result As DialogResult = MessageBox.Show($"Are you sure you have received cash from {cashiername} on {datevalue}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's response
            If result = DialogResult.Yes Then
                ' Update the 'Cashrec' column in the database to 'Yes'
                UpdateCashRecInDatabase(cashiername, datevalue)
            Else
                ' User clicked No, do nothing or provide feedback as needed
                ' ...
                ShowMessageForm(cashiername, datevalue)

            End If
        End If
    End Sub
    Private Sub ShowMessageForm(cashiername As String, datevalue As String)
        ' Create an instance of the message form
        Dim sendMessageForm As New frm_mainCashier()

        ' Subscribe to the MessageReceived event


    End Sub

    Private Sub UpdateCashRecInDatabase(cashiername As String, datevalue As String)
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            ' Update the 'Cashrec' column in the database to 'Yes'
            Dim updateQuery As String = "UPDATE cash_report SET Cashrec = 'Yes' WHERE Cashier_name = @cashiername AND Date = @datevalue"

            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@cashiername", cashiername)
                cmd.Parameters.AddWithValue("@datevalue", datevalue)
                cmd.ExecuteNonQuery()
            End Using

            ' Display a message indicating successful update
            MessageBox.Show($"Cash received from {cashiername} on {datevalue} has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, refresh your DataGridView
            load_report_admin()
        Catch ex As Exception
            ' Handle any exceptions that may occur during the database update
            MessageBox.Show("Error updating the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub rbtn_all_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_all.CheckedChanged
        load_report_admin()
    End Sub

    Private Sub rbtn_today_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_today.CheckedChanged
        DataGridView1.Rows.Clear()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `cash_report` WHERE Date Like '%" & Date.Now.ToString("yyyy-MM-dd") & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("Date"), dr.Item("Cashier_name"), dr.Item("Amount"), dr.Item("Cash_subcashier"), dr.Item("Cashrec"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub rbtn_currentMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_currentMonth.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `cash_report`  WHERE  Date like '%" & Date.Now.ToString("yyyy-MM") & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("Date"), dr.Item("Cashier_name"), dr.Item("Amount"), dr.Item("Cash_subcashier"), dr.Item("Cashrec"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.Open()


            cmd = New MySqlCommand("SELECT * FROM `cash_report` WHERE Date BETWEEN @date1 AND @date2 ", conn)


            cmd.Parameters.AddWithValue("@date1", date1)
            cmd.Parameters.AddWithValue("@date2", date2)

            dr = cmd.ExecuteReader()

            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("Date"), dr.Item("Cashier_name"), dr.Item("Amount"), dr.Item("Cash_subcashier"), dr.Item("Cashrec"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class