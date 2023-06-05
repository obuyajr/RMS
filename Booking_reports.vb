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


        Dim query As String = "SELECT username FROM user_login" ' Replace YourTable with the actual table name


        Using command As New SqlCommand(query, con)
            Try

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim username As String = reader("username").ToString()
                    ComboBox1.Items.Add(username) ' Replace ComboBox1 with the name of your ComboBox control
                End While

                reader.Close()
            Catch ex As Exception
                ' Handle any exceptions
                MessageBox.Show("Error: " & ex.Message)
            Finally

            End Try
        End Using

    End Sub


End Class