Imports System.IO
Imports Newtonsoft.Json
Module MainFormController

    Public Sub UpdateSW2AppListView()

        Form1.SW2App_ListView.Items.Clear()

        Dim dirs As String() = Directory.GetDirectories(AppInitModule.webview2AppDirectory)
        For Each dir As String In dirs
            Dim sw2appListViewItem As New ListViewItem()
            Dim folderName As String = Path.GetFileName(dir)

            Dim myProfile As Webview2AppProfile = GetProfile(folderName)

            sw2appListViewItem.SubItems.Add(folderName)
            sw2appListViewItem.SubItems.Add(myProfile.Version)
            '狀態
            sw2appListViewItem.SubItems.Add("Off")
            sw2appListViewItem.SubItems.Add("")
            Form1.SW2App_ListView.Items.Add(sw2appListViewItem)
        Next


    End Sub


    Private Function GetProfile(folderName)
        Try
            Dim profile As New Webview2AppProfile With {
                .Version = "N/A",    ' 設定預設版本號
                .BuildDate = "N/A" ' 設定預設建置日期
            }

            Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "mySW2App", "appConfigs", "profile.json")
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

            Dim filePath As String = Path.Combine(AppInitModule.webview2AppDirectory, folderName, "mySW2App", "appConfigs", "appConfigs.json")
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

    Public Sub DirectoryCopy(sourceDir As String, destDir As String, copySubDirs As Boolean)
        Dim dir As DirectoryInfo = New DirectoryInfo(sourceDir)
        Dim dirs As DirectoryInfo() = dir.GetDirectories()

        If Not Directory.Exists(destDir) Then
            Directory.CreateDirectory(destDir)
        End If

        Dim files As FileInfo() = dir.GetFiles()
        For Each file As FileInfo In files
            Dim tempPath As String = Path.Combine(destDir, file.Name)
            file.CopyTo(tempPath, False)
        Next

        If copySubDirs Then
            For Each subdir As DirectoryInfo In dirs
                Dim tempPath As String = Path.Combine(destDir, subdir.Name)
                DirectoryCopy(subdir.FullName, tempPath, copySubDirs)
            Next
        End If
    End Sub

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
