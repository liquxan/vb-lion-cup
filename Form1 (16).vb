Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, y, i, j, x, x1, y1, y2 As Integer
        Dim str As String = ""
        n = TextBox1.Text
        If ((n Mod 2 = 0) Or (n > 20 Or n < 1)) Then
            TextBox2.Text = "N 需大於 1 且 N 為奇數"
        End If
        Dim a(n, n) As Integer
        For i = 1 To n
            For j = 1 To n
                a(i, j) = 0
            Next
        Next
        x = (n - 1) / 2
        y = 0
        y1 = n - 1
        a(x, y) = 1
        For i = 2 To n * n
            x1 = (x + 1) Mod n
            y2 = (y + y1) Mod n
            If a(x1, y2) = 0 Then
                x = x1
                y = y2
            Else
                y = y + 1
            End If
            a(x, y) = i
        Next
        For i = 0 To n - 1
            For j = 0 To n - 1
                str &= a(j, i) & "  "
            Next
            str &= vbCrLf
        Next
        TextBox2.Text = str
    End Sub
End Class
