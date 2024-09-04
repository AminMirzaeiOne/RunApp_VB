Public Class TextBox
    Public Sub New(left As Integer, top As Integer, width As Integer, height As Integer)
        Console.SetCursorPosition(left, top)
        Console.Write("╔")
        For index = 0 To width
            Console.Write("═")
            If index = width Then
                Console.Write("╗")
            End If
        Next
    End Sub

    Public Property BackColor As ConsoleColor = ConsoleColor.Black
    Public Property ForeColor As ConsoleColor = ConsoleColor.White
    Public Property BorderColor As ConsoleColor = ConsoleColor.Blue
    Public Property HolderColor As ConsoleColor = ConsoleColor.Gray
    Public Property HolderText As String = "Enter Text"




End Class
