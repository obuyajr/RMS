﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        components = New ComponentModel.Container()
        btn_book = New Button()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        checkin_date = New DateTimePicker()
        checkout_date = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txt_total = New TextBox()
        txt_roomNo = New TextBox()
        txt_rates = New TextBox()
        txt_guestName = New TextBox()
        txt_phoneNo = New TextBox()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        roomType = New TextBox()
        txt_roomStatus = New TextBox()
        Label9 = New Label()
        Timer1 = New Timer(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_book
        ' 
        btn_book.BackColor = Color.Crimson
        btn_book.Location = New Point(638, 441)
        btn_book.Name = "btn_book"
        btn_book.Size = New Size(118, 41)
        btn_book.TabIndex = 0
        btn_book.Text = "Book n Print"
        btn_book.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(544, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 1
        Label1.Text = "Room no."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(537, 76)
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
        Label3.Location = New Point(553, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 4
        Label3.Text = "Rates"
        ' 
        ' checkin_date
        ' 
        checkin_date.Location = New Point(616, 268)
        checkin_date.Name = "checkin_date"
        checkin_date.Size = New Size(200, 23)
        checkin_date.TabIndex = 5
        ' 
        ' checkout_date
        ' 
        checkout_date.Location = New Point(618, 307)
        checkout_date.Name = "checkout_date"
        checkout_date.Size = New Size(200, 23)
        checkout_date.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(516, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 7
        Label4.Text = "Guest Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(505, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 8
        Label5.Text = "Phonenumber"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(533, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 9
        Label6.Text = "Check-In"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(525, 313)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 10
        Label7.Text = "Check-out"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(587, 387)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 25)
        Label8.TabIndex = 11
        Label8.Text = "TOTAL"
        ' 
        ' txt_total
        ' 
        txt_total.BackColor = SystemColors.MenuText
        txt_total.ForeColor = Color.Yellow
        txt_total.Location = New Point(686, 387)
        txt_total.Name = "txt_total"
        txt_total.Size = New Size(100, 23)
        txt_total.TabIndex = 12
        ' 
        ' txt_roomNo
        ' 
        txt_roomNo.BackColor = SystemColors.Desktop
        txt_roomNo.ForeColor = SystemColors.MenuHighlight
        txt_roomNo.Location = New Point(615, 33)
        txt_roomNo.Name = "txt_roomNo"
        txt_roomNo.Size = New Size(201, 23)
        txt_roomNo.TabIndex = 13
        ' 
        ' txt_rates
        ' 
        txt_rates.Location = New Point(616, 114)
        txt_rates.Name = "txt_rates"
        txt_rates.Size = New Size(140, 23)
        txt_rates.TabIndex = 14
        ' 
        ' txt_guestName
        ' 
        txt_guestName.Location = New Point(616, 190)
        txt_guestName.Name = "txt_guestName"
        txt_guestName.Size = New Size(200, 23)
        txt_guestName.TabIndex = 15
        ' 
        ' txt_phoneNo
        ' 
        txt_phoneNo.Location = New Point(616, 223)
        txt_phoneNo.Name = "txt_phoneNo"
        txt_phoneNo.Size = New Size(140, 23)
        txt_phoneNo.TabIndex = 16
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 512)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(878, 22)
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
        roomType.Location = New Point(616, 73)
        roomType.Name = "roomType"
        roomType.Size = New Size(202, 23)
        roomType.TabIndex = 19
        ' 
        ' txt_roomStatus
        ' 
        txt_roomStatus.Location = New Point(616, 150)
        txt_roomStatus.Name = "txt_roomStatus"
        txt_roomStatus.Size = New Size(140, 23)
        txt_roomStatus.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(514, 158)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 15)
        Label9.TabIndex = 21
        Label9.Text = "Room Status"
        ' 
        ' Timer1
        ' 
        ' 
        ' Book_Rooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(878, 534)
        Controls.Add(Label9)
        Controls.Add(txt_roomStatus)
        Controls.Add(roomType)
        Controls.Add(StatusStrip1)
        Controls.Add(txt_phoneNo)
        Controls.Add(txt_guestName)
        Controls.Add(txt_rates)
        Controls.Add(txt_roomNo)
        Controls.Add(txt_total)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(checkout_date)
        Controls.Add(checkin_date)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_book)
        Name = "Book_Rooms"
        Text = "Book_Rooms"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_book As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents checkin_date As DateTimePicker
    Friend WithEvents checkout_date As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_roomNo As TextBox
    Friend WithEvents txt_rates As TextBox
    Friend WithEvents txt_guestName As TextBox
    Friend WithEvents txt_phoneNo As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents roomType As TextBox
    Friend WithEvents txt_roomStatus As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
End Class
