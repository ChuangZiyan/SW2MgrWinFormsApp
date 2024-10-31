<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CreateNewSW2App_Button = New Button()
        DeleteSelectedSW2AppFolder_Button = New Button()
        LaunchSeletedSW2App_Button = New Button()
        TerminateSW2AppByPId_Button = New Button()
        UpdateSW2AppListView_Button = New Button()
        SW2App_ListView = New ListView()
        SW2App_PId_ColumnHeader = New ColumnHeader()
        SW2App_FolderName_ColumnHeader = New ColumnHeader()
        SW2App_Version_ColumnHeader = New ColumnHeader()
        SW2App_Status_ColumnHeader = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        Label1 = New Label()
        NewSW2FolderName_TextBox = New TextBox()
        Label2 = New Label()
        Button6 = New Button()
        SourceSW2AppVersion_TextBox = New TextBox()
        RevealAppSourceFolder_Button = New Button()
        Button8 = New Button()
        Button9 = New Button()
        SuspendLayout()
        ' 
        ' CreateNewSW2App_Button
        ' 
        CreateNewSW2App_Button.Location = New Point(410, 57)
        CreateNewSW2App_Button.Name = "CreateNewSW2App_Button"
        CreateNewSW2App_Button.Size = New Size(94, 29)
        CreateNewSW2App_Button.TabIndex = 1
        CreateNewSW2App_Button.Text = "新增"
        CreateNewSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' DeleteSelectedSW2AppFolder_Button
        ' 
        DeleteSelectedSW2AppFolder_Button.Location = New Point(510, 57)
        DeleteSelectedSW2AppFolder_Button.Name = "DeleteSelectedSW2AppFolder_Button"
        DeleteSelectedSW2AppFolder_Button.Size = New Size(94, 29)
        DeleteSelectedSW2AppFolder_Button.TabIndex = 2
        DeleteSelectedSW2AppFolder_Button.Text = "刪除"
        DeleteSelectedSW2AppFolder_Button.UseVisualStyleBackColor = True
        ' 
        ' LaunchSeletedSW2App_Button
        ' 
        LaunchSeletedSW2App_Button.Location = New Point(12, 506)
        LaunchSeletedSW2App_Button.Name = "LaunchSeletedSW2App_Button"
        LaunchSeletedSW2App_Button.Size = New Size(94, 29)
        LaunchSeletedSW2App_Button.TabIndex = 3
        LaunchSeletedSW2App_Button.Text = "啟動"
        LaunchSeletedSW2App_Button.UseVisualStyleBackColor = True
        ' 
        ' TerminateSW2AppByPId_Button
        ' 
        TerminateSW2AppByPId_Button.Location = New Point(112, 506)
        TerminateSW2AppByPId_Button.Name = "TerminateSW2AppByPId_Button"
        TerminateSW2AppByPId_Button.Size = New Size(94, 29)
        TerminateSW2AppByPId_Button.TabIndex = 4
        TerminateSW2AppByPId_Button.Text = "關閉所選"
        TerminateSW2AppByPId_Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateSW2AppListView_Button
        ' 
        UpdateSW2AppListView_Button.Location = New Point(610, 57)
        UpdateSW2AppListView_Button.Name = "UpdateSW2AppListView_Button"
        UpdateSW2AppListView_Button.Size = New Size(94, 29)
        UpdateSW2AppListView_Button.TabIndex = 5
        UpdateSW2AppListView_Button.Text = "重新整理"
        UpdateSW2AppListView_Button.UseVisualStyleBackColor = True
        ' 
        ' SW2App_ListView
        ' 
        SW2App_ListView.Columns.AddRange(New ColumnHeader() {SW2App_PId_ColumnHeader, SW2App_FolderName_ColumnHeader, SW2App_Version_ColumnHeader, SW2App_Status_ColumnHeader, ColumnHeader5})
        SW2App_ListView.FullRowSelect = True
        SW2App_ListView.Location = New Point(12, 92)
        SW2App_ListView.Name = "SW2App_ListView"
        SW2App_ListView.Size = New Size(692, 408)
        SW2App_ListView.TabIndex = 6
        SW2App_ListView.UseCompatibleStateImageBehavior = False
        SW2App_ListView.View = View.Details
        ' 
        ' SW2App_PId_ColumnHeader
        ' 
        SW2App_PId_ColumnHeader.Text = "PID"
        SW2App_PId_ColumnHeader.Width = 80
        ' 
        ' SW2App_FolderName_ColumnHeader
        ' 
        SW2App_FolderName_ColumnHeader.Text = "資料夾名稱"
        SW2App_FolderName_ColumnHeader.Width = 150
        ' 
        ' SW2App_Version_ColumnHeader
        ' 
        SW2App_Version_ColumnHeader.Text = "版本"
        SW2App_Version_ColumnHeader.Width = 150
        ' 
        ' SW2App_Status_ColumnHeader
        ' 
        SW2App_Status_ColumnHeader.Text = "狀態"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "保留"
        ColumnHeader5.Width = 150
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 19)
        Label1.TabIndex = 7
        Label1.Text = "資料夾名稱: "
        ' 
        ' NewSW2FolderName_TextBox
        ' 
        NewSW2FolderName_TextBox.Location = New Point(109, 57)
        NewSW2FolderName_TextBox.Name = "NewSW2FolderName_TextBox"
        NewSW2FolderName_TextBox.Size = New Size(295, 27)
        NewSW2FolderName_TextBox.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 19)
        Label2.TabIndex = 0
        Label2.Text = "來源版本 : "
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(510, 17)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 1
        Button6.Text = "更新所選"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' SourceSW2AppVersion_TextBox
        ' 
        SourceSW2AppVersion_TextBox.Location = New Point(109, 17)
        SourceSW2AppVersion_TextBox.Name = "SourceSW2AppVersion_TextBox"
        SourceSW2AppVersion_TextBox.ReadOnly = True
        SourceSW2AppVersion_TextBox.Size = New Size(295, 27)
        SourceSW2AppVersion_TextBox.TabIndex = 2
        ' 
        ' RevealAppSourceFolder_Button
        ' 
        RevealAppSourceFolder_Button.Location = New Point(410, 17)
        RevealAppSourceFolder_Button.Name = "RevealAppSourceFolder_Button"
        RevealAppSourceFolder_Button.Size = New Size(94, 29)
        RevealAppSourceFolder_Button.TabIndex = 3
        RevealAppSourceFolder_Button.Text = "打開"
        RevealAppSourceFolder_Button.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(610, 506)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 29)
        Button8.TabIndex = 10
        Button8.Text = "全部關閉"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(610, 17)
        Button9.Name = "Button9"
        Button9.Size = New Size(94, 29)
        Button9.TabIndex = 11
        Button9.Text = "全部更新"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1118, 611)
        Controls.Add(Button9)
        Controls.Add(RevealAppSourceFolder_Button)
        Controls.Add(Button8)
        Controls.Add(SourceSW2AppVersion_TextBox)
        Controls.Add(Button6)
        Controls.Add(NewSW2FolderName_TextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SW2App_ListView)
        Controls.Add(UpdateSW2AppListView_Button)
        Controls.Add(TerminateSW2AppByPId_Button)
        Controls.Add(LaunchSeletedSW2App_Button)
        Controls.Add(DeleteSelectedSW2AppFolder_Button)
        Controls.Add(CreateNewSW2App_Button)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CreateNewSW2App_Button As Button
    Friend WithEvents DeleteSelectedSW2AppFolder_Button As Button
    Friend WithEvents LaunchSeletedSW2App_Button As Button
    Friend WithEvents TerminateSW2AppByPId_Button As Button
    Friend WithEvents UpdateSW2AppListView_Button As Button
    Friend WithEvents SW2App_ListView As ListView
    Friend WithEvents SW2App_PId_ColumnHeader As ColumnHeader
    Friend WithEvents SW2App_FolderName_ColumnHeader As ColumnHeader
    Friend WithEvents SW2App_Version_ColumnHeader As ColumnHeader
    Friend WithEvents SW2App_Status_ColumnHeader As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents NewSW2FolderName_TextBox As TextBox
    Friend WithEvents SourceSW2AppVersion_TextBox As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RevealAppSourceFolder_Button As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button

End Class
