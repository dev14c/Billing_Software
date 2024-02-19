<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Refreshbutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_manageProduct = New System.Windows.Forms.Button()
        Me.cash_report_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Reports = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_ManageStock = New System.Windows.Forms.Button()
        Me.btn_manageUsers = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.label_noOfUser = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label_nooftodaysale = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelnoofmonthlysale = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.monthprofit = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label_noofProduct = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label_monthlysale = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label_todaysale = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.todayprofit = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Refreshbutton)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1142, 95)
        Me.Panel1.TabIndex = 1
        '
        'Refreshbutton
        '
        Me.Refreshbutton.BackColor = System.Drawing.Color.Blue
        Me.Refreshbutton.ForeColor = System.Drawing.Color.White
        Me.Refreshbutton.Location = New System.Drawing.Point(192, 20)
        Me.Refreshbutton.Name = "Refreshbutton"
        Me.Refreshbutton.Size = New System.Drawing.Size(75, 42)
        Me.Refreshbutton.TabIndex = 4
        Me.Refreshbutton.Text = "Refresh"
        Me.Refreshbutton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inventory System"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageProduct, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cash_report_btn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Reports, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ManageStock, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageUsers, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(436, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(706, 95)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_manageProduct
        '
        Me.btn_manageProduct.FlatAppearance.BorderSize = 0
        Me.btn_manageProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_manageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageProduct.Location = New System.Drawing.Point(3, 3)
        Me.btn_manageProduct.Name = "btn_manageProduct"
        Me.btn_manageProduct.Size = New System.Drawing.Size(94, 76)
        Me.btn_manageProduct.TabIndex = 0
        Me.btn_manageProduct.Text = "Manage Product"
        Me.btn_manageProduct.UseVisualStyleBackColor = True
        '
        'cash_report_btn
        '
        Me.cash_report_btn.FlatAppearance.BorderSize = 0
        Me.cash_report_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cash_report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cash_report_btn.ForeColor = System.Drawing.Color.White
        Me.cash_report_btn.Location = New System.Drawing.Point(103, 3)
        Me.cash_report_btn.Name = "cash_report_btn"
        Me.cash_report_btn.Size = New System.Drawing.Size(94, 76)
        Me.cash_report_btn.TabIndex = 5
        Me.cash_report_btn.Text = "Cash Reports"
        Me.cash_report_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(503, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 76)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "View Bills"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_Reports
        '
        Me.btn_Reports.FlatAppearance.BorderSize = 0
        Me.btn_Reports.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reports.Location = New System.Drawing.Point(403, 3)
        Me.btn_Reports.Name = "btn_Reports"
        Me.btn_Reports.Size = New System.Drawing.Size(94, 76)
        Me.btn_Reports.TabIndex = 3
        Me.btn_Reports.Text = "Reports"
        Me.btn_Reports.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Location = New System.Drawing.Point(603, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(94, 76)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_ManageStock
        '
        Me.btn_ManageStock.FlatAppearance.BorderSize = 0
        Me.btn_ManageStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_ManageStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ManageStock.Location = New System.Drawing.Point(303, 3)
        Me.btn_ManageStock.Name = "btn_ManageStock"
        Me.btn_ManageStock.Size = New System.Drawing.Size(94, 68)
        Me.btn_ManageStock.TabIndex = 1
        Me.btn_ManageStock.Text = "Manage Stock"
        Me.btn_ManageStock.UseVisualStyleBackColor = True
        '
        'btn_manageUsers
        '
        Me.btn_manageUsers.FlatAppearance.BorderSize = 0
        Me.btn_manageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_manageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageUsers.Location = New System.Drawing.Point(203, 3)
        Me.btn_manageUsers.Name = "btn_manageUsers"
        Me.btn_manageUsers.Size = New System.Drawing.Size(94, 76)
        Me.btn_manageUsers.TabIndex = 2
        Me.btn_manageUsers.Text = "Manage Users"
        Me.btn_manageUsers.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 595)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1142, 53)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(4, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1138, 380)
        Me.Panel3.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel11, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel9, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel8, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel13, 4, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 228)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1138, 100)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.label_noOfUser)
        Me.Panel11.Location = New System.Drawing.Point(570, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(179, 94)
        Me.Panel11.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 23)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "No of users"
        '
        'label_noOfUser
        '
        Me.label_noOfUser.AutoSize = True
        Me.label_noOfUser.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_noOfUser.Location = New System.Drawing.Point(27, 21)
        Me.label_noOfUser.Name = "label_noOfUser"
        Me.label_noOfUser.Size = New System.Drawing.Size(29, 35)
        Me.label_noOfUser.TabIndex = 0
        Me.label_noOfUser.Text = "0"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.label_nooftodaysale)
        Me.Panel9.Location = New System.Drawing.Point(192, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(179, 94)
        Me.Panel9.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "No of Today Sales"
        '
        'label_nooftodaysale
        '
        Me.label_nooftodaysale.AutoSize = True
        Me.label_nooftodaysale.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nooftodaysale.Location = New System.Drawing.Point(27, 21)
        Me.label_nooftodaysale.Name = "label_nooftodaysale"
        Me.label_nooftodaysale.Size = New System.Drawing.Size(64, 35)
        Me.label_nooftodaysale.TabIndex = 0
        Me.label_nooftodaysale.Text = "0.00"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.labelnoofmonthlysale)
        Me.Panel8.Location = New System.Drawing.Point(381, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(179, 94)
        Me.Panel8.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "No of Monthly sales"
        '
        'labelnoofmonthlysale
        '
        Me.labelnoofmonthlysale.AutoSize = True
        Me.labelnoofmonthlysale.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnoofmonthlysale.Location = New System.Drawing.Point(27, 21)
        Me.labelnoofmonthlysale.Name = "labelnoofmonthlysale"
        Me.labelnoofmonthlysale.Size = New System.Drawing.Size(64, 35)
        Me.labelnoofmonthlysale.TabIndex = 0
        Me.labelnoofmonthlysale.Text = "0.00"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label8)
        Me.Panel13.Controls.Add(Me.monthprofit)
        Me.Panel13.Location = New System.Drawing.Point(759, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(179, 94)
        Me.Panel13.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Month's Profit"
        '
        'monthprofit
        '
        Me.monthprofit.AutoSize = True
        Me.monthprofit.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthprofit.Location = New System.Drawing.Point(27, 21)
        Me.monthprofit.Name = "monthprofit"
        Me.monthprofit.Size = New System.Drawing.Size(64, 35)
        Me.monthprofit.TabIndex = 0
        Me.monthprofit.Text = "0.00"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 171)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1138, 57)
        Me.Panel5.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel10, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel12, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 62)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1138, 109)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Controls.Add(Me.label_noofProduct)
        Me.Panel10.Location = New System.Drawing.Point(570, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(179, 103)
        Me.Panel10.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 23)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "No of Product"
        '
        'label_noofProduct
        '
        Me.label_noofProduct.AutoSize = True
        Me.label_noofProduct.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_noofProduct.Location = New System.Drawing.Point(27, 21)
        Me.label_noofProduct.Name = "label_noofProduct"
        Me.label_noofProduct.Size = New System.Drawing.Size(29, 35)
        Me.label_noofProduct.TabIndex = 0
        Me.label_noofProduct.Text = "0"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.label_monthlysale)
        Me.Panel7.Location = New System.Drawing.Point(381, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(179, 103)
        Me.Panel7.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Monthly Sales"
        '
        'label_monthlysale
        '
        Me.label_monthlysale.AutoSize = True
        Me.label_monthlysale.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_monthlysale.Location = New System.Drawing.Point(27, 21)
        Me.label_monthlysale.Name = "label_monthlysale"
        Me.label_monthlysale.Size = New System.Drawing.Size(64, 35)
        Me.label_monthlysale.TabIndex = 0
        Me.label_monthlysale.Text = "0.00"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.label_todaysale)
        Me.Panel6.Location = New System.Drawing.Point(192, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(179, 103)
        Me.Panel6.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Today Sales"
        '
        'label_todaysale
        '
        Me.label_todaysale.AutoSize = True
        Me.label_todaysale.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_todaysale.Location = New System.Drawing.Point(27, 21)
        Me.label_todaysale.Name = "label_todaysale"
        Me.label_todaysale.Size = New System.Drawing.Size(64, 35)
        Me.label_todaysale.TabIndex = 0
        Me.label_todaysale.Text = "0.00"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Controls.Add(Me.todayprofit)
        Me.Panel12.Location = New System.Drawing.Point(759, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(179, 103)
        Me.Panel12.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Today's Profit"
        '
        'todayprofit
        '
        Me.todayprofit.AutoSize = True
        Me.todayprofit.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todayprofit.Location = New System.Drawing.Point(27, 21)
        Me.todayprofit.Name = "todayprofit"
        Me.todayprofit.Size = New System.Drawing.Size(64, 35)
        Me.todayprofit.TabIndex = 0
        Me.todayprofit.Text = "0.00"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1138, 62)
        Me.Panel4.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_mainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1142, 648)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_mainAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pos And Inventory"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_Reports As Button
    Friend WithEvents btn_manageUsers As Button
    Friend WithEvents btn_manageProduct As Button
    Friend WithEvents btn_ManageStock As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents label_todaysale As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents labelnoofmonthlysale As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents label_monthlysale As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents label_noOfUser As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents label_nooftodaysale As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents cash_report_btn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Refreshbutton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents label_noofProduct As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents todayprofit As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents monthprofit As Label
End Class
