Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As New AB
        s.add()
        s.divide()
    End Sub
End Class
Public MustInherit Class abstractclass
    Public MustOverride Function add() As Integer
    Public MustOverride Function divide() As Integer
End Class
Public Class AB
    Inherits abstractclass
    Dim x, y As UInteger
    Public Overrides Function add() As Integer
        x = 12
        y = 23
        MessageBox.Show("The sum is " & x + y)
    End Function
    Public Overrides Function divide() As Integer
        x = 12
        y = 23
        MessageBox.Show("The division is " & x / y)
    End Function
End Class