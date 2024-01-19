Imports MySql.Data.MySqlClient
Public Class frm_ManageStock
    Dim j As Integer

    Private Sub frm_ManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_stock()
    End Sub
    Public Sub Load_stock()
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblproduct`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("Rate_per"), dr.Item("purchase_price"),
                dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"))
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
            cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE procode like '%" & txt_search.Text & "%' or progroup like '%" & txt_search.Text & "%' or proname like '%" & txt_search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("Rate_per"), dr.Item("purchase_price"),
                dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_updateStock_Click(sender As Object, e As EventArgs) Handles btn_updateStock.Click
        frm_updateStock.ShowDialog()


    End Sub


End Class