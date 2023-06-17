<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_dashbord
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
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button9 = New Button()
        TabPage2 = New TabPage()
        Button8 = New Button()
        btn_checkOut = New Button()
        btn_bookRoom = New Button()
        TabPage3 = New TabPage()
        btn_editUser = New Button()
        btn_addUser = New Button()
        btn_editRoom = New Button()
        btn_addRoom = New Button()
        TabPage4 = New TabPage()
        btn_checkOutReports = New Button()
        btn_bookReports = New Button()
        TabPage5 = New TabPage()
        Button1 = New Button()
        StatusStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.White
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3})
        StatusStrip1.Location = New Point(0, 432)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(77, 17)
        ToolStripStatusLabel1.Text = "Logged in as:"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(119, 17)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(119, 17)
        ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        ' 
        ' Timer1
        ' 
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(0, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(15, 8)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 153)
        TabControl1.TabIndex = 6
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.BorderStyle = BorderStyle.FixedSingle
        TabPage1.Controls.Add(Button9)
        TabPage1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 36)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 113)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Application"
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button9.Image = My.Resources.Resources.log_out_circle_regular_48
        Button9.ImageAlign = ContentAlignment.BottomCenter
        Button9.Location = New Point(19, 20)
        Button9.Name = "Button9"
        Button9.Size = New Size(69, 72)
        Button9.TabIndex = 5
        Button9.Text = "Log Out"
        Button9.TextAlign = ContentAlignment.TopCenter
        Button9.UseVisualStyleBackColor = False
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.White
        TabPage2.BorderStyle = BorderStyle.FixedSingle
        TabPage2.Controls.Add(Button8)
        TabPage2.Controls.Add(btn_checkOut)
        TabPage2.Controls.Add(btn_bookRoom)
        TabPage2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage2.Location = New Point(4, 36)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(792, 113)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Front Office"
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button8.Image = My.Resources.Resources.edit_alt_regular_24
        Button8.ImageAlign = ContentAlignment.BottomCenter
        Button8.Location = New Point(505, 20)
        Button8.Name = "Button8"
        Button8.Size = New Size(76, 72)
        Button8.TabIndex = 6
        Button8.Text = "Room Availability"
        Button8.TextAlign = ContentAlignment.TopCenter
        Button8.UseVisualStyleBackColor = False
        ' 
        ' btn_checkOut
        ' 
        btn_checkOut.BackColor = Color.Transparent
        btn_checkOut.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_checkOut.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_checkOut.Image = My.Resources.Resources.check_double_regular_241
        btn_checkOut.ImageAlign = ContentAlignment.BottomCenter
        btn_checkOut.Location = New Point(150, 20)
        btn_checkOut.Name = "btn_checkOut"
        btn_checkOut.Size = New Size(58, 72)
        btn_checkOut.TabIndex = 5
        btn_checkOut.Text = "Check Out"
        btn_checkOut.TextAlign = ContentAlignment.TopCenter
        btn_checkOut.UseVisualStyleBackColor = False
        ' 
        ' btn_bookRoom
        ' 
        btn_bookRoom.BackColor = Color.Transparent
        btn_bookRoom.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_bookRoom.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_bookRoom.Image = My.Resources.Resources.book_open_regular_24___Copy
        btn_bookRoom.ImageAlign = ContentAlignment.BottomCenter
        btn_bookRoom.Location = New Point(31, 20)
        btn_bookRoom.Name = "btn_bookRoom"
        btn_bookRoom.Size = New Size(58, 72)
        btn_bookRoom.TabIndex = 4
        btn_bookRoom.Text = "Book Room" & vbCrLf
        btn_bookRoom.TextAlign = ContentAlignment.TopCenter
        btn_bookRoom.UseVisualStyleBackColor = False
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.BorderStyle = BorderStyle.FixedSingle
        TabPage3.Controls.Add(btn_editUser)
        TabPage3.Controls.Add(btn_addUser)
        TabPage3.Controls.Add(btn_editRoom)
        TabPage3.Controls.Add(btn_addRoom)
        TabPage3.Location = New Point(4, 36)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(792, 113)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Back Office"
        ' 
        ' btn_editUser
        ' 
        btn_editUser.BackColor = Color.Transparent
        btn_editUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_editUser.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_editUser.Image = My.Resources.Resources.edit_alt_regular_24
        btn_editUser.ImageAlign = ContentAlignment.BottomCenter
        btn_editUser.Location = New Point(309, 21)
        btn_editUser.Name = "btn_editUser"
        btn_editUser.Size = New Size(58, 72)
        btn_editUser.TabIndex = 3
        btn_editUser.Text = "Edit User"
        btn_editUser.TextAlign = ContentAlignment.TopCenter
        btn_editUser.UseVisualStyleBackColor = False
        ' 
        ' btn_addUser
        ' 
        btn_addUser.BackColor = Color.Transparent
        btn_addUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_addUser.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_addUser.Image = My.Resources.Resources.user_name
        btn_addUser.ImageAlign = ContentAlignment.BottomCenter
        btn_addUser.Location = New Point(210, 21)
        btn_addUser.Name = "btn_addUser"
        btn_addUser.Size = New Size(52, 72)
        btn_addUser.TabIndex = 2
        btn_addUser.Text = "Add User"
        btn_addUser.TextAlign = ContentAlignment.TopCenter
        btn_addUser.UseVisualStyleBackColor = False
        ' 
        ' btn_editRoom
        ' 
        btn_editRoom.BackColor = Color.Transparent
        btn_editRoom.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_editRoom.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_editRoom.Image = My.Resources.Resources.edit_alt_regular_24
        btn_editRoom.ImageAlign = ContentAlignment.BottomCenter
        btn_editRoom.Location = New Point(113, 21)
        btn_editRoom.Name = "btn_editRoom"
        btn_editRoom.Size = New Size(57, 72)
        btn_editRoom.TabIndex = 1
        btn_editRoom.Text = "Edit Room"
        btn_editRoom.TextAlign = ContentAlignment.TopCenter
        btn_editRoom.UseVisualStyleBackColor = False
        ' 
        ' btn_addRoom
        ' 
        btn_addRoom.BackColor = Color.Transparent
        btn_addRoom.BackgroundImageLayout = ImageLayout.None
        btn_addRoom.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_addRoom.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_addRoom.Image = My.Resources.Resources.folder_plus_solid_241
        btn_addRoom.ImageAlign = ContentAlignment.BottomCenter
        btn_addRoom.Location = New Point(17, 21)
        btn_addRoom.Name = "btn_addRoom"
        btn_addRoom.Size = New Size(60, 72)
        btn_addRoom.TabIndex = 0
        btn_addRoom.Text = "Add Rooms"
        btn_addRoom.TextAlign = ContentAlignment.TopCenter
        btn_addRoom.UseVisualStyleBackColor = False
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.White
        TabPage4.BorderStyle = BorderStyle.FixedSingle
        TabPage4.Controls.Add(btn_checkOutReports)
        TabPage4.Controls.Add(btn_bookReports)
        TabPage4.Location = New Point(4, 36)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(792, 113)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Reports"
        ' 
        ' btn_checkOutReports
        ' 
        btn_checkOutReports.BackColor = Color.Transparent
        btn_checkOutReports.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_checkOutReports.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_checkOutReports.Image = My.Resources.Resources.check_double_regular_241
        btn_checkOutReports.ImageAlign = ContentAlignment.BottomCenter
        btn_checkOutReports.Location = New Point(133, 17)
        btn_checkOutReports.Name = "btn_checkOutReports"
        btn_checkOutReports.Size = New Size(59, 77)
        btn_checkOutReports.TabIndex = 5
        btn_checkOutReports.Text = "Check Out Reports"
        btn_checkOutReports.TextAlign = ContentAlignment.TopCenter
        btn_checkOutReports.UseVisualStyleBackColor = False
        ' 
        ' btn_bookReports
        ' 
        btn_bookReports.BackColor = Color.Transparent
        btn_bookReports.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_bookReports.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btn_bookReports.Image = My.Resources.Resources.book_open_regular_24___Copy
        btn_bookReports.ImageAlign = ContentAlignment.BottomCenter
        btn_bookReports.Location = New Point(33, 17)
        btn_bookReports.Name = "btn_bookReports"
        btn_bookReports.Size = New Size(62, 77)
        btn_bookReports.TabIndex = 4
        btn_bookReports.Text = "Booking reports"
        btn_bookReports.TextAlign = ContentAlignment.TopCenter
        btn_bookReports.UseVisualStyleBackColor = False
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.White
        TabPage5.BorderStyle = BorderStyle.FixedSingle
        TabPage5.Controls.Add(Button1)
        TabPage5.Location = New Point(4, 36)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(792, 113)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Back-Up"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.Image = My.Resources.Resources.check_double_regular_241
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(16, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(52, 67)
        Button1.TabIndex = 6
        Button1.Text = "To Email" & vbCrLf
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' user_dashbord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Tan
        ClientSize = New Size(800, 454)
        Controls.Add(TabControl1)
        Controls.Add(StatusStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "user_dashbord"
        Text = "USER DASHBOARD"
        WindowState = FormWindowState.Maximized
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button8 As Button
    Friend WithEvents btn_checkOut As Button
    Friend WithEvents btn_bookRoom As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_editUser As Button
    Friend WithEvents btn_addUser As Button
    Friend WithEvents btn_editRoom As Button
    Friend WithEvents btn_addRoom As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btn_bookReports As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button9 As Button
    Friend WithEvents btn_checkOutReports As Button
    Friend WithEvents Button1 As Button
End Class
