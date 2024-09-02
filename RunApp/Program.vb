Module Program

    Sub Main()
        Dim run1 As RunLibrary.Run = New RunLibrary.Run()
        run1.SelectApp = RunLibrary.Run.Apps.Notepad
        run1.Start()
    End Sub

End Module
