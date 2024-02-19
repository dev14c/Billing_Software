<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainCashier
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_loginUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.qtyUpdate = New System.Windows.Forms.Button()
        Me.txt_cus_num = New System.Windows.Forms.TextBox()
        Me.txt_cus_name = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btp_time = New System.Windows.Forms.DateTimePicker()
        Me.txt_SearchProduct = New System.Windows.Forms.TextBox()
        Me.txt_billno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_submit_cash1 = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btm_new = New System.Windows.Forms.Button()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_sub_total = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.Label()
        Me.txt_change = New System.Windows.Forms.Label()
        Me.cbo_payMode = New System.Windows.Forms.ComboBox()
        Me.txt_amtrec = New System.Windows.Forms.TextBox()
        Me.txt_grandtotal = New System.Windows.Forms.Label()
        Me.txt_totaltax = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.txt_totalprice = New System.Windows.Forms.Label()
        Me.txt_no_of_items = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_overallGrandTotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeductQty = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_username)
        Me.Panel1.Controls.Add(Me.lbl_time)
        Me.Panel1.Controls.Add(Me.lbl_loginUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1448, 82)
        Me.Panel1.TabIndex = 0
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(585, 20)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(46, 17)
        Me.lbl_username.TabIndex = 32
        Me.lbl_username.Text = "Label6"
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_time.Location = New System.Drawing.Point(1270, 17)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(165, 40)
        Me.lbl_time.TabIndex = 31
        Me.lbl_time.Text = "00.00"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_loginUser
        '
        Me.lbl_loginUser.AutoSize = True
        Me.lbl_loginUser.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loginUser.Location = New System.Drawing.Point(917, 9)
        Me.lbl_loginUser.Name = "lbl_loginUser"
        Me.lbl_loginUser.Size = New System.Drawing.Size(145, 23)
        Me.lbl_loginUser.TabIndex = 6
        Me.lbl_loginUser.Text = "Inventory System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Inventory System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "POS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.qtyUpdate)
        Me.Panel2.Controls.Add(Me.txt_cus_num)
        Me.Panel2.Controls.Add(Me.txt_cus_name)
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.Controls.Add(Me.btp_time)
        Me.Panel2.Controls.Add(Me.txt_SearchProduct)
        Me.Panel2.Controls.Add(Me.txt_billno)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1448, 113)
        Me.Panel2.TabIndex = 1
        '
        'qtyUpdate
        '
        Me.qtyUpdate.Location = New System.Drawing.Point(822, 77)
        Me.qtyUpdate.Name = "qtyUpdate"
        Me.qtyUpdate.Size = New System.Drawing.Size(75, 23)
        Me.qtyUpdate.TabIndex = 37
        Me.qtyUpdate.Text = "Update Qty"
        Me.qtyUpdate.UseVisualStyleBackColor = True
        '
        'txt_cus_num
        '
        Me.txt_cus_num.Location = New System.Drawing.Point(827, 15)
        Me.txt_cus_num.Name = "txt_cus_num"
        Me.txt_cus_num.Size = New System.Drawing.Size(168, 25)
        Me.txt_cus_num.TabIndex = 36
        Me.txt_cus_num.Visible = False
        '
        'txt_cus_name
        '
        Me.txt_cus_name.Location = New System.Drawing.Point(633, 20)
        Me.txt_cus_name.Name = "txt_cus_name"
        Me.txt_cus_name.Size = New System.Drawing.Size(209, 25)
        Me.txt_cus_name.TabIndex = 35
        Me.txt_cus_name.Visible = False
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_date.Location = New System.Drawing.Point(1321, 5)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(124, 40)
        Me.lbl_date.TabIndex = 32
        Me.lbl_date.Text = "00.00"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btp_time
        '
        Me.btp_time.Checked = False
        Me.btp_time.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.btp_time.Location = New System.Drawing.Point(409, 37)
        Me.btp_time.Name = "btp_time"
        Me.btp_time.Size = New System.Drawing.Size(131, 25)
        Me.btp_time.TabIndex = 12
        Me.btp_time.Value = New Date(2023, 12, 30, 21, 0, 38, 0)
        '
        'txt_SearchProduct
        '
        Me.txt_SearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SearchProduct.Location = New System.Drawing.Point(150, 77)
        Me.txt_SearchProduct.Name = "txt_SearchProduct"
        Me.txt_SearchProduct.Size = New System.Drawing.Size(621, 25)
        Me.txt_SearchProduct.TabIndex = 11
        '
        'txt_billno
        '
        Me.txt_billno.Location = New System.Drawing.Point(87, 37)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(209, 25)
        Me.txt_billno.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Product/Barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bill date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bill No :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_remove, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_report, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_submit_cash1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btm_new, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_change, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 671)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1448, 70)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_remove.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.ForeColor = System.Drawing.Color.White
        Me.btn_remove.Location = New System.Drawing.Point(827, 3)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(170, 64)
        Me.btn_remove.TabIndex = 17
        Me.btn_remove.Text = "[CLEAR ALL]"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report.ForeColor = System.Drawing.Color.White
        Me.btn_report.Location = New System.Drawing.Point(621, 3)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(170, 64)
        Me.btn_report.TabIndex = 16
        Me.btn_report.Text = "[REPORT]"
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'btn_submit_cash1
        '
        Me.btn_submit_cash1.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_submit_cash1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit_cash1.ForeColor = System.Drawing.Color.White
        Me.btn_submit_cash1.Location = New System.Drawing.Point(415, 3)
        Me.btn_submit_cash1.Name = "btn_submit_cash1"
        Me.btn_submit_cash1.Size = New System.Drawing.Size(170, 64)
        Me.btn_submit_cash1.TabIndex = 15
        Me.btn_submit_cash1.Text = "[SUBMIT THE CASH]"
        Me.btn_submit_cash1.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(209, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(170, 64)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "[View Bills]"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btm_new
        '
        Me.btm_new.BackColor = System.Drawing.Color.RoyalBlue
        Me.btm_new.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btm_new.ForeColor = System.Drawing.Color.White
        Me.btm_new.Location = New System.Drawing.Point(3, 3)
        Me.btm_new.Name = "btm_new"
        Me.btm_new.Size = New System.Drawing.Size(170, 64)
        Me.btm_new.TabIndex = 13
        Me.btm_new.Text = "[NEW]"
        Me.btm_new.UseVisualStyleBackColor = False
        '
        'btn_change
        '
        Me.btn_change.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_change.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change.ForeColor = System.Drawing.Color.White
        Me.btn_change.Location = New System.Drawing.Point(1239, 3)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(170, 64)
        Me.btn_change.TabIndex = 18
        Me.btn_change.Text = "[CHANGE PASSWORD]"
        Me.btn_change.UseVisualStyleBackColor = False
        Me.btn_change.Visible = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Coral
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(1033, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(170, 64)
        Me.btn_logout.TabIndex = 19
        Me.btn_logout.Text = "[LOGOUT]"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txt_sub_total)
        Me.Panel3.Controls.Add(Me.txt_subtotal)
        Me.Panel3.Controls.Add(Me.txt_change)
        Me.Panel3.Controls.Add(Me.cbo_payMode)
        Me.Panel3.Controls.Add(Me.txt_amtrec)
        Me.Panel3.Controls.Add(Me.txt_grandtotal)
        Me.Panel3.Controls.Add(Me.txt_totaltax)
        Me.Panel3.Controls.Add(Me.lbl_discount)
        Me.Panel3.Controls.Add(Me.txt_totalprice)
        Me.Panel3.Controls.Add(Me.txt_no_of_items)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.btn_pay)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txt_discount)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_overallGrandTotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1021, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(427, 476)
        Me.Panel3.TabIndex = 3
        '
        'txt_sub_total
        '
        Me.txt_sub_total.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_sub_total.Location = New System.Drawing.Point(311, 118)
        Me.txt_sub_total.Name = "txt_sub_total"
        Me.txt_sub_total.Size = New System.Drawing.Size(90, 30)
        Me.txt_sub_total.TabIndex = 30
        Me.txt_sub_total.Text = "00.00"
        Me.txt_sub_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_subtotal
        '
        Me.txt_subtotal.AutoSize = True
        Me.txt_subtotal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(72, 120)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_subtotal.Size = New System.Drawing.Size(80, 23)
        Me.txt_subtotal.TabIndex = 29
        Me.txt_subtotal.Text = "Sub Total"
        '
        'txt_change
        '
        Me.txt_change.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_change.Location = New System.Drawing.Point(314, 371)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.Size = New System.Drawing.Size(90, 30)
        Me.txt_change.TabIndex = 28
        Me.txt_change.Text = "00.00"
        Me.txt_change.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbo_payMode
        '
        Me.cbo_payMode.FormattingEnabled = True
        Me.cbo_payMode.Items.AddRange(New Object() {"CASH", "UPI", "CREDIT CARD", "DEBIT CARD"})
        Me.cbo_payMode.Location = New System.Drawing.Point(258, 302)
        Me.cbo_payMode.Name = "cbo_payMode"
        Me.cbo_payMode.Size = New System.Drawing.Size(146, 25)
        Me.cbo_payMode.TabIndex = 27
        '
        'txt_amtrec
        '
        Me.txt_amtrec.Location = New System.Drawing.Point(253, 339)
        Me.txt_amtrec.Name = "txt_amtrec"
        Me.txt_amtrec.Size = New System.Drawing.Size(151, 25)
        Me.txt_amtrec.TabIndex = 13
        '
        'txt_grandtotal
        '
        Me.txt_grandtotal.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grandtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_grandtotal.Location = New System.Drawing.Point(311, 255)
        Me.txt_grandtotal.Name = "txt_grandtotal"
        Me.txt_grandtotal.Size = New System.Drawing.Size(90, 30)
        Me.txt_grandtotal.TabIndex = 26
        Me.txt_grandtotal.Text = "00.00"
        Me.txt_grandtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_totaltax
        '
        Me.txt_totaltax.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totaltax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_totaltax.Location = New System.Drawing.Point(311, 149)
        Me.txt_totaltax.Name = "txt_totaltax"
        Me.txt_totaltax.Size = New System.Drawing.Size(90, 30)
        Me.txt_totaltax.TabIndex = 25
        Me.txt_totaltax.Text = "00.00"
        Me.txt_totaltax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_discount
        '
        Me.lbl_discount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_discount.Location = New System.Drawing.Point(311, 223)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(90, 30)
        Me.lbl_discount.TabIndex = 24
        Me.lbl_discount.Text = "00.00"
        Me.lbl_discount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_totalprice
        '
        Me.txt_totalprice.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_totalprice.Location = New System.Drawing.Point(311, 184)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.Size = New System.Drawing.Size(90, 30)
        Me.txt_totalprice.TabIndex = 23
        Me.txt_totalprice.Text = "00.00"
        Me.txt_totalprice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_no_of_items
        '
        Me.txt_no_of_items.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_of_items.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_no_of_items.Location = New System.Drawing.Point(312, 82)
        Me.txt_no_of_items.Name = "txt_no_of_items"
        Me.txt_no_of_items.Size = New System.Drawing.Size(90, 30)
        Me.txt_no_of_items.TabIndex = 22
        Me.txt_no_of_items.Text = "00.00"
        Me.txt_no_of_items.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 378)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(69, 23)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Change"
        '
        'btn_pay
        '
        Me.btn_pay.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_pay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_pay.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pay.ForeColor = System.Drawing.Color.White
        Me.btn_pay.Location = New System.Drawing.Point(0, 421)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(427, 55)
        Me.btn_pay.TabIndex = 18
        Me.btn_pay.Text = "[F9-PAY]"
        Me.btn_pay.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(71, 364)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(0, 23)
        Me.Label14.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(71, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(146, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Amount Received"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(71, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(98, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Grand Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(128, 23)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Payment Mode"
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(154, 226)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_discount.Size = New System.Drawing.Size(45, 25)
        Me.txt_discount.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(77, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Discount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(72, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Total Tax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(101, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "No of Items"
        '
        'txt_overallGrandTotal
        '
        Me.txt_overallGrandTotal.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_overallGrandTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_overallGrandTotal.Location = New System.Drawing.Point(57, 29)
        Me.txt_overallGrandTotal.Name = "txt_overallGrandTotal"
        Me.txt_overallGrandTotal.Size = New System.Drawing.Size(335, 40)
        Me.txt_overallGrandTotal.TabIndex = 0
        Me.txt_overallGrandTotal.Text = "00.00"
        Me.txt_overallGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column14, Me.Rate, Me.Column10, Me.Column12, Me.btnDeductQty, Me.Column11})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 30
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1021, 476)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 45
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Product Group"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 127
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UOM"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 68
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Price"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 66
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Tax %"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 72
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "GST Price"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 93
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Qty"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 59
        '
        'Column14
        '
        Me.Column14.HeaderText = "MRP"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 125
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.MinimumWidth = 6
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 125
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Total"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 66
        '
        'Column12
        '
        Me.Column12.HeaderText = "Purchase Price"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        Me.Column12.Width = 125
        '
        'btnDeductQty
        '
        Me.btnDeductQty.HeaderText = "Deduct Qty"
        Me.btnDeductQty.MinimumWidth = 6
        Me.btnDeductQty.Name = "btnDeductQty"
        Me.btnDeductQty.ReadOnly = True
        Me.btnDeductQty.Text = "-"
        Me.btnDeductQty.UseColumnTextForButtonValue = True
        Me.btnDeductQty.Width = 50
        '
        'Column11
        '
        Me.Column11.HeaderText = "Remove"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Text = "Remove"
        Me.Column11.UseColumnTextForButtonValue = True
        Me.Column11.Width = 50
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'frm_mainCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1448, 741)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_mainCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sd"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_billno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btp_time As DateTimePicker
    Friend WithEvents txt_SearchProduct As TextBox
    Friend WithEvents btm_new As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_change As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_submit_cash1 As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_overallGrandTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_pay As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_totalprice As Label
    Friend WithEvents txt_no_of_items As Label
    Friend WithEvents txt_change As Label
    Friend WithEvents cbo_payMode As ComboBox
    Friend WithEvents txt_amtrec As TextBox
    Friend WithEvents txt_grandtotal As Label
    Friend WithEvents txt_totaltax As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt_subtotal As Label
    Friend WithEvents txt_sub_total As Label
    Friend WithEvents lbl_loginUser As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_cus_name As TextBox
    Friend WithEvents txt_cus_num As TextBox
    Friend WithEvents qtyUpdate As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents btnDeductQty As DataGridViewButtonColumn
    Friend WithEvents Column11 As DataGridViewButtonColumn
End Class
