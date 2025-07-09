Public Class frm_makeorder_a193067
    Public myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")

    Private currentOrderID As String
    Private Sub frm_makeorder_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentOrderID = generate_ID()
        txt_orderID.Text = currentOrderID

        Dim productQuery As String = "SELECT DISTINCT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A193067"
        Dim productDataTable As DataTable = RunSqlQuery(productQuery)
        cmb_productID.DataSource = productDataTable
        cmb_productID.DisplayMember = "FLD_PRODUCT_ID"
        cmb_productID.ValueMember = "FLD_PRODUCT_ID"

        Dim custQuery As String = "SELECT DISTINCT FLD_CUST_ID FROM TBL_CUSTOMERS_A193067"
        Dim custDataTable As DataTable = RunSqlQuery(custQuery)
        cmb_customerID.DataSource = custDataTable
        cmb_customerID.DisplayMember = "FLD_CUST_ID"
        cmb_customerID.ValueMember = "FLD_CUST_ID"

        Dim staffQuery As String = "SELECT DISTINCT FLD_STAFF_ID FROM TBL_STAFF_A193067"
        Dim staffDataTable As DataTable = RunSqlQuery(staffQuery)
        cmb_staffID.DataSource = staffDataTable
        cmb_staffID.DisplayMember = "FLD_STAFF_ID"
        cmb_staffID.ValueMember = "FLD_STAFF_ID"
    End Sub

    Private Function generate_ID() As String
        Dim lastOrderIDQuery As String = "SELECT TOP 1 FLD_ORDERS_ID FROM TBL_ORDERS_A193067 ORDER BY FLD_ORDERS_ID DESC"
        Dim lastOrderIDResult As DataTable = RunSqlQuery(lastOrderIDQuery)

        If lastOrderIDResult.Rows.Count > 0 Then
            Dim lastOrderID As String = lastOrderIDResult.Rows(0)("FLD_ORDERS_ID")

            If Integer.TryParse(Mid(lastOrderID, 2), Nothing) Then
                Dim newID As Integer = Integer.Parse(Mid(lastOrderID, 2)) + 1
                Return "L" & newID.ToString().PadLeft(2, "0"c)
            Else
                ' Handle the case where Mid(lastOrderID, 2) is not a valid integer
                Return "L01"
            End If
        Else
            ' No rows in the result, generate a default order ID
            Return "L01"
        End If
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection.Open()
        mytransaction = myconnection.BeginTransaction

        Try
            ' Insert data into TBL_ORDERS_A193067
            Dim orderID As String = currentOrderID
            Dim productID As String = cmb_productID.SelectedValue?.ToString()
            Dim customerID As String = cmb_customerID.SelectedValue?.ToString()
            Dim staffID As String = cmb_staffID.SelectedValue?.ToString()
            Dim orderDateTime As String = txt_dateTime.Text

            If String.IsNullOrWhiteSpace(productID) OrElse String.IsNullOrWhiteSpace(customerID) OrElse String.IsNullOrWhiteSpace(staffID) Then
                MsgBox("Please select valid values for Product ID, Customer ID, and Staff ID.")
                Return
            End If

            Dim insertOrderQuery As String = "INSERT INTO TBL_ORDERS_A193067 (FLD_ORDERS_ID, FLD_ORDERS_CUST, FLD_ORDERS_PRODUCT, FLD_ORDERS_STAFF) " &
            "VALUES (@OrderID, @CustomerID, @ProductID, @StaffID)"

            Using insertOrderCommand As New OleDb.OleDbCommand(insertOrderQuery, myconnection, mytransaction)
                insertOrderCommand.Parameters.AddWithValue("@OrderID", orderID)
                insertOrderCommand.Parameters.AddWithValue("@CustomerID", customerID)
                insertOrderCommand.Parameters.AddWithValue("@ProductID", productID)
                insertOrderCommand.Parameters.AddWithValue("@StaffID", staffID)
                insertOrderCommand.ExecuteNonQuery()
            End Using

            ' Insert data into TBL_ORDERDETAILS_A193067
            Dim quantity As Integer

            If Integer.TryParse(txt_quantity.Text, quantity) Then
                Dim price As Double = GetProductPrice(productID)

                ' Calculate subtotal (which is the price of the product)
                Dim subTotal As Double = price

                Dim insertDetailsQuery As String = "INSERT INTO TBL_ORDERDETAILS_A193067 (FLD_ORDERS_ID, FLD_PRODUCT_ID, FLD_QUANTITY, FLD_DATE_TIME) " &
                "VALUES (@DetailsOrderID, @DetailsProductID, @DetailsQuantity, @DetailsOrderDateTime)"

                Using insertDetailsCommand As New OleDb.OleDbCommand(insertDetailsQuery, myconnection, mytransaction)
                    insertDetailsCommand.Parameters.AddWithValue("@DetailsOrderID", orderID)
                    insertDetailsCommand.Parameters.AddWithValue("@DetailsProductID", productID)
                    insertDetailsCommand.Parameters.AddWithValue("@DetailsQuantity", quantity)
                    insertDetailsCommand.Parameters.AddWithValue("@DetailsOrderDateTime", orderDateTime)

                    Try
                        insertDetailsCommand.ExecuteNonQuery()


                        ' Calculate and display total amount
                        Dim totalAmount As Double = price * quantity
                        txt_subTotal.Text = subTotal.ToString("C") ' Displaying the correct subtotal
                        txt_total.Text = totalAmount.ToString("C")



                        ' Check if the product exists
                        If Not ProductExists(productID) Then
                            MsgBox("Selected product does not exist. Please choose a valid product.")
                        End If

                        cmb_productID.SelectedIndex = -1
                        txt_quantity.Clear()

                        mytransaction.Commit()
                    Catch ex As Exception
                        ' Display detailed error message
                        MsgBox($"Error: {ex.Message}")
                        Beep()
                        MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
                        mytransaction.Rollback()
                        Throw
                    Finally
                        myconnection.Close()
                    End Try

                    ' Display inserted data in grd_order
                    RefreshGrid()

                End Using
            Else
                ' The conversion failed, show an error message or handle it accordingly
                MsgBox("Invalid quantity. Please enter a valid integer.")
            End If
        Catch ex As Exception
            ' Display any exception that occurs outside the Try block
            MsgBox($"Error: {ex.Message}")
        Finally
            myconnection.Close()
        End Try
    End Sub

    Private Sub RefreshGrid()
        ' Fetch the updated data from the database and bind it to grd_order
        Dim orderQuery As String = "SELECT * FROM TBL_ORDERS_A193067"
        Dim orderDataTable As DataTable = RunSqlQuery(orderQuery)

        ' Add debug statement to check if data is retrieved
        Debug.WriteLine($"Number of rows retrieved: {orderDataTable.Rows.Count}")

        grd_order.DataSource = orderDataTable
    End Sub

    Private Sub ClearForm()
        ' Implement your code to clear the form controls
        cmb_customerID.SelectedIndex = -1
        cmb_staffID.SelectedIndex = -1
        cmb_productID.SelectedIndex = -1
        txt_quantity.Clear()
        txt_dateTime.Clear() ' Clear the DateTime field
    End Sub

    Private Function ProductExists(productID As String) As Boolean
        Dim productQuery As String = $"SELECT COUNT(*) FROM TBL_PRODUCTS_A193067 WHERE FLD_PRODUCT_ID = '{productID}'"
        Dim count As Integer = Convert.ToInt32(RunSqlQuery(productQuery).Rows(0)(0))
        Return count > 0
    End Function


    Private Function GetProductPrice(productID As String) As Double
        Dim priceQuery As String = $"SELECT FLD_PRICE FROM TBL_PRODUCTS_A193067 WHERE FLD_PRODUCT_ID = '{productID}'"
        Dim priceDataTable As DataTable = RunSqlQuery(priceQuery)

        If priceDataTable.Rows.Count > 0 AndAlso priceDataTable.Rows(0)("FLD_PRICE") IsNot DBNull.Value Then
            Return Convert.ToDouble(priceDataTable.Rows(0)("FLD_PRICE"))
        Else
            Return 0.0 ' Or any default value if the product price is not found
        End If
    End Function

    Private Sub btn_makeOrder_Click(sender As Object, e As EventArgs) Handles btn_makeOrder.Click
        Dim viewOrderForm As New frm_vieworder_a193067()

        ' Set the Subtotal and Total properties before showing the form
        viewOrderForm.Subtotal = txt_subTotal.Text
        viewOrderForm.Total = txt_total.Text
        viewOrderForm.Show()

        ' Clear the necessary fields after making an order
        cmb_productID.SelectedIndex = -1
        txt_quantity.Clear()
        ClearForm()
    End Sub

    Private Sub btn_generateID_Click(sender As Object, e As EventArgs) Handles btn_generateID.Click
        currentOrderID = generate_ID()
        txt_orderID.Text = currentOrderID
    End Sub
End Class
