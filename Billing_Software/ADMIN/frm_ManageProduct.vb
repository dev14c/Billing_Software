Imports MySql.Data.MySqlClient
Imports MessagingToolkit.Barcode

Public Class frm_ManageProduct
    Private Sub frm_ManageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        DataGridView1.RowTemplate.Height = 30

        load_PorductGroup()
        load_product()

    End Sub

    Private Sub btn_AddGroup_Click(sender As Object, e As EventArgs) Handles btn_AddGroup.Click
        frm_addGroup.ShowDialog()


    End Sub
    Sub load_PorductGroup()
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
    Sub load_product()
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT  `procode`, `proname`, `progroup`, `uom`, `stock`,`Rate_per`,`purchase_price`,`Selling_price`, `tax`, `totalprice`,`barcode` FROM `tblproduct` ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("stock"), dr.Item("Rate_per"),
                dr.Item("purchase_price"), dr.Item("Selling_price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("barcode"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message & "2")
        End Try

    End Sub
    Sub Clear()
        txt_location.Clear()
        txt_selling_price.Clear()
        txt_procode.Clear()
        txt_proname.Clear()
        txt_totalprice.Clear()
        txt_purchase_price.Clear() ' Add this line to clear txt_purchase
        txt_rate_per.Clear() ' Add this line to clear txt_rate_per
        cbo_group.SelectedIndex = -1
        cbo_tax.SelectedIndex = -1
        cbo_uom.SelectedIndex = -1
        pic_barcode.Image = Nothing

    End Sub

    Private Sub txt_procode_TextChanged(sender As Object, e As EventArgs) Handles txt_procode.TextChanged
        'Barcode Generator'
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Try
            pic_barcode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_procode.Text))
        Catch ex As Exception
            pic_barcode.Image = Nothing
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
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
            cmd = New MySqlCommand("INSERT INTO `tblproduct`(`procode`, `proname`, `progroup`, `uom`, `Rate_per`, `stock`, `purchase_price`, `tax`, `totalprice`, `barcode`)
    VALUES (@procode, @proname,@progroup, @uom, @rate_per, @stock, @purchase_price, @tax, @totalprice, @barcode)", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
            cmd.Parameters.AddWithValue("@proname", txt_proname.Text)
            cmd.Parameters.AddWithValue("@progroup", cbo_group.Text)
            cmd.Parameters.AddWithValue("@uom", cbo_uom.Text)
            cmd.Parameters.AddWithValue("@stock", CDec(txt_location.Text))
            cmd.Parameters.AddWithValue("@Rate_per", CDec(txt_rate_per.Text))
            cmd.Parameters.AddWithValue("@purchase_price", CDec(txt_purchase_price.Text))
            'cmd.Parameters.AddWithValue("@selling_price", CDec(txt_selling_price.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalprice.Text))
            cmd.Parameters.AddWithValue("@barcode", arrImage)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Porudct Save Success", vbExclamation)
            Else
                MsgBox("New Porudct Save Failed", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " 4 ")
        End Try
        ' conn.Close()
        Clear()
        'load_product()
        'frm_mainAdmin.Load_noOfProduct()
    End Sub

    Private Sub cbo_tax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tax.SelectedIndexChanged

        Dim price As Decimal
        Dim taxPercentage As Decimal
        Dim qty As Integer


        If Decimal.TryParse(txt_selling_price.Text, price) AndAlso Decimal.TryParse(cbo_tax.Text, taxPercentage) AndAlso Integer.TryParse(txt_location.Text, qty) Then
            ' Conversion successful, txt_price.Text and cbo_tax.Text contain valid numerical values
            ' Calculate total price with tax
            Dim taxAmount As Decimal = (price * taxPercentage) / 100
            Dim totalPrice As Decimal = price * qty
            totalPrice = totalPrice + taxAmount


            ' Update txt_totalprice TextBox with the calculated total price
            txt_totalprice.Text = totalPrice.ToString()

        End If
    End Sub



    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        'search product
        DataGridView1.Rows.Clear()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblproduct` WHERE procode LIKE '%" & txt_search.Text & "%' OR proname LIKE '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("location"), dr.Item("price"),
                                       dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"), dr.Item("barcode"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        txt_procode.ReadOnly = True
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("SELECT  `procode`, `proname`, `progroup`, `uom`, `stock`, `Rate_per`,`purchase_price`,`Selling_price`, `tax`, `totalprice`,`barcode` FROM `tblproduct` WHERE procode LIKE '%" & txt_SearchProductCode.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                txt_procode.Text = dr.Item("procode")
                txt_proname.Text = dr.Item("proname")
                cbo_group.Text = dr.Item("progroup")
                cbo_uom.Text = dr.Item("uom")
                txt_location.Text = dr.Item("stock")
                txt_location.Text = dr.Item("Rate_per")
                txt_location.Text = dr.Item("purchase_price")
                txt_selling_price.Text = dr.Item("Selling_price")
                cbo_tax.Text = dr.Item("tax")
                txt_totalprice.Text = dr.Item("totalprice")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tblproduct` SET `proname`=@proname,`progroup`=@progroup,`uom`=@uom,`location`=@location,`price`=@price,`tax`=@tax,`totalprice`=@totalprice WHERE `procode`=@procode", conn)

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@proname", txt_proname.Text)
            cmd.Parameters.AddWithValue("@progroup", cbo_group.Text)
            cmd.Parameters.AddWithValue("@uom", cbo_uom.Text)
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_selling_price.Text))
            cmd.Parameters.AddWithValue("@tax", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@totalprice", CDec(txt_totalprice.Text))
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Porudct Update Success", vbExclamation)
            Else
                MsgBox("New Porudct Save Failed", vbExclamation)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Clear()
        txt_SearchProductCode.Clear()
        load_product()
        frm_mainAdmin.Load_noOfProduct()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you SUre Delete this Product", vbExclamation + vbYesNo) = vbYes Then
            Try

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblproduct` WHERE `procode`=@procode", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@procode", txt_procode.Text)


                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Delete  Success", vbExclamation)
                Else
                    MsgBox("New Porudct Save Failed", vbExclamation)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Clear()
            txt_SearchProductCode.Clear()
            load_product()
        Else
            Return

        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
        cbo_tax.SelectedIndex = -1
        txt_SearchProductCode.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    Private Sub txt_rate_per_Leave(sender As Object, e As EventArgs) Handles cbo_tax.TextChanged
        'UpdatePurchasePrice()
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
            txt_totalprice.Text = Math.Round(CDec(txt_location.Text) * CDec(txt_purchase_price.Text), 2)
        Else
            MsgBox("Purchase price khaali reh gaya")
        End If
    End Sub


    Sub updateGST()
        Try
            Dim a, b, c As Decimal
            Decimal.TryParse(txt_rate_per.Text, a)
            'Decimal.TryParse(txt_rate_per.Text, b)
            Decimal.TryParse(cbo_tax.Text, c)
            b = 100 + c
            gstAmount.Text = Math.Round(a / b * c, 2)
            p_price = a - CDec(gstAmount.Text)
            afterGST.Text = p_price
            MsgBox(a & " " & c)
            Dim d As Integer
            Decimal.TryParse(txt_location.Text, d)
            t_price = Math.Round(d * p_price, 2)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Private Sub UpdatePurchasePrice()
        ' Check if the text in txt_location is a valid integer
        Dim qty As Integer
        If Integer.TryParse(txt_location.Text, qty) Then
            ' Check if the text in txt_rate_per is a valid integer
            Dim rate As Integer
            If Integer.TryParse(txt_rate_per.Text, rate) Then
                ' Calculate the purchase price and update txt_purchase_price
                txt_purchase_price.Text = (qty * rate).ToString()
            Else
                ' Handle the case where txt_rate_per contains non-numeric text
                MessageBox.Show("Please enter a valid rate.")
            End If
        Else
            ' Handle the case where txt_location contains non-numeric text
            MessageBox.Show("Please enter a valid quantity.")
        End If
    End Sub

    Private Sub txt_rate_per_TextChanged(sender As Object, e As EventArgs) Handles txt_rate_per.TextChanged

    End Sub
End Class
