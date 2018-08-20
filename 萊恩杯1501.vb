Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i As Integer
        Dim str1 As String = ""
        Dim mu() As Integer = {2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 24, 25, 27, 28, 30, 32, 35, 36, 40, 42, 45, 48, 49, 54, 56, 63, 64, 72, 81}
        n = TextBox1.Text
        For i = 0 To UBound(mu, 1)
            If mu(i) Mod 10 = n Or mu(i) / 10 = n Then
                str1 &= mu(i) & " "
            End If
        Next
        TextBox2.Text = str1
    End Sub
End Class
