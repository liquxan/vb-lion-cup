Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, s As Integer
        For i = 0 To TextBox1.Text.Length - 1
            s += Asc(TextBox1.Text.Substring(i, 1))
        Next
        TextBox2.Text = Format(s / Len(TextBox1.Text), ".000")
    End Sub
End Class
