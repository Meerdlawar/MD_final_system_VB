Imports System.Data.OleDb


Module Connection
    Public Class GLOBALS
        ' declared conn as a public variable and new OLeDb Connection
        Public Shared conn As New OleDb.OleDbConnection
        ' declared public variable myqry as datatype string and predefined it as empty
        Public Shared myqry As String = Nothing
        ' declared public variable mycmd as a new OleDbCommand
        Public Shared mycmd As New OleDbCommand
        ' declared public variable mydr as a OleDb data reader
        Public Shared mydr As OleDbDataReader



        Public Shared Sub ConnToDb()
            ' try catch implemented incase the query fails
            Try
                ' using the New OleDb connection 
                With conn
                    ' if the connection is open, then close it
                    If .State = ConnectionState.Open Then .Close()
                    ' connection string defined
                    .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SD_prototype_DB(final version).accdb"
                    .Open()
                End With
                ' if query fails a message is outputted to stop the program from failing
            Catch ex As Exception
                MessageBox.Show("Unable to connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub
    End Class
End Module
