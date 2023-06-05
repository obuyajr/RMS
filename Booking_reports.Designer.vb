<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_reports
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
        btn_close = New Button()
        btn_generate = New Button()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn_close
        ' 
        btn_close.Location = New Point(406, 212)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 23)
        btn_close.TabIndex = 15
        btn_close.Text = "CLOSE"
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' btn_generate
        ' 
        btn_generate.Location = New Point(122, 212)
        btn_generate.Name = "btn_generate"
        btn_generate.Size = New Size(75, 23)
        btn_generate.TabIndex = 14
        btn_generate.Text = "GENERATE"
        btn_generate.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(122, 140)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(148, 23)
        ComboBox1.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 12
        Label3.Text = "TELLER NAME"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(122, 85)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 11
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(122, 32)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 9
        Label2.Text = "END DATE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 8
        Label1.Text = "START DATE"
        ' 
        ' Booking_reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(516, 267)
        Controls.Add(btn_close)
        Controls.Add(btn_generate)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Booking_reports"
        Text = "Booking_reports"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_close As Button
    Friend WithEvents btn_generate As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
