Imports System.Data.SqlClient
Imports System.Net.Mail


Public Class frm_email_send
    Private Sub frm_email_send_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Private Sub BtnSendEmail_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' This code will send an email.
        Try


            Dim smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage

            smtp_Server.UseDefaultCredentials = False
            smtp_Server.Credentials = New Net.NetworkCredential("jkgius436@gmail.com", "decole12")
            smtp_Server.Port = 587
            smtp_Server.EnableSsl = True
            smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("jkgius436@gmail.com")
            e_mail.To.Add("salonidulwani246@gmail.com")
            e_mail.Subject = "hell0"
            e_mail.IsBodyHtml = False
            e_mail.Body = "sample mesaage"

            smtp_Server.Send(e_mail)
            MsgBox("Email sent. Thanks!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Something failed." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class