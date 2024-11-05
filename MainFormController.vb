Imports System.IO
Imports Newtonsoft.Json
Module MainFormController

    Public Sub UpdateSW2AppListView()

        Dim dirs As String() = Directory.GetDirectories(AppInitModule.webview2AppDirectory)
        For Each dir As String In dirs

            Dim folderName As String = Path.GetFileName(dir)
            Dim myProfile As Webview2AppProfile = GetProfile(folderName)

            Dim exist_app = False
            Dim app_status = "Off"
            Dim app_pid = ""

            For Each item As ListViewItem In Form1.SW2App_ListView.Items
                'Debug.WriteLine("PID: " & item.SubItems(0).Text)
                Dim exist_app_pid = item.SubItems(0).Text
                Dim exist_app_name = item.SubItems(1).Text
                'Debug.WriteLine("Name: " & item.SubItems(1).Text)
                If exist_app_name = folderName Then
                    Debug.WriteLine("exist app " & folderName)
                    exist_app = True
                    ' check app status with pid
                    If exist_app_pid <> "" Then
                        If IsProcessRunning(CInt(exist_app_pid)) Then
                            Debug.WriteLine("app pid : " & exist_app_pid & " is running ")
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
                sw2appListViewItem.SubItems.Add("")
                Form1.SW2App_ListView.Items.Add(sw2appListViewItem)
            End If

        Next

    End Sub


    Private Function GetProfile(folderName)
        Try
            Dim profile As New Webview2AppProfile With {
                .Version = "N/A",    ' 設定預設版本號
                .BuildDate = "N/A" ' 設定預設建置日期
            }

            Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "profile.json")
            ' Debug.WriteLine(filePath)
            ' 如果 profile.json 檔案存在，就讀取檔案並反序列化
            If File.Exists(filePath) Then
                Dim jsonString As String = File.ReadAllText(filePath)
                profile = JsonConvert.DeserializeObject(Of Webview2AppProfile)(jsonString)
            End If

            Return profile
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function GetAppConfigs(folderName)
        Try
            Dim appConfigs As New AppConfigs With {
                .AutoRun = False,
                .AutoRunDelaySeconds = 15,
                .ScheduledRun = False
            }

            Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "appConfigs", "appConfigs.json")
            ' Debug.WriteLine(filePath)
            ' 如果 profile.json 檔案存在，就讀取檔案並反序列化
            If File.Exists(filePath) Then
                Dim jsonString As String = File.ReadAllText(filePath)
                appConfigs = JsonConvert.DeserializeObject(Of AppConfigs)(jsonString)
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


    Public Class Webview2AppProfile
        Public Property Version As String
        Public Property BuildDate As String

    End Class

    Public Class AppConfigs
        Public Property AutoRun As Boolean
        Public Property AutoRunDelaySeconds As Integer
        Public Property ScheduledRun As Boolean

    End Class


End Module
