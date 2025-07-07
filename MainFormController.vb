Imports System.IO
Imports Newtonsoft.Json
Module MainFormController

    Public Sub UpdateSW2AppListView()
        'Debug.WriteLine("update listview")

        Try

            Dim dirs As String() = Directory.GetDirectories(AppInitModule.webview2AppDirectory)
            For Each dir As String In dirs

                Dim folderName As String = Path.GetFileName(dir)
                Dim myProfile As Webview2AppProfile = GetProfile(folderName)
                Dim myAppConfigs As Webview2AppConfigs = GetAppConfigs(folderName)

                Dim exist_app = False
                Dim app_status = "Off"
                Dim app_pid = ""

                For Each item As ListViewItem In Form1.SW2App_ListView.Items
                    'Debug.WriteLine("PID: " & item.SubItems(0).Text)
                    Dim exist_app_pid = item.SubItems(0).Text
                    Dim exist_app_name = item.SubItems(1).Text
                    'Debug.WriteLine("Name: " & item.SubItems(1).Text)
                    If exist_app_name = folderName Then
                        'Debug.WriteLine("exist app " & folderName)
                        exist_app = True

                        ' update version
                        item.SubItems(2).Text = myProfile.Version


                        item.SubItems(4).Text = If(myAppConfigs.AutoRun, "是", "否")
                        item.SubItems(5).Text = myAppConfigs.AutoRunDelaySeconds
                        item.SubItems(6).Text = If(myAppConfigs.ScheduledRun, "定時", "順序")


                        If myAppConfigs.ScheduledRun Then
                            item.SubItems(7).Text = "NULL"
                        Else
                            item.SubItems(7).Text = myAppConfigs.NumberOfRuns
                        End If


                        ' check app status with pid
                        If exist_app_pid <> "" Then
                            If IsProcessRunning(CInt(exist_app_pid)) Then
                                'Debug.WriteLine("app pid : " & exist_app_pid & " is running ")
                                app_status = "On"
                                app_pid = exist_app_pid
                            Else
                                item.SubItems(0).Text = app_pid
                                item.SubItems(3).Text = app_status
                            End If

                        End If
                        Exit For
                    End If
                Next

                If Not exist_app Then
                    Dim sw2appListViewItem As New ListViewItem(app_pid)
                    sw2appListViewItem.SubItems.Add(folderName)
                    sw2appListViewItem.SubItems.Add(myProfile.Version)
                    '狀態
                    sw2appListViewItem.SubItems.Add(app_status)
                    sw2appListViewItem.SubItems.Add(If(myAppConfigs.AutoRun, "是", "否"))
                    sw2appListViewItem.SubItems.Add(myAppConfigs.AutoRunDelaySeconds)
                    sw2appListViewItem.SubItems.Add(If(myAppConfigs.ScheduledRun, "定時", "順序"))

                    If myAppConfigs.ScheduledRun Then
                        sw2appListViewItem.SubItems.Add("NULL")
                    Else
                        sw2appListViewItem.SubItems.Add(myAppConfigs.NumberOfRuns)
                    End If


                    Form1.SW2App_ListView.Items.Add(sw2appListViewItem)
                End If





            Next
            ' 更新字體樣式
            UpdateListViewItemStyle()
        Catch ex As Exception
            Debug.WriteLine("更新失敗")
            Debug.WriteLine(ex)
        End Try


    End Sub

    Private Sub UpdateListViewItemStyle()
        For Each item As ListViewItem In Form1.SW2App_ListView.Items
            Dim subItemText As String = item.SubItems(3).Text
            If subItemText = "On" Then
                ' 修改背景與粗體樣式
                item.UseItemStyleForSubItems = False

                ' 字的顏色
                'item.SubItems(3).ForeColor = Color.Green

                ' 背景顏色
                item.SubItems(3).BackColor = Color.LightGreen

                ' 字體修改 FontStyle.Bold就是粗體
                item.SubItems(3).Font = New Font(Form1.SW2App_ListView.Font, FontStyle.Bold)
            Else
                ' 恢復預設樣式
                item.SubItems(3).BackColor = Color.White
                item.SubItems(3).Font = Form1.SW2App_ListView.Font
            End If
        Next
    End Sub

    Public Function GetProfile(folderName)
        Try
            Dim profile As New Webview2AppProfile With {
                .Version = "N/A",
                .BuildDate = "N/A",
                .UUID = "N/A"
            }

            Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "profile.json")
            ' Debug.WriteLine(filePath)
            ' 如果 profile.json 檔案存在，就讀取檔案並反序列化
            If File.Exists(filePath) Then
                Dim jsonString As String = File.ReadAllText(filePath)
                profile = JsonConvert.DeserializeObject(Of Webview2AppProfile)(jsonString)
            End If
            'Debug.WriteLine($"{folderName} ver {profile.Version}")

            Return profile
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function GetAppConfigs(folderName)
        Try
            Dim appConfigs As New Webview2AppConfigs With {
                .AutoRun = False,
                .AutoRunDelaySeconds = 15,
                .ScheduledRun = False
            }

            Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "appConfigs.json")
            ' Debug.WriteLine(filePath)
            ' 如果 profile.json 檔案存在，就讀取檔案並反序列化
            If File.Exists(filePath) Then
                Dim jsonString As String = File.ReadAllText(filePath)
                appConfigs = JsonConvert.DeserializeObject(Of Webview2AppConfigs)(jsonString)
            Else
                Dim jsonString As String = JsonConvert.SerializeObject(appConfigs, Formatting.Indented)
                File.WriteAllText(filePath, jsonString)
            End If

            Return appConfigs
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Sub SaveSW2AppConfigs(target As String)
        Try
            ' Debug.WriteLine(target)
            Dim selectedSW2AppListViewItems = Form1.SW2App_ListView.SelectedItems

            If selectedSW2AppListViewItems.Count > 0 Then
                For Each seletedItem As ListViewItem In selectedSW2AppListViewItems

                    Dim folderName = seletedItem.SubItems(1).Text
                    Dim appConfigs As Webview2AppConfigs = GetAppConfigs(folderName)

                    Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "appConfigs.json")

                    Select Case target
                        Case "autoRun"
                            appConfigs.AutoRun = Form1.SW2App_AutoRun_CheckBox.Checked
                        Case "autoRunDelaySeconds"
                            appConfigs.AutoRunDelaySeconds = Form1.SW2App_AutoRunDelaySeconds_NumericUpDown.Value
                        Case "numberOfRuns"
                            appConfigs.NumberOfRuns = Form1.SW2App_NumberOfRuns_NumericUpDown.Value
                        Case "sequentialRun"
                            If Form1.SW2App_SequentialRun_RadioButton.Checked Then
                                appConfigs.ScheduledRun = False
                            Else
                                appConfigs.ScheduledRun = True
                            End If
                    End Select


                    Dim jsonString As String = JsonConvert.SerializeObject(appConfigs, Formatting.Indented)
                    File.WriteAllText(filePath, jsonString)

                Next

            End If

            MainFormController.UpdateSW2AppListView()

        Catch ex As Exception
            Debug.WriteLine(ex)

        End Try

    End Sub



    Public Class Webview2AppProfile
        Public Property Version As String
        Public Property BuildDate As String
        Public Property UUID As String
        Public Property AppFolderPath As String

    End Class

    Public Class Webview2AppConfigs
        Public Property AutoRun As Boolean
        Public Property AutoRunDelaySeconds As Integer
        Public Property ScheduledRun As Boolean
        Public Property NumberOfRuns As Integer

    End Class


End Module
