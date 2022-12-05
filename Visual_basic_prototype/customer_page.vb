Imports System.Data.OleDb

Public Class customer_page
    ' varable ID declared as an empty string
    Dim ID As String = ""


    Private Sub customer_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagridView()
    End Sub



    Public Sub loadDatagridView()
        controls1()
        ' try catch implemented to display user friendly message incase the query fails
        Try
            ' clears all the rows in the data grid view
            customerDGV.Rows.Clear()
            ' query that selects everything in the tblcustomers table
            GLOBALS.myqry = "SELECT * FROM tblCustomers"
            ' a new command is set up
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' the data reader executes the command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

            ' adds all the data in tblcustomers inside their respective rows
            While GLOBALS.mydr.Read
                customerDGV.Rows.Add(GLOBALS.mydr.Item("customerID"), GLOBALS.mydr.Item("prefix"), GLOBALS.mydr.Item("Fname"), GLOBALS.mydr.Item("Lname"), GLOBALS.mydr.Item("phone_number"), GLOBALS.mydr.Item("email"), GLOBALS.mydr.Item("subfix"))
            End While

            ' displays message if query fails
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub AddRecord()

        ' displays error message if text boxes are empty
        If txtCustomerFname.Text = "" Or txtCustomerLname.Text = "" Or txtCustomerNumber.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            ' try catch that displays an error message if the query fails
            Try
                ' query inserts data into the respective fields using parameters to avoid SQL injeciton
                GLOBALS.myqry = "INSERT INTO tblCustomers([prefix], [Fname], [Lname], [phone_number],[email],[subfix], [full_name]) VALUES(?,?,?,?,?,?,?)"
                ' a new command is setup using the query and connection string
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                ' parameters are added
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("prefix", txtCustomerPrefix.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("Fname", txtCustomerFname.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("Lname", txtCustomerLname.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("PhoneNumber", txtCustomerNumber.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("Email", txtCustomerEmail.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("Subfix", txtCustomerSubfix.Text))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("full_name", txtCustomerFname.Text & " " & txtCustomerLname.Text))

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
            loadDatagridView()
            ' clears textboxes once record is added
            cleartxtbox()
        End If

    End Sub



    Private Sub DeleteRecord()
        ' try catch incase query fails
        Try
            'message box displayed verfies whether the user wants to delete the record
            ' if yes then it moves on to the DELETE query
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' the DELETE query checks the customer ID and delete records related to that ID, uses parameters as well to stop SQL injection
                GLOBALS.myqry = "DELETE FROM tblCustomers WHERE customerID = @ID"
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
        ' conditional statement that checks whether the necessary fields are filled
        If txtCustomerFname.Text = "" Or txtCustomerLname.Text = "" Or txtCustomerNumber.Text = "" Then
            MessageBox.Show("All fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ' try catch which displays an error message if query fails
            Try
                ' verifies with the user whether they want to edit a record
                If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'assign the insetion query
                    GLOBALS.myqry = "UPDATE tblCustomers 
                     SET prefix = @prefix, Fname = @Fname, Lname = @Lname, phone_number = @phone_number, email = @email, subfix = @subfix
                     WHERE customerID = @productID;"
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
                        .Parameters.AddWithValue("@Prefix", txtCustomerPrefix.Text)
                        .Parameters.AddWithValue("@Fname", txtCustomerFname.Text)
                        .Parameters.AddWithValue("@Lname", txtCustomerLname.Text)
                        .Parameters.AddWithValue("@phone_number", txtCustomerNumber.Text)
                        .Parameters.AddWithValue("@email", txtCustomerEmail.Text)
                        .Parameters.AddWithValue("@Subfix", txtCustomerSubfix.Text)
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
        If txtCustomerSearch.Text = "" Then
            loadDatagridView()
        Else
            ' try catch implemented in case the query fails
            Try
                ' clears all the rows in the data grid view
                customerDGV.Rows.Clear()
                ' the query then selects any pieces of data that share the same characters in the textbox and uses parameters as it input
                GLOBALS.myqry = "SELECT * FROM tblCustomers WHERE Fname LIKE @Fname OR Lname LIKE @Lname;"
                ' a new command is created using the query and connection string
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                ' parameters are displayed
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@Fname", txtCustomerSearch.Text & "%"))
                GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@Lname", txtCustomerSearch.Text & "%"))
                ' data reader is then executed
                GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
                ' the data reader reads all values that are closely related to what's been searched in the textbox
                While GLOBALS.mydr.Read
                    customerDGV.Rows.Add(GLOBALS.mydr.Item("customerID"), GLOBALS.mydr.Item("prefix"), GLOBALS.mydr.Item("Fname"), GLOBALS.mydr.Item("Lname"), GLOBALS.mydr.Item("phone_number"), GLOBALS.mydr.Item("email"), GLOBALS.mydr.Item("subfix"))
                End While


            Catch ex As Exception
                ' display the error
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cleartxtbox()
        ' clears variable ID and all textboces
        ID = ""
        txtCustomerFname.Clear()
        txtCustomerEmail.Clear()
        txtCustomerLname.Clear()
        txtCustomerNumber.Clear()
        txtCustomerPrefix.Clear()
        txtCustomerSubfix.Clear()
    End Sub

    Sub controls1()
        ' enables use of add button
        btncustomerAdd.Enabled = True
        ' enables use of delete button
        btncustomerDelete.Enabled = True
        ' enables use of back button
        btncustomerBack.Enabled = True
        ' disables use of clear button
        btncustomerClear.Enabled = False
        ' disables use of save button
        btncustomerSave.Enabled = False
        ' disables use of cancel button
        btncustomerCancel.Enabled = False

    End Sub

    Sub controls2()
        ' enables use of save button
        btncustomerSave.Enabled = True
        ' enables use of cancel button
        btncustomerCancel.Enabled = True
        'enables use of clear button
        btncustomerClear.Enabled = True
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

    Private Sub productDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles customerDGV.CellContentClick
        ' rows are assigned a variable or textbox when clicking on a field
        ID = customerDGV.CurrentRow.Cells(0).Value
        txtCustomerPrefix.Text = customerDGV.CurrentRow.Cells(1).Value.ToString
        txtCustomerFname.Text = customerDGV.CurrentRow.Cells(2).Value.ToString
        txtCustomerLname.Text = customerDGV.CurrentRow.Cells(3).Value.ToString
        txtCustomerNumber.Text = customerDGV.CurrentRow.Cells(4).Value.ToString
        txtCustomerEmail.Text = customerDGV.CurrentRow.Cells(5).Value.ToString
        txtCustomerSubfix.Text = customerDGV.CurrentRow.Cells(6).Value.ToString
    End Sub




    Private Sub btncustomerBack_Click(sender As Object, e As EventArgs) Handles btncustomerBack.Click
        Me.Hide()
        main_menu.Show()
    End Sub

    Private Sub btnproductAdd_Click(sender As Object, e As EventArgs) Handles btncustomerAdd.Click
        AddRecord()
    End Sub

    Private Sub btnProductClear_Click(sender As Object, e As EventArgs) Handles btncustomerClear.Click
        cleartxtbox()
    End Sub

    Private Sub btncustomerDelete_Click(sender As Object, e As EventArgs) Handles btncustomerDelete.Click
        DeleteRecord()
    End Sub

    Private Sub btncustomerSave_Click(sender As Object, e As EventArgs) Handles btncustomerSave.Click
        EditRecord()
    End Sub

    Private Sub btncustomerCancel_Click(sender As Object, e As EventArgs) Handles btncustomerCancel.Click
        ' clears all textboxes
        cleartxtbox()
        ' controls1 is enabled
        Call controls1()
    End Sub

    Private Sub txtCustomerSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerSearch.TextChanged
        searchItem()
    End Sub

    Private Sub txtCustomerPrefix_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerPrefix.TextChanged
        saveFunc()
    End Sub

    Private Sub txtCustomerFname_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerFname.TextChanged
        saveFunc()
    End Sub

    Private Sub txtCustomerLname_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerLname.TextChanged
        saveFunc()
    End Sub

    Private Sub txtCustomerNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerNumber.TextChanged
        saveFunc()
    End Sub

    Private Sub txtCustomerEmail_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerEmail.TextChanged
        saveFunc()
    End Sub

    Private Sub txtCustomerSubfix_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerSubfix.TextChanged
        saveFunc()
    End Sub


End Class