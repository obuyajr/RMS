﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        btn_logout = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        Panel1 = New Panel()
        btn_checkout = New Button()
        btn_bookRoom = New Button()
        Timer1 = New Timer(components)
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_logout
        ' 
        btn_logout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_logout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_logout.Image = My.Resources.Resources.log_out_circle_regular_48
        btn_logout.ImageAlign = ContentAlignment.TopCenter
        btn_logout.Location = New Point(690, 19)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(71, 70)
        btn_logout.TabIndex = 0
        btn_logout.Text = "LOGOUT"
        btn_logout.TextAlign = ContentAlignment.BottomCenter
        btn_logout.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
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
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.IndianRed
        Panel1.Controls.Add(btn_checkout)
        Panel1.Controls.Add(btn_bookRoom)
        Panel1.Controls.Add(btn_logout)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 110)
        Panel1.TabIndex = 2
        ' 
        ' btn_checkout
        ' 
        btn_checkout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_checkout.Image = My.Resources.Resources.log_out_regular_48
        btn_checkout.ImageAlign = ContentAlignment.TopCenter
        btn_checkout.Location = New Point(151, 19)
        btn_checkout.Name = "btn_checkout"
        btn_checkout.Size = New Size(78, 70)
        btn_checkout.TabIndex = 1
        btn_checkout.Text = "Check Out"
        btn_checkout.TextAlign = ContentAlignment.BottomCenter
        btn_checkout.UseVisualStyleBackColor = True
        ' 
        ' btn_bookRoom
        ' 
        btn_bookRoom.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_bookRoom.Image = My.Resources.Resources.book_regular_48
        btn_bookRoom.ImageAlign = ContentAlignment.TopCenter
        btn_bookRoom.Location = New Point(14, 19)
        btn_bookRoom.Name = "btn_bookRoom"
        btn_bookRoom.Size = New Size(80, 70)
        btn_bookRoom.TabIndex = 0
        btn_bookRoom.Text = "Book Room"
        btn_bookRoom.TextAlign = ContentAlignment.BottomCenter
        btn_bookRoom.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' user_dashbord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowFrame
        ClientSize = New Size(800, 454)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "user_dashbord"
        Text = "USER DASHBOARD"
        WindowState = FormWindowState.Maximized
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_bookRoom As Button
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents btn_checkout As Button
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
