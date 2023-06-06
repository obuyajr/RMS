<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_reports
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
        btn_close = New Button()
        btn_generate = New Button()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        lbl_total = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_close
        ' 
        btn_close.Location = New Point(742, 453)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 23)
        btn_close.TabIndex = 15
        btn_close.Text = "CLOSE"
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' btn_generate
        ' 
        btn_generate.BackColor = Color.IndianRed
        btn_generate.Location = New Point(742, 8)
        btn_generate.Name = "btn_generate"
        btn_generate.Size = New Size(104, 40)
        btn_generate.TabIndex = 14
        btn_generate.Text = "GENERATE"
        btn_generate.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(518, 15)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 11
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(279, 15)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(494, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 15)
        Label2.TabIndex = 9
        Label2.Text = "TO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(232, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 8
        Label1.Text = "FROM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 16
        Label3.Text = "USERNAME"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(89, 15)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 54)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1104, 358)
        DataGridView1.TabIndex = 18
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_total.Location = New Point(93, 434)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(117, 45)
        lbl_total.TabIndex = 19
        lbl_total.Text = "TOTAL"
        ' 
        ' Booking_reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1116, 488)
        Controls.Add(lbl_total)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(btn_close)
        Controls.Add(btn_generate)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Booking_reports"
        Text = "Booking_reports"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_close As Button
    Friend WithEvents btn_generate As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_total As Label
End Class
