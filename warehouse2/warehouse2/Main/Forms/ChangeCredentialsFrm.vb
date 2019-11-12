Public Class ChangeCredentialsFrm
    Private Sub ChangeCredentialsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fullname_Tbox.Text = user_fullname
        Nickname_Tbox.Text = user_nick
        Username_Tbox.Text = user

        'Password_Tbox.Tag = pass
        'OldPassword_Tbox.Tag = pass
    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click
        If OldPassword_Tbox.Text = Nothing Then
            KMDIPrompts(Me, "UserWarning",,,, True, True, "Old password required", False)
            OldPassword_Tbox.Focus()

        ElseIf OldPassword_Tbox.Text <> pass Then
            KMDIPrompts(Me, "UserWarning",,,, True, True, "Old password does not match", False)
            OldPassword_Tbox.Focus()

        ElseIf Password_Tbox.Text <> Retype_Tbox.Text Then
            KMDIPrompts(Me, "UserWarning",,,, True, True, "Passwords does not match", False)
            Password_Tbox.Focus()

        ElseIf Password_Tbox.Text = Retype_Tbox.Text And OldPassword_Tbox.Text = pass Then
            'KMDIPrompts(Me, "UserWarning",,,, True, True, "Passwords does not match", False)
            MsgBox("success")
        End If
    End Sub

    Private Sub Chk_CheckedChanged(sender As Object, e As EventArgs) Handles Fullname_Chk.CheckedChanged,
                                                                             Nickname_Chk.CheckedChanged,
                                                                             Username_Chk.CheckedChanged,
                                                                             NewPass_Chk.CheckedChanged
        For Each ctrl In Controls
            If ctrl.Tag = sender.Name.ToString Then
                ctrl.Enabled = sender.Checked
                ctrl.Focus()
            End If
        Next
    End Sub
End Class