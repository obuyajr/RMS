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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        combo_utype = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_uname
        ' 
        txt_uname.Location = New Point(630, 55)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(100, 23)
        txt_uname.TabIndex = 0
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(630, 108)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(100, 23)
        txt_password.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(553, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(551, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(560, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "USERTYPE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(23, 44)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(378, 394)
        DataGridView1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(537, 248)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 33)
        Button1.TabIndex = 7
        Button1.Text = "EDIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(696, 248)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 33)
        Button2.TabIndex = 8
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(713, 415)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 9
        Button3.Text = "CLOSE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' combo_utype
        ' 
        combo_utype.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        combo_utype.FormattingEnabled = True
        combo_utype.Items.AddRange(New Object() {"ADMIN", "USERS"})
        combo_utype.Location = New Point(630, 162)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(100, 23)
        combo_utype.TabIndex = 10
        ' 
        ' edit_users
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(800, 450)
        Controls.Add(combo_utype)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_password)
        Controls.Add(txt_uname)
        Name = "edit_users"
        Text = "edit_users"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents combo_utype As ComboBox
End Class
