Imports System.IO
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json
Imports SW2MgrWinFormsApp.MainFormController

Public Class Form1

    Private cts As CancellationTokenSource ' 用來取消背景任務
    Private MgrMainFormEventController As New MgrMainFormEventController()

    Private Sub RegisterMgrMainFormEventhandlers()

        AddHandler UpdateSelectedSW2App_Button.Click, AddressOf MgrMainFormEventController.UpdateSelectedSW2App_Button_Click
        AddHandler RevealAppSourceFolder_Button.Click, AddressOf MgrMainFormEventController.RevealAppSourceFolder_Button_Click
        AddHandler CreateNewSW2App_Button.Click, AddressOf MgrMainFormEventController.CreateNewSW2App_Button_Click
        AddHandler UpdateSW2AppListView_Button.Click, AddressOf MgrMainFormEventController.UpdateSW2AppListView_Button_Click
        AddHandler DeleteSelectedSW2AppFolder_Button.Click, AddressOf MgrMainFormEventController.DeleteSelectedSW2AppFolder_Button_Click
        AddHandler LaunchSeletedSW2App_Button.Click, AddressOf MgrMainFormEventController.LaunchSeletedSW2App_Button_Click
        AddHandler TerminateSW2AppByPId_Button.Click, AddressOf MgrMainFormEventController.TerminateSW2AppByPId_Button_Click
        AddHandler SW2App_ListView.SelectedIndexChanged, AddressOf MgrMainFormEventController.SW2App_ListView_SelectedIndexChanged
        AddHandler SaveSW2AppConfigs_Button.Click, AddressOf MgrMainFormEventController.SW2App_ListView_SelectedIndexChanged
        AddHandler TerminateAllSW2App_Button.Click, AddressOf MgrMainFormEventController.TerminateAllSW2App_Button_Click

    End Sub

    Private Async Sub StartBackgroundUpdate()
        cts = New CancellationTokenSource()
        Dim token As CancellationToken = cts.Token
        Await Task.Run(Async Function()
                           While Not token.IsCancellationRequested
                               UpdateData()
                               Try
                                   ' 預設每3秒更新UI資訊
                                   Await Task.Delay(3000, token)
                               Catch ex As TaskCanceledException
                                   Exit While
                               End Try
                           End While
                       End Function, token)
    End Sub

    Private Sub UpdateData()
        Me.Invoke(Sub()
                      'Debug.WriteLine("update data")
                      MainFormController.UpdateSW2AppListView()
                      AppInitModule.ReadSourceAppProfile()
                  End Sub)
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


End Class
