Imports System.IO

Module UpdaterModule

    ' 定義不需要更新的資料夾名稱
    Private ReadOnly ExcludedFolders As String() = {"myAssets"}

    ' 定義不需要更新的檔案名稱或副檔名
    Private ReadOnly ExcludedFiles As String() = {"appConfigs.json", "scriptListviewData.txt"}

    Public totalFiles As Integer
    Public progressCounter As Integer = 0


    Public Sub UpdateFiles(sourceDir As String, targetDir As String)
        Try

            If Not Directory.Exists(targetDir) Then
                Directory.CreateDirectory(targetDir)
            End If

            For Each sourceFilePath As String In Directory.GetFiles(sourceDir)
                Dim fileName As String = Path.GetFileName(sourceFilePath)

                If ExcludedFiles.Contains(fileName) Then
                    'Debug.WriteLine($"跳過檔案: {fileName}")
                    Continue For
                End If

                Dim targetFilePath As String = Path.Combine(targetDir, fileName)
                File.Copy(sourceFilePath, targetFilePath, True)

                UpdateProgress()
            Next

            For Each sourceSubDir As String In Directory.GetDirectories(sourceDir)
                Dim dirName As String = New DirectoryInfo(sourceSubDir).Name

                If ExcludedFolders.Contains(dirName) Then
                    'Debug.WriteLine($"跳過資料夾: {dirName}")
                    Continue For
                End If

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
            If ExcludedFiles.Contains(Path.GetFileName(filePath)) Then
                Continue For
            End If
            count += 1
        Next
        For Each subDir As String In Directory.GetDirectories(dir)
            Dim dirName As String = New DirectoryInfo(subDir).Name
            If ExcludedFolders.Contains(dirName) Then
                Continue For
            End If
            count += GetTotalFiles(subDir)
        Next
        Return count
    End Function

    Public Sub UpdateProgress()

        progressCounter += 1
        Dim percentageProgress = progressCounter / totalFiles * 100
        'Debug.WriteLine(percentageProgress)
        Form1.AppUpdating_ProgressBar.Value = CInt(percentageProgress)
        Form1.UpdatingProgressPercent_Label.Text = Math.Round(percentageProgress, 2) & "%"
        'Debug.WriteLine(Math.Round(percentageProgress, 2))
        Application.DoEvents() ' update UI

    End Sub

End Module
