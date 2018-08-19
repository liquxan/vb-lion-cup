Public Class Form1
    Function f(ByVal n)
        If n = 2 Then
            Return 5
        ElseIf n = 1 Then
            Return 3
        ElseIf n >= 3 Then
            Return 3 * f(n - 1) - f(n - 2)
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim n, x As Integer
        n = TextBox1.Text
        TextBox2.Text = f(n)
    End Sub
End Class
