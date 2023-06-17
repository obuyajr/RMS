<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        btn_logout = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        TabPage3 = New TabPage()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TabPage4 = New TabPage()
        Button5 = New Button()
        TabPage5 = New TabPage()
        Panel1 = New Panel()
        StatusStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.BackColor = Color.White
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(80, 17)
        ToolStripStatusLabel1.Text = "Logged in as: "
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.BackColor = Color.White
        ToolStripStatusLabel2.ForeColor = Color.Green
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(119, 17)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' btn_logout
        ' 
        btn_logout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_logout.Image = My.Resources.Resources.log_out_circle_regular_48
        btn_logout.ImageAlign = ContentAlignment.BottomCenter
        btn_logout.Location = New Point(21, 22)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(83, 70)
        btn_logout.TabIndex = 1
        btn_logout.Text = "Logout"
        btn_logout.TextAlign = ContentAlignment.TopCenter
        btn_logout.UseVisualStyleBackColor = True
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
        TabControl1.TabIndex = 5
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.BorderStyle = BorderStyle.FixedSingle
        TabPage1.Controls.Add(btn_logout)
        TabPage1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 36)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 113)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Application"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.White
        TabPage2.BorderStyle = BorderStyle.FixedSingle
        TabPage2.Controls.Add(Button8)
        TabPage2.Controls.Add(Button7)
        TabPage2.Controls.Add(Button6)
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
        Button8.Size = New Size(58, 72)
        Button8.TabIndex = 6
        Button8.Text = "Edit User"
        Button8.TextAlign = ContentAlignment.TopCenter
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button7.Image = My.Resources.Resources.check_double_regular_241
        Button7.ImageAlign = ContentAlignment.BottomCenter
        Button7.Location = New Point(150, 20)
        Button7.Name = "Button7"
        Button7.Size = New Size(58, 72)
        Button7.TabIndex = 5
        Button7.Text = "Check Out"
        Button7.TextAlign = ContentAlignment.TopCenter
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button6.Image = My.Resources.Resources.book_open_regular_24___Copy
        Button6.ImageAlign = ContentAlignment.BottomCenter
        Button6.Location = New Point(31, 20)
        Button6.Name = "Button6"
        Button6.Size = New Size(58, 72)
        Button6.TabIndex = 4
        Button6.Text = "Book Rooms"
        Button6.TextAlign = ContentAlignment.TopCenter
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.BorderStyle = BorderStyle.FixedSingle
        TabPage3.Controls.Add(Button4)
        TabPage3.Controls.Add(Button3)
        TabPage3.Controls.Add(Button2)
        TabPage3.Controls.Add(Button1)
        TabPage3.Location = New Point(4, 36)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(792, 113)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Back Office"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.Image = My.Resources.Resources.edit_alt_regular_24
        Button4.ImageAlign = ContentAlignment.BottomCenter
        Button4.Location = New Point(309, 21)
        Button4.Name = "Button4"
        Button4.Size = New Size(58, 72)
        Button4.TabIndex = 3
        Button4.Text = "Edit User"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.Image = My.Resources.Resources.user_name
        Button3.ImageAlign = ContentAlignment.BottomCenter
        Button3.Location = New Point(210, 21)
        Button3.Name = "Button3"
        Button3.Size = New Size(52, 72)
        Button3.TabIndex = 2
        Button3.Text = "Add User"
        Button3.TextAlign = ContentAlignment.TopCenter
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.Image = My.Resources.Resources.edit_alt_regular_24
        Button2.ImageAlign = ContentAlignment.BottomCenter
        Button2.Location = New Point(113, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(57, 72)
        Button2.TabIndex = 1
        Button2.Text = "Edit Room"
        Button2.TextAlign = ContentAlignment.TopCenter
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.Image = My.Resources.Resources.folder_plus_solid_241
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(17, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(60, 72)
        Button1.TabIndex = 0
        Button1.Text = "Add Rooms"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.White
        TabPage4.BorderStyle = BorderStyle.FixedSingle
        TabPage4.Controls.Add(Button5)
        TabPage4.Location = New Point(4, 36)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(792, 113)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Reports"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button5.Image = My.Resources.Resources.book_open_regular_24___Copy
        Button5.ImageAlign = ContentAlignment.BottomCenter
        Button5.Location = New Point(33, 17)
        Button5.Name = "Button5"
        Button5.Size = New Size(62, 72)
        Button5.TabIndex = 4
        Button5.Text = "Booking reports"
        Button5.TextAlign = ContentAlignment.TopCenter
        Button5.UseVisualStyleBackColor = False
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.White
        TabPage5.BorderStyle = BorderStyle.FixedSingle
        TabPage5.Location = New Point(4, 36)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(792, 113)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Back-Up"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Tan
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(4, 157)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(792, 268)
        Panel1.TabIndex = 7
        ' 
        ' admin_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSalmon
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Controls.Add(StatusStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        IsMdiContainer = True
        MdiChildrenMinimizedAnchorBottom = False
        Name = "admin_dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        WindowState = FormWindowState.Maximized
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents btn_logout As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
End Class
