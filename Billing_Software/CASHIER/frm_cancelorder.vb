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
            cmd = New MySqlCommand("SELECT * FROM `tbi_pos`  group by billno", conn)
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
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "Col_del" Then
            If MsgBox("Are you sure want delete this bill !", vbQuestion + vbYesNo) = vbYes Then
                Try

                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                    conn.Open()
                    cmd = New MySqlCommand("Delete from tbi_pos where billno='" & DataGridView1.CurrentRow.Cells(1).Value & "'", conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Bill Delete Success !", vbInformation)
                        load_cancelorder()
                    Else
                        MsgBox("Bill Delete Failed!", vbInformation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            End If
        End If

    End Sub



End Class