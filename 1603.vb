Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text
        Dim str1 As String = TextBox2.Text
        Dim a, b, i, j, k As Integer
        For i = 1 To 4
            If Mid(str, i, 1) = Mid(str1, i, 1) Then
                a += 1
            End If
        Next
        For j = 1 To 4
            For k = 1 To 4
                If Mid(str, k, 1) = Mid(str1, j, 1) And j <> k Then
                    b += 1
                End If
            Next
        Next
        TextBox3.Text = a & " A " & b & " B"
    End Sub
End Class
