Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

Public Class frm_ChangePassword


    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Private Sub btn_ChangePass_Click(sender As Object, e As EventArgs) Handles chnage_password.Click
        If txt_oldpassword.Text = String.Empty Then
            MsgBox("Please enter your old password!", vbExclamation)
            Return
        ElseIf txt_newpassword.Text = String.Empty Or txt_reenterpassword.Text = String.Empty Then
            MsgBox("Please enter your new password!", vbExclamation)
            Return
        ElseIf Not StrComp(txt_newpassword.Text, txt_reenterpassword.Text, CompareMethod.Binary) <> 0 Then
            MsgBox("New passwords do not match!", vbExclamation)
            Return
        End If

        Try

            cmd = New MySqlCommand("UPDATE tbluser SET `password`=@newPassword WHERE `password`=@oldPassword", conn)
            cmd.Parameters.AddWithValue("@newPassword", txt_newpassword.Text)
            cmd.Parameters.AddWithValue("@oldPassword", txt_oldpassword.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Password Change Success!", vbInformation)
            Else
                MsgBox("Password Change Failed!", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        ' Clear password fields after operation, for security reasons

    End Sub


End Class