﻿Imports System.Data.SqlClient

Public Class RoomAvailability
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub RoomAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim query As String = "SELECT  * FROM rooms WHERE room_status = 'BOOKED'"
        'Dim query As String = "SELECT * FROM rooms INNER JOIN bookings  ON b.booking_id = c.booking_id WHERE b.room_status = 'BOOKED'"


        Dim adapter As New SqlDataAdapter(query, con)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        ' Assign the DataTable as the DataGridView's data source
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class