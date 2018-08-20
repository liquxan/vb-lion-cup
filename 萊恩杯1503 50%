Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i As Integer
        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim j As String
        j = TextBox3.Text
        n = TextBox1.Text
        Do While n > 0
            i = CStr(n Mod 16)
            Select Case i
                Case "10"
                    i = "A"
                Case "11"
                    i = "B"
                Case "12"
                    i = "C"
                Case "13"
                    i = "D"
                Case "14"
                    i = "E"
                Case "15"
                    i = "F"
            End Select
            str1 = i & str1
            n = n / 16
        Loop

    End Sub
End Class
