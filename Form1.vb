Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Define the connection string to the database
        Dim connectionString As String = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"

        ' Create a SqlConnection using the connection string
        Using con As SqlConnection = New SqlConnection(connectionString)
            con.Open()

            ' Define the SQL query with parameters for username, password, and usertype
            Dim query As String = "SELECT * FROM user_login WHERE username = @username AND password = @password AND usertype = @usertype"
            Dim cmd As SqlCommand = New SqlCommand(query, con)

            ' Set parameter values to prevent SQL injection and improve security
            cmd.Parameters.AddWithValue("@username", txt_uname.Text)
            cmd.Parameters.AddWithValue("@password", txt_pwd.Text)
            cmd.Parameters.AddWithValue("@usertype", combo_utype.SelectedItem)

            ' Create a DataTable to hold the results of the query
            Dim dt As DataTable = New DataTable()

            ' Create a SqlDataAdapter to fill the DataTable with data from the query
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)

            ' Check if any rows are returned from the query
            If dt.Rows.Count > 0 Then
                ' If there are rows, display a success message with the user type
                MessageBox.Show("You are logged in as " & dt.Rows(0)("usertype").ToString())

                ' Based on the selected user type, show the appropriate form
                If combo_utype.SelectedIndex = 0 Then
                    ' If user type is "Admin", create an instance of the Admin form and show it
                    Dim adminForm As New admin_dashboard()
                    adminForm.Show()
                Else
                    ' If user type is "User", create an instance of the User form and show it
                    Dim userForm As New user_dashbord()
                    userForm.Show()
                End If

                ' Hide the current form
                Me.Hide()
            Else
                ' If no rows are returned, display an error message
                MessageBox.Show("Invalid username, password, or user type.")
            End If
        End Using
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()

    End Sub
End Class
