﻿Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Printing

Public Class Book_Rooms

    'dB connection vars
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim checkinDate As Date
    Dim rates As Decimal
    Dim totalAmounts As Decimal




    Private Sub Book_Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the database connection string
        con.ConnectionString =
            "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;
             Integrated Security=True"


        ' Open the database connection
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        'open dB con
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
                txt_total.Text = ""

            End If

        End If

    End Sub

    Private Sub btn_book_Click(sender As Object, e As EventArgs) Handles btn_book.Click

        ' Check if a room is selected for booking
        If Not String.IsNullOrEmpty(txt_roomNo.Text) Then

            ' Update the room status to "BOOKED" in the rooms table
            Using updateCmd As New SqlCommand("UPDATE rooms SET Room_status = 'BOOKED' WHERE Room_no = @RoomNo", con)

                updateCmd.Parameters.AddWithValue("@RoomNo", txt_roomNo.Text)
                updateCmd.ExecuteNonQuery()

            End Using


            ' Calculate the number of days
            Dim checkinDate As Date = DateTime.Parse(checkin_date.Value)
            Dim checkoutDate As Date = DateTime.Parse(checkout_date.Value)


            Dim totalDays As Integer = (checkoutDate - checkinDate).Days
            'If checkinDate <= Date.Now Then

            '    MessageBox.Show("enter valid date")
            '    ErrorProvider1.SetError(Panel3, "enter valid date")
            'Else

            '    ' Calculate the total amount
            '    rates = Decimal.Parse(txt_rates.Text)
            '    totalAmount = totalDays * rates

            'End If





            ' Check if any required field is empty
            If String.IsNullOrEmpty(txt_guestName.Text) OrElse
               String.IsNullOrEmpty(txt_phoneNo.Text) OrElse
               String.IsNullOrEmpty(txt_total.Text) Then

                    ' Display an error message if any field is empty
                    MessageBox.Show("Please fill in all the required fields.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ' Exit the method early

                End If

                '
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
                insertCmd.Parameters.AddWithValue("@Total", totalAmounts)
                insertCmd.Parameters.AddWithValue("@TellerName", ToolStripStatusLabel3.Text)
                    insertCmd.ExecuteNonQuery()

                End Using

                ' Show a success message for the booking
                MessageBox.Show("Room booked successfully!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)


                ' Print Preview
                Dim printDocument As New PrintDocument()
                AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

                Dim printPreviewDialog As New PrintPreviewDialog()
                printPreviewDialog.Document = printDocument
                printPreviewDialog.ShowDialog()


                ' Clear the input fields and update the grid
                txt_roomNo.Text = ""
                roomType.Text = ""
                txt_rates.Text = ""
                txt_guestName.Text = ""
                txt_phoneNo.Text = ""
                txt_total.Text = ""
                txt_roomStatus.Text = ""
                txt_total.Text = ""

                UpdateGrid()



                Else

            ' Display an error message if no room is selected
            MessageBox.Show("Please select a room to book.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)

        ' Define the content to be printed
        Dim content As String = " HAPPY CHOICE GH " & Environment.NewLine &
            "-----------------------------------------" & Environment.NewLine &
            "Booking Details:" & Environment.NewLine &
            "Room No: " & txt_roomNo.Text & Environment.NewLine &
            "Room Type: " & roomType.Text & Environment.NewLine &
            "Rates: " & txt_rates.Text & Environment.NewLine &
            "Guest Name: " & txt_guestName.Text & Environment.NewLine &
            "Phone Number: " & txt_phoneNo.Text & Environment.NewLine &
            "Check-in Date: " & checkin_date.Value.ToString() & Environment.NewLine &
            "Checkout Date: " & checkout_date.Value.ToString() & Environment.NewLine &
            "Total: " & txt_total.Text & Environment.NewLine &
            "-----------------------------------------" & Environment.NewLine &
            "SERVED BY: " & ToolStripStatusLabel3.Text


        ' Define the font and brush for drawing the content
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        ' Define the printable area of the thermal printer
        Dim printableAreaWidth As Single = 200 ' Example width in points
        Dim printableAreaHeight As Single = 150 ' Example height in points

        ' Calculate the available content area within the printable area
        Dim contentArea As New RectangleF(0, 0, printableAreaWidth, printableAreaHeight)

        ' Center the content horizontally within the printable area
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Near

        ' Draw the content on the print page within the content area
        e.Graphics.DrawString(content, font, brush, contentArea, format)

        ' Indicate that there are no more pages to print
        e.HasMorePages = False
    End Sub


    Private Sub checkout_date_ValueChanged(sender As Object, e As EventArgs) Handles checkout_date.ValueChanged
        'anytime value changes clear the total field
        txt_total.Text = ""

        '' Calculate the number of days
        'Dim checkinDate As Date = DateTime.Parse(checkin_date.Value)
        'Dim checkoutDate As Date = DateTime.Parse(checkout_date.Value)
        'Dim totalDays As Integer = (checkoutDate - checkinDate).Days

        '' Calculate the total amount
        'Dim rates As Decimal = Decimal.Parse(txt_rates.Text)
        'Dim totalAmount As Decimal = totalDays * rates

        '' Update the total amount text box
        'txt_total.Text = totalAmount.ToString()

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

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

        txt_total.ReadOnly = True

    End Sub

    Private Sub checkin_date_ValueChanged(sender As Object, e As EventArgs) Handles checkin_date.ValueChanged
        ErrorProvider1.SetError(Panel3, "")

        'anytime value changes clear the total field
        txt_total.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '
        If checkinDate < Date.Now Then

            MessageBox.Show("enter valid date")
            ErrorProvider1.SetError(Panel3, "enter valid date")
        Else

            ' Calculate the number of days
            Dim checkinDate As Date = DateTime.Parse(checkin_date.Value)
            Dim checkoutDate As Date = DateTime.Parse(checkout_date.Value)
            Dim totalDays As Integer = (checkoutDate - checkinDate).Days

            ' Calculate the total amount
            rates = Decimal.Parse(txt_rates.Text)
            totalAmounts = totalDays * rates

            'Update the total amount text box
            txt_total.Text = totalAmounts.ToString()
            ' Calculate the total amount



        End If


    End Sub
End Class
