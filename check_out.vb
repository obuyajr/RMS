Imports System.Data.SqlClient

Public Class check_out
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub check_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim query As String = "SELECT * FROM rooms WHERE room_status = 'BOOKED'"

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

        ToolStripStatusLabel2.Text = Form1.txt_uname.Text
    End Sub

    Private Sub btn_check_out_Click(sender As Object, e As EventArgs) Handles btn_check_out.Click
        If Not String.IsNullOrEmpty(txt_roomNo.Text) Then
            ' Ask for confirmation
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to check out this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Perform the checkout process
                Try
                    ' Update the room status to "UNBOOKED" in the rooms table
                    Dim updateQuery As String = "UPDATE rooms SET Room_status = 'UNBOOKED' WHERE Room_no = @RoomNo"
                    Using updateCmd As New SqlCommand(updateQuery, con)
                        updateCmd.Parameters.AddWithValue("@RoomNo", txt_roomNo.Text)
                        updateCmd.ExecuteNonQuery()
                    End Using

                    ' Show a message to indicate successful checkout
                    MessageBox.Show("Room checked out successfully!", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear the selected room details
                    txt_roomNo.Text = ""

                    ' Reload the DataGridView
                    UpdateGrid()
                Catch ex As Exception
                    MessageBox.Show("Error occurred during checkout: " & ex.Message, "Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            ' No room is selected, display an error message
            MessageBox.Show("Please select a room to check out.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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



            Else
                txt_roomNo.Text = ""

            End If
        End If
    End Sub

    Private Sub UpdateGrid()
        ' Clear the existing data in the DataGridView
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()

        ' Retrieve updated data from the database and populate the DataGridView
        Dim query As String = "SELECT * FROM rooms WHERE room_status = 'BOOKED'"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        ' Add the checkbox column to the DataGridView if it doesn't exist
        If DataGridView1.Columns("Select") Is Nothing Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.Name = "Select"
            checkBoxColumn.HeaderText = "Select"
            DataGridView1.Columns.Add(checkBoxColumn)
        End If

        ' Assign the DataTable as the DataGridView's data source
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

        Me.Close()

    End Sub
End Class