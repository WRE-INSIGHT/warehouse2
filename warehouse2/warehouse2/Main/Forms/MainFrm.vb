Public Class MainFrm
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = user_fullname
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        'If InventoryToolStripMenuItem.Checked = True Then
        Dim inv As Form = WarehouseInvFrm
        inv.MdiParent = Me
        inv.WindowState = FormWindowState.Maximized
        inv.Show()
        SystemToolStripMenuItem.HideDropDown()
        'Else
        '    WarehouseInvFrm.Close()
        'End If

    End Sub

    Private Sub MainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KMDIPrompts(Me, "Question", "Are you sure you want to Exit?", Nothing, Nothing, True,,, False)
        If QuestionPromptAnswer = 6 Then
            LoginFrm.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        WarehouseInvFrm.save()
    End Sub

    Private Sub AccountabilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountabilityToolStripMenuItem.Click
        Dim acct As Form = AccountabilityFrm
        acct.MdiParent = Me
        acct.WindowState = FormWindowState.Maximized
        acct.Show()
        AccountabilityFrm.frm_Split.SplitterDistance = 478

    End Sub

    Private Sub ChangeCredentialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCredentialsToolStripMenuItem.Click
        Dim cred As Form = ChangeCredentialsFrm
        cred.ShowDialog()
    End Sub
End Class