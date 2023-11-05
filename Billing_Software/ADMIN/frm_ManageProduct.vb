Imports MySql.Data.MySqlClient
Public Class frm_ManageProduct
    Private Sub frm_ManageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_PorductGroup()
    End Sub

    Private Sub btn_AddGroup_Click(sender As Object, e As EventArgs) Handles btn_AddGroup.Click
        frm_addGroup.ShowDialog()


    End Sub
    Sub load_PorductGroup()
        Try
        
        Catch ex As Exception

        End Try
    End Sub
End Class
