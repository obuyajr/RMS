<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_room
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt_roomNo = New TextBox()
        combo_roomType = New ComboBox()
        txt_rates = New TextBox()
        combo_status = New ComboBox()
        DataGridView1 = New DataGridView()
        btn_edit = New Button()
        btn_delete = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "ROOM NO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 1
        Label2.Text = "ROOM TYPE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 2
        Label3.Text = "STATUS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "RATES"
        ' 
        ' txt_roomNo
        ' 
        txt_roomNo.CharacterCasing = CharacterCasing.Upper
        txt_roomNo.Location = New Point(117, 29)
        txt_roomNo.Name = "txt_roomNo"
        txt_roomNo.ReadOnly = True
        txt_roomNo.Size = New Size(74, 23)
        txt_roomNo.TabIndex = 4
        ' 
        ' combo_roomType
        ' 
        combo_roomType.FormattingEnabled = True
        combo_roomType.Items.AddRange(New Object() {"DELUXE", "NORMAL"})
        combo_roomType.Location = New Point(117, 86)
        combo_roomType.Name = "combo_roomType"
        combo_roomType.Size = New Size(121, 23)
        combo_roomType.TabIndex = 5
        ' 
        ' txt_rates
        ' 
        txt_rates.CharacterCasing = CharacterCasing.Upper
        txt_rates.Location = New Point(117, 144)
        txt_rates.Name = "txt_rates"
        txt_rates.Size = New Size(121, 23)
        txt_rates.TabIndex = 6
        ' 
        ' combo_status
        ' 
        combo_status.FormattingEnabled = True
        combo_status.Items.AddRange(New Object() {"UNBOOKED"})
        combo_status.Location = New Point(117, 193)
        combo_status.Name = "combo_status"
        combo_status.Size = New Size(121, 23)
        combo_status.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(350, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(438, 426)
        DataGridView1.TabIndex = 8
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(23, 295)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(75, 23)
        btn_edit.TabIndex = 9
        btn_edit.Text = "EDIT"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(163, 295)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(75, 23)
        btn_delete.TabIndex = 10
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' edit_room
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(DataGridView1)
        Controls.Add(combo_status)
        Controls.Add(txt_rates)
        Controls.Add(combo_roomType)
        Controls.Add(txt_roomNo)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "edit_room"
        Text = "edit_room"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_roomNo As TextBox
    Friend WithEvents combo_roomType As ComboBox
    Friend WithEvents txt_rates As TextBox
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
End Class
