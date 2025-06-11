Module DbConnection
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=;")
    Public cmd As OleDb.OleDbCommand


    Public Function DbConnect()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("An Error Occured" & ex.Message)
        End Try

        Return conn
    End Function

    Public Sub DbDisconnect()
        conn.Close()
    End Sub
End Module
