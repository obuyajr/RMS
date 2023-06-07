<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_users
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
        btn_add = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_uname = New TextBox()
        txt_password = New TextBox()
        combo_utype = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btn_add
        ' 
        btn_add.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_add.Location = New Point(145, 250)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(147, 35)
        btn_add.TabIndex = 0
        btn_add.Text = "ADD USER"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(41, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 21)
        Label1.TabIndex = 1
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(41, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 21)
        Label2.TabIndex = 2
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(41, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 21)
        Label3.TabIndex = 3
        Label3.Text = "USERTYPE"
        ' 
        ' txt_uname
        ' 
        txt_uname.CharacterCasing = CharacterCasing.Upper
        txt_uname.Location = New Point(145, 97)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(149, 23)
        txt_uname.TabIndex = 4
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(145, 142)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(149, 23)
        txt_password.TabIndex = 5
        ' 
        ' combo_utype
        ' 
        combo_utype.FormattingEnabled = True
        combo_utype.Items.AddRange(New Object() {"ADMIN", "USER"})
        combo_utype.Location = New Point(145, 192)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(149, 23)
        combo_utype.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(245, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' add_users
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(354, 391)
        Controls.Add(Button1)
        Controls.Add(combo_utype)
        Controls.Add(txt_password)
        Controls.Add(txt_uname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_add)
        Name = "add_users"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADD USERS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents combo_utype As ComboBox
    Friend WithEvents Button1 As Button
End Class
