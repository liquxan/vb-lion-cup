Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x, i, y As Integer
        x = TextBox1.Text
        If x >= 10000 Or x <= 0 Then
            End
        End If
        y = x * x + x + 41
        For i = 2 To y - 1
            If y Mod i = 0 Then
                TextBox2.Text = "這是非質數"
            Else
                TextBox2.Text = "這是質數"
            End If
        Next
    End Sub
End Class
