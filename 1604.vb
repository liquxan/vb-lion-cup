Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, x As Double
        Dim a1, a2 As Double
        Dim s As Integer = 1000000
        n = TextBox1.Text
        x = 360 / n
        a1 = 2 * Math.Sin(x * Math.PI / 180) * n
        a1 = Math.Floor(a1 * s) / s
        TextBox2.Text = Format(a1, "#.000000")
        a2 = n * Math.Sin(Math.PI * x / 180) / 2
        a2 = Math.Floor(a2 * s) / s
        TextBox3.Text = Format(a2, "#.000000")
    End Sub
End Class
