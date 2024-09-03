
Imports RunLibrary

Module Program

    Sub Main()
        Dim r As Run = New Run()
        r.SelectApp = Run.Apps.FileExplorer
        r.Exited()
        Console.ReadKey()
    End Sub

End Module
