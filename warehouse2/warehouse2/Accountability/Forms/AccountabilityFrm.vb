Public Class AccountabilityFrm

    Private Sub Btn_Pnl_SizeChanged(sender As Object, e As EventArgs) Handles Btn_Pnl.SizeChanged
        For Each btn In sender.Controls
            btn.Width = Btn_Pnl.Width / 5
        Next
    End Sub

    Private Sub AccountabilityFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class