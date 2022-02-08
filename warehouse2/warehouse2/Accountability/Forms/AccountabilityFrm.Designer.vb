<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountabilityFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountabilityFrm))
        Me.frm_Split = New System.Windows.Forms.SplitContainer()
        Me.Fields_Pnl = New System.Windows.Forms.Panel()
        Me.Recget_Btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.Remarks_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.ReceivedBy_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Unit_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.Desc_Cbox = New System.Windows.Forms.ComboBox()
        Me.Item_Pnl = New System.Windows.Forms.Panel()
        Me.Loading2_PB = New System.Windows.Forms.PictureBox()
        Me.Search_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.CtrlNo_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Line_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.EmpDept_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.EmpPosition_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.EmpName_Cbox = New System.Windows.Forms.ComboBox()
        Me.Get_Btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Quantity_Num = New System.Windows.Forms.NumericUpDown()
        Me.UnitPrice_Num = New System.Windows.Forms.NumericUpDown()
        Me.EmpID_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.RecByID_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Pnl = New System.Windows.Forms.Panel()
        Me.Refresh_Btn = New System.Windows.Forms.Button()
        Me.Clear_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Edit_Btn = New System.Windows.Forms.Button()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Mode_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.Filter_Pnl = New System.Windows.Forms.Panel()
        Me.FilterReq_Btn = New System.Windows.Forms.Button()
        Me.Legends_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.UnauthorizedLegend_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.ReturnablesLegend_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.TransferLegend_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.LostLegend_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.ReturnLegend_Pnl = New System.Windows.Forms.Panel()
        Me.EmpFilter_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.DeptFilter_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.SearchAcct_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Loading_PB = New System.Windows.Forms.PictureBox()
        Me.Acctblty_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filter2_Pnl = New System.Windows.Forms.Panel()
        Me.Unauthorized_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Returnbles_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Lost_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Transferred_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Return_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.DateIssued_DTP = New System.Windows.Forms.DateTimePicker()
        CType(Me.frm_Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Split.Panel1.SuspendLayout()
        Me.frm_Split.Panel2.SuspendLayout()
        Me.frm_Split.SuspendLayout()
        Me.Fields_Pnl.SuspendLayout()
        Me.Item_Pnl.SuspendLayout()
        CType(Me.Loading2_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quantity_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPrice_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Btn_Pnl.SuspendLayout()
        Me.Filter_Pnl.SuspendLayout()
        Me.Legends_Pnl.SuspendLayout()
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Acctblty_Cmenu.SuspendLayout()
        Me.Filter2_Pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Split
        '
        Me.frm_Split.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Split.Location = New System.Drawing.Point(0, 0)
        Me.frm_Split.Name = "frm_Split"
        '
        'frm_Split.Panel1
        '
        Me.frm_Split.Panel1.Controls.Add(Me.Fields_Pnl)
        Me.frm_Split.Panel1.Controls.Add(Me.Panel1)
        Me.frm_Split.Panel1MinSize = 478
        '
        'frm_Split.Panel2
        '
        Me.frm_Split.Panel2.AccessibleName = "asdasd"
        Me.frm_Split.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.frm_Split.Panel2.Controls.Add(Me.Filter_Pnl)
        Me.frm_Split.Panel2.Controls.Add(Me.Loading_PB)
        Me.frm_Split.Size = New System.Drawing.Size(1008, 661)
        Me.frm_Split.SplitterDistance = 478
        Me.frm_Split.TabIndex = 0
        '
        'Fields_Pnl
        '
        Me.Fields_Pnl.AutoScroll = True
        Me.Fields_Pnl.BackColor = System.Drawing.Color.DarkGray
        Me.Fields_Pnl.Controls.Add(Me.Recget_Btn)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel12)
        Me.Fields_Pnl.Controls.Add(Me.Remarks_Tbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel11)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel10)
        Me.Fields_Pnl.Controls.Add(Me.ReceivedBy_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel9)
        Me.Fields_Pnl.Controls.Add(Me.Unit_Tbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel8)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel7)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel6)
        Me.Fields_Pnl.Controls.Add(Me.Desc_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.Item_Pnl)
        Me.Fields_Pnl.Controls.Add(Me.Search_Tbox)
        Me.Fields_Pnl.Controls.Add(Me.CtrlNo_Tbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel5)
        Me.Fields_Pnl.Controls.Add(Me.Line_Pnl)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel4)
        Me.Fields_Pnl.Controls.Add(Me.EmpDept_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel3)
        Me.Fields_Pnl.Controls.Add(Me.EmpPosition_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel2)
        Me.Fields_Pnl.Controls.Add(Me.EmpName_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.Get_Btn)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel1)
        Me.Fields_Pnl.Controls.Add(Me.Quantity_Num)
        Me.Fields_Pnl.Controls.Add(Me.UnitPrice_Num)
        Me.Fields_Pnl.Controls.Add(Me.EmpID_Tbox)
        Me.Fields_Pnl.Controls.Add(Me.RecByID_Tbox)
        Me.Fields_Pnl.Controls.Add(Me.DateIssued_DTP)
        Me.Fields_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fields_Pnl.Location = New System.Drawing.Point(0, 80)
        Me.Fields_Pnl.Name = "Fields_Pnl"
        Me.Fields_Pnl.Size = New System.Drawing.Size(478, 581)
        Me.Fields_Pnl.TabIndex = 0
        '
        'Recget_Btn
        '
        Me.Recget_Btn.Location = New System.Drawing.Point(229, 556)
        Me.Recget_Btn.Name = "Recget_Btn"
        Me.Recget_Btn.Size = New System.Drawing.Size(46, 25)
        Me.Recget_Btn.TabIndex = 843
        Me.Recget_Btn.Text = "Get"
        Me.Recget_Btn.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(3, 614)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(99, 25)
        Me.MetroLabel12.TabIndex = 846
        Me.MetroLabel12.Text = "Date Issued"
        Me.MetroLabel12.UseCustomBackColor = True
        '
        'Remarks_Tbox
        '
        Me.Remarks_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Remarks_Tbox.CustomButton.Image = Nothing
        Me.Remarks_Tbox.CustomButton.Location = New System.Drawing.Point(258, 1)
        Me.Remarks_Tbox.CustomButton.Name = ""
        Me.Remarks_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Remarks_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Remarks_Tbox.CustomButton.TabIndex = 1
        Me.Remarks_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Remarks_Tbox.CustomButton.UseSelectable = True
        Me.Remarks_Tbox.CustomButton.Visible = False
        Me.Remarks_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Remarks_Tbox.Lines = New String(-1) {}
        Me.Remarks_Tbox.Location = New System.Drawing.Point(117, 583)
        Me.Remarks_Tbox.MaxLength = 32767
        Me.Remarks_Tbox.Name = "Remarks_Tbox"
        Me.Remarks_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Remarks_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Remarks_Tbox.SelectedText = ""
        Me.Remarks_Tbox.SelectionLength = 0
        Me.Remarks_Tbox.SelectionStart = 0
        Me.Remarks_Tbox.Size = New System.Drawing.Size(282, 25)
        Me.Remarks_Tbox.TabIndex = 845
        Me.Remarks_Tbox.UseSelectable = True
        Me.Remarks_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Remarks_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.Location = New System.Drawing.Point(26, 585)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel11.TabIndex = 843
        Me.MetroLabel11.Text = "Remarks"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.Location = New System.Drawing.Point(0, 556)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(102, 25)
        Me.MetroLabel10.TabIndex = 841
        Me.MetroLabel10.Text = "Received by"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'ReceivedBy_Cbox
        '
        Me.ReceivedBy_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReceivedBy_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ReceivedBy_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ReceivedBy_Cbox.DropDownWidth = 253
        Me.ReceivedBy_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceivedBy_Cbox.FormattingEnabled = True
        Me.ReceivedBy_Cbox.IntegralHeight = False
        Me.ReceivedBy_Cbox.Location = New System.Drawing.Point(281, 556)
        Me.ReceivedBy_Cbox.Name = "ReceivedBy_Cbox"
        Me.ReceivedBy_Cbox.Size = New System.Drawing.Size(118, 25)
        Me.ReceivedBy_Cbox.TabIndex = 844
        Me.ReceivedBy_Cbox.Tag = "Emp_Name"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.Location = New System.Drawing.Point(17, 525)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(85, 25)
        Me.MetroLabel9.TabIndex = 839
        Me.MetroLabel9.Text = "Unit price"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'Unit_Tbox
        '
        Me.Unit_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Unit_Tbox.CustomButton.Image = Nothing
        Me.Unit_Tbox.CustomButton.Location = New System.Drawing.Point(258, 1)
        Me.Unit_Tbox.CustomButton.Name = ""
        Me.Unit_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Unit_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Unit_Tbox.CustomButton.TabIndex = 1
        Me.Unit_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Unit_Tbox.CustomButton.UseSelectable = True
        Me.Unit_Tbox.CustomButton.Visible = False
        Me.Unit_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Unit_Tbox.Lines = New String(-1) {}
        Me.Unit_Tbox.Location = New System.Drawing.Point(117, 493)
        Me.Unit_Tbox.MaxLength = 32767
        Me.Unit_Tbox.Name = "Unit_Tbox"
        Me.Unit_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Unit_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Unit_Tbox.SelectedText = ""
        Me.Unit_Tbox.SelectionLength = 0
        Me.Unit_Tbox.SelectionStart = 0
        Me.Unit_Tbox.Size = New System.Drawing.Size(282, 25)
        Me.Unit_Tbox.TabIndex = 838
        Me.Unit_Tbox.UseSelectable = True
        Me.Unit_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Unit_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(59, 492)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(43, 25)
        Me.MetroLabel8.TabIndex = 837
        Me.MetroLabel8.Text = "Unit"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(25, 462)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(77, 25)
        Me.MetroLabel7.TabIndex = 835
        Me.MetroLabel7.Text = "Quantity"
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(5, 430)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(97, 25)
        Me.MetroLabel6.TabIndex = 833
        Me.MetroLabel6.Text = "Description"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'Desc_Cbox
        '
        Me.Desc_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Desc_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Desc_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Desc_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_Cbox.FormattingEnabled = True
        Me.Desc_Cbox.IntegralHeight = False
        Me.Desc_Cbox.Location = New System.Drawing.Point(117, 430)
        Me.Desc_Cbox.Name = "Desc_Cbox"
        Me.Desc_Cbox.Size = New System.Drawing.Size(282, 25)
        Me.Desc_Cbox.TabIndex = 834
        Me.Desc_Cbox.Tag = "stk_desc"
        '
        'Item_Pnl
        '
        Me.Item_Pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_Pnl.BackColor = System.Drawing.Color.White
        Me.Item_Pnl.Controls.Add(Me.Loading2_PB)
        Me.Item_Pnl.Location = New System.Drawing.Point(12, 212)
        Me.Item_Pnl.Name = "Item_Pnl"
        Me.Item_Pnl.Size = New System.Drawing.Size(387, 215)
        Me.Item_Pnl.TabIndex = 0
        '
        'Loading2_PB
        '
        Me.Loading2_PB.BackColor = System.Drawing.Color.Transparent
        Me.Loading2_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Loading2_PB.Image = Global.warehouse2.My.Resources.Resources.loading_trans
        Me.Loading2_PB.ImageLocation = ""
        Me.Loading2_PB.Location = New System.Drawing.Point(180, 80)
        Me.Loading2_PB.Name = "Loading2_PB"
        Me.Loading2_PB.Size = New System.Drawing.Size(55, 55)
        Me.Loading2_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Loading2_PB.TabIndex = 21
        Me.Loading2_PB.TabStop = False
        '
        'Search_Tbox
        '
        Me.Search_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Search_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Search_Tbox.CustomButton.Location = New System.Drawing.Point(361, 1)
        Me.Search_Tbox.CustomButton.Name = ""
        Me.Search_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Search_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Search_Tbox.CustomButton.TabIndex = 1
        Me.Search_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Search_Tbox.CustomButton.UseSelectable = True
        Me.Search_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Search_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Search_Tbox.Lines = New String(-1) {}
        Me.Search_Tbox.Location = New System.Drawing.Point(12, 179)
        Me.Search_Tbox.MaxLength = 32767
        Me.Search_Tbox.Name = "Search_Tbox"
        Me.Search_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Search_Tbox.SelectedText = ""
        Me.Search_Tbox.SelectionLength = 0
        Me.Search_Tbox.SelectionStart = 0
        Me.Search_Tbox.ShowButton = True
        Me.Search_Tbox.ShowClearButton = True
        Me.Search_Tbox.Size = New System.Drawing.Size(387, 27)
        Me.Search_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.Search_Tbox.TabIndex = 832
        Me.Search_Tbox.UseCustomForeColor = True
        Me.Search_Tbox.UseSelectable = True
        Me.Search_Tbox.WaterMark = "Search here"
        Me.Search_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Search_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CtrlNo_Tbox
        '
        Me.CtrlNo_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.CtrlNo_Tbox.CustomButton.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlNo_Tbox.CustomButton.Image = Nothing
        Me.CtrlNo_Tbox.CustomButton.Location = New System.Drawing.Point(252, 1)
        Me.CtrlNo_Tbox.CustomButton.Name = ""
        Me.CtrlNo_Tbox.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.CtrlNo_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.CtrlNo_Tbox.CustomButton.TabIndex = 1
        Me.CtrlNo_Tbox.CustomButton.Text = "G"
        Me.CtrlNo_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CtrlNo_Tbox.CustomButton.UseSelectable = True
        Me.CtrlNo_Tbox.CustomButton.UseStyleColors = True
        Me.CtrlNo_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.CtrlNo_Tbox.Lines = New String(-1) {}
        Me.CtrlNo_Tbox.Location = New System.Drawing.Point(113, 6)
        Me.CtrlNo_Tbox.MaxLength = 32767
        Me.CtrlNo_Tbox.Name = "CtrlNo_Tbox"
        Me.CtrlNo_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CtrlNo_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CtrlNo_Tbox.SelectedText = ""
        Me.CtrlNo_Tbox.SelectionLength = 0
        Me.CtrlNo_Tbox.SelectionStart = 0
        Me.CtrlNo_Tbox.ShowButton = True
        Me.CtrlNo_Tbox.Size = New System.Drawing.Size(286, 35)
        Me.CtrlNo_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.CtrlNo_Tbox.TabIndex = 0
        Me.CtrlNo_Tbox.UseSelectable = True
        Me.CtrlNo_Tbox.UseStyleColors = True
        Me.CtrlNo_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CtrlNo_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(2, 11)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(100, 25)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Control No."
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'Line_Pnl
        '
        Me.Line_Pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line_Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Line_Pnl.Location = New System.Drawing.Point(5, 171)
        Me.Line_Pnl.Name = "Line_Pnl"
        Me.Line_Pnl.Size = New System.Drawing.Size(394, 2)
        Me.Line_Pnl.TabIndex = 9
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(1, 140)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(103, 25)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Department"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'EmpDept_Cbox
        '
        Me.EmpDept_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpDept_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmpDept_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpDept_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDept_Cbox.FormattingEnabled = True
        Me.EmpDept_Cbox.IntegralHeight = False
        Me.EmpDept_Cbox.Location = New System.Drawing.Point(113, 140)
        Me.EmpDept_Cbox.Name = "EmpDept_Cbox"
        Me.EmpDept_Cbox.Size = New System.Drawing.Size(236, 25)
        Me.EmpDept_Cbox.TabIndex = 8
        Me.EmpDept_Cbox.Tag = "Sub_Department_Name"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(33, 109)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 25)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Position"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'EmpPosition_Cbox
        '
        Me.EmpPosition_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpPosition_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmpPosition_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpPosition_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPosition_Cbox.FormattingEnabled = True
        Me.EmpPosition_Cbox.IntegralHeight = False
        Me.EmpPosition_Cbox.Location = New System.Drawing.Point(113, 109)
        Me.EmpPosition_Cbox.Name = "EmpPosition_Cbox"
        Me.EmpPosition_Cbox.Size = New System.Drawing.Size(236, 25)
        Me.EmpPosition_Cbox.TabIndex = 6
        Me.EmpPosition_Cbox.Tag = "Position"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(46, 78)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(58, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Name"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'EmpName_Cbox
        '
        Me.EmpName_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpName_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmpName_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpName_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpName_Cbox.FormattingEnabled = True
        Me.EmpName_Cbox.IntegralHeight = False
        Me.EmpName_Cbox.Location = New System.Drawing.Point(113, 78)
        Me.EmpName_Cbox.Name = "EmpName_Cbox"
        Me.EmpName_Cbox.Size = New System.Drawing.Size(236, 25)
        Me.EmpName_Cbox.TabIndex = 4
        Me.EmpName_Cbox.Tag = "Emp_Name"
        '
        'Get_Btn
        '
        Me.Get_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Get_Btn.Location = New System.Drawing.Point(353, 47)
        Me.Get_Btn.Name = "Get_Btn"
        Me.Get_Btn.Size = New System.Drawing.Size(46, 25)
        Me.Get_Btn.TabIndex = 2
        Me.Get_Btn.Text = "Get"
        Me.Get_Btn.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(-3, 47)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Employee ID"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'Quantity_Num
        '
        Me.Quantity_Num.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Quantity_Num.DecimalPlaces = 2
        Me.Quantity_Num.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity_Num.Location = New System.Drawing.Point(117, 457)
        Me.Quantity_Num.Name = "Quantity_Num"
        Me.Quantity_Num.Size = New System.Drawing.Size(282, 34)
        Me.Quantity_Num.TabIndex = 836
        Me.Quantity_Num.ThousandsSeparator = True
        '
        'UnitPrice_Num
        '
        Me.UnitPrice_Num.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnitPrice_Num.DecimalPlaces = 2
        Me.UnitPrice_Num.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice_Num.Location = New System.Drawing.Point(117, 520)
        Me.UnitPrice_Num.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitPrice_Num.Name = "UnitPrice_Num"
        Me.UnitPrice_Num.Size = New System.Drawing.Size(282, 34)
        Me.UnitPrice_Num.TabIndex = 840
        Me.UnitPrice_Num.ThousandsSeparator = True
        '
        'EmpID_Tbox
        '
        Me.EmpID_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.EmpID_Tbox.CustomButton.Image = Nothing
        Me.EmpID_Tbox.CustomButton.Location = New System.Drawing.Point(212, 1)
        Me.EmpID_Tbox.CustomButton.Name = ""
        Me.EmpID_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.EmpID_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpID_Tbox.CustomButton.TabIndex = 1
        Me.EmpID_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmpID_Tbox.CustomButton.UseSelectable = True
        Me.EmpID_Tbox.CustomButton.Visible = False
        Me.EmpID_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.EmpID_Tbox.Lines = New String(-1) {}
        Me.EmpID_Tbox.Location = New System.Drawing.Point(113, 47)
        Me.EmpID_Tbox.MaxLength = 32767
        Me.EmpID_Tbox.Name = "EmpID_Tbox"
        Me.EmpID_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EmpID_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpID_Tbox.SelectedText = ""
        Me.EmpID_Tbox.SelectionLength = 0
        Me.EmpID_Tbox.SelectionStart = 0
        Me.EmpID_Tbox.Size = New System.Drawing.Size(236, 25)
        Me.EmpID_Tbox.TabIndex = 847
        Me.EmpID_Tbox.UseSelectable = True
        Me.EmpID_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpID_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'RecByID_Tbox
        '
        '
        '
        '
        Me.RecByID_Tbox.CustomButton.Image = Nothing
        Me.RecByID_Tbox.CustomButton.Location = New System.Drawing.Point(82, 1)
        Me.RecByID_Tbox.CustomButton.Name = ""
        Me.RecByID_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.RecByID_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.RecByID_Tbox.CustomButton.TabIndex = 1
        Me.RecByID_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.RecByID_Tbox.CustomButton.UseSelectable = True
        Me.RecByID_Tbox.CustomButton.Visible = False
        Me.RecByID_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.RecByID_Tbox.Lines = New String(-1) {}
        Me.RecByID_Tbox.Location = New System.Drawing.Point(117, 556)
        Me.RecByID_Tbox.MaxLength = 32767
        Me.RecByID_Tbox.Name = "RecByID_Tbox"
        Me.RecByID_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RecByID_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.RecByID_Tbox.SelectedText = ""
        Me.RecByID_Tbox.SelectionLength = 0
        Me.RecByID_Tbox.SelectionStart = 0
        Me.RecByID_Tbox.Size = New System.Drawing.Size(106, 25)
        Me.RecByID_Tbox.TabIndex = 848
        Me.RecByID_Tbox.Tag = "emp_id"
        Me.RecByID_Tbox.UseSelectable = True
        Me.RecByID_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RecByID_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Btn_Pnl)
        Me.Panel1.Controls.Add(Me.Mode_Lbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 80)
        Me.Panel1.TabIndex = 1
        '
        'Btn_Pnl
        '
        Me.Btn_Pnl.Controls.Add(Me.Refresh_Btn)
        Me.Btn_Pnl.Controls.Add(Me.Clear_Btn)
        Me.Btn_Pnl.Controls.Add(Me.Delete_Btn)
        Me.Btn_Pnl.Controls.Add(Me.Edit_Btn)
        Me.Btn_Pnl.Controls.Add(Me.Save_Btn)
        Me.Btn_Pnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_Pnl.Location = New System.Drawing.Point(0, 45)
        Me.Btn_Pnl.Name = "Btn_Pnl"
        Me.Btn_Pnl.Size = New System.Drawing.Size(478, 35)
        Me.Btn_Pnl.TabIndex = 0
        '
        'Refresh_Btn
        '
        Me.Refresh_Btn.BackColor = System.Drawing.Color.Gray
        Me.Refresh_Btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Refresh_Btn.FlatAppearance.BorderSize = 0
        Me.Refresh_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Refresh_Btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Refresh_Btn.Location = New System.Drawing.Point(400, 0)
        Me.Refresh_Btn.Name = "Refresh_Btn"
        Me.Refresh_Btn.Size = New System.Drawing.Size(100, 35)
        Me.Refresh_Btn.TabIndex = 849
        Me.Refresh_Btn.Text = "Refresh (F5)"
        Me.Refresh_Btn.UseVisualStyleBackColor = False
        '
        'Clear_Btn
        '
        Me.Clear_Btn.BackColor = System.Drawing.Color.Gray
        Me.Clear_Btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Clear_Btn.FlatAppearance.BorderSize = 0
        Me.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear_Btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Clear_Btn.Location = New System.Drawing.Point(300, 0)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(100, 35)
        Me.Clear_Btn.TabIndex = 848
        Me.Clear_Btn.Text = "Clear (F4)"
        Me.Clear_Btn.UseVisualStyleBackColor = False
        '
        'Delete_Btn
        '
        Me.Delete_Btn.BackColor = System.Drawing.Color.Gray
        Me.Delete_Btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Delete_Btn.FlatAppearance.BorderSize = 0
        Me.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Btn.Font = New System.Drawing.Font("Segoe UI", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Delete_Btn.Location = New System.Drawing.Point(200, 0)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(100, 35)
        Me.Delete_Btn.TabIndex = 847
        Me.Delete_Btn.Text = "Delete (F3)"
        Me.Delete_Btn.UseVisualStyleBackColor = False
        '
        'Edit_Btn
        '
        Me.Edit_Btn.BackColor = System.Drawing.Color.Gray
        Me.Edit_Btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Edit_Btn.FlatAppearance.BorderSize = 0
        Me.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit_Btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Edit_Btn.Location = New System.Drawing.Point(100, 0)
        Me.Edit_Btn.Name = "Edit_Btn"
        Me.Edit_Btn.Size = New System.Drawing.Size(100, 35)
        Me.Edit_Btn.TabIndex = 846
        Me.Edit_Btn.Text = "Edit (F2)"
        Me.Edit_Btn.UseVisualStyleBackColor = False
        '
        'Save_Btn
        '
        Me.Save_Btn.BackColor = System.Drawing.Color.Gray
        Me.Save_Btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Save_Btn.FlatAppearance.BorderSize = 0
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Save_Btn.Location = New System.Drawing.Point(0, 0)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(100, 35)
        Me.Save_Btn.TabIndex = 845
        Me.Save_Btn.Text = "Save (F1)"
        Me.Save_Btn.UseVisualStyleBackColor = False
        '
        'Mode_Lbl
        '
        Me.Mode_Lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mode_Lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Mode_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Mode_Lbl.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Mode_Lbl.Location = New System.Drawing.Point(12, 9)
        Me.Mode_Lbl.Name = "Mode_Lbl"
        Me.Mode_Lbl.Size = New System.Drawing.Size(449, 25)
        Me.Mode_Lbl.TabIndex = 2
        Me.Mode_Lbl.Text = "New"
        Me.Mode_Lbl.UseCustomBackColor = True
        Me.Mode_Lbl.UseCustomForeColor = True
        '
        'Filter_Pnl
        '
        Me.Filter_Pnl.BackColor = System.Drawing.Color.White
        Me.Filter_Pnl.Controls.Add(Me.FilterReq_Btn)
        Me.Filter_Pnl.Controls.Add(Me.Legends_Pnl)
        Me.Filter_Pnl.Controls.Add(Me.EmpFilter_Cbox)
        Me.Filter_Pnl.Controls.Add(Me.MetroLabel14)
        Me.Filter_Pnl.Controls.Add(Me.DeptFilter_Cbox)
        Me.Filter_Pnl.Controls.Add(Me.MetroLabel13)
        Me.Filter_Pnl.Controls.Add(Me.SearchAcct_Tbox)
        Me.Filter_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Filter_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.Filter_Pnl.Name = "Filter_Pnl"
        Me.Filter_Pnl.Size = New System.Drawing.Size(526, 60)
        Me.Filter_Pnl.TabIndex = 21
        '
        'FilterReq_Btn
        '
        Me.FilterReq_Btn.BackColor = System.Drawing.Color.Transparent
        Me.FilterReq_Btn.BackgroundImage = Global.warehouse2.My.Resources.Resources.filter_48px
        Me.FilterReq_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FilterReq_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FilterReq_Btn.FlatAppearance.BorderSize = 0
        Me.FilterReq_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.FilterReq_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.FilterReq_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterReq_Btn.Location = New System.Drawing.Point(346, 29)
        Me.FilterReq_Btn.Name = "FilterReq_Btn"
        Me.FilterReq_Btn.Size = New System.Drawing.Size(27, 27)
        Me.FilterReq_Btn.TabIndex = 839
        Me.FilterReq_Btn.UseVisualStyleBackColor = False
        '
        'Legends_Pnl
        '
        Me.Legends_Pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Legends_Pnl.Controls.Add(Me.MetroLabel19)
        Me.Legends_Pnl.Controls.Add(Me.UnauthorizedLegend_Pnl)
        Me.Legends_Pnl.Controls.Add(Me.MetroLabel18)
        Me.Legends_Pnl.Controls.Add(Me.ReturnablesLegend_Pnl)
        Me.Legends_Pnl.Controls.Add(Me.MetroLabel17)
        Me.Legends_Pnl.Controls.Add(Me.TransferLegend_Pnl)
        Me.Legends_Pnl.Controls.Add(Me.MetroLabel16)
        Me.Legends_Pnl.Controls.Add(Me.LostLegend_Pnl)
        Me.Legends_Pnl.Controls.Add(Me.MetroLabel15)
        Me.Legends_Pnl.Controls.Add(Me.ReturnLegend_Pnl)
        Me.Legends_Pnl.Location = New System.Drawing.Point(376, 9)
        Me.Legends_Pnl.Name = "Legends_Pnl"
        Me.Legends_Pnl.Size = New System.Drawing.Size(138, 19)
        Me.Legends_Pnl.TabIndex = 838
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel19.Location = New System.Drawing.Point(362, 1)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(83, 15)
        Me.MetroLabel19.TabIndex = 846
        Me.MetroLabel19.Text = "Unauthorized"
        '
        'UnauthorizedLegend_Pnl
        '
        Me.UnauthorizedLegend_Pnl.BackColor = System.Drawing.Color.Orange
        Me.UnauthorizedLegend_Pnl.Location = New System.Drawing.Point(341, 3)
        Me.UnauthorizedLegend_Pnl.Name = "UnauthorizedLegend_Pnl"
        Me.UnauthorizedLegend_Pnl.Size = New System.Drawing.Size(20, 10)
        Me.UnauthorizedLegend_Pnl.TabIndex = 847
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel18.Location = New System.Drawing.Point(261, 1)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(74, 15)
        Me.MetroLabel18.TabIndex = 844
        Me.MetroLabel18.Text = "Returnables"
        '
        'ReturnablesLegend_Pnl
        '
        Me.ReturnablesLegend_Pnl.BackColor = System.Drawing.Color.Black
        Me.ReturnablesLegend_Pnl.Location = New System.Drawing.Point(240, 3)
        Me.ReturnablesLegend_Pnl.Name = "ReturnablesLegend_Pnl"
        Me.ReturnablesLegend_Pnl.Size = New System.Drawing.Size(20, 10)
        Me.ReturnablesLegend_Pnl.TabIndex = 845
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.Location = New System.Drawing.Point(161, 1)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(72, 15)
        Me.MetroLabel17.TabIndex = 842
        Me.MetroLabel17.Text = "Transferred"
        '
        'TransferLegend_Pnl
        '
        Me.TransferLegend_Pnl.BackColor = System.Drawing.Color.DimGray
        Me.TransferLegend_Pnl.Location = New System.Drawing.Point(143, 3)
        Me.TransferLegend_Pnl.Name = "TransferLegend_Pnl"
        Me.TransferLegend_Pnl.Size = New System.Drawing.Size(20, 10)
        Me.TransferLegend_Pnl.TabIndex = 843
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel16.Location = New System.Drawing.Point(106, 1)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(30, 15)
        Me.MetroLabel16.TabIndex = 840
        Me.MetroLabel16.Text = "Lost"
        '
        'LostLegend_Pnl
        '
        Me.LostLegend_Pnl.BackColor = System.Drawing.Color.IndianRed
        Me.LostLegend_Pnl.Location = New System.Drawing.Point(87, 3)
        Me.LostLegend_Pnl.Name = "LostLegend_Pnl"
        Me.LostLegend_Pnl.Size = New System.Drawing.Size(20, 10)
        Me.LostLegend_Pnl.TabIndex = 841
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel15.Location = New System.Drawing.Point(21, 1)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(60, 15)
        Me.MetroLabel15.TabIndex = 839
        Me.MetroLabel15.Text = "Returned"
        '
        'ReturnLegend_Pnl
        '
        Me.ReturnLegend_Pnl.BackColor = System.Drawing.Color.ForestGreen
        Me.ReturnLegend_Pnl.Location = New System.Drawing.Point(3, 3)
        Me.ReturnLegend_Pnl.Name = "ReturnLegend_Pnl"
        Me.ReturnLegend_Pnl.Size = New System.Drawing.Size(20, 10)
        Me.ReturnLegend_Pnl.TabIndex = 839
        '
        'EmpFilter_Cbox
        '
        Me.EmpFilter_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmpFilter_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpFilter_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFilter_Cbox.FormattingEnabled = True
        Me.EmpFilter_Cbox.Location = New System.Drawing.Point(163, 31)
        Me.EmpFilter_Cbox.Name = "EmpFilter_Cbox"
        Me.EmpFilter_Cbox.Size = New System.Drawing.Size(179, 25)
        Me.EmpFilter_Cbox.TabIndex = 837
        Me.EmpFilter_Cbox.Tag = "get"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(160, 9)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel14.TabIndex = 836
        Me.MetroLabel14.Text = "Employee"
        '
        'DeptFilter_Cbox
        '
        Me.DeptFilter_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptFilter_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptFilter_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeptFilter_Cbox.FormattingEnabled = True
        Me.DeptFilter_Cbox.Location = New System.Drawing.Point(6, 31)
        Me.DeptFilter_Cbox.Name = "DeptFilter_Cbox"
        Me.DeptFilter_Cbox.Size = New System.Drawing.Size(151, 25)
        Me.DeptFilter_Cbox.TabIndex = 835
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(3, 9)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel13.TabIndex = 834
        Me.MetroLabel13.Text = "Department"
        '
        'SearchAcct_Tbox
        '
        Me.SearchAcct_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.SearchAcct_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchAcct_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.SearchAcct_Tbox.CustomButton.Location = New System.Drawing.Point(114, 1)
        Me.SearchAcct_Tbox.CustomButton.Name = ""
        Me.SearchAcct_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.SearchAcct_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchAcct_Tbox.CustomButton.TabIndex = 1
        Me.SearchAcct_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchAcct_Tbox.CustomButton.UseSelectable = True
        Me.SearchAcct_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.SearchAcct_Tbox.ForeColor = System.Drawing.Color.Black
        Me.SearchAcct_Tbox.Lines = New String(-1) {}
        Me.SearchAcct_Tbox.Location = New System.Drawing.Point(376, 31)
        Me.SearchAcct_Tbox.MaxLength = 32767
        Me.SearchAcct_Tbox.Name = "SearchAcct_Tbox"
        Me.SearchAcct_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchAcct_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchAcct_Tbox.SelectedText = ""
        Me.SearchAcct_Tbox.SelectionLength = 0
        Me.SearchAcct_Tbox.SelectionStart = 0
        Me.SearchAcct_Tbox.ShowButton = True
        Me.SearchAcct_Tbox.ShowClearButton = True
        Me.SearchAcct_Tbox.Size = New System.Drawing.Size(138, 25)
        Me.SearchAcct_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.SearchAcct_Tbox.TabIndex = 833
        Me.SearchAcct_Tbox.UseCustomForeColor = True
        Me.SearchAcct_Tbox.UseSelectable = True
        Me.SearchAcct_Tbox.WaterMark = "Search here"
        Me.SearchAcct_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchAcct_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Loading_PB
        '
        Me.Loading_PB.BackColor = System.Drawing.Color.Transparent
        Me.Loading_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Loading_PB.Image = Global.warehouse2.My.Resources.Resources.loading_trans
        Me.Loading_PB.ImageLocation = ""
        Me.Loading_PB.Location = New System.Drawing.Point(218, 283)
        Me.Loading_PB.Name = "Loading_PB"
        Me.Loading_PB.Size = New System.Drawing.Size(55, 55)
        Me.Loading_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Loading_PB.TabIndex = 20
        Me.Loading_PB.TabStop = False
        '
        'Acctblty_Cmenu
        '
        Me.Acctblty_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToolStripMenuItem, Me.LostToolStripMenuItem, Me.TransferToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.Acctblty_Cmenu.Name = "AcctbltyCmenu"
        Me.Acctblty_Cmenu.Size = New System.Drawing.Size(116, 92)
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Image = Global.warehouse2.My.Resources.Resources.return_48px
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'LostToolStripMenuItem
        '
        Me.LostToolStripMenuItem.Image = Global.warehouse2.My.Resources.Resources.bearish_48px
        Me.LostToolStripMenuItem.Name = "LostToolStripMenuItem"
        Me.LostToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LostToolStripMenuItem.Text = "Lost"
        '
        'TransferToolStripMenuItem
        '
        Me.TransferToolStripMenuItem.Image = Global.warehouse2.My.Resources.Resources.transfer_between_users_48px
        Me.TransferToolStripMenuItem.Name = "TransferToolStripMenuItem"
        Me.TransferToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.TransferToolStripMenuItem.Tag = "Transferred"
        Me.TransferToolStripMenuItem.Text = "Transfer"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.warehouse2.My.Resources.Resources.print_48px
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'Filter2_Pnl
        '
        Me.Filter2_Pnl.BackColor = System.Drawing.Color.White
        Me.Filter2_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Filter2_Pnl.Controls.Add(Me.Unauthorized_Chk)
        Me.Filter2_Pnl.Controls.Add(Me.Returnbles_Chk)
        Me.Filter2_Pnl.Controls.Add(Me.Lost_Chk)
        Me.Filter2_Pnl.Controls.Add(Me.Transferred_Chk)
        Me.Filter2_Pnl.Controls.Add(Me.Return_Chk)
        Me.Filter2_Pnl.Location = New System.Drawing.Point(858, 7)
        Me.Filter2_Pnl.Name = "Filter2_Pnl"
        Me.Filter2_Pnl.Size = New System.Drawing.Size(102, 91)
        Me.Filter2_Pnl.TabIndex = 9
        Me.Filter2_Pnl.Visible = False
        '
        'Unauthorized_Chk
        '
        Me.Unauthorized_Chk.AutoSize = True
        Me.Unauthorized_Chk.Checked = True
        Me.Unauthorized_Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Unauthorized_Chk.Location = New System.Drawing.Point(5, 69)
        Me.Unauthorized_Chk.Name = "Unauthorized_Chk"
        Me.Unauthorized_Chk.Size = New System.Drawing.Size(94, 15)
        Me.Unauthorized_Chk.TabIndex = 5
        Me.Unauthorized_Chk.Text = "Unauthorized"
        Me.Unauthorized_Chk.UseSelectable = True
        '
        'Returnbles_Chk
        '
        Me.Returnbles_Chk.AutoSize = True
        Me.Returnbles_Chk.Checked = True
        Me.Returnbles_Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Returnbles_Chk.Location = New System.Drawing.Point(5, 53)
        Me.Returnbles_Chk.Name = "Returnbles_Chk"
        Me.Returnbles_Chk.Size = New System.Drawing.Size(85, 15)
        Me.Returnbles_Chk.TabIndex = 4
        Me.Returnbles_Chk.Text = "Returnables"
        Me.Returnbles_Chk.UseSelectable = True
        '
        'Lost_Chk
        '
        Me.Lost_Chk.AutoSize = True
        Me.Lost_Chk.Checked = True
        Me.Lost_Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Lost_Chk.Location = New System.Drawing.Point(5, 21)
        Me.Lost_Chk.Name = "Lost_Chk"
        Me.Lost_Chk.Size = New System.Drawing.Size(45, 15)
        Me.Lost_Chk.TabIndex = 3
        Me.Lost_Chk.Text = "Lost"
        Me.Lost_Chk.UseSelectable = True
        '
        'Transferred_Chk
        '
        Me.Transferred_Chk.AutoSize = True
        Me.Transferred_Chk.Checked = True
        Me.Transferred_Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Transferred_Chk.Location = New System.Drawing.Point(5, 37)
        Me.Transferred_Chk.Name = "Transferred_Chk"
        Me.Transferred_Chk.Size = New System.Drawing.Size(81, 15)
        Me.Transferred_Chk.TabIndex = 1
        Me.Transferred_Chk.Text = "Transferred"
        Me.Transferred_Chk.UseSelectable = True
        '
        'Return_Chk
        '
        Me.Return_Chk.AutoSize = True
        Me.Return_Chk.Checked = True
        Me.Return_Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Return_Chk.Location = New System.Drawing.Point(5, 5)
        Me.Return_Chk.Name = "Return_Chk"
        Me.Return_Chk.Size = New System.Drawing.Size(58, 15)
        Me.Return_Chk.TabIndex = 0
        Me.Return_Chk.Text = "Return"
        Me.Return_Chk.UseSelectable = True
        '
        'DateIssued_DTP
        '
        Me.DateIssued_DTP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateIssued_DTP.Location = New System.Drawing.Point(117, 610)
        Me.DateIssued_DTP.Name = "DateIssued_DTP"
        Me.DateIssued_DTP.Size = New System.Drawing.Size(282, 29)
        Me.DateIssued_DTP.TabIndex = 849
        '
        'AccountabilityFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.frm_Split)
        Me.Controls.Add(Me.Filter2_Pnl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AccountabilityFrm"
        Me.Text = "Accountability"
        Me.frm_Split.Panel1.ResumeLayout(False)
        Me.frm_Split.Panel2.ResumeLayout(False)
        CType(Me.frm_Split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Split.ResumeLayout(False)
        Me.Fields_Pnl.ResumeLayout(False)
        Me.Fields_Pnl.PerformLayout()
        Me.Item_Pnl.ResumeLayout(False)
        CType(Me.Loading2_PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quantity_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPrice_Num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Btn_Pnl.ResumeLayout(False)
        Me.Filter_Pnl.ResumeLayout(False)
        Me.Filter_Pnl.PerformLayout()
        Me.Legends_Pnl.ResumeLayout(False)
        Me.Legends_Pnl.PerformLayout()
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Acctblty_Cmenu.ResumeLayout(False)
        Me.Filter2_Pnl.ResumeLayout(False)
        Me.Filter2_Pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frm_Split As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Mode_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents Fields_Pnl As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Get_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EmpName_Cbox As ComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EmpPosition_Cbox As ComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EmpDept_Cbox As ComboBox
    Friend WithEvents Line_Pnl As Panel
    Friend WithEvents CtrlNo_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Search_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Item_Pnl As Panel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Desc_Cbox As ComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Unit_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Remarks_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ReceivedBy_Cbox As ComboBox
    Friend WithEvents Quantity_Num As NumericUpDown
    Friend WithEvents Btn_Pnl As Panel
    Friend WithEvents Clear_Btn As Button
    Friend WithEvents Delete_Btn As Button
    Friend WithEvents Edit_Btn As Button
    Friend WithEvents Save_Btn As Button
    Friend WithEvents Refresh_Btn As Button
    Friend WithEvents Loading2_PB As PictureBox
    Friend WithEvents UnitPrice_Num As NumericUpDown
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Recget_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Filter_Pnl As Panel
    Friend WithEvents Loading_PB As PictureBox
    Friend WithEvents SearchAcct_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DeptFilter_Cbox As ComboBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EmpFilter_Cbox As ComboBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Legends_Pnl As Panel
    Friend WithEvents ReturnLegend_Pnl As Panel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TransferLegend_Pnl As Panel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LostLegend_Pnl As Panel
    Friend WithEvents Acctblty_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilterReq_Btn As Button
    Friend WithEvents Filter2_Pnl As Panel
    Friend WithEvents Lost_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Transferred_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Return_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Returnbles_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ReturnablesLegend_Pnl As Panel
    Friend WithEvents EmpID_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents RecByID_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UnauthorizedLegend_Pnl As Panel
    Friend WithEvents Unauthorized_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents DateIssued_DTP As DateTimePicker
End Class
