Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Booking_reports
    Private con As New SqlConnection

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Booking_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
            ' SQL query to retrieve usernames from user_login table
            Dim query As String = "SELECT username FROM user_login"

            ' Create a SqlCommand object with the query and connection
            Dim command As New SqlCommand(query, con)

            ' Create a SqlDataReader object
            Dim reader As SqlDataReader = command.ExecuteReader()

            ' Loop through the result set and add usernames to the ComboBox
            While reader.Read()
                ComboBox1.Items.Add(reader("username").ToString())
            End While

            ' Close the reader
            reader.Close()
        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            con.Close()
        End Try
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim startDate As DateTime = DateTimePicker1.Value
        Dim endDate As DateTime = DateTimePicker2.Value
        Dim selectedUsername As String = ComboBox1.SelectedItem?.ToString()

        ' Connection string for your database
        Dim connectionString As String = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"

        ' SQL query to retrieve data based on the DateTimePickers and username
        Dim query As String = "SELECT booking_id, room_no, room_type, guest_name, phone_number, checkin_date, checkout_date, total, teller_name, time_stamp FROM bookings WHERE time_stamp >= @startDate AND time_stamp <= @endDate AND teller_name = @selectedUsername"

        ' Create a SqlConnection object
        Using connection As New SqlConnection(connectionString)
            ' Create a SqlCommand object with the query and connection
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@startDate", startDate.Date)
            command.Parameters.AddWithValue("@endDate", endDate.AddDays(1).AddSeconds(-1)) ' Set end date to the end of the day
            command.Parameters.AddWithValue("@selectedUsername", selectedUsername)

            Try
                ' Open the connection
                connection.Open()

                ' Create a SqlDataAdapter object
                Dim adapter As New SqlDataAdapter(command)

                ' Create a DataSet object to hold the data
                Dim dataSet As New DataSet()

                ' Fill the DataSet with the data from the query
                adapter.Fill(dataSet, "bookings")

                ' Set the DataGridView's DataSource to the DataSet
                DataGridView1.DataSource = dataSet.Tables("bookings")

                ' Calculate the total money
                Dim totalMoney As Decimal = 0

                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim amount As Decimal = 0

                    If Decimal.TryParse(row.Cells("total").Value.ToString(), amount) Then
                        totalMoney += amount
                    End If
                Next

                ' Display the total money
                lbl_total.Text = "Total: " & totalMoney.ToString("C")
            Catch ex As Exception
                ' Handle any errors
                MessageBox.Show("Error: " & ex.Message)
            Finally
                ' Close the connection
                connection.Close()
            End Try
        End Using
    End Sub
End Class
