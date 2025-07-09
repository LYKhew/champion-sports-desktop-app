Public Class frm_product_a193067
    Private Sub frm_product_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info = False;"

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A193067"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable
    End Sub

    Private Sub btn_viewproduct_Click(sender As Object, e As EventArgs) Handles btn_viewproduct.Click
        frm_viewproduct_a193067.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertproduct_a193067.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproduct_a193067.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        frm_deleteproduct_a193067.Show()
        Me.Hide()
    End Sub
End Class