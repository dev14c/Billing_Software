<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateStock
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
        Me.txt_procode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.btn_updateStock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Product Code"
        '
        'txt_procode
        '
        Me.txt_procode.Location = New System.Drawing.Point(42, 57)
        Me.txt_procode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_procode.Name = "txt_procode"
        Me.txt_procode.Size = New System.Drawing.Size(185, 20)
        Me.txt_procode.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Qty"
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(42, 112)
        Me.txt_location.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(185, 20)
        Me.txt_location.TabIndex = 16
        '
        'btn_updateStock
        '
        Me.btn_updateStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_updateStock.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_updateStock.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btn_updateStock.Location = New System.Drawing.Point(79, 157)
        Me.btn_updateStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_updateStock.Name = "btn_updateStock"
        Me.btn_updateStock.Size = New System.Drawing.Size(99, 27)
        Me.btn_updateStock.TabIndex = 18
        Me.btn_updateStock.Text = "UPDATE STOCK"
        Me.btn_updateStock.UseVisualStyleBackColor = False
        '
        'frm_updateStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 230)
        Me.Controls.Add(Me.btn_updateStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_procode)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_updateStock"
        Me.Text = "frm_updateStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_procode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_location As TextBox
    Friend WithEvents btn_updateStock As Button
End Class
