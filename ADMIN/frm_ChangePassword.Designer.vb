<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePassword
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.chnage_password = New System.Windows.Forms.Button()
        Me.txt_oldpassword = New System.Windows.Forms.Label()
        Me.txt_newpassword = New System.Windows.Forms.Label()
        Me.txt_reenterpassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBox1.Location = New System.Drawing.Point(79, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBox2.Location = New System.Drawing.Point(79, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 22)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'TextBox3
        '
        Me.TextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBox3.Location = New System.Drawing.Point(79, 193)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(212, 22)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.UseSystemPasswordChar = True
        '
        'chnage_password
        '
        Me.chnage_password.BackColor = System.Drawing.SystemColors.HotTrack
        Me.chnage_password.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chnage_password.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chnage_password.Location = New System.Drawing.Point(79, 234)
        Me.chnage_password.Name = "chnage_password"
        Me.chnage_password.Size = New System.Drawing.Size(220, 35)
        Me.chnage_password.TabIndex = 3
        Me.chnage_password.Text = "Change_Password"
        Me.chnage_password.UseVisualStyleBackColor = False
        '
        'txt_oldpassword
        '
        Me.txt_oldpassword.AutoSize = True
        Me.txt_oldpassword.Location = New System.Drawing.Point(76, 43)
        Me.txt_oldpassword.Name = "txt_oldpassword"
        Me.txt_oldpassword.Size = New System.Drawing.Size(154, 16)
        Me.txt_oldpassword.TabIndex = 4
        Me.txt_oldpassword.Text = "Enter your Old Password"
        '
        'txt_newpassword
        '
        Me.txt_newpassword.AutoSize = True
        Me.txt_newpassword.Location = New System.Drawing.Point(76, 101)
        Me.txt_newpassword.Name = "txt_newpassword"
        Me.txt_newpassword.Size = New System.Drawing.Size(160, 16)
        Me.txt_newpassword.TabIndex = 5
        Me.txt_newpassword.Text = "Enter your New Password"
        '
        'txt_reenterpassword
        '
        Me.txt_reenterpassword.AutoSize = True
        Me.txt_reenterpassword.Location = New System.Drawing.Point(76, 165)
        Me.txt_reenterpassword.Name = "txt_reenterpassword"
        Me.txt_reenterpassword.Size = New System.Drawing.Size(182, 16)
        Me.txt_reenterpassword.TabIndex = 6
        Me.txt_reenterpassword.Text = "Re-Enter your New Password"
        '
        'frm_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 299)
        Me.Controls.Add(Me.txt_reenterpassword)
        Me.Controls.Add(Me.txt_newpassword)
        Me.Controls.Add(Me.txt_oldpassword)
        Me.Controls.Add(Me.chnage_password)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frm_ChangePassword"
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents chnage_password As Button
    Friend WithEvents txt_oldpassword As Label
    Friend WithEvents txt_newpassword As Label
    Friend WithEvents txt_reenterpassword As Label
End Class
