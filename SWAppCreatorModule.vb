Imports System.IO

Module SWAppCreatorModule
    Public Async Function DirectoryCopy(sourceDir As String, destDir As String, copySubDirs As Boolean) As Task
        Dim dir As DirectoryInfo = New DirectoryInfo(sourceDir)
        Dim dirs As DirectoryInfo() = dir.GetDirectories()

        If Not Directory.Exists(destDir) Then
            Directory.CreateDirectory(destDir)
        End If


        Dim files As FileInfo() = dir.GetFiles()
        For Each file As FileInfo In files
            Dim tempPath As String = Path.Combine(destDir, file.Name)
            file.CopyTo(tempPath, False)
            UpdateCreateNewSW2AppButtonProgress()
        Next

        If copySubDirs Then
            For Each subdir As DirectoryInfo In dirs
                Dim tempPath As String = Path.Combine(destDir, subdir.Name)
                Await DirectoryCopy(subdir.FullName, tempPath, copySubDirs)
            Next
        End If
    End Function



    Private copiedFiles As Integer = 0
    Public totalFiles As Integer = 0

    Private Sub UpdateCreateNewSW2AppButtonProgress()
        copiedFiles += 1
        Dim progressPercent As Integer = CInt((copiedFiles / totalFiles) * 100)
        Form1.CreateNewSW2App_Button.Text = $"{progressPercent}%"
    End Sub

    Public Function GetTotalFiles(dir As String) As Integer
        Dim count As Integer = 0
        For Each filePath As String In Directory.GetFiles(dir)
            count += 1
        Next
        For Each subDir As String In Directory.GetDirectories(dir)
            Dim dirName As String = New DirectoryInfo(subDir).Name
            count += GetTotalFiles(subDir)
        Next
        Return count
    End Function


End Module
