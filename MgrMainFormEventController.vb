Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json

Public Class MgrMainFormEventController

    Public Sub SW2App_ListView_DoubleClick(sender As Object, e As EventArgs)
        Try
            Dim selectedItem As ListViewItem = Form1.SW2App_ListView.SelectedItems(0)
            Dim folderName = selectedItem.SubItems(1).Text
            ' Debug.WriteLine("folderName : " & folderName)

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
                    Dim process As Process = process.GetProcessById(pid)
                    process.Kill()
                End If
            Next

            Await Delay_msec(1000)

            ' 開始更新
            For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems

                Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 中"

                Dim swAppPath = Path.Combine(webview2AppDirectory, selectedItem.SubItems(1).Text)
                UpdaterModule.totalFiles = UpdaterModule.GetTotalFiles(AppInitModule.webview2AppSourceDirectory)
                Form1.AppUpdating_ProgressBar.Value = 0
                UpdaterModule.UpdateFiles(AppInitModule.webview2AppSourceDirectory, swAppPath)
                Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 完成"
                UpdaterModule.progressCounter = 0
            Next
            MsgBox("更新成功")
            Form1.AppUpdatingProgressInfo_Label.Text = "更新進度"
            Form1.UpdatingProgressPercent_Label.Text = "0%"
            Form1.AppUpdating_ProgressBar.Value = 0

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
                        Dim process As Process = process.GetProcessById(pid)
                        process.Kill()
                    End If
                Next

                Await Delay_msec(1000)

                For Each selectedItem As ListViewItem In Form1.SW2App_ListView.Items

                    ' 如果開啟就先關閉再更新
                    Dim app_pid = selectedItem.SubItems(0).Text
                    If app_pid <> "" Then
                        Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)
                        Dim process As Process = process.GetProcessById(pid)
                        process.Kill()
                    End If


                    Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 中"

                    Dim swAppPath = Path.Combine(webview2AppDirectory, selectedItem.SubItems(1).Text)
                    UpdaterModule.totalFiles = UpdaterModule.GetTotalFiles(AppInitModule.webview2AppSourceDirectory)
                    Form1.AppUpdating_ProgressBar.Value = 0
                    UpdaterModule.UpdateFiles(AppInitModule.webview2AppSourceDirectory, swAppPath)
                    Form1.AppUpdatingProgressInfo_Label.Text = $"更新 {selectedItem.SubItems(1).Text} 完成"
                    UpdaterModule.progressCounter = 0
                Next

                MsgBox("更新成功")
                Form1.AppUpdatingProgressInfo_Label.Text = "更新進度"
                Form1.UpdatingProgressPercent_Label.Text = "0%"
                Form1.AppUpdating_ProgressBar.Value = 0

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
            ' 設定一些防呆
            Form1.CreateNewSW2App_Button.Enabled = False
            Form1.DeleteSelectedSW2AppFolder_Button.Enabled = False
            Form1.autoUpdateUI = False

            ' 這邊開始主要功能
            Dim folderName As String = Form1.NewSW2FolderName_TextBox.Text
            Dim folderPath = Path.Combine(AppInitModule.webview2AppDirectory, folderName)

            If Not Directory.Exists(folderPath) And Not folderName.Contains("&"c) Then
                Directory.CreateDirectory(folderPath)

                ' 複製SW2 source 到 新資料夾
                Dim sourceFolder As String = AppInitModule.webview2AppSourceDirectory

                Dim destinationPath As String = folderPath

                If Directory.Exists(sourceFolder) Then
                    SWAppCreatorModule.totalFiles = SWAppCreatorModule.GetTotalFiles(sourceFolder)
                    SWAppCreatorModule.UpdateFiles(sourceFolder, destinationPath)

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

        ' 把防呆的元件設定回來
        Form1.CreateNewSW2App_Button.Text = "新增"
        Form1.CreateNewSW2App_Button.Enabled = True
        Form1.DeleteSelectedSW2AppFolder_Button.Enabled = True
        Form1.autoUpdateUI = True
        ' 進度重設
        SWAppCreatorModule.progressCounter = 0

    End Sub

    Public Sub UpdateSW2AppListView_Button_Click(sender As Object, e As EventArgs)
        MainFormController.UpdateSW2AppListView()
        AppInitModule.ReadSourceAppProfile()
    End Sub


    Public Async Sub DeleteSelectedSW2AppFolder_Button_Click(sender As Object, e As EventArgs)
        Try
            If Form1.SW2App_ListView.SelectedItems.Count < 1 Then
                Exit Sub
            End If

            Dim result As DialogResult = MessageBox.Show("確定要刪除嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' 設定一些防呆
                Form1.DeleteSelectedSW2AppFolder_Button.Enabled = False
                Form1.DeleteSelectedSW2AppFolder_Button.Text = "刪除中"
                Form1.CreateNewSW2App_Button.Enabled = False
                Form1.autoUpdateUI = False

                Application.DoEvents() ' 更新一下UI

                ' 先關閉開啟的APP
                For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems

                    ' 如果開啟就先關閉再更新
                    Dim app_pid = selectedItem.SubItems(0).Text
                    If app_pid <> "" Then
                        Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)
                        Dim process As Process = process.GetProcessById(pid)
                        process.Kill()
                    End If
                Next

                Await Delay_msec(1000)

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

        ' 把防呆的元件設定回來
        Form1.DeleteSelectedSW2AppFolder_Button.Text = "刪除"
        Form1.DeleteSelectedSW2AppFolder_Button.Enabled = True
        Form1.CreateNewSW2App_Button.Enabled = True
        Form1.autoUpdateUI = True

    End Sub


    Public Async Sub LaunchSeletedSW2App_Button_Click(sender As Object, e As EventArgs)

        For Each selectedItem As ListViewItem In Form1.SW2App_ListView.SelectedItems
            Try
                Dim exePath As String = Path.Combine(AppInitModule.webview2AppDirectory, selectedItem.SubItems(1).Text, "SW2WinFormsApp.exe")
                'Debug.WriteLine("exepath : " & exePath)
                If File.Exists(exePath) Then
                    Form1.LaunchSeletedSW2App_Button.Enabled = False
                    Form1.TerminateSW2AppByPId_Button.Enabled = True
                    Dim process As Process = process.Start(exePath)
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
                Dim process As Process = process.GetProcessById(pid)
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
            If selectedSW2AppListViewItems.Count = 1 Then

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

                Form1.SW2App_NumberOfRuns_NumericUpDown.Value = appConfigs.NumberOfRuns
            Else
                Form1.SW2App_AutoRun_CheckBox.Checked = False
                Form1.SW2App_ScheduledRun_RadioButton.Checked = False
                Form1.SW2App_SequentialRun_RadioButton.Checked = True
                Form1.SW2App_AutoRunDelaySeconds_NumericUpDown.Value = 15
                Form1.SW2App_NumberOfRuns_NumericUpDown.Value = 1

            End If
        Catch ex As Exception
            Debug.WriteLine(ex)
            Debug.WriteLine("讀取SW2 Configs失敗")
        End Try

    End Sub


    Public Sub TerminateAllSW2App_Button_Click(sender As Object, e As EventArgs)
        Try
            For Each selectedItem As ListViewItem In Form1.SW2App_ListView.Items
                Try
                    Dim app_status = selectedItem.SubItems(3).Text

                    If app_status = "On" Then
                        Dim pid As Integer = CInt(selectedItem.SubItems(0).Text)
                        Dim process As Process = process.GetProcessById(pid)
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

    Public Sub SaveSW2AppConfigs_Button_Click(sender As Object, e As EventArgs)
        Try

            Dim selectedSW2AppListViewItems = Form1.SW2App_ListView.SelectedItems

            If selectedSW2AppListViewItems.Count > 0 Then
                For Each seletedItem As ListViewItem In selectedSW2AppListViewItems

                    Dim folderName = seletedItem.SubItems(1).Text
                    Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "appConfigs.json")

                    Dim appConfigs = GetAppConfigs(folderName)

                    appConfigs.AutoRunDelaySeconds = Form1.SW2App_AutoRunDelaySeconds_NumericUpDown.Value
                    appConfigs.ScheduledRun = Form1.SW2App_ScheduledRun_RadioButton.Checked
                    appConfigs.NumberOfRuns = Form1.SW2App_NumberOfRuns_NumericUpDown.Value


                    Dim jsonString As String = JsonConvert.SerializeObject(appConfigs, Formatting.Indented)
                    File.WriteAllText(filePath, jsonString)

                Next
                MsgBox("儲存成功")
            Else
                MsgBox("未選擇程式")
            End If

            MainFormController.UpdateSW2AppListView()

        Catch ex As Exception
            Debug.WriteLine(ex)
            MsgBox("寫入失敗")
        End Try

    End Sub

    Public Sub SW2App_AutoRun_CheckBox_Click(sender As Object, e As EventArgs)
        MainFormController.SaveSW2AppConfigs("autoRun")
    End Sub



    Public Sub SelectAllSW2AppListViewItems_Button_Click(sender As Object, e As EventArgs)

        For Each item As ListViewItem In Form1.SW2App_ListView.Items
            item.Selected = True
        Next

    End Sub

    Public Sub DeselectAllSW2AppListViewItems_Button_Click(sender As Object, e As EventArgs)
        For Each item As ListViewItem In Form1.SW2App_ListView.Items
            item.Selected = False
        Next
    End Sub



    Public Sub SelectedItemsByText_Button_Click(sender As Object, e As EventArgs)
        For Each item As ListViewItem In Form1.SW2App_ListView.Items
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                If subItem.Text = Form1.SW2APPSearchText_ComboBox.Text Then
                    item.Selected = True
                    Exit For ' 一旦找到匹配的子項就跳出內層迴圈
                End If
            Next
        Next
    End Sub



    Public Sub MarkSW2ListViewItemsByText_Button_Click(sender As Object, e As EventArgs)

        If Form1.SW2APPSearchText_ComboBox.Text = "" Then
            Exit Sub
        End If

        For Each item As ListViewItem In Form1.SW2App_ListView.Items
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                item.UseItemStyleForSubItems = False
                If subItem.Text = Form1.SW2APPSearchText_ComboBox.Text Then

                    subItem.BackColor = Color.LightGreen
                    subItem.Font = New Font(Form1.SW2App_ListView.Font, FontStyle.Bold)
                    Exit For
                End If
            Next
        Next
    End Sub


    Public Sub UnmarkSW2ListViewItemsByText_Button_Click(sender As Object, e As EventArgs)
        For Each item As ListViewItem In Form1.SW2App_ListView.Items
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                item.UseItemStyleForSubItems = False

                If Form1.SW2APPSearchText_ComboBox.Text = "" Then
                    subItem.BackColor = Color.White
                    subItem.Font = Form1.SW2App_ListView.Font

                ElseIf subItem.Text = form1.SW2APPSearchText_ComboBox.Text Then
                    subItem.BackColor = Color.White
                    subItem.Font = Form1.SW2App_ListView.Font
                    Exit For
                End If

            Next
        Next
    End Sub


    Public Sub ApplySWAppWindowConfigs_Button_Click(sender As Object, e As EventArgs)

        Dim selectedSW2AppListViewItems = Form1.SW2App_ListView.SelectedItems

        For Each item As ListViewItem In selectedSW2AppListViewItems

            ' 檢查是啟動的APP才送命令，防止Timeout
            If item.SubItems(0).Text <> "" Then

                Dim profile As Webview2AppProfile = MainFormController.GetProfile(item.SubItems(1).Text)
                Dim appUUID As String = profile.UUID
                Select Case True
                    Case Form1.LiteModeNormal_RadioButton.Checked
                        UtilsModule.SendPipeCommandTask(appUUID, "setLiteModeNormal")
                    Case Form1.LiteModeWebview_RadioButton.Checked
                        UtilsModule.SendPipeCommandTask(appUUID, "setLiteModeWebview")
                    Case Form1.LiteModeScriptListView_RadioButton.Checked
                        UtilsModule.SendPipeCommandTask(appUUID, "setLiteModeScriptListView")
                End Select
                Dim opacityVal As Double = Form1.SWAPP_OpacityValue_NumericUpDown.Value / 100
                UtilsModule.SendPipeCommandTask(appUUID, $"setOpacity:{opacityVal:0.00}")

            End If


        Next

    End Sub


End Class
