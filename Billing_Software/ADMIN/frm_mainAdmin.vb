Imports MySql.Data.MySqlClient
Public Class frm_mainAdmin
    Private Sub btn_manageProduct_Click(sender As Object, e As EventArgs) Handles btn_manageProduct.Click
        frm_ManageProduct.ShowDialog()
    End Sub

    Private Sub btn_ManageStock_Click(sender As Object, e As EventArgs) Handles btn_ManageStock.Click
        frm_ManageStock.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub btn_manageUsers_Click(sender As Object, e As EventArgs) Handles btn_manageUsers.Click
        frm_user_list.ShowDialog()
    End Sub

    Private Sub frm_mainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        loadstock()
        todaysale()
        noOfCashier()
        monthSale()
        NoOfmonthSale()
        NoOfProduct()
        NoOfTodaysale()
        loadtodayProfit()
        loadmonthProfit()
        'MsgBox("SELECT SUM(`grandtotal`),`billno` FROM `tbi_pos` WHERE `billdate` = '" & Date.Now.ToString("yyyy-MM-dd") & "' group by billno ")
    End Sub
    Sub loadstock()
        Try
            Dim i As String = ""
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()


            Dim cmd As New MySqlCommand("SELECT proname, stock FROM tblproduct", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim productname As String = reader("proname").ToString()
                Dim stock As Integer = Convert.ToInt32(reader("stock"))


                Dim minqty As Integer = 5

                If stock < minqty Then
                    i = i & ", " & productname


                End If
            End While
            If Not String.IsNullOrEmpty(i) Then
                MsgBox($"The following products have stock below the 5 qty: {i}. Please refill!", vbInformation)
            Else
                MsgBox("All stocks are above the fullfilled. No refill needed.", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Sub loadtodayProfit()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT SUM(`profit`) FROM `tbi_pos` WHERE `billdate` = '" & Date.Now.ToString("yyyy-MM-dd") & "'", conn)

            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                todayprofit.Text = result.ToString()
            Else
                todayprofit.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub loadmonthProfit()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            'conn.Open()
            cmd = New MySqlCommand("SELECT SUM(`profit`) FROM `tbi_pos` WHERE MONTH(billdate) = '" & Date.Now.ToString("MM") & "'", conn)
            'monthProfit.Text = cmd.ExecuteScalar.ToString

            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                monthprofit.Text = result.ToString()
            Else
                monthprofit.Text = "0" '
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub btn_Reports_Click(sender As Object, e As EventArgs) Handles btn_Reports.Click
        report_admin.ShowDialog()
    End Sub

    Sub NoOfTodaysale()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(DISTINCT billno) FROM `tbi_pos` WHERE `billdate` = @billdate", conn)
            cmd.Parameters.AddWithValue("@billdate", Date.Now.ToString("yyyy-MM-dd"))
            'lbl_noOfTodaySale.Text = cmd.ExecuteScalar().ToString()
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                label_nooftodaysale.Text = result.ToString()
            Else
                label_nooftodaysale.Text = "0" ' 
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub NoOfProduct()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(`procode`) FROM `tblproduct`", conn)
            'lbl_noOfProduct.Text = cmd.ExecuteScalar.ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                label_noofProduct.Text = result.ToString()
            Else
                label_noofProduct.Text = "0" ' 
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub monthSale()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            'conn.Open()
            cmd = New MySqlCommand("SELECT SUM(`totalprice`) FROM `tbi_pos` WHERE MONTH(billdate) = '" & Date.Now.ToString("MM") & "'", conn)
            'lbl_monthlySale.Text = cmd.ExecuteScalar.ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                label_monthlysale.Text = result.ToString()
            Else
                label_monthlysale.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub todaysale()
        ' If the product code doesn't exist, add a new row
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT SUM(`totalprice`) FROM `tbi_pos` WHERE `billdate` = '" & Date.Now.ToString("yyyy-MM-dd") & "'", conn)
            'lbl_todaySale.Text = cmd.ExecuteScalar.ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                label_todaysale.Text = result.ToString()
            Else
                label_todaysale.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Sub NoOfCashier()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("Select  COUNT(DISTINCT name) As totalUsers
FROM `tbluser`
WHERE role = 'Cashier'", conn)
            'lbl_noOfUser.Text = cmd.ExecuteScalar.ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                label_noOfUser.Text = result.ToString()
            Else
                label_noOfUser.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub NoOfmonthSale()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT COUNT(DISTINCT billno) AS numberOfBills FROM tbi_pos WHERE MONTH(billdate) = MONTH(CURDATE())", conn)
            'lbl_noOfMonthlySale.Text = cmd.ExecuteScalar().ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                labelnoofmonthlysale.Text = result.ToString()
            Else
                labelnoofmonthlysale.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub cash_report_btn_Click(sender As Object, e As EventArgs) Handles cash_report_btn.Click
        frm_cash_sumbit.ShowDialog()

    End Sub

    Private Sub Refreshbutton_Click_1(sender As Object, e As EventArgs) Handles Refreshbutton.Click
        ReloadData()
    End Sub

    Private Sub ReloadData()
        loadstock()

        todaysale()
        NoOfCashier()
        monthSale()
        NoOfmonthSale()
        NoOfProduct()
        NoOfTodaysale()

        MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_viewbill_admin.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class