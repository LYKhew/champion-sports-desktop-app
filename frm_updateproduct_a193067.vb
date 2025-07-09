Public Class frm_updateproduct_a193067
    Dim current_code As String
    Dim myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")

    Private Sub frm_updateproduct_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler grd_updateproduct.CellClick, AddressOf HandleGridEvent
        AddHandler grd_updateproduct.SelectionChanged, AddressOf HandleGridEvent

        Dim genderQuery As String = "SELECT DISTINCT FLD_GENDER FROM TBL_PRODUCTS_A193067"
        Dim genderDataTable As DataTable = RunSqlQuery(genderQuery)
        cmb_gender.DataSource = genderDataTable
        cmb_gender.DisplayMember = "FLD_GENDER"
        cmb_gender.ValueMember = "FLD_GENDER" ' Set the ValueMember property

        Dim sizeQuery As String = "SELECT DISTINCT FLD_TYPE FROM TBL_PRODUCTS_A193067"
        Dim sizeDataTable As DataTable = RunSqlQuery(sizeQuery)
        cmb_type.DataSource = sizeDataTable
        cmb_type.DisplayMember = "FLD_TYPE"
        cmb_type.ValueMember = "FLD_TYPE" ' Set the ValueMember property

        refresh_grid()
    End Sub

    Private Sub grd_updateproduct_SelectionChanged(sender As Object, e As EventArgs) Handles grd_updateproduct.SelectionChanged
        ' Handle the selection changed event to update text fields and display image
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A193067"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_updateproduct.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_productID.Text = ""
        txt_produtname.Text = ""
        txt_price.Text = ""
        txt_size.Text = ""
        txt_quantity.Text = ""
        cmb_gender.SelectedIndex = -1
        cmb_type.SelectedIndex = -1
        pic_product.BackgroundImage = Nothing
    End Sub


    Private Sub get_current_code()
        If grd_updateproduct.SelectedRows.Count > 0 Then
            Dim current_row As Integer = grd_updateproduct.SelectedRows(0).Index
            current_code = grd_updateproduct(0, current_row).Value.ToString()

            ' Populate text fields
            txt_productID.Text = current_code

            If Not IsDBNull(grd_updateproduct(1, current_row).Value) Then
                txt_produtname.Text = grd_updateproduct(1, current_row).Value.ToString()
            Else
                txt_produtname.Text = ""
            End If

            ' Convert price and quantity to Decimal and Integer, respectively
            If Decimal.TryParse(grd_updateproduct(2, current_row).Value.ToString(), Nothing) Then
                txt_price.Text = grd_updateproduct(2, current_row).Value.ToString()
            Else
                txt_price.Text = "0" ' Default value if conversion fails
            End If

            If Integer.TryParse(grd_updateproduct(5, current_row).Value.ToString(), Nothing) Then
                txt_quantity.Text = grd_updateproduct(5, current_row).Value.ToString()
            Else
                txt_quantity.Text = "0" ' Default value if conversion fails
            End If

            txt_size.Text = grd_updateproduct(4, current_row).Value.ToString()

            ' Set combo box selections
            SetComboBoxSelection(cmb_gender, grd_updateproduct(6, current_row).Value.ToString())
            SetComboBoxSelection(cmb_type, grd_updateproduct(3, current_row).Value.ToString())

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

    Private Sub SetComboBoxSelection(comboBox As ComboBox, value As String)
        Dim itemIndex As Integer = -1
        For i As Integer = 0 To comboBox.Items.Count - 1
            If comboBox.GetItemText(comboBox.Items(i)) = value Then
                itemIndex = i
                Exit For
            End If
        Next

        If itemIndex <> -1 Then
            comboBox.SelectedIndex = itemIndex
        Else
            comboBox.SelectedIndex = -1
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

        If cmb_gender.SelectedIndex = -1 Then
            MsgBox("Please select a gender.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validate that a type is selected
        If cmb_type.SelectedIndex = -1 Then
            MsgBox("Please select a type.", MsgBoxStyle.Exclamation)
            Return
        End If

        If grd_updateproduct.SelectedRows.Count > 0 Then
            Try
                ' Update the product data based on user input
                Dim update_sql As String = "UPDATE TBL_PRODUCTS_A193067 SET " &
                    "FLD_PRODUCT_NAME='" & txt_produtname.Text & "', " &
                    "FLD_PRICE=" & CDbl(txt_price.Text) & ", " &
                    "FLD_SIZE='" & txt_size.Text & "', " &
                    "FLD_QUANTITY=" & CInt(txt_quantity.Text) & ", " &
                    "FLD_TYPE='" & cmb_type.SelectedValue.ToString() & "', " & ' Use cmb_type
                    "FLD_GENDER='" & cmb_gender.SelectedValue.ToString() & "' " & ' Use cmb_gender
                    "WHERE FLD_PRODUCT_ID='" & current_code & "'"

                run_sql_command(update_sql)
                Beep()
                MsgBox("The product """ & current_code & """ has been successfully updated.")
                refresh_grid()
                clear_fields()
            Catch ex As Exception
                MsgBox("An error occurred while updating the product: " & ex.Message)
            End Try
        Else
            MsgBox("Please select a product to update.")
        End If
    End Sub

    Private Sub HandleGridEvent(sender As Object, e As EventArgs)
        ' Update text fields and display image
        get_current_code()
    End Sub

    Private Sub grd_updateproduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_updateproduct.CellClick
        get_current_code()
    End Sub
End Class
