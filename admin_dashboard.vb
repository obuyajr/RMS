Public Class admin_dashboard

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login_form As New Form1()
        login_form.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim addRoom As New add_rooms()
        addRoom.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim editRoom As New edit_room()
        editRoom.Show()

    End Sub

    Private Sub ADDUSERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDUSERSToolStripMenuItem.Click
        Dim addUsers As New add_users()
        addUsers.Show()
    End Sub

    Private Sub EDITUSERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITUSERSToolStripMenuItem.Click
        Dim editUsers As New edit_users()
        editUsers.Show()

    End Sub
End Class