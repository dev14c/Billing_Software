Imports MySql.Data.MySqlClient
Public Class frm_updateStock
    Dim productCode As String
    Private Sub frm_updateStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_updateStock_Click(sender As Object, e As EventArgs) Handles btn_updateStock.Click
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("UPDATE tblproduct SET stock = stock + @newQuantity WHERE procode = @procode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@newQuantity", CDec(txt_qty.Text))
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Stock Update Success", vbInformation)
                frm_ManageStock.Load_stock()
                txt_procode.Text = ""
                txt_qty.Text = ""


            Else
                MsgBox("Stock Update Failed", vbInformation)


            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub txt_location_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged

    End Sub
End Class