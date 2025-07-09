Public Class frm_insertCustomer_a193067

    Dim myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")
    Dim mydatatable As New DataTable

    Private Sub frm_insertCustomer_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_insertcustomer.DataSource = RunSqlQuery("SELECT * FROM TBL_CUSTOMERS_A193067")
        txt_customerID.Text = generate_id()
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = RunSqlQuery("SELECT MAX(FLD_CUST_ID) AS LASTID FROM TBL_CUSTOMERS_A193067").Rows(0).Item("LASTID")
        Dim newid As String = "C0" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMERS_A193067 (FLD_CUST_ID, FLD_CUST_NAME, FLD_CUST_CONTACT, FLD_CUST_EMAIL) " &
            "VALUES ('" & txt_customerID.Text & "', '" & txt_customername.Text & "', '" & txt_contactnumber.Text & "', '" & txt_email.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_insertcustomer.DataSource = RunSqlQuery("SELECT * FROM TBL_CUSTOMERS_A193067")
            txt_customerID.Text = generate_id()
            txt_customername.Text = ""
            txt_contactnumber.Text = ""
            txt_email.Text = ""

            MessageBox.Show("Data successfully inserted into the table!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub
End Class
