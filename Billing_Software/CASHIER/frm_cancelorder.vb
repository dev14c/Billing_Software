Imports MySql.Data.MySqlClient
Public Class frm_cancelorder
    Private Sub frm_cancelorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_cancelorder()


    End Sub
    Sub load_cancelorder()
        DataGridView1.Rows.Clear()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbi_pos` WHERE cashier_name = @CurrentUser GROUP BY billno", conn)
            cmd.Parameters.AddWithValue("@CurrentUser", UserSession.CurrentUser)

            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("grandtotal"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbi_pos`where billno like '%" & txt_search.Text & "%' group by billno", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("grandtotal"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the "View Bill" column
        If e.ColumnIndex = DataGridView1.Columns(4).Index AndAlso e.RowIndex >= 0 Then
            ' Retrieve the procode from the selected row
            Dim billno As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' Call a function to display the bill details based on the procode
            DisplayBillDetails(billno)
        End If
    End Sub
    Private Sub DisplayBillDetails(billno As String)

        ' Instantiate and show the BillDetailsForm
        Dim billDetailsForm As New view_bill()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("select billno,Customer_Name,Customer_Mobile,paymode,billdate, grandtotal from tbi_pos where billno=@billno", conn)

            cmd.Parameters.AddWithValue("@billno", billno)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ' Set the TextBox on the BillDetailsForm with the retrieved grandtotal
                billDetailsForm.txt_billno.Text = dr("billno").ToString()
                billDetailsForm.txt_billdate.Text = dr("billdate").ToString()
                billDetailsForm.txt_cusname.Text = dr("Customer_Name").ToString()
                billDetailsForm.txt_cusmob.Text = dr("Customer_Mobile").ToString()
                billDetailsForm.txt_mod.Text = dr("paymode").ToString()
                billDetailsForm.txt_total.Text = dr("grandtotal").ToString()
            Else
                MsgBox("No details found for the selected bill.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        ' Show the BillDetailsForm
        billDetailsForm.Show()
    End Sub

End Class