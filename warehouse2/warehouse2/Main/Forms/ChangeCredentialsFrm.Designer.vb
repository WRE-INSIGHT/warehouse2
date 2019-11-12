<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangeCredentialsFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeCredentialsFrm))
        Me.Fullname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Nickname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Username_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Password_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Retype_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Line_Pnl = New System.Windows.Forms.Panel()
        Me.OldPassword_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.Cancel_Btn = New System.Windows.Forms.Button()
        Me.Fullname_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Nickname_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Username_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.NewPass_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Fullname_Tbox
        '
        Me.Fullname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Fullname_Tbox.CustomButton.Image = Nothing
        Me.Fullname_Tbox.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.Fullname_Tbox.CustomButton.Name = ""
        Me.Fullname_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Fullname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Fullname_Tbox.CustomButton.TabIndex = 1
        Me.Fullname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Fullname_Tbox.CustomButton.UseSelectable = True
        Me.Fullname_Tbox.CustomButton.Visible = False
        Me.Fullname_Tbox.Enabled = False
        Me.Fullname_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Fullname_Tbox.Lines = New String(-1) {}
        Me.Fullname_Tbox.Location = New System.Drawing.Point(151, 25)
        Me.Fullname_Tbox.MaxLength = 32767
        Me.Fullname_Tbox.Name = "Fullname_Tbox"
        Me.Fullname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Fullname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Fullname_Tbox.SelectedText = ""
        Me.Fullname_Tbox.SelectionLength = 0
        Me.Fullname_Tbox.SelectionStart = 0
        Me.Fullname_Tbox.Size = New System.Drawing.Size(205, 25)
        Me.Fullname_Tbox.TabIndex = 840
        Me.Fullname_Tbox.Tag = "Fullname_Chk"
        Me.Fullname_Tbox.UseSelectable = True
        Me.Fullname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Fullname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Nickname_Tbox
        '
        Me.Nickname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Nickname_Tbox.CustomButton.Image = Nothing
        Me.Nickname_Tbox.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.Nickname_Tbox.CustomButton.Name = ""
        Me.Nickname_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Nickname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Nickname_Tbox.CustomButton.TabIndex = 1
        Me.Nickname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Nickname_Tbox.CustomButton.UseSelectable = True
        Me.Nickname_Tbox.CustomButton.Visible = False
        Me.Nickname_Tbox.Enabled = False
        Me.Nickname_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Nickname_Tbox.Lines = New String(-1) {}
        Me.Nickname_Tbox.Location = New System.Drawing.Point(151, 56)
        Me.Nickname_Tbox.MaxLength = 32767
        Me.Nickname_Tbox.Name = "Nickname_Tbox"
        Me.Nickname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nickname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Nickname_Tbox.SelectedText = ""
        Me.Nickname_Tbox.SelectionLength = 0
        Me.Nickname_Tbox.SelectionStart = 0
        Me.Nickname_Tbox.Size = New System.Drawing.Size(205, 25)
        Me.Nickname_Tbox.TabIndex = 842
        Me.Nickname_Tbox.Tag = "Nickname_Chk"
        Me.Nickname_Tbox.UseSelectable = True
        Me.Nickname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Nickname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Username_Tbox
        '
        Me.Username_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Username_Tbox.CustomButton.Image = Nothing
        Me.Username_Tbox.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.Username_Tbox.CustomButton.Name = ""
        Me.Username_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Username_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Username_Tbox.CustomButton.TabIndex = 1
        Me.Username_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Username_Tbox.CustomButton.UseSelectable = True
        Me.Username_Tbox.CustomButton.Visible = False
        Me.Username_Tbox.Enabled = False
        Me.Username_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Username_Tbox.Lines = New String(-1) {}
        Me.Username_Tbox.Location = New System.Drawing.Point(151, 96)
        Me.Username_Tbox.MaxLength = 32767
        Me.Username_Tbox.Name = "Username_Tbox"
        Me.Username_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Username_Tbox.SelectedText = ""
        Me.Username_Tbox.SelectionLength = 0
        Me.Username_Tbox.SelectionStart = 0
        Me.Username_Tbox.Size = New System.Drawing.Size(205, 25)
        Me.Username_Tbox.TabIndex = 844
        Me.Username_Tbox.Tag = "Username_Chk"
        Me.Username_Tbox.UseSelectable = True
        Me.Username_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Username_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Password_Tbox
        '
        Me.Password_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Password_Tbox.CustomButton.Image = Nothing
        Me.Password_Tbox.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.Password_Tbox.CustomButton.Name = ""
        Me.Password_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Password_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password_Tbox.CustomButton.TabIndex = 1
        Me.Password_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password_Tbox.CustomButton.UseSelectable = True
        Me.Password_Tbox.CustomButton.Visible = False
        Me.Password_Tbox.Enabled = False
        Me.Password_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Password_Tbox.Lines = New String(-1) {}
        Me.Password_Tbox.Location = New System.Drawing.Point(151, 127)
        Me.Password_Tbox.MaxLength = 32767
        Me.Password_Tbox.Name = "Password_Tbox"
        Me.Password_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Password_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password_Tbox.SelectedText = ""
        Me.Password_Tbox.SelectionLength = 0
        Me.Password_Tbox.SelectionStart = 0
        Me.Password_Tbox.ShowClearButton = True
        Me.Password_Tbox.Size = New System.Drawing.Size(205, 25)
        Me.Password_Tbox.TabIndex = 846
        Me.Password_Tbox.Tag = "NewPass_Chk"
        Me.Password_Tbox.UseSelectable = True
        Me.Password_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Password_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Retype_Tbox
        '
        Me.Retype_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Retype_Tbox.CustomButton.Image = Nothing
        Me.Retype_Tbox.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.Retype_Tbox.CustomButton.Name = ""
        Me.Retype_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Retype_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Retype_Tbox.CustomButton.TabIndex = 1
        Me.Retype_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Retype_Tbox.CustomButton.UseSelectable = True
        Me.Retype_Tbox.CustomButton.Visible = False
        Me.Retype_Tbox.Enabled = False
        Me.Retype_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Retype_Tbox.Lines = New String(-1) {}
        Me.Retype_Tbox.Location = New System.Drawing.Point(151, 158)
        Me.Retype_Tbox.MaxLength = 32767
        Me.Retype_Tbox.Name = "Retype_Tbox"
        Me.Retype_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Retype_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Retype_Tbox.SelectedText = ""
        Me.Retype_Tbox.SelectionLength = 0
        Me.Retype_Tbox.SelectionStart = 0
        Me.Retype_Tbox.Size = New System.Drawing.Size(205, 25)
        Me.Retype_Tbox.TabIndex = 848
        Me.Retype_Tbox.Tag = "NewPass_Chk"
        Me.Retype_Tbox.UseSelectable = True
        Me.Retype_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Retype_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Line_Pnl
        '
        Me.Line_Pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line_Pnl.BackColor = System.Drawing.Color.LightSlateGray
        Me.Line_Pnl.Location = New System.Drawing.Point(10, 88)
        Me.Line_Pnl.Name = "Line_Pnl"
        Me.Line_Pnl.Size = New System.Drawing.Size(346, 2)
        Me.Line_Pnl.TabIndex = 849
        '
        'OldPassword_Tbox
        '
        Me.OldPassword_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.OldPassword_Tbox.CustomButton.Image = Nothing
        Me.OldPassword_Tbox.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.OldPassword_Tbox.CustomButton.Name = ""
        Me.OldPassword_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.OldPassword_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.OldPassword_Tbox.CustomButton.TabIndex = 1
        Me.OldPassword_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.OldPassword_Tbox.CustomButton.UseSelectable = True
        Me.OldPassword_Tbox.CustomButton.Visible = False
        Me.OldPassword_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.OldPassword_Tbox.Lines = New String(-1) {}
        Me.OldPassword_Tbox.Location = New System.Drawing.Point(151, 189)
        Me.OldPassword_Tbox.MaxLength = 32767
        Me.OldPassword_Tbox.Name = "OldPassword_Tbox"
        Me.OldPassword_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.OldPassword_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OldPassword_Tbox.SelectedText = ""
        Me.OldPassword_Tbox.SelectionLength = 0
        Me.OldPassword_Tbox.SelectionStart = 0
        Me.OldPassword_Tbox.Size = New System.Drawing.Size(205, 25)
        Me.OldPassword_Tbox.TabIndex = 851
        Me.OldPassword_Tbox.UseSelectable = True
        Me.OldPassword_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.OldPassword_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Save_btn
        '
        Me.Save_btn.AutoSize = True
        Me.Save_btn.BackColor = System.Drawing.Color.DarkGray
        Me.Save_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Save_btn.FlatAppearance.BorderSize = 0
        Me.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_btn.Location = New System.Drawing.Point(281, 220)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(75, 33)
        Me.Save_btn.TabIndex = 852
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = False
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.ForeColor = System.Drawing.Color.Red
        Me.MetroLabel6.Location = New System.Drawing.Point(18, 189)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(19, 25)
        Me.MetroLabel6.TabIndex = 853
        Me.MetroLabel6.Text = "*"
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'Cancel_Btn
        '
        Me.Cancel_Btn.AutoSize = True
        Me.Cancel_Btn.BackColor = System.Drawing.Color.DarkGray
        Me.Cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Btn.FlatAppearance.BorderSize = 0
        Me.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Btn.Location = New System.Drawing.Point(207, 220)
        Me.Cancel_Btn.Name = "Cancel_Btn"
        Me.Cancel_Btn.Size = New System.Drawing.Size(75, 33)
        Me.Cancel_Btn.TabIndex = 854
        Me.Cancel_Btn.Text = "Cancel"
        Me.Cancel_Btn.UseVisualStyleBackColor = False
        '
        'Fullname_Chk
        '
        Me.Fullname_Chk.AutoSize = True
        Me.Fullname_Chk.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.Fullname_Chk.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.Fullname_Chk.ForeColor = System.Drawing.Color.Black
        Me.Fullname_Chk.Location = New System.Drawing.Point(48, 25)
        Me.Fullname_Chk.Name = "Fullname_Chk"
        Me.Fullname_Chk.Size = New System.Drawing.Size(97, 25)
        Me.Fullname_Chk.Style = MetroFramework.MetroColorStyle.Black
        Me.Fullname_Chk.TabIndex = 855
        Me.Fullname_Chk.Text = "Fullname"
        Me.Fullname_Chk.UseCustomBackColor = True
        Me.Fullname_Chk.UseCustomForeColor = True
        Me.Fullname_Chk.UseSelectable = True
        '
        'Nickname_Chk
        '
        Me.Nickname_Chk.AutoSize = True
        Me.Nickname_Chk.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.Nickname_Chk.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.Nickname_Chk.ForeColor = System.Drawing.Color.Black
        Me.Nickname_Chk.Location = New System.Drawing.Point(41, 56)
        Me.Nickname_Chk.Name = "Nickname_Chk"
        Me.Nickname_Chk.Size = New System.Drawing.Size(104, 25)
        Me.Nickname_Chk.Style = MetroFramework.MetroColorStyle.Black
        Me.Nickname_Chk.TabIndex = 856
        Me.Nickname_Chk.Text = "Nickname"
        Me.Nickname_Chk.UseCustomBackColor = True
        Me.Nickname_Chk.UseCustomForeColor = True
        Me.Nickname_Chk.UseSelectable = True
        '
        'Username_Chk
        '
        Me.Username_Chk.AutoSize = True
        Me.Username_Chk.BackColor = System.Drawing.Color.DarkGray
        Me.Username_Chk.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.Username_Chk.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.Username_Chk.ForeColor = System.Drawing.Color.Black
        Me.Username_Chk.Location = New System.Drawing.Point(40, 96)
        Me.Username_Chk.Name = "Username_Chk"
        Me.Username_Chk.Size = New System.Drawing.Size(105, 25)
        Me.Username_Chk.Style = MetroFramework.MetroColorStyle.Black
        Me.Username_Chk.TabIndex = 857
        Me.Username_Chk.Text = "Username"
        Me.Username_Chk.UseCustomBackColor = True
        Me.Username_Chk.UseCustomForeColor = True
        Me.Username_Chk.UseSelectable = True
        '
        'NewPass_Chk
        '
        Me.NewPass_Chk.AutoSize = True
        Me.NewPass_Chk.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.NewPass_Chk.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.NewPass_Chk.ForeColor = System.Drawing.Color.Black
        Me.NewPass_Chk.Location = New System.Drawing.Point(7, 127)
        Me.NewPass_Chk.Name = "NewPass_Chk"
        Me.NewPass_Chk.Size = New System.Drawing.Size(138, 25)
        Me.NewPass_Chk.Style = MetroFramework.MetroColorStyle.Black
        Me.NewPass_Chk.TabIndex = 858
        Me.NewPass_Chk.Text = "New password"
        Me.NewPass_Chk.UseCustomBackColor = True
        Me.NewPass_Chk.UseCustomForeColor = True
        Me.NewPass_Chk.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(75, 158)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(70, 25)
        Me.MetroLabel5.TabIndex = 859
        Me.MetroLabel5.Text = "Re-type"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(30, 189)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(115, 25)
        Me.MetroLabel1.TabIndex = 860
        Me.MetroLabel1.Text = "Old Password"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'ChangeCredentialsFrm
        '
        Me.AcceptButton = Me.Save_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.CancelButton = Me.Cancel_Btn
        Me.ClientSize = New System.Drawing.Size(368, 266)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.NewPass_Chk)
        Me.Controls.Add(Me.Username_Chk)
        Me.Controls.Add(Me.Nickname_Chk)
        Me.Controls.Add(Me.Cancel_Btn)
        Me.Controls.Add(Me.Save_btn)
        Me.Controls.Add(Me.OldPassword_Tbox)
        Me.Controls.Add(Me.Line_Pnl)
        Me.Controls.Add(Me.Retype_Tbox)
        Me.Controls.Add(Me.Password_Tbox)
        Me.Controls.Add(Me.Username_Tbox)
        Me.Controls.Add(Me.Nickname_Tbox)
        Me.Controls.Add(Me.Fullname_Tbox)
        Me.Controls.Add(Me.Fullname_Chk)
        Me.Controls.Add(Me.MetroLabel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeCredentialsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Credentials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fullname_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Nickname_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Username_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Password_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Retype_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Line_Pnl As Panel
    Friend WithEvents OldPassword_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Save_btn As Button
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Cancel_Btn As Button
    Friend WithEvents Fullname_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Nickname_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Username_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents NewPass_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
