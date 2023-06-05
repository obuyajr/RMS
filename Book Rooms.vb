Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Book_Rooms
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Book_Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the database connection string
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"

        ' Open the database connection
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        ' Update the DataGridView with the available rooms
        UpdateGrid()

        ' Set the username in the status strip
        ToolStripStatusLabel3.Text = Form1.txt_uname.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle the click event in the DataGridView cells
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

            ' Update the room details text boxes if a room is selected
            If selectedRow.Cells("Select").Value Then
                txt_roomNo.Text = selectedRow.Cells("Room_no").Value.ToString()
                txt_roomNo.ReadOnly = True
                roomType.Text = selectedRow.Cells("Room_type").Value.ToString()
                roomType.ReadOnly = True
                txt_rates.Text = selectedRow.Cells("Rates").Value.ToString()
                txt_rates.ReadOnly = True

                txt_roomStatus.Text = selectedRow.Cells("Room_status").Value.ToString()
            Else
                ' Clear the room details text boxes if no room is selected
                txt_roomNo.Text = ""
                roomType.Text = ""
                txt_rates.Text = ""
                txt_roomStatus.Text = ""
            End If
        End If
    End Sub

    Private Sub btn_book_Click(sender As Object, e As EventArgs) Handles btn_book.Click
        ' Check if a room is selected for booking
        If Not String.IsNullOrEmpty(txt_roomNo.Text) Then
            ' Update the room status to "BOOKED" in the rooms table
            Dim updateQuery As String = "UPDATE rooms SET Room_status = 'BOOKED' WHERE Room_no = @RoomNo"
            Using updateCmd As New SqlCommand(updateQuery, con)
                updateCmd.Parameters.AddWithValue("@RoomNo", txt_roomNo.Text)
                updateCmd.ExecuteNonQuery()
            End Using

            ' Calculate the number of days
            Dim checkinDate As Date = DateTime.Parse(checkin_date.Value)
            Dim checkoutDate As Date = DateTime.Parse(checkout_date.Value)
            Dim totalDays As Integer = (checkoutDate - checkinDate).Days

            ' Calculate the total amount
            Dim rates As Decimal = Decimal.Parse(txt_rates.Text)
            Dim totalAmount As Decimal = totalDays * rates

            ' Insert a new booking record into the bookings table
            Dim insertQuery As String = "INSERT INTO bookings (room_no, room_type, rates, room_status, guest_name, phone_number, checkin_date, checkout_date, total, teller_name, time_stamp) " &
                        "VALUES (@RoomNo, @RoomType, @Rates, @RoomStatus, @GuestName, @PhoneNumber, @CheckinDate, @CheckoutDate, @Total, @TellerName, GETDATE())"
            Using insertCmd As New SqlCommand(insertQuery, con)
                insertCmd.Parameters.AddWithValue("@RoomNo", txt_roomNo.Text)
                insertCmd.Parameters.AddWithValue("@RoomType", roomType.Text)
                insertCmd.Parameters.AddWithValue("@Rates", rates)
                insertCmd.Parameters.AddWithValue("@RoomStatus", "Booked")
                insertCmd.Parameters.AddWithValue("@GuestName", txt_guestName.Text)
                insertCmd.Parameters.AddWithValue("@PhoneNumber", txt_phoneNo.Text)
                insertCmd.Parameters.AddWithValue("@CheckinDate", checkinDate)
                insertCmd.Parameters.AddWithValue("@CheckoutDate", checkoutDate)
                insertCmd.Parameters.AddWithValue("@Total", totalAmount)
                insertCmd.Parameters.AddWithValue("@TellerName", ToolStripStatusLabel3.Text)
                insertCmd.ExecuteNonQuery()
            End Using

            ' Show a success message for the booking
            MessageBox.Show("Room booked successfully!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the input fields and update the grid
            txt_roomNo.Text = ""
            roomType.Text = ""
            txt_rates.Text = ""
            txt_guestName.Text = ""
            txt_phoneNo.Text = ""
            txt_total.Text = ""
            txt_roomStatus.Text = ""
            UpdateGrid()
            PrintReceipt()
        Else
            ' Display an error message if no room is selected
            MessageBox.Show("Please select a room to book.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub checkout_date_ValueChanged(sender As Object, e As EventArgs) Handles checkout_date.ValueChanged
        ' Calculate the number of days
        Dim checkinDate As Date = DateTime.Parse(checkin_date.Value)
        Dim checkoutDate As Date = DateTime.Parse(checkout_date.Value)
        Dim totalDays As Integer = (checkoutDate - checkinDate).Days

        ' Calculate the total amount
        Dim rates As Decimal = Decimal.Parse(txt_rates.Text)
        Dim totalAmount As Decimal = totalDays * rates

        ' Update the total amount text box
        txt_total.Text = totalAmount.ToString()
    End Sub

    Private Sub UpdateGrid()
        ' Clear the existing data in the grid
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Retrieve updated data from the database and populate the grid
        Dim query As String = "SELECT * FROM rooms WHERE Room_status = 'UNBOOKED'"

        Using adapter As New SqlDataAdapter(query, con)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Add the checkbox column to the DataGridView
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.Name = "Select"
            checkBoxColumn.HeaderText = "Select"
            DataGridView1.Columns.Add(checkBoxColumn)

            ' Add the remaining columns to the DataGridView
            DataGridView1.Columns.Add("Room_no", "Room Number")
            DataGridView1.Columns.Add("Room_type", "Room Type")
            DataGridView1.Columns.Add("Rates", "Rates")
            DataGridView1.Columns.Add("Room_status", "Room Status")

            ' Populate the grid with the retrieved data
            For Each row As DataRow In dataTable.Rows
                Dim roomNo As String = row("Room_no").ToString()
                Dim roomType As String = row("Room_type").ToString()
                Dim rates As String = row("Rates").ToString()
                Dim roomStatus As String = row("Room_status").ToString()

                DataGridView1.Rows.Add(False, roomNo, roomType, rates, roomStatus)
            Next
        End Using
    End Sub

    Private Sub PrintReceipt()
        ' Create a PrintDocument instance
        Dim printDocument As New PrintDocument()

        ' Handle the PrintPage event to define the content that will be printed
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Show the print preview dialog
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument

        printPreviewDialog.ShowDialog()
    End Sub


    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Define the content to be printed here
        ' You can use the Graphics object (e.Graphics) to draw text, shapes, images, etc.

        ' Example: Print the booking details
        Dim font As New Font("Arial", 12)
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim lineHeight As Integer = 20

        ' Print the heading
        e.Graphics.DrawString("Booking Receipt", font, Brushes.Black, startX, startY)

        ' Print the room details
        startY += lineHeight
        e.Graphics.DrawString("Room Number: " & txt_roomNo.Text, font, Brushes.Black, startX, startY)

        ' Print the guest details
        startY += lineHeight
        e.Graphics.DrawString("Guest Name: " & txt_guestName.Text, font, Brushes.Black, startX, startY)
        startY += lineHeight
        e.Graphics.DrawString("Phone Number: " & txt_phoneNo.Text, font, Brushes.Black, startX, startY)

        ' ... (add more content as needed)

        ' Print a horizontal line
        startY += lineHeight
        e.Graphics.DrawLine(Pens.Black, startX, startY, e.PageBounds.Width - startX, startY)

        ' Print the footer
        startY += lineHeight
        e.Graphics.DrawString("Thank you for choosing our hotel!", font, Brushes.Black, startX, startY)
    End Sub

End Class
