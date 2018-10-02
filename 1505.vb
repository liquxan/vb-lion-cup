Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = TextBox1.Text
        Dim min As Integer = Integer.MaxValue
        Dim s, k, minx As Integer
        For x = 1 To n
            s = 0
            For k = 1 To n
                s = s + k * Math.Abs(x - k)
            Next
            If s < min Then
                min = s
                minx = x
            End If
        Next
        TextBox2.Text = minx
        TextBox3.Text = min
    End Sub
End Class
