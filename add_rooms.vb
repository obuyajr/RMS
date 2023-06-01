Imports System.Data.SqlClient


Public Class add_rooms

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub add_rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

    End Sub

    Private Sub btn_save_new_Click(sender As Object, e As EventArgs) Handles btn_save_new.Click
        cmd = con.CreateCommand()
        cmd.CommandText = CommandType.Text
        cmd.CommandText = "insert into rooms values('" + txt_roomNo.Text + "', 
        '" + combo_roomType.SelectedItem.ToString() + "','" + txt_rates.Text + "'
        ,'" + combo_status.SelectedItem.ToString() + "' )"

        cmd.ExecuteNonQuery()
        MsgBox("ROOM ADDED SUCCESSFULLY")
        txt_roomNo.Text = string.Empty
        combo_roomType.SelectedItem = 0
        txt_rates.Text = string.Empty
        combo_status.SelectedItem = 0




    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

        Me.Dispose()
    End Sub
End Class