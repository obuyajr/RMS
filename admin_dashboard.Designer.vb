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
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        USERSToolStripMenuItem = New ToolStripMenuItem()
        ADDUSERSToolStripMenuItem = New ToolStripMenuItem()
        EDITUSERSToolStripMenuItem = New ToolStripMenuItem()
        REPORTSToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        Panel1 = New Panel()
        btn_logout = New Button()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(596, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 23)
        Button1.TabIndex = 0
        Button1.Text = "LOGOUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, USERSToolStripMenuItem, REPORTSToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(61, 20)
        ToolStripMenuItem1.Text = "ROOMS"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(143, 22)
        ToolStripMenuItem2.Text = "ADD ROOMS"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(143, 22)
        ToolStripMenuItem3.Text = "EDIT ROOMS"
        ' 
        ' USERSToolStripMenuItem
        ' 
        USERSToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ADDUSERSToolStripMenuItem, EDITUSERSToolStripMenuItem})
        USERSToolStripMenuItem.Name = "USERSToolStripMenuItem"
        USERSToolStripMenuItem.Size = New Size(52, 20)
        USERSToolStripMenuItem.Text = "USERS"
        ' 
        ' ADDUSERSToolStripMenuItem
        ' 
        ADDUSERSToolStripMenuItem.Name = "ADDUSERSToolStripMenuItem"
        ADDUSERSToolStripMenuItem.Size = New Size(180, 22)
        ADDUSERSToolStripMenuItem.Text = "ADD USERS"
        ' 
        ' EDITUSERSToolStripMenuItem
        ' 
        EDITUSERSToolStripMenuItem.Name = "EDITUSERSToolStripMenuItem"
        EDITUSERSToolStripMenuItem.Size = New Size(180, 22)
        EDITUSERSToolStripMenuItem.Text = "EDIT USERS"
        ' 
        ' REPORTSToolStripMenuItem
        ' 
        REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        REPORTSToolStripMenuItem.Size = New Size(66, 20)
        REPORTSToolStripMenuItem.Text = "REPORTS"
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
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(80, 17)
        ToolStripStatusLabel1.Text = "Logged in as: "
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(119, 17)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.IndianRed
        Panel1.Controls.Add(btn_logout)
        Panel1.Location = New Point(0, 42)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 100)
        Panel1.TabIndex = 3
        ' 
        ' btn_logout
        ' 
        btn_logout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_logout.Image = My.Resources.Resources.log_out_circle_regular_48
        btn_logout.ImageAlign = ContentAlignment.TopCenter
        btn_logout.Location = New Point(682, 14)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(106, 70)
        btn_logout.TabIndex = 1
        btn_logout.Text = "LOGOUT"
        btn_logout.TextAlign = ContentAlignment.BottomCenter
        btn_logout.UseVisualStyleBackColor = True
        ' 
        ' admin_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "admin_dashboard"
        Text = "admin_dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents USERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ADDUSERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITUSERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_logout As Button
End Class
