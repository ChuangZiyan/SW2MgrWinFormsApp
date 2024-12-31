Imports System.IO
Imports System.Runtime
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json
Imports SW2MgrWinFormsApp.MainFormController

Public Class Form1

    Public autoUpdateUI As Boolean = True
    Private cts As CancellationTokenSource ' 用來取消背景任務
    Private MgrMainFormEventController As New MgrMainFormEventController()

    Private Sub RegisterMgrMainFormEventhandlers()

        AddHandler RevealAppSourceFolder_Button.Click, AddressOf MgrMainFormEventController.RevealAppSourceFolder_Button_Click
        AddHandler UpdateSW2AppListView_Button.Click, AddressOf MgrMainFormEventController.UpdateSW2AppListView_Button_Click

        AddHandler LaunchSeletedSW2App_Button.Click, AddressOf MgrMainFormEventController.LaunchSeletedSW2App_Button_Click
        AddHandler TerminateSW2AppByPId_Button.Click, AddressOf MgrMainFormEventController.TerminateSW2AppByPId_Button_Click
        AddHandler SW2App_ListView.SelectedIndexChanged, AddressOf MgrMainFormEventController.SW2App_ListView_SelectedIndexChanged
        AddHandler SaveSW2AppConfigs_Button.Click, AddressOf MgrMainFormEventController.SaveSW2AppConfigs_Button_Click
        AddHandler TerminateAllSW2App_Button.Click, AddressOf MgrMainFormEventController.TerminateAllSW2App_Button_Click
        AddHandler SW2App_ListView.DoubleClick, AddressOf MgrMainFormEventController.SW2App_ListView_DoubleClick


        AddHandler SelectAllSW2AppListViewItems_Button.Click, AddressOf MgrMainFormEventController.SelectAllSW2AppListViewItems_Button_Click
        AddHandler DeselectAllSW2AppListViewItems_Button.Click, AddressOf MgrMainFormEventController.DeselectAllSW2AppListViewItems_Button_Click


        ' 新增SWAPP資料夾
        AddHandler CreateNewSW2App_Button.Click, AddressOf MgrMainFormEventController.CreateNewSW2App_Button_Click

        ' 刪除SWAPP資料夾
        AddHandler DeleteSelectedSW2AppFolder_Button.Click, AddressOf MgrMainFormEventController.DeleteSelectedSW2AppFolder_Button_Click

        '更新SWAPP功能
        AddHandler UpdateSelectedSW2App_Button.Click, AddressOf MgrMainFormEventController.UpdateSelectedSW2App_Button_Click
        AddHandler UpdateAllSWApp_Button.Click, AddressOf MgrMainFormEventController.UpdateAllSWApp_Button_Click


        ' 程式設置儲存功能
        AddHandler SW2App_AutoRun_CheckBox.Click, AddressOf MgrMainFormEventController.SW2App_AutoRun_CheckBox_Click
        'AddHandler SW2App_AutoRunDelaySeconds_NumericUpDown.Click, AddressOf MgrMainFormEventController.SW2App_AutoRunDelaySeconds_NumericUpDown_ValueChanged
        'AddHandler SW2App_SequentialRun_RadioButton.CheckedChanged, AddressOf MgrMainFormEventController.SW2App_SequentialRun_RadioButton_CheckedChanged
        'AddHandler SW2App_NumberOfRuns_NumericUpDown.ValueChanged, AddressOf MgrMainFormEventController.SW2App_NumberOfRuns_NumericUpDown_ValueChanged

        '下排選擇跟標記功能
        AddHandler SelectedItemsByText_Button.Click, AddressOf MgrMainFormEventController.SelectedItemsByText_Button_Click
        AddHandler MarkSW2ListViewItemsByText_Button.Click, AddressOf MgrMainFormEventController.MarkSW2ListViewItemsByText_Button_Click
        AddHandler UnmarkSW2ListViewItemsByText_Button.Click, AddressOf MgrMainFormEventController.UnmarkSW2ListViewItemsByText_Button_Click


        '管線命令
        AddHandler ApplySWAppWindowConfigs_Button.Click, AddressOf MgrMainFormEventController.ApplySWAppWindowConfigs_Button_Click
        AddHandler ApplySWAppLocation_Button.Click, AddressOf MgrMainFormEventController.ApplySWAppLocation_Button_Click

    End Sub


    Private Async Sub StartBackgroundUpdate()
        cts = New CancellationTokenSource()
        Dim token As CancellationToken = cts.Token
        Await Task.Run(Async Function()
                           While Not token.IsCancellationRequested

                               If autoUpdateUI Then
                                   UpdateData()
                                   Try
                                       ' 預設每3秒更新UI資訊
                                       Await Task.Delay(3000, token)
                                   Catch ex As TaskCanceledException
                                       Exit While
                                   End Try
                               Else
                                   Await Delay_msec(3000)
                               End If

                           End While
                       End Function, token)
    End Sub

    Private Sub UpdateData()
        Try
            Me.Invoke(Sub()
                          MainFormController.UpdateSW2AppListView()
                          AppInitModule.ReadSourceAppProfile()
                      End Sub)
        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初始化
        AppInitModule.InitializeMainApp()

        ' 事件註冊
        RegisterMgrMainFormEventhandlers()

        ' 啟用背景更新
        StartBackgroundUpdate()
    End Sub


    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If cts IsNot Nothing Then
            cts.Cancel()
            cts.Dispose()
        End If

    End Sub

    Private Sub SetSWAppForeground_Button_Click(sender As Object, e As EventArgs) Handles SetSWAppForeground_Button.Click

        Dim selectedSW2AppListViewItems = SW2App_ListView.SelectedItems
        If selectedSW2AppListViewItems.Count > 0 Then
            Dim profile As Webview2AppProfile = MainFormController.GetProfile(selectedSW2AppListViewItems.Item(0).SubItems(1).Text)
            ' Debug.WriteLine($"UUID : {profile.UUID}")
            UtilsModule.SendPipeCommandTask(profile.UUID, "setForegroundWindow")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' UtilsModule.SendPipeCommandTask(uuid_TextBox1.Text, "bringToTop")
        UtilsModule.SendPipeCommandTask(uuid_TextBox1.Text, "closeApp")
    End Sub

    Private Sub ColseAppByPipeLine_Button_Click(sender As Object, e As EventArgs) Handles ColseAppByPipeLine_Button.Click
        Dim selectedSW2AppListViewItems = SW2App_ListView.SelectedItems
        If selectedSW2AppListViewItems.Count > 0 Then
            Dim profile As Webview2AppProfile = MainFormController.GetProfile(selectedSW2AppListViewItems.Item(0).SubItems(1).Text)
            ' Debug.WriteLine($"UUID : {profile.UUID}")
            UtilsModule.SendPipeCommandTask(profile.UUID, "closeApp")

        End If
    End Sub
End Class
