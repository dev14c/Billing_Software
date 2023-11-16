<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_qty_add
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
        Me.txt_qty_add = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_qty_add
        '
        Me.txt_qty_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_qty_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty_add.Location = New System.Drawing.Point(0, 0)
        Me.txt_qty_add.Multiline = True
        Me.txt_qty_add.Name = "txt_qty_add"
        Me.txt_qty_add.Size = New System.Drawing.Size(216, 56)
        Me.txt_qty_add.TabIndex = 0
        Me.txt_qty_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_qty_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 56)
        Me.Controls.Add(Me.txt_qty_add)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_qty_add"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_qty_add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_qty_add As TextBox
End Class
