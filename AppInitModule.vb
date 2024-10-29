Imports System.IO

Module AppInitModule
    ' app base 
    Public ReadOnly appBaseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
    Public ReadOnly webview2AppSourceDirectory As String = Path.Combine(appBaseDirectory, "Webview2AppSource")

    Public Sub InitializeMainApp()
        InitializeDataDirectory()

    End Sub


    Public Sub InitializeDataDirectory()

        ' 初始化所有資料夾，把路徑放進去就會在程式啟動時候自動建立
        Dim myDirectories() As String = {
                webview2AppSourceDirectory
        }

        For Each myDir In myDirectories
            If Not Directory.Exists(myDir) Then
                Directory.CreateDirectory(myDir)
            End If
        Next

    End Sub





End Module
