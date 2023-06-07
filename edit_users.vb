Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

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

            ' Assuming your textboxes are named txt_uname, txt_password, and combo_utype
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

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        ' Retrieve the edited values from the textboxes
        Dim updatedUsername As String = txt_uname.Text.Trim()
        Dim updatedPassword As String = txt_password.Text.Trim()
        Dim updatedUsertype As String = combo_utype.SelectedItem.ToString()

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
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("user_id").Value)

            Dim query As String = "UPDATE user_login SET username = @username,
            password = @password, usertype = @usertype WHERE user_id = @user_id"
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@username", updatedUsername)
                command.Parameters.AddWithValue("@password", updatedPassword)
                command.Parameters.AddWithValue("@usertype", updatedUsertype)
                command.Parameters.AddWithValue("@user_id", userId)
                MsgBox("USER DETAILS EDITED SUCCESSFULLY !!")
                command.ExecuteNonQuery()
            End Using

            'Dim StrCmd As String = "UPDATE user_login" &
            '                       " SET username = '" & txt_uname.Text.Trim() & "'" &
            '                        "   , password = '" & txt_password.Text.Trim() & "'" &
            '                        "   , usertype ='" & combo_utype.SelectedItem.ToString() & "' " &
            '                        " WHERE user_id = @user_id"


            'cmd = New SqlCommand(StrCmd, con)

            'Try
            '    MessageBox.Show("USER DETAILS UPDATED SUCCESSFULLY")
            '    cmd.ExecuteNonQuery()
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try

            'cmd.Dispose()

            ' Refresh the DataGridView to reflect the change
            RefreshDataGridView()

            ' Clear the textboxes and selection
            txt_uname.Text = ""
            txt_password.Text = ""
            combo_utype.SelectedItem = Nothing

        End If
    End Sub
    'refresh and reload the data from the dB
    Private Sub RefreshDataGridView()
        ' Clear the existing data in the DataGridView
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Fetch the updated data from the database
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' Retrieve the selected row
        Dim selectedRow As DataGridViewRow = Nothing
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Convert.ToBoolean(row.Cells("Select").Value) Then
                selectedRow = row
                Exit For
            End If
        Next

        ' Delete the selected user from the database
        If selectedRow IsNot Nothing Then
            ' Ask for confirmation
            Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo)

            If confirmationResult = DialogResult.Yes Then
                Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("user_id").Value)

                Dim query As String = "DELETE FROM user_login WHERE user_id = @user_id"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@user_id", userId)
                    command.ExecuteNonQuery()
                End Using

                ' Refresh the DataGridView to reflect the change
                RefreshDataGridView()

                ' Clear the textboxes and selection
                txt_uname.Text = ""
                txt_password.Text = ""
                combo_utype.SelectedItem = Nothing

                MsgBox("USER DELETED SUCCESSFULLY !!")
            End If
        Else
            MsgBox("SELECT A USER TO DELETE !!")
        End If

    End Sub





    '
End Class
