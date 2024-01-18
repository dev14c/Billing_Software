Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_viewbill_admin
    Private Sub frm_viewbill_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_bill()

    End Sub
    Sub load_bill()
        DataGridView1.Rows.Clear()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbi_pos`  GROUP BY billno", conn)

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

        If e.ColumnIndex = DataGridView1.Columns(5).Index AndAlso e.RowIndex >= 0 Then
            If MsgBox("Are you sure you want to delete this bill?", vbQuestion + vbYesNo) = vbYes Then

                Dim billno As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()


                Dim directoryPath As String = Path.Combine(Application.StartupPath, "Reports")


                Dim pdfFilePath As String = Path.Combine(directoryPath, $"Bill No_{billno}.pdf")


                If File.Exists(pdfFilePath) Then

                    File.Delete(pdfFilePath)
                Else
                    MsgBox("PDF file not found for the selected bill number.")
                End If


                Try
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM tbi_pos WHERE billno='" & billno & "'", conn)
                    Dim i As Integer = cmd.ExecuteNonQuery

                    If i > 0 Then
                        MsgBox("Bill Delete Success !", vbInformation)

                        load_bill()
                    Else
                        MsgBox("Bill Delete Failed!", vbInformation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If



        If e.ColumnIndex = DataGridView1.Columns(4).Index AndAlso e.RowIndex >= 0 Then
            Try

                Dim directoryPath As String = Path.Combine(Application.StartupPath, "Reports")


                Dim billno As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

                Dim pdfFilePath As String = Path.Combine(directoryPath, $"Bill No_{billno}.pdf")

                If File.Exists(pdfFilePath) Then

                    Process.Start(pdfFilePath)
                Else
                    MsgBox("PDF file not found for the selected bill number.", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        End If
    End Sub
    Private Sub Display_Bill(billno As String)
        ' Instantiate and show the BillDetailsForm
        Dim billDetailsForm As New view_admin_bill()

        Try


            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.Open()
            billDetailsForm.ListBox1.Items.Clear()
            cmd = New MySqlCommand("SELECT billno, Customer_Name, proname,qty,Customer_Mobile,cashier_name,totalpriceqty,paymode, billdate, grandtotal FROM tbi_pos WHERE billno = @billno", conn)
            cmd.Parameters.AddWithValue("@billno", billno)

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()

                    billDetailsForm.txt_billno.Text = dr("billno").ToString()
                    billDetailsForm.txt_billdate.Text = dr("billdate").ToString()
                    billDetailsForm.txt_cusname.Text = dr("Customer_Name").ToString()
                    billDetailsForm.txt_cusmob.Text = dr("Customer_Mobile").ToString()
                    billDetailsForm.txt_mod.Text = dr("paymode").ToString()
                    billDetailsForm.txt_total.Text = dr("grandtotal").ToString()
                    billDetailsForm.txt_cashier.Text = dr("cashier_name").ToString()


                    Dim combinedItem As String = dr("proname").ToString() & " - " & dr("qty").ToString() & "  " & "(Qty)"
                    billDetailsForm.ListBox1.Items.Add(combinedItem)
                    Dim combinedItem2 As String = dr("proname").ToString() & " - " & dr("totalpriceqty").ToString() & " " & "(Each Qty Price)"
                    billDetailsForm.ListBox2.Items.Add(combinedItem2)
                End While
            Else
                MsgBox("No details found for the selected bill.", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        billDetailsForm.Show()
    End Sub



End Class