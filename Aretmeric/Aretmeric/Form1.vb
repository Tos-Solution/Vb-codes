Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ob1 As New arithmetic
        ob1.add()
        ob1.mul()
        ob1.subt()
        ob1.div()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ob2 As New relational
        ob2.rel()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ob3 As New logical
        ob3.log()
    End Sub
End Class
Public Class arithmetic
    Public Sub add()
        Dim a, b, c, d As Integer
        a = InputBox("Enter the value of A : ")
        b = InputBox("Enter the value of B : ")
        c = a + b
        d = CInt(c)
        MessageBox.Show("The Addition of two numbers is : " & d)
    End Sub
    Public Sub subt()
        Dim a, b, c, d As Integer
        a = InputBox("Enter the value of A : ")
        b = InputBox("Enter the value of B : ")
        c = a - b
        d = CInt(c)
        MessageBox.Show("The Subtraction of two numbers is : " & d)
    End Sub
    Public Sub mul()
        Dim a, b, c, d As Double
        a = InputBox("Enter the value of A : ")
        b = InputBox("Enter the value of B : ")
        c = a * b
        d = CDbl(c)
        MessageBox.Show("The Multiplication of two numbers is : " & d)
    End Sub
    Public Sub div()
        Dim a, b, c, d As Double
        a = InputBox("Enter the value of A : ")
        b = InputBox("Enter the value of B : ")
        c = a / b
        d = CDbl(c)
        MessageBox.Show("The Division of two numbers is : " & d)
    End Sub
End Class
Public Class relational
    Public Sub rel()
        Dim a, b, c, d As Integer
        a = InputBox("Enter the value of A : ")
        b = InputBox("Enter the value of B : ")
        c = CInt(a)
        d = CInt(b)
        If (c > d) Then
            MessageBox.Show("The value C is greater than D.")
        Else
            MessageBox.Show("The value D is greater than C.")
        End If
    End Sub
End Class
Public Class logical
    Public Sub log()
        Dim age, marks As Integer
        Dim name As String
        name = InputBox("Enter the Name of the person")
        age = InputBox("Enter the Age of person")
        marks = InputBox("Enter the percentage of the student")
        If (age >= 18 And marks > 75) Then
            MessageBox.Show("You have Qualified for Exam.")
        Else
            MessageBox.Show("Sorry! You didn't qualify for Exam.")
        End If
    End Sub
End Class