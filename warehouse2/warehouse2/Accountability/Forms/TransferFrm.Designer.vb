<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Header_Pnl = New System.Windows.Forms.Panel()
        Me.AssignPnlAccept_Btn = New System.Windows.Forms.Button()
        Me.AssignPnlExit_Btn = New System.Windows.Forms.Button()
        Me.EmpName_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.EmpID_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Recget_Btn = New MetroFramework.Controls.MetroButton()
        Me.Header_Pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header_Pnl
        '
        Me.Header_Pnl.BackColor = System.Drawing.Color.Gray
        Me.Header_Pnl.Controls.Add(Me.AssignPnlAccept_Btn)
        Me.Header_Pnl.Controls.Add(Me.AssignPnlExit_Btn)
        Me.Header_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.Header_Pnl.Margin = New System.Windows.Forms.Padding(0)
        Me.Header_Pnl.Name = "Header_Pnl"
        Me.Header_Pnl.Size = New System.Drawing.Size(386, 25)
        Me.Header_Pnl.TabIndex = 4
        '
        'AssignPnlAccept_Btn
        '
        Me.AssignPnlAccept_Btn.BackColor = System.Drawing.Color.Transparent
        Me.AssignPnlAccept_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.AssignPnlAccept_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.AssignPnlAccept_Btn.FlatAppearance.BorderSize = 0
        Me.AssignPnlAccept_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssignPnlAccept_Btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignPnlAccept_Btn.ForeColor = System.Drawing.Color.Green
        Me.AssignPnlAccept_Btn.Location = New System.Drawing.Point(318, 0)
        Me.AssignPnlAccept_Btn.Name = "AssignPnlAccept_Btn"
        Me.AssignPnlAccept_Btn.Size = New System.Drawing.Size(34, 25)
        Me.AssignPnlAccept_Btn.TabIndex = 2
        Me.AssignPnlAccept_Btn.Text = "✔"
        Me.AssignPnlAccept_Btn.UseVisualStyleBackColor = False
        '
        'AssignPnlExit_Btn
        '
        Me.AssignPnlExit_Btn.BackColor = System.Drawing.Color.Transparent
        Me.AssignPnlExit_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AssignPnlExit_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.AssignPnlExit_Btn.FlatAppearance.BorderSize = 0
        Me.AssignPnlExit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssignPnlExit_Btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignPnlExit_Btn.ForeColor = System.Drawing.Color.Black
        Me.AssignPnlExit_Btn.Location = New System.Drawing.Point(352, 0)
        Me.AssignPnlExit_Btn.Name = "AssignPnlExit_Btn"
        Me.AssignPnlExit_Btn.Size = New System.Drawing.Size(34, 25)
        Me.AssignPnlExit_Btn.TabIndex = 3
        Me.AssignPnlExit_Btn.Text = "X"
        Me.AssignPnlExit_Btn.UseVisualStyleBackColor = False
        '
        'EmpName_Tbox
        '
        '
        '
        '
        Me.EmpName_Tbox.CustomButton.Image = Nothing
        Me.EmpName_Tbox.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.EmpName_Tbox.CustomButton.Name = ""
        Me.EmpName_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.EmpName_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpName_Tbox.CustomButton.TabIndex = 1
        Me.EmpName_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmpName_Tbox.CustomButton.UseSelectable = True
        Me.EmpName_Tbox.CustomButton.Visible = False
        Me.EmpName_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.EmpName_Tbox.Lines = New String(-1) {}
        Me.EmpName_Tbox.Location = New System.Drawing.Point(176, 34)
        Me.EmpName_Tbox.MaxLength = 32767
        Me.EmpName_Tbox.Name = "EmpName_Tbox"
        Me.EmpName_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmpName_Tbox.ReadOnly = True
        Me.EmpName_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpName_Tbox.SelectedText = ""
        Me.EmpName_Tbox.SelectionLength = 0
        Me.EmpName_Tbox.SelectionStart = 0
        Me.EmpName_Tbox.Size = New System.Drawing.Size(198, 25)
        Me.EmpName_Tbox.TabIndex = 846
        Me.EmpName_Tbox.UseSelectable = True
        Me.EmpName_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpName_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'EmpID_Tbox
        '
        '
        '
        '
        Me.EmpID_Tbox.CustomButton.Image = Nothing
        Me.EmpID_Tbox.CustomButton.Location = New System.Drawing.Point(82, 1)
        Me.EmpID_Tbox.CustomButton.Name = ""
        Me.EmpID_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.EmpID_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpID_Tbox.CustomButton.TabIndex = 1
        Me.EmpID_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmpID_Tbox.CustomButton.UseSelectable = True
        Me.EmpID_Tbox.CustomButton.Visible = False
        Me.EmpID_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.EmpID_Tbox.Lines = New String(-1) {}
        Me.EmpID_Tbox.Location = New System.Drawing.Point(12, 34)
        Me.EmpID_Tbox.MaxLength = 32767
        Me.EmpID_Tbox.Name = "EmpID_Tbox"
        Me.EmpID_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EmpID_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpID_Tbox.SelectedText = ""
        Me.EmpID_Tbox.SelectionLength = 0
        Me.EmpID_Tbox.SelectionStart = 0
        Me.EmpID_Tbox.Size = New System.Drawing.Size(106, 25)
        Me.EmpID_Tbox.TabIndex = 849
        Me.EmpID_Tbox.Tag = "emp_id"
        Me.EmpID_Tbox.UseSelectable = True
        Me.EmpID_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpID_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Recget_Btn
        '
        Me.Recget_Btn.Location = New System.Drawing.Point(124, 34)
        Me.Recget_Btn.Name = "Recget_Btn"
        Me.Recget_Btn.Size = New System.Drawing.Size(46, 25)
        Me.Recget_Btn.TabIndex = 850
        Me.Recget_Btn.Text = "Get"
        Me.Recget_Btn.UseSelectable = True
        '
        'TransferFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.AssignPnlExit_Btn
        Me.ClientSize = New System.Drawing.Size(386, 72)
        Me.ControlBox = False
        Me.Controls.Add(Me.Recget_Btn)
        Me.Controls.Add(Me.EmpName_Tbox)
        Me.Controls.Add(Me.Header_Pnl)
        Me.Controls.Add(Me.EmpID_Tbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TransferFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Header_Pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header_Pnl As Panel
    Friend WithEvents AssignPnlAccept_Btn As Button
    Friend WithEvents AssignPnlExit_Btn As Button
    Friend WithEvents EmpName_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents EmpID_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Recget_Btn As MetroFramework.Controls.MetroButton
End Class
