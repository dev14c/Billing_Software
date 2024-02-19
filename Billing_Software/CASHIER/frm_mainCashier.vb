Imports System.Windows.Media
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cms
Public Class frm_mainCashier


    Public Event MessageReceived(message As String)
    Private Sub frm_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()




        DataGridView1.RowTemplate.Height = 30
        txt_SearchProduct.Focus()
        btn_pay.Enabled = False
        total()
        lbl_username.Text = "Welcome, " & UserSession.CurrentUser

        txt_billno.Text = GetbillNo()

    End Sub

    Public Sub DisplayMessage(message As String)
        ' Display the message in your form
        MessageBox.Show(message, "Message from Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub addlist()
        Dim exist As Boolean = False
        Dim existingRowIndex As Integer = 0
        Dim existingQuantity As Integer = 0


        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = txt_SearchProduct.Text Then
                exist = True
                existingRowIndex = row.Index

                existingQuantity = CInt(row.Cells(8).Value)
                Exit For
            End If
        Next

        If exist Then

            Dim currentStock As Integer = GetStockLevel(txt_SearchProduct.Text)

            Dim x As Integer
            x = currentStock - CInt(DataGridView1.Rows(existingRowIndex).Cells(8).Value)
            If x > 0 Then
                DataGridView1.Rows(existingRowIndex).Cells(8).Value = CInt(DataGridView1.Rows(existingRowIndex).Cells(8).Value) + 1
                calculate_price(existingRowIndex)
            Else
                MsgBox("Insufficient stock for the selected product.", MsgBoxStyle.Exclamation)
            End If
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            ' If the product doesn't exist, add a new 
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM tblproduct WHERE procode = @procode", conn)
                cmd.Parameters.AddWithValue("@procode", txt_SearchProduct.Text)
                dr = cmd.ExecuteReader

                If dr.Read() Then
                    Dim procode As String = dr("procode").ToString()
                    Dim proname As String = dr("proname").ToString()
                    Dim progroup As String = dr("progroup").ToString()
                    Dim uom As String = dr("uom").ToString()
                    Dim stock As Integer = CInt(dr("stock"))
                    Dim purchase As Integer = CInt(dr("purchase_price"))
                    Dim mrp As Integer = CInt(dr("Rate_per"))
                    If stock > 0 Then
                        Dim rate As Decimal
                        Dim tax As Decimal
                        Dim gstprice As Double
                        Dim gstAmount As Double
                        If Decimal.TryParse(dr("selling_price").ToString(), rate) AndAlso Decimal.TryParse(dr("tax").ToString(), tax) Then
                            gstprice = Math.Round(rate / (tax + 100) * tax, 2)
                            gstAmount = Math.Round(rate - gstprice, 2)
                        End If

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, procode, proname, progroup, uom, gstAmount, tax, gstprice, 1, mrp, rate, rate, purchase)
                        txt_SearchProduct.Clear()
                        txt_SearchProduct.Focus()
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


    Public Function GetStockLevel(productCode As String) As Integer
        Dim stockLevel As Integer = 0


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Try
            Dim query As String = "SELECT stock FROM tblproduct WHERE procode = @procode"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@procode", productCode)
                'Dim result As Object = cmd.ExecuteScalar()
                Dim result As Integer = cmd.ExecuteScalar
                'If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), stockLevel) Then
                ' Successfully retrieved stock level from the database

                'Else
                ' Handle the case when the stock level couldn't be retrieved
                'stockLevel = 0
                'End If
                stockLevel = CDec(result)
            End Using
        Catch ex As Exception
            ' Handle exceptions
            stockLevel = 0
        Finally
            conn.Close()
        End Try

        Return stockLevel
    End Function






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
        Dim dis As Double = 0
        Dim items As Integer = DataGridView1.Rows.Count()
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(11).Value

            dis = dis + (DataGridView1.Rows(i).Cells(9).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            tax = tax + DataGridView1.Rows(i).Cells(7).Value

            subtotal = subtotal + DataGridView1.Rows(i).Cells(5).Value
        Next


        Try
            txt_no_of_items.Text = items
            ' Display subtotal
            txt_sub_total.Text = Format(CDec(subtotal), "#,##0.00")

            ' Display total tax
            txt_totaltax.Text = Format(CDec(tax), "#,##0.00")

            ' Calculate total price (subtotal + tax)
            txt_totalprice.Text = Format(CDec(subtotal + tax), "#,##0.00")


            lbl_discount.Text = Format(CDec(dis), "#,##0.00")
            ' Calculate grand total (total price - discount)
            txt_grandtotal.Text = Format(CDec(txt_totalprice.Text), "#,##0.00")
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

        Dim grandTotal As Decimal
        If Decimal.TryParse(txt_grandtotal.Text, grandTotal) Then
            ' Try to parse the text in txt_amtrec to a Decimal
            Dim amountReceived As Decimal
            If Decimal.TryParse(txt_amtrec.Text, amountReceived) Then

                txt_change.Text = Format(amountReceived - grandTotal, "#,##0.00")
                btn_pay.Enabled = True
            Else

                txt_change.Text = "00.00"
            End If
        Else
            '
            txt_change.Text = "00.00"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dd:MMMM:yyyy dddd")
    End Sub
    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        ' Get the customer's mobile number
        Dim customerMobile As String = InputBox("Enter customer mobile number:", "Customer Information")

        ' Check if the user canceled the input
        If String.IsNullOrEmpty(customerMobile) Then
            MessageBox.Show("Payment canceled. Customer mobile number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If


        Dim customerName As String = GetCustomerNameFromDatabase(customerMobile)


        If Not String.IsNullOrEmpty(customerName) Then
            MessageBox.Show($"Customer found: {customerName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            customerName = InputBox("Enter customer name:", "Customer Information")


            If String.IsNullOrEmpty(customerName) Then
                MessageBox.Show("Payment canceled. Customer name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If


        txt_cus_name.Text = customerName
        txt_cus_num.Text = customerMobile



        save_bill()
        If isError = False Then
            frm_billprint.ShowDialog()
            frm_mainAdmin.monthSale()
            frm_mainAdmin.todaysale()

            Clear()
            txt_billno.Text = GetbillNo()
            txt_SearchProduct.Focus()
        End If
        If isError = True Then
            frm_mainAdmin.monthSale()
            frm_mainAdmin.todaysale()



            txt_SearchProduct.Focus()
        End If


    End Sub
    Private Function GetCustomerNameFromDatabase(customerMobile As String) As String
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT Customer_Name FROM tbi_pos WHERE Customer_Mobile = @customerMobile"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@customerMobile", customerMobile)

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                Return result.ToString()
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return String.Empty
        End Try
    End Function


    Dim isError As Boolean = False
    Sub save_bill()
        isError = False

        If txt_cus_name.Text = String.Empty Then
            MsgBox("Please enter customer name!", vbInformation)
            isError = True
            Return
        End If

        If txt_cus_num.Text = String.Empty Then
            MsgBox("Please enter mobile number!", vbInformation)
            isError = True
            Return
        End If

        If cbo_payMode.Text = String.Empty Then
            MsgBox("Please select payment mode!", vbInformation)
            isError = True
            Return
        End If

        If txt_amtrec.Text = String.Empty Then
            MsgBox("Please enter the payment amount!", vbInformation)
            isError = True
            Return
        End If

        If Not IsNumeric(txt_amtrec.Text) Then
            MsgBox("Please enter a valid numeric value for the payment amount!", vbInformation)
            isError = True
            Return
        End If

        If CDec(txt_grandtotal.Text) > CDec(txt_amtrec.Text) Then
            MsgBox("Payment amount cannot be less than the grand total!", vbInformation)
            isError = True
            Return
        End If

        If Not isError Then
            Try
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                For j As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim updateStockQuery As String = "UPDATE tblproduct SET stock = stock - @qty, totalprice = purchase_price * stock  WHERE procode = @procode"
                    cmd = New MySqlCommand(updateStockQuery, conn)
                    cmd.Parameters.AddWithValue("@qty", CInt(DataGridView1.Rows(j).Cells(8).Value))
                    cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value.ToString())

                    ' Execute the update query
                    cmd.ExecuteNonQuery()
                Next
                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd = New MySqlCommand("INSERT INTO tbi_pos (billno, billdate, bmonth, bmonthyear, procode, proname, progroup, uom, price, tax, totalproductprice, qty, totalpriceqty, subtotal, totaltax, totalprice, discount_per, discount_amount, grandtotal, paymode, recieveamount, balance,cashier_name,Customer_Name,Customer_Mobile,profit,time,selling_price) VALUES " &
                               "(@billno, @billdate, @bmonth, @bmonthyear, @procode, @proname, @progroup, @uom, @price, @tax, @totalproductprice, @qty, @totalpriceqty, @subtotal, @totaltax, @totalprice,@discount_per, @discount_amount, @grandtotal, @paymode, @recieveamount, @balance,@cashier_name,@Customer_Name,@Customer_Mobile,@profit,@time,@sp)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@billno", txt_billno.Text)

                    Dim selectedDate As DateTime = DateTime.Today


                    Dim mysqlDateFormat As String = selectedDate.ToString("yyyy-MM-dd")


                    cmd.Parameters.AddWithValue("@billdate", mysqlDateFormat)

                    'cmd.Parameters.AddWithValue("@billdate", CDate(btp_time.Value.Date))
                    cmd.Parameters.AddWithValue("@bmonth", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@bmonthyear", Date.Now.ToString("MMMM-yyyy"))
                    cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@totalproductprice", DataGridView1.Rows(j).Cells(7).Value)
                    cmd.Parameters.AddWithValue("@qty", (DataGridView1.Rows(j).Cells(8).Value))
                    cmd.Parameters.AddWithValue("@totalpriceqty", (DataGridView1.Rows(j).Cells(9).Value))

                    cmd.Parameters.AddWithValue("@sp", (DataGridView1.Rows(j).Cells(10).Value))
                    cmd.Parameters.AddWithValue("@subtotal", (txt_sub_total.Text))
                    cmd.Parameters.AddWithValue("@totaltax", (txt_totaltax.Text))
                    cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(11).Value) '10
                    cmd.Parameters.AddWithValue("@discount_per", (txt_discount.Text))
                    cmd.Parameters.AddWithValue("@discount_amount", (lbl_discount.Text))
                    cmd.Parameters.AddWithValue("@grandtotal", (txt_grandtotal.Text))
                    cmd.Parameters.AddWithValue("@paymode", cbo_payMode.Text)
                    cmd.Parameters.AddWithValue("@recieveamount", (txt_amtrec.Text))
                    cmd.Parameters.AddWithValue("@balance", (txt_change.Text))
                    cmd.Parameters.AddWithValue("@cashier_name", (UserSession.CurrentUser))
                    cmd.Parameters.AddWithValue("@Customer_name", (txt_cus_name.Text))
                    cmd.Parameters.AddWithValue("@Customer_Mobile", (txt_cus_num.Text))
                    cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("hh:mm tt"))


                    Dim profit As Decimal
                    profit = CDec(DataGridView1.Rows(j).Cells(11).Value) - CDec(DataGridView1.Rows(j).Cells(12).Value) * CDec(DataGridView1.Rows(j).Cells(8).Value)
                    cmd.Parameters.AddWithValue("@profit", profit)
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
        txt_cus_name.Clear()
        txt_cus_name.Clear()
    End Sub


    Private Sub btm_new_Click(sender As Object, e As EventArgs) Handles btm_new.Click
        Clear()
        txt_billno.Text = GetbillNo()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click

        DataGridView1.Rows.Clear()


    End Sub


    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        frm_ChangePassword.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.ShowDialog()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = 14 AndAlso e.RowIndex >= 0 Then

            DataGridView1.Rows.RemoveAt(e.RowIndex)


            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Cells(0).Value = i + 1
            Next
        End If


        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 13 Then

            Dim rowIndex As Integer = e.RowIndex

            ' Check if the quantity is greater than 1 before deducting
            If CInt(DataGridView1.Rows(rowIndex).Cells(8).Value) > 1 Then
                ' Deduct the quantity by 1
                DataGridView1.Rows(rowIndex).Cells(8).Value = CInt(DataGridView1.Rows(rowIndex).Cells(8).Value) - 1
                calculate_price(rowIndex)
            Else

                MsgBox("Qty is already 1 you cannot deduct the qty now  you can remove the qty ")
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_cancelorder.ShowDialog()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        frm_report.ShowDialog()
    End Sub



    Private Sub btn_setdiscount_Click(sender As Object, e As EventArgs) Handles btn_submit_cash1.Click
        frm_cahier_cash_report.ShowDialog()
    End Sub

    Sub calculate_price(numrow As Integer)
        Dim qty As Integer = DataGridView1.Rows(numrow).Cells(8).Value
        Dim rate As Integer = DataGridView1.Rows(numrow).Cells(10).Value
        Dim tax As Integer = DataGridView1.Rows(numrow).Cells(6).Value
        Dim taxprice As Decimal
        Dim rate_x_qty As Decimal = rate * qty
        Dim gstAmount As Decimal
        taxprice = Math.Round((rate_x_qty / (tax + 100)) * tax, 2)

        gstAmount = Math.Round(rate_x_qty - taxprice, 2)

        DataGridView1.Rows(numrow).Cells(7).Value = taxprice
        DataGridView1.Rows(numrow).Cells(5).Value = gstAmount
        DataGridView1.Rows(numrow).Cells(11).Value = rate_x_qty
    End Sub





    Private Sub qtyUpdate_Click(sender As Object, e As EventArgs) Handles qtyUpdate.Click
        Dim form2Instance As New frm_qty_add(Me)
        form2Instance.ShowDialog()
    End Sub

    Private Sub txt_billno_TextChanged(sender As Object, e As EventArgs) Handles txt_billno.TextChanged

    End Sub


End Class