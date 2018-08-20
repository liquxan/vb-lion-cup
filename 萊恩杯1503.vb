Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, i, s As Integer
        Dim str1 As String = ""
        Dim j As String = ""
        j = TextBox2.Text
        n = TextBox1.Text
        Do While (n > 0)
            i = CStr(n Mod 16)
            str1 = i & "" & str1
            n \= 16
        Loop
        str1 = Replace(str1, "10", "A")
        str1 = Replace(str1, "11", "B")
        str1 = Replace(str1, "12", "C")
        str1 = Replace(str1, "13", "D")
        str1 = Replace(str1, "14", "E")
        str1 = Replace(str1, "15", "F")

        For i = 1 To Len(str1)
            If (Mid(str1, i, 1) = j) Then
                s += 1
            End If
        Next
        TextBox3.Text = s
    End Sub
End Class
