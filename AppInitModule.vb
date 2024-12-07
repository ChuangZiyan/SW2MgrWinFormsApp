Imports System.IO
Imports Newtonsoft.Json

Module AppInitModule
    ' app base 
    Public ReadOnly appBaseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
    Public ReadOnly webview2AppSourceDirectory As String = Path.Combine(appBaseDirectory, "Webview2AppSource")
    Public ReadOnly webview2AppDirectory As String = Path.Combine(appBaseDirectory, "Webview2App")

    Public Sub InitializeMainApp()
        InitializeDataDirectory()
        'MainFormController.UpdateSW2AppListView()
        ReadSourceAppProfile()

    End Sub


    Public Sub InitializeDataDirectory()

        ' 初始化所有資料夾，把路徑放進去就會在程式啟動時候自動建立
        Dim myDirectories() As String = {
                webview2AppSourceDirectory,
                webview2AppDirectory
        }

        For Each myDir In myDirectories
            If Not Directory.Exists(myDir) Then
                Directory.CreateDirectory(myDir)
            End If
        Next

    End Sub


    Public Sub ReadSourceAppProfile()
        Try
            Dim profile As New Webview2AppProfile With {
                .Version = "N/A",
                .BuildDate = "N/A",
                .UUID = "N/A"
            }

            Dim filePath As String = Path.Combine(AppInitModule.webview2AppSourceDirectory, "appConfigs", "profile.json")

            ' 如果 profile.json 檔案存在，就讀取檔案並反序列化
            If File.Exists(filePath) Then
                Dim jsonString As String = File.ReadAllText(filePath)
                profile = JsonConvert.DeserializeObject(Of Webview2AppProfile)(jsonString)
            End If

            Form1.SourceSW2AppVersion_TextBox.Text = profile.Version

        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try

    End Sub



End Module
