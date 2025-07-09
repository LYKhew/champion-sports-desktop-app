Public Class frm_orderdetails_a193067
    Private Sub frm_orderdetails_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info = False;"

        Dim mysql As String = "SELECT * FROM TBL_ORDERDETAILS_A193067"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_orderdetails.DataSource = mydatatable
    End Sub
End Class