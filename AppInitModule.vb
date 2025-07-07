Imports System.IO
Imports System.Runtime
Imports Newtonsoft.Json

Module AppInitModule


    ' app base 
    ' Public ReadOnly appBaseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

    ' AppDataDirectory
    Private ReadOnly appdata_path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    Public ReadOnly appDataFolder As String = IO.Path.Combine(appdata_path, "auxiliaryprogram")

    Public ReadOnly documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)


    ' 這是主控程式資料的路徑
    Public ReadOnly appBaseDirectory As String = Path.Combine(documentsPath, "auxiliaryprogram_mgr")
    Public ReadOnly appConfigFilePath As String = Path.Combine(appBaseDirectory, "appConfig.json")


    ' 這邊是來源程式資料的路徑
    Public ReadOnly sourceAppDirectory As String = Path.Combine(documentsPath, "auxiliaryprogram")


    Public webview2AppSourceDirectory As String






    ' 這是用來儲存 Webview2 應用程式的資料夾，要改成實際的路徑，還未完成!!!
    Public ReadOnly webview2AppDirectory As String = Path.Combine(appBaseDirectory, "Webview2App")




    Public Sub InitializeMainApp()
        InitializeDataDirectory()
        'MainFormController.UpdateSW2AppListView()
        InitAppConfigs()


        ReadSourceAppProfile()


    End Sub


    Public Sub InitializeDataDirectory()

        Try
            ' 初始化所有資料夾，把路徑放進去就會在程式啟動時候自動建立
            Dim myDirectories() As String = {
                        webview2AppDirectory,
                        appBaseDirectory
                }

            For Each myDir In myDirectories
                Debug.WriteLine(myDir)
                If Not Directory.Exists(myDir) Then
                    Directory.CreateDirectory(myDir)
                End If
            Next

        Catch ex As Exception

        End Try



    End Sub


    Public Sub InitAppConfigs()
        Try
            Dim myConfigs As AppConfigs = ReadAppConfigs()
            webview2AppSourceDirectory = myConfigs.AppSourceDirectory
            Form1.AppSourcePath_TextBox.Text = myConfigs.AppSourceDirectory


        Catch ex As Exception

        End Try
    End Sub


    Public Sub ReadSourceAppProfile()
        Try
            ' 這是用來讀取來源程式的設定檔

            Dim profile As New Webview2AppProfile With {
                .Version = "N/A",
                .BuildDate = "N/A",
                .UUID = "N/A"
            }

            Dim profile_path = Path.Combine(sourceAppDirectory, "appConfigs", "profile.json")

            If File.Exists(profile_path) Then

                ' 如果 profile.json 檔案存在，就讀取檔案並反序列化
                If File.Exists(profile_path) Then
                    Dim jsonString As String = File.ReadAllText(profile_path)
                    profile = JsonConvert.DeserializeObject(Of Webview2AppProfile)(jsonString)
                End If
                Form1.SourceSW2AppVersion_TextBox.Text = profile.Version
            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try

    End Sub




    Public Function ReadAppConfigs() As AppConfigs
        ' 這是用來讀取主控程式本身的設定
        Try
            ' 如果檔案存在就讀取 JSON

            If File.Exists(appConfigFilePath) Then
                Dim json As String = File.ReadAllText(appConfigFilePath)
                Return JsonConvert.DeserializeObject(Of AppConfigs)(json)
            Else
                ' 如果檔案不存在就建立預設值並寫入
                Dim defaultConfig As New AppConfigs With {
                .Version = "",
                .AppSourceDirectory = ""
            }

                Dim json As String = JsonConvert.SerializeObject(defaultConfig, Formatting.Indented)

                ' 確保目錄存在
                Dim folder = Path.GetDirectoryName(appConfigFilePath)
                If Not Directory.Exists(folder) Then
                    Directory.CreateDirectory(folder)
                End If

                File.WriteAllText(appConfigFilePath, json)
                Return defaultConfig
            End If

        Catch ex As Exception
            Debug.WriteLine(ex)
            Return New AppConfigs()
        End Try
    End Function



    Public Class AppConfigs
        Public Property Version As String
        Public Property AppSourceDirectory As String
    End Class


End Module
