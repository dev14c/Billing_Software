<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Btn_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Location = New System.Drawing.Point(291, 85)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(198, 20)
        Me.txt_username.TabIndex = 0
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Location = New System.Drawing.Point(291, 147)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(198, 20)
        Me.txt_password.TabIndex = 1
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(291, 193)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(198, 35)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Btn_exit
        '
        Me.Btn_exit.BackColor = System.Drawing.Color.Red
        Me.Btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_exit.ForeColor = System.Drawing.Color.White
        Me.Btn_exit.Location = New System.Drawing.Point(291, 234)
        Me.Btn_exit.Name = "Btn_exit"
        Me.Btn_exit.Size = New System.Drawing.Size(198, 35)
        Me.Btn_exit.TabIndex = 3
        Me.Btn_exit.Text = "EXIT"
        Me.Btn_exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Here !"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Billing_Software.My.Resources.Resources.kisspng_login_google_account_computer_icons_user_activity_5ac6bbe74aa7f1_6157264215229736713058
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(68, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 174)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents Btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
