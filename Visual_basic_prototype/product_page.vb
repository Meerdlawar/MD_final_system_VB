Imports System.Data.OleDb

Public Class product_page
    Dim ID As String = ""
    Dim str As String

    Private Sub product_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' the sub loadDatagirdView is called
        loadDatagridView()
    End Sub

    Public Sub loadDatagridView()
        controls1()
        ' try catch implemented to display user friendly message incase the query fails
        Try
            ' clears all the rows in the data grid view
            productDGV.Rows.Clear()
            ' query that selects everything in the tblproducts table
            GLOBALS.myqry = "SELECT * FROM tblProducts"
            ' a new command is set up
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' the data reader executes the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

            ' adds all the data in tblproducts inside their respective rows
            While GLOBALS.mydr.Read
                productDGV.Rows.Add(GLOBALS.mydr.Item("productID"), GLOBALS.mydr.Item("product_name"), (FormatCurrency(GLOBALS.mydr.Item("product_price"))), GLOBALS.mydr.Item("product_type"), GLOBALS.mydr.Item("product_suitability"))
            End While

            ' displays message if query fails
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddRecord()
        If txtProductName.Text = "" Or txtProductPrice.Text = "" Or txtProductType.Text = "" Or txtDietInquiries.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' try catch that displays an error message if the query fails
            Try
                ' query inserts data into the respective fields using parameters to avoid SQL injeciton
                GLOBALS.myqry = "INSERT INTO tblProducts([product_name], [product_price], [product_type], [product_suitability]) VALUES(?,?,?,?)"
                ' a new command is setup using the query and connection string
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                ' parameters are added
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_name", txtProductName.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_price", txtProductPrice.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_type", txtProductType.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_suitability", txtDietInquiries.Text))

                ' a non query using the new command and the parmeters within
                With GLOBALS.mycmd
                    .CommandText = GLOBALS.myqry
                    .Connection = GLOBALS.conn
                    .ExecuteNonQuery()
                End With
                ' try catch message is displayed

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ' load data grid view function is called
            loadDatagridView()
            cleartxtbox()
        End If
    End Sub

    Private Sub DeleteRecord()
        ' try catch incase query fails
        Try
            'message box displayed verfies whether the user wants to delete the record
            ' if yes then it moves on to the DELETE query
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' the DELETE query checks the product ID and delete records related to that ID, uses parameters as well to stop SQL injection
                GLOBALS.myqry = "DELETE FROM tblProducts WHERE productID = @ID"
                ' a new OleDbCommand is created usin the query and connection string
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                ' parameter is added to th command
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@ID", ID))

                ' non query is executed
                With GLOBALS.mycmd
                    .CommandText = GLOBALS.myqry
                    .Connection = GLOBALS.conn
                    .ExecuteNonQuery()
                End With
            End If

        Catch ex As Exception
            ' display the error
            MessageBox.Show(ex.Message)
        End Try

        'textboxes are cleared
        cleartxtbox()
        ' Loads an updated version of the data grid view
        loadDatagridView()
    End Sub

    Private Sub EditRecord()
        ' displays error message if text boxes are empty
        If txtProductName.Text = "" Or txtProductPrice.Text = "" Or txtProductType.Text = "" Or txtDietInquiries.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                ' verifies with the user whether they want to edit a record
                If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'assign the insetion query
                    GLOBALS.myqry = "UPDATE tblProducts 
                     SET product_name = @product_name, product_price = @product_price, product_type = @product_type, product_suitability = @product_suitability
                     WHERE productID = @productID;"
                    'initialize a new database command
                    GLOBALS.mycmd = New OleDbCommand
                    'with the connamd var
                    With GLOBALS.mycmd
                        'assign the command text that is the query i built earlier
                        .CommandText = GLOBALS.myqry
                        'assign thedatabse that is to be connected too
                        .Connection = GLOBALS.conn
                        'assign the parameters in the query with the values from variables.
                        'this will help avoid sql injection
                        .Parameters.AddWithValue("@product_name", txtProductName.Text)
                        .Parameters.AddWithValue("@product_price", txtProductPrice.Text)
                        .Parameters.AddWithValue("@product_type", txtProductType.Text)
                        .Parameters.AddWithValue("@product_suitability", txtDietInquiries.Text)
                        .Parameters.AddWithValue("@productID", ID)
                        'Execute the command
                        .ExecuteNonQuery()
                        'end with
                    End With
                End If

            Catch ex As Exception
                ' display the error
                MessageBox.Show(ex.Message)
            End Try

            'certain buttons are disabled
            Call controls1()
            ' updates the data grid view with the new layout
            loadDatagridView()
            ' clears all textboxes
            cleartxtbox()
        End If
    End Sub

    Private Sub searchItem()
        ' when nothing is in the search textbox then all records from tblProducts are displayed
        If txtProductSearch.Text = "" Then
            loadDatagridView()
        Else
            ' try catch implemented in case the query fails
            Try
                ' clears all the rows in the data grid view
                productDGV.Rows.Clear()
                ' the query then selects any pieces of data that share the same characters in the textbox and uses parameters as it input
                GLOBALS.myqry = "SELECT * FROM tblProducts WHERE product_name LIKE @product OR product_type LIKE @type OR product_suitability LIKE @suitability;"
                ' a new command is created using the query and connection string
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                ' parameters are displayed
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@product", txtProductSearch.Text & "%"))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@product_suitability", txtProductSearch.Text & "%"))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@type", txtProductSearch.Text & "%"))
                ' data reader is then executed
                GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
                ' the data reader reads all values that are closely related to what's been searched in the textbox
                While GLOBALS.mydr.Read
                    productDGV.Rows.Add(GLOBALS.mydr.Item("productID"), GLOBALS.mydr.Item("product_name"), (FormatCurrency(GLOBALS.mydr.Item("product_price"))), GLOBALS.mydr.Item("product_type"), GLOBALS.mydr.Item("product_suitability"))
                End While


            Catch ex As Exception
                ' display the error
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cleartxtbox()
        'clears ID textbox
        ID = ""
        ' clears product name textbox
        txtProductName.Clear()
        ' clears product price textbox
        txtProductPrice.Clear()
        ' clears product type textbox
        txtProductType.Clear()
        ' clears diet inquiries textbox
        txtDietInquiries.Clear()
    End Sub

    Sub controls1()
        ' enables use of add button
        btnproductAdd.Enabled = True
        ' enables use of delete button
        btnproductDelete.Enabled = True
        ' enables use of back button
        btnproductBack.Enabled = True
        ' disables use of clear button
        btnProductClear.Enabled = False
        ' disables use of save button
        btnProductSave.Enabled = False
        ' disables use of cancel button
        btnProductCancel.Enabled = False

    End Sub

    Sub controls2()
        ' enables use of save button
        btnProductSave.Enabled = True
        ' enables use of cancel button
        btnProductCancel.Enabled = True
        'enables use of clear button
        btnProductClear.Enabled = True
    End Sub

    Sub saveFunc()
        ' if ID textbox has is not empty controls 2 is enabled
        If ID <> "" Then
            Call controls2()
        Else
            'controls 1 is enabled otherwise
            Call controls1()
        End If
    End Sub

    Private Sub productDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productDGV.CellContentClick
        ' the product ID textbox is associated with row 0
        ID = productDGV.CurrentRow.Cells(0).Value.ToString
        ' the product name textbox is associated with row 1
        txtProductName.Text = productDGV.CurrentRow.Cells(1).Value.ToString
        ' the product price textbox is associated with row 2
        txtProductPrice.Text = productDGV.CurrentRow.Cells(2).Value.ToString
        ' the product type textbox is associated with row 3
        txtProductType.Text = productDGV.CurrentRow.Cells(3).Value.ToString
        ' the diet inquiries textbox is associated with row 4
        txtDietInquiries.Text = productDGV.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub btnProductSave_Click(sender As Object, e As EventArgs) Handles btnProductSave.Click
        ' edit record funtion is called
        EditRecord()
    End Sub

    Private Sub btnProductCancel_Click(sender As Object, e As EventArgs) Handles btnProductCancel.Click
        ' clears all textboces
        cleartxtbox()
        ' controls1 is enabled
        Call controls1()
    End Sub

    Private Sub btnproductDelete_Click(sender As Object, e As EventArgs) Handles btnproductDelete.Click
        ' when the delete button is clicked a record is deleted
        DeleteRecord()
    End Sub

    Private Sub btnProductClear_Click(sender As Object, e As EventArgs) Handles btnProductClear.Click
        ' clears all the text boxes
        cleartxtbox()
    End Sub

    Private Sub txtProductSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProductSearch.TextChanged
        ' search function is called
        searchItem()
    End Sub

    Private Sub btnproductBack_Click(sender As Object, e As EventArgs) Handles btnproductBack.Click
        ' displays main menu
        main_menu.Show()
        ' hides the current page
        Me.Hide()
    End Sub

    Private Sub btnproductAdd_Click(sender As Object, e As EventArgs) Handles btnproductAdd.Click
        ' add record funtion is called
        AddRecord()
    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged
        ' saveFunc is called
        saveFunc()
    End Sub

    Private Sub txtProductPrice_TextChanged(sender As Object, e As EventArgs) Handles txtProductPrice.TextChanged
        ' saveFun is called
        saveFunc()
    End Sub

    Private Sub txtProductType_TextChanged(sender As Object, e As EventArgs) Handles txtProductType.TextChanged
        ' saveFunc is called
        saveFunc()
    End Sub

    Private Sub txtDietInquiries_TextChanged(sender As Object, e As EventArgs) Handles txtDietInquiries.TextChanged
        ' saveFunc is called
        saveFunc()
    End Sub

    Private Sub txtProductPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductPrice.KeyPress
        ' does not allow the input of any characters other than backspace
        If e.KeyChar <> ChrW(Keys.Back) Then
            ' if a number key is clicked then it is inputted into the textbox
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDietInquiries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDietInquiries.KeyPress
        ' does not allow the input of any characters other than backspace
        If e.KeyChar <> ChrW(Keys.Back) Then
            ' if a letter key is clicked then it is inputted into the textbox
            If Char.IsLetter(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtProductName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductName.KeyPress
        ' does not allow the input of any characters other than backspace
        If e.KeyChar <> ChrW(Keys.Back) Then
            ' If a letter key is clicked then it is inputted into the textbox
            If Char.IsLetter(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtProductType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductType.KeyPress
        ' does not allow the input of any characters other than backspace
        If e.KeyChar <> ChrW(Keys.Back) Then
            ' if a letter key is clicked then it is inputted into the textbox
            If Char.IsLetter(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class