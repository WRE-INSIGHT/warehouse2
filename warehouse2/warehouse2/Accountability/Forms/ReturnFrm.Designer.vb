<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnFrm
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
        Me.Return_DTP = New MetroFramework.Controls.MetroDateTime()
        Me.Header_Pnl = New System.Windows.Forms.Panel()
        Me.AssignPnlAccept_Btn = New System.Windows.Forms.Button()
        Me.AssignPnlExit_Btn = New System.Windows.Forms.Button()
        Me.Header_Pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Return_DTP
        '
        Me.Return_DTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Return_DTP.Location = New System.Drawing.Point(12, 35)
        Me.Return_DTP.MinimumSize = New System.Drawing.Size(0, 29)
        Me.Return_DTP.Name = "Return_DTP"
        Me.Return_DTP.Size = New System.Drawing.Size(230, 29)
        Me.Return_DTP.TabIndex = 0
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
        Me.Header_Pnl.Size = New System.Drawing.Size(253, 25)
        Me.Header_Pnl.TabIndex = 3
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
        Me.AssignPnlAccept_Btn.Location = New System.Drawing.Point(185, 0)
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
        Me.AssignPnlExit_Btn.Location = New System.Drawing.Point(219, 0)
        Me.AssignPnlExit_Btn.Name = "AssignPnlExit_Btn"
        Me.AssignPnlExit_Btn.Size = New System.Drawing.Size(34, 25)
        Me.AssignPnlExit_Btn.TabIndex = 3
        Me.AssignPnlExit_Btn.Text = "X"
        Me.AssignPnlExit_Btn.UseVisualStyleBackColor = False
        '
        'ReturnFrm
        '
        Me.AcceptButton = Me.AssignPnlAccept_Btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.AssignPnlExit_Btn
        Me.ClientSize = New System.Drawing.Size(253, 76)
        Me.ControlBox = False
        Me.Controls.Add(Me.Header_Pnl)
        Me.Controls.Add(Me.Return_DTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReturnFrm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Header_Pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Return_DTP As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Header_Pnl As Panel
    Friend WithEvents AssignPnlAccept_Btn As Button
    Friend WithEvents AssignPnlExit_Btn As Button
End Class
