<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Panel1 = New Panel()
        lbl_amount = New Label()
        label5 = New Label()
        Panel2 = New Panel()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel3 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(lbl_amount)
        Panel1.Controls.Add(label5)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(467, 93)
        Panel1.TabIndex = 0
        ' 
        ' lbl_amount
        ' 
        lbl_amount.AutoSize = True
        lbl_amount.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_amount.Location = New Point(306, 24)
        lbl_amount.Name = "lbl_amount"
        lbl_amount.Size = New Size(0, 40)
        lbl_amount.TabIndex = 1
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        label5.ForeColor = SystemColors.ControlLightLight
        label5.Location = New Point(22, 19)
        label5.Name = "label5"
        label5.Size = New Size(93, 45)
        label5.TabIndex = 0
        label5.Text = "DUE:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Panel2.Location = New Point(12, 111)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(467, 301)
        Panel2.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.InactiveCaptionText
        TextBox4.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.ForeColor = Color.Yellow
        TextBox4.Location = New Point(192, 229)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(136, 40)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(192, 168)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(136, 33)
        TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(28, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 20)
        Label4.TabIndex = 5
        Label4.Text = "LOOSE CHANGE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(25, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 20)
        Label3.TabIndex = 4
        Label3.Text = "TOTAL PAYMENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(86, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 3
        Label2.Text = "M/MONEY"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(119, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 2
        Label1.Text = "CASH"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(192, 109)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(136, 33)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(192, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(136, 33)
        TextBox1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientInactiveCaption
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(12, 418)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(467, 100)
        Panel3.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Window
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(316, 27)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 38)
        Button2.TabIndex = 1
        Button2.Text = "CLOSE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(191, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 38)
        Button1.TabIndex = 0
        Button1.Text = "ACCEPT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 524)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Payment"
        Text = "Payment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_amount As Label
    Friend WithEvents label5 As Label
End Class
