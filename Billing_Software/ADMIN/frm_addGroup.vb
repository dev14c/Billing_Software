Imports MySql.Data.MySqlClient
Public Class frm_addGroup
    Private Sub frm_addGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            ' conn.Open()'

            cmd = New MySqlCommand("INSERT INTO `tblGroup`(`progroup`) VALUES (@progroup)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@progroup", txt_group.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Product Group Save Success !", vbInformation)
            Else
                MsgBox("New Product Group Save Failed !", vbInformation)

            End If
            txt_group.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        frm_ManageProduct.load_PorductGroup()

    End Sub
End Class