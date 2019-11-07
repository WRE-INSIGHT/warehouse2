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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountabilityFrm))
        Me.frm_Split = New System.Windows.Forms.SplitContainer()
        Me.Fields_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.DateIssued_DTP = New MetroFramework.Controls.MetroDateTime()
        Me.Remarks_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.ReceivedBy_Tbox = New System.Windows.Forms.ComboBox()
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
        Me.Dept_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Position_Cbox = New System.Windows.Forms.ComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.EmpName_Cbox = New System.Windows.Forms.ComboBox()
        Me.Get_Btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.EmpID_Cbox = New System.Windows.Forms.ComboBox()
        Me.Quantity_Num = New System.Windows.Forms.NumericUpDown()
        Me.UnitPrice_Num = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Pnl = New System.Windows.Forms.Panel()
        Me.Refresh_Btn = New System.Windows.Forms.Button()
        Me.Clear_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Edit_Btn = New System.Windows.Forms.Button()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Mode_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.Loading_PB = New System.Windows.Forms.PictureBox()
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
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.frm_Split.Panel2.Controls.Add(Me.Loading_PB)
        Me.frm_Split.Size = New System.Drawing.Size(1008, 661)
        Me.frm_Split.SplitterDistance = 496
        Me.frm_Split.TabIndex = 0
        '
        'Fields_Pnl
        '
        Me.Fields_Pnl.BackColor = System.Drawing.Color.DarkGray
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel12)
        Me.Fields_Pnl.Controls.Add(Me.DateIssued_DTP)
        Me.Fields_Pnl.Controls.Add(Me.Remarks_Tbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel11)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel10)
        Me.Fields_Pnl.Controls.Add(Me.ReceivedBy_Tbox)
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
        Me.Fields_Pnl.Controls.Add(Me.Dept_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel3)
        Me.Fields_Pnl.Controls.Add(Me.Position_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel2)
        Me.Fields_Pnl.Controls.Add(Me.EmpName_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.Get_Btn)
        Me.Fields_Pnl.Controls.Add(Me.MetroLabel1)
        Me.Fields_Pnl.Controls.Add(Me.EmpID_Cbox)
        Me.Fields_Pnl.Controls.Add(Me.Quantity_Num)
        Me.Fields_Pnl.Controls.Add(Me.UnitPrice_Num)
        Me.Fields_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fields_Pnl.Location = New System.Drawing.Point(0, 80)
        Me.Fields_Pnl.Name = "Fields_Pnl"
        Me.Fields_Pnl.Size = New System.Drawing.Size(496, 581)
        Me.Fields_Pnl.TabIndex = 0
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(3, 531)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(99, 25)
        Me.MetroLabel12.TabIndex = 846
        Me.MetroLabel12.Text = "Date Issued"
        Me.MetroLabel12.UseCustomBackColor = True
        '
        'DateIssued_DTP
        '
        Me.DateIssued_DTP.Location = New System.Drawing.Point(117, 527)
        Me.DateIssued_DTP.MinimumSize = New System.Drawing.Size(4, 29)
        Me.DateIssued_DTP.Name = "DateIssued_DTP"
        Me.DateIssued_DTP.Size = New System.Drawing.Size(228, 29)
        Me.DateIssued_DTP.TabIndex = 845
        '
        'Remarks_Tbox
        '
        Me.Remarks_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Remarks_Tbox.CustomButton.Image = Nothing
        Me.Remarks_Tbox.CustomButton.Location = New System.Drawing.Point(335, 1)
        Me.Remarks_Tbox.CustomButton.Name = ""
        Me.Remarks_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Remarks_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Remarks_Tbox.CustomButton.TabIndex = 1
        Me.Remarks_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Remarks_Tbox.CustomButton.UseSelectable = True
        Me.Remarks_Tbox.CustomButton.Visible = False
        Me.Remarks_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Remarks_Tbox.Lines = New String(-1) {}
        Me.Remarks_Tbox.Location = New System.Drawing.Point(117, 500)
        Me.Remarks_Tbox.MaxLength = 32767
        Me.Remarks_Tbox.Name = "Remarks_Tbox"
        Me.Remarks_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Remarks_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Remarks_Tbox.SelectedText = ""
        Me.Remarks_Tbox.SelectionLength = 0
        Me.Remarks_Tbox.SelectionStart = 0
        Me.Remarks_Tbox.Size = New System.Drawing.Size(359, 25)
        Me.Remarks_Tbox.TabIndex = 844
        Me.Remarks_Tbox.UseSelectable = True
        Me.Remarks_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Remarks_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.Location = New System.Drawing.Point(26, 502)
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
        Me.MetroLabel10.Location = New System.Drawing.Point(0, 473)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(102, 25)
        Me.MetroLabel10.TabIndex = 841
        Me.MetroLabel10.Text = "Received by"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'ReceivedBy_Tbox
        '
        Me.ReceivedBy_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReceivedBy_Tbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ReceivedBy_Tbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ReceivedBy_Tbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceivedBy_Tbox.FormattingEnabled = True
        Me.ReceivedBy_Tbox.Location = New System.Drawing.Point(117, 473)
        Me.ReceivedBy_Tbox.Name = "ReceivedBy_Tbox"
        Me.ReceivedBy_Tbox.Size = New System.Drawing.Size(359, 25)
        Me.ReceivedBy_Tbox.TabIndex = 842
        Me.ReceivedBy_Tbox.Tag = "SUPPLIER"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.Location = New System.Drawing.Point(17, 442)
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
        Me.Unit_Tbox.CustomButton.Location = New System.Drawing.Point(335, 1)
        Me.Unit_Tbox.CustomButton.Name = ""
        Me.Unit_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Unit_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Unit_Tbox.CustomButton.TabIndex = 1
        Me.Unit_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Unit_Tbox.CustomButton.UseSelectable = True
        Me.Unit_Tbox.CustomButton.Visible = False
        Me.Unit_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Unit_Tbox.Lines = New String(-1) {}
        Me.Unit_Tbox.Location = New System.Drawing.Point(117, 410)
        Me.Unit_Tbox.MaxLength = 32767
        Me.Unit_Tbox.Name = "Unit_Tbox"
        Me.Unit_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Unit_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Unit_Tbox.SelectedText = ""
        Me.Unit_Tbox.SelectionLength = 0
        Me.Unit_Tbox.SelectionStart = 0
        Me.Unit_Tbox.Size = New System.Drawing.Size(359, 25)
        Me.Unit_Tbox.TabIndex = 838
        Me.Unit_Tbox.UseSelectable = True
        Me.Unit_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Unit_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(59, 409)
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
        Me.MetroLabel7.Location = New System.Drawing.Point(25, 379)
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
        Me.MetroLabel6.Location = New System.Drawing.Point(5, 347)
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
        Me.Desc_Cbox.Location = New System.Drawing.Point(117, 347)
        Me.Desc_Cbox.Name = "Desc_Cbox"
        Me.Desc_Cbox.Size = New System.Drawing.Size(359, 25)
        Me.Desc_Cbox.TabIndex = 834
        Me.Desc_Cbox.Tag = "SUPPLIER"
        '
        'Item_Pnl
        '
        Me.Item_Pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_Pnl.BackColor = System.Drawing.Color.White
        Me.Item_Pnl.Controls.Add(Me.Loading2_PB)
        Me.Item_Pnl.Location = New System.Drawing.Point(12, 212)
        Me.Item_Pnl.Name = "Item_Pnl"
        Me.Item_Pnl.Size = New System.Drawing.Size(459, 123)
        Me.Item_Pnl.TabIndex = 0
        '
        'Loading2_PB
        '
        Me.Loading2_PB.BackColor = System.Drawing.Color.Transparent
        Me.Loading2_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Loading2_PB.Image = Global.warehouse2.My.Resources.Resources.loading_trans
        Me.Loading2_PB.ImageLocation = ""
        Me.Loading2_PB.Location = New System.Drawing.Point(202, 34)
        Me.Loading2_PB.Name = "Loading2_PB"
        Me.Loading2_PB.Size = New System.Drawing.Size(55, 55)
        Me.Loading2_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Loading2_PB.TabIndex = 21
        Me.Loading2_PB.TabStop = False
        Me.Loading2_PB.Visible = False
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
        Me.Search_Tbox.CustomButton.Location = New System.Drawing.Point(433, 1)
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
        Me.Search_Tbox.Size = New System.Drawing.Size(459, 27)
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
        Me.CtrlNo_Tbox.CustomButton.Location = New System.Drawing.Point(334, 1)
        Me.CtrlNo_Tbox.CustomButton.Name = ""
        Me.CtrlNo_Tbox.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.CtrlNo_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.CtrlNo_Tbox.CustomButton.TabIndex = 1
        Me.CtrlNo_Tbox.CustomButton.Text = "G"
        Me.CtrlNo_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CtrlNo_Tbox.CustomButton.UseSelectable = True
        Me.CtrlNo_Tbox.CustomButton.UseStyleColors = True
        Me.CtrlNo_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.CtrlNo_Tbox.Lines = New String() {"19-19246"}
        Me.CtrlNo_Tbox.Location = New System.Drawing.Point(113, 6)
        Me.CtrlNo_Tbox.MaxLength = 32767
        Me.CtrlNo_Tbox.Name = "CtrlNo_Tbox"
        Me.CtrlNo_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CtrlNo_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CtrlNo_Tbox.SelectedText = ""
        Me.CtrlNo_Tbox.SelectionLength = 0
        Me.CtrlNo_Tbox.SelectionStart = 0
        Me.CtrlNo_Tbox.ShowButton = True
        Me.CtrlNo_Tbox.Size = New System.Drawing.Size(368, 35)
        Me.CtrlNo_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.CtrlNo_Tbox.TabIndex = 0
        Me.CtrlNo_Tbox.Text = "19-19246"
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
        Me.Line_Pnl.Size = New System.Drawing.Size(466, 2)
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
        'Dept_Cbox
        '
        Me.Dept_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dept_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Dept_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Dept_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept_Cbox.FormattingEnabled = True
        Me.Dept_Cbox.Location = New System.Drawing.Point(113, 140)
        Me.Dept_Cbox.Name = "Dept_Cbox"
        Me.Dept_Cbox.Size = New System.Drawing.Size(328, 25)
        Me.Dept_Cbox.TabIndex = 8
        Me.Dept_Cbox.Tag = "SUPPLIER"
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
        'Position_Cbox
        '
        Me.Position_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Position_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Position_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Position_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position_Cbox.FormattingEnabled = True
        Me.Position_Cbox.Location = New System.Drawing.Point(113, 109)
        Me.Position_Cbox.Name = "Position_Cbox"
        Me.Position_Cbox.Size = New System.Drawing.Size(328, 25)
        Me.Position_Cbox.TabIndex = 6
        Me.Position_Cbox.Tag = "SUPPLIER"
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
        Me.EmpName_Cbox.Location = New System.Drawing.Point(113, 78)
        Me.EmpName_Cbox.Name = "EmpName_Cbox"
        Me.EmpName_Cbox.Size = New System.Drawing.Size(328, 25)
        Me.EmpName_Cbox.TabIndex = 4
        Me.EmpName_Cbox.Tag = "SUPPLIER"
        '
        'Get_Btn
        '
        Me.Get_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Get_Btn.Location = New System.Drawing.Point(447, 47)
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
        'EmpID_Cbox
        '
        Me.EmpID_Cbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpID_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmpID_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpID_Cbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID_Cbox.FormattingEnabled = True
        Me.EmpID_Cbox.Location = New System.Drawing.Point(113, 47)
        Me.EmpID_Cbox.Name = "EmpID_Cbox"
        Me.EmpID_Cbox.Size = New System.Drawing.Size(328, 25)
        Me.EmpID_Cbox.TabIndex = 1
        Me.EmpID_Cbox.Tag = "SUPPLIER"
        '
        'Quantity_Num
        '
        Me.Quantity_Num.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Quantity_Num.DecimalPlaces = 4
        Me.Quantity_Num.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity_Num.Location = New System.Drawing.Point(117, 374)
        Me.Quantity_Num.Name = "Quantity_Num"
        Me.Quantity_Num.Size = New System.Drawing.Size(359, 34)
        Me.Quantity_Num.TabIndex = 836
        Me.Quantity_Num.ThousandsSeparator = True
        '
        'UnitPrice_Num
        '
        Me.UnitPrice_Num.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnitPrice_Num.DecimalPlaces = 4
        Me.UnitPrice_Num.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice_Num.Location = New System.Drawing.Point(117, 437)
        Me.UnitPrice_Num.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitPrice_Num.Name = "UnitPrice_Num"
        Me.UnitPrice_Num.Size = New System.Drawing.Size(359, 34)
        Me.UnitPrice_Num.TabIndex = 840
        Me.UnitPrice_Num.ThousandsSeparator = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Btn_Pnl)
        Me.Panel1.Controls.Add(Me.Mode_Lbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 80)
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
        Me.Btn_Pnl.Size = New System.Drawing.Size(496, 35)
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
        Me.Mode_Lbl.Size = New System.Drawing.Size(476, 25)
        Me.Mode_Lbl.TabIndex = 2
        Me.Mode_Lbl.Text = "New"
        Me.Mode_Lbl.UseCustomBackColor = True
        Me.Mode_Lbl.UseCustomForeColor = True
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
        Me.Loading_PB.Visible = False
        '
        'AccountabilityFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.frm_Split)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frm_Split As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Mode_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents Fields_Pnl As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EmpID_Cbox As ComboBox
    Friend WithEvents Get_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents EmpName_Cbox As ComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Position_Cbox As ComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Dept_Cbox As ComboBox
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
    Friend WithEvents ReceivedBy_Tbox As ComboBox
    Friend WithEvents Quantity_Num As NumericUpDown
    Friend WithEvents Btn_Pnl As Panel
    Friend WithEvents Clear_Btn As Button
    Friend WithEvents Delete_Btn As Button
    Friend WithEvents Edit_Btn As Button
    Friend WithEvents Save_Btn As Button
    Friend WithEvents Refresh_Btn As Button
    Friend WithEvents Loading_PB As PictureBox
    Friend WithEvents Loading2_PB As PictureBox
    Friend WithEvents UnitPrice_Num As NumericUpDown
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateIssued_DTP As MetroFramework.Controls.MetroDateTime
End Class
