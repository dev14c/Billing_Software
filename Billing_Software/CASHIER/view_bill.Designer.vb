<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_bill
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_billno = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.txt_cusmob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_billdate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill no"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'txt_billno
        '
        Me.txt_billno.Location = New System.Drawing.Point(212, 51)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(100, 22)
        Me.txt_billno.TabIndex = 2
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(212, 106)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(100, 22)
        Me.txt_cusname.TabIndex = 3
        '
        'txt_cusmob
        '
        Me.txt_cusmob.Location = New System.Drawing.Point(212, 148)
        Me.txt_cusmob.Name = "txt_cusmob"
        Me.txt_cusmob.Size = New System.Drawing.Size(100, 22)
        Me.txt_cusmob.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer Mobile"
        '
        'txt_mod
        '
        Me.txt_mod.Location = New System.Drawing.Point(222, 202)
        Me.txt_mod.Name = "txt_mod"
        Me.txt_mod.Size = New System.Drawing.Size(100, 22)
        Me.txt_mod.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mode Of Payment"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(213, 250)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 22)
        Me.txt_total.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total"
        '
        'txt_billdate
        '
        Me.txt_billdate.Location = New System.Drawing.Point(212, 79)
        Me.txt_billdate.Name = "txt_billdate"
        Me.txt_billdate.Size = New System.Drawing.Size(100, 22)
        Me.txt_billdate.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date"
        '
        'view_bill
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
        Me.Name = "view_bill"
        Me.Text = "view_bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_billno As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents txt_cusmob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_mod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_billdate As TextBox
    Friend WithEvents Label5 As Label
End Class
