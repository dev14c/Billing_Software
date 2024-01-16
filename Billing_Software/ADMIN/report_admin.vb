Imports MySql.Data.MySqlClient

Public Class report_admin
    Private Sub report_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30


        load_report()
        total()
    End Sub
    Sub load_report()
        DataGridView1.Rows.Clear()

        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`,`proname`,`qty`,`totalprice`,`cashier_name`,sum(profit) as profit,proname FROM `tbi_pos` GROUP BY `billno`,`proname`", conn)


            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("proname"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("cashier_name"), dr.Item("profit"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`, `proname`, `qty`, `totalprice`, `cashier_name`, SUM(profit) AS profit FROM `tbi_pos` WHERE billno LIKE @billno GROUP BY `billno`, `proname`", conn)

            cmd.Parameters.AddWithValue("@billno", "%" & txt_search.Text & "%")


            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("proname"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("cashier_name"), dr.Item("profit"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub rbtn_today_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_today.CheckedChanged
        DataGridView1.Rows.Clear()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`,`proname`,`qty`,`totalprice`,`cashier_name`,sum(profit) as profit,proname FROM `tbi_pos` WHERE billdate Like '%" & Date.Now.ToString("yyyy-MM-dd") & "%' GROUP BY `billno`,`proname`  ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("proname"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("cashier_name"), dr.Item("profit"))
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
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`,`proname`,`qty`,`totalprice`,`cashier_name`,sum(profit) as profit,proname FROM `tbi_pos`  WHERE  billdate like '%" & Date.Now.ToString("yyyy-MM") & "%' GROUP BY `billno`,`proname`  ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("proname"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("cashier_name"), dr.Item("profit"))
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


            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`,`proname`,`qty`,`totalprice`,`cashier_name`,sum(profit) as profit,proname FROM `tbi_pos` WHERE billdate BETWEEN @date1 AND @date2 GROUP BY `billno`,`proname`  ", conn)


            cmd.Parameters.AddWithValue("@date1", date1)
            cmd.Parameters.AddWithValue("@date2", date2)

            dr = cmd.ExecuteReader()

            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("proname"), dr.Item("qty"), dr.Item("totalprice"), dr.Item("cashier_name"), dr.Item("profit"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub total()
        Dim sum As Double = 0
        Dim profit As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(7).Value
            profit += DataGridView1.Rows(i).Cells(9).Value
        Next
        label_totaldisplay.Text = Format(CDec(sum), "#,##0.00")
        label_profit.Text = Format(CDec(profit), "#,##0.00")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()

    End Sub
End Class