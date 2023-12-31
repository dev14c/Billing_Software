﻿Imports MySql.Data.MySqlClient
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
        Load_todaySale()
        Load_noOfCashier()
        Load_monthSale()
        Load_noOfmonthSale()
        Load_noOfProduct()
        Load_noOfTodaySale()
        Load_todayProfit()
        Load_monthProfit()
        'MsgBox("SELECT SUM(`grandtotal`),`billno` FROM `tbi_pos` WHERE `billdate` = '" & Date.Now.ToString("yyyy-MM-dd") & "' group by billno ")
    End Sub

    Sub Load_todayProfit()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT SUM(`profit`) FROM `tbi_pos` WHERE `billdate` = '" & Date.Now.ToString("yyyy-MM-dd") & "'", conn)
            'todayProfit.Text = cmd.ExecuteScalar.ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                todayProfit.Text = result.ToString()
            Else
                todayProfit.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub Load_monthProfit()
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
                monthProfit.Text = result.ToString()
            Else
                monthProfit.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub btn_Reports_Click(sender As Object, e As EventArgs) Handles btn_Reports.Click
        report_admin.ShowDialog()
    End Sub

    Sub Load_noOfTodaySale()
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
                lbl_noOfTodaySale.Text = result.ToString()
            Else
                lbl_noOfTodaySale.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub Load_noOfProduct()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(`procode`) FROM `tblproduct`", conn)
            'lbl_noOfProduct.Text = cmd.ExecuteScalar.ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                lbl_noOfProduct.Text = result.ToString()
            Else
                lbl_noOfProduct.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub Load_monthSale()
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
                lbl_monthlySale.Text = result.ToString()
            Else
                lbl_monthlySale.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub Load_todaySale()
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
                lbl_todaySale.Text = result.ToString()
            Else
                lbl_todaySale.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Sub Load_noOfCashier()
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
                lbl_noOfUser.Text = result.ToString()
            Else
                lbl_noOfUser.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub Load_noOfmonthSale()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT COUNT(DISTINCT billno) AS numberOfBills FROM tbi_pos WHERE MONTH(billdate) = MONTH(CURDATE())", conn)
            'lbl_noOfMonthlySale.Text = cmd.ExecuteScalar().ToString
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                lbl_noOfMonthlySale.Text = result.ToString()
            Else
                lbl_noOfMonthlySale.Text = "0" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub cash_report_btn_Click(sender As Object, e As EventArgs) Handles cash_report_btn.Click
        frm_cash_sumbit.ShowDialog()

    End Sub

    Private Sub Refreshbutton_Click_1(sender As Object, e As EventArgs) Handles Refreshbutton.Click
        ReloadData()
    End Sub

    Private Sub ReloadData()
        ' Place the logic to reload your data here
        ' For example, if you have a DataGridView, you can reload its data source
        ' or if you have other controls, update their values accordingly

        ' Call the methods or logic you use to load or display data
        Load_todaySale()
        Load_noOfCashier()
        Load_monthSale()
        Load_noOfmonthSale()
        Load_noOfProduct()
        Load_noOfTodaySale()
        ' Add more methods as needed

        ' Optionally, display a message or perform other actions after the refresh
        MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_viewbill_admin.ShowDialog()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class