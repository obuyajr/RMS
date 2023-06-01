<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        DELETEROOMSToolStripMenuItem = New ToolStripMenuItem()
        USERSToolStripMenuItem = New ToolStripMenuItem()
        ADDUSERSToolStripMenuItem = New ToolStripMenuItem()
        EDITUSERSToolStripMenuItem = New ToolStripMenuItem()
        DELETEUSERSToolStripMenuItem = New ToolStripMenuItem()
        EeeToolStripMenuItem = New ToolStripMenuItem()
        REPORTSToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(577, 415)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 23)
        Button1.TabIndex = 0
        Button1.Text = "LOGOUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, USERSToolStripMenuItem, REPORTSToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, DELETEROOMSToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(61, 20)
        ToolStripMenuItem1.Text = "ROOMS"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(180, 22)
        ToolStripMenuItem2.Text = "ADD ROOMS"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(180, 22)
        ToolStripMenuItem3.Text = "EDIT ROOMS"
        ' 
        ' DELETEROOMSToolStripMenuItem
        ' 
        DELETEROOMSToolStripMenuItem.Name = "DELETEROOMSToolStripMenuItem"
        DELETEROOMSToolStripMenuItem.Size = New Size(180, 22)
        DELETEROOMSToolStripMenuItem.Text = "DELETE ROOMS"
        ' 
        ' USERSToolStripMenuItem
        ' 
        USERSToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ADDUSERSToolStripMenuItem, EDITUSERSToolStripMenuItem, DELETEUSERSToolStripMenuItem, EeeToolStripMenuItem})
        USERSToolStripMenuItem.Name = "USERSToolStripMenuItem"
        USERSToolStripMenuItem.Size = New Size(52, 20)
        USERSToolStripMenuItem.Text = "USERS"
        ' 
        ' ADDUSERSToolStripMenuItem
        ' 
        ADDUSERSToolStripMenuItem.Name = "ADDUSERSToolStripMenuItem"
        ADDUSERSToolStripMenuItem.Size = New Size(148, 22)
        ADDUSERSToolStripMenuItem.Text = "ADD USERS"
        ' 
        ' EDITUSERSToolStripMenuItem
        ' 
        EDITUSERSToolStripMenuItem.Name = "EDITUSERSToolStripMenuItem"
        EDITUSERSToolStripMenuItem.Size = New Size(148, 22)
        EDITUSERSToolStripMenuItem.Text = "EDIT USERS"
        ' 
        ' DELETEUSERSToolStripMenuItem
        ' 
        DELETEUSERSToolStripMenuItem.Name = "DELETEUSERSToolStripMenuItem"
        DELETEUSERSToolStripMenuItem.Size = New Size(148, 22)
        DELETEUSERSToolStripMenuItem.Text = "DELETE USERS"
        ' 
        ' EeeToolStripMenuItem
        ' 
        EeeToolStripMenuItem.Name = "EeeToolStripMenuItem"
        EeeToolStripMenuItem.Size = New Size(148, 22)
        EeeToolStripMenuItem.Text = "eee"
        ' 
        ' REPORTSToolStripMenuItem
        ' 
        REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        REPORTSToolStripMenuItem.Size = New Size(66, 20)
        REPORTSToolStripMenuItem.Text = "REPORTS"
        ' 
        ' admin_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "admin_dashboard"
        Text = "admin_dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents USERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents DELETEROOMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADDUSERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITUSERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEUSERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EeeToolStripMenuItem As ToolStripMenuItem
End Class
