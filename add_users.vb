Imports System.Data.SqlClient

Public Class add_users

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub add_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        cmd = con.CreateCommand()
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "insert into user_login values('" + txt_uname.Text + "',
        '" + txt_password.Text + "'
        ,'" + combo_utype.SelectedItem.ToString() + "' )"

        cmd.ExecuteNonQuery()
        MsgBox("USER ADDED SUCCESSFULLY")
        txt_uname.Text = String.Empty
        txt_password.Text = String.Empty
        combo_utype.SelectedItem = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class