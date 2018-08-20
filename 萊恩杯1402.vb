Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x, n, s As Integer
        Dim str1 As String = ""
        x = TextBox1.Text
        If x > 0 And x < 10 Then
            TextBox2.Text = 50 & "元"
        End If
        Select Case x
            Case 10 To 100
                x *= 60
                n = x / 10
                n += 50
                TextBox2.Text = n & "元"
            Case 101 To 200
                x -= 100
                x *= 60
                n = x / 15
                n = n + 590
                TextBox2.Text = n & "元"
            Case 201 To 500
                x -= 200
                x *= 60
                n = x / 20
                n = n + 990
                TextBox2.Text = n & "元"
            Case x > 500
                x -= 500
                x *= 60
                n = x / 30
                n = n + 590 + 990 + 600
                TextBox2.Text = n & "元"
        End Select


    End Sub
End Class
