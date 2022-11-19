Imports System.Data.OleDb

Public Class order_history
    Dim ID As String = ""
    Dim customer_ID As String = ""
    Dim totalPrice As String = ""
    Dim paymentMethod As String = ""
    Dim orderPlaced As String = ""
    Dim orderDue As String = ""
    Dim info As String = ""


    Private Sub order_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadOrderDGV()
    End Sub

    Public Shared Function loadOrderDGV()
        Try
            ' clears the rows in the data grid view
            order_history.orderDGV.Rows.Clear()
            ' query selects all the rows from tblOrders
            GLOBALS.myqry = "SELECT * FROM tblOrders"
            ' new command is initialised
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' data reader is executed
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

            ' all the rows within the data grid view are filled with the data in the tblOrders fields
            While GLOBALS.mydr.Read
                order_history.orderDGV.Rows.Add(GLOBALS.mydr.Item("orderID"), GLOBALS.mydr.Item("customerID"), (FormatCurrency(GLOBALS.mydr.Item("total_price"))), GLOBALS.mydr.Item("method_of_payment"), GLOBALS.mydr.Item("order_Placed"), GLOBALS.mydr.Item("order_due"), GLOBALS.mydr.Item("comments"))
            End While

            ' intercepts errors
        Catch ex As Exception
            ' displays an error message box
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Private Sub DeleteRecord()
        ' checks if ID is empty then displays a message box asking the user to select an item to delete
        If ID = "" Then
            MsgBox("Please click on an order to delete.")
        Else
            ' try catch incase query fails
            Try
                'message box displayed verfies whether the user wants to delete the record
                ' if yes then it moves on to the DELETE query
                If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ' the DELETE query checks the order ID and delete records related to that ID, uses parameters as well to stop SQL injection
                    GLOBALS.myqry = "DELETE FROM tblOrders WHERE orderID = @ID"
                    ' a new OleDbCommand is created usin the query and connection string
                    GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                    ' parameter is added to the command
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
            ' Loads an updated version of the data grid view
            loadOrderDGV()
        End If
    End Sub


    Shared Function orderDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderDGV.CellContentClick

        ' the ID, customer_ID, totalPrice, paymentMethod, orderPlaced, orderDue and info variables are assgined to a specific row in the data grid view
        order_history.ID = order_history.orderDGV.CurrentRow.Cells(0).Value.ToString()
        order_history.customer_ID = order_history.orderDGV.CurrentRow.Cells(1).Value.ToString()
        order_history.totalPrice = order_history.orderDGV.CurrentRow.Cells(2).Value.ToString()
        order_history.paymentMethod = order_history.orderDGV.CurrentRow.Cells(3).Value.ToString()
        order_history.orderPlaced = order_history.orderDGV.CurrentRow.Cells(4).Value.ToString()
        order_history.orderDue = order_history.orderDGV.CurrentRow.Cells(5).Value.ToString()
        order_history.info = order_history.orderDGV.CurrentRow.Cells(6).Value.ToString()

        ' if the product button is clicked in the data grid view the function below are called
        If order_history.orderDGV.Columns(e.ColumnIndex).HeaderText = "Products" Then
            order_history.Hide()
            order_create.Show()
            order_create.controls2()
            order_create.access()
            order_create.populateDGV()
            order_create.populatecombobox()
            order_create.populateDataTimePicker()
            order_create.populatetxtbox()
        End If
        Return ""
    End Function






    Private Sub btnOrderBack_Click(sender As Object, e As EventArgs) Handles btnOrderBack.Click
        Me.Hide()
        main_menu.Show()
    End Sub

    Private Sub btnOrderAdd_Click(sender As Object, e As EventArgs) Handles btnOrderCreate.Click
        Me.Hide()
        order_create.Show()
        order_create.controls1()
    End Sub

    Private Sub btnHistoryDelete_Click(sender As Object, e As EventArgs) Handles btnHistoryDelete.Click
        DeleteRecord()
    End Sub
End Class