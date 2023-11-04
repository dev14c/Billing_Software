<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_Reports = New System.Windows.Forms.Button()
        Me.btn_manageUsers = New System.Windows.Forms.Button()
        Me.btn_manageProduct = New System.Windows.Forms.Button()
        Me.btn_ManageStock = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 74)
        Me.Panel1.TabIndex = 1
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
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.37799!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33493!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Reports, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageUsers, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageProduct, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ManageStock, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(445, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 74)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_logout
        '
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Location = New System.Drawing.Point(381, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(89, 56)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_Reports
        '
        Me.btn_Reports.FlatAppearance.BorderSize = 0
        Me.btn_Reports.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reports.Location = New System.Drawing.Point(285, 3)
        Me.btn_Reports.Name = "btn_Reports"
        Me.btn_Reports.Size = New System.Drawing.Size(89, 56)
        Me.btn_Reports.TabIndex = 3
        Me.btn_Reports.Text = "Reports"
        Me.btn_Reports.UseVisualStyleBackColor = True
        '
        'btn_manageUsers
        '
        Me.btn_manageUsers.FlatAppearance.BorderSize = 0
        Me.btn_manageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageUsers.Location = New System.Drawing.Point(193, 3)
        Me.btn_manageUsers.Name = "btn_manageUsers"
        Me.btn_manageUsers.Size = New System.Drawing.Size(86, 56)
        Me.btn_manageUsers.TabIndex = 2
        Me.btn_manageUsers.Text = "Manage Users"
        Me.btn_manageUsers.UseVisualStyleBackColor = True
        '
        'btn_manageProduct
        '
        Me.btn_manageProduct.FlatAppearance.BorderSize = 0
        Me.btn_manageProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageProduct.Location = New System.Drawing.Point(3, 3)
        Me.btn_manageProduct.Name = "btn_manageProduct"
        Me.btn_manageProduct.Size = New System.Drawing.Size(89, 56)
        Me.btn_manageProduct.TabIndex = 0
        Me.btn_manageProduct.Text = "Manage Product"
        Me.btn_manageProduct.UseVisualStyleBackColor = True
        '
        'btn_ManageStock
        '
        Me.btn_ManageStock.FlatAppearance.BorderSize = 0
        Me.btn_ManageStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_ManageStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ManageStock.Location = New System.Drawing.Point(98, 3)
        Me.btn_ManageStock.Name = "btn_ManageStock"
        Me.btn_ManageStock.Size = New System.Drawing.Size(89, 68)
        Me.btn_ManageStock.TabIndex = 1
        Me.btn_ManageStock.Text = "Manage Stock"
        Me.btn_ManageStock.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 401)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(919, 52)
        Me.Panel2.TabIndex = 2
        '
        'frm_mainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 453)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_mainAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pos And Inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
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
End Class
