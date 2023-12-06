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
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_mod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cusmob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.txt_billno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_billdate
        '
        Me.txt_billdate.Location = New System.Drawing.Point(400, 143)
        Me.txt_billdate.Name = "txt_billdate"
        Me.txt_billdate.Size = New System.Drawing.Size(100, 22)
        Me.txt_billdate.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Date"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(401, 314)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 22)
        Me.txt_total.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(298, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Total"
        '
        'txt_mod
        '
        Me.txt_mod.Location = New System.Drawing.Point(410, 266)
        Me.txt_mod.Name = "txt_mod"
        Me.txt_mod.Size = New System.Drawing.Size(100, 22)
        Me.txt_mod.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Mode Of Payment"
        '
        'txt_cusmob
        '
        Me.txt_cusmob.Location = New System.Drawing.Point(400, 212)
        Me.txt_cusmob.Name = "txt_cusmob"
        Me.txt_cusmob.Size = New System.Drawing.Size(100, 22)
        Me.txt_cusmob.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Customer Mobile"
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(400, 170)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(100, 22)
        Me.txt_cusname.TabIndex = 17
        '
        'txt_billno
        '
        Me.txt_billno.Location = New System.Drawing.Point(400, 115)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(100, 22)
        Me.txt_billno.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bill no"
        '
        'view_admin_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_billdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label6)
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
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_mod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cusmob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents txt_billno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
