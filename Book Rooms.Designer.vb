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
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        roomType = New TextBox()
        txt_roomStatus = New TextBox()
        Label9 = New Label()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        Button1 = New Button()
        Panel3 = New Panel()
        Panel2 = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_book
        ' 
        btn_book.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_book.BackColor = Color.GhostWhite
        btn_book.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_book.Image = My.Resources.Resources.printer_solid_24
        btn_book.ImageAlign = ContentAlignment.MiddleLeft
        btn_book.Location = New Point(275, 15)
        btn_book.Name = "btn_book"
        btn_book.Size = New Size(177, 58)
        btn_book.TabIndex = 0
        btn_book.Text = "Book n Print"
        btn_book.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label1.Location = New Point(845, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 1
        Label1.Text = "Room no."
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label2.Location = New Point(78, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 2
        Label2.Text = "Room Type"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(10, 14)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(564, 553)
        DataGridView1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label3.Location = New Point(109, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 4
        Label3.Text = "Rates"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' checkin_date
        ' 
        checkin_date.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        checkin_date.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        checkin_date.Location = New Point(171, 271)
        checkin_date.Name = "checkin_date"
        checkin_date.Size = New Size(230, 25)
        checkin_date.TabIndex = 5
        ' 
        ' checkout_date
        ' 
        checkout_date.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        checkout_date.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        checkout_date.Location = New Point(171, 302)
        checkout_date.Name = "checkout_date"
        checkout_date.Size = New Size(228, 25)
        checkout_date.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label4.Location = New Point(71, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 7
        Label4.Text = "Guest Name"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label5.Location = New Point(61, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 15)
        Label5.TabIndex = 8
        Label5.Text = "Phonenumber"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label6.Location = New Point(91, 281)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 9
        Label6.Text = "Check-In"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label7.Location = New Point(83, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 15)
        Label7.TabIndex = 10
        Label7.Text = "Check-out"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(275, 404)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 25)
        Label8.TabIndex = 11
        Label8.Text = "TOTAL"
        ' 
        ' txt_total
        ' 
        txt_total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_total.BackColor = SystemColors.MenuText
        txt_total.CharacterCasing = CharacterCasing.Upper
        txt_total.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_total.ForeColor = Color.Yellow
        txt_total.Location = New Point(349, 391)
        txt_total.Name = "txt_total"
        txt_total.Size = New Size(114, 44)
        txt_total.TabIndex = 12
        txt_total.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_roomNo
        ' 
        txt_roomNo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_roomNo.BackColor = SystemColors.Desktop
        txt_roomNo.CharacterCasing = CharacterCasing.Upper
        txt_roomNo.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_roomNo.ForeColor = Color.Yellow
        txt_roomNo.Location = New Point(926, 27)
        txt_roomNo.Name = "txt_roomNo"
        txt_roomNo.Size = New Size(94, 29)
        txt_roomNo.TabIndex = 13
        ' 
        ' txt_rates
        ' 
        txt_rates.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_rates.CharacterCasing = CharacterCasing.Upper
        txt_rates.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rates.Location = New Point(927, 119)
        txt_rates.Name = "txt_rates"
        txt_rates.Size = New Size(228, 29)
        txt_rates.TabIndex = 14
        ' 
        ' txt_guestName
        ' 
        txt_guestName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_guestName.CharacterCasing = CharacterCasing.Upper
        txt_guestName.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_guestName.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        txt_guestName.Location = New Point(927, 205)
        txt_guestName.Name = "txt_guestName"
        txt_guestName.Size = New Size(228, 29)
        txt_guestName.TabIndex = 15
        ' 
        ' txt_phoneNo
        ' 
        txt_phoneNo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_phoneNo.CharacterCasing = CharacterCasing.Upper
        txt_phoneNo.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_phoneNo.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        txt_phoneNo.Location = New Point(927, 243)
        txt_phoneNo.Name = "txt_phoneNo"
        txt_phoneNo.Size = New Size(228, 29)
        txt_phoneNo.TabIndex = 16
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3})
        StatusStrip1.Location = New Point(0, 583)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 16, 0)
        StatusStrip1.Size = New Size(1367, 22)
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
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(119, 17)
        ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        ' 
        ' roomType
        ' 
        roomType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        roomType.CharacterCasing = CharacterCasing.Upper
        roomType.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        roomType.Location = New Point(927, 73)
        roomType.Name = "roomType"
        roomType.Size = New Size(228, 29)
        roomType.TabIndex = 19
        ' 
        ' txt_roomStatus
        ' 
        txt_roomStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_roomStatus.CharacterCasing = CharacterCasing.Upper
        txt_roomStatus.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_roomStatus.Location = New Point(927, 160)
        txt_roomStatus.Name = "txt_roomStatus"
        txt_roomStatus.Size = New Size(228, 29)
        txt_roomStatus.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label9.Location = New Point(69, 153)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 15)
        Label9.TabIndex = 21
        Label9.Text = "Room Status"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txt_total)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(checkin_date)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(checkout_date)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(757, 14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(501, 453)
        Panel1.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Brown
        Button1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.calculator_solid_24
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(47, 391)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 42)
        Button1.TabIndex = 25
        Button1.Text = "CALCULATE"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(408, 271)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(31, 25)
        Panel3.TabIndex = 24
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_book)
        Panel2.ForeColor = Color.Teal
        Panel2.Location = New Point(757, 473)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(501, 92)
        Panel2.TabIndex = 23
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' Book_Rooms
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(1367, 605)
        Controls.Add(txt_roomStatus)
        Controls.Add(roomType)
        Controls.Add(StatusStrip1)
        Controls.Add(txt_phoneNo)
        Controls.Add(txt_guestName)
        Controls.Add(txt_rates)
        Controls.Add(txt_roomNo)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.Black
        MaximizeBox = False
        Name = "Book_Rooms"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BOOK ROOMS"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Button1 As Button
End Class
