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



                ' Insert a new record into the 'cash_s_report' table with parameters
                Dim insertQuery As String = "INSERT INTO cash_report (Date, Cashier_name, Amount, Cash_subcashier) VALUES (@currentDate1, @cashierName, @grandtotal, 'Yes')"

                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@cashierName", cashierName)
                    cmd.Parameters.AddWithValue("@currentDate1", currentDate1)
                    cmd.Parameters.AddWithValue("@grandtotal", grandtotal)
                    cmd.ExecuteNonQuery()
                End Using

                ' Display a message indicating successful submission
                MessageBox.Show("Cash submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Disable the button after submission
                btn_submit_cash.Enabled = False
                load_report()

            Catch ex As Exception
                ' Handle any exceptions that may occur during the database insert
                MessageBox.Show("Error inserting into the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the database connection
                conn.Close()

            End Try
        Else
            ' User clicked No, do nothing or provide feedback as needed
            ' ...
        End If
    End Sub
End Class
