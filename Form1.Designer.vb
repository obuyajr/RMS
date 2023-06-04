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
        btn_login.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_login.Image = My.Resources.Resources.chevrons_right_regular_24
        btn_login.ImageAlign = ContentAlignment.MiddleRight
        btn_login.Location = New Point(35, 289)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(78, 34)
        btn_login.TabIndex = 0
        btn_login.Text = "LOGIN"
        btn_login.TextAlign = ContentAlignment.MiddleLeft
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_close
        ' 
        btn_close.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.Image = My.Resources.Resources.close
        btn_close.ImageAlign = ContentAlignment.MiddleRight
        btn_close.Location = New Point(270, 289)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(79, 34)
        btn_close.TabIndex = 1
        btn_close.Text = "CLOSE"
        btn_close.TextAlign = ContentAlignment.MiddleLeft
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' combo_utype
        ' 
        combo_utype.FormattingEnabled = True
        combo_utype.Items.AddRange(New Object() {"ADMIN", "USER"})
        combo_utype.Location = New Point(146, 221)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(121, 23)
        combo_utype.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(40, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(40, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(49, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "USERTYPE"
        ' 
        ' txt_uname
        ' 
        txt_uname.Location = New Point(146, 114)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(196, 23)
        txt_uname.TabIndex = 6
        ' 
        ' txt_pwd
        ' 
        txt_pwd.Location = New Point(146, 176)
        txt_pwd.Name = "txt_pwd"
        txt_pwd.Size = New Size(196, 23)
        txt_pwd.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Gabriola", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(105, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(359, 88)
        Label4.TabIndex = 8
        Label4.Text = "HAPPY CHOICE GH"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        BackgroundImage = My.Resources.Resources.building_house_solid_72___Copy
        ClientSize = New Size(551, 344)
        Controls.Add(Label4)
        Controls.Add(txt_pwd)
        Controls.Add(txt_uname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(combo_utype)
        Controls.Add(btn_close)
        Controls.Add(btn_login)
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
