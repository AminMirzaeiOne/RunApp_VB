﻿Module Menu
    Public Sub DrawAll()
        Console.OutputEncoding = System.Text.Encoding.UTF8
        DrawNotepad()
        DrawPaint()
        DrawCalculator()
        DrawCmera()
        DrawExplorer()
    End Sub

    Public Sub DrawNotepad()
        Console.ForegroundColor = ConsoleColor.Magenta
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
        Dim top As Byte = 7
        Dim left As Byte = 40
        Console.SetCursorPosition(left, top)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("   ╔═════════════════════════╗")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║      (Application)      ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║ ")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║       🎨 Paint          ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╔═══════╗   ╔═══════╗  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ║ Start ║   ║ Exit  ║  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╚═══════╝   ╚═══════╝  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ╚═════════════════════════╝")
        Console.ResetColor()
    End Sub

    Public Sub DrawCalculator()
        Dim top As Byte = 7
        Dim left As Byte = 80
        Console.SetCursorPosition(left, top)
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("   ╔═════════════════════════╗")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║      (Application)      ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║ ")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║       🧮 Calculator     ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╔═══════╗   ╔═══════╗  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ║ Start ║   ║ Exit  ║  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╚═══════╝   ╚═══════╝  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ╚═════════════════════════╝")
        Console.ResetColor()
    End Sub

    Public Sub DrawCmera()
        For index = 1 To 23
            Console.WriteLine()
        Next
        Dim top As Byte = 10
        Dim left As Byte = 0
        Console.SetCursorPosition(left, top)
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Write("   ╔═════════════════════════╗")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║      (Application)      ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║ ")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║       📷 Camera         ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╔═══════╗   ╔═══════╗  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ║ Start ║   ║ Exit  ║  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╚═══════╝   ╚═══════╝  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ╚═════════════════════════╝")
        Console.ResetColor()
    End Sub

    Public Sub DrawExplorer()
        For index = 1 To 12
            Console.WriteLine()
        Next
        Dim top As Byte = 7
        Dim left As Byte = 40
        Console.SetCursorPosition(left, top)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("   ╔═════════════════════════╗")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║         (System)        ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║ ")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║     📂 File Explorer    ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║                         ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║═════════════════════════║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╔═══════╗   ╔═══════╗  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ║ Start ║   ║ Exit  ║  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ║  ╚═══════╝   ╚═══════╝  ║")
        top = top + 1
        Console.SetCursorPosition(left, top)
        Console.Write("   ╚═════════════════════════╝")
        Console.ResetColor()
    End Sub
End Module
