Public Class PrintReturnablesFrm
    Private Sub PrintReturnablesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class