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
        Me.EmpID_Cbox = New System.Windows.Forms.ComboBox()
        Me.EmpName_Tbox = New MetroFramework.Controls.MetroTextBox()
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
        Me.Header_Pnl.Size = New System.Drawing.Size(332, 25)
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
        Me.AssignPnlAccept_Btn.Location = New System.Drawing.Point(264, 0)
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
        Me.AssignPnlExit_Btn.Location = New System.Drawing.Point(298, 0)
        Me.AssignPnlExit_Btn.Name = "AssignPnlExit_Btn"
        Me.AssignPnlExit_Btn.Size = New System.Drawing.Size(34, 25)
        Me.AssignPnlExit_Btn.TabIndex = 3
        Me.AssignPnlExit_Btn.Text = "X"
        Me.AssignPnlExit_Btn.UseVisualStyleBackColor = False
        '
        'EmpID_Cbox
        '
        Me.EmpID_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmpID_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpID_Cbox.DropDownHeight = 75
        Me.EmpID_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID_Cbox.FormattingEnabled = True
        Me.EmpID_Cbox.IntegralHeight = False
        Me.EmpID_Cbox.Location = New System.Drawing.Point(12, 34)
        Me.EmpID_Cbox.Name = "EmpID_Cbox"
        Me.EmpID_Cbox.Size = New System.Drawing.Size(106, 25)
        Me.EmpID_Cbox.TabIndex = 845
        Me.EmpID_Cbox.Tag = "emp_id"
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
        Me.EmpName_Tbox.Location = New System.Drawing.Point(124, 34)
        Me.EmpName_Tbox.MaxLength = 32767
        Me.EmpName_Tbox.Name = "EmpName_Tbox"
        Me.EmpName_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmpName_Tbox.ReadOnly = True
        Me.EmpName_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpName_Tbox.SelectedText = ""
        Me.EmpName_Tbox.SelectionLength = 0
        Me.EmpName_Tbox.SelectionStart = 0
        Me.EmpName_Tbox.Size = New System.Drawing.Size(196, 25)
        Me.EmpName_Tbox.TabIndex = 846
        Me.EmpName_Tbox.UseSelectable = True
        Me.EmpName_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpName_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TransferFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.AssignPnlExit_Btn
        Me.ClientSize = New System.Drawing.Size(332, 72)
        Me.ControlBox = False
        Me.Controls.Add(Me.EmpName_Tbox)
        Me.Controls.Add(Me.EmpID_Cbox)
        Me.Controls.Add(Me.Header_Pnl)
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
    Friend WithEvents EmpID_Cbox As ComboBox
    Friend WithEvents EmpName_Tbox As MetroFramework.Controls.MetroTextBox
End Class
