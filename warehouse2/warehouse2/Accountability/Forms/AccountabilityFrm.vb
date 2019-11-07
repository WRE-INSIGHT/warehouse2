Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit
Imports MetroFramework
Public Class AccountabilityFrm

    Private BGW As BackgroundWorker = New BackgroundWorker
    Public DGV_Accountability As New KryptonDataGridView
    Public DGV_Search_Inventory As New KryptonDataGridView
    Dim dgv_acct_bs As New BindingSource
    Dim dgv_inv_bs As New BindingSource

    Dim todo, todo_mode, search_acct, search_inv As String
    Dim ctr_todo As Integer
    Private Sub Reset_here()
        DGV_Accountability.Enabled = True
        DGV_Search_Inventory.Enabled = True
        todo_mode = ""
        ctr_todo = 0
    End Sub
    Private Sub Start_BGW()
        Try
            If BGW.IsBusy <> True Then
                DGV_Accountability.Enabled = False
                DGV_Search_Inventory.Enabled = False
                BGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AccountabilityFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BGW.WorkerSupportsCancellation = True
        BGW.WorkerReportsProgress = True
        AddHandler BGW.DoWork, AddressOf BGW_DoWork
        AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
        AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

        DGV_Accountability.DataSource = dgv_acct_bs
        DGV_Search_Inventory.DataSource = dgv_inv_bs

        Loading_PB.Visible = True
        UnitPrice_Num.Maximum = Decimal.MaxValue

        search_acct = ""
        search_inv = ""
        todo_mode = "onload"
        todo = "load_acctblty"
        Start_BGW()
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case todo
                Case "load_acctblty"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, search_acct)
                    BGW.ReportProgress(0)

                Case "load_search_inv"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, "%" & search_inv & "%")
                    BGW.ReportProgress(0)

                Case "getmax_ctrlno"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, "%" & Now.ToString("yy") & "-")
            End Select
        Catch ex As SqlException
            BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex2.Message, ex2.StackTrace)
                BGW.CancelAsync()
            End Try
        Catch ex As Exception
            BGW.CancelAsync()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
        If BGW.CancellationPending = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case todo
                Case "load_acctblty"
                    If Not frm_Split.Panel2.Controls.Contains(DGV_Accountability) Then
                        DGV_Properties(DGV_Accountability, "DGV_Accountability")
                        AddHandler DGV_Accountability.RowPostPaint, AddressOf dgv_rowpostpaint
                        AddHandler DGV_Accountability.DataError, AddressOf dgv_dataerror
                        'AddHandler DGV_Accountability.KeyDown, AddressOf dgv_keydown
                        'AddHandler DGV_Warehouse_Inventory.CellMouseClick, AddressOf dgv_cellmouseclick

                        frm_Split.Panel2.Controls.Add(DGV_Accountability)
                    End If

                Case "load_search_inv"
                    If Not Item_Pnl.Controls.Contains(DGV_Search_Inventory) Then
                        DGV_Properties(DGV_Search_Inventory, "DGV_Search_Inventory")
                        AddHandler DGV_Search_Inventory.DataError, AddressOf dgv_dataerror
                        AddHandler DGV_Search_Inventory.CellMouseDoubleClick, AddressOf dgv_cellmousedoubleclick

                        Item_Pnl.Controls.Add(DGV_Search_Inventory)
                    End If
            End Select
        Catch ex As Exception
            Reset_here()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            Exit Sub
        End Try
    End Sub

    Private Sub BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                'If BackgroundWorker Then terminated due To Error
                Reset_here()
            Else
                If sql_Transaction_result = "Committed" Then
                    Select Case todo
                        Case "load_acctblty"
                            dgv_acct_bs.DataSource = sqlDataSet
                            dgv_acct_bs.DataMember = todo
                            With DGV_Accountability
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .AllowUserToOrderColumns = False
                                .Select()
                                .Columns("acctblty_id").Visible = False
                                .Columns("Quantity").DefaultCellStyle.Format = "N2"
                                .Columns("Total Amount").DefaultCellStyle.Format = "N2"
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                                .MultiSelect = True
                                .ClearSelection()
                            End With
                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                                Loading_PB.Visible = False
                            End If

                        Case "load_search_inv"
                            dgv_inv_bs.DataSource = sqlDataSet
                            dgv_inv_bs.DataMember = todo
                            With DGV_Search_Inventory
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .AllowUserToOrderColumns = False
                                .Select()
                                .Cursor = Cursors.Hand
                                .Columns("STOCKNO").Visible = False
                                .Columns("PHYSICAL").DefaultCellStyle.Format = "N4"
                                .Columns("UNITPRICE").DefaultCellStyle.Format = "N4"
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                                .RowHeadersVisible = False
                                .MultiSelect = False
                                .ClearSelection()
                            End With
                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                                Loading2_PB.Visible = False
                            End If

                        Case "getmax_ctrlno"
                            Dim ctrlno As String = sqlDataSet.Tables(todo).Rows(0).Item(0).ToString
                            If ctrlno = "0" Then
                                CtrlNo_Tbox.Text = Now.ToString("yy") & "-00001"
                            Else
                                Dim cno_str As String = ctrlno.Substring(ctrlno.IndexOf("-") + 1)
                                Dim cno_int As Integer = CInt(cno_str) + 1
                                With CtrlNo_Tbox
                                    .Text = Now.ToString("yy") & "-"
                                    For i = cno_int.ToString.Length To 5
                                        .Text &= "0"
                                    Next
                                    .Text = cno_int.ToString
                                End With
                            End If
                    End Select

                    Select Case todo_mode
                        Case "onload"
                            Select Case ctr_todo
                                Case 1
                                    Loading_PB.Visible = False
                                    Loading2_PB.Visible = True
                                    todo = "load_search_inv"
                                    Start_BGW()
                                Case 2
                                    Reset_here()
                                    Loading2_PB.Visible = False

                            End Select
                    End Select
                End If
            End If
        Catch ex As Exception
            Reset_here()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_cellmousedoubleclick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex <> -1 And sender.rows.count <> 0 Then
                Desc_Cbox.Text = DGV_Search_Inventory.Item("DESCRIPTION", e.RowIndex).Value.ToString
                Quantity_Num.Maximum = DGV_Search_Inventory.Item("PHYSICAL", e.RowIndex).Value
                Unit_Tbox.Text = DGV_Search_Inventory.Item("UNIT", e.RowIndex).Value.ToString
                UnitPrice_Num.Value = DGV_Search_Inventory.Item("UNITPRICE", e.RowIndex).Value
                Quantity_Num.Focus()
                Quantity_Num.Select(0, Quantity_Num.Text.Length)
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub dgv_dataerror(sender As Object, e As DataGridViewDataErrorEventArgs)
    End Sub

    Private Sub dgv_rowpostpaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub

    Private Sub Search_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Search_Tbox.ButtonClick
        Loading2_PB.Visible = True
        search_inv = Trim(Search_Tbox.Text)
        todo = "load_search_inv"
        Start_BGW()
    End Sub
    Private Sub Search_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Search_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search_Tbox.CustomButton.PerformClick()
        End If
    End Sub

    Private Sub Qty_Num_KeyDown(sender As Object, e As KeyEventArgs) Handles Quantity_Num.KeyDown
        If e.KeyCode = Keys.Enter Then
            Unit_Tbox.Focus()
        End If
    End Sub

    Private Sub Fields_Pnl_Paint(sender As Object, e As PaintEventArgs) Handles Fields_Pnl.Paint

    End Sub

    Private Sub CtrlNo_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles CtrlNo_Tbox.ButtonClick
        todo = "getmax_ctrlno"
        Start_BGW()
    End Sub

    Private Sub Item_Pnl_SizeChanged(sender As Object, e As EventArgs) Handles Item_Pnl.SizeChanged
        Loading2_PB.Location = New Point((sender.Width - Loading_PB.Width) / 2, (sender.Height - Loading_PB.Height) / 2)
    End Sub

    Private Sub frm_Split_Panel2_SizeChanged(sender As Object, e As EventArgs) Handles frm_Split.Panel2.SizeChanged
        Loading_PB.Location = New Point((sender.Width - Loading_PB.Width) / 2, (sender.Height - Loading_PB.Height) / 2)
    End Sub

    Private Sub Btn_Pnl_SizeChanged(sender As Object, e As EventArgs) Handles Btn_Pnl.SizeChanged
        For Each btn In sender.Controls
            btn.Width = Btn_Pnl.Width / 5
        Next
    End Sub

End Class