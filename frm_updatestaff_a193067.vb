Public Class frm_updatestaff_a193067

    Dim current_code As String
    Dim myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")

    Private Sub frm_updatestaff_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler grd_updatestaff.CellClick, AddressOf HandleGridEvent
        AddHandler grd_updatestaff.SelectionChanged, AddressOf HandleGridEvent
        refresh_grid()
    End Sub

    Private Sub grd_updatestaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updatestaff.CellContentClick
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A193067"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_updatestaff.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_staffID.Text = ""
        txt_staffname.Text = ""
        txt_contactnumber.Text = ""
        txt_email.Text = ""
    End Sub

    Private Sub get_current_code()
        If grd_updatestaff.SelectedRows.Count > 0 Then
            Dim current_row As Integer = grd_updatestaff.SelectedRows(0).Index
            current_code = grd_updatestaff(0, current_row).Value.ToString()

            ' Populate text fields
            txt_staffID.Text = current_code

            If Not IsDBNull(grd_updatestaff(1, current_row).Value) Then
                txt_staffname.Text = grd_updatestaff(1, current_row).Value.ToString()
            Else
                txt_staffname.Text = ""
            End If

            ' Check for DBNull before assigning values to avoid potential issues
            If Not IsDBNull(grd_updatestaff(2, current_row).Value) Then
                txt_contactnumber.Text = grd_updatestaff(2, current_row).Value.ToString()
            Else
                txt_contactnumber.Text = ""
            End If

            If Not IsDBNull(grd_updatestaff(3, current_row).Value) Then
                txt_email.Text = grd_updatestaff(3, current_row).Value.ToString()
            Else
                txt_email.Text = ""
            End If
        End If
    End Sub

    Private Sub run_sql_command(thissql As String)
        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If grd_updatestaff.SelectedRows.Count > 0 Then
            Try
                ' Update the customer data based on user input
                Dim update_sql As String = "UPDATE TBL_STAFF_A193067 SET " &
                "FLD_STAFF_NAME=?, " &
                "FLD_STAFF_CONTACT=?, " &
                "FLD_STAFF_EMAIL=? " &
                "WHERE FLD_STAFF_ID=?"

                Using mywriter As New OleDb.OleDbCommand(update_sql, myconnection)
                    ' Set parameters
                    mywriter.Parameters.AddWithValue("?", txt_staffname.Text)
                    mywriter.Parameters.AddWithValue("?", txt_contactnumber.Text)
                    mywriter.Parameters.AddWithValue("?", txt_email.Text)
                    mywriter.Parameters.AddWithValue("?", current_code)

                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                End Using

                Beep()
                MsgBox("The staff """ & current_code & """ has been successfully updated.")
                refresh_grid()
                clear_fields()
            Catch ex As Exception
                MsgBox("An error occurred while updating the staff: " & ex.Message)
            Finally
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()
                End If
            End Try
        Else
            MsgBox("Please select a staff to update.")
        End If
    End Sub



    Private Sub HandleGridEvent(sender As Object, e As EventArgs)
        ' Update text fields and display image
        get_current_code()
    End Sub

    Private Sub grd_updatestaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updatestaff.CellClick
        get_current_code()
    End Sub

End Class
