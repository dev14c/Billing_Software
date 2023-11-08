Imports MySql.Data.MySqlClient
Public Class frm_mainCashier
    Private Sub frm_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_SearchProduct.Focus()
    End Sub

    Public Sub addlist()
        Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString = txt_SearchProduct.Text Then
                    exist = True

                    numrow = itm.Index
                    numtext = CInt(itm.Cells(8).Value)
                    Exit For

                End If
            End If
        Next
        If exist = False Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tblproduct WHERE procode = @procode", conn)
                cmd.Parameters.AddWithValue("@procode", txt_SearchProduct.Text)
                dr = cmd.ExecuteReader
                While dr.Read()
                    If txt_SearchProduct.Text = String.Empty Then
                        Return
                    Else
                        'create new row
                        '`procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`,
                        Dim procode As String = dr("procode").ToString()
                        Dim proname As String = dr("proname").ToString()
                        Dim progroup As String = dr("progroup").ToString()
                        Dim uom As String = dr("uom").ToString()
                        Dim price As Decimal
                        Dim tax As Decimal
                        Dim totalqtyprice As Double

                        If Decimal.TryParse(dr("price").ToString(), price) AndAlso Decimal.TryParse(dr("tax").ToString(), tax) Then
                            totalqtyprice = price * tax / 100 + price
                        End If

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, procode, proname, progroup, uom, price, tax, totalqtyprice, 1, totalqtyprice)
                        txt_SearchProduct.Clear()
                        txt_SearchProduct.Focus()
                    End If

                End While
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation)

            End Try
            DataGridView1.Rows(numrow).Cells(8).Value = CInt("1") + numtext
            DataGridView1.Rows(numrow).Cells(9).Value = DataGridView1.Rows(numrow).Cells(7).Value



        End If

    End Sub



    Private Sub txt_SearchProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SearchProduct.KeyDown
        If txt_SearchProduct.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                addlist()
                txt_SearchProduct.Clear()
                txt_SearchProduct.Focus()
            End If
        End If

    End Sub
    Public Sub 
End Class