Public Class user_dashbord
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim login_form As New Form1()
        login_form.Show()
        Me.Close()
    End Sub

    Private Sub btn_bookRoom_Click(sender As Object, e As EventArgs) Handles btn_bookRoom.Click
        Dim bookies As New Book_Rooms()
        bookies.Show()

    End Sub

    Private Sub user_dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = Form1.txt_uname.Text
        ToolStripStatusLabel3.Text = Date.Now()
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        Dim checkOut As New check_out()
        checkOut.Show()

    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class