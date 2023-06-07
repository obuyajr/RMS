﻿Imports System.Data.SqlClient

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
        '
        ' Retrieve the edited values from the textboxes
        Dim updatedRoomNo As String = txt_roomNo.Text.Trim()
        Dim updatedRoomType As String = combo_roomType.SelectedItem.ToString()
        Dim updatedRates As String = txt_rates.Text.Trim()
        Dim updatedStatus As String = combo_status.SelectedItem.ToString()


        ' Retrieve the selected row
        Dim selectedRow As DataGridViewRow = Nothing
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Convert.ToBoolean(row.Cells("Select").Value) Then
                selectedRow = row
                Exit For
            End If
        Next

        ' Update the corresponding record in the database
        If selectedRow IsNot Nothing Then
            Dim roomNumber As String = Convert.ToString(selectedRow.Cells("Room_no").Value)


            Dim query As String = "UPDATE rooms SET Room_type = @Roomtype,
            Rates = @Rates, Room_status = @roomStatus WHERE Room_no = @roomNo"
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@Roomtype", updatedRoomType)
                command.Parameters.AddWithValue("@Rates", updatedRates)
                command.Parameters.AddWithValue("@roomStatus", updatedStatus)
                command.Parameters.AddWithValue("@roomNo", updatedRoomNo)

                MsgBox("ROOM DETAILS EDITED SUCCESSFULLY !!")
                command.ExecuteNonQuery()
            End Using

            ' Refresh the DataGridView to reflect the change


            ' Clear the textboxes and selection
            txt_roomNo.Text = ""
            combo_roomType.SelectedItem = Nothing
            txt_rates.Text = ""
            combo_status.SelectedItem = Nothing

            UpdateGrid()
        End If




        '



    End Sub

    'update tableGrid
    Private Sub UpdateGrid()
        ' Clear the existing data in the DataGridView
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Fetch the updated data from the database
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



End Class
