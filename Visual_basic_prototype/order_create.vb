Imports System.Data.OleDb

Public Class order_create
    ' variable totalbalance is perdefined as a decimal and value of 0
    Dim totalbalance As Decimal = 0

    Private Sub order_create_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Shared Function cmbProductOrderPopulate()
        ' try catch implemented to prevent the program from stopping if the query fails
        Try
            GLOBALS.myqry = "SELECT product_name FROM tblProducts;"
            ' a new command is set up
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' the data reader executes the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

            While GLOBALS.mydr.Read
                order_create.cmbProductOrder.Items.Add(GLOBALS.mydr("product_name"))
            End While

            ' displays message if query fails
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Shared Function cmbCustomerOrderPopulate()
        Try
            GLOBALS.myqry = "SELECT full_name FROM tblCustomers;"
            ' a new command is set up
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' the data reader executes the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

            order_create.cmbCustomerOrder.Items.Add("New Customer")
            While GLOBALS.mydr.Read
                order_create.cmbCustomerOrder.Items.Add(GLOBALS.mydr("full_name"))
            End While

            ' displays message if query fails
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Private Sub addProductDGV()
        ' checks if an item in the combo box has been seleceted
        If cmbProductOrder.SelectedIndex > -1 Then
            ' Declares index1 as integer 0
            Dim index1 As Integer = 0
            ' index is assigned the index of whats been selected in the combo box
            index1 = cmbProductOrder.SelectedIndex
            ' Declared items as an object
            Dim item1 As Object
            ' item1 is assigned the items that has been selected in the combo box
            item1 = cmbProductOrder.SelectedItem
            Try
                GLOBALS.myqry = "SELECT * FROM tblProducts WHERE product_name LIKE @product;"
                'initialising a new command with the connection and query with it
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@product", item1 & "%"))
                'initialising the Data reader with the command
                GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
                'while the data reader is reading
                While GLOBALS.mydr.Read
                    orderCreateDGV.Rows.Add(GLOBALS.mydr.Item("productID"), GLOBALS.mydr.Item("product_name"), (FormatCurrency(GLOBALS.mydr.Item("product_price"))), GLOBALS.mydr.Item("product_type"), GLOBALS.mydr.Item("product_suitability"))
                End While
                'End while
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            totalPrice()
        End If
    End Sub

    Private Sub addOrder()
        ' variable customerID declared as integer
        Dim customerID As Integer
        Try
            GLOBALS.myqry = "SELECT customerID from tblCustomers WHERE full_name = @customerName"
            'initialising a new command with the connection and query with it
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@customerName", cmbCustomerOrder.Text))
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            'while the data reader is reading
            While GLOBALS.mydr.Read
                ' the variable customer ID is assigned the data thats been retrieved in the data reader
                customerID = GLOBALS.mydr("customerID")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GLOBALS.myqry = "INSERT INTO tblOrders([customerID], [total_price], [method_of_payment], [order_Placed], [order_due], [comments]) VALUES(?,?,?,?,?,?)"
            ' a new command is set up
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' the data reader executes the command
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("customerID", customerID)).ToString()
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("total_price", totalbalance)).ToString()
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("method_of_payment", cmbPaymentMethod.Text)).ToString()
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("order_Placed", DateTimePickerPlaced.Text)).ToString()
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("order_due", DateTimePickerDue.Text)).ToString()
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("comments", txtboxComments.Text)).ToString()
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            MsgBox("Successfully added to database.")
            order_history.loadOrderDGV()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub addOrderProduct()
        ' variable order_ID is predefined as a String and an empty value
        Dim order_ID As String = ""
        Try
            GLOBALS.myqry = "SELECT TOP 1 orderID FROM tblOrders ORDER BY orderID DESC"
            'initialising a new command with the connection and query with it
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            ' while the data reader is reading 
            While GLOBALS.mydr.Read
                ' variable order_ID is assgiend what the data reader has read from the database
                order_ID = GLOBALS.mydr("orderID").ToString()
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' try catch that displays an error message if the query fails
        Try
            ' loops as many times as there are rows
            For Each row As DataGridViewRow In orderCreateDGV.Rows
                ' query inserts data into the respective fields using parameters to avoid SQL injeciton
                GLOBALS.myqry = "INSERT INTO orderProducts([orderID], [productID]) VALUES(?,?);"
                ' a new command is setup using the query and connection string
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                ' parameters are added
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("orderID", order_ID))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("productID", row.Cells("productID").Value))


                ' a non query using the new command and the parmeters within
                With GLOBALS.mycmd
                    .CommandText = GLOBALS.myqry
                    .Connection = GLOBALS.conn
                    .ExecuteNonQuery()
                End With
                ' try catch message is displayed
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub totalPrice()
        ' variable is assigned the value 0 
        totalbalance = 0
        ' loops the same amount of times as there rows
        For Each R As DataGridViewRow In orderCreateDGV.Rows
            ' the value in the cell is added onto what is previously in totalbalance
            totalbalance += R.Cells(2).Value
        Next
        ' the labels text is displays the totalbalance
        lblTotalPrice.Text = "Total Price:" & "" & totalbalance
    End Sub

    Shared Function populateDGV()
        order_create.orderCreateDGV.Rows.Clear()
        Try
            GLOBALS.myqry = "SELECT tblProducts.*
                             FROM tblProducts INNER JOIN (tblOrders INNER JOIN orderProducts ON tblOrders.orderID = orderProducts.orderID)
                             ON tblProducts.productID = orderProducts.productID WHERE tblOrders.orderID = @order;"
            'initialising a new command with the connection and query with it
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@order", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            'while the data reader is reading
            While GLOBALS.mydr.Read
                order_create.orderCreateDGV.Rows.Add(GLOBALS.mydr.Item("productID"), GLOBALS.mydr.Item("product_name"), (FormatCurrency(GLOBALS.mydr.Item("product_price"))), GLOBALS.mydr.Item("product_type"), GLOBALS.mydr.Item("product_suitability"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        order_create.totalPrice()
        Return ""
    End Function

    Shared Function populatecombobox()
        Try
            GLOBALS.myqry = "SELECT tblCustomers.full_name
                             FROM tblCustomers INNER JOIN tblOrders
                             ON tblCustomers.customerID = tblOrders.customerID WHERE tblOrders.orderID = @order;"

            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@order", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read
                order_create.cmbCustomerOrder.Text = (GLOBALS.mydr("full_name"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GLOBALS.myqry = "SELECT method_of_payment FROM tblOrders WHERE tblOrders.orderID = @order;"

            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@order", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read
                order_create.cmbPaymentMethod.Text = (GLOBALS.mydr("method_of_payment"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Shared Function populateDataTimePicker()
        Try
            GLOBALS.myqry = "SELECT order_Placed FROM tblOrders WHERE tblOrders.orderID = @order;"

            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@order", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read
                order_create.DateTimePickerPlaced.Value = (GLOBALS.mydr("order_placed"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GLOBALS.myqry = "SELECT order_due FROM tblOrders WHERE tblOrders.orderID = @order;"

            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@order", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read
                order_create.DateTimePickerDue.Value = (GLOBALS.mydr("order_due"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Shared Function populatetxtbox()
        Try
            GLOBALS.myqry = "SELECT comments FROM tblOrders WHERE tblOrders.orderID = @order;"

            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@order", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))
            'initialising the Data reader with the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read
                order_create.txtboxComments.Text = (GLOBALS.mydr("comments"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Shared Function access()
        ' the create button is disabled
        order_create.btnCreate.Enabled = False
        ' the remove buttons is enabled
        order_create.btnremove.Enabled = True
        ' the save button is enabled
        order_create.btnSaveOrder.Enabled = True
        Return ""
    End Function

    Shared Function editOrder()
        ' displays error message if text boxes are empty
        If order_create.cmbCustomerOrder.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim customerID As Integer
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    GLOBALS.myqry = "SELECT customerID from tblCustomers WHERE full_name = @customerName"
                    GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                    GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@customerName", order_create.cmbCustomerOrder.Text))
                    GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
                    'customerID = GLOBALS.mydr("customerID")
                    While GLOBALS.mydr.Read
                        customerID = GLOBALS.mydr("customerID")
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    ' verifies with the user whether they want to edit a record

                    'assign the insetion query
                    GLOBALS.myqry = "UPDATE tblOrders
                         SET customerID = @customerID, total_price = @total_price, method_of_payment = @method_of_payment, order_Placed = @order_Placed, order_due = @order_due, comments = @comments
                         WHERE orderID = @orderID;"
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
                        .Parameters.AddWithValue("@customerID", customerID)
                        .Parameters.AddWithValue("@total_price", order_create.totalbalance)
                        .Parameters.AddWithValue("@method_of_payment", order_create.cmbPaymentMethod.Text)
                        .Parameters.AddWithValue("@order_Placed", order_create.DateTimePickerPlaced.Value)
                        .Parameters.AddWithValue("@order_due", order_create.DateTimePickerDue.Value)
                        .Parameters.AddWithValue("@comments", order_create.txtboxComments.Text)
                        .Parameters.AddWithValue("@orderID", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString())
                        'Execute the command
                        .ExecuteNonQuery()
                        'end with
                    End With

                Catch ex As Exception
                    ' display the error
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
        Return ""
    End Function

    Shared Function editOrderProduct()
        Try
            'the DELETE query checks the order ID and delete records related to that ID, uses parameters as well to stop SQL injection
            GLOBALS.myqry = "DELETE * FROM orderProducts WHERE orderID = @orderID"
            ' a new OleDbCommand is created usin the query and connection string
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' parameter is added to th command
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@orderID", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))

            ' non query is executed
            With GLOBALS.mycmd
                .CommandText = GLOBALS.myqry
                .Connection = GLOBALS.conn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            ' display the error
            MessageBox.Show(ex.Message)
        End Try

        'try catch that displays an error message if the query fails
        Try
            For Each row As DataGridViewRow In order_create.orderCreateDGV.Rows
                ' query inserts data into the respective fields using parameters to avoid SQL injeciton
                GLOBALS.myqry = "INSERT INTO orderProducts([orderID], [productID]) VALUES(?,?);"
                ' a new command is setup using the query and connection string
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                ' parameters are added
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("orderID", order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("productID", row.Cells("productID").Value))


                ' a non query using the new command and the parmeters within
                With GLOBALS.mycmd
                    .CommandText = GLOBALS.myqry
                    .Connection = GLOBALS.conn
                    .ExecuteNonQuery()
                End With
                ' try catch message is displayed
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' updates the data grid view with the new layout
        order_history.loadOrderDGV()
        Return ""
    End Function

    Shared Function controls1()
        ' the save button is disabled
        order_create.btnSaveOrder.Enabled = False
        ' the create buttons is enabled
        order_create.btnCreate.Enabled = True
        Return ""
    End Function

    Shared Function controls2()
        ' the save button is enabled
        order_create.btnSaveOrder.Enabled = True
        ' the save buttons is disabled
        order_create.btnCreate.Enabled = False
        Return ""
    End Function

    Private Sub btnBackOrderCreate_Click(sender As Object, e As EventArgs) Handles btnBackOrderCreate.Click
        Me.Hide()
        order_history.Show()
        ' clear whatever text is in the combobox
        cmbProductOrder.Text = String.Empty
        ' clears whatever text is in the combobox
        cmbCustomerOrder.Text = String.Empty
        ' clears whatever text is in the combobox
        cmbPaymentMethod.Text = String.Empty
        ' clear whatever text is int the textbox
        txtboxComments.Clear()
        ' empties all the rows in the data-grid view
        orderCreateDGV.Rows.Clear()
        ' Clears all the items in the combobox
        cmbProductOrder.Items.Clear()
        ' Clears all the items in the combobox
        cmbCustomerOrder.Items.Clear()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        addProductDGV()
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        ' if there are more than 0 rows in the data grid view
        If orderCreateDGV.SelectedRows.Count > 0 Then
            ' the selected row will be deleted
            orderCreateDGV.Rows.RemoveAt(orderCreateDGV.CurrentRow.Index)
        End If
        totalPrice()
    End Sub

    Private Sub cmbCustomerOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomerOrder.SelectedIndexChanged
        ' if "New customer" is selected in the combo box, it closes the current page and opens the customer page
        If cmbCustomerOrder.Text = "New customer" Then
            Me.Hide()
            customer_page.Show()
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' if the rows are greater than 1 then the two functions are called
        If orderCreateDGV.RowCount > 0 Then
            addOrder()
            addOrderProduct()
        Else
            ' 
            MsgBox("An order cannot be created without products")
        End If

    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        editOrder()
        editOrderProduct()
    End Sub
End Class



