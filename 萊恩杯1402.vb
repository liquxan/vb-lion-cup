Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        x = TextBox1.Text
        If x = 0 Then
            TextBox2.Text = 50 & "元"
        End If
        x -= 10
        If x = 0 Then
            TextBox2.Text = 50 & "元"
        End If

        If x > 10 And x < 100 Then
            x *= 60
            x = x / 10
            TextBox2.Text = x + 50 & "元"
        ElseIf x > 100 And x < 200 Then
            x *= 60
            x = x / 15
            TextBox2.Text = x + 50 & "元"
        ElseIf x > 200 And x < 500 Then
            x *= 60
            x = x / 20
            TextBox2.Text = x + 50 & "元"
        ElseIf x > 500 Then
            x *= 60
            x = x / 30
            TextBox2.Text = x + 50 & "元"
        End If

    End Sub
End Class
