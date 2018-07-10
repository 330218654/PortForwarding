<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.NUD_Src = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Dst = New System.Windows.Forms.NumericUpDown()
        Me.Lab_Src = New System.Windows.Forms.Label()
        Me.Lab_Dst = New System.Windows.Forms.Label()
        Me.Chk_LogRevSize = New System.Windows.Forms.CheckBox()
        Me.Chk_LogSndSize = New System.Windows.Forms.CheckBox()
        Me.Chk_LogClose = New System.Windows.Forms.CheckBox()
        Me.Lab_SndBufSize = New System.Windows.Forms.Label()
        Me.NUD_SndBufferSize = New System.Windows.Forms.NumericUpDown()
        Me.Chk_LogAccept = New System.Windows.Forms.CheckBox()
        Me.Lab_RevBufSize = New System.Windows.Forms.Label()
        Me.NUD_RevBufferSize = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Manager = New System.Windows.Forms.Button()
        Me.GPB_ManagerClient = New System.Windows.Forms.GroupBox()
        Me.Btn_Import = New System.Windows.Forms.Button()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Btn_RmHourAgo = New System.Windows.Forms.Button()
        Me.NUD_Hour = New System.Windows.Forms.NumericUpDown()
        Me.Num_Count = New System.Windows.Forms.NumericUpDown()
        Me.Btn_RmCountlt = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Cmb_UIFilter = New System.Windows.Forms.ComboBox()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_Defense = New System.Windows.Forms.Button()
        Me.Btn_Access = New System.Windows.Forms.Button()
        Me.Btn_ReSet = New System.Windows.Forms.Button()
        Me.Btn_ReLoad = New System.Windows.Forms.Button()
        Me.Ltv_Client = New System.Windows.Forms.ListView()
        Me.CMH_Serial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMH_IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMH_RevCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMH_SndCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMH_IsDefensed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMH_DefenseTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMH_Count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMH_LastTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Log = New Sy.UI.Control.TextBox()
        CType(Me.NUD_Src, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Dst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SndBufferSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_RevBufferSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPB_ManagerClient.SuspendLayout()
        CType(Me.NUD_Hour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Start
        '
        Me.Btn_Start.Location = New System.Drawing.Point(483, 12)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(220, 58)
        Me.Btn_Start.TabIndex = 41
        Me.Btn_Start.Text = Global.PortForwarding.My.Resources.Resources.Btn_Start_Text_Start
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'NUD_Src
        '
        Me.NUD_Src.Location = New System.Drawing.Point(43, 17)
        Me.NUD_Src.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.NUD_Src.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Src.Name = "NUD_Src"
        Me.NUD_Src.Size = New System.Drawing.Size(58, 21)
        Me.NUD_Src.TabIndex = 42
        Me.NUD_Src.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_Src.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'NUD_Dst
        '
        Me.NUD_Dst.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.NUD_Dst.Location = New System.Drawing.Point(43, 47)
        Me.NUD_Dst.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.NUD_Dst.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Dst.Name = "NUD_Dst"
        Me.NUD_Dst.Size = New System.Drawing.Size(58, 21)
        Me.NUD_Dst.TabIndex = 44
        Me.NUD_Dst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_Dst.Value = New Decimal(New Integer() {2222, 0, 0, 0})
        '
        'Lab_Src
        '
        Me.Lab_Src.AutoSize = True
        Me.Lab_Src.Location = New System.Drawing.Point(12, 21)
        Me.Lab_Src.Name = "Lab_Src"
        Me.Lab_Src.Size = New System.Drawing.Size(35, 12)
        Me.Lab_Src.TabIndex = 45
        Me.Lab_Src.Text = "Src："
        '
        'Lab_Dst
        '
        Me.Lab_Dst.AutoSize = True
        Me.Lab_Dst.Location = New System.Drawing.Point(12, 51)
        Me.Lab_Dst.Name = "Lab_Dst"
        Me.Lab_Dst.Size = New System.Drawing.Size(35, 12)
        Me.Lab_Dst.TabIndex = 46
        Me.Lab_Dst.Text = "Dst："
        '
        'Chk_LogRevSize
        '
        Me.Chk_LogRevSize.AutoSize = True
        Me.Chk_LogRevSize.Checked = True
        Me.Chk_LogRevSize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_LogRevSize.Location = New System.Drawing.Point(393, 19)
        Me.Chk_LogRevSize.Name = "Chk_LogRevSize"
        Me.Chk_LogRevSize.Size = New System.Drawing.Size(84, 16)
        Me.Chk_LogRevSize.TabIndex = 47
        Me.Chk_LogRevSize.Text = Global.PortForwarding.My.Resources.Resources.Chk_LogRevSize_Text
        Me.Chk_LogRevSize.UseVisualStyleBackColor = True
        '
        'Chk_LogSndSize
        '
        Me.Chk_LogSndSize.AutoSize = True
        Me.Chk_LogSndSize.Checked = True
        Me.Chk_LogSndSize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_LogSndSize.Location = New System.Drawing.Point(393, 49)
        Me.Chk_LogSndSize.Name = "Chk_LogSndSize"
        Me.Chk_LogSndSize.Size = New System.Drawing.Size(90, 16)
        Me.Chk_LogSndSize.TabIndex = 48
        Me.Chk_LogSndSize.Text = Global.PortForwarding.My.Resources.Resources.Chk_LogSndSize_Text
        Me.Chk_LogSndSize.UseVisualStyleBackColor = True
        '
        'Chk_LogClose
        '
        Me.Chk_LogClose.AutoSize = True
        Me.Chk_LogClose.Checked = True
        Me.Chk_LogClose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_LogClose.Location = New System.Drawing.Point(303, 49)
        Me.Chk_LogClose.Name = "Chk_LogClose"
        Me.Chk_LogClose.Size = New System.Drawing.Size(72, 16)
        Me.Chk_LogClose.TabIndex = 49
        Me.Chk_LogClose.Text = Global.PortForwarding.My.Resources.Resources.Chk_LogClose_Text
        Me.Chk_LogClose.UseVisualStyleBackColor = True
        '
        'Lab_SndBufSize
        '
        Me.Lab_SndBufSize.AutoSize = True
        Me.Lab_SndBufSize.Location = New System.Drawing.Point(124, 51)
        Me.Lab_SndBufSize.Name = "Lab_SndBufSize"
        Me.Lab_SndBufSize.Size = New System.Drawing.Size(77, 12)
        Me.Lab_SndBufSize.TabIndex = 51
        Me.Lab_SndBufSize.Text = "SndBufSize："
        '
        'NUD_SndBufferSize
        '
        Me.NUD_SndBufferSize.Location = New System.Drawing.Point(198, 47)
        Me.NUD_SndBufferSize.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.NUD_SndBufferSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_SndBufferSize.Name = "NUD_SndBufferSize"
        Me.NUD_SndBufferSize.Size = New System.Drawing.Size(80, 21)
        Me.NUD_SndBufferSize.TabIndex = 50
        Me.NUD_SndBufferSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_SndBufferSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Chk_LogAccept
        '
        Me.Chk_LogAccept.AutoSize = True
        Me.Chk_LogAccept.Checked = True
        Me.Chk_LogAccept.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_LogAccept.Location = New System.Drawing.Point(303, 19)
        Me.Chk_LogAccept.Name = "Chk_LogAccept"
        Me.Chk_LogAccept.Size = New System.Drawing.Size(78, 16)
        Me.Chk_LogAccept.TabIndex = 52
        Me.Chk_LogAccept.Text = Global.PortForwarding.My.Resources.Resources.Chk_LogAccept_Text
        Me.Chk_LogAccept.UseVisualStyleBackColor = True
        '
        'Lab_RevBufSize
        '
        Me.Lab_RevBufSize.AutoSize = True
        Me.Lab_RevBufSize.Location = New System.Drawing.Point(124, 21)
        Me.Lab_RevBufSize.Name = "Lab_RevBufSize"
        Me.Lab_RevBufSize.Size = New System.Drawing.Size(77, 12)
        Me.Lab_RevBufSize.TabIndex = 54
        Me.Lab_RevBufSize.Text = "RevBufSize："
        '
        'NUD_RevBufferSize
        '
        Me.NUD_RevBufferSize.Location = New System.Drawing.Point(198, 17)
        Me.NUD_RevBufferSize.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.NUD_RevBufferSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_RevBufferSize.Name = "NUD_RevBufferSize"
        Me.NUD_RevBufferSize.Size = New System.Drawing.Size(80, 21)
        Me.NUD_RevBufferSize.TabIndex = 53
        Me.NUD_RevBufferSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_RevBufferSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Btn_Manager
        '
        Me.Btn_Manager.Location = New System.Drawing.Point(709, 12)
        Me.Btn_Manager.Name = "Btn_Manager"
        Me.Btn_Manager.Size = New System.Drawing.Size(130, 58)
        Me.Btn_Manager.TabIndex = 55
        Me.Btn_Manager.Text = Global.PortForwarding.My.Resources.Resources.Btn_Manager_Text
        Me.Btn_Manager.UseVisualStyleBackColor = True
        '
        'GPB_ManagerClient
        '
        Me.GPB_ManagerClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_Import)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_Export)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_RmHourAgo)
        Me.GPB_ManagerClient.Controls.Add(Me.NUD_Hour)
        Me.GPB_ManagerClient.Controls.Add(Me.Num_Count)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_RmCountlt)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_Clear)
        Me.GPB_ManagerClient.Controls.Add(Me.Cmb_UIFilter)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_Remove)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_Defense)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_Access)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_ReSet)
        Me.GPB_ManagerClient.Controls.Add(Me.Btn_ReLoad)
        Me.GPB_ManagerClient.Controls.Add(Me.Ltv_Client)
        Me.GPB_ManagerClient.Controls.Add(Me.Button1)
        Me.GPB_ManagerClient.Location = New System.Drawing.Point(8, 12)
        Me.GPB_ManagerClient.Name = "GPB_ManagerClient"
        Me.GPB_ManagerClient.Size = New System.Drawing.Size(836, 558)
        Me.GPB_ManagerClient.TabIndex = 56
        Me.GPB_ManagerClient.TabStop = False
        Me.GPB_ManagerClient.Text = "Manager Client"
        Me.GPB_ManagerClient.Visible = False
        '
        'Btn_Import
        '
        Me.Btn_Import.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Import.Location = New System.Drawing.Point(732, 284)
        Me.Btn_Import.Name = "Btn_Import"
        Me.Btn_Import.Size = New System.Drawing.Size(96, 38)
        Me.Btn_Import.TabIndex = 70
        Me.Btn_Import.Text = Global.PortForwarding.My.Resources.Resources.Btn_Import_Text
        Me.Btn_Import.UseVisualStyleBackColor = True
        '
        'Btn_Export
        '
        Me.Btn_Export.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Export.Location = New System.Drawing.Point(732, 240)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(96, 38)
        Me.Btn_Export.TabIndex = 69
        Me.Btn_Export.Text = Global.PortForwarding.My.Resources.Resources.Btn_Export_Text
        Me.Btn_Export.UseVisualStyleBackColor = True
        '
        'Btn_RmHourAgo
        '
        Me.Btn_RmHourAgo.ForeColor = System.Drawing.Color.Fuchsia
        Me.Btn_RmHourAgo.Location = New System.Drawing.Point(733, 355)
        Me.Btn_RmHourAgo.Name = "Btn_RmHourAgo"
        Me.Btn_RmHourAgo.Size = New System.Drawing.Size(95, 38)
        Me.Btn_RmHourAgo.TabIndex = 68
        Me.Btn_RmHourAgo.Text = Global.PortForwarding.My.Resources.Resources.Btn_RmHourAgo_Text
        Me.Btn_RmHourAgo.UseVisualStyleBackColor = True
        '
        'NUD_Hour
        '
        Me.NUD_Hour.Location = New System.Drawing.Point(733, 328)
        Me.NUD_Hour.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.NUD_Hour.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Hour.Name = "NUD_Hour"
        Me.NUD_Hour.Size = New System.Drawing.Size(95, 21)
        Me.NUD_Hour.TabIndex = 67
        Me.NUD_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_Hour.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Num_Count
        '
        Me.Num_Count.Location = New System.Drawing.Point(733, 399)
        Me.Num_Count.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.Num_Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num_Count.Name = "Num_Count"
        Me.Num_Count.Size = New System.Drawing.Size(95, 21)
        Me.Num_Count.TabIndex = 66
        Me.Num_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Num_Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Btn_RmCountlt
        '
        Me.Btn_RmCountlt.ForeColor = System.Drawing.Color.Fuchsia
        Me.Btn_RmCountlt.Location = New System.Drawing.Point(733, 426)
        Me.Btn_RmCountlt.Name = "Btn_RmCountlt"
        Me.Btn_RmCountlt.Size = New System.Drawing.Size(95, 38)
        Me.Btn_RmCountlt.TabIndex = 65
        Me.Btn_RmCountlt.Text = Global.PortForwarding.My.Resources.Resources.Btn_RmCountlt_Text
        Me.Btn_RmCountlt.UseVisualStyleBackColor = True
        '
        'Btn_Clear
        '
        Me.Btn_Clear.ForeColor = System.Drawing.Color.Fuchsia
        Me.Btn_Clear.Location = New System.Drawing.Point(733, 514)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(96, 38)
        Me.Btn_Clear.TabIndex = 64
        Me.Btn_Clear.Text = Global.PortForwarding.My.Resources.Resources.Btn_Clear_Text
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Cmb_UIFilter
        '
        Me.Cmb_UIFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_UIFilter.FormattingEnabled = True
        Me.Cmb_UIFilter.Location = New System.Drawing.Point(732, 38)
        Me.Cmb_UIFilter.Name = "Cmb_UIFilter"
        Me.Cmb_UIFilter.Size = New System.Drawing.Size(95, 20)
        Me.Cmb_UIFilter.TabIndex = 63
        '
        'Btn_Remove
        '
        Me.Btn_Remove.ForeColor = System.Drawing.Color.Fuchsia
        Me.Btn_Remove.Location = New System.Drawing.Point(733, 470)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(95, 38)
        Me.Btn_Remove.TabIndex = 62
        Me.Btn_Remove.Text = Global.PortForwarding.My.Resources.Resources.Btn_Remove_Text
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Defense
        '
        Me.Btn_Defense.ForeColor = System.Drawing.Color.Red
        Me.Btn_Defense.Location = New System.Drawing.Point(732, 196)
        Me.Btn_Defense.Name = "Btn_Defense"
        Me.Btn_Defense.Size = New System.Drawing.Size(96, 38)
        Me.Btn_Defense.TabIndex = 61
        Me.Btn_Defense.Text = Global.PortForwarding.My.Resources.Resources.Btn_Defense_Text
        Me.Btn_Defense.UseVisualStyleBackColor = True
        '
        'Btn_Access
        '
        Me.Btn_Access.Location = New System.Drawing.Point(732, 152)
        Me.Btn_Access.Name = "Btn_Access"
        Me.Btn_Access.Size = New System.Drawing.Size(96, 38)
        Me.Btn_Access.TabIndex = 60
        Me.Btn_Access.Text = Global.PortForwarding.My.Resources.Resources.Btn_Access_Text
        Me.Btn_Access.UseVisualStyleBackColor = True
        '
        'Btn_ReSet
        '
        Me.Btn_ReSet.Location = New System.Drawing.Point(732, 108)
        Me.Btn_ReSet.Name = "Btn_ReSet"
        Me.Btn_ReSet.Size = New System.Drawing.Size(96, 38)
        Me.Btn_ReSet.TabIndex = 59
        Me.Btn_ReSet.Text = Global.PortForwarding.My.Resources.Resources.Btn_ReSet_Text
        Me.Btn_ReSet.UseVisualStyleBackColor = True
        '
        'Btn_ReLoad
        '
        Me.Btn_ReLoad.Location = New System.Drawing.Point(732, 64)
        Me.Btn_ReLoad.Name = "Btn_ReLoad"
        Me.Btn_ReLoad.Size = New System.Drawing.Size(96, 38)
        Me.Btn_ReLoad.TabIndex = 58
        Me.Btn_ReLoad.Text = Global.PortForwarding.My.Resources.Resources.Btn_ReLoad_Text
        Me.Btn_ReLoad.UseVisualStyleBackColor = True
        '
        'Ltv_Client
        '
        Me.Ltv_Client.CheckBoxes = True
        Me.Ltv_Client.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CMH_Serial, Me.CMH_IP, Me.CMH_RevCount, Me.CMH_SndCount, Me.CMH_IsDefensed, Me.CMH_DefenseTime, Me.CMH_Count, Me.CMH_LastTime})
        Me.Ltv_Client.FullRowSelect = True
        Me.Ltv_Client.Location = New System.Drawing.Point(6, 16)
        Me.Ltv_Client.Name = "Ltv_Client"
        Me.Ltv_Client.Size = New System.Drawing.Size(722, 534)
        Me.Ltv_Client.TabIndex = 57
        Me.Ltv_Client.UseCompatibleStateImageBehavior = False
        Me.Ltv_Client.View = System.Windows.Forms.View.Details
        '
        'CMH_Serial
        '
        Me.CMH_Serial.Text = Global.PortForwarding.My.Resources.Resources.CMH_Serial_Text
        Me.CMH_Serial.Width = 53
        '
        'CMH_IP
        '
        Me.CMH_IP.Text = Global.PortForwarding.My.Resources.Resources.CMH_IP_Text
        Me.CMH_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMH_IP.Width = 106
        '
        'CMH_RevCount
        '
        Me.CMH_RevCount.Text = Global.PortForwarding.My.Resources.Resources.CMH_RevCount_Text
        Me.CMH_RevCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMH_RevCount.Width = 72
        '
        'CMH_SndCount
        '
        Me.CMH_SndCount.Text = Global.PortForwarding.My.Resources.Resources.CMH_SndCount_Text
        Me.CMH_SndCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMH_SndCount.Width = 71
        '
        'CMH_IsDefensed
        '
        Me.CMH_IsDefensed.Text = Global.PortForwarding.My.Resources.Resources.CMH_IsDefensed_Text
        Me.CMH_IsDefensed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMH_IsDefensed.Width = 76
        '
        'CMH_DefenseTime
        '
        Me.CMH_DefenseTime.Text = Global.PortForwarding.My.Resources.Resources.CMH_DefenseTime_Text
        Me.CMH_DefenseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMH_DefenseTime.Width = 93
        '
        'CMH_Count
        '
        Me.CMH_Count.Text = Global.PortForwarding.My.Resources.Resources.CMH_Count_Text
        Me.CMH_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMH_Count.Width = 63
        '
        'CMH_LastTime
        '
        Me.CMH_LastTime.Text = Global.PortForwarding.My.Resources.Resources.CMH_LastTime_Text
        Me.CMH_LastTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CMH_LastTime.Width = 148
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(803, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 22)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "_"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.BorderColor = System.Drawing.Color.Black
        Me.Log.BorderPrint = True
        Me.Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Log.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Log.Location = New System.Drawing.Point(0, 79)
        Me.Log.MaxTextLen = 6666
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(851, 503)
        Me.Log.TabIndex = 0
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 582)
        Me.Controls.Add(Me.GPB_ManagerClient)
        Me.Controls.Add(Me.NUD_Dst)
        Me.Controls.Add(Me.NUD_Src)
        Me.Controls.Add(Me.Btn_Manager)
        Me.Controls.Add(Me.NUD_RevBufferSize)
        Me.Controls.Add(Me.NUD_SndBufferSize)
        Me.Controls.Add(Me.Lab_RevBufSize)
        Me.Controls.Add(Me.Chk_LogAccept)
        Me.Controls.Add(Me.Lab_SndBufSize)
        Me.Controls.Add(Me.Chk_LogClose)
        Me.Controls.Add(Me.Chk_LogSndSize)
        Me.Controls.Add(Me.Chk_LogRevSize)
        Me.Controls.Add(Me.Lab_Dst)
        Me.Controls.Add(Me.Lab_Src)
        Me.Controls.Add(Me.Btn_Start)
        Me.Controls.Add(Me.Log)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Main"
        Me.Text = "Port Firewall"
        CType(Me.NUD_Src, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Dst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SndBufferSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_RevBufferSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPB_ManagerClient.ResumeLayout(False)
        CType(Me.NUD_Hour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Count, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Btn_RmHourAgo As Button
    Private WithEvents NUD_Hour As NumericUpDown
    Private WithEvents Log As Sy.UI.Control.TextBox
    Private WithEvents Btn_Start As Button
    Private WithEvents NUD_Src As NumericUpDown
    Private WithEvents NUD_Dst As NumericUpDown
    Private WithEvents Lab_Src As Label
    Private WithEvents Lab_Dst As Label
    Private WithEvents Chk_LogRevSize As CheckBox
    Private WithEvents Chk_LogSndSize As CheckBox
    Private WithEvents Chk_LogClose As CheckBox
    Private WithEvents Lab_SndBufSize As Label
    Private WithEvents NUD_SndBufferSize As NumericUpDown
    Private WithEvents Chk_LogAccept As CheckBox
    Private WithEvents Lab_RevBufSize As Label
    Private WithEvents NUD_RevBufferSize As NumericUpDown
    Private WithEvents Btn_Manager As Button
    Private WithEvents GPB_ManagerClient As GroupBox
    Private WithEvents Button1 As Button
    Private WithEvents Btn_ReLoad As Button
    Private WithEvents Ltv_Client As ListView
    Private WithEvents CMH_Serial As ColumnHeader
    Private WithEvents CMH_IP As ColumnHeader
    Private WithEvents CMH_RevCount As ColumnHeader
    Private WithEvents CMH_SndCount As ColumnHeader
    Private WithEvents CMH_IsDefensed As ColumnHeader
    Private WithEvents Btn_Defense As Button
    Private WithEvents Btn_Access As Button
    Private WithEvents Btn_ReSet As Button
    Private WithEvents CMH_DefenseTime As ColumnHeader
    Private WithEvents CMH_Count As ColumnHeader
    Private WithEvents Btn_Clear As Button
    Private WithEvents Cmb_UIFilter As ComboBox
    Private WithEvents Btn_Remove As Button
    Private WithEvents CMH_LastTime As ColumnHeader
    Private WithEvents Btn_RmCountlt As Button
    Private WithEvents Num_Count As NumericUpDown
    Private WithEvents Btn_Import As Button
    Private WithEvents Btn_Export As Button
End Class
