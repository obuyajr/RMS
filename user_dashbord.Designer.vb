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
        btn_logout = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        Panel1 = New Panel()
        btn_bookRoom = New Button()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_logout
        ' 
        btn_logout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_logout.Image = My.Resources.Resources.log_out_circle_regular_48
        btn_logout.ImageAlign = ContentAlignment.TopCenter
        btn_logout.Location = New Point(682, 3)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(106, 70)
        btn_logout.TabIndex = 0
        btn_logout.Text = "LOGOUT"
        btn_logout.TextAlign = ContentAlignment.BottomCenter
        btn_logout.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.IndianRed
        Panel1.Controls.Add(btn_bookRoom)
        Panel1.Controls.Add(btn_logout)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 91)
        Panel1.TabIndex = 2
        ' 
        ' btn_bookRoom
        ' 
        btn_bookRoom.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_bookRoom.Image = My.Resources.Resources.book_regular_48
        btn_bookRoom.ImageAlign = ContentAlignment.TopCenter
        btn_bookRoom.Location = New Point(12, 3)
        btn_bookRoom.Name = "btn_bookRoom"
        btn_bookRoom.Size = New Size(106, 70)
        btn_bookRoom.TabIndex = 0
        btn_bookRoom.Text = "Book Room"
        btn_bookRoom.TextAlign = ContentAlignment.BottomCenter
        btn_bookRoom.UseVisualStyleBackColor = True
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(119, 17)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' user_dashbord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 454)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Name = "user_dashbord"
        Text = "user_dashbord"
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
End Class
