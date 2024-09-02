Public Class Run

    Private appPath As String = ""
    Private appSelect As RunLibrary.Run.Apps
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
                    Me.appPath = "microsoft. windows. camera："
            End Select
        End Set
    End Property

    Public Sub Start()
        System.Diagnostics.Process.Start(appPath)
    End Sub
End Class
