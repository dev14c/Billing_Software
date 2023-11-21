Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

Public Class frm_login
    Dim name As String
    Dim password As String
    Dim username As String
    Dim role As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click
        If MsgBox("Are you sure to exit ?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
            conn.Close()
        End If



    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim found As Boolean = False
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()




            cmd = New MySqlCommand("SELECT * FROM tbluser WHERE `username`='" & txt_username.Text & "' AND `password`='" & txt_password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                UserSession.CurrentUser = txt_username.Text
                found = True
                name = dr.Item("name").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString
            Else
                found = False
                name = ""
                username = ""
                password = ""
                role = ""
            End If
            If StrComp(txt_username.Text, username, CompareMethod.Binary) = 0 AndAlso StrComp(txt_password.Text, password, CompareMethod.Binary) = 0 Then
                ' Username and password match
                If UCase(role) = "ADMIN" Then
                    Me.Hide()
                    frm_mainAdmin.Show()
                ElseIf UCase(role) = "CASHIER" Then
                    Me.Hide()
                    frm_mainCashier.Show()
                End If
            Else
                ' Password does not match or user not found
                MsgBox("Warning: Wrong Username or Password!", vbInformation)
                txt_password.Clear()
                txt_username.Clear()
                ' Return ' Exit the method, preventing further execution (remove this line if you don't want to exit the method)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        dr.Close()



    End Sub


End Class