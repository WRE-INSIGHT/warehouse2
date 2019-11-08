Imports System.Data.SqlClient
Module AccountabilityMod

    Public Sub Accountability_Inv_STP(ByVal StoredProcedureName As String,
                                      ByVal dsTbl_Command As String,
                                      Optional SearchString As String = "",
                                      Optional control_no As String = "",
                                      Optional emp_id As String = "",
                                      Optional emp_name As String = "",
                                      Optional emp_position As String = "",
                                      Optional emp_dept As String = "",
                                      Optional stk_desc As String = "",
                                      Optional stk_qty As Decimal = 0.00D,
                                      Optional stk_unit As String = "",
                                      Optional date_issued As Date = #01-01-1997#,
                                      Optional stk_unitprice As Decimal = 0.00D,
                                      Optional stk_receivedby_id As String = "",
                                      Optional stk_receivedby As String = "",
                                      Optional stk_remarks As String = "",
                                      Optional date_returned As String = "")
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
                sqlCommand.Parameters.Add("@search", SqlDbType.VarChar).Value = SearchString

                sqlCommand.Parameters.Add("@control_no", SqlDbType.VarChar).Value = control_no
                sqlCommand.Parameters.Add("@emp_id", SqlDbType.VarChar).Value = emp_id
                sqlCommand.Parameters.Add("@emp_name", SqlDbType.VarChar).Value = emp_name
                sqlCommand.Parameters.Add("@emp_position", SqlDbType.VarChar).Value = emp_position
                sqlCommand.Parameters.Add("@emp_dept", SqlDbType.VarChar).Value = emp_dept
                sqlCommand.Parameters.Add("@stk_desc", SqlDbType.VarChar).Value = stk_desc
                sqlCommand.Parameters.Add("@stk_unit", SqlDbType.VarChar).Value = stk_unit
                sqlCommand.Parameters.Add("@stk_receivedby_id", SqlDbType.VarChar).Value = stk_receivedby_id
                sqlCommand.Parameters.Add("@stk_receivedby", SqlDbType.VarChar).Value = stk_receivedby
                sqlCommand.Parameters.Add("@stk_remarks", SqlDbType.VarChar).Value = stk_remarks
                sqlCommand.Parameters.Add("@inputtedby", SqlDbType.VarChar).Value = user_fullname

                sqlCommand.Parameters.Add("@stk_qty", SqlDbType.Decimal).Value = stk_qty
                sqlCommand.Parameters.Add("@stk_unitprice", SqlDbType.Decimal).Value = stk_unitprice
                sqlCommand.Parameters.Add("@date_issued", SqlDbType.Date).Value = date_issued
                sqlCommand.Parameters.Add("@date_returned", SqlDbType.VarChar).Value = date_returned
                sqlCommand.ExecuteNonQuery()
                transaction.Commit()

                sql_Transaction_result = "Committed"

                If dsTbl_Command.Contains("trans") = False And
                    dsTbl_Command.Contains("Print") = False Then

                    sqlDataAdapter.SelectCommand = sqlCommand
                    sqlDataAdapter.Fill(sqlDataSet, dsTbl_Command)
                    sqlBindingSource.DataSource = sqlDataSet
                    sqlBindingSource.DataMember = dsTbl_Command

                    'ElseIf dsTbl_Command.Contains("Print") = True Then
                    '    If dsTbl_Command = "PrintER_Items" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.ER_Items)
                    '        RR_Transmittal.ER_ItemsBindingSource.DataSource = mi_ds.ER_Items.DefaultView
                    '    ElseIf dsTbl_Command = "PrintER_GiftSummary" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.GiftSummaryBody)
                    '        RR_GiftSummary.GiftSummaryBodyBindingSource.DataSource = mi_ds.GiftSummaryBody.DefaultView
                    '    ElseIf dsTbl_Command = "PrintWithoutGifts" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.WithoutGifts)
                    '        RR_WithoutGifts.WithoutGiftsBindingSource.DataSource = mi_ds.WithoutGifts.DefaultView
                    '    ElseIf dsTbl_Command = "PrintCreditPoints" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.ExportCP)
                    '        RR_ExportCP.ExportCPBindingSource.DataSource = mi_ds.ExportCP.DefaultView
                    '    End If
                End If
            End Using
        End Using
    End Sub
End Module
