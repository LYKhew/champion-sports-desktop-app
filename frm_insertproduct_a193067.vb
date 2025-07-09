Public Class frm_insertproduct_a193067

    Dim myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")
    Dim mydatatable As New DataTable
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"


    Private Sub frm_insertproduct_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenFileDialog1 = New OpenFileDialog()
        grd_insertproduct.DataSource = RunSqlQuery("SELECT * FROM TBL_PRODUCTS_A193067")
        txt_productID.Text = generate_id()
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

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

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = RunSqlQuery("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A193067").Rows(0).Item("LASTID")
        Dim newid As String = "P" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If Not Double.TryParse(txt_price.Text, Nothing) Then
            MsgBox("Please enter a valid numeric value for Price.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validate numeric input for quantity
        If Not Integer.TryParse(txt_quantity.Text, Nothing) Then
            MsgBox("Please enter a valid numeric value for Quantity.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validate that a gender is selected
        If cmb_gender.SelectedIndex = -1 Then
            MsgBox("Please select a gender.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validate that a type is selected
        If cmb_type.SelectedIndex = -1 Then
            MsgBox("Please select a type.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A193067 (FLD_PRODUCT_ID, FLD_PRODUCT_NAME, FLD_PRICE, FLD_SIZE, FLD_QUANTITY, FLD_TYPE, FLD_GENDER) " &
        "VALUES ('" & txt_productID.Text & "', '" & txt_produtname.Text & "', " & CDbl(txt_price.Text) & ", '" & txt_size.Text & "', " & CInt(txt_quantity.Text) & ", '" & cmb_type.SelectedValue.ToString() & "', '" & cmb_gender.SelectedValue.ToString() & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection)
        Dim destinationFilePath As String = System.IO.Path.Combine(Application.StartupPath, "pictures", txt_productID.Text & ".jpg")

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_insertproduct.DataSource = RunSqlQuery("SELECT * FROM TBL_PRODUCTS_A193067")
            txt_productID.Text = generate_id()
            txt_produtname.Text = ""
            txt_price.Text = ""
            txt_size.Text = ""
            txt_quantity.Text = ""

            ' Clear ComboBox selections
            cmb_type.SelectedIndex = -1
            cmb_gender.SelectedIndex = -1

            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            System.IO.File.Copy(OpenFileDialog1.FileName, destinationFilePath, True)

            MessageBox.Show("Data successfully inserted into the table!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub


    Private Sub btn_selectpic_Click(sender As Object, e As EventArgs) Handles btn_selectpic.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = " "
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        End If
    End Sub


    Private Function RunSqlQuery(query As String) As DataTable
        Dim adapter As New OleDb.OleDbDataAdapter(query, myconnection)
        Dim resultDataTable As New DataTable()

        Try
            adapter.Fill(resultDataTable)
        Catch ex As Exception
            Beep()
            MsgBox("Error executing SQL query: " & ex.Message)
        End Try

        Return resultDataTable
    End Function

End Class


