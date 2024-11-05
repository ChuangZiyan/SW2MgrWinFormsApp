﻿Imports System.IO
Imports Newtonsoft.Json
Imports SW2MgrWinFormsApp.MainFormController

Public Class Form1
    Private Sub RevealAppSourceFolder_Button_Click(sender As Object, e As EventArgs) Handles RevealAppSourceFolder_Button.Click
        Try
            Process.Start("explorer.exe", AppInitModule.webview2AppSourceDirectory)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppInitModule.InitializeMainApp()
    End Sub

    Private Sub CreateNewSW2App_Button_Click(sender As Object, e As EventArgs) Handles CreateNewSW2App_Button.Click

        Try
            Dim folderName As String = NewSW2FolderName_TextBox.Text
            Dim folderPath = Path.Combine(AppInitModule.webview2AppDirectory, folderName)

            If Not Directory.Exists(folderPath) And Not folderName.Contains("&"c) Then
                Directory.CreateDirectory(folderPath)

                ' 複製SW2 source 到 新資料夾
                Dim sourceFolder As String = AppInitModule.webview2AppSourceDirectory

                Dim destinationPath As String = folderPath

                If Directory.Exists(sourceFolder) Then
                    DirectoryCopy(sourceFolder, destinationPath, True)
                Else
                    Debug.WriteLine("source not found")
                End If

                'Directory.CreateDirectory(Path.Combine(folderPath, "null"))
                MainFormController.UpdateSW2AppListView()
                NewSW2FolderName_TextBox.Clear()
            Else
                MsgBox("無法使用此名稱")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub UpdateSW2AppListView_Button_Click(sender As Object, e As EventArgs) Handles UpdateSW2AppListView_Button.Click
        MainFormController.UpdateSW2AppListView()
        AppInitModule.ReadSourceAppProfile()
    End Sub

    Private Sub DeleteSelectedSW2AppFolder_Button_Click(sender As Object, e As EventArgs) Handles DeleteSelectedSW2AppFolder_Button.Click
        Try
            Dim selectedItems = SW2App_ListView.SelectedItems
            If selectedItems.Count > 0 Then
                ' 刪掉選擇的
                Dim result As DialogResult = MessageBox.Show("確定要刪除嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    For Each item As ListViewItem In selectedItems
                        Dim folderPath = Path.Combine(AppInitModule.webview2AppDirectory, item.SubItems(1).Text)
                        Directory.Delete(folderPath, recursive:=True)
                    Next
                    MainFormController.UpdateSW2AppListView()
                    MsgBox("刪除成功")
                End If
            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("刪除失敗")
        End Try
    End Sub

    Private Sub LaunchSeletedSW2App_Button_Click(sender As Object, e As EventArgs) Handles LaunchSeletedSW2App_Button.Click

        Try
            If SW2App_ListView.SelectedItems.Count > 0 Then
                Dim selectedSW2Item As ListViewItem = SW2App_ListView.SelectedItems.Item(0)
                Dim exePath As String = Path.Combine(AppInitModule.webview2AppDirectory, selectedSW2Item.SubItems(1).Text, "SW2WinFormsApp.exe")
                Debug.WriteLine("exepath : " & exePath)
                If File.Exists(exePath) Then
                    LaunchSeletedSW2App_Button.Enabled = False
                    Dim process As Process = Process.Start(exePath)
                    Dim pid As Integer = process.Id
                    selectedSW2Item.SubItems(0).Text = pid.ToString()
                    selectedSW2Item.SubItems(3).Text = "On"
                Else
                    Debug.WriteLine("找不到指定的exe檔案！")
                End If

            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("無法啟動")
            LaunchSeletedSW2App_Button.Enabled = True
        End Try

    End Sub

    Private Sub TerminateSW2AppByPId_Button_Click(sender As Object, e As EventArgs) Handles TerminateSW2AppByPId_Button.Click
        Try

            If SW2App_ListView.SelectedItems.Count > 0 Then

                Dim selectedSW2Item As ListViewItem = SW2App_ListView.SelectedItems.Item(0)

                Dim pid As Integer = CInt(selectedSW2Item.SubItems(0).Text)

                ' 取得對應的Process物件並終止
                Dim process As Process = Process.GetProcessById(pid)
                process.Kill()

                selectedSW2Item.SubItems(0).Text = ""
                selectedSW2Item.SubItems(3).Text = "Off"
                LaunchSeletedSW2App_Button.Enabled = True
                MsgBox("關閉成功")

            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("關閉失敗")
        End Try
    End Sub

    Private Sub SW2App_ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SW2App_ListView.SelectedIndexChanged
        Try
            Dim selectedSW2AppListViewItems = SW2App_ListView.SelectedItems
            If selectedSW2AppListViewItems.Count > 0 Then

                If selectedSW2AppListViewItems(0).SubItems(3).Text = "On" Then
                    LaunchSeletedSW2App_Button.Enabled = False
                Else
                    LaunchSeletedSW2App_Button.Enabled = True
                End If

                Dim folderName = selectedSW2AppListViewItems(0).SubItems(1).Text
                'Debug.WriteLine(folderName)
                Dim appConfigs As AppConfigs = GetAppConfigs(folderName)
                SW2App_AutoRun_CheckBox.Checked = appConfigs.AutoRun
                SW2App_AutoRunDelaySeconds_NumericUpDown.Value = appConfigs.AutoRunDelaySeconds
                If appConfigs.ScheduledRun Then
                    SW2App_ScheduledRun_RadioButton.Checked = True
                    SW2App_SequentialRun_RadioButton.Checked = False
                Else
                    SW2App_ScheduledRun_RadioButton.Checked = False
                    SW2App_SequentialRun_RadioButton.Checked = True
                End If

            End If
        Catch ex As Exception
            Debug.WriteLine(ex)
            Debug.WriteLine("讀取SW2 Configs失敗")
        End Try

    End Sub

    Private Sub SaveSW2AppConfigs_Button_Click(sender As Object, e As EventArgs) Handles SaveSW2AppConfigs_Button.Click
        Try
            Dim selectedSW2AppListViewItems = SW2App_ListView.SelectedItems

            If selectedSW2AppListViewItems.Count > 0 Then
                Dim folderName = selectedSW2AppListViewItems(0).SubItems(1).Text
                Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "appConfigs.json")

                Dim appConfigs As New AppConfigs With {
                    .AutoRun = SW2App_AutoRun_CheckBox.Checked,
                    .AutoRunDelaySeconds = SW2App_AutoRunDelaySeconds_NumericUpDown.Value,
                    .ScheduledRun = SW2App_ScheduledRun_RadioButton.Checked
                }
                Dim jsonString As String = JsonConvert.SerializeObject(appConfigs, Formatting.Indented)
                File.WriteAllText(filePath, jsonString)
                MsgBox("儲存成功")
            Else
                MsgBox("未選擇程式")
            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("寫入失敗")
        End Try

    End Sub

End Class
