Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, x As Integer
        Dim str1 As String = ""
        n = TextBox1.Text
        If n < 2 And n > 1000000000 Then
            MsgBox("輸入值不再範圍內,請重新輸入")
        Else
            For i = 2 To n
                Do While n Mod i = 0
                    n /= i
                    x += 1
                Loop
            Next
        End If
        TextBox2.Text = x
    End Sub
End Class
