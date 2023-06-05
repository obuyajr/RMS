Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Booking_reports
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub


    Private Sub Booking_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()




    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim bookreportTable As New Booking_reports_table()
        bookreportTable.Show()

    End Sub


End Class