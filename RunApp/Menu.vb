Module Menu
    Public Sub DrawAll()
        DrawNotepad()
        DrawPaint()
        DrawCalculator()
    End Sub

    Public Sub DrawNotepad()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.SetCursorPosition(35, 0)
        Console.WriteLine("---------------- Start and Exit Apps  ----------------")
        Console.SetCursorPosition(0, 7)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("   ╔═════════════════════════╗")
        Console.WriteLine("   ║      (Application)      ║")
        Console.WriteLine("   ║═════════════════════════║")
        Console.WriteLine("   ║                         ║ ")
        Console.WriteLine("   ║       🗒️ Notepad        ║")
        Console.WriteLine("   ║                         ║")
        Console.WriteLine("   ║═════════════════════════║")
        Console.WriteLine("   ║  ╔═══════╗   ╔═══════╗  ║")
        Console.WriteLine("   ║  ║ Start ║   ║ Exit  ║  ║")
        Console.WriteLine("   ║  ╚═══════╝   ╚═══════╝  ║")
        Console.WriteLine("   ╚═════════════════════════╝")
        Console.ResetColor()
    End Sub

    Public Sub DrawPaint()
        Dim x As Byte = 7
        Console.SetCursorPosition(40, x)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("   ╔═════════════════════════╗")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║      (Application)      ║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║═════════════════════════║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║                         ║ ")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║       🎨 Paint          ║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║                         ║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║═════════════════════════║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║  ╔═══════╗   ╔═══════╗  ║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║  ║ Start ║   ║ Exit  ║  ║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ║  ╚═══════╝   ╚═══════╝  ║")
        x = x + 1
        Console.SetCursorPosition(40, x)
        Console.Write("   ╚═════════════════════════╝")
        Console.ResetColor()
    End Sub

    Public Sub DrawCalculator()
        Dim x As Byte = 7
        Console.SetCursorPosition(60, x)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("   ╔═════════════════════════╗")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║      (Application)      ║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║═════════════════════════║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║                         ║ ")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║       🎨 Paint          ║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║                         ║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║═════════════════════════║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║  ╔═══════╗   ╔═══════╗  ║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║  ║ Start ║   ║ Exit  ║  ║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ║  ╚═══════╝   ╚═══════╝  ║")
        x = x + 1
        Console.SetCursorPosition(60, x)
        Console.Write("   ╚═════════════════════════╝")
        Console.ResetColor()
    End Sub
End Module
