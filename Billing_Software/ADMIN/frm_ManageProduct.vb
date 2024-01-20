Imports MySql.Data.MySqlClient
Imports MessagingToolkit.Barcode

Public Class frm_ManageProduct
    Private Sub frm_ManageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        DataGridView1.RowTemplate.Height = 30

        loadproductgroup()
        loadproduct()

    End Sub

    Private Sub btn_AddGroup_Click(sender As Object, e As EventArgs) Handles btn_AddGroup.Click
        frm_addGroup.ShowDialog()


    End Sub
    Sub loadproductgroup()
        cbo_group.Items.Clear()

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblgroup`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cbo_group.Items.Add(dr.Item("progroup").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Sub loadproduct()
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT  * FROM `tblproduct` ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("stock"), dr.Item("Rate_per"),
                dr.Item("purchase_price"), dr.Item("selling_price"), dr.Item("discount_percent"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("barcode"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message & "2")
        End Try

    End Sub
    Sub Clear()
        txt_qty.Clear()

        txt_procode.Clear()

        txt_proname.Clear()
        txt_totalprice.Clear()
        txt_purchase_price.Clear()
        txt_rate_per.Clear()
        cbo_group.SelectedIndex = -1
        cbo_tax.Text = Nothing
        gstAmount.Clear()
        afterGST.Clear()
        txt_selling_price.Clear()
        txt_discount.Clear()
        txt_discount_amt.Clear()
        cbo_uom.SelectedIndex = -1

        pic_barcode.Image = Nothing
        txt_procode.Focus()
        txt_procode.ReadOnly = False
    End Sub

    Private Sub txt_procode_TextChanged(sender As Object, e As EventArgs) Handles txt_procode.LostFocus


        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            cmd = New MySqlCommand("SELECT COUNT(procode) FROM tblproduct WHERE procode=@procode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)


            Dim count As Integer = CInt(cmd.ExecuteScalar())


            If count >= 1 Then
                MsgBox("Product code already exists in the product table", vbInformation)
                txt_procode.Clear()
                txt_procode.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Try
            pic_barcode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_procode.Text))
        Catch ex As Exception
            pic_barcode.Image = Nothing
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If String.IsNullOrWhiteSpace(txt_procode.Text) Then
            MsgBox("Please enter a product code")
            Return
        End If

        If String.IsNullOrWhiteSpace(txt_proname.Text) Then
            MsgBox("Please enter a product name")
            Return
        End If

        If String.IsNullOrWhiteSpace(cbo_group.Text) Then
            MsgBox("Please select a product group")
            Return
        End If
        If String.IsNullOrWhiteSpace(txt_qty.Text) Then
            MsgBox("Please Enter a qty")
            Return
        End If
        If String.IsNullOrWhiteSpace(txt_rate_per.Text) Then
            MsgBox("Please Enter a rate")
            Return
        End If
        If String.IsNullOrWhiteSpace(cbo_tax.Text) Then
            MsgBox("Please select a tax")
            Return
        End If
        If String.IsNullOrWhiteSpace(txt_purchase_price.Text) Then
            MsgBox("Please Enter a purchase price")
            Return
        End If


        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            'image comnvered to binaryformate'
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()

            'cmd = New MySqlCommand("INSERT INTO `tblproduct`(`procode`, `proname`, `progroup`, `uom`, `Rate_per`, `stock`, `purchase_price`, `Selling_price`, `tax`, `totalprice`, `barcode`)
            'VALUES (@procode, @proname,@progroup, @uom, @rate_per, @stock, @purchase_price, @selling_price, @tax, @totalprice, @barcode)", conn)
            cmd = New MySqlCommand("INSERT INTO `tblproduct`(`procode`, `proname`, `progroup`, `uom`, `Rate_per`, `stock`, `purchase_price`, `tax`, `totalprice`, `barcode` , `discount_percent`, `discount_amt`,`selling_price`)
    VALUES (@procode, @proname,@progroup, @uom, @rate_per, @stock, @purchase_price, @tax, @totalprice, @barcode, @discount_per, @discount_amt, @selling_price)", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
            cmd.Parameters.AddWithValue("@proname", txt_proname.Text)
            cmd.Parameters.AddWithValue("@progroup", cbo_group.Text)
            cmd.Parameters.AddWithValue("@uom", cbo_uom.Text)
            cmd.Parameters.AddWithValue("@stock", CDec(txt_qty.Text))
            cmd.Parameters.AddWithValue("@Rate_per", CDec(txt_rate_per.Text))
            cmd.Parameters.AddWithValue("@purchase_price", CDec(txt_purchase_price.Text))

            cmd.Parameters.AddWithValue("@selling_price", CDec(txt_selling_price.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalprice.Text))
            cmd.Parameters.AddWithValue("@discount_amt", CDec(txt_discount_amt.Text))
            cmd.Parameters.AddWithValue("@discount_per", CDec(txt_discount.Text))
            cmd.Parameters.AddWithValue("@barcode", arrImage)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Porudct Save Success", vbInformation)
            Else
                MsgBox("New Porudct Save Failed", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' conn.Close()
        Clear()
        loadproduct()
        'loadproduct()
        'frm_mainAdmin.Load_noOfProduct()
    End Sub



    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If String.IsNullOrEmpty(txt_SearchProductCode.Text.Trim()) Then

            MsgBox("Please enter a product code.", vbInformation)
            Return
        End If

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            'this is for if the code is present or not to check the code presend tin the db'
            cmd = New MySqlCommand("SELECT COUNT(procode) FROM tblproduct WHERE procode=@procode", conn)
            cmd.Parameters.AddWithValue("@procode", txt_SearchProductCode.Text)
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Entered product code is " & txt_SearchProductCode.Text)
            Else
                MsgBox("Product code not found", vbExclamation)
                txt_SearchProductCode.Clear()
                Return
            End If


            cmd = New MySqlCommand("SELECT * FROM tblproduct WHERE procode LIKE @procode", conn)
            cmd.Parameters.AddWithValue("@procode", txt_SearchProductCode.Text)

            dr = cmd.ExecuteReader
            While dr.Read
                txt_proname.Text = dr.Item("proname")
                cbo_group.Text = dr.Item("progroup")
                cbo_uom.Text = dr.Item("uom")
                txt_qty.Text = dr.Item("stock")
                txt_rate_per.Text = dr.Item("Rate_per")
                txt_purchase_price.Text = dr.Item("purchase_price")
                cbo_tax.Text = dr.Item("tax")
                txt_selling_price.Text = dr.Item("selling_price")
                txt_discount.Text = dr.Item("discount_percent")
                txt_discount_amt.Text = dr.Item("discount_amt")
                txt_totalprice.Text = dr.Item("totalprice")
            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txt_procode.ReadOnly = True
    End Sub


    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try

            If String.IsNullOrEmpty(txt_SearchProductCode.Text.Trim()) Then

                MsgBox("Please enter a product code and click 'Search' before editing.", vbInformation)
                Return
            End If

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            'cmd = New MySqlCommand("UPDATE `tblproduct` SET `proname`=@proname,`progroup`=@progroup,`uom`=@uom,`location`=@location,`price`=@price,`tax`=@tax,`totalprice`=@totalprice WHERE `procode`=@procode", conn)
            cmd = New MySqlCommand("UPDATE `tblproduct` SET `proname`=@proname, `progroup`=@progroup, `uom`=@uom, `Rate_per` = @mrp, `stock` = @qty, `purchase_price`=@pp, `tax`=@tax, `totalprice`=@totalprice ,`discount_percent`=@discount_per,`discount_amt`=@discount_amt,`selling_price`=@sp  where `procode`=@procode ", conn)

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@proname", txt_proname.Text)
            cmd.Parameters.AddWithValue("@progroup", cbo_group.Text)
            cmd.Parameters.AddWithValue("@uom", cbo_uom.Text)
            cmd.Parameters.AddWithValue("@mrp", txt_rate_per.Text)
            cmd.Parameters.AddWithValue("@qty", CDec(txt_qty.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@pp", CDec(txt_purchase_price.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalprice.Text))
            cmd.Parameters.AddWithValue("@procode", txt_SearchProductCode.Text)
            cmd.Parameters.AddWithValue("@discount_per", txt_discount.Text)
            cmd.Parameters.AddWithValue("@sp", txt_selling_price.Text)
            cmd.Parameters.AddWithValue("@discount_amt", txt_discount_amt.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product Update Success", vbInformation)
            Else
                MsgBox("New Product Save Failed", vbExclamation)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Clear()
        txt_SearchProductCode.Clear()
        loadproduct()
        frm_mainAdmin.NoOfProduct()

    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If String.IsNullOrEmpty(txt_SearchProductCode.Text.Trim()) Then

                MsgBox("Please enter a product code and click 'Search' before deleting.", vbInformation)
                Return
            End If

            If MsgBox("Are you sure you want to delete this product?", vbExclamation + vbYesNo) = vbYes Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                cmd = New MySqlCommand("DELETE FROM `tblproduct` WHERE `procode`=@procode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@procode", txt_SearchProductCode.Text)

                i = cmd.ExecuteNonQuery
                MsgBox(i)
                If i > 0 Then
                    MsgBox("Delete Success", vbInformation)
                Else
                    MsgBox("Delete Failed", vbExclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Clear()
        txt_SearchProductCode.Clear()
        loadproduct()
    End Sub



    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
        cbo_tax.SelectedIndex = -1
        txt_SearchProductCode.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    Private Sub txt_rate_per_Leave(sender As Object, e As EventArgs) Handles cbo_tax.TextChanged
        'updatepurchaseprice()
        updateGST()
    End Sub
    Public p_price As Decimal
    Public t_price As Decimal
    Private Sub txt_purchase_price_Leave(sender As Object, e As EventArgs) Handles txt_purchase_price.Leave

        If txt_purchase_price.Text <> "" Then
            If CDec(txt_purchase_price.Text) > p_price Then
                txt_purchase_price.Clear()
                txt_purchase_price.Focus()
                MsgBox("Enter vailid purchase price", vbCritical)
                Return
            End If
            txt_totalprice.Text = Math.Round(CDec(txt_qty.Text) * CDec(txt_purchase_price.Text), 2)
        Else
            MsgBox("Please Enter purchase price")
        End If
    End Sub


    Sub updateGST()
        Try
            Dim mrp, b, cbotax As Decimal
            Decimal.TryParse(txt_rate_per.Text, mrp)
            'Decimal.TryParse(txt_rate_per.Text, b)
            Decimal.TryParse(cbo_tax.Text, cbotax)
            b = 100 + cbotax
            gstAmount.Text = Math.Round(mrp / b * cbotax, 2)
            p_price = mrp - CDec(gstAmount.Text)
            afterGST.Text = p_price
            'MsgBox(a & " " & c)
            Dim qty As Integer
            Decimal.TryParse(txt_qty.Text, qty)
            t_price = Math.Round(qty * p_price, 2)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Private Sub updatepurchaseprice()

        Dim qty As Integer
        If Integer.TryParse(txt_qty.Text, qty) Then

            Dim rate As Integer
            If Integer.TryParse(txt_rate_per.Text, rate) Then

                txt_purchase_price.Text = (qty * rate).ToString()
            Else

                MessageBox.Show("Please enter a valid rate.")
            End If
        Else

            MessageBox.Show("Please enter a valid quantity.")
        End If
    End Sub


    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE procode like '%" & txt_search.Text & "%' or progroup like '%" & txt_search.Text & "%' or proname like '%" & txt_search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("stock"), dr.Item("Rate_per"),
                dr.Item("purchase_price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("barcode"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_discount.TextChanged
        Try
            Dim mrp, dis_per, dis_amt As Decimal
            Decimal.TryParse(txt_rate_per.Text, mrp)
            'Decimal.TryParse(txt_rate_per.Text, b)
            Decimal.TryParse(txt_discount.Text, dis_per)
            dis_amt = Math.Round(dis_per / 100 * mrp, 2)
            txt_selling_price.Text = mrp - dis_amt
            txt_discount_amt.Text = dis_amt
            'MsgBox(a & " " & c)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class
