Public Class frm_updatecustomer_a193067

    Dim current_code As String
    Dim myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")

    Private Sub frm_updatecustomer_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler grd_updatecustomer.CellClick, AddressOf HandleGridEvent
        AddHandler grd_updatecustomer.SelectionChanged, AddressOf HandleGridEvent
        refresh_grid()
    End Sub

    Private Sub grd_updatecustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updatecustomer.CellContentClick
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A193067"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_updatecustomer.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_customerID.Text = ""
        txt_customername.Text = ""
        txt_contactnumber.Text = ""
        txt_email.Text = ""
    End Sub

    Private Sub get_current_code()
        If grd_updatecustomer.SelectedRows.Count > 0 Then
            Dim current_row As Integer = grd_updatecustomer.SelectedRows(0).Index
            current_code = grd_updatecustomer(0, current_row).Value.ToString()

            ' Populate text fields
            txt_customerID.Text = current_code

            If Not IsDBNull(grd_updatecustomer(1, current_row).Value) Then
                txt_customername.Text = grd_updatecustomer(1, current_row).Value.ToString()
            Else
                txt_customername.Text = ""
            End If

            ' Check for DBNull before assigning values to avoid potential issues
            If Not IsDBNull(grd_updatecustomer(2, current_row).Value) Then
                txt_contactnumber.Text = grd_updatecustomer(2, current_row).Value.ToString()
            Else
                txt_contactnumber.Text = ""
            End If

            If Not IsDBNull(grd_updatecustomer(3, current_row).Value) Then
                txt_email.Text = grd_updatecustomer(3, current_row).Value.ToString()
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
        If grd_updatecustomer.SelectedRows.Count > 0 Then
            Try
                ' Update the customer data based on user input
                Dim update_sql As String = "UPDATE TBL_CUSTOMERS_A193067 SET " &
                "FLD_CUST_NAME=?, " &
                "FLD_CUST_CONTACT=?, " &
                "FLD_CUST_EMAIL=? " &
                "WHERE FLD_CUST_ID=?"

                Using mywriter As New OleDb.OleDbCommand(update_sql, myconnection)
                    ' Set parameters
                    mywriter.Parameters.AddWithValue("?", txt_customername.Text)
                    mywriter.Parameters.AddWithValue("?", txt_contactnumber.Text)
                    mywriter.Parameters.AddWithValue("?", txt_email.Text)
                    mywriter.Parameters.AddWithValue("?", current_code)

                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                End Using

                Beep()
                MsgBox("The customer """ & current_code & """ has been successfully updated.")
                refresh_grid()
                clear_fields()
            Catch ex As Exception
                MsgBox("An error occurred while updating the customer: " & ex.Message)
            Finally
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()
                End If
            End Try
        Else
            MsgBox("Please select a customer to update.")
        End If
    End Sub



    Private Sub HandleGridEvent(sender As Object, e As EventArgs)
        ' Update text fields and display image
        get_current_code()
    End Sub

    Private Sub grd_updatecustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updatecustomer.CellClick
        get_current_code()
    End Sub

End Class