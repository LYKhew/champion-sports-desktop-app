Module mod_globals_a193067
    ' Use Function to get a new connection for each operation
    Public Function GetConnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CHAMPIONSPORTS_A193067.accdb;Persist Security Info=False;")
    End Function

    Public Function RunSqlQuery(mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Using myconnection As OleDb.OleDbConnection = GetConnection()
            Try
                myconnection.Open()
                Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
                myreader.Fill(mydatatable)
            Catch ex As Exception
                Beep()
                MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End Using
        Return mydatatable
    End Function

    Public Sub RunSqlCommand(thissql As String)
        Using myconnection As OleDb.OleDbConnection = GetConnection()
            Try
                myconnection.Open()
                Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection)
                mywriter.ExecuteNonQuery()
            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End Using
    End Sub
End Module

