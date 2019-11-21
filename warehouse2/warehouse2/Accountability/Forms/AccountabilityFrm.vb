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
    Dim cbox_bs As New BindingSource
    Dim acctblty_id_list As New ArrayList

    Dim cbox_obj As Object
    Dim deptfilter_str As String = ""
    Dim search_acct, search_inv, search, current_mode_string, cbox_cols, cols,
        ctrl_no, emp_id, emp_name, emp_pos, emp_dept, stk_desc, stk_unit, receivedby_id, receivedby As String
    Dim ctr_todo, kmdi_emp_id, stockno, acctblty_id, CboxselIndex As Integer
    Dim current_mode_color As Color
    Dim btn_clicking As Object
    Dim stk_qty, stk_unitprice As Decimal
    Dim date_issued As Date


    Dim return_str As String = "Return",
        lost_str As String = "Lost",
        transferred_str As String = "Transfer",
        all_str As String = ""
    Public todo, todo_mode, date_returned, remarks As String
    Private Sub Reset_here()
        DGV_Accountability.Enabled = True
        DGV_Search_Inventory.Enabled = True
        Btn_Pnl.Enabled = True
        Filter_Pnl.Enabled = True
        todo_mode = ""
        ctr_todo = 0
        sql_Transaction_result = ""
        'kmdi_emp_id = 0

        Mode_Lbl.Text = current_mode_string
        Mode_Lbl.ForeColor = current_mode_color
    End Sub

    Sub itemsclear()
        acctblty_id = 0
        stockno = 0
        Desc_Cbox.Text = ""
        Quantity_Num.Value = 0
        Unit_Tbox.Clear()
        UnitPrice_Num.Value = 0
        acctblty_id_list.Clear()

        Mode_Lbl.Text = "New"
        Mode_Lbl.ForeColor = Color.DarkSlateGray
    End Sub
    Public Sub Start_BGW()
        Try

            If BGW.IsBusy <> True Then
                DGV_Accountability.Enabled = False
                DGV_Search_Inventory.Enabled = False
                Btn_Pnl.Enabled = False
                Filter_Pnl.Enabled = False
                BGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function fieldtrim() As Boolean
        ctrl_no = Trim(CtrlNo_Tbox.Text)
        emp_id = Trim(EmpID_Cbox.Text)
        emp_name = Trim(EmpName_Cbox.Text)
        emp_pos = Trim(EmpPosition_Cbox.Text)
        emp_dept = Trim(EmpDept_Cbox.Text)
        stk_desc = Trim(Desc_Cbox.Text)
        stk_qty = Quantity_Num.Value
        stk_unit = Trim(Unit_Tbox.Text)
        stk_unitprice = UnitPrice_Num.Value
        receivedby_id = Trim(RecByID_Cbox.Text)
        receivedby = Trim(ReceivedBy_Cbox.Text)
        remarks = Trim(Remarks_Tbox.Text)
        date_issued = DateIssued_DTP.Value

        If stk_qty <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AccountabilityFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BGW.WorkerSupportsCancellation = True
        BGW.WorkerReportsProgress = True
        AddHandler BGW.DoWork, AddressOf BGW_DoWork
        AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
        AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

        DGV_Accountability.DataSource = dgv_acct_bs
        DGV_Search_Inventory.DataSource = dgv_inv_bs

        Loading_PB.BringToFront()
        UnitPrice_Num.Maximum = Decimal.MaxValue
        Quantity_Num.Maximum = Decimal.MaxValue
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
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, "%" & search_acct & "%",,
                                           return_str, lost_str, transferred_str, all_str)
                    BGW.ReportProgress(0)

                Case "load_acctblty_byEmpID"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, search_acct,,
                                           return_str, lost_str, transferred_str, all_str)
                    BGW.ReportProgress(0)

                Case "load_search_inv"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, "%" & search_inv & "%")
                    BGW.ReportProgress(0)

                Case "getmax_ctrlno"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, "%" & Now.ToString("yy") & "-%")

                Case "get_employee"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, search)

                Case "get_empfilter"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo, deptfilter_str)
                    BGW.ReportProgress(0)

                Case "get_deptfilter"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo)
                    BGW.ReportProgress(0)

                Case "transSaveAcct"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo,,, ctrl_no, emp_id, emp_name, emp_pos, emp_dept, stockno, stk_desc, stk_qty,
                                                                     stk_unit, date_issued, stk_unitprice, receivedby_id, receivedby, remarks)

                Case "transEditAcct"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo,, acctblty_id, ctrl_no, emp_id, emp_name, emp_pos, emp_dept, stockno, stk_desc, stk_qty,
                                                                    stk_unit, date_issued, stk_unitprice, receivedby_id, receivedby, remarks)

                Case "transDelAcct"
                    For i = 0 To acctblty_id_list.Count - 1
                        BGW.ReportProgress(acctblty_id_list(i))
                    Next

                Case "transRemarksAcct"
                    For i = 0 To acctblty_id_list.Count - 1
                        BGW.ReportProgress(acctblty_id_list(i))
                    Next

                Case "transReturnAcct"
                    For i = 0 To acctblty_id_list.Count - 1
                        BGW.ReportProgress(acctblty_id_list(i))
                    Next

                Case "Load_ComboBoxData"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo,,,,,,,,,,,,,,,,,, cols)
                    BGW.ReportProgress(0)

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
                Case "load_acctblty", "load_acctblty_byEmpID"
                    If Not frm_Split.Panel2.Controls.Contains(DGV_Accountability) Then
                        DGV_Properties(DGV_Accountability, "DGV_Accountability")
                        AddHandler DGV_Accountability.RowPostPaint, AddressOf dgv_rowpostpaint
                        AddHandler DGV_Accountability.DataError, AddressOf dgv_dataerror
                        AddHandler DGV_Accountability.CellFormatting, AddressOf dgv_cellformatting
                        AddHandler DGV_Accountability.KeyDown, AddressOf dgv_keydown
                        AddHandler DGV_Accountability.CellMouseClick, AddressOf dgv_cellmouseclick

                        frm_Split.Panel2.Controls.Add(DGV_Accountability)
                    End If

                Case "load_search_inv"
                    If Not Item_Pnl.Controls.Contains(DGV_Search_Inventory) Then
                        DGV_Properties(DGV_Search_Inventory, "DGV_Search_Inventory")
                        AddHandler DGV_Search_Inventory.DataError, AddressOf dgv_dataerror
                        AddHandler DGV_Search_Inventory.CellMouseDoubleClick, AddressOf dgv_cellmousedoubleclick

                        Item_Pnl.Controls.Add(DGV_Search_Inventory)
                    End If

                Case "get_deptfilter", "get_empfilter", "Load_ComboBoxData"
                    cbox_bs = New BindingSource
                    cbox_bs.DataSource = sqlDataSet
                    cbox_bs.DataMember = todo

                Case "transDelAcct"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo,, e.ProgressPercentage)

                Case "transRemarksAcct"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo,, e.ProgressPercentage,,,,,,,,,,,,,, remarks)

                Case "transReturnAcct"
                    Accountability_Inv_STP("warehouse_acctblty_stp", todo,, e.ProgressPercentage,,,,,,,,,,,,,,, date_returned)

                    'Case "Load_ComboBoxData"
                    '    cbox_bs = New BindingSource
                    '    cbox_bs.DataSource = sqlDataSet
                    '    cbox_bs.DataMember = todo
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
                        Case "load_acctblty", "load_acctblty_byEmpID"
                            dgv_acct_bs.DataSource = sqlDataSet
                            dgv_acct_bs.DataMember = todo
                            With DGV_Accountability
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .Select()
                                .StateCommon.Background.Color1 = SystemColors.Control
                                .Columns("acctblty_id").Visible = False
                                .Columns("stk_recievedby_id").Visible = False
                                .Columns("stk_no").Visible = False
                                .Columns("stk_changes").Visible = False
                                .Columns("Quantity").DefaultCellStyle.Format = "N2"
                                .Columns("Date Issued").DefaultCellStyle.Format = "MMM. dd, yyyy"
                                .Columns("Total Amount").DefaultCellStyle.Format = "N2"
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                                .MultiSelect = True
                                .ClearSelection()
                                .BringToFront()
                            End With
                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                                Loading_PB.SendToBack()
                            End If

                        Case "load_search_inv"
                            dgv_inv_bs.DataSource = sqlDataSet
                            dgv_inv_bs.DataMember = todo
                            With DGV_Search_Inventory
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .Select()
                                .Cursor = Cursors.Hand
                                .Columns("STOCKNO").Visible = False
                                .Columns("PHYSICAL").DefaultCellStyle.Format = "N2"
                                .Columns("UNITPRICE").DefaultCellStyle.Format = "N2"
                                .DefaultCellStyle.BackColor = Color.White
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
                                Loading2_PB.SendToBack()
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
                                    For i = cno_int.ToString.Length To cno_str.Length - 1
                                        .Text &= "0"
                                    Next
                                    .Text &= cno_int.ToString
                                End With
                            End If
                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                            End If

                        Case "get_employee"
                            With sqlDataSet.Tables(todo)
                                If .Rows.Count <> 0 Then
                                    With .Rows(0)
                                        If btn_clicking Is Get_Btn Then
                                            'kmdi_emp_id = .Item("KMDI_Emp_ID")
                                            EmpID_Cbox.Text = .Item("Emp_ID")
                                            EmpName_Cbox.Text = .Item("Emp_Name").ToString
                                            EmpPosition_Cbox.Text = .Item("Position").ToString
                                            EmpDept_Cbox.Text = .Item("Department_Name").ToString

                                            If RecByID_Cbox.Text = "" Then
                                                RecByID_Cbox.Text = .Item("Emp_ID")
                                                ReceivedBy_Cbox.Text = .Item("Emp_Name").ToString
                                            End If

                                        ElseIf btn_clicking Is Recget_Btn Then
                                            RecByID_Cbox.Text = .Item("Emp_ID")
                                            ReceivedBy_Cbox.Text = .Item("Emp_Name").ToString

                                        End If
                                    End With
                                End If
                            End With
                            Reset_here()

                        Case "get_deptfilter"
                            RemoveHandler DeptFilter_Cbox.SelectedIndexChanged, AddressOf DeptFilter_Cbox_SelectedIndexChanged

                            DeptFilter_Cbox.DataSource = cbox_bs
                            DeptFilter_Cbox.DisplayMember = "emp_dept"

                            If CboxselIndex <> 0 Then
                                If CboxselIndex > DeptFilter_Cbox.Items.Count - 1 Then
                                    DeptFilter_Cbox.SelectedIndex = -1
                                Else
                                    DeptFilter_Cbox.SelectedIndex = CboxselIndex
                                End If
                            Else
                                DeptFilter_Cbox.SelectedIndex = -1
                            End If


                            AddHandler DeptFilter_Cbox.SelectedIndexChanged, AddressOf DeptFilter_Cbox_SelectedIndexChanged

                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                            End If

                        Case "get_empfilter"
                            RemoveHandler EmpFilter_Cbox.SelectedIndexChanged, AddressOf EmpFilter_Cbox_SelectedIndexChanged

                            EmpFilter_Cbox.DataSource = cbox_bs
                            EmpFilter_Cbox.DisplayMember = "emp_name"
                            EmpFilter_Cbox.ValueMember = "emp_id"
                            EmpFilter_Cbox.SelectedIndex = -1
                            Reset_here()

                            AddHandler EmpFilter_Cbox.SelectedIndexChanged, AddressOf EmpFilter_Cbox_SelectedIndexChanged

                        Case "Load_ComboBoxData"
                            cbox_obj.DataSource = cbox_bs
                            cbox_obj.DisplayMember = cols


                            If CboxselIndex > cbox_obj.Items.Count - 1 Then
                                cbox_obj.SelectedIndex = -1
                            Else
                                cbox_obj.SelectedIndex = CboxselIndex
                            End If

                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                            End If

                        Case "transSaveAcct"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True,,, False)
                            ctr_todo += 1

                        Case "transEditAcct"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True,,, False)
                            ctr_todo += 1

                        Case "transDelAcct"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True,,, False)
                            ctr_todo += 1

                        Case "transRemarksAcct"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True,,, False)
                            ctr_todo += 1

                        Case "transReturnAcct"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True,,, False)
                            ctr_todo += 1

                    End Select

                    Select Case todo_mode
                        Case "onload"
                            Select Case ctr_todo
                                Case 1
                                    Loading_PB.SendToBack()
                                    Loading2_PB.BringToFront()
                                    todo = "load_search_inv"
                                    Start_BGW()
                                Case 2
                                    Loading2_PB.SendToBack()
                                    CtrlNo_Tbox.CustomButton.PerformClick()

                                Case 3
                                    todo = "get_deptfilter"
                                    Start_BGW()
                                Case 4
                                    Reset_here()

                            End Select

                        Case "refresh"
                            Select Case ctr_todo
                                Case 1
                                    todo = "get_deptfilter"
                                    Start_BGW()

                                Case 2
                                    Reset_here()
                                    itemsclear()
                                    CtrlNo_Tbox.CustomButton.PerformClick()

                            End Select

                        Case "after_trans"
                            Select Case ctr_todo
                                Case 1
                                    Loading_PB.BringToFront()
                                    If DeptFilter_Cbox.Text = "" And EmpFilter_Cbox.Text = "" Then
                                        search_acct = ""
                                        todo = "load_acctblty"
                                    Else
                                        search_acct = EmpFilter_Cbox.SelectedValue
                                        todo = "load_acctblty_byEmpID"
                                    End If
                                    Start_BGW()

                                Case 2
                                    todo = "get_deptfilter"
                                    Start_BGW()

                                Case 3
                                    Loading_PB.SendToBack()
                                    Reset_here()
                                    itemsclear()

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

    Private Sub dgv_cellmouseclick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex <> -1 And e.Button = MouseButtons.Right Then
                sender.Rows(e.RowIndex).Selected = True
                Acctblty_Cmenu.Show(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub dgv_keydown(sender As Object, e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.F2 Then
                Dim items As DataGridViewSelectedRowCollection = DGV_Accountability.SelectedRows
                With items(0)
                    acctblty_id = .Cells("acctblty_id").Value
                    stockno = .Cells("stk_no").Value
                    CtrlNo_Tbox.Text = .Cells("Control No.").Value.ToString
                    EmpID_Cbox.Text = .Cells("Employee ID").Value.ToString
                    EmpName_Cbox.Text = .Cells("Name").Value.ToString
                    EmpPosition_Cbox.Text = .Cells("Position").Value.ToString
                    EmpDept_Cbox.Text = .Cells("Department").Value.ToString
                    Desc_Cbox.Text = .Cells("Description").Value.ToString
                    Quantity_Num.Maximum = Decimal.MaxValue
                    Quantity_Num.Value = .Cells("Quantity").Value
                    Unit_Tbox.Text = .Cells("Unit").Value.ToString
                    UnitPrice_Num.Value = .Cells("Unit Price").Value
                    RecByID_Cbox.Text = .Cells("stk_recievedby_id").Value.ToString
                    ReceivedBy_Cbox.Text = .Cells("Received By").Value.ToString
                    DateIssued_DTP.Value = .Cells("Date Issued").Value.ToString
                    Remarks_Tbox.Text = .Cells("Remarks").Value.ToString

                    Mode_Lbl.Text = "Update Request - " & .Cells("Control No.").Value.ToString
                    Mode_Lbl.ForeColor = Color.Maroon

                End With
            ElseIf e.KeyCode = Keys.F3 Then
                KMDIPrompts(Me, "Question", "Are you sure you want to Delete?", Nothing, Nothing, True,,, False)
                If QuestionPromptAnswer = 6 Then
                    Dim items As DataGridViewSelectedRowCollection = DGV_Accountability.SelectedRows
                    For Each item As DataGridViewRow In items
                        acctblty_id_list.Add(item.Cells("acctblty_id").Value)
                    Next
                    todo_mode = "after_trans"
                    todo = "transDelAcct"
                    Start_BGW()
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub dgv_cellformatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Try
            With DGV_Accountability
                .Item("Control No.", e.RowIndex).Style.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
                If .Item("stk_changes", e.RowIndex).Value.ToString = "Return" Then
                    .Item("Control No.", e.RowIndex).Style.ForeColor = ReturnLegend_Pnl.BackColor
                    .Item("Control No.", e.RowIndex).Style.SelectionForeColor = ReturnLegend_Pnl.BackColor

                ElseIf .Item("stk_changes", e.RowIndex).Value.ToString = "Lost" Then
                    .Item("Control No.", e.RowIndex).Style.ForeColor = LostLegend_Pnl.BackColor
                    .Item("Control No.", e.RowIndex).Style.SelectionForeColor = LostLegend_Pnl.BackColor

                ElseIf .Item("stk_changes", e.RowIndex).Value.ToString = "Transfer" Then
                    .Item("Control No.", e.RowIndex).Style.ForeColor = TransferLegend_Pnl.BackColor
                    .Item("Control No.", e.RowIndex).Style.SelectionForeColor = TransferLegend_Pnl.BackColor

                Else
                    .Item("Control No.", e.RowIndex).Style.ForeColor = Color.Black
                    .Item("Control No.", e.RowIndex).Style.SelectionForeColor = Color.Black
                End If
                'If .Item("Date Returned", e.RowIndex).Value.ToString <> "" Then
                '    .Item("Control No.", e.RowIndex).Style.ForeColor = ReturnLegend_Pnl.BackColor
                '    .Item("Control No.", e.RowIndex).Style.SelectionForeColor = ReturnLegend_Pnl.BackColor
                'Else
                '    If .Item("Remarks", e.RowIndex).Value.ToString.Contains("Lost") Then
                '        .Item("Control No.", e.RowIndex).Style.ForeColor = LostLegend_Pnl.BackColor
                '        .Item("Control No.", e.RowIndex).Style.SelectionForeColor = LostLegend_Pnl.BackColor

                '    ElseIf .Item("Remarks", e.RowIndex).Value.ToString.Contains("Transferred") Then
                '        .Item("Control No.", e.RowIndex).Style.ForeColor = TransferLegend_Pnl.BackColor
                '        .Item("Control No.", e.RowIndex).Style.SelectionForeColor = TransferLegend_Pnl.BackColor

                '    Else
                '        .Item("Control No.", e.RowIndex).Style.ForeColor = Color.Black
                '        .Item("Control No.", e.RowIndex).Style.SelectionForeColor = Color.Black

                '    End If
                'End If
            End With
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub dgv_cellmousedoubleclick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex <> -1 And sender.rows.count <> 0 Then
                With DGV_Search_Inventory
                    stockno = .Item("STOCKNO", e.RowIndex).Value
                    Desc_Cbox.Text = .Item("DESCRIPTION", e.RowIndex).Value.ToString
                    'Quantity_Num.Maximum = .Item("PHYSICAL", e.RowIndex).Value
                    Unit_Tbox.Text = .Item("UNIT", e.RowIndex).Value.ToString
                    UnitPrice_Num.Value = .Item("UNITPRICE", e.RowIndex).Value
                End With
                Quantity_Num.Focus()
                Quantity_Num.Select(0, Quantity_Num.Text.Length)
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub SearchAcct_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles SearchAcct_Tbox.ButtonClick
        search_acct = Trim(SearchAcct_Tbox.Text)
        todo = "load_acctblty"
        Start_BGW()
    End Sub
    Private Sub FilterReq_Btn_Click(sender As Object, e As EventArgs) Handles FilterReq_Btn.Click
        Filter2_Pnl.BringToFront()
        If Filter2_Pnl.Visible = True Then
            Filter2_Pnl.Visible = False
            If Return_Chk.Checked = True Then
                return_str = "Return"
            Else
                return_str = "notReturn"
            End If

            If Lost_Chk.Checked = True Then
                lost_str = "Lost"
            Else
                lost_str = "notLost"
            End If

            If Transferred_Chk.Checked = True Then
                transferred_str = "Transfer"
            Else
                transferred_str = "notTransfer"
            End If

            If All_Chk.Checked = True Then
                return_str = "Return"
                lost_str = "Lost"
                transferred_str = "Transfer"
                all_str = ""
            Else
                all_str = "notall"
            End If

            If DeptFilter_Cbox.Text = "" And EmpFilter_Cbox.Text = "" Then
                search_acct = ""
                todo = "load_acctblty"
            Else
                search_acct = EmpFilter_Cbox.SelectedValue
                todo = "load_acctblty_byEmpID"
            End If
            Start_BGW()
        Else
            Filter2_Pnl.Visible = True
        End If
    End Sub

    Private Sub SearchAcct_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchAcct_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchAcct_Tbox.CustomButton.PerformClick()
        End If
    End Sub

    Private Sub dgv_dataerror(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub dgv_rowpostpaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub

    Private Sub Search_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Search_Tbox.ButtonClick
        current_mode_string = Mode_Lbl.Text
        current_mode_color = Mode_Lbl.ForeColor

        Loading2_PB.BringToFront()
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

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        If fieldtrim() = True Then
            current_mode_string = Mode_Lbl.Text
            current_mode_color = Mode_Lbl.ForeColor
            Mode_Lbl.Text = "Saving."

            todo_mode = "after_trans"
            If acctblty_id = 0 Then
                todo = "transSaveAcct"
            Else
                todo = "transEditAcct"
            End If
            Start_BGW()
        Else
            KMDIPrompts(Me, "UserWarning",,,, True, True, "Invalid Quantity", False)
        End If
    End Sub

    Private Sub Clear_Btn_Click(sender As Object, e As EventArgs) Handles Clear_Btn.Click
        For Each ctrl In Fields_Pnl.Controls
            If ctrl.Name.Contains("Tbox") Or ctrl.name.Contains("Cbox") Then
                ctrl.Text = ""
            End If
        Next
        Quantity_Num.Value = 0
        UnitPrice_Num.Value = 0
        CtrlNo_Tbox.CustomButton.PerformClick()
        DeptFilter_Cbox.Text = ""
        EmpFilter_Cbox.Text = ""
        itemsclear()
    End Sub

    Private Sub Refresh_Btn_Click(sender As Object, e As EventArgs) Handles Refresh_Btn.Click
        Loading_PB.BringToFront()
        search_acct = ""
        EmpFilter_Cbox.Text = ""

        todo_mode = "refresh"
        todo = "load_acctblty"
        Start_BGW()
    End Sub

    Private Sub AccountabilityFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Save_Btn.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            Clear_Btn.PerformClick()
        ElseIf e.KeyCode = Keys.F5 Then
            Refresh_Btn.PerformClick()
        End If
    End Sub

    Private Sub CtrlNo_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles CtrlNo_Tbox.ButtonClick
        current_mode_string = Mode_Lbl.Text
        current_mode_color = Mode_Lbl.ForeColor
        Mode_Lbl.Text = "Getting latest control number."

        todo = "getmax_ctrlno"
        Start_BGW()
    End Sub

    Private Sub Get_Btn_Click(sender As Object, e As EventArgs) Handles Get_Btn.Click, Recget_Btn.Click
        btn_clicking = sender

        current_mode_string = Mode_Lbl.Text
        current_mode_color = Mode_Lbl.ForeColor
        Mode_Lbl.Text = "Getting employee."

        If sender Is Get_Btn Then
            search = EmpID_Cbox.Text
            For Each ctrl In Fields_Pnl.Controls
                If ctrl.Name.Contains("Emp") Then
                    ctrl.Text = ""
                End If
            Next
        ElseIf sender Is Recget_Btn Then
            search = RecByID_Cbox.Text
            RecByID_Cbox.Text = ""
            ReceivedBy_Cbox.Text = ""
        End If

        todo = "get_employee"
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

    Private Sub EmpID_Cbox_KeyDown(sender As Object, e As KeyEventArgs) Handles EmpID_Cbox.KeyDown, RecByID_Cbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender Is EmpID_Cbox Then
                Get_Btn.PerformClick()
            ElseIf sender Is RecByID_Cbox Then
                Recget_Btn.PerformClick()
            End If
        End If
    End Sub

    Private Sub DeptFilter_Cbox_SelectedIndexChanged(sender As Object, e As EventArgs)
        current_mode_string = Mode_Lbl.Text
        current_mode_color = Mode_Lbl.ForeColor

        CboxselIndex = sender.SelectedIndex
        Mode_Lbl.Text = "Getting lists of employee."

        deptfilter_str = DeptFilter_Cbox.Text
        todo = "get_empfilter"
        Start_BGW()
    End Sub

    Private Sub EmpFilter_Cbox_SelectedIndexChanged(sender As Object, e As EventArgs)
        current_mode_string = Mode_Lbl.Text
        current_mode_color = Mode_Lbl.ForeColor
        Mode_Lbl.Text = "Getting requests of employee."

        search_acct = EmpFilter_Cbox.SelectedValue.ToString
        todo = "load_acctblty_byEmpID"
        'todo = "load_acctblty"
        Start_BGW()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Dim items As DataGridViewSelectedRowCollection = DGV_Accountability.SelectedRows
        For Each item As DataGridViewRow In items
            acctblty_id_list.Add(item.Cells("acctblty_id").Value)
        Next
        ReturnFrm.ShowDialog()
    End Sub

    Private Sub LostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LostToolStripMenuItem.Click
        Dim items As DataGridViewSelectedRowCollection = DGV_Accountability.SelectedRows
        For Each item As DataGridViewRow In items
            acctblty_id_list.Add(item.Cells("acctblty_id").Value)
        Next
        remarks = LostToolStripMenuItem.Text
        todo_mode = "after_trans"
        todo = "transRemarksAcct"
        Start_BGW()
    End Sub

    Private Sub TransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferToolStripMenuItem.Click
        Dim items As DataGridViewSelectedRowCollection = DGV_Accountability.SelectedRows
        For Each item As DataGridViewRow In items
            acctblty_id_list.Add(item.Cells("acctblty_id").Value)
        Next
        remarks = TransferToolStripMenuItem.Tag
        TransferFrm.ShowDialog()
        'todo_mode = "after_trans"
        'todo = "transRemarksAcct"
        'Start_BGW()
    End Sub
    Private Sub Cbox_MouseDown(sender As Object, e As MouseEventArgs) Handles EmpID_Cbox.MouseDown,
                                                                              EmpName_Cbox.MouseDown,
                                                                              EmpPosition_Cbox.MouseDown,
                                                                              EmpDept_Cbox.MouseDown,
                                                                              Desc_Cbox.MouseDown,
                                                                              RecByID_Cbox.MouseDown,
                                                                              ReceivedBy_Cbox.MouseDown
        current_mode_string = Mode_Lbl.Text
        current_mode_color = Mode_Lbl.ForeColor
        CboxselIndex = sender.SelectedIndex
        cbox_obj = sender
        cols = sender.Tag
        todo = "Load_ComboBoxData"
        Start_BGW()

    End Sub
End Class