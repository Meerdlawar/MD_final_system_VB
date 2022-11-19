Imports System.Data.OleDb
Public Class login
    ' decalred variable str as data type String
    Dim str As String = Nothing
    ' declared variable staff_id as data type integer
    Dim staff_id As Integer = 0


    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' declared variable username and password as datatype string
        Dim username, password As String

        ' conditional statement that outputs the message "Please enter a username or password." 
        ' if the username and password textboxes were empty
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Please enter a username or password.")
        Else
            ' the variable username is assigned whatever is in the username textbox
            username = txtusername.Text
            ' the variable password is assigned whatever is in the password textbox
            password = txtpassword.Text
            ' database connection is called
            GLOBALS.ConnToDb()
            ' query compares username and password input to values inside the table tblstaff
            GLOBALS.myqry = "SELECT * FROM tblStaffs WHERE staff_user = @USERNAME and staff_pass = @PASSWORD;"
            ' new command is setup containing the query string and connection string
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            ' use of parameters to avoid SQL injection
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@USERNAME", username))
            GLOBALS.mycmd.Parameters.Add(New OleDbParameter("@PASSWORD", password))
            ' data reader reads the database using the New command
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader


            ' while loop that reads everything in the StaffID column 
            While GLOBALS.mydr.Read
                staff_id = GLOBALS.mydr("StaffID")

            End While
            ' if the staff ID is not 0 then it logs the user in and directs them to the main menu
            ' otherwise the user is asked to input a valid username or password
            If staff_id <> 0 Then
                main_menu.Show()
                Me.Hide()
            Else
                MsgBox("Please enter a valid username or password")
                ' textboxes are cleared if username or password aren't correct
                txtusername.Clear()
                txtpassword.Clear()
            End If
        End If


    End Sub

    Private Sub showpassCB_CheckedChanged(sender As Object, e As EventArgs) Handles showpassCB.CheckedChanged
        If showpassCB.Checked = True Then
#Disable Warning BC42016 ' Implicit conversion
            txtpassword.PasswordChar = ""
        ElseIf showpassCB.Checked = False Then
            txtpassword.PasswordChar = "*"
#Enable Warning BC42016 ' Implicit conversion
        End If
    End Sub
End Class
