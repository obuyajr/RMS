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
        SuspendLayout()
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_login.Image = My.Resources.Resources.chevrons_right_regular_24
        btn_login.ImageAlign = ContentAlignment.MiddleRight
        btn_login.Location = New Point(103, 187)
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
        btn_close.Location = New Point(484, 187)
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
        combo_utype.Location = New Point(217, 125)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(121, 23)
        combo_utype.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(118, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(116, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(125, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "USERTYPE"
        ' 
        ' txt_uname
        ' 
        txt_uname.Location = New Point(217, 43)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(196, 23)
        txt_uname.TabIndex = 6
        ' 
        ' txt_pwd
        ' 
        txt_pwd.Location = New Point(217, 83)
        txt_pwd.Name = "txt_pwd"
        txt_pwd.Size = New Size(196, 23)
        txt_pwd.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(661, 253)
        Controls.Add(txt_pwd)
        Controls.Add(txt_uname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(combo_utype)
        Controls.Add(btn_close)
        Controls.Add(btn_login)
        Name = "Form1"
        Text = "Form1"
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
End Class
