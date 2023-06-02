<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_Rooms
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        txt_roomNo = New TextBox()
        txt_rates = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        roomType = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.Location = New Point(623, 380)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 41)
        Button1.TabIndex = 0
        Button1.Text = "Book n Print"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(544, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 1
        Label1.Text = "Room no."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(544, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 2
        Label2.Text = "Room Type"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(9, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(429, 426)
        DataGridView1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(553, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 4
        Label3.Text = "Rates"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(617, 215)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 5
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(618, 270)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(516, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 7
        Label4.Text = "Guest Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(505, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 8
        Label5.Text = "Phonenumber"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(533, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 9
        Label6.Text = "Check-In"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(525, 276)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 10
        Label7.Text = "Check-out"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(549, 318)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 25)
        Label8.TabIndex = 11
        Label8.Text = "TOTAL"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuText
        TextBox1.ForeColor = Color.Yellow
        TextBox1.Location = New Point(623, 318)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 12
        ' 
        ' txt_roomNo
        ' 
        txt_roomNo.BackColor = SystemColors.Desktop
        txt_roomNo.ForeColor = SystemColors.MenuHighlight
        txt_roomNo.Location = New Point(617, 12)
        txt_roomNo.Name = "txt_roomNo"
        txt_roomNo.Size = New Size(106, 23)
        txt_roomNo.TabIndex = 13
        ' 
        ' txt_rates
        ' 
        txt_rates.Location = New Point(618, 85)
        txt_rates.Name = "txt_rates"
        txt_rates.Size = New Size(105, 23)
        txt_rates.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(618, 129)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(105, 23)
        TextBox4.TabIndex = 15
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(618, 173)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(105, 23)
        TextBox5.TabIndex = 16
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 470)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(829, 22)
        StatusStrip1.TabIndex = 18
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(0, 17)
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(88, 17)
        ToolStripStatusLabel2.Text = "Loogged in as :"
        ' 
        ' roomType
        ' 
        roomType.Location = New Point(616, 52)
        roomType.Name = "roomType"
        roomType.Size = New Size(100, 23)
        roomType.TabIndex = 19
        ' 
        ' Book_Rooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(829, 492)
        Controls.Add(roomType)
        Controls.Add(StatusStrip1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(txt_rates)
        Controls.Add(txt_roomNo)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Book_Rooms"
        Text = "Book_Rooms"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_roomNo As TextBox
    Friend WithEvents txt_rates As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents roomType As TextBox
End Class
