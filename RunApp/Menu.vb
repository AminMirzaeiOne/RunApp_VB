Module Menu
    Public Sub Draw()
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Console.ForegroundColor = ConsoleColor.Blue
        Console.SetCursorPosition(35, 0)
        Console.WriteLine("---------------- Start and Exit Apps  ----------------")
        Console.SetCursorPosition(0, 7)
        Console.ResetColor()
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
    End Sub
End Module
