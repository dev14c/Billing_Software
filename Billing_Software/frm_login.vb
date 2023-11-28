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
                '
                ''In the provided code, dr.Item("status").ToString().Equals("Activate", StringComparison.OrdinalIgnoreCase) checks if the status retrieved from the database for the current user Is equal to the string "Activate" (ignoring case differences).

                'Here 's a breakdown of the code:

                'dr.Item("status").ToString() : Retrieves the value of the "status" column from the database reader (dr) as a string.

                '.Equals("Activate", StringComparison.OrdinalIgnoreCase) : Compares the retrieved status with the string "Activate" using a case-insensitive comparison (StringComparison.OrdinalIgnoreCase).
                'This means that it will consider "activate," "Activate," "ACTIVATE," And so On, as equal.'
                ' Check if the account is active
                If dr.Item("status").ToString().Equals("Activate", StringComparison.OrdinalIgnoreCase) Then
                    UserSession.CurrentUser = txt_username.Text

                    found = True
                    name = dr.Item("name").ToString
                    username = dr.Item("username").ToString
                    password = dr.Item("password").ToString
                    role = dr.Item("role").ToString

                    ' Username and password match, and account is active
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        frm_mainAdmin.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_mainCashier.Show()
                    End If
                Else
                    ' Account is deactivated
                    MsgBox("Account is deactivated. Please contact the administrator.", vbInformation)
                    txt_password.Clear()
                    txt_username.Clear()
                End If
            Else
                ' User not found or incorrect password
                found = False
                name = ""
                username = ""
                password = ""
                role = ""
                MsgBox("Incorrect Username or Password!", vbInformation)
                txt_password.Clear()
                txt_username.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
        dr.Close()
    End Sub



End Class