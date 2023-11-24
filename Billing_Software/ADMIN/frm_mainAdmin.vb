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
        Load_todaySale()
        Load_noOfCashier()
        Load_monthSale()
        Load_noOfmonthSale()
        Load_noOfProduct()
        Load_noOfTodaySale()

        'MsgBox("SELECT SUM(`grandtotal`),`billno` FROM `tbi_pos` WHERE `billdate` = '" & Date.Now.ToString("yyyy-MM-dd") & "' group by billno ")
    End Sub

    Private Sub btn_Reports_Click(sender As Object, e As EventArgs) Handles btn_Reports.Click
        report_admin.ShowDialog()
    End Sub

    Sub Load_noOfTodaySale()
        Try
            'conn.Open()
            cmd = New MySqlCommand("SELECT COUNT(DISTINCT billno) FROM `tbi_pos` WHERE `billdate` = @billdate", conn)
            cmd.Parameters.AddWithValue("@billdate", Date.Now.ToString("yyyy-MM-dd"))
            lbl_noOfTodaySale.Text = cmd.ExecuteScalar().ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub Load_noOfProduct()
        Try
            'conn.Open()
            cmd = New MySqlCommand("SELECT COUNT(`procode`) FROM `tblproduct`", conn)
            lbl_noOfProduct.Text = cmd.ExecuteScalar.ToString

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub Load_monthSale()
        Try
            'conn.Open()
            cmd = New MySqlCommand("SELECT SUM(`grandtotal`) FROM `tbi_pos` WHERE MONTH(billdate) = '" & Date.Now.ToString("MM") & " ' ", conn)
            lbl_monthlySale.Text = cmd.ExecuteScalar.ToString

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub Load_todaySale()
        Try
            'conn.Open()
            cmd = New MySqlCommand("SELECT SUM(`grandtotal`) FROM `tbi_pos` WHERE `billdate` = '" & Date.Now.ToString("yyyy-MM-dd") & " ' ", conn)
            lbl_todaySale.Text = cmd.ExecuteScalar.ToString

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub Load_noOfCashier()
        Try
            cmd = New MySqlCommand("Select  COUNT(DISTINCT name) As totalUsers
FROM `tbluser`
WHERE role = 'Cashier'", conn)
            lbl_noOfUser.Text = cmd.ExecuteScalar.ToString

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub Load_noOfmonthSale()
        Try
            cmd = New MySqlCommand("SELECT COUNT(DISTINCT billno) AS numberOfBills FROM tbi_pos WHERE MONTH(billdate) = MONTH(CURDATE())", conn)
            lbl_noOfMonthlySale.Text = cmd.ExecuteScalar().ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class