Public Class frm_vieworder_a193067
    Public myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")
    Private _total As Double
    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
            ' Optionally, update a label or other UI element to display the total
            txt_total.Text = value.ToString("C")
        End Set
    End Property

    Private _subtotal As Double
    Public Property Subtotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property

    Private Sub frm_vieworder_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_subtotal.Text = Subtotal.ToString("C")
        txt_total.Text = Total.ToString("C")
        RefreshGrid()

    End Sub


    Private Sub RefreshGrid()
        ' Fetch the updated data from the database and bind it to grd_orderdetails
        Dim orderQuery As String = "SELECT OD.*, O.FLD_ORDERS_CUST, O.FLD_ORDERS_STAFF FROM TBL_ORDERDETAILS_A193067 OD " &
    "INNER JOIN TBL_ORDERS_A193067 O ON OD.FLD_ORDERS_ID = O.FLD_ORDERS_ID"

        Dim orderDataTable As DataTable = RunSqlQuery(orderQuery)

        ' Add debug statement to check if data is retrieved
        Debug.WriteLine($"Number of rows retrieved: {orderDataTable.Rows.Count}")

        grd_orderdetails.DataSource = orderDataTable
    End Sub


End Class