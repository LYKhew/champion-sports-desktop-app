Public Class frm_deleteproduct_a193067
    Dim current_code As String
    Dim myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")

    Private Sub frm_deleteproduct_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler grd_deleteproduct.CellClick, AddressOf HandleGridEvent
        AddHandler grd_deleteproduct.SelectionChanged, AddressOf HandleGridEvent
        refresh_grid()
    End Sub

    Private Sub grd_deleteproduct_SelectionChanged(sender As Object, e As EventArgs) Handles grd_deleteproduct.SelectionChanged
        ' Handle the selection changed event to update text fields and display image
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A193067"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_deleteproduct.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_productID.Text = ""
        txt_produtname.Text = ""
        txt_price.Text = ""
        txt_gender.Text = ""
        txt_size.Text = ""
        txt_type.Text = ""
        txt_quantity.Text = ""  ' Clear the quantity textbox
        pic_product.BackgroundImage = Nothing
    End Sub


    Private Sub get_current_code()
        If grd_deleteproduct.SelectedRows.Count > 0 Then
            Dim current_row As Integer = grd_deleteproduct.SelectedRows(0).Index
            current_code = grd_deleteproduct(0, current_row).Value.ToString()

            ' Populate text fields
            txt_productID.Text = current_code

            If Not IsDBNull(grd_deleteproduct(1, current_row).Value) Then
                txt_produtname.Text = grd_deleteproduct(1, current_row).Value.ToString()
            Else
                txt_produtname.Text = ""
            End If

            ' Convert price and quantity to Integer
            If Decimal.TryParse(grd_deleteproduct(2, current_row).Value.ToString(), Nothing) Then
                txt_price.Text = grd_deleteproduct(2, current_row).Value.ToString()
            Else
                txt_price.Text = "0" ' Default value if conversion fails
            End If

            If Integer.TryParse(grd_deleteproduct(5, current_row).Value.ToString(), Nothing) Then
                txt_quantity.Text = grd_deleteproduct(5, current_row).Value.ToString()
            Else
                txt_quantity.Text = "0" ' Default value if conversion fails
            End If

            txt_type.Text = grd_deleteproduct(3, current_row).Value.ToString()
            txt_size.Text = grd_deleteproduct(4, current_row).Value.ToString()
            txt_gender.Text = grd_deleteproduct(6, current_row).Value.ToString()

            ' Display image if available
            Try
                Dim imagePath As String = "pictures\" & current_code & ".jpg"
                If System.IO.File.Exists(imagePath) Then
                    pic_product.BackgroundImage = Image.FromFile(imagePath)
                Else
                    ' Handle case where image file is not found
                    pic_product.BackgroundImage = Nothing
                    MessageBox.Show("Image file not found: " & imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                ' Handle exception when loading image
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
        If grd_deleteproduct.SelectedRows.Count > 0 Then
            Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product? """ & current_code & """?", MsgBoxStyle.YesNo)
            If delete_confirmation = MsgBoxResult.Yes Then
                Try
                    run_sql_command("DELETE FROM TBL_PRODUCTS_A193067 WHERE FLD_PRODUCT_ID='" & current_code & "'")
                    Beep()
                    MsgBox("The product """ & current_code & """ has been successfully deleted.")
                    refresh_grid()
                    clear_fields()
                Catch ex As Exception
                    MsgBox("An error occurred while deleting the product: " & ex.Message)
                End Try
            End If
        Else
            MsgBox("Please select a product to delete.")
        End If
    End Sub

    Private Sub HandleGridEvent(sender As Object, e As EventArgs)
        ' Update text fields and display image
        get_current_code()
    End Sub

    Private Sub grd_deleteproduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_deleteproduct.CellClick
        get_current_code()
    End Sub

End Class
