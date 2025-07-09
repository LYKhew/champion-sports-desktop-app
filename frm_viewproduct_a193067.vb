
Public Class frm_viewproduct_a193067

    Public myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")
    Private Sub frm_viewproduct_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A193067"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_productID.DataSource = mydatatable
        cmb_productID.DisplayMember = "FLD_PRODUCT_ID"
        refresh_grid(cmb_productID.Text)
    End Sub

    Private Sub refresh_grid(product_ID As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A193067 WHERE FLD_PRODUCT_ID='" & product_ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        If mydatatable.Rows.Count > 0 Then
            txt_productName.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
            txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
            txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
            txt_size.Text = mydatatable.Rows(0).Item("FLD_SIZE")
            txt_gender.Text = mydatatable.Rows(0).Item("FLD_GENDER")
            txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")

            Try
                Dim imagePath As String = "pictures/" & cmb_productID.Text & ".jpg"
                If System.IO.File.Exists(imagePath) Then
                    pic_products.BackgroundImage = Image.FromFile(imagePath)
                Else
                    ' Handle case where image file is not found
                    pic_products.BackgroundImage = Nothing
                End If
            Catch ex As Exception
                ' Handle exception when loading image
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cmb_productID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_productID.SelectedIndexChanged
        refresh_grid(cmb_productID.Text)
    End Sub
End Class
