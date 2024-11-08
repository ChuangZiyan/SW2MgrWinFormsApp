Imports System.IO

Module UtilsModule
    Function IsProcessRunning(ByVal pid As Integer) As Boolean
        Try
            Dim proc As Process = Process.GetProcessById(pid)
            ' 如果能取得進程，表示存在
            Return True
        Catch ex As ArgumentException
            ' 如果拋出 ArgumentException，表示進程不存在
            Return False
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

    Public Async Function Delay_msec(msec As Integer) As Task
        Await Task.Delay(msec)
    End Function

End Module
