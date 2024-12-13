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
        SW2App_NumberOfRuns_NumericUpDown = New NumericUpDown()
        SW2App_AutoRunDelaySeconds_NumericUpDown = New NumericUpDown()
        SW2App_AutoRun_CheckBox = New CheckBox()
        Label7 = New Label()
        SW2App_ScheduledRun_RadioButton = New RadioButton()
        SW2App_SequentialRun_RadioButton = New RadioButton()
        Label4 = New Label()
        SaveSW2AppConfigs_Button = New Button()
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
        uuid_TextBox1 = New TextBox()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        ApplySWAppLocation_Button = New Button()
        Label13 = New Label()
        Label12 = New Label()
        SWAppLocationY_NumericUpDown = New NumericUpDown()
        SWAppLocationX_NumericUpDown = New NumericUpDown()
        Label11 = New Label()
        ApplySWAppWindowConfigs_Button = New Button()
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
        CreateNewSW2App_Button.Location = New Point(342, 118)
        CreateNewSW2App_Button.Name = "CreateNewSW2App_Button"
        CreateNewSW2App_Button.Size = New Size(94, 29)
        CreateNewSW2App_Button.TabIndex = 1
        CreateNewSW2App_Button.Text = "新增"
        CreateNewSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' DeleteSelectedSW2AppFolder_Button
        ' 
        DeleteSelectedSW2AppFolder_Button.Location = New Point(442, 118)
        DeleteSelectedSW2AppFolder_Button.Name = "DeleteSelectedSW2AppFolder_Button"
        DeleteSelectedSW2AppFolder_Button.Size = New Size(94, 29)
        DeleteSelectedSW2AppFolder_Button.TabIndex = 2
        DeleteSelectedSW2AppFolder_Button.Text = "刪除"
        DeleteSelectedSW2AppFolder_Button.UseVisualStyleBackColor = True
        ' 
        ' LaunchSeletedSW2App_Button
        ' 
        LaunchSeletedSW2App_Button.Location = New Point(184, 506)
        LaunchSeletedSW2App_Button.Name = "LaunchSeletedSW2App_Button"
        LaunchSeletedSW2App_Button.Size = New Size(94, 29)
        LaunchSeletedSW2App_Button.TabIndex = 3
        LaunchSeletedSW2App_Button.Text = "啟動"
        LaunchSeletedSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' TerminateSW2AppByPId_Button
        ' 
        TerminateSW2AppByPId_Button.Location = New Point(284, 506)
        TerminateSW2AppByPId_Button.Name = "TerminateSW2AppByPId_Button"
        TerminateSW2AppByPId_Button.Size = New Size(94, 29)
        TerminateSW2AppByPId_Button.TabIndex = 4
        TerminateSW2AppByPId_Button.Text = "關閉所選"
        TerminateSW2AppByPId_Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateSW2AppListView_Button
        ' 
        UpdateSW2AppListView_Button.Location = New Point(663, 506)
        UpdateSW2AppListView_Button.Name = "UpdateSW2AppListView_Button"
        UpdateSW2AppListView_Button.Size = New Size(94, 29)
        UpdateSW2AppListView_Button.TabIndex = 5
        UpdateSW2AppListView_Button.Text = "重新整理"
        UpdateSW2AppListView_Button.UseVisualStyleBackColor = True
        ' 
        ' SW2App_ListView
        ' 
        SW2App_ListView.BackColor = SystemColors.Window
        SW2App_ListView.Columns.AddRange(New ColumnHeader() {SW2App_PId_ColumnHeader, SW2App_FolderName_ColumnHeader, SW2App_Version_ColumnHeader, SW2App_Status_ColumnHeader, SW2APP_AutoRun_ColumnHeader, SW2APP_AutoRunDelaySeconds_ColumnHeader, SW2APP_RunMode_ColumnHeader, SW2APP_NumberOfRuns_ColumnHeader})
        SW2App_ListView.FullRowSelect = True
        SW2App_ListView.Location = New Point(12, 153)
        SW2App_ListView.Name = "SW2App_ListView"
        SW2App_ListView.Size = New Size(745, 347)
        SW2App_ListView.TabIndex = 6
        SW2App_ListView.UseCompatibleStateImageBehavior = False
        SW2App_ListView.View = View.Details
        ' 
        ' SW2App_PId_ColumnHeader
        ' 
        SW2App_PId_ColumnHeader.Text = "PID"
        SW2App_PId_ColumnHeader.Width = 80
        ' 
        ' SW2App_FolderName_ColumnHeader
        ' 
        SW2App_FolderName_ColumnHeader.Text = "資料夾名稱"
        SW2App_FolderName_ColumnHeader.Width = 150
        ' 
        ' SW2App_Version_ColumnHeader
        ' 
        SW2App_Version_ColumnHeader.Text = "版本"
        SW2App_Version_ColumnHeader.Width = 150
        ' 
        ' SW2App_Status_ColumnHeader
        ' 
        SW2App_Status_ColumnHeader.Text = "狀態"
        ' 
        ' SW2APP_AutoRun_ColumnHeader
        ' 
        SW2APP_AutoRun_ColumnHeader.Text = "啟動執行"
        SW2APP_AutoRun_ColumnHeader.Width = 75
        ' 
        ' SW2APP_AutoRunDelaySeconds_ColumnHeader
        ' 
        SW2APP_AutoRunDelaySeconds_ColumnHeader.Text = "延遲秒數"
        SW2APP_AutoRunDelaySeconds_ColumnHeader.Width = 75
        ' 
        ' SW2APP_RunMode_ColumnHeader
        ' 
        SW2APP_RunMode_ColumnHeader.Text = "執行模式"
        SW2APP_RunMode_ColumnHeader.Width = 75
        ' 
        ' SW2APP_NumberOfRuns_ColumnHeader
        ' 
        SW2APP_NumberOfRuns_ColumnHeader.Text = "執行次數"
        SW2APP_NumberOfRuns_ColumnHeader.Width = 75
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 19)
        Label1.TabIndex = 7
        Label1.Text = "資料夾名稱: "
        ' 
        ' NewSW2FolderName_TextBox
        ' 
        NewSW2FolderName_TextBox.Location = New Point(109, 117)
        NewSW2FolderName_TextBox.Name = "NewSW2FolderName_TextBox"
        NewSW2FolderName_TextBox.Size = New Size(227, 27)
        NewSW2FolderName_TextBox.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 19)
        Label2.TabIndex = 0
        Label2.Text = "來源版本 : "
        ' 
        ' UpdateSelectedSW2App_Button
        ' 
        UpdateSelectedSW2App_Button.Location = New Point(342, 52)
        UpdateSelectedSW2App_Button.Name = "UpdateSelectedSW2App_Button"
        UpdateSelectedSW2App_Button.Size = New Size(94, 29)
        UpdateSelectedSW2App_Button.TabIndex = 1
        UpdateSelectedSW2App_Button.Text = "更新所選"
        UpdateSelectedSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' SourceSW2AppVersion_TextBox
        ' 
        SourceSW2AppVersion_TextBox.Location = New Point(109, 17)
        SourceSW2AppVersion_TextBox.Name = "SourceSW2AppVersion_TextBox"
        SourceSW2AppVersion_TextBox.ReadOnly = True
        SourceSW2AppVersion_TextBox.Size = New Size(227, 27)
        SourceSW2AppVersion_TextBox.TabIndex = 2
        ' 
        ' RevealAppSourceFolder_Button
        ' 
        RevealAppSourceFolder_Button.Location = New Point(342, 17)
        RevealAppSourceFolder_Button.Name = "RevealAppSourceFolder_Button"
        RevealAppSourceFolder_Button.Size = New Size(194, 29)
        RevealAppSourceFolder_Button.TabIndex = 3
        RevealAppSourceFolder_Button.Text = "打開來源資料夾"
        RevealAppSourceFolder_Button.UseVisualStyleBackColor = True
        ' 
        ' TerminateAllSW2App_Button
        ' 
        TerminateAllSW2App_Button.Location = New Point(384, 506)
        TerminateAllSW2App_Button.Name = "TerminateAllSW2App_Button"
        TerminateAllSW2App_Button.Size = New Size(94, 29)
        TerminateAllSW2App_Button.TabIndex = 10
        TerminateAllSW2App_Button.Text = "全部關閉"
        TerminateAllSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateAllSWApp_Button
        ' 
        UpdateAllSWApp_Button.Location = New Point(442, 52)
        UpdateAllSWApp_Button.Name = "UpdateAllSWApp_Button"
        UpdateAllSWApp_Button.Size = New Size(94, 29)
        UpdateAllSWApp_Button.TabIndex = 11
        UpdateAllSWApp_Button.Text = "全部更新"
        UpdateAllSWApp_Button.UseVisualStyleBackColor = True
        ' 
        ' AppConfigs_GroupBox
        ' 
        AppConfigs_GroupBox.Controls.Add(Label3)
        AppConfigs_GroupBox.Controls.Add(SW2App_NumberOfRuns_NumericUpDown)
        AppConfigs_GroupBox.Controls.Add(SW2App_AutoRunDelaySeconds_NumericUpDown)
        AppConfigs_GroupBox.Controls.Add(SW2App_AutoRun_CheckBox)
        AppConfigs_GroupBox.Controls.Add(Label7)
        AppConfigs_GroupBox.Controls.Add(SW2App_ScheduledRun_RadioButton)
        AppConfigs_GroupBox.Controls.Add(SW2App_SequentialRun_RadioButton)
        AppConfigs_GroupBox.Controls.Add(Label4)
        AppConfigs_GroupBox.Controls.Add(SaveSW2AppConfigs_Button)
        AppConfigs_GroupBox.Location = New Point(763, 153)
        AppConfigs_GroupBox.Name = "AppConfigs_GroupBox"
        AppConfigs_GroupBox.Size = New Size(353, 167)
        AppConfigs_GroupBox.TabIndex = 12
        AppConfigs_GroupBox.TabStop = False
        AppConfigs_GroupBox.Text = "程式設置"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 19)
        Label3.TabIndex = 2
        Label3.Text = "延遲秒數 : "
        ' 
        ' SW2App_NumberOfRuns_NumericUpDown
        ' 
        SW2App_NumberOfRuns_NumericUpDown.Location = New Point(116, 118)
        SW2App_NumberOfRuns_NumericUpDown.Name = "SW2App_NumberOfRuns_NumericUpDown"
        SW2App_NumberOfRuns_NumericUpDown.Size = New Size(70, 27)
        SW2App_NumberOfRuns_NumericUpDown.TabIndex = 8
        ' 
        ' SW2App_AutoRunDelaySeconds_NumericUpDown
        ' 
        SW2App_AutoRunDelaySeconds_NumericUpDown.Location = New Point(116, 85)
        SW2App_AutoRunDelaySeconds_NumericUpDown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        SW2App_AutoRunDelaySeconds_NumericUpDown.Name = "SW2App_AutoRunDelaySeconds_NumericUpDown"
        SW2App_AutoRunDelaySeconds_NumericUpDown.Size = New Size(70, 27)
        SW2App_AutoRunDelaySeconds_NumericUpDown.TabIndex = 3
        SW2App_AutoRunDelaySeconds_NumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        ' 
        ' SW2App_AutoRun_CheckBox
        ' 
        SW2App_AutoRun_CheckBox.AutoSize = True
        SW2App_AutoRun_CheckBox.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        SW2App_AutoRun_CheckBox.Location = New Point(6, 26)
        SW2App_AutoRun_CheckBox.Name = "SW2App_AutoRun_CheckBox"
        SW2App_AutoRun_CheckBox.Size = New Size(214, 26)
        SW2App_AutoRun_CheckBox.TabIndex = 0
        SW2App_AutoRun_CheckBox.Text = "啟動時執行(勾了就生效)"
        SW2App_AutoRun_CheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 120)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 19)
        Label7.TabIndex = 7
        Label7.Text = "執行次數 : "
        ' 
        ' SW2App_ScheduledRun_RadioButton
        ' 
        SW2App_ScheduledRun_RadioButton.AutoSize = True
        SW2App_ScheduledRun_RadioButton.Location = New Point(211, 53)
        SW2App_ScheduledRun_RadioButton.Name = "SW2App_ScheduledRun_RadioButton"
        SW2App_ScheduledRun_RadioButton.Size = New Size(90, 23)
        SW2App_ScheduledRun_RadioButton.TabIndex = 5
        SW2App_ScheduledRun_RadioButton.TabStop = True
        SW2App_ScheduledRun_RadioButton.Text = "定時執行"
        SW2App_ScheduledRun_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' SW2App_SequentialRun_RadioButton
        ' 
        SW2App_SequentialRun_RadioButton.AutoSize = True
        SW2App_SequentialRun_RadioButton.Location = New Point(115, 53)
        SW2App_SequentialRun_RadioButton.Name = "SW2App_SequentialRun_RadioButton"
        SW2App_SequentialRun_RadioButton.Size = New Size(90, 23)
        SW2App_SequentialRun_RadioButton.TabIndex = 4
        SW2App_SequentialRun_RadioButton.TabStop = True
        SW2App_SequentialRun_RadioButton.Text = "順序執行"
        SW2App_SequentialRun_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 19)
        Label4.TabIndex = 6
        Label4.Text = "執行模式 : "
        ' 
        ' SaveSW2AppConfigs_Button
        ' 
        SaveSW2AppConfigs_Button.Location = New Point(211, 116)
        SaveSW2AppConfigs_Button.Name = "SaveSW2AppConfigs_Button"
        SaveSW2AppConfigs_Button.Size = New Size(90, 29)
        SaveSW2AppConfigs_Button.TabIndex = 13
        SaveSW2AppConfigs_Button.Text = "儲存"
        SaveSW2AppConfigs_Button.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(152, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(22, 19)
        Label10.TabIndex = 20
        Label10.Text = "%"
        ' 
        ' SWAPP_OpacityValue_NumericUpDown
        ' 
        SWAPP_OpacityValue_NumericUpDown.Location = New Point(92, 55)
        SWAPP_OpacityValue_NumericUpDown.Name = "SWAPP_OpacityValue_NumericUpDown"
        SWAPP_OpacityValue_NumericUpDown.Size = New Size(54, 27)
        SWAPP_OpacityValue_NumericUpDown.TabIndex = 19
        SWAPP_OpacityValue_NumericUpDown.Value = New Decimal(New Integer() {100, 0, 0, 0})
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 63)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 19)
        Label9.TabIndex = 18
        Label9.Text = "透明度 : "
        ' 
        ' LiteModeScriptListView_RadioButton
        ' 
        LiteModeScriptListView_RadioButton.AutoSize = True
        LiteModeScriptListView_RadioButton.Location = New Point(198, 26)
        LiteModeScriptListView_RadioButton.Name = "LiteModeScriptListView_RadioButton"
        LiteModeScriptListView_RadioButton.Size = New Size(90, 23)
        LiteModeScriptListView_RadioButton.TabIndex = 17
        LiteModeScriptListView_RadioButton.TabStop = True
        LiteModeScriptListView_RadioButton.Text = "腳本模式"
        LiteModeScriptListView_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LiteModeWebview_RadioButton
        ' 
        LiteModeWebview_RadioButton.AutoSize = True
        LiteModeWebview_RadioButton.Location = New Point(102, 26)
        LiteModeWebview_RadioButton.Name = "LiteModeWebview_RadioButton"
        LiteModeWebview_RadioButton.Size = New Size(90, 23)
        LiteModeWebview_RadioButton.TabIndex = 16
        LiteModeWebview_RadioButton.TabStop = True
        LiteModeWebview_RadioButton.Text = "網頁模式"
        LiteModeWebview_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LiteModeNormal_RadioButton
        ' 
        LiteModeNormal_RadioButton.AutoSize = True
        LiteModeNormal_RadioButton.Location = New Point(6, 26)
        LiteModeNormal_RadioButton.Name = "LiteModeNormal_RadioButton"
        LiteModeNormal_RadioButton.Size = New Size(90, 23)
        LiteModeNormal_RadioButton.TabIndex = 15
        LiteModeNormal_RadioButton.TabStop = True
        LiteModeNormal_RadioButton.Text = "一般模式"
        LiteModeNormal_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' LaunchDelaySeconds_NumericUpDown
        ' 
        LaunchDelaySeconds_NumericUpDown.Location = New Point(128, 506)
        LaunchDelaySeconds_NumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        LaunchDelaySeconds_NumericUpDown.Name = "LaunchDelaySeconds_NumericUpDown"
        LaunchDelaySeconds_NumericUpDown.Size = New Size(50, 27)
        LaunchDelaySeconds_NumericUpDown.TabIndex = 14
        LaunchDelaySeconds_NumericUpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 511)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 19)
        Label5.TabIndex = 15
        Label5.Text = "啟動延遲秒數 : "
        ' 
        ' AppUpdating_ProgressBar
        ' 
        AppUpdating_ProgressBar.Location = New Point(109, 50)
        AppUpdating_ProgressBar.Name = "AppUpdating_ProgressBar"
        AppUpdating_ProgressBar.Size = New Size(227, 29)
        AppUpdating_ProgressBar.TabIndex = 16
        ' 
        ' AppUpdatingProgressInfo_Label
        ' 
        AppUpdatingProgressInfo_Label.AutoSize = True
        AppUpdatingProgressInfo_Label.Location = New Point(109, 82)
        AppUpdatingProgressInfo_Label.Name = "AppUpdatingProgressInfo_Label"
        AppUpdatingProgressInfo_Label.Size = New Size(73, 19)
        AppUpdatingProgressInfo_Label.TabIndex = 18
        AppUpdatingProgressInfo_Label.Text = "更新進度 "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 19)
        Label6.TabIndex = 19
        Label6.Text = "程式更新 : "
        ' 
        ' UpdatingProgressPercent_Label
        ' 
        UpdatingProgressPercent_Label.AutoSize = True
        UpdatingProgressPercent_Label.Location = New Point(305, 82)
        UpdatingProgressPercent_Label.Name = "UpdatingProgressPercent_Label"
        UpdatingProgressPercent_Label.Size = New Size(31, 19)
        UpdatingProgressPercent_Label.TabIndex = 20
        UpdatingProgressPercent_Label.Text = "0%"
        ' 
        ' SelectAllSW2AppListViewItems_Button
        ' 
        SelectAllSW2AppListViewItems_Button.Location = New Point(563, 118)
        SelectAllSW2AppListViewItems_Button.Name = "SelectAllSW2AppListViewItems_Button"
        SelectAllSW2AppListViewItems_Button.Size = New Size(94, 29)
        SelectAllSW2AppListViewItems_Button.TabIndex = 21
        SelectAllSW2AppListViewItems_Button.Text = "全選"
        SelectAllSW2AppListViewItems_Button.UseVisualStyleBackColor = True
        ' 
        ' DeselectAllSW2AppListViewItems_Button
        ' 
        DeselectAllSW2AppListViewItems_Button.Location = New Point(663, 118)
        DeselectAllSW2AppListViewItems_Button.Name = "DeselectAllSW2AppListViewItems_Button"
        DeselectAllSW2AppListViewItems_Button.Size = New Size(94, 29)
        DeselectAllSW2AppListViewItems_Button.TabIndex = 22
        DeselectAllSW2AppListViewItems_Button.Text = "全不選"
        DeselectAllSW2AppListViewItems_Button.UseVisualStyleBackColor = True
        ' 
        ' SW2APPSearchText_ComboBox
        ' 
        SW2APPSearchText_ComboBox.FormattingEnabled = True
        SW2APPSearchText_ComboBox.Items.AddRange(New Object() {"是", "否", "定時", "順序"})
        SW2APPSearchText_ComboBox.Location = New Point(12, 541)
        SW2APPSearchText_ComboBox.Name = "SW2APPSearchText_ComboBox"
        SW2APPSearchText_ComboBox.Size = New Size(166, 27)
        SW2APPSearchText_ComboBox.TabIndex = 23
        ' 
        ' MarkSW2ListViewItemsByText_Button
        ' 
        MarkSW2ListViewItemsByText_Button.Location = New Point(284, 541)
        MarkSW2ListViewItemsByText_Button.Name = "MarkSW2ListViewItemsByText_Button"
        MarkSW2ListViewItemsByText_Button.Size = New Size(94, 29)
        MarkSW2ListViewItemsByText_Button.TabIndex = 24
        MarkSW2ListViewItemsByText_Button.Text = "標註"
        MarkSW2ListViewItemsByText_Button.UseVisualStyleBackColor = True
        ' 
        ' SelectedItemsByText_Button
        ' 
        SelectedItemsByText_Button.Location = New Point(184, 541)
        SelectedItemsByText_Button.Name = "SelectedItemsByText_Button"
        SelectedItemsByText_Button.Size = New Size(94, 29)
        SelectedItemsByText_Button.TabIndex = 25
        SelectedItemsByText_Button.Text = "選取"
        SelectedItemsByText_Button.UseVisualStyleBackColor = True
        ' 
        ' UnmarkSW2ListViewItemsByText_Button
        ' 
        UnmarkSW2ListViewItemsByText_Button.Location = New Point(384, 541)
        UnmarkSW2ListViewItemsByText_Button.Name = "UnmarkSW2ListViewItemsByText_Button"
        UnmarkSW2ListViewItemsByText_Button.Size = New Size(94, 29)
        UnmarkSW2ListViewItemsByText_Button.TabIndex = 26
        UnmarkSW2ListViewItemsByText_Button.Text = "取消標註"
        UnmarkSW2ListViewItemsByText_Button.UseVisualStyleBackColor = True
        ' 
        ' SetSWAppForeground_Button
        ' 
        SetSWAppForeground_Button.Location = New Point(563, 506)
        SetSWAppForeground_Button.Name = "SetSWAppForeground_Button"
        SetSWAppForeground_Button.Size = New Size(94, 29)
        SetSWAppForeground_Button.TabIndex = 28
        SetSWAppForeground_Button.Text = "至頂視窗"
        SetSWAppForeground_Button.UseVisualStyleBackColor = True
        ' 
        ' uuid_TextBox1
        ' 
        uuid_TextBox1.Location = New Point(597, 17)
        uuid_TextBox1.Name = "uuid_TextBox1"
        uuid_TextBox1.Size = New Size(386, 27)
        uuid_TextBox1.TabIndex = 29
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(989, 17)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 30
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ApplySWAppLocation_Button)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
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
        GroupBox1.Location = New Point(763, 326)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(353, 242)
        GroupBox1.TabIndex = 31
        GroupBox1.TabStop = False
        GroupBox1.Text = "視窗設置"
        ' 
        ' ApplySWAppLocation_Button
        ' 
        ApplySWAppLocation_Button.Location = New Point(245, 119)
        ApplySWAppLocation_Button.Name = "ApplySWAppLocation_Button"
        ApplySWAppLocation_Button.Size = New Size(94, 29)
        ApplySWAppLocation_Button.TabIndex = 30
        ApplySWAppLocation_Button.Text = "套用座標"
        ApplySWAppLocation_Button.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(154, 127)
        Label13.Name = "Label13"
        Label13.Size = New Size(29, 19)
        Label13.TabIndex = 29
        Label13.Text = "Y : "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(62, 127)
        Label12.Name = "Label12"
        Label12.Size = New Size(30, 19)
        Label12.TabIndex = 28
        Label12.Text = "X : "
        ' 
        ' SWAppLocationY_NumericUpDown
        ' 
        SWAppLocationY_NumericUpDown.Location = New Point(189, 121)
        SWAppLocationY_NumericUpDown.Name = "SWAppLocationY_NumericUpDown"
        SWAppLocationY_NumericUpDown.Size = New Size(50, 27)
        SWAppLocationY_NumericUpDown.TabIndex = 27
        ' 
        ' SWAppLocationX_NumericUpDown
        ' 
        SWAppLocationX_NumericUpDown.Location = New Point(98, 121)
        SWAppLocationX_NumericUpDown.Name = "SWAppLocationX_NumericUpDown"
        SWAppLocationX_NumericUpDown.Size = New Size(50, 27)
        SWAppLocationX_NumericUpDown.TabIndex = 26
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 127)
        Label11.Name = "Label11"
        Label11.Size = New Size(50, 19)
        Label11.TabIndex = 25
        Label11.Text = "座標 : "
        ' 
        ' ApplySWAppWindowConfigs_Button
        ' 
        ApplySWAppWindowConfigs_Button.Location = New Point(245, 55)
        ApplySWAppWindowConfigs_Button.Name = "ApplySWAppWindowConfigs_Button"
        ApplySWAppWindowConfigs_Button.Size = New Size(94, 29)
        ApplySWAppWindowConfigs_Button.TabIndex = 21
        ApplySWAppWindowConfigs_Button.Text = "套用"
        ApplySWAppWindowConfigs_Button.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1129, 585)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(uuid_TextBox1)
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
        Controls.Add(Label5)
        Controls.Add(LaunchDelaySeconds_NumericUpDown)
        Controls.Add(AppConfigs_GroupBox)
        Controls.Add(UpdateAllSWApp_Button)
        Controls.Add(RevealAppSourceFolder_Button)
        Controls.Add(TerminateAllSW2App_Button)
        Controls.Add(SourceSW2AppVersion_TextBox)
        Controls.Add(UpdateSelectedSW2App_Button)
        Controls.Add(NewSW2FolderName_TextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SW2App_ListView)
        Controls.Add(UpdateSW2AppListView_Button)
        Controls.Add(TerminateSW2AppByPId_Button)
        Controls.Add(LaunchSeletedSW2App_Button)
        Controls.Add(DeleteSelectedSW2AppFolder_Button)
        Controls.Add(CreateNewSW2App_Button)
        Name = "Form1"
        StartPosition = FormStartPosition.Manual
        Text = "SW2App 主控"
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
    Friend WithEvents uuid_TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ApplySWAppWindowConfigs_Button As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SWAppLocationY_NumericUpDown As NumericUpDown
    Friend WithEvents SWAppLocationX_NumericUpDown As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents ApplySWAppLocation_Button As Button

End Class
