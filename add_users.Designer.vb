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
        Panel1 = New Panel()
        Button2 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = Color.Red
        btn_add.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_add.Location = New Point(20, 209)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(101, 35)
        btn_add.TabIndex = 0
        btn_add.Text = "ADD USER"
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SeaShell
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(20, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 17)
        Label1.TabIndex = 1
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SeaShell
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(18, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 17)
        Label2.TabIndex = 2
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SeaShell
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(27, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 17)
        Label3.TabIndex = 3
        Label3.Text = "USERTYPE"
        ' 
        ' txt_uname
        ' 
        txt_uname.CharacterCasing = CharacterCasing.Upper
        txt_uname.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_uname.Location = New Point(113, 29)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(149, 29)
        txt_uname.TabIndex = 4
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_password.Location = New Point(113, 83)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(149, 29)
        txt_password.TabIndex = 5
        ' 
        ' combo_utype
        ' 
        combo_utype.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        combo_utype.FormattingEnabled = True
        combo_utype.Items.AddRange(New Object() {"ADMIN", "USER"})
        combo_utype.Location = New Point(113, 130)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(149, 29)
        combo_utype.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Orange
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(217, 430)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 35)
        Button1.TabIndex = 7
        Button1.Text = "CLOSE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaShell
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btn_add)
        Panel1.Controls.Add(combo_utype)
        Panel1.Controls.Add(txt_uname)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txt_password)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(308, 509)
        Panel1.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(177, 209)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 34)
        Button2.TabIndex = 8
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(326, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(468, 509)
        Panel2.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(188, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 20)
        Label4.TabIndex = 0
        Label4.Text = "User Rights"
        ' 
        ' add_users
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(806, 533)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "add_users"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADD USERS"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents combo_utype As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
End Class
