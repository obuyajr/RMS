Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Booking_reports_table
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Private ReadOnly _bookings As ObservableCollection(Of String)


    Private Sub Booking_reports_table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate dataGridView
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim query As String = "SELECT * FROM bookings"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)



        ' Assign the DataTable as the DataGridView's data source
        DataGridView1.DataSource = dataTable
        DataGridView1.ReadOnly = True

    End Sub
End Class