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

        Dim query As String = "SELECT * FROM rooms WHERE room_status = 'UNBOOKED'"

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
                roomType.Text = selectedRow.Cells("Room_type").Value.ToString()
                roomType.ReadOnly = True
                txt_rates.Text = selectedRow.Cells("Rates").Value.ToString()
                txt_rates.ReadOnly = True

                txt_roomStatus.Text = selectedRow.Cells("Room_status").Value.ToString()
                ' combo_status.SelectedItem = selectedRow.Cells("Room_status").Value.ToString()
            Else
                txt_roomNo.Text = ""
                roomType.Text = ""
                txt_rates.Text = ""
                txt_roomStatus.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_book.Click
        ' Check if a room is selected
        If Not String.IsNullOrEmpty(txt_roomNo.Text) Then
            ' Perform the booking process
            ' ...

            ' Update the room status to "Booked" in the rooms table
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
            Dim insertQuery As String = "INSERT INTO bookings (room_no, room_type, rates, room_status, guest_name, phone_number, checkin_date, checkout_date, total) " &
                                        "VALUES (@RoomNo, @RoomType, @Rates, @RoomStatus, @GuestName, @PhoneNumber, @CheckinDate, @CheckoutDate, @Total)"
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
                insertCmd.ExecuteNonQuery()
            End Using

            ' Show a message to indicate the successful booking
            MessageBox.Show("Room booked successfully!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)





            '
            'RELOAD THE TABLE
            UpdateGrid()
            '
            ' Clear the selected room details
            txt_roomNo.Text = ""
            roomType.Text = ""
            txt_rates.Text = ""
            txt_guestName.Text = ""
            txt_phoneNo.Text = ""
            txt_total.Text = ""
            txt_roomStatus.Text = ""
            'checkin_date.Value = DateTime.Now
            ' checkout_date.Value = DateTime.Now
            'RELOAD THE TABLE
            UpdateGrid()
            '
        Else
            ' No room is selected, display an error message
            MessageBox.Show("Please select a room to book.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'when checkout date is changed calculate the total
    Private Sub checkout_date_ValueChanged(sender As Object, e As EventArgs) Handles checkout_date.ValueChanged
        ' Calculate the number of days
        Dim checkinDate As Date = DateTime.Parse(checkin_date.Value)
        Dim checkoutDate As Date = DateTime.Parse(checkout_date.Value)
        Dim totalDays As Integer = (checkoutDate - checkinDate).Days

        ' Calculate the total amount
        Dim rates As Decimal = Decimal.Parse(txt_rates.Text)
        Dim totalAmount As Decimal = totalDays * rates

        ' Update the txt_total TextBox with the calculated total
        txt_total.Text = totalAmount.ToString()
    End Sub

    'reload grid
    Private Sub UpdateGrid()
        ' Assuming you have a DataGridView control named dgv_rooms

        ' Clear the existing data in the grid
        DataGridView1.Rows.Clear()

        ' Retrieve updated data from the database and populate the grid
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT * FROM rooms WHERE room_status = 'UNBOOKED'"
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            DataGridView1.Rows.Add(reader("Room_no"), reader("Room_type"), reader("Rates"), reader("Room_status"))
        End While
        reader.Close()
    End Sub



End Class