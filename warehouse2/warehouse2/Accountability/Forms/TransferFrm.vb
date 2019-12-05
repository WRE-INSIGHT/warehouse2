Public Class TransferFrm

    Private Drag As Boolean
    Public MouseX, MouseY As Integer

    Private Sub Header_Pnl_MouseDown(sender As Object, e As MouseEventArgs) Handles Header_Pnl.MouseDown
        Drag = True
        MouseX = Cursor.Position.X - Left
        MouseY = Cursor.Position.Y - Top
    End Sub

    Private Sub Header_Pnl_MouseMove(sender As Object, e As MouseEventArgs) Handles Header_Pnl.MouseMove
        If Drag Then
            Top = Cursor.Position.Y - MouseY
            Left = Cursor.Position.X - MouseX
        End If
    End Sub
    Private Sub Header_Pnl_MouseUp(sender As Object, e As MouseEventArgs) Handles Header_Pnl.MouseUp
        Drag = False
    End Sub
    Private Sub AssignPnlExit_Btn_Click(sender As Object, e As EventArgs) Handles AssignPnlExit_Btn.Click
        Close()
    End Sub

    Private Sub TransferFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dispose()
    End Sub

    Private Sub TransferFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Accountability_Inv_STP("warehouse_acctblty_stp", "get_employee", "")

        'With AccountabilityFrm
        '    EmpID_Cbox.DataSource = sqlDataSet.Tables("get_employee")
        '    EmpID_Cbox.DisplayMember = "Emp_ID"
        '    EmpID_Cbox.ValueMember = "Emp_Name"
        '    EmpID_Cbox.SelectedIndex = -1
        'End With

        'AddHandler EmpID_Cbox.SelectedIndexChanged, AddressOf EmpID_Cbox_SelectedIndexChanged
    End Sub

    Private Sub AssignPnlAccept_Btn_Click(sender As Object, e As EventArgs) Handles AssignPnlAccept_Btn.Click
        KMDIPrompts(Me, "Question", "Are you sure?", Nothing, Nothing, True,,, False)
        If QuestionPromptAnswer = 6 Then
            With AccountabilityFrm
                .emp_id = EmpID_Tbox.Text
                .remarks += " " & EmpName_Tbox.Text
                .todo_mode = "after_trans"
                .todo = "transRemarksAcct"
                .Start_BGW()
            End With
            Close()
        End If
    End Sub

    Private Sub EmpID_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles EmpID_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Recget_Btn.PerformClick()
        End If
    End Sub

    Private Sub Recget_Btn_Click(sender As Object, e As EventArgs) Handles Recget_Btn.Click
        Try
            Accountability_Inv_STP("warehouse_acctblty_stp", "get_employee", EmpID_Tbox.Text)
            EmpName_Tbox.Text = sqlDataSet.Tables("get_employee").Rows(0).Item("Emp_Name").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class