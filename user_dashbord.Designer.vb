<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_dashbord
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
        btn_logout = New Button()
        SuspendLayout()
        ' 
        ' btn_logout
        ' 
        btn_logout.Location = New Point(639, 394)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(100, 23)
        btn_logout.TabIndex = 0
        btn_logout.Text = "LOGOUT"
        btn_logout.UseVisualStyleBackColor = True
        ' 
        ' user_dashbord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 454)
        Controls.Add(btn_logout)
        Name = "user_dashbord"
        Text = "user_dashbord"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_logout As Button
End Class
