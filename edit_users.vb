Imports System.Data.SqlClient

Public Class edit_users
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub edit_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate dataGridView
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;Initial Catalog=vb_login;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Dim query As String = "SELECT * FROM user_login"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()

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
                txt_uname.Text = selectedRow.Cells("username").Value.ToString().ToUpper()
                txt_password.Text = selectedRow.Cells("password").Value.ToString().ToUpper()
                combo_utype.SelectedItem = selectedRow.Cells("usertype").Value.ToString().ToUpper()
            Else
                txt_uname.Text = ""
                txt_password.Text = ""
                combo_utype.SelectedItem = Nothing
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        cmd = con.CreateCommand()
        cmd.CommandText = "UPDATE user_login SET username = @username,
                           password = @password,
                           usertype = @usertype 
                           WHERE username = @originalUsername"

        cmd.Parameters.AddWithValue("@username", txt_uname.Text.ToUpper())

        cmd.Parameters.AddWithValue("@password", txt_password.Text)
        cmd.Parameters.AddWithValue("@usertype", combo_utype.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@originalUsername", txt_uname.Text)
        'UpdateGrid()
        cmd.ExecuteNonQuery()
        MsgBox("USER UPDATED SUCCESSFULLY")
    End Sub

    Private Sub txt_uname_TextChanged(sender As Object, e As EventArgs) Handles txt_uname.TextChanged
        txt_uname.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class