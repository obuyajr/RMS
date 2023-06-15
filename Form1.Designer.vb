<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn_login = New Button()
        btn_close = New Button()
        combo_utype = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_uname = New TextBox()
        txt_pwd = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.Yellow
        btn_login.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_login.Image = My.Resources.Resources.chevrons_right_regular_24
        btn_login.ImageAlign = ContentAlignment.MiddleRight
        btn_login.Location = New Point(85, 277)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(98, 46)
        btn_login.TabIndex = 0
        btn_login.Text = "LOGIN"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_close
        ' 
        btn_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_close.BackColor = Color.LimeGreen
        btn_close.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.Image = My.Resources.Resources.close
        btn_close.ImageAlign = ContentAlignment.MiddleLeft
        btn_close.Location = New Point(321, 277)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(98, 46)
        btn_close.TabIndex = 1
        btn_close.Text = "CLOSE"
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' combo_utype
        ' 
        combo_utype.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_utype.FormattingEnabled = True
        combo_utype.Items.AddRange(New Object() {"ADMIN", "USER"})
        combo_utype.Location = New Point(146, 213)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(196, 28)
        combo_utype.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(39, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 21)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(38, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 21)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(50, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 21)
        Label3.TabIndex = 5
        Label3.Text = "USERTYPE"
        ' 
        ' txt_uname
        ' 
        txt_uname.CharacterCasing = CharacterCasing.Upper
        txt_uname.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_uname.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        txt_uname.Location = New Point(146, 106)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(196, 33)
        txt_uname.TabIndex = 6
        txt_uname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_pwd
        ' 
        txt_pwd.CharacterCasing = CharacterCasing.Upper
        txt_pwd.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txt_pwd.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        txt_pwd.Location = New Point(146, 161)
        txt_pwd.Name = "txt_pwd"
        txt_pwd.PasswordChar = "#"c
        txt_pwd.Size = New Size(196, 33)
        txt_pwd.TabIndex = 7
        txt_pwd.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Gabriola", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(60, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(359, 88)
        Label4.TabIndex = 8
        Label4.Text = "HAPPY CHOICE GH"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        ClientSize = New Size(506, 344)
        Controls.Add(Label4)
        Controls.Add(txt_pwd)
        Controls.Add(txt_uname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(combo_utype)
        Controls.Add(btn_close)
        Controls.Add(btn_login)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HAPPY CHOICE LTD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents combo_utype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents Label4 As Label
End Class
