Imports System.Data.SqlClient
Module MainModule

    Public Sub WarehouseMain_STP(ByVal StoredProcedureName As String,
                                 ByVal dsTbl_Command As String,
                                 Optional fullname As String = "",
                                 Optional nickname As String = "",
                                 Optional username As String = "",
                                 Optional password As String = "",
                                 Optional id As Integer = 0)
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource
        sqlDataSet = New DataSet
        If sqlDataSet.Tables.Contains(dsTbl_Command) Then
            sqlDataSet.Tables(dsTbl_Command).Clear()
        End If
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure
                sqlCommand.Parameters.Add("@todo", SqlDbType.VarChar).Value = dsTbl_Command
                sqlCommand.Parameters.Add("@fullname", SqlDbType.VarChar).Value = fullname
                sqlCommand.Parameters.Add("@nickname", SqlDbType.VarChar).Value = nickname
                sqlCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = username
                sqlCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id

                sqlCommand.ExecuteNonQuery()
                transaction.Commit()

                sql_Transaction_result = "Committed"
                If dsTbl_Command.Contains("trans") = False Then
                    sqlDataAdapter.SelectCommand = sqlCommand
                    sqlDataAdapter.Fill(sqlDataSet, dsTbl_Command)
                    sqlBindingSource.DataSource = sqlDataSet
                    sqlBindingSource.DataMember = dsTbl_Command
                End If
            End Using
        End Using
    End Sub
End Module
