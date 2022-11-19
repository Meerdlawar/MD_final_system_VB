Imports System.Data.OleDb

Public Class product_edit_page

    Sub ProductListViewSetup()
        'using the listview columns
        With product_list.Columns
            'Adds a column header and defines a header name, width, and format the text allgnment
            .Add("Product ID", 100, HorizontalAlignment.Left)
            .Add("Product name", 200, HorizontalAlignment.Left)
            .Add("Product price", 60, HorizontalAlignment.Left)
            .Add("Type", 150, HorizontalAlignment.Left)
            .Add("Suitability", 80, HorizontalAlignment.Left)
            'end with
        End With
    End Sub

    Sub loadListview()

        product_list.Items.Clear() 'clears all items int the listview
        'assigning the SELECT FROM query to collect the Query variable

        GLOBALS.myqry = "SELECT * FROM tblProducts"
        'initialising a new command with the connection and query with it
        GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
        'initialising the Data reader with the command
        GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
        'while the data reader is reading
        While GLOBALS.mydr.Read
            'using the Parts listview
            With product_list
                'add to the first column
                .Items.Add(GLOBALS.mydr("productID"))
                'with items subitems
                With .Items(.Items.Count - 1).SubItems
                    'add the data to the listview in this order
                    .Add(GLOBALS.mydr(“product_name”))
                    .Add(FormatCurrency(GLOBALS.mydr(“product_price")))
                    .Add(GLOBALS.mydr(“product_type”))
                    .Add(GLOBALS.mydr(“product_suitability”))
                    'end with
                End With
                'end with
            End With
            'End while
        End While

    End Sub

    Private Sub product_edit_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductListViewSetup()
        loadListview()
    End Sub

    Private Sub AddRecord()
        ' if the text boxes and combo boxes are empty then an error message is displayed
        If txtProductName.Text = "" Or cmbProductType.Text = "" Or txtDietInquiries.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' query inserts data from the textboxes into the table
            GLOBALS.myqry = "INSERT INTO tblProducts([product_name], [product_price], [product_type], [product_suitability]) VALUES(?,?,?,?)"
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_name", txtProductName.Text))
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_price", txtProductPrice.Text))
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_type", cmbProductType.Text))
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("product_suitability", txtDietInquiries.Text))


            With GLOBALS.mycmd
                .CommandText = GLOBALS.myqry
                .Connection = GLOBALS.conn
                .ExecuteNonQuery()
            End With


        End If
    End Sub

    Private Sub btnproductBack_Click(sender As Object, e As EventArgs) Handles btnproductBack.Click
        Me.Hide()
        main_menu.Show()
    End Sub

    Private Sub btnproductAdd_Click(sender As Object, e As EventArgs) Handles btnproductAdd.Click
        AddRecord()
        loadListview()
    End Sub

    Private Sub clear()
        ' clears the texboxes and combo boxes
        txtSelectProductID.Clear()
        txtProductName.Clear()
        txtProductPrice.Clear()
        cmbProductType.Items.Clear()
    End Sub
End Class