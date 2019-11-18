﻿Public Class TransferFrm

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
        Accountability_Inv_STP("warehouse_acctblty_stp", "get_employee", "")

        With AccountabilityFrm
            EmpID_Cbox.DataSource = sqlDataSet.Tables("get_employee")
            EmpID_Cbox.DisplayMember = "Emp_ID"
            EmpID_Cbox.ValueMember = "Emp_Name"
            EmpID_Cbox.SelectedIndex = -1
        End With

        AddHandler EmpID_Cbox.SelectedIndexChanged, AddressOf EmpID_Cbox_SelectedIndexChanged
    End Sub

    Private Sub AssignPnlAccept_Btn_Click(sender As Object, e As EventArgs) Handles AssignPnlAccept_Btn.Click
        With AccountabilityFrm
            .remarks += " " & EmpID_Cbox.Text & " " & EmpName_Tbox.Text
            .todo_mode = "after_trans"
            .todo = "transRemarksAcct"
            .Start_BGW()
        End With
        Close()
    End Sub

    Private Sub EmpID_Cbox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            EmpName_Tbox.Text = EmpID_Cbox.SelectedValue.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class