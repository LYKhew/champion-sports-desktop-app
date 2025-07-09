Public Class frm_mainmenu_a193067
    Private Sub frm_mainmenu_a193067_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        MsgBox("Thank you for visiting our store. Come again next time!")
        Me.Hide()
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a193067.Show()
    End Sub

    Private Sub btn_Customer_Click(sender As Object, e As EventArgs) Handles btn_Customer.Click
        frm_customer_a193067.Show()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a193067.Show()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a193067.Show()
    End Sub

    Private Sub btn_orderdetails_Click(sender As Object, e As EventArgs) Handles btn_orderdetails.Click
        frm_orderdetails_a193067.Show()
    End Sub

End Class
