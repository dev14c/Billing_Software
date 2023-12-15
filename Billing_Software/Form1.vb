Public Class Form1

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles myprogress.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myprogress.Increment(1)
        Dim percentage As String
        percentage = Convert.ToString(myprogress.Value)
        percentagelb1.Text = percentage + "%"
        If myprogress.Value = 100 Then
            Me.Hide()
            Dim log = New frm_login
            Timer1.Enabled = False
            log.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class
