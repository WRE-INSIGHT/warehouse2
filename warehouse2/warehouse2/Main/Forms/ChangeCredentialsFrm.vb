Public Class ChangeCredentialsFrm
    Private Sub ChangeCredentialsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fullname_Tbox.Text = user_fullname
        Nickname_Tbox.Text = user_nick
        Username_Tbox.Text = user

        'Password_Tbox.Tag = pass
        'OldPassword_Tbox.Tag = pass
    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click
        Try
            If OldPassword_Tbox.Text = Nothing Then
                KMDIPrompts(Me, "UserWarning",,,, True, True, "Old password required", False)
                OldPassword_Tbox.Focus()
                Exit Sub

            ElseIf Password_Tbox.Text <> Retype_Tbox.Text Then
                KMDIPrompts(Me, "UserWarning",,,, True, True, "Passwords does not match", False)
                Password_Tbox.Focus()
                Exit Sub

            ElseIf OldPassword_Tbox.Text <> pass Then
                KMDIPrompts(Me, "UserWarning",,,, True, True, "Old password does not match", False)
                OldPassword_Tbox.Focus()
                Exit Sub

            ElseIf Password_Tbox.Text = Retype_Tbox.Text And OldPassword_Tbox.Text = pass Then
                Dim fullname, nickname, username, password As String

                If Fullname_Tbox.Enabled = True Then
                    fullname = Trim(Fullname_Tbox.Text)
                Else
                    fullname = user_fullname
                End If

                If Nickname_Tbox.Enabled = True Then
                    nickname = Trim(Nickname_Tbox.Text)
                Else
                    nickname = user_nick
                End If

                If Username_Tbox.Enabled = True Then
                    username = Trim(Username_Tbox.Text)
                    WarehouseMain_STP("warehouse_main_stp", "getuser",,, username,,)
                    If sqlDataSet.Tables("getuser").Rows(0).Item(0) <> 0 Then
                        KMDIPrompts(Me, "UserWarning",,,, True, True, "Exisiting username", True)
                        Exit Sub
                    End If
                Else
                    username = user
                End If

                If Password_Tbox.Enabled = True Then

                    If Trim(Password_Tbox.Text) = Nothing Or Trim(Retype_Tbox.Text) = Nothing Then
                        KMDIPrompts(Me, "UserWarning",,,, True, True, "Invalid password.", False)
                        Password_Tbox.Focus()
                        Exit Sub
                    Else
                        password = Trim(Password_Tbox.Text)

                    End If
                Else
                    password = pass
                End If

                WarehouseMain_STP("warehouse_main_stp", "transchangecred", fullname, nickname, username, password, user_id)

                If sql_Transaction_result = "Committed" Then
                    KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True,,, False)
                    MessageBox.Show(Me, "Relogin to apply changes. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    LoginFrm.Close()
                Else
                    KMDIPrompts(Me, "DotNetError", "", "", Nothing, True, True, "Failed", False)
                End If


            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
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