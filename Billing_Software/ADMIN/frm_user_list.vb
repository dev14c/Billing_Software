Imports System.Diagnostics.Eventing.Reader
Imports MessagingToolkit.Barcode
Imports MySql.Data.MySqlClient
Public Class frm_user_list


    Private Sub frm_user_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_user()


    End Sub
    Sub load_user()

        DataGridView1.Rows.Clear()

        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("Select ID,name,username,role,Status from tbluser", conn)

            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("name"), dr.Item("username"), dr.Item("role"), dr.Item("Status"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btn_updateStock_Click(sender As Object, e As EventArgs) Handles btn_add_user.Click
        frm_ManageUser.ShowDialog()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 4 Then ' Assuming 4 is the column index for "Activate" button
                Dim result As DialogResult = MessageBox.Show("Do you want to Activate the user?", "Confirmation", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    ' Your activation logic here..
                    '
                    Try
                        If conn.State = ConnectionState.Open Then
                            conn.Close()
                        End If
                        conn.Open()
                        Dim userID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()

                        cmd = New MySqlCommand("UPDATE tbluser SET Status = 'Activate' WHERE ID = @userID", conn)
                        cmd.Parameters.AddWithValue("@userID", userID)
                        cmd.ExecuteNonQuery()

                        MsgBox("Activated successfully")
                        DataGridView1.Rows(e.RowIndex).Cells(5).ReadOnly = True
                        DataGridView1.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Gray
                        DataGridView1.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.White

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf e.ColumnIndex = 5 Then ' Assuming 5 is the column index for "Deactivate" button
                Dim result As DialogResult = MessageBox.Show("Do you want to Deactivate the user?", "Confirmation", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    ' Your deactivation logic here..
                    '
                    Try
                        If conn.State = ConnectionState.Open Then
                            conn.Close()
                        End If
                        conn.Open()
                        Dim userID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()

                        cmd = New MySqlCommand("UPDATE tbluser SET Status = 'Deactivate' WHERE ID = @userID", conn)
                        cmd.Parameters.AddWithValue("@userID", userID)
                        cmd.ExecuteNonQuery()

                        MsgBox("Deactivated successfully")
                        DataGridView1.Rows(e.RowIndex).Cells(4).ReadOnly = True
                        DataGridView1.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.Gray
                        DataGridView1.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.White

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub
End Class