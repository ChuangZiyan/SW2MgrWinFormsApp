Imports System.IO
Imports System.IO.Pipes

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


End Module
