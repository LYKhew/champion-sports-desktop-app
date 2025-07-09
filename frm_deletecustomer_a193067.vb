Public Class frm_deletecustomer_a193067

    Dim current_code As String
    Dim myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")

    Private Sub frm_deletecustomer_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler grd_deletecustomer.CellClick, AddressOf HandleGridEvent
        AddHandler grd_deletecustomer.SelectionChanged, AddressOf HandleGridEvent
        refresh_grid()
    End Sub

    Private Sub grd_deletecustomer_SelectionChanged(sender As Object, e As EventArgs) Handles grd_deletecustomer.SelectionChanged
        ' Handle the selection changed event to update text fields and display image
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A193067"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_deletecustomer.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()
        txt_customerID.Text = ""
        txt_customername.Text = ""
        txt_contactnumber.Text = ""
        txt_email.Text = ""
    End Sub
    Private Sub get_current_code()
        If grd_deletecustomer.SelectedRows.Count > 0 Then
            Dim current_row As Integer = grd_deletecustomer.SelectedRows(0).Index
            current_code = grd_deletecustomer(0, current_row).Value.ToString()

            ' Populate text fields
            txt_customerID.Text = current_code

            If Not IsDBNull(grd_deletecustomer(1, current_row).Value) Then
                txt_customername.Text = grd_deletecustomer(1, current_row).Value.ToString()
            Else
                txt_customername.Text = ""
            End If

            ' Check for DBNull before assigning values to avoid potential issues
            If Not IsDBNull(grd_deletecustomer(2, current_row).Value) Then
                txt_contactnumber.Text = grd_deletecustomer(2, current_row).Value.ToString()
            Else
                txt_contactnumber.Text = ""
            End If

            If Not IsDBNull(grd_deletecustomer(3, current_row).Value) Then
                txt_email.Text = grd_deletecustomer(3, current_row).Value.ToString()
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

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If grd_deletecustomer.SelectedRows.Count > 0 Then
            Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer? """ & current_code & """?", MsgBoxStyle.YesNo)
            If delete_confirmation = MsgBoxResult.Yes Then
                Try
                    run_sql_command("DELETE FROM TBL_CUSTOMERS_A193067 WHERE FLD_CUST_ID='" & current_code & "'")
                    Beep()
                    MsgBox("The customer """ & current_code & """ has been successfully deleted.")
                    refresh_grid()
                    clear_fields()
                Catch ex As Exception
                    MsgBox("An error occurred while deleting the customer: " & ex.Message)
                End Try
            End If
        Else
            MsgBox("Please select a customer to delete.")
        End If
    End Sub

    Private Sub HandleGridEvent(sender As Object, e As EventArgs)
        ' Update text fields and display image
        get_current_code()
    End Sub

    Private Sub grd_deletecustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_deletecustomer.CellClick
        get_current_code()
    End Sub

End Class