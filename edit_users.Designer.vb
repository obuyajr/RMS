<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_users
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
        txt_uname = New TextBox()
        txt_password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        btn_edit = New Button()
        btn_delete = New Button()
        btn_close = New Button()
        combo_utype = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_uname
        ' 
        txt_uname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_uname.CharacterCasing = CharacterCasing.Upper
        txt_uname.Location = New Point(774, 55)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(100, 23)
        txt_uname.TabIndex = 0
        ' 
        ' txt_password
        ' 
        txt_password.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_password.CharacterCasing = CharacterCasing.Upper
        txt_password.Location = New Point(774, 108)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(100, 23)
        txt_password.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(697, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(695, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(704, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "USERTYPE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(552, 426)
        DataGridView1.TabIndex = 6
        ' 
        ' btn_edit
        ' 
        btn_edit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btn_edit.BackColor = SystemColors.ControlLightLight
        btn_edit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_edit.Image = My.Resources.Resources.edit_alt_solid_24
        btn_edit.ImageAlign = ContentAlignment.MiddleRight
        btn_edit.Location = New Point(684, 248)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(75, 33)
        btn_edit.TabIndex = 7
        btn_edit.Text = "EDIT"
        btn_edit.TextAlign = ContentAlignment.MiddleLeft
        btn_edit.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btn_delete.BackColor = SystemColors.ControlLightLight
        btn_delete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_delete.Image = My.Resources.Resources.trash_solid_24
        btn_delete.ImageAlign = ContentAlignment.MiddleRight
        btn_delete.Location = New Point(840, 248)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(75, 33)
        btn_delete.TabIndex = 8
        btn_delete.Text = "DELETE"
        btn_delete.TextAlign = ContentAlignment.MiddleLeft
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_close
        ' 
        btn_close.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btn_close.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.Image = My.Resources.Resources.close
        btn_close.ImageAlign = ContentAlignment.MiddleRight
        btn_close.Location = New Point(840, 402)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 36)
        btn_close.TabIndex = 9
        btn_close.Text = "CLOSE"
        btn_close.TextAlign = ContentAlignment.MiddleLeft
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' combo_utype
        ' 
        combo_utype.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        combo_utype.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        combo_utype.FormattingEnabled = True
        combo_utype.Items.AddRange(New Object() {"ADMIN", "USER"})
        combo_utype.Location = New Point(774, 162)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(100, 23)
        combo_utype.TabIndex = 10
        ' 
        ' edit_users
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(973, 450)
        Controls.Add(combo_utype)
        Controls.Add(btn_close)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_password)
        Controls.Add(txt_uname)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "edit_users"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Users"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents combo_utype As ComboBox
End Class
