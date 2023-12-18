Imports MySql.Data.MySqlClient

Public Class frm_qty_add
    ' Reference to Form1
    Private form1Instance As frm_mainCashier

    ' Constructor that takes a reference to Form1
    Public Sub New(form1 As frm_mainCashier)
        InitializeComponent()

        ' Save the reference to Form1
        form1Instance = form1
    End Sub
    Private Sub frm_qty_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Product ID"
        Label2.Text = "Quantity"
        Button1.Text = "Update"
        dbconn()
    End Sub

    Private Sub txt_qty_add_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exist As Boolean = False
        Dim existingRowIndex As Integer = 0
        Dim existingQuantity As Integer = 0

        Dim dgv As DataGridView = form1Instance.DataGridView1
        ' Check if the product already exists in the DataGridView
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = update_pid.Text Then
                exist = True
                existingRowIndex = row.Index
                existingQuantity = CInt(row.Cells(8).Value)
                Exit For
            End If
        Next

        If exist Then
            ' If the product already exists, check stock before incrementing the quantity
            Dim currentStock As Integer = form1Instance.GetStockLevel(update_pid.Text)
            If currentStock > 0 Then
                dgv.Rows(existingRowIndex).Cells(8).Value = CInt(update_qty.Text)
                form1Instance.calculate_price(existingRowIndex)
                'dgv.Rows(existingRowIndex).Cells(8).Value = existingQuantity + 1
                'Dim totalPrice As Decimal = CDec(dgv.Rows(existingRowIndex).Cells(7).Value) * CInt(dgv.Rows(existingRowIndex).Cells(8).Value)
                'dgv.Rows(existingRowIndex).Cells(9).Value = totalPrice
            Else
                MsgBox("Insufficient stock for the selected product.", MsgBoxStyle.Exclamation)
            End If
        Else
            ' If the product doesn't exist, add a new row
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tblproduct WHERE procode = @procode", conn)
                cmd.Parameters.AddWithValue("@procode", update_pid.Text)
                dr = cmd.ExecuteReader

                If dr.Read() Then
                    Dim procode As String = dr("procode").ToString()
                    Dim proname As String = dr("proname").ToString()
                    Dim progroup As String = dr("progroup").ToString()
                    Dim uom As String = dr("uom").ToString()
                    Dim stock As Integer = CInt(dr("stock"))

                    If stock > 0 Then
                        Dim rate As Decimal
                        Dim tax As Decimal
                        Dim totalQtyPrice As Double
                        Dim puchase_price As String = dr("purchase_price")
                        Dim gstAmount As Double
                        If Decimal.TryParse(dr("Rate_per").ToString(), rate) AndAlso Decimal.TryParse(dr("tax").ToString(), tax) Then
                            totalQtyPrice = Math.Round(rate / (tax + 100) * tax, 2)
                            gstAmount = Math.Round(rate - totalQtyPrice, 2)
                            totalQtyPrice = totalQtyPrice * 1
                        End If

                        'dgv.Rows.Add(dgv.Rows.Count + 1, procode, proname, progroup, uom, rate, tax, totalQtyPrice, 1, totalQtyPrice)
                        dgv.Rows.Add(dgv.Rows.Count + 1, procode, proname, progroup, uom, gstAmount, tax, totalQtyPrice, 1, rate, rate, puchase_price)
                        update_pid.Clear()
                        update_qty.Clear()
                        update_qty.Focus()
                    Else
                        MsgBox("Insufficient stock for the selected product.", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Product not found.", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation)
            Finally
                conn.Close()
            End Try
        End If

    End Sub
End Class
