<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check_out
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
        DataGridView1 = New DataGridView()
        btn_check_out = New Button()
        btn_close = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        txt_roomNo = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 24)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(547, 434)
        DataGridView1.TabIndex = 0
        ' 
        ' btn_check_out
        ' 
        btn_check_out.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btn_check_out.BackColor = Color.IndianRed
        btn_check_out.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_check_out.Image = My.Resources.Resources.check_double_regular_24
        btn_check_out.ImageAlign = ContentAlignment.MiddleRight
        btn_check_out.Location = New Point(636, 109)
        btn_check_out.Name = "btn_check_out"
        btn_check_out.Size = New Size(104, 37)
        btn_check_out.TabIndex = 1
        btn_check_out.Text = "CHECKOUT"
        btn_check_out.TextAlign = ContentAlignment.MiddleLeft
        btn_check_out.UseVisualStyleBackColor = False
        ' 
        ' btn_close
        ' 
        btn_close.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btn_close.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.Image = My.Resources.Resources.close
        btn_close.ImageAlign = ContentAlignment.MiddleRight
        btn_close.Location = New Point(636, 407)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 31)
        btn_close.TabIndex = 2
        btn_close.Text = "CLOSE"
        btn_close.TextAlign = ContentAlignment.MiddleLeft
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 471)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(777, 22)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(79, 17)
        ToolStripStatusLabel1.Text = "Logged in As:"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(119, 17)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' txt_roomNo
        ' 
        txt_roomNo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_roomNo.CharacterCasing = CharacterCasing.Upper
        txt_roomNo.Location = New Point(636, 56)
        txt_roomNo.Name = "txt_roomNo"
        txt_roomNo.Size = New Size(82, 23)
        txt_roomNo.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(573, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 5
        Label1.Text = "Room no"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Location = New Point(565, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 166)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Location = New Point(565, 196)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 262)
        Panel2.TabIndex = 7
        ' 
        ' check_out
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Menu
        ClientSize = New Size(777, 493)
        Controls.Add(Label1)
        Controls.Add(txt_roomNo)
        Controls.Add(StatusStrip1)
        Controls.Add(btn_close)
        Controls.Add(btn_check_out)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "check_out"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ROOM CHECKOUT"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_check_out As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents txt_roomNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
