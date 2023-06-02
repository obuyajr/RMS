Imports System.Data.SqlClient

Public Class edit_room
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub edit_room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate dataGridView
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
            If selectedRow.Cells("Select").Value Then
                txt_roomNo.Text = selectedRow.Cells("Room_no").Value.ToString()
                txt_roomNo.ReadOnly = True
                combo_roomType.SelectedItem = selectedRow.Cells("Room_type").Value.ToString()
                txt_rates.Text = selectedRow.Cells("Rates").Value.ToString()
                combo_status.SelectedItem = selectedRow.Cells("Room_status").Value.ToString()
            Else
                txt_roomNo.Text = ""
                combo_roomType.SelectedItem = Nothing
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click


        cmd = con.CreateCommand()
        cmd.CommandText = "UPDATE rooms SET room_type = @roomType,
        rates = @rates, Room_status = @status WHERE room_no = @roomNo"
        cmd.Parameters.AddWithValue("@roomType", combo_roomType.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@rates", txt_rates.Text)
        cmd.Parameters.AddWithValue("@status", combo_status.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@roomNo", txt_roomNo.Text)
        UpdateGrid()
        cmd.ExecuteNonQuery()
        MsgBox("ROOM UPDATED SUCCESSFULLY")

    End Sub

    'update tableGrid
    Private Sub UpdateGrid()
        ' Assuming you have a DataGridView control named dgv_rooms

        ' Clear the existing data in the grid
        DataGridView1.Rows.Clear()

        ' Retrieve updated data from the database and populate the grid
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT * FROM rooms"
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            DataGridView1.Rows.Add(reader("Room_no"), reader("Room_type"), reader("Rates"), reader("Room_status"))
        End While
        reader.Close()
    End Sub



End Class
