Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Book_Rooms
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Book_Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim query As String = "SELECT * FROM rooms"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        ' Add the checkbox column to the DataGridView
        Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        checkBoxColumn.Name = "Select"
        checkBoxColumn.HeaderText = "Select"
        DataGridView1.Columns.Add(checkBoxColumn)

        ' Assign the DataTable as the DataGridView's data source
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'display on textbox and comboBox if clicked
        ' Check if the checkbox column is clicked
        If e.ColumnIndex = DataGridView1.Columns("Select").Index AndAlso e.RowIndex >= 0 Then
            ' Uncheck all other checkboxes
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Index <> e.RowIndex AndAlso Convert.ToBoolean(row.Cells("Select").Value) Then
                    row.Cells("Select").Value = False
                End If
            Next

            ' Update the selected row's checkbox value
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim isSelected As Boolean = Convert.ToBoolean(selectedRow.Cells("Select").Value)
            selectedRow.Cells("Select").Value = Not isSelected

            ' Assuming your textboxes are named txt_roomNo, txt_roomType, and combo_roomType
            'display from grid to textb 
            If selectedRow.Cells("Select").Value Then
                txt_roomNo.Text = selectedRow.Cells("Room_no").Value.ToString()
                txt_roomNo.ReadOnly = True
                'combo_roomType.SelectedItem = selectedRow.Cells("Room_type").Value.ToString()


                roomType.Text = selectedRow.Cells("Room_type").Value.ToString()
                roomType.ReadOnly = True
                txt_rates.Text = selectedRow.Cells("Rates").Value.ToString()
                txt_rates.ReadOnly = True

                ' combo_status.SelectedItem = selectedRow.Cells("Room_status").Value.ToString()
            Else
                txt_roomNo.Text = ""
                roomType.Text = ""
                txt_rates.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if a room is selected
        If Not String.IsNullOrEmpty(txt_roomNo.Text) Then
            ' Perform the booking process
            ' ...

            ' Assuming you have a "bookings" table in your database
            ' Insert a new booking record into the database
            Dim query As String = "INSERT INTO bookings (room_no, room_type, rates, room_status,
                                    guest_name,phone_number, checkin_date, checkout_date, total) " &
                              "VALUES (@RoomNo, @RoomType, @Rates, @RoomStatus,
                                @GuestName, @PhoneNumber, @CheckinDate, @CheckoutDate, @Total)"
            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@RoomNo", txt_roomNo.Text)
                cmd.Parameters.AddWithValue("@RoomType", roomType.Text)
                cmd.Parameters.AddWithValue("@Rates", Decimal.Parse(txt_rates.Text))
                cmd.Parameters.AddWithValue("@RoomStatus", "Booked")
                cmd.Parameters.AddWithValue("@GuestName", txt_guestName.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", txt_phoneNo.Text)
                cmd.Parameters.AddWithValue("@CheckinDate", DateTime.Parse(checkin_date.Value))
                cmd.Parameters.AddWithValue("@CheckoutDate", DateTime.Parse(checkout_date.Value))
                cmd.Parameters.AddWithValue("@Total", Decimal.Parse(txt_total.Text))
                ' cmd.Parameters.AddWithValue("@Rates", txt_rates.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Show a message to indicate the successful booking
            MessageBox.Show("Room booked successfully!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)

            PrintPreviewBookingDetails()

            ' Clear the selected room details
            txt_roomNo.Text = ""
            roomType.Text = ""
            txt_rates.Text = ""
        Else
            ' No room is selected, display an error message
            MessageBox.Show("Please select a room to book.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'print bookings




    End Sub



    'print booking

    Private Sub PrintPreviewBookingDetails()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim font As New Font("Arial", 12, FontStyle.Regular)
        Dim brush As New SolidBrush(Color.Black)
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim lineHeight As Integer = 20

        ' Print the booking details
        e.Graphics.DrawString("Booking Details", font, brush, startX, startY)
        startY += lineHeight
        e.Graphics.DrawString("Room No: " & txt_roomNo.Text, font, brush, startX, startY)
        startY += lineHeight
        e.Graphics.DrawString("Room Type: " & roomType.Text, font, brush, startX, startY)
        startY += lineHeight
        e.Graphics.DrawString("Rates: " & txt_rates.Text, font, brush, startX, startY)
        startY += lineHeight
        ' ... Print other details as needed ...

        ' Dispose of the font and brush objects
        font.Dispose()
        brush.Dispose()
    End Sub
    '
End Class