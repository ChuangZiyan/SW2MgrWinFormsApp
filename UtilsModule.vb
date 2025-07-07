Imports System.IO
Imports System.IO.Pipes
Imports Newtonsoft.Json

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


    Public Async Function Delay_msec(msec As Integer) As Task
        Await Task.Delay(msec)
    End Function


    Public Sub SendPipeCommandTask(pipeName As String, command As String)

        Task.Run(Function()

                     Try
                         Using pipeClient As New NamedPipeClientStream(".", pipeName, PipeDirection.Out)
                             Debug.WriteLine($"pipeName:{pipeName} cmd:{command}")
                             ' 連接收指令的地方
                             pipeClient.Connect(2000) ' 這是多久沒回應就取消的預設值
                             Using writer As New StreamWriter(pipeClient)
                                 writer.AutoFlush = True
                                 writer.WriteLine(command)
                             End Using
                         End Using
                         Return True
                     Catch ex As Exception
                         Debug.WriteLine("send pipe cmd failed: " & ex.Message)
                         Return False
                     End Try
                 End Function)
    End Sub



    Public Sub SaveAppConfigs(configs As AppConfigs, filePath As String)
        Try
            Dim json As String = JsonConvert.SerializeObject(configs, Formatting.Indented)
            File.WriteAllText(filePath, json)
        Catch ex As Exception
            MessageBox.Show("儲存設定檔失敗：" & ex.Message)
        End Try
    End Sub


    Public Function ReadAppConfigs(filePath As String) As AppConfigs
        Try
            If File.Exists(filePath) Then
                Dim json As String = File.ReadAllText(filePath)
                Return JsonConvert.DeserializeObject(Of AppConfigs)(json)
            Else
                ' 若檔案不存在就回傳預設值
                Return New AppConfigs()
            End If
        Catch ex As Exception
            MessageBox.Show("讀取設定檔失敗：" & ex.Message)
            Return New AppConfigs()
        End Try
    End Function





End Module
