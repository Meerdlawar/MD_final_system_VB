Public Class main_menu
    Private Sub btnproducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        'product_edit_page.Show()
        product_page.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomer_order_history_Click(sender As Object, e As EventArgs) Handles btnCustomer_order_history.Click
        ' shows the order_history page
        order_history.Show()
        ' hides the current page
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' closes the entire application
        Application.Exit()
        End
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ' hides the current page
        Me.Hide()
        ' shows the customer page
        customer_page.Show()
    End Sub

    Private Sub btnPrint_allegies_info_Click(sender As Object, e As EventArgs) Handles btnPrint_allegies_info.Click
        ' hides the current page
        Me.Hide()
        ' shows the print allergies information page
        printAllergiesInformationPage.Show()
    End Sub
End Class

