Imports System.IO

Module SWAppCreatorModule

    Public totalFiles As Integer
    Public progressCounter As Integer = 0

    Public Sub UpdateFiles(sourceDir As String, targetDir As String)
        Try

            If Not Directory.Exists(targetDir) Then
                Directory.CreateDirectory(targetDir)
            End If

            For Each sourceFilePath As String In Directory.GetFiles(sourceDir)
                Dim fileName As String = Path.GetFileName(sourceFilePath)

                Dim targetFilePath As String = Path.Combine(targetDir, fileName)
                File.Copy(sourceFilePath, targetFilePath, True)

                UpdateProgress()
            Next

            For Each sourceSubDir As String In Directory.GetDirectories(sourceDir)
                Dim dirName As String = New DirectoryInfo(sourceSubDir).Name

                Dim targetSubDir As String = Path.Combine(targetDir, dirName)
                UpdateFiles(sourceSubDir, targetSubDir)
            Next

        Catch ex As Exception
            Debug.WriteLine($"錯誤: {ex.Message}")
        End Try
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

    Private Sub UpdateProgress()
        progressCounter += 1
        Dim progressPercent As Integer = CInt((progressCounter / totalFiles) * 100)
        Form1.CreateNewSW2App_Button.Text = $"{progressPercent}%"
        Application.DoEvents() ' update UI
    End Sub


End Module
