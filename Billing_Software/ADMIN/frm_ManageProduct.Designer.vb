<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.afterGST = New System.Windows.Forms.TextBox()
        Me.txt_selling_price = New System.Windows.Forms.TextBox()
        Me.txt_discount_amt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gstAmount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_rate_per = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.txt_purchase_price = New System.Windows.Forms.TextBox()
        Me.btn_AddGroup = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_SearchProductCode = New System.Windows.Forms.TextBox()
        Me.pic_barcode = New System.Windows.Forms.PictureBox()
        Me.txt_totalprice = New System.Windows.Forms.TextBox()
        Me.cbo_tax = New System.Windows.Forms.ComboBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.cbo_uom = New System.Windows.Forms.ComboBox()
        Me.cbo_group = New System.Windows.Forms.ComboBox()
        Me.txt_proname = New System.Windows.Forms.TextBox()
        Me.txt_procode = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 77)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(12, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(186, 30)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Manage Product"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 77)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(8, 15)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1166, 636)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 48)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1158, 584)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PRODUCT LIST"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeight = 47
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column13, Me.Column9, Me.Column12, Me.Column14, Me.Column10, Me.Column11, Me.Column7, Me.Column8})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1152, 512)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1152, 66)
        Me.Panel2.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(97, 25)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(313, 23)
        Me.txt_search.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Search"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.afterGST)
        Me.TabPage2.Controls.Add(Me.txt_selling_price)
        Me.TabPage2.Controls.Add(Me.txt_discount_amt)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.gstAmount)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txt_rate_per)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txt_discount)
        Me.TabPage2.Controls.Add(Me.txt_purchase_price)
        Me.TabPage2.Controls.Add(Me.btn_AddGroup)
        Me.TabPage2.Controls.Add(Me.btn_clear)
        Me.TabPage2.Controls.Add(Me.btn_delete)
        Me.TabPage2.Controls.Add(Me.btn_edit)
        Me.TabPage2.Controls.Add(Me.btn_save)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txt_SearchProductCode)
        Me.TabPage2.Controls.Add(Me.pic_barcode)
        Me.TabPage2.Controls.Add(Me.txt_totalprice)
        Me.TabPage2.Controls.Add(Me.cbo_tax)
        Me.TabPage2.Controls.Add(Me.txt_qty)
        Me.TabPage2.Controls.Add(Me.cbo_uom)
        Me.TabPage2.Controls.Add(Me.cbo_group)
        Me.TabPage2.Controls.Add(Me.txt_proname)
        Me.TabPage2.Controls.Add(Me.txt_procode)
        Me.TabPage2.Location = New System.Drawing.Point(4, 48)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1158, 584)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADD PRODUCT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'afterGST
        '
        Me.afterGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.afterGST.Location = New System.Drawing.Point(856, 106)
        Me.afterGST.Name = "afterGST"
        Me.afterGST.ReadOnly = True
        Me.afterGST.Size = New System.Drawing.Size(100, 23)
        Me.afterGST.TabIndex = 33
        '
        'txt_selling_price
        '
        Me.txt_selling_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_selling_price.Location = New System.Drawing.Point(856, 161)
        Me.txt_selling_price.Name = "txt_selling_price"
        Me.txt_selling_price.ReadOnly = True
        Me.txt_selling_price.Size = New System.Drawing.Size(98, 23)
        Me.txt_selling_price.TabIndex = 32
        '
        'txt_discount_amt
        '
        Me.txt_discount_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_discount_amt.Location = New System.Drawing.Point(721, 161)
        Me.txt_discount_amt.Name = "txt_discount_amt"
        Me.txt_discount_amt.ReadOnly = True
        Me.txt_discount_amt.Size = New System.Drawing.Size(98, 23)
        Me.txt_discount_amt.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(853, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 15)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Selling Price"
        '
        'gstAmount
        '
        Me.gstAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gstAmount.Location = New System.Drawing.Point(721, 106)
        Me.gstAmount.Name = "gstAmount"
        Me.gstAmount.ReadOnly = True
        Me.gstAmount.Size = New System.Drawing.Size(98, 23)
        Me.gstAmount.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(718, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 15)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Discount Amount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(853, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 15)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Price After GST"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(718, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "GST Amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(119, 390)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "MRP"
        '
        'txt_rate_per
        '
        Me.txt_rate_per.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rate_per.Location = New System.Drawing.Point(123, 413)
        Me.txt_rate_per.Name = "txt_rate_per"
        Me.txt_rate_per.Size = New System.Drawing.Size(245, 23)
        Me.txt_rate_per.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Discount %"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(433, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Purchase Price"
        '
        'txt_discount
        '
        Me.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_discount.Location = New System.Drawing.Point(438, 161)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(245, 23)
        Me.txt_discount.TabIndex = 7
        '
        'txt_purchase_price
        '
        Me.txt_purchase_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_purchase_price.Location = New System.Drawing.Point(437, 227)
        Me.txt_purchase_price.Name = "txt_purchase_price"
        Me.txt_purchase_price.Size = New System.Drawing.Size(245, 23)
        Me.txt_purchase_price.TabIndex = 8
        '
        'btn_AddGroup
        '
        Me.btn_AddGroup.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_AddGroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddGroup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_AddGroup.FlatAppearance.BorderSize = 0
        Me.btn_AddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddGroup.ForeColor = System.Drawing.Color.White
        Me.btn_AddGroup.Location = New System.Drawing.Point(339, 224)
        Me.btn_AddGroup.Name = "btn_AddGroup"
        Me.btn_AddGroup.Size = New System.Drawing.Size(33, 27)
        Me.btn_AddGroup.TabIndex = 25
        Me.btn_AddGroup.Text = "+"
        Me.btn_AddGroup.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Gray
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Location = New System.Drawing.Point(532, 467)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(109, 27)
        Me.btn_clear.TabIndex = 24
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(391, 467)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(109, 27)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(259, 467)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(109, 27)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Blue
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(123, 467)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(109, 27)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(588, 44)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(109, 27)
        Me.btn_search.TabIndex = 20
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(119, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Search Product Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(433, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Purchase Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(433, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Barcode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "GST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "UOM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Product Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product Code"
        '
        'txt_SearchProductCode
        '
        Me.txt_SearchProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SearchProductCode.Location = New System.Drawing.Point(123, 44)
        Me.txt_SearchProductCode.Name = "txt_SearchProductCode"
        Me.txt_SearchProductCode.Size = New System.Drawing.Size(459, 23)
        Me.txt_SearchProductCode.TabIndex = 0
        '
        'pic_barcode
        '
        Me.pic_barcode.BackColor = System.Drawing.Color.White
        Me.pic_barcode.Location = New System.Drawing.Point(437, 367)
        Me.pic_barcode.Name = "pic_barcode"
        Me.pic_barcode.Size = New System.Drawing.Size(235, 72)
        Me.pic_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barcode.TabIndex = 8
        Me.pic_barcode.TabStop = False
        '
        'txt_totalprice
        '
        Me.txt_totalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_totalprice.Location = New System.Drawing.Point(437, 298)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.ReadOnly = True
        Me.txt_totalprice.Size = New System.Drawing.Size(245, 23)
        Me.txt_totalprice.TabIndex = 9
        '
        'cbo_tax
        '
        Me.cbo_tax.FormattingEnabled = True
        Me.cbo_tax.Items.AddRange(New Object() {"NIL", "5", "12", "18", "28"})
        Me.cbo_tax.Location = New System.Drawing.Point(438, 106)
        Me.cbo_tax.Name = "cbo_tax"
        Me.cbo_tax.Size = New System.Drawing.Size(245, 23)
        Me.cbo_tax.TabIndex = 6
        '
        'txt_qty
        '
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Location = New System.Drawing.Point(123, 351)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(245, 23)
        Me.txt_qty.TabIndex = 4
        '
        'cbo_uom
        '
        Me.cbo_uom.FormattingEnabled = True
        Me.cbo_uom.Items.AddRange(New Object() {"NOS", "PKT", "BAG", "LTR", "PAR"})
        Me.cbo_uom.Location = New System.Drawing.Point(123, 285)
        Me.cbo_uom.Name = "cbo_uom"
        Me.cbo_uom.Size = New System.Drawing.Size(245, 23)
        Me.cbo_uom.TabIndex = 3
        '
        'cbo_group
        '
        Me.cbo_group.FormattingEnabled = True
        Me.cbo_group.Location = New System.Drawing.Point(123, 223)
        Me.cbo_group.Name = "cbo_group"
        Me.cbo_group.Size = New System.Drawing.Size(210, 23)
        Me.cbo_group.TabIndex = 2
        '
        'txt_proname
        '
        Me.txt_proname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_proname.Location = New System.Drawing.Point(123, 161)
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.Size = New System.Drawing.Size(245, 23)
        Me.txt_proname.TabIndex = 1
        '
        'txt_procode
        '
        Me.txt_procode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_procode.Location = New System.Drawing.Point(123, 106)
        Me.txt_procode.Name = "txt_procode"
        Me.txt_procode.Size = New System.Drawing.Size(245, 23)
        Me.txt_procode.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "PRO CODE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 82
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "PRODUCT NAME"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "GROUP"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 71
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UOM"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Stock"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 62
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = "MRP"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 57
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Purchase Price"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Selling Price"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Discount %"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "TAX %"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 61
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "Total Purchase Price"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 126
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "STOCK"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 69
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "BARCODE"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Visible = False
        Me.Column8.Width = 85
        '
        'frm_ManageProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1166, 713)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_ManageProduct"
        Me.Text = "Manage Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_totalprice As TextBox
    Friend WithEvents cbo_tax As ComboBox
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents cbo_uom As ComboBox
    Friend WithEvents cbo_group As ComboBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents txt_procode As TextBox
    Friend WithEvents pic_barcode As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_SearchProductCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_AddGroup As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_purchase_price As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_rate_per As TextBox
    Friend WithEvents afterGST As TextBox
    Friend WithEvents gstAmount As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_discount_amt As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents txt_selling_price As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
End Class
