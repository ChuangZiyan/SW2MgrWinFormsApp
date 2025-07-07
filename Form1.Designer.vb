<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        CreateNewSW2App_Button = New Button()
        DeleteSelectedSW2AppFolder_Button = New Button()
        LaunchSeletedSW2App_Button = New Button()
        TerminateSW2AppByPId_Button = New Button()
        UpdateSW2AppListView_Button = New Button()
        SW2App_ListView = New ListView()
        SW2App_PId_ColumnHeader = New ColumnHeader()
        SW2App_FolderName_ColumnHeader = New ColumnHeader()
        SW2App_Version_ColumnHeader = New ColumnHeader()
        SW2App_Status_ColumnHeader = New ColumnHeader()
        SW2APP_AutoRun_ColumnHeader = New ColumnHeader()
        SW2APP_AutoRunDelaySeconds_ColumnHeader = New ColumnHeader()
        SW2APP_RunMode_ColumnHeader = New ColumnHeader()
        SW2APP_NumberOfRuns_ColumnHeader = New ColumnHeader()
        Label1 = New Label()
        NewSW2FolderName_TextBox = New TextBox()
        Label2 = New Label()
        UpdateSelectedSW2App_Button = New Button()
        SourceSW2AppVersion_TextBox = New TextBox()
        RevealAppSourceFolder_Button = New Button()
        TerminateAllSW2App_Button = New Button()
        UpdateAllSWApp_Button = New Button()
        AppConfigs_GroupBox = New GroupBox()
        Label3 = New Label()
        Label13 = New Label()
        SW2App_NumberOfRuns_NumericUpDown = New NumericUpDown()
        SW2App_AutoRunDelaySeconds_NumericUpDown = New NumericUpDown()
        Label12 = New Label()
        Label7 = New Label()
        SW2App_ScheduledRun_RadioButton = New RadioButton()
        SW2App_SequentialRun_RadioButton = New RadioButton()
        Label4 = New Label()
        SaveSW2AppConfigs_Button = New Button()
        SW2App_AutoRun_CheckBox = New CheckBox()
        Label10 = New Label()
        SWAPP_OpacityValue_NumericUpDown = New NumericUpDown()
        Label9 = New Label()
        LiteModeScriptListView_RadioButton = New RadioButton()
        LiteModeWebview_RadioButton = New RadioButton()
        LiteModeNormal_RadioButton = New RadioButton()
        LaunchDelaySeconds_NumericUpDown = New NumericUpDown()
        Label5 = New Label()
        AppUpdating_ProgressBar = New ProgressBar()
        AppUpdatingProgressInfo_Label = New Label()
        Label6 = New Label()
        UpdatingProgressPercent_Label = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        SelectAllSW2AppListViewItems_Button = New Button()
        DeselectAllSW2AppListViewItems_Button = New Button()
        SW2APPSearchText_ComboBox = New ComboBox()
        MarkSW2ListViewItemsByText_Button = New Button()
        SelectedItemsByText_Button = New Button()
        UnmarkSW2ListViewItemsByText_Button = New Button()
        SetSWAppForeground_Button = New Button()
        GroupBox1 = New GroupBox()
        Label15 = New Label()
        ApplySWAppLocation_Button = New Button()
        SWAppLocationY_NumericUpDown = New NumericUpDown()
        SWAppLocationX_NumericUpDown = New NumericUpDown()
        Label11 = New Label()
        ApplySWAppWindowConfigs_Button = New Button()
        ColseAppByPipeLine_Button = New Button()
        Label8 = New Label()
        AppSourcePath_TextBox = New TextBox()
        ApplySourceAppPath_Button = New Button()
        Label14 = New Label()
        AppConfigs_GroupBox.SuspendLayout()
        CType(SW2App_NumberOfRuns_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(SW2App_AutoRunDelaySeconds_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(SWAPP_OpacityValue_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(LaunchDelaySeconds_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(SWAppLocationY_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(SWAppLocationX_NumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CreateNewSW2App_Button
        ' 
        CreateNewSW2App_Button.Cursor = Cursors.Hand
        CreateNewSW2App_Button.Location = New Point(244, 337)
        CreateNewSW2App_Button.Margin = New Padding(2)
        CreateNewSW2App_Button.Name = "CreateNewSW2App_Button"
        CreateNewSW2App_Button.Size = New Size(126, 23)
        CreateNewSW2App_Button.TabIndex = 1
        CreateNewSW2App_Button.Text = "新增"
        CreateNewSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' DeleteSelectedSW2AppFolder_Button
        ' 
        DeleteSelectedSW2AppFolder_Button.Cursor = Cursors.Hand
        DeleteSelectedSW2AppFolder_Button.Location = New Point(375, 337)
        DeleteSelectedSW2AppFolder_Button.Margin = New Padding(2)
        DeleteSelectedSW2AppFolder_Button.Name = "DeleteSelectedSW2AppFolder_Button"
        DeleteSelectedSW2AppFolder_Button.Size = New Size(126, 23)
        DeleteSelectedSW2AppFolder_Button.TabIndex = 2
        DeleteSelectedSW2AppFolder_Button.Text = "刪除"
        DeleteSelectedSW2AppFolder_Button.UseVisualStyleBackColor = True
        ' 
        ' LaunchSeletedSW2App_Button
        ' 
        LaunchSeletedSW2App_Button.Cursor = Cursors.Hand
        LaunchSeletedSW2App_Button.Font = New Font("Microsoft JhengHei UI", 9F, FontStyle.Bold)
        LaunchSeletedSW2App_Button.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        LaunchSeletedSW2App_Button.Location = New Point(115, 369)
        LaunchSeletedSW2App_Button.Margin = New Padding(2)
        LaunchSeletedSW2App_Button.Name = "LaunchSeletedSW2App_Button"
        LaunchSeletedSW2App_Button.Size = New Size(126, 23)
        LaunchSeletedSW2App_Button.TabIndex = 3
        LaunchSeletedSW2App_Button.Text = "啟動程式"
        LaunchSeletedSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' TerminateSW2AppByPId_Button
        ' 
        TerminateSW2AppByPId_Button.Cursor = Cursors.Hand
        TerminateSW2AppByPId_Button.Location = New Point(375, 369)
        TerminateSW2AppByPId_Button.Margin = New Padding(2)
        TerminateSW2AppByPId_Button.Name = "TerminateSW2AppByPId_Button"
        TerminateSW2AppByPId_Button.Size = New Size(126, 23)
        TerminateSW2AppByPId_Button.TabIndex = 4
        TerminateSW2AppByPId_Button.Text = "關閉所選"
        TerminateSW2AppByPId_Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateSW2AppListView_Button
        ' 
        UpdateSW2AppListView_Button.Location = New Point(35, 151)
        UpdateSW2AppListView_Button.Margin = New Padding(2)
        UpdateSW2AppListView_Button.Name = "UpdateSW2AppListView_Button"
        UpdateSW2AppListView_Button.Size = New Size(73, 23)
        UpdateSW2AppListView_Button.TabIndex = 5
        UpdateSW2AppListView_Button.Text = "重新整理"
        UpdateSW2AppListView_Button.UseVisualStyleBackColor = True
        UpdateSW2AppListView_Button.Visible = False
        ' 
        ' SW2App_ListView
        ' 
        SW2App_ListView.BackColor = SystemColors.Window
        SW2App_ListView.Columns.AddRange(New ColumnHeader() {SW2App_PId_ColumnHeader, SW2App_FolderName_ColumnHeader, SW2App_Version_ColumnHeader, SW2App_Status_ColumnHeader, SW2APP_AutoRun_ColumnHeader, SW2APP_AutoRunDelaySeconds_ColumnHeader, SW2APP_RunMode_ColumnHeader, SW2APP_NumberOfRuns_ColumnHeader})
        SW2App_ListView.FullRowSelect = True
        SW2App_ListView.Location = New Point(25, 47)
        SW2App_ListView.Margin = New Padding(2)
        SW2App_ListView.Name = "SW2App_ListView"
        SW2App_ListView.Size = New Size(496, 280)
        SW2App_ListView.TabIndex = 6
        SW2App_ListView.UseCompatibleStateImageBehavior = False
        SW2App_ListView.View = View.Details
        ' 
        ' SW2App_PId_ColumnHeader
        ' 
        SW2App_PId_ColumnHeader.Text = "PID"
        SW2App_PId_ColumnHeader.Width = 67
        ' 
        ' SW2App_FolderName_ColumnHeader
        ' 
        SW2App_FolderName_ColumnHeader.Text = "名稱"
        SW2App_FolderName_ColumnHeader.Width = 67
        ' 
        ' SW2App_Version_ColumnHeader
        ' 
        SW2App_Version_ColumnHeader.Text = "版本"
        SW2App_Version_ColumnHeader.Width = 0
        ' 
        ' SW2App_Status_ColumnHeader
        ' 
        SW2App_Status_ColumnHeader.Text = "狀態"
        SW2App_Status_ColumnHeader.Width = 67
        ' 
        ' SW2APP_AutoRun_ColumnHeader
        ' 
        SW2APP_AutoRun_ColumnHeader.Text = "啟動執行"
        SW2APP_AutoRun_ColumnHeader.Width = 67
        ' 
        ' SW2APP_AutoRunDelaySeconds_ColumnHeader
        ' 
        SW2APP_AutoRunDelaySeconds_ColumnHeader.Text = "延遲秒數"
        SW2APP_AutoRunDelaySeconds_ColumnHeader.Width = 67
        ' 
        ' SW2APP_RunMode_ColumnHeader
        ' 
        SW2APP_RunMode_ColumnHeader.Text = "執行模式"
        SW2APP_RunMode_ColumnHeader.Width = 67
        ' 
        ' SW2APP_NumberOfRuns_ColumnHeader
        ' 
        SW2APP_NumberOfRuns_ColumnHeader.Text = "執行次數"
        SW2APP_NumberOfRuns_ColumnHeader.Width = 67
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 340)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 7
        Label1.Text = "名稱："
        ' 
        ' NewSW2FolderName_TextBox
        ' 
        NewSW2FolderName_TextBox.Location = New Point(64, 337)
        NewSW2FolderName_TextBox.Margin = New Padding(2)
        NewSW2FolderName_TextBox.Name = "NewSW2FolderName_TextBox"
        NewSW2FolderName_TextBox.Size = New Size(171, 23)
        NewSW2FolderName_TextBox.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 107)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 0
        Label2.Text = "來源版本 : "
        Label2.Visible = False
        ' 
        ' UpdateSelectedSW2App_Button
        ' 
        UpdateSelectedSW2App_Button.Location = New Point(35, 82)
        UpdateSelectedSW2App_Button.Margin = New Padding(2)
        UpdateSelectedSW2App_Button.Name = "UpdateSelectedSW2App_Button"
        UpdateSelectedSW2App_Button.Size = New Size(73, 23)
        UpdateSelectedSW2App_Button.TabIndex = 1
        UpdateSelectedSW2App_Button.Text = "更新所選"
        UpdateSelectedSW2App_Button.UseVisualStyleBackColor = True
        UpdateSelectedSW2App_Button.Visible = False
        ' 
        ' SourceSW2AppVersion_TextBox
        ' 
        SourceSW2AppVersion_TextBox.Location = New Point(35, 124)
        SourceSW2AppVersion_TextBox.Margin = New Padding(2)
        SourceSW2AppVersion_TextBox.Name = "SourceSW2AppVersion_TextBox"
        SourceSW2AppVersion_TextBox.ReadOnly = True
        SourceSW2AppVersion_TextBox.Size = New Size(73, 23)
        SourceSW2AppVersion_TextBox.TabIndex = 2
        SourceSW2AppVersion_TextBox.Visible = False
        ' 
        ' RevealAppSourceFolder_Button
        ' 
        RevealAppSourceFolder_Button.Cursor = Cursors.Hand
        RevealAppSourceFolder_Button.Location = New Point(376, 16)
        RevealAppSourceFolder_Button.Margin = New Padding(2)
        RevealAppSourceFolder_Button.Name = "RevealAppSourceFolder_Button"
        RevealAppSourceFolder_Button.Size = New Size(90, 23)
        RevealAppSourceFolder_Button.TabIndex = 3
        RevealAppSourceFolder_Button.Text = "開啟"
        RevealAppSourceFolder_Button.UseVisualStyleBackColor = True
        ' 
        ' TerminateAllSW2App_Button
        ' 
        TerminateAllSW2App_Button.Cursor = Cursors.Hand
        TerminateAllSW2App_Button.Location = New Point(505, 369)
        TerminateAllSW2App_Button.Margin = New Padding(2)
        TerminateAllSW2App_Button.Name = "TerminateAllSW2App_Button"
        TerminateAllSW2App_Button.Size = New Size(126, 23)
        TerminateAllSW2App_Button.TabIndex = 10
        TerminateAllSW2App_Button.Text = "全部關閉"
        TerminateAllSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateAllSWApp_Button
        ' 
        UpdateAllSWApp_Button.Cursor = Cursors.Hand
        UpdateAllSWApp_Button.Location = New Point(537, 16)
        UpdateAllSWApp_Button.Margin = New Padding(2)
        UpdateAllSWApp_Button.Name = "UpdateAllSWApp_Button"
        UpdateAllSWApp_Button.Size = New Size(185, 23)
        UpdateAllSWApp_Button.TabIndex = 11
        UpdateAllSWApp_Button.Text = "全部更新"
        UpdateAllSWApp_Button.UseVisualStyleBackColor = True
        ' 
        ' AppConfigs_GroupBox
        ' 
        AppConfigs_GroupBox.Controls.Add(Label3)
        AppConfigs_GroupBox.Controls.Add(Label13)
        AppConfigs_GroupBox.Controls.Add(SW2App_NumberOfRuns_NumericUpDown)
        AppConfigs_GroupBox.Controls.Add(SW2App_AutoRunDelaySeconds_NumericUpDown)
        AppConfigs_GroupBox.Controls.Add(Label12)
        AppConfigs_GroupBox.Controls.Add(Label7)
        AppConfigs_GroupBox.Controls.Add(SW2App_ScheduledRun_RadioButton)
        AppConfigs_GroupBox.Controls.Add(SW2App_SequentialRun_RadioButton)
        AppConfigs_GroupBox.Controls.Add(Label4)
        AppConfigs_GroupBox.Controls.Add(SaveSW2AppConfigs_Button)
        AppConfigs_GroupBox.Location = New Point(529, 47)
        AppConfigs_GroupBox.Margin = New Padding(2)
        AppConfigs_GroupBox.Name = "AppConfigs_GroupBox"
        AppConfigs_GroupBox.Padding = New Padding(2)
        AppConfigs_GroupBox.Size = New Size(232, 136)
        AppConfigs_GroupBox.TabIndex = 12
        AppConfigs_GroupBox.TabStop = False
        AppConfigs_GroupBox.Text = "程式設置"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 31)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "等待："
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(146, 101)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(19, 15)
        Label13.TabIndex = 29
        Label13.Text = "秒"
        ' 
        ' SW2App_NumberOfRuns_NumericUpDown
        ' 
        SW2App_NumberOfRuns_NumericUpDown.Location = New Point(62, 96)
        SW2App_NumberOfRuns_NumericUpDown.Margin = New Padding(2)
        SW2App_NumberOfRuns_NumericUpDown.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        SW2App_NumberOfRuns_NumericUpDown.Name = "SW2App_NumberOfRuns_NumericUpDown"
        SW2App_NumberOfRuns_NumericUpDown.Size = New Size(80, 23)
        SW2App_NumberOfRuns_NumericUpDown.TabIndex = 8
        SW2App_NumberOfRuns_NumericUpDown.TextAlign = HorizontalAlignment.Center
        ' 
        ' SW2App_AutoRunDelaySeconds_NumericUpDown
        ' 
        SW2App_AutoRunDelaySeconds_NumericUpDown.Location = New Point(62, 27)
        SW2App_AutoRunDelaySeconds_NumericUpDown.Margin = New Padding(2)
        SW2App_AutoRunDelaySeconds_NumericUpDown.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        SW2App_AutoRunDelaySeconds_NumericUpDown.Name = "SW2App_AutoRunDelaySeconds_NumericUpDown"
        SW2App_AutoRunDelaySeconds_NumericUpDown.Size = New Size(80, 23)
        SW2App_AutoRunDelaySeconds_NumericUpDown.TabIndex = 3
        SW2App_AutoRunDelaySeconds_NumericUpDown.TextAlign = HorizontalAlignment.Center
        SW2App_AutoRunDelaySeconds_NumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(146, 31)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(19, 15)
        Label12.TabIndex = 28
        Label12.Text = "秒"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(16, 100)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 15)
        Label7.TabIndex = 7
        Label7.Text = "次數："
        ' 
        ' SW2App_ScheduledRun_RadioButton
        ' 
        SW2App_ScheduledRun_RadioButton.AutoSize = True
        SW2App_ScheduledRun_RadioButton.Cursor = Cursors.Hand
        SW2App_ScheduledRun_RadioButton.Location = New Point(116, 62)
        SW2App_ScheduledRun_RadioButton.Margin = New Padding(2)
        SW2App_ScheduledRun_RadioButton.Name = "SW2App_ScheduledRun_RadioButton"
        SW2App_ScheduledRun_RadioButton.Size = New Size(49, 19)
        SW2App_ScheduledRun_RadioButton.TabIndex = 5
        SW2App_ScheduledRun_RadioButton.TabStop = True
        SW2App_ScheduledRun_RadioButton.Text = "定時"
        SW2App_ScheduledRun_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' SW2App_SequentialRun_RadioButton
        ' 
        SW2App_SequentialRun_RadioButton.AutoSize = True
        SW2App_SequentialRun_RadioButton.Cursor = Cursors.Hand
        SW2App_SequentialRun_RadioButton.Location = New Point(63, 62)
        SW2App_SequentialRun_RadioButton.Margin = New Padding(2)
        SW2App_SequentialRun_RadioButton.Name = "SW2App_SequentialRun_RadioButton"
        SW2App_SequentialRun_RadioButton.Size = New Size(49, 19)
        SW2App_SequentialRun_RadioButton.TabIndex = 4
        SW2App_SequentialRun_RadioButton.TabStop = True
        SW2App_SequentialRun_RadioButton.Text = "順序"
        SW2App_SequentialRun_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 64)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 6
        Label4.Text = "模式："
        ' 
        ' SaveSW2AppConfigs_Button
        ' 
        SaveSW2AppConfigs_Button.Cursor = Cursors.Hand
        SaveSW2AppConfigs_Button.Location = New Point(170, 97)
        SaveSW2AppConfigs_Button.Margin = New Padding(2)
        SaveSW2AppConfigs_Button.Name = "SaveSW2AppConfigs_Button"
        SaveSW2AppConfigs_Button.Size = New Size(49, 23)
        SaveSW2AppConfigs_Button.TabIndex = 13
        SaveSW2AppConfigs_Button.Text = "儲存"
        SaveSW2AppConfigs_Button.UseVisualStyleBackColor = True
        ' 
        ' SW2App_AutoRun_CheckBox
        ' 
        SW2App_AutoRun_CheckBox.AutoSize = True
        SW2App_AutoRun_CheckBox.Cursor = Cursors.Hand
        SW2App_AutoRun_CheckBox.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        SW2App_AutoRun_CheckBox.Location = New Point(25, 370)
        SW2App_AutoRun_CheckBox.Margin = New Padding(2)
        SW2App_AutoRun_CheckBox.Name = "SW2App_AutoRun_CheckBox"
        SW2App_AutoRun_CheckBox.Size = New Size(83, 22)
        SW2App_AutoRun_CheckBox.TabIndex = 0
        SW2App_AutoRun_CheckBox.Text = "啟動執行"
        SW2App_AutoRun_CheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(146, 65)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(18, 15)
        Label10.TabIndex = 20
        Label10.Text = "%"
        ' 
        ' SWAPP_OpacityValue_NumericUpDown
        ' 
        SWAPP_OpacityValue_NumericUpDown.Location = New Point(62, 60)
        SWAPP_OpacityValue_NumericUpDown.Margin = New Padding(2)
        SWAPP_OpacityValue_NumericUpDown.Name = "SWAPP_OpacityValue_NumericUpDown"
        SWAPP_OpacityValue_NumericUpDown.Size = New Size(80, 23)
        SWAPP_OpacityValue_NumericUpDown.TabIndex = 19
        SWAPP_OpacityValue_NumericUpDown.TextAlign = HorizontalAlignment.Center
        SWAPP_OpacityValue_NumericUpDown.Value = New Decimal(New Integer() {100, 0, 0, 0})
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(16, 64)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 15)
        Label9.TabIndex = 18
        Label9.Text = "透明："
        ' 
        ' LiteModeScriptListView_RadioButton
        ' 
        LiteModeScriptListView_RadioButton.AutoSize = True
        LiteModeScriptListView_RadioButton.Cursor = Cursors.Hand
        LiteModeScriptListView_RadioButton.Location = New Point(171, 29)
        LiteModeScriptListView_RadioButton.Margin = New Padding(2)
        LiteModeScriptListView_RadioButton.Name = "LiteModeScriptListView_RadioButton"
        LiteModeScriptListView_RadioButton.Size = New Size(49, 19)
        LiteModeScriptListView_RadioButton.TabIndex = 17
        LiteModeScriptListView_RadioButton.TabStop = True
        LiteModeScriptListView_RadioButton.Text = "表格"
        LiteModeScriptListView_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LiteModeWebview_RadioButton
        ' 
        LiteModeWebview_RadioButton.AutoSize = True
        LiteModeWebview_RadioButton.Cursor = Cursors.Hand
        LiteModeWebview_RadioButton.Location = New Point(116, 29)
        LiteModeWebview_RadioButton.Margin = New Padding(2)
        LiteModeWebview_RadioButton.Name = "LiteModeWebview_RadioButton"
        LiteModeWebview_RadioButton.Size = New Size(49, 19)
        LiteModeWebview_RadioButton.TabIndex = 16
        LiteModeWebview_RadioButton.TabStop = True
        LiteModeWebview_RadioButton.Text = "網頁"
        LiteModeWebview_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LiteModeNormal_RadioButton
        ' 
        LiteModeNormal_RadioButton.AutoSize = True
        LiteModeNormal_RadioButton.Cursor = Cursors.Hand
        LiteModeNormal_RadioButton.Location = New Point(63, 29)
        LiteModeNormal_RadioButton.Margin = New Padding(2)
        LiteModeNormal_RadioButton.Name = "LiteModeNormal_RadioButton"
        LiteModeNormal_RadioButton.Size = New Size(49, 19)
        LiteModeNormal_RadioButton.TabIndex = 15
        LiteModeNormal_RadioButton.TabStop = True
        LiteModeNormal_RadioButton.Text = "一般"
        LiteModeNormal_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LaunchDelaySeconds_NumericUpDown
        ' 
        LaunchDelaySeconds_NumericUpDown.Location = New Point(312, 369)
        LaunchDelaySeconds_NumericUpDown.Margin = New Padding(2)
        LaunchDelaySeconds_NumericUpDown.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        LaunchDelaySeconds_NumericUpDown.Name = "LaunchDelaySeconds_NumericUpDown"
        LaunchDelaySeconds_NumericUpDown.Size = New Size(39, 23)
        LaunchDelaySeconds_NumericUpDown.TabIndex = 14
        LaunchDelaySeconds_NumericUpDown.TextAlign = HorizontalAlignment.Center
        LaunchDelaySeconds_NumericUpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(247, 373)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 15
        Label5.Text = "啟動延遲："
        ' 
        ' AppUpdating_ProgressBar
        ' 
        AppUpdating_ProgressBar.Location = New Point(115, 124)
        AppUpdating_ProgressBar.Margin = New Padding(2)
        AppUpdating_ProgressBar.Name = "AppUpdating_ProgressBar"
        AppUpdating_ProgressBar.Size = New Size(95, 23)
        AppUpdating_ProgressBar.TabIndex = 16
        AppUpdating_ProgressBar.Visible = False
        ' 
        ' AppUpdatingProgressInfo_Label
        ' 
        AppUpdatingProgressInfo_Label.AutoSize = True
        AppUpdatingProgressInfo_Label.Location = New Point(115, 107)
        AppUpdatingProgressInfo_Label.Margin = New Padding(2, 0, 2, 0)
        AppUpdatingProgressInfo_Label.Name = "AppUpdatingProgressInfo_Label"
        AppUpdatingProgressInfo_Label.Size = New Size(58, 15)
        AppUpdatingProgressInfo_Label.TabIndex = 18
        AppUpdatingProgressInfo_Label.Text = "更新進度 "
        AppUpdatingProgressInfo_Label.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(470, 20)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 19
        Label6.Text = "程式更新："
        ' 
        ' UpdatingProgressPercent_Label
        ' 
        UpdatingProgressPercent_Label.AutoSize = True
        UpdatingProgressPercent_Label.Location = New Point(726, 20)
        UpdatingProgressPercent_Label.Margin = New Padding(2, 0, 2, 0)
        UpdatingProgressPercent_Label.Name = "UpdatingProgressPercent_Label"
        UpdatingProgressPercent_Label.Size = New Size(25, 15)
        UpdatingProgressPercent_Label.TabIndex = 20
        UpdatingProgressPercent_Label.Text = "0%"
        ' 
        ' SelectAllSW2AppListViewItems_Button
        ' 
        SelectAllSW2AppListViewItems_Button.Cursor = Cursors.Hand
        SelectAllSW2AppListViewItems_Button.Location = New Point(505, 337)
        SelectAllSW2AppListViewItems_Button.Margin = New Padding(2)
        SelectAllSW2AppListViewItems_Button.Name = "SelectAllSW2AppListViewItems_Button"
        SelectAllSW2AppListViewItems_Button.Size = New Size(126, 23)
        SelectAllSW2AppListViewItems_Button.TabIndex = 21
        SelectAllSW2AppListViewItems_Button.Text = "全部選擇"
        SelectAllSW2AppListViewItems_Button.UseVisualStyleBackColor = True
        ' 
        ' DeselectAllSW2AppListViewItems_Button
        ' 
        DeselectAllSW2AppListViewItems_Button.Cursor = Cursors.Hand
        DeselectAllSW2AppListViewItems_Button.Location = New Point(635, 338)
        DeselectAllSW2AppListViewItems_Button.Margin = New Padding(2)
        DeselectAllSW2AppListViewItems_Button.Name = "DeselectAllSW2AppListViewItems_Button"
        DeselectAllSW2AppListViewItems_Button.Size = New Size(126, 23)
        DeselectAllSW2AppListViewItems_Button.TabIndex = 22
        DeselectAllSW2AppListViewItems_Button.Text = "全部不選"
        DeselectAllSW2AppListViewItems_Button.UseVisualStyleBackColor = True
        ' 
        ' SW2APPSearchText_ComboBox
        ' 
        SW2APPSearchText_ComboBox.FormattingEnabled = True
        SW2APPSearchText_ComboBox.Items.AddRange(New Object() {"是", "否", "定時", "順序"})
        SW2APPSearchText_ComboBox.Location = New Point(35, 178)
        SW2APPSearchText_ComboBox.Margin = New Padding(2)
        SW2APPSearchText_ComboBox.Name = "SW2APPSearchText_ComboBox"
        SW2APPSearchText_ComboBox.Size = New Size(73, 23)
        SW2APPSearchText_ComboBox.TabIndex = 23
        SW2APPSearchText_ComboBox.Visible = False
        ' 
        ' MarkSW2ListViewItemsByText_Button
        ' 
        MarkSW2ListViewItemsByText_Button.Location = New Point(35, 237)
        MarkSW2ListViewItemsByText_Button.Margin = New Padding(2)
        MarkSW2ListViewItemsByText_Button.Name = "MarkSW2ListViewItemsByText_Button"
        MarkSW2ListViewItemsByText_Button.Size = New Size(73, 23)
        MarkSW2ListViewItemsByText_Button.TabIndex = 24
        MarkSW2ListViewItemsByText_Button.Text = "標註"
        MarkSW2ListViewItemsByText_Button.UseVisualStyleBackColor = True
        MarkSW2ListViewItemsByText_Button.Visible = False
        ' 
        ' SelectedItemsByText_Button
        ' 
        SelectedItemsByText_Button.Location = New Point(35, 208)
        SelectedItemsByText_Button.Margin = New Padding(2)
        SelectedItemsByText_Button.Name = "SelectedItemsByText_Button"
        SelectedItemsByText_Button.Size = New Size(73, 23)
        SelectedItemsByText_Button.TabIndex = 25
        SelectedItemsByText_Button.Text = "選取"
        SelectedItemsByText_Button.UseVisualStyleBackColor = True
        SelectedItemsByText_Button.Visible = False
        ' 
        ' UnmarkSW2ListViewItemsByText_Button
        ' 
        UnmarkSW2ListViewItemsByText_Button.Location = New Point(35, 264)
        UnmarkSW2ListViewItemsByText_Button.Margin = New Padding(2)
        UnmarkSW2ListViewItemsByText_Button.Name = "UnmarkSW2ListViewItemsByText_Button"
        UnmarkSW2ListViewItemsByText_Button.Size = New Size(73, 23)
        UnmarkSW2ListViewItemsByText_Button.TabIndex = 26
        UnmarkSW2ListViewItemsByText_Button.Text = "取消標註"
        UnmarkSW2ListViewItemsByText_Button.UseVisualStyleBackColor = True
        UnmarkSW2ListViewItemsByText_Button.Visible = False
        ' 
        ' SetSWAppForeground_Button
        ' 
        SetSWAppForeground_Button.Cursor = Cursors.Hand
        SetSWAppForeground_Button.Location = New Point(635, 369)
        SetSWAppForeground_Button.Margin = New Padding(2)
        SetSWAppForeground_Button.Name = "SetSWAppForeground_Button"
        SetSWAppForeground_Button.Size = New Size(126, 23)
        SetSWAppForeground_Button.TabIndex = 28
        SetSWAppForeground_Button.Text = "尋找視窗"
        SetSWAppForeground_Button.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(ApplySWAppLocation_Button)
        GroupBox1.Controls.Add(SWAppLocationY_NumericUpDown)
        GroupBox1.Controls.Add(SWAppLocationX_NumericUpDown)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(ApplySWAppWindowConfigs_Button)
        GroupBox1.Controls.Add(LiteModeNormal_RadioButton)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(LiteModeWebview_RadioButton)
        GroupBox1.Controls.Add(LiteModeScriptListView_RadioButton)
        GroupBox1.Controls.Add(SWAPP_OpacityValue_NumericUpDown)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Location = New Point(529, 191)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(232, 136)
        GroupBox1.TabIndex = 31
        GroupBox1.TabStop = False
        GroupBox1.Text = "視窗設置"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(15, 31)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(43, 15)
        Label15.TabIndex = 37
        Label15.Text = "模式："
        ' 
        ' ApplySWAppLocation_Button
        ' 
        ApplySWAppLocation_Button.Cursor = Cursors.Hand
        ApplySWAppLocation_Button.Location = New Point(170, 96)
        ApplySWAppLocation_Button.Margin = New Padding(2)
        ApplySWAppLocation_Button.Name = "ApplySWAppLocation_Button"
        ApplySWAppLocation_Button.Size = New Size(49, 23)
        ApplySWAppLocation_Button.TabIndex = 30
        ApplySWAppLocation_Button.Text = "確定"
        ApplySWAppLocation_Button.UseVisualStyleBackColor = True
        ' 
        ' SWAppLocationY_NumericUpDown
        ' 
        SWAppLocationY_NumericUpDown.Location = New Point(115, 96)
        SWAppLocationY_NumericUpDown.Margin = New Padding(2)
        SWAppLocationY_NumericUpDown.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        SWAppLocationY_NumericUpDown.Name = "SWAppLocationY_NumericUpDown"
        SWAppLocationY_NumericUpDown.Size = New Size(49, 23)
        SWAppLocationY_NumericUpDown.TabIndex = 27
        SWAppLocationY_NumericUpDown.TextAlign = HorizontalAlignment.Center
        ' 
        ' SWAppLocationX_NumericUpDown
        ' 
        SWAppLocationX_NumericUpDown.Location = New Point(62, 96)
        SWAppLocationX_NumericUpDown.Margin = New Padding(2)
        SWAppLocationX_NumericUpDown.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        SWAppLocationX_NumericUpDown.Name = "SWAppLocationX_NumericUpDown"
        SWAppLocationX_NumericUpDown.Size = New Size(49, 23)
        SWAppLocationX_NumericUpDown.TabIndex = 26
        SWAppLocationX_NumericUpDown.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(16, 100)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 15)
        Label11.TabIndex = 25
        Label11.Text = "座標："
        ' 
        ' ApplySWAppWindowConfigs_Button
        ' 
        ApplySWAppWindowConfigs_Button.Cursor = Cursors.Hand
        ApplySWAppWindowConfigs_Button.Location = New Point(170, 61)
        ApplySWAppWindowConfigs_Button.Margin = New Padding(2)
        ApplySWAppWindowConfigs_Button.Name = "ApplySWAppWindowConfigs_Button"
        ApplySWAppWindowConfigs_Button.Size = New Size(49, 23)
        ApplySWAppWindowConfigs_Button.TabIndex = 21
        ApplySWAppWindowConfigs_Button.Text = "確定"
        ApplySWAppWindowConfigs_Button.UseVisualStyleBackColor = True
        ' 
        ' ColseAppByPipeLine_Button
        ' 
        ColseAppByPipeLine_Button.Location = New Point(115, 82)
        ColseAppByPipeLine_Button.Margin = New Padding(2)
        ColseAppByPipeLine_Button.Name = "ColseAppByPipeLine_Button"
        ColseAppByPipeLine_Button.Size = New Size(95, 23)
        ColseAppByPipeLine_Button.TabIndex = 32
        ColseAppByPipeLine_Button.Text = "關閉所選(測試)"
        ColseAppByPipeLine_Button.UseVisualStyleBackColor = True
        ColseAppByPipeLine_Button.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 20)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 15)
        Label8.TabIndex = 33
        Label8.Text = "來源路徑："
        ' 
        ' AppSourcePath_TextBox
        ' 
        AppSourcePath_TextBox.Location = New Point(93, 16)
        AppSourcePath_TextBox.Margin = New Padding(2)
        AppSourcePath_TextBox.Name = "AppSourcePath_TextBox"
        AppSourcePath_TextBox.Size = New Size(185, 23)
        AppSourcePath_TextBox.TabIndex = 34
        ' 
        ' ApplySourceAppPath_Button
        ' 
        ApplySourceAppPath_Button.Cursor = Cursors.Hand
        ApplySourceAppPath_Button.Location = New Point(282, 16)
        ApplySourceAppPath_Button.Margin = New Padding(2)
        ApplySourceAppPath_Button.Name = "ApplySourceAppPath_Button"
        ApplySourceAppPath_Button.Size = New Size(90, 23)
        ApplySourceAppPath_Button.TabIndex = 35
        ApplySourceAppPath_Button.Text = "套用"
        ApplySourceAppPath_Button.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(354, 373)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(19, 15)
        Label14.TabIndex = 36
        Label14.Text = "秒"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 411)
        Controls.Add(UpdateAllSWApp_Button)
        Controls.Add(AppSourcePath_TextBox)
        Controls.Add(NewSW2FolderName_TextBox)
        Controls.Add(LaunchDelaySeconds_NumericUpDown)
        Controls.Add(Label14)
        Controls.Add(ApplySourceAppPath_Button)
        Controls.Add(Label8)
        Controls.Add(SW2App_AutoRun_CheckBox)
        Controls.Add(ColseAppByPipeLine_Button)
        Controls.Add(GroupBox1)
        Controls.Add(SetSWAppForeground_Button)
        Controls.Add(UnmarkSW2ListViewItemsByText_Button)
        Controls.Add(SelectedItemsByText_Button)
        Controls.Add(MarkSW2ListViewItemsByText_Button)
        Controls.Add(SW2APPSearchText_ComboBox)
        Controls.Add(DeselectAllSW2AppListViewItems_Button)
        Controls.Add(SelectAllSW2AppListViewItems_Button)
        Controls.Add(UpdatingProgressPercent_Label)
        Controls.Add(Label6)
        Controls.Add(AppUpdatingProgressInfo_Label)
        Controls.Add(AppUpdating_ProgressBar)
        Controls.Add(AppConfigs_GroupBox)
        Controls.Add(RevealAppSourceFolder_Button)
        Controls.Add(TerminateAllSW2App_Button)
        Controls.Add(SourceSW2AppVersion_TextBox)
        Controls.Add(UpdateSelectedSW2App_Button)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(UpdateSW2AppListView_Button)
        Controls.Add(TerminateSW2AppByPId_Button)
        Controls.Add(LaunchSeletedSW2App_Button)
        Controls.Add(DeleteSelectedSW2AppFolder_Button)
        Controls.Add(CreateNewSW2App_Button)
        Controls.Add(SW2App_ListView)
        Controls.Add(Label5)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.Manual
        Text = "Fb多開程式"
        AppConfigs_GroupBox.ResumeLayout(False)
        AppConfigs_GroupBox.PerformLayout()
        CType(SW2App_NumberOfRuns_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(SW2App_AutoRunDelaySeconds_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(SWAPP_OpacityValue_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(LaunchDelaySeconds_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(SWAppLocationY_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(SWAppLocationX_NumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CreateNewSW2App_Button As Button
    Friend WithEvents DeleteSelectedSW2AppFolder_Button As Button
    Friend WithEvents LaunchSeletedSW2App_Button As Button
    Friend WithEvents TerminateSW2AppByPId_Button As Button
    Friend WithEvents UpdateSW2AppListView_Button As Button
    Friend WithEvents SW2App_ListView As ListView
    Friend WithEvents SW2App_PId_ColumnHeader As ColumnHeader
    Friend WithEvents SW2App_FolderName_ColumnHeader As ColumnHeader
    Friend WithEvents SW2App_Version_ColumnHeader As ColumnHeader
    Friend WithEvents SW2App_Status_ColumnHeader As ColumnHeader
    Friend WithEvents SW2APP_AutoRun_ColumnHeader As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents NewSW2FolderName_TextBox As TextBox
    Friend WithEvents SourceSW2AppVersion_TextBox As TextBox
    Friend WithEvents UpdateSelectedSW2App_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RevealAppSourceFolder_Button As Button
    Friend WithEvents TerminateAllSW2App_Button As Button
    Friend WithEvents UpdateAllSWApp_Button As Button
    Friend WithEvents AppConfigs_GroupBox As GroupBox
    Friend WithEvents SaveSW2AppConfigs_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents SW2App_AutoRun_CheckBox As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SW2App_ScheduledRun_RadioButton As RadioButton
    Friend WithEvents SW2App_SequentialRun_RadioButton As RadioButton
    Friend WithEvents SW2App_AutoRunDelaySeconds_NumericUpDown As NumericUpDown
    Friend WithEvents LaunchDelaySeconds_NumericUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents AppUpdating_ProgressBar As ProgressBar
    Friend WithEvents AppUpdatingProgressInfo_Label As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UpdatingProgressPercent_Label As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SW2App_NumberOfRuns_NumericUpDown As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents SW2APP_AutoRunDelaySeconds_ColumnHeader As ColumnHeader
    Friend WithEvents SW2APP_RunMode_ColumnHeader As ColumnHeader
    Friend WithEvents SW2APP_NumberOfRuns_ColumnHeader As ColumnHeader
    Friend WithEvents SelectAllSW2AppListViewItems_Button As Button
    Friend WithEvents DeselectAllSW2AppListViewItems_Button As Button
    Friend WithEvents SW2APPSearchText_ComboBox As ComboBox
    Friend WithEvents MarkSW2ListViewItemsByText_Button As Button
    Friend WithEvents SelectedItemsByText_Button As Button
    Friend WithEvents UnmarkSW2ListViewItemsByText_Button As Button
    Friend WithEvents LiteModeScriptListView_RadioButton As RadioButton
    Friend WithEvents LiteModeWebview_RadioButton As RadioButton
    Friend WithEvents LiteModeNormal_RadioButton As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents SWAPP_OpacityValue_NumericUpDown As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents SetSWAppForeground_Button As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ApplySWAppWindowConfigs_Button As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SWAppLocationY_NumericUpDown As NumericUpDown
    Friend WithEvents SWAppLocationX_NumericUpDown As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents ApplySWAppLocation_Button As Button
    Friend WithEvents ColseAppByPipeLine_Button As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents AppSourcePath_TextBox As TextBox
    Friend WithEvents ApplySourceAppPath_Button As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label

End Class
