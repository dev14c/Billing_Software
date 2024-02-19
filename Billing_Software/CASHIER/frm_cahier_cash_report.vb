Imports Billing_Software.dbconnection
Imports MySql.Data.MySqlClient

Public Class frm_cahier_cash_report



    Private Sub frm_cahier_cash_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        cashier_name.Text = "Cash Report of " & UserSession.CurrentUser

        load_report()
    End Sub

    Dim grandtotal As String
    Sub load_report()
        DataGridView1.Rows.Clear()
        Dim currentUser = UserSession.CurrentUser
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT Date, Cashier_name, Amount, Cash_subcashier, Cashrec FROM cash_report WHERE Cashier_name = @currentUser", conn)
            cmd.Parameters.AddWithValue("@currentUser", currentUser)
            dr = cmd.ExecuteReader

            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("Date"), dr.Item("Amount"), dr.Item("Cash_subcashier"), dr.Item("Cashrec"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub


    Private Sub btn_submit_cash_Click(sender As Object, e As EventArgs) Handles btn_submit_cash.Click

        ' Get the current date in the desired format
        Dim currentDate1 As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim grandtotal As String

        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to submit the cash for {currentDate1}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            Try
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                Dim cashierName As String = UserSession.CurrentUser

                ' Use parameterized query to avoid SQL injection
                cmd = New MySqlCommand("SELECT SUM(`grandtotal`) AS totalSales FROM `tbi_pos` WHERE cashier_name = @CurrentUser AND DATE(billdate) = @CurrentDate", conn)
                cmd.Parameters.AddWithValue("@CurrentUser", cashierName)
                cmd.Parameters.AddWithValue("@CurrentDate", Date.Now.ToString("yyyy-MM-dd"))

                Dim total As Object = cmd.ExecuteScalar()

                If total IsNot Nothing Then
                    grandtotal = total.ToString()
                Else
                    grandtotal = "N/A" ' Set a default value or handle the case when the result is null
                End If


                ' Check if a record for today's date already exists in the cash_report table
                Dim recordExistsQuery As String = "SELECT COUNT(*) FROM cash_report WHERE Date = @currentDate1 AND Cash_subcashier = 'Yes'"

                Using cmdCheckRecord As New MySqlCommand(recordExistsQuery, conn)
                    cmdCheckRecord.Parameters.AddWithValue("@currentDate1", currentDate1)

                    Dim recordCount As Integer = CInt(cmdCheckRecord.ExecuteScalar())

                    If recordCount > 0 Then
                        ' If a record for today already exists, update the existing record
                        Dim updateQuery As String = "UPDATE cash_report SET Amount = @grandtotal WHERE Date = @currentDate1 AND Cash_subcashier = 'Yes'"

                        Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                            cmdUpdate.Parameters.AddWithValue("@currentDate1", currentDate1)
                            cmdUpdate.Parameters.AddWithValue("@grandtotal", grandtotal)
                            cmdUpdate.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Cash updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' If no record for today exists, insert a new record
                        Dim insertQuery As String = "INSERT INTO cash_report (Date, Cashier_name, Amount, Cash_subcashier) VALUES (@currentDate1, @cashierName, @grandtotal, 'Yes')"

                        Using cmdInsert As New MySqlCommand(insertQuery, conn)
                            cmdInsert.Parameters.AddWithValue("@cashierName", cashierName)
                            cmdInsert.Parameters.AddWithValue("@currentDate1", currentDate1)
                            cmdInsert.Parameters.AddWithValue("@grandtotal", grandtotal)
                            cmdInsert.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Cash submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
        ' Disable the button after submission
        'btn_submit_cash.Enabled = False
        load_report()

    End Sub

    Private Sub rbtn_today_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_today.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT Date, Cashier_name, Amount, Cash_subcashier, Cashrec FROM cash_report WHERE Cashier_name = @currentUser AND DATE(Date) = CURRENT_DATE", conn)
            cmd.Parameters.AddWithValue("@CurrentUser", UserSession.CurrentUser)

            dr = cmd.ExecuteReader
            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr("Date"), dr("Amount"), dr("Cash_subcashier"), dr("Cashrec"))
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

            ' Use MONTH() function to filter by the current month
            cmd = New MySqlCommand("SELECT Date, Cashier_name, Amount, Cash_subcashier, Cashrec FROM cash_report WHERE Cashier_name = @currentUser AND MONTH(Date) = MONTH(CURRENT_DATE)", conn)
            cmd.Parameters.AddWithValue("@CurrentUser", UserSession.CurrentUser)

                dr = cmd.ExecuteReader
                While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr("Date"), dr("Amount"), dr("Cash_subcashier"), dr("Cashrec"))
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

            cmd = New MySqlCommand("SELECT Date, Cashier_name, Amount, Cash_subcashier, Cashrec FROM cash_report WHERE Cashier_name = @currentUser AND Date BETWEEN @date1 AND @date2", conn)
            cmd.Parameters.AddWithValue("@CurrentUser", UserSession.CurrentUser)
            cmd.Parameters.AddWithValue("@date1", date1)
            cmd.Parameters.AddWithValue("@date2", date2)

            dr = cmd.ExecuteReader
            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr("Date"), dr("Amount"), dr("Cash_subcashier"), dr("Cashrec"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub rbtn_all_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_all.CheckedChanged
        load_report()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub
End Class
