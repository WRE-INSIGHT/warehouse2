Public Class ReturnFrm
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

    Private Sub AssignPnlAccept_Btn_Click(sender As Object, e As EventArgs) Handles AssignPnlAccept_Btn.Click
        With AccountabilityFrm
            .date_returned = Return_DTP.Value.ToString("MMM. dd, yyyy hh:mm:ss tt")
            .todo_mode = "after_trans"
            .todo = "transReturnAcct"
            .Start_BGW()
        End With
        Close()
    End Sub

    Private Sub ReturnFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

End Class