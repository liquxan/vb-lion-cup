Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, s As Integer
        Dim Ti, T0 As Double
        T0 = TextBox1.Text
        s = TextBox2.Text
        For i = 0 To s
            Ti = T0 + i * 3.14159
            T0 = Ti
        Next
        TextBox3.Text = Format(T0, ".00000")
    End Sub
End Class
