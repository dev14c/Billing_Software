Imports MySql.Data.MySqlClient
Public Class frm_ManageUser
    Private Sub frm_ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Sub clear()
        txt_name.Clear()
        txt_password.Clear()
        txt_username.Clear()
        cbo_role.Items.Clear()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        frm_mainAdmin.Show()
    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        Try
            cmd = New MySqlCommand("INSERT INTO `tbluser`(`name`, `username`, `password`, `role`) VALUES (@name,@username,@password,@role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", cbo_role.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New User Register Success !", vbInformation)
                clear()

            Else
                MsgBox("New User Register Failed !", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
        frm_mainAdmin.NoOfCashier()
        frm_user_list.load_user()

    End Sub


End Class