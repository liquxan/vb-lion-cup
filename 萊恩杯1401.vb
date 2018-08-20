Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f(20) As Integer
        Dim n, i As Integer
        n = TextBox1.Text
        If n >= 20 Or n <= 1 Then
            End
        End If
        f(1) = 3
        f(2) = 5
        If n >= 3 Then
            For i = 3 To n
                f(i) = 3 * f(i - 1) - f(i - 2)
            Next
        End If
        TextBox2.Text = f(n)
    End Sub
End Class
