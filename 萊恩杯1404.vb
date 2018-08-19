Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        Dim j As String
        Dim str1 As String
        Dim str2 As String = ""
        j = Len(TextBox1.Text)
        str1 = TextBox1.Text
        While j > 0
            str2 &= Mid(str1, j, 1)
            j -= 1
        End While
        If str1 = str2 Then
            TextBox2.Text = "是迴文"
        Else
            TextBox2.Text = "非迴文"
        End If
    End Sub
End Class
