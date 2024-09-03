Imports CMDExecute
Public Class Run

    Private appPath As String = ""
    Private appSelect As RunLibrary.Run.Apps
    Private executor As Executor = New Executor()

    Public Enum Apps
        Notepad
        Paint
        Calculator
        Camera
        Terminal
        PowerShell
        Edge
        Chrome
        FileExplorer
        MicrosoftStore
        Settings
        ControlPanel
    End Enum

    Public Property SelectApp As RunLibrary.Run.Apps
        Get
            Return appSelect
        End Get
        Set
            appSelect = Value
            Select Case Value
                Case Apps.Notepad
                    Me.appPath = "notepad.exe"
                Case Apps.Paint
                    Me.appPath = "mspaint"
                Case Apps.Calculator
                    Me.appPath = "calc"
                Case Apps.Camera
                    Me.appPath = "microsoft.windows.camera"
                Case Apps.FileExplorer
                    Me.appPath = "explorer"
                Case Apps.ControlPanel
                    Me.appPath = "control panel"
                Case Apps.Chrome
                    Me.appPath = "chrome"
                Case Apps.Edge
                    Me.appPath = "msedge"
                Case Apps.PowerShell
                    Me.appPath = "powershell"
                Case Apps.Terminal
                    Me.appPath = "cmd"
                Case Apps.Settings
                    Me.appPath = "ms-settings:"
                Case Apps.MicrosoftStore
                    Me.appPath = "ms-windows-store:"
            End Select
        End Set
    End Property

    Public Sub Start()
        Me.executor.ExecuteAsync("start " + appPath)
    End Sub

    Public Sub Exited()
        Me.executor.ExecuteAsync($"taskkill /IM {appPath} /f")
    End Sub

    Public Function GetProgrammerInfo() As String
        Return "Programmer : Amin Mirzaei - Github(Username) : AminMirzaeiOne"
    End Function

End Class
