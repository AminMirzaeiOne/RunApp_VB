﻿
Imports RunLibrary

Module Program

    Sub Main()
        Menu.DrawAll()
        'Dim r As Run = New Run()
        r.SelectApp = Run.Apps.MicrosoftStore
        Console.ReadKey()
    End Sub

End Module
