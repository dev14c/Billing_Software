Public Class frm_qty_add
    Public qtyAdd As Integer

    Private Sub frm_qty_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub txt_qty_add_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_qty_add.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Integer.TryParse(txt_qty_add.Text, qtyAdd) Then
                Me.DialogResult = DialogResult.OK
                txt_qty_add.Clear()
                Me.Close()


            Else
                MessageBox.Show("Please enter a valid integer for quantity.")
            End If
        End If
    End Sub
End Class
