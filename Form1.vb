Public Class Form1
    Private Sub RevealAppSourceFolder_Button_Click(sender As Object, e As EventArgs) Handles RevealAppSourceFolder_Button.Click
        Try
            Process.Start("explorer.exe", AppInitModule.webview2AppSourceDirectory)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppInitModule.InitializeMainApp()
    End Sub
End Class
