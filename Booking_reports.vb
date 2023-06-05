Public Class Booking_reports
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim bookReportsTable As New Booking_reports_table
        bookReportsTable.Show()
        Me.Close()

    End Sub
End Class