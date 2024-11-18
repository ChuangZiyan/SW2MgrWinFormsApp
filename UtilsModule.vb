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


    Public Async Function Delay_msec(msec As Integer) As Task
        Await Task.Delay(msec)
    End Function

End Module
