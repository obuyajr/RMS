<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_rooms
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
        txt_roomNo = New TextBox()
        txt_rates = New TextBox()
        btn_save_new = New Button()
        Button2 = New Button()
        btn_close = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        combo_roomType = New ComboBox()
        combo_status = New ComboBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txt_roomNo
        ' 
        txt_roomNo.Location = New Point(142, 44)
        txt_roomNo.Name = "txt_roomNo"
        txt_roomNo.Size = New Size(121, 23)
        txt_roomNo.TabIndex = 0
        ' 
        ' txt_rates
        ' 
        txt_rates.Location = New Point(142, 124)
        txt_rates.Name = "txt_rates"
        txt_rates.Size = New Size(100, 23)
        txt_rates.TabIndex = 1
        ' 
        ' btn_save_new
        ' 
        btn_save_new.Location = New Point(12, 227)
        btn_save_new.Name = "btn_save_new"
        btn_save_new.Size = New Size(116, 23)
        btn_save_new.TabIndex = 3
        btn_save_new.Text = "SAVE AND NEW"
        btn_save_new.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(134, 227)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 23)
        Button2.TabIndex = 4
        Button2.Text = "SAVE AND CLOSE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btn_close
        ' 
        btn_close.Location = New Point(271, 227)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 23)
        btn_close.TabIndex = 5
        btn_close.Text = "CLOSE"
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 6
        Label1.Text = "ROOM NO."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 7
        Label2.Text = "ROOM TYPE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(78, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 8
        Label3.Text = "RATES"
        ' 
        ' combo_roomType
        ' 
        combo_roomType.FormattingEnabled = True
        combo_roomType.Items.AddRange(New Object() {"DELUXE", "NORMAL"})
        combo_roomType.Location = New Point(142, 84)
        combo_roomType.Name = "combo_roomType"
        combo_roomType.Size = New Size(121, 23)
        combo_roomType.TabIndex = 9
        ' 
        ' combo_status
        ' 
        combo_status.FormattingEnabled = True
        combo_status.Items.AddRange(New Object() {"UNBOOKED"})
        combo_status.Location = New Point(142, 164)
        combo_status.Name = "combo_status"
        combo_status.Size = New Size(121, 23)
        combo_status.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(78, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 11
        Label4.Text = "STATUS"
        ' 
        ' add_rooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(372, 292)
        Controls.Add(Label4)
        Controls.Add(combo_status)
        Controls.Add(combo_roomType)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_close)
        Controls.Add(Button2)
        Controls.Add(btn_save_new)
        Controls.Add(txt_rates)
        Controls.Add(txt_roomNo)
        Name = "add_rooms"
        Text = "add_rooms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_roomNo As TextBox
    Friend WithEvents txt_rates As TextBox
    Friend WithEvents btn_save_new As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_roomType As ComboBox
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents Label4 As Label
End Class
