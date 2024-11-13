﻿Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json

Public Class MgrMainFormEventController




    Public Sub SW2App_ListView_DoubleClick(sender As Object, e As EventArgs)
        Try
            Dim selectedItem As ListViewItem = Form1.SW2App_ListView.SelectedItems(0)
            Dim folderName = selectedItem.SubItems(1).Text
            Debug.WriteLine("folderName : " & folderName)

            Process.Start("explorer.exe", Path.Combine(AppInitModule.webview2AppDirectory, folderName))
        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try

    End Sub



    Public Async Sub UpdateSelectedSW2App_Button_Click(sender As Object, e As EventArgs)

        Try
            If Form1.SW2App_ListView.SelectedItems.Count < 1 Then
                Exit Sub
            End If

            'Dim result As DialogResult = MessageBox.Show("確定要更新嗎？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If result = DialogResult.Yes Then
            Form1.UpdateSelectedSW2App_Button.Enabled = False
            Form1.UpdateAllSWApp_Button.Enabled = False



            ' 先關閉開啟的APP
            For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems

                ' 如果開啟就先關閉再更新
                Dim app_pid = selectedItem.SubItems(0).Text
                If app_pid <> "" Then
                    Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)
                    Dim process As Process = Process.GetProcessById(pid)
                    process.Kill()
                End If
            Next

            Await Delay_msec(1000)

            ' 開始更新
            For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems

                Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 中"

                Dim swAppPath = Path.Combine(webview2AppDirectory, selectedItem.SubItems(1).Text)
                UpdaterModule.totalFiles = GetTotalFiles(AppInitModule.webview2AppSourceDirectory)
                Form1.AppUpdating_ProgressBar.Value = 0
                UpdaterModule.UpdateFiles(AppInitModule.webview2AppSourceDirectory, swAppPath)
                Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 完成"
                UpdaterModule.progressCounter = 0
            Next
            MsgBox("更新成功")
            'End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("更新失敗")
        End Try

        Form1.UpdateSelectedSW2App_Button.Enabled = True
        Form1.UpdateAllSWApp_Button.Enabled = True


    End Sub


    Public Async Sub UpdateAllSWApp_Button_Click(sender As Object, e As EventArgs)
        Try
            Dim result As DialogResult = MessageBox.Show("確定要更新全部嗎？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Form1.UpdateSelectedSW2App_Button.Enabled = False
                Form1.UpdateAllSWApp_Button.Enabled = False



                ' 先關閉開啟的APP
                For Each selectedItem As ListViewItem In Form1.SW2App_ListView.Items

                    ' 如果開啟就先關閉再更新
                    Dim app_pid = selectedItem.SubItems(0).Text
                    If app_pid <> "" Then
                        Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)
                        Dim process As Process = Process.GetProcessById(pid)
                        process.Kill()
                    End If
                Next

                Await Delay_msec(1000)

                For Each selectedItem As ListViewItem In Form1.SW2App_ListView.Items

                    ' 如果開啟就先關閉再更新
                    Dim app_pid = selectedItem.SubItems(0).Text
                    If app_pid <> "" Then
                        Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)
                        Dim process As Process = Process.GetProcessById(pid)
                        process.Kill()
                    End If


                    Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 中"

                    Dim swAppPath = Path.Combine(webview2AppDirectory, selectedItem.SubItems(1).Text)
                    UpdaterModule.totalFiles = GetTotalFiles(AppInitModule.webview2AppSourceDirectory)
                    Form1.AppUpdating_ProgressBar.Value = 0
                    UpdaterModule.UpdateFiles(AppInitModule.webview2AppSourceDirectory, swAppPath)
                    Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 完成"
                    UpdaterModule.progressCounter = 0
                Next
                MsgBox("更新成功")
            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("更新失敗")
        End Try

        Form1.UpdateSelectedSW2App_Button.Enabled = True
        Form1.UpdateAllSWApp_Button.Enabled = True

    End Sub

    Public Sub RevealAppSourceFolder_Button_Click(sender As Object, e As EventArgs)
        Try
            Process.Start("explorer.exe", AppInitModule.webview2AppSourceDirectory)
        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try
    End Sub


    Public Sub CreateNewSW2App_Button_Click(sender As Object, e As EventArgs)

        Try
            Dim folderName As String = Form1.NewSW2FolderName_TextBox.Text
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

                MainFormController.UpdateSW2AppListView()
                Form1.NewSW2FolderName_TextBox.Clear()
            Else
                MsgBox("無法使用此名稱")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Public Sub UpdateSW2AppListView_Button_Click(sender As Object, e As EventArgs)
        MainFormController.UpdateSW2AppListView()
        AppInitModule.ReadSourceAppProfile()
    End Sub


    Public Sub DeleteSelectedSW2AppFolder_Button_Click(sender As Object, e As EventArgs)
        Try
            If Form1.SW2App_ListView.SelectedItems.Count < 1 Then
                Exit Sub
            End If

            Dim result As DialogResult = MessageBox.Show("確定要刪除嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems

                    Dim folderPath = Path.Combine(AppInitModule.webview2AppDirectory, selectedItem.SubItems(1).Text)
                    Directory.Delete(folderPath, recursive:=True)
                    Form1.SW2App_ListView.Items.Remove(selectedItem)
                Next
                MsgBox("刪除成功")
            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("刪除失敗")
        End Try
    End Sub


    Public Async Sub LaunchSeletedSW2App_Button_Click(sender As Object, e As EventArgs)

        For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems
            Try
                Dim exePath As String = Path.Combine(AppInitModule.webview2AppDirectory, selectedItem.SubItems(1).Text, "SW2WinFormsApp.exe")
                'Debug.WriteLine("exepath : " & exePath)
                If File.Exists(exePath) Then
                    Form1.LaunchSeletedSW2App_Button.Enabled = False
                    Form1.TerminateSW2AppByPId_Button.Enabled = True
                    Dim process As Process = Process.Start(exePath)
                    Dim pid As Integer = process.Id
                    selectedItem.SubItems(0).Text = pid.ToString()
                    selectedItem.SubItems(3).Text = "On"
                Else
                    Debug.WriteLine("找不到指定的exe檔案！")
                End If
                Await Delay_msec(Form1.LaunchDelaySeconds_NumericUpDown.Value * 1000)
            Catch ex As Exception
                Debug.WriteLine(ex)
                MsgBox("啟動 " & selectedItem.SubItems(1).Text & " 失敗")
            End Try

        Next

    End Sub

    Public Sub TerminateSW2AppByPId_Button_Click(sender As Object, e As EventArgs)

        For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems
            Try

                Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)

                ' 取得對應的Process物件並終止
                Dim process As Process = Process.GetProcessById(pid)
                process.Kill()

                selectedItem.SubItems(0).Text = ""
                selectedItem.SubItems(3).Text = "Off"
                Form1.LaunchSeletedSW2App_Button.Enabled = True
                Form1.TerminateSW2AppByPId_Button.Enabled = False
            Catch ex As Exception
                Debug.WriteLine(ex)
                MsgBox("關閉 " & selectedItem.SubItems(1).Text & " 失敗")
            End Try

        Next

    End Sub

    Public Sub SW2App_ListView_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            Dim selectedSW2AppListViewItems = Form1.SW2App_ListView.SelectedItems
            If selectedSW2AppListViewItems.Count > 0 Then

                If selectedSW2AppListViewItems(0).SubItems(3).Text = "On" Then
                    Form1.LaunchSeletedSW2App_Button.Enabled = False
                    Form1.TerminateSW2AppByPId_Button.Enabled = True
                Else
                    Form1.LaunchSeletedSW2App_Button.Enabled = True
                    Form1.TerminateSW2AppByPId_Button.Enabled = False
                End If

                Dim folderName = selectedSW2AppListViewItems(0).SubItems(1).Text
                'Debug.WriteLine(folderName)
                Dim appConfigs As AppConfigs = GetAppConfigs(folderName)
                Form1.SW2App_AutoRun_CheckBox.Checked = appConfigs.AutoRun
                Form1.SW2App_AutoRunDelaySeconds_NumericUpDown.Value = appConfigs.AutoRunDelaySeconds
                If appConfigs.ScheduledRun Then
                    Form1.SW2App_ScheduledRun_RadioButton.Checked = True
                    Form1.SW2App_SequentialRun_RadioButton.Checked = False
                Else
                    Form1.SW2App_ScheduledRun_RadioButton.Checked = False
                    Form1.SW2App_SequentialRun_RadioButton.Checked = True
                End If

            End If
        Catch ex As Exception
            Debug.WriteLine(ex)
            Debug.WriteLine("讀取SW2 Configs失敗")
        End Try

    End Sub


    Public Sub SaveSW2AppConfigs_Button_Click(sender As Object, e As EventArgs)
        Try
            Dim selectedSW2AppListViewItems = Form1.SW2App_ListView.SelectedItems

            If selectedSW2AppListViewItems.Count > 0 Then
                Dim folderName = selectedSW2AppListViewItems(0).SubItems(1).Text
                Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "appConfigs.json")

                Dim appConfigs As New AppConfigs With {
                    .AutoRun = Form1.SW2App_AutoRun_CheckBox.Checked,
                    .AutoRunDelaySeconds = Form1.SW2App_AutoRunDelaySeconds_NumericUpDown.Value,
                    .ScheduledRun = Form1.SW2App_ScheduledRun_RadioButton.Checked
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

    Public Sub TerminateAllSW2App_Button_Click(sender As Object, e As EventArgs)
        Try
            For Each selectedItem As ListViewItem In Form1.SW2App_ListView.Items
                Try
                    Dim app_status = selectedItem.SubItems(3).Text

                    If app_status = "On" Then
                        Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)
                        Dim process As Process = Process.GetProcessById(pid)
                        process.Kill()

                        selectedItem.SubItems(0).Text = ""
                        selectedItem.SubItems(3).Text = "Off"
                    End If

                Catch ex As Exception
                    Debug.WriteLine(ex)
                End Try

            Next

            Form1.LaunchSeletedSW2App_Button.Enabled = True
            Form1.TerminateSW2AppByPId_Button.Enabled = False
            MsgBox("關閉全部成功")
        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("關閉發生錯誤")
        End Try

    End Sub

End Class
