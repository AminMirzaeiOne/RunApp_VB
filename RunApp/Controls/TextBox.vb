Imports System.ComponentModel

Public Enum Aligns
    Left
    Center
    Right
End Enum

Public Class TextBox

    Private leftControl As Integer
    Private topControl As Integer
    Private widthControl As Integer
    Private heightControl As Integer
    Private align As Aligns = Aligns.Left

    Public Sub New(left As Integer, top As Integer, width As Integer, height As Integer)
        Me.leftControl = left
        Me.topControl = top
        Me.widthControl = width
        Me.heightControl = height
        Console.SetBufferSize(Console.BufferWidth, Console.BufferHeight + 100)
        Console.SetCursorPosition(left, top)
        Dim wleft As Integer = 0
        Dim hleft As Integer = 0
        Console.ForegroundColor = BorderColor
        Console.Write("╔")
        For index = 0 To width
            Console.Write("═")
            If index = width Then
                wleft = Console.CursorLeft
                Console.Write("╗")
            End If
        Next

        Console.SetCursorPosition(left, top)
        Dim y As Integer = top
        For index = 0 To height
            y = y + 1
            Console.SetCursorPosition(left, y)
            Console.Write("║")
            If index = height Then
                hleft = Console.CursorTop
            End If
        Next

        Console.SetCursorPosition(wleft, top)
        Dim y2 As Integer = top
        For index = 0 To height
            y2 = y2 + 1
            Console.SetCursorPosition(wleft, y2)
            Console.Write("║")
        Next

        Console.SetCursorPosition(left, hleft)
        Console.Write("╚")
        For index = 0 To width
            Console.Write("═")
            If index = width Then
                Console.Write("╝")
            End If
        Next

    End Sub

    Public Sub EnterText()

    End Sub

    Public Property BackColor As ConsoleColor = ConsoleColor.Black
    Public Property ForeColor As ConsoleColor = ConsoleColor.White
    Public Property BorderColor As ConsoleColor = ConsoleColor.Blue
    Public Property HolderColor As ConsoleColor = ConsoleColor.Gray
    Public Property HolderText As String = "Enter Text"
    Public Property MaxLength As Byte = 150

    Public Property TextAlign As Aligns
        Get
            Return Me.align
        End Get
        Set(ByVal value As Aligns)
            Me.align = value
            Select Case value
                Case Aligns.Left
                    Console.SetCursorPosition(Me.leftControl + 1, Me.topControl + Me.heightControl)
                    Console.Write("Hello World")
                Case Aligns.Center

                Case Aligns.Right

            End Select
        End Set
    End Property




End Class
