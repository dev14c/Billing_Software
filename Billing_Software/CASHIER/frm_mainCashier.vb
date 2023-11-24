Imports System.Windows.Media
Imports MySql.Data.MySqlClient
Public Class frm_mainCashier
    Private Sub frm_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_SearchProduct.Focus()
        btn_pay.Enabled = False
        total()
        lbl_username.Text = "Welcome, " & UserSession.CurrentUser

        txt_billno.Text = GetbillNo()
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

        If exist Then
            ' If the product code already exists in a row, increment the quantity
            DataGridView1.Rows(numrow).Cells(8).Value = CInt(DataGridView1.Rows(numrow).Cells(8).Value) + 1
            DataGridView1.Rows(numrow).Cells(9).Value = CDec(DataGridView1.Rows(numrow).Cells(7).Value) * CInt(DataGridView1.Rows(numrow).Cells(8).Value)
            DataGridView1.Rows(numrow).Cells(9).Value = CDec(DataGridView1.Rows(numrow).Cells(7).Value) * CInt(DataGridView1.Rows(numrow).Cells(8).Value)
        Else
            ' If the product code doesn't exist, add a new row
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
                        ' Create new row
                        Dim procode As String = dr("procode").ToString()
                        Dim proname As String = dr("proname").ToString()
                        Dim progroup As String = dr("progroup").ToString()
                        Dim uom As String = dr("uom").ToString()

                        Dim rate As Decimal
                        Dim tax As Decimal
                        Dim totalqtyprice As Double

                        If Decimal.TryParse(dr("Rate_per").ToString(), rate) AndAlso Decimal.TryParse(dr("tax").ToString(), tax) Then
                            totalqtyprice = rate * tax / 100 + rate
                            totalqtyprice = totalqtyprice * 1
                        End If

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, procode, proname, progroup, uom, rate, tax, totalqtyprice, 1, totalqtyprice)
                        txt_SearchProduct.Clear()
                        txt_SearchProduct.Focus()
                    End If
                End While
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub




    Private Sub txt_SearchProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SearchProduct.KeyDown
        If txt_SearchProduct.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                addlist()

                total()
                txt_SearchProduct.Clear()
                txt_SearchProduct.Focus()
            End If
        End If

    End Sub
    Public Sub total()
        txt_no_of_items.Text = DataGridView1.Rows.Count - 1 + 1
        Dim sum As Double = 0
        Dim subtotal As Double = 0
        Dim tax As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(9).Value
            tax = tax + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(6).Value / 100 * DataGridView1.Rows(i).Cells(8).Value
            subtotal = subtotal + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(8).Value
        Next


        Try

            ' Display subtotal
            txt_sub_total.Text = Format(CDec(subtotal), "#,##0.00")

            ' Display total tax
            txt_totaltax.Text = Format(CDec(tax), "#,##0.00")

            ' Calculate total price (subtotal + tax)
            txt_totalprice.Text = Format(CDec(subtotal + tax), "#,##0.00")



            ' Calculate grand total (total price - discount)
            txt_grandtotal.Text = Format(CDec(txt_totalprice.Text - lbl_discount.Text), "#,##0.00")
            txt_overallGrandTotal.Text = Format(CDec(txt_grandtotal.Text), "#,##0.00")


        Catch ex As Exception
            MsgBox(ex.Message)

            Console.WriteLine(ex.ToString())


        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_discount.TextChanged
        Dim discountPercentage As Decimal

        ' Try to parse the text in txt_discount to a Decimal
        If Decimal.TryParse(txt_discount.Text, discountPercentage) Then
            ' The parsing was successful, update lbl_discount.Text
            lbl_discount.Text = Format(discountPercentage * CDec(txt_totalprice.Text) / 100, "#,##0.00")
            txt_grandtotal.Text = Format(CDec(txt_totalprice.Text - lbl_discount.Text), "#,##0.00")
            txt_overallGrandTotal.Text = Format(CDec(txt_grandtotal.Text), "#,##0.00")

        Else
            ' The parsing failed, handle the error (e.g., display a message)
            lbl_discount.Text = "00.00"
        End If
    End Sub

    Private Sub txt_amtrec_TextChanged(sender As Object, e As EventArgs) Handles txt_amtrec.TextChanged
        ' Try to parse the text in txt_grandtotal to a Decimal
        Dim grandTotal As Decimal
        If Decimal.TryParse(txt_grandtotal.Text, grandTotal) Then
            ' Try to parse the text in txt_amtrec to a Decimal
            Dim amountReceived As Decimal
            If Decimal.TryParse(txt_amtrec.Text, amountReceived) Then
                ' Both parsing operations were successful, update txt_change
                txt_change.Text = Format(amountReceived - grandTotal, "#,##0.00")
                btn_pay.Enabled = True
            Else
                ' The parsing of txt_amtrec failed, handle the error (e.g., display a message)
                txt_change.Text = "00.00"
            End If
        Else
            ' The parsing of txt_grandtotal failed, handle the error (e.g., display a message)
            txt_change.Text = "00.00"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dd:MMMM:yyyy dddd")
    End Sub

    Sub save_bill()
        If cbo_payMode.Text = String.Empty Then
            MsgBox("Pls select payment mode !", vbInformation)
            Return
        ElseIf txt_amtrec.Text = String.Empty Then
            MsgBox("Pls eneter payment mode ", vbInformation)
            Return
        ElseIf txt_grandtotal.Text > txt_amtrec.Text Then
            MsgBox("Infinity Balance !", vbInformation)
            Return

        Else
            Try
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                ' Update product stock in tblproduct
                For j As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim updateStockQuery As String = "UPDATE tblproduct SET stock = stock - @qty WHERE procode = @procode"
                    cmd = New MySqlCommand(updateStockQuery, conn)
                    cmd.Parameters.AddWithValue("@qty", CInt(DataGridView1.Rows(j).Cells(8).Value)) ' Assuming qty is in the eighth column
                    cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value.ToString())

                    ' Execute the update query
                    cmd.ExecuteNonQuery()
                Next
                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd = New MySqlCommand("INSERT INTO tbi_pos (billno, billdate, bmonth, bmonthyear, procode, proname, progroup, uom, price, tax, totalproductprice, qty, totalpriceqty, subtotal, totaltax, totalprice, discount_per, discount_amount, grandtotal, paymode, recieveamount, balance,cashier_name) VALUES " &
                                               "(@billno, @billdate, @bmonth, @bmonthyear, @procode, @proname, @progroup, @uom, @price, @tax, @totalproductprice, @qty, @totalpriceqty, @subtotal, @totaltax, @totalprice,@discount_per, @discount_amount, @grandtotal, @paymode, @recieveamount, @balance,@cashier_name)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@billno", txt_billno.Text)
                    cmd.Parameters.AddWithValue("@billdate", CDate(btp_time.Text))
                    cmd.Parameters.AddWithValue("@bmonth", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@bmonthyear", Date.Now.ToString("MMMM-yyyy"))
                    cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(2).Value) ' Assuming proname is in the second column
                    cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(3).Value) ' Assuming progroup is in the third column
                    cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(4).Value) ' Assuming uom is in the fourth column
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(5).Value) ' Assuming price is in the fifth column
                    cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(6).Value) ' Assuming tax is in the sixth column
                    cmd.Parameters.AddWithValue("@totalproductprice", DataGridView1.Rows(j).Cells(7).Value) ' Assuming totalproductprice is in the seventh column
                    cmd.Parameters.AddWithValue("@qty", (DataGridView1.Rows(j).Cells(8).Value)) ' Assuming qty is in the eighth column
                    cmd.Parameters.AddWithValue("@totalpriceqty", (DataGridView1.Rows(j).Cells(9).Value)) ' Assuming totalpriceqty is in the ninth column
                    cmd.Parameters.AddWithValue("@subtotal", (txt_sub_total.Text))
                    cmd.Parameters.AddWithValue("@totaltax", (txt_totaltax.Text))
                    cmd.Parameters.AddWithValue("@totalprice", (txt_totalprice.Text))
                    cmd.Parameters.AddWithValue("@discount_per", (txt_discount.Text))
                    cmd.Parameters.AddWithValue("@discount_amount", (lbl_discount.Text)) ' Please verify if 181_discount is the correct control
                    cmd.Parameters.AddWithValue("@grandtotal", (txt_grandtotal.Text))
                    cmd.Parameters.AddWithValue("@paymode", cbo_payMode.Text)
                    cmd.Parameters.AddWithValue("@recieveamount", (txt_amtrec.Text)) ' Assuming txt_AmountReceived is the correct control
                    cmd.Parameters.AddWithValue("@balance", (txt_change.Text))
                    cmd.Parameters.AddWithValue("@cashier_name", (UserSession.CurrentUser))

                    i = cmd.ExecuteNonQuery


                Next
                If i > 0 Then
                    MsgBox("New Transcition Save Success !" & vbNewLine & "Bill no : " & txt_billno.Text)

                Else
                    MsgBox("Last Transcation  Failed !", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If



    End Sub
    Sub Clear()

        lbl_date.Text = Now
        txt_SearchProduct.Clear()
        DataGridView1.Rows.Clear()
        txt_change.Text = "0.00"
        lbl_discount.Text = "0.00"
        txt_discount.Clear()
        txt_grandtotal.Text = "0.00"
        txt_no_of_items.Text = "0"
        txt_grandtotal.Text = "0.00"
        txt_sub_total.Text = "0.00"
        txt_totalprice.Text = "0.00"
        txt_totaltax.Text = "0.00"
        cbo_payMode.SelectedIndex = -1
        txt_amtrec.Clear()
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click

        save_bill()
        frm_mainAdmin.Load_monthSale()
        frm_mainAdmin.Load_todaySale()
        frm_billprint.ShowDialog()
        Clear()
        txt_billno.Text = GetbillNo()
        txt_SearchProduct.Focus()

    End Sub

    Private Sub btm_new_Click(sender As Object, e As EventArgs) Handles btm_new.Click
        Clear()
        txt_billno.Text = GetbillNo()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows.Item(1))
        Else
            MessageBox.Show("Please select a row to remove.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        frm_ChangePassword.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.ShowDialog()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is the "Remove" button (assuming it's in the 10th column, adjust accordingly)
        If e.ColumnIndex = 11 AndAlso e.RowIndex >= 0 Then
            ' Remove the clicked row
            DataGridView1.Rows.RemoveAt(e.RowIndex)

            ' Renumber the rows
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Cells(0).Value = i + 1
            Next
        End If

        ' Check if the clicked cell is the button column and a valid row
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 10 Then
            ' Get the selected row index
            Dim rowIndex As Integer = e.RowIndex

            ' Check if the quantity is greater than 1 before deducting
            If CInt(DataGridView1.Rows(rowIndex).Cells(8).Value) > 1 Then
                ' Deduct the quantity by 1
                DataGridView1.Rows(rowIndex).Cells(8).Value = CInt(DataGridView1.Rows(rowIndex).Cells(8).Value) - 1
                ' Recalculate total price for the row
                DataGridView1.Rows(rowIndex).Cells(9).Value = CInt(DataGridView1.Rows(rowIndex).Cells(5).Value) * CInt(DataGridView1.Rows(rowIndex).Cells(8).Value)
            Else
                ' If the quantity is already 1, you may choose to remove the row or handle it accordingly
                MsgBox("Qty is already 1 you cannot deduct the qty now ")
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_cancelorder.ShowDialog()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        frm_report.ShowDialog()
    End Sub

    Private Sub frm_mainCashier_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F1) Then
            btm_new_Click(sender, e)
        ElseIf (e.KeyCode = Keys.F2) Then
            btn_cancel_Click(sender, e)

        ElseIf (e.KeyCode = Keys.F4) Then
            btn_report_Click(sender, e)
        ElseIf (e.KeyCode = Keys.F6) Then
            btn_change_Click(sender, e)
        ElseIf (e.KeyCode = Keys.F7) Then
            btn_logout_Click(sender, e)
        End If


    End Sub
End Class