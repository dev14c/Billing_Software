<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class countBills
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.rbtn_currentMonth = New System.Windows.Forms.RadioButton()
        Me.rbtn_all = New System.Windows.Forms.RadioButton()
        Me.rbtn_today = New System.Windows.Forms.RadioButton()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_filter)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.rbtn_currentMonth)
        Me.Panel2.Controls.Add(Me.rbtn_all)
        Me.Panel2.Controls.Add(Me.rbtn_today)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 57)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search"
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(909, 16)
        Me.btn_filter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(75, 30)
        Me.btn_filter.TabIndex = 6
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(760, 16)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(131, 22)
        Me.DateTimePicker2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(611, 16)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(131, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'rbtn_currentMonth
        '
        Me.rbtn_currentMonth.AutoSize = True
        Me.rbtn_currentMonth.Location = New System.Drawing.Point(469, 16)
        Me.rbtn_currentMonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtn_currentMonth.Name = "rbtn_currentMonth"
        Me.rbtn_currentMonth.Size = New System.Drawing.Size(109, 20)
        Me.rbtn_currentMonth.TabIndex = 3
        Me.rbtn_currentMonth.TabStop = True
        Me.rbtn_currentMonth.Text = "Current Month"
        Me.rbtn_currentMonth.UseVisualStyleBackColor = True
        '
        'rbtn_all
        '
        Me.rbtn_all.AutoSize = True
        Me.rbtn_all.Location = New System.Drawing.Point(296, 16)
        Me.rbtn_all.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtn_all.Name = "rbtn_all"
        Me.rbtn_all.Size = New System.Drawing.Size(43, 20)
        Me.rbtn_all.TabIndex = 2
        Me.rbtn_all.TabStop = True
        Me.rbtn_all.Text = "All"
        Me.rbtn_all.UseVisualStyleBackColor = True
        '
        'rbtn_today
        '
        Me.rbtn_today.AutoSize = True
        Me.rbtn_today.Location = New System.Drawing.Point(387, 16)
        Me.rbtn_today.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtn_today.Name = "rbtn_today"
        Me.rbtn_today.Size = New System.Drawing.Size(68, 20)
        Me.rbtn_today.TabIndex = 2
        Me.rbtn_today.TabStop = True
        Me.rbtn_today.Text = "Today"
        Me.rbtn_today.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(91, 12)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(199, 22)
        Me.txt_search.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column4, Me.Column7, Me.Column5, Me.Column6})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 57)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(800, 393)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Date"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 65
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Cashier Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Amount"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 81
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Cash Submited from the Cashier"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 146
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Cash Recieved"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 119
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Received"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Text = "Received"
        Me.Column5.UseColumnTextForButtonValue = True
        Me.Column5.Width = 95
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Not received"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Text = "Not received"
        Me.Column6.UseColumnTextForButtonValue = True
        Me.Column6.Width = 104
        '
        'countBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "countBills"
        Me.Text = "countBills"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_filter As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbtn_currentMonth As RadioButton
    Friend WithEvents rbtn_all As RadioButton
    Friend WithEvents rbtn_today As RadioButton
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewButtonColumn
End Class
