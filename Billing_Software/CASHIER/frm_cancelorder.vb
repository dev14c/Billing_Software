Imports System.IO
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

        Try

            Dim directoryPath As String = Path.Combine(Application.StartupPath, "Reports")


            Dim selectedBillNo As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

            Dim pdfFilePath As String = Path.Combine(directoryPath, $"Bill No_{selectedBillNo}.pdf")
            'this is to view the bill'
            ''

            If File.Exists(pdfFilePath) Then

                Process.Start(pdfFilePath)
            Else
                MsgBox("PDF file not found for the selected bill number.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




End Class