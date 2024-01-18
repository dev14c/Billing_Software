<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_admin_bill
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
        Me.txt_billdate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_mod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cusmob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.txt_billno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cashier = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_billdate
        '
        Me.txt_billdate.Location = New System.Drawing.Point(158, 57)
        Me.txt_billdate.Name = "txt_billdate"
        Me.txt_billdate.Size = New System.Drawing.Size(129, 22)
        Me.txt_billdate.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Date"
        '
        'txt_mod
        '
        Me.txt_mod.Location = New System.Drawing.Point(158, 177)
        Me.txt_mod.Name = "txt_mod"
        Me.txt_mod.Size = New System.Drawing.Size(129, 22)
        Me.txt_mod.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Mode Of Payment"
        '
        'txt_cusmob
        '
        Me.txt_cusmob.Location = New System.Drawing.Point(158, 123)
        Me.txt_cusmob.Name = "txt_cusmob"
        Me.txt_cusmob.Size = New System.Drawing.Size(129, 22)
        Me.txt_cusmob.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Customer Mobile"
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(158, 84)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(129, 22)
        Me.txt_cusname.TabIndex = 17
        '
        'txt_billno
        '
        Me.txt_billno.Location = New System.Drawing.Point(158, 29)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(129, 22)
        Me.txt_billno.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bill no"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(149, 235)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(339, 100)
        Me.ListBox1.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Product &&Qty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Product &&Price"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(149, 348)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(339, 100)
        Me.ListBox2.TabIndex = 29
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(160, 484)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(127, 22)
        Me.txt_total.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Total"
        '
        'txt_cashier
        '
        Me.txt_cashier.Location = New System.Drawing.Point(160, 542)
        Me.txt_cashier.Name = "txt_cashier"
        Me.txt_cashier.Size = New System.Drawing.Size(127, 22)
        Me.txt_cashier.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 542)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Cashier Name"
        '
        'view_admin_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 640)
        Me.Controls.Add(Me.txt_cashier)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txt_billdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_mod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cusmob)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cusname)
        Me.Controls.Add(Me.txt_billno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "view_admin_bill"
        Me.Text = "view_admin_bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_billdate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_mod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cusmob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents txt_billno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cashier As TextBox
    Friend WithEvents Label9 As Label
End Class
