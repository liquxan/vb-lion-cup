Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
        Dim l1m, l2m As Double
        x1 = TextBox1.Text : y1 = TextBox5.Text
        x2 = TextBox2.Text : y2 = TextBox6.Text
        x3 = TextBox3.Text : y3 = TextBox7.Text
        x4 = TextBox4.Text : y4 = TextBox8.Text
        l1m = (y1 - y2) / (x1 - x2)
        l2m = (y3 - y4) / (x3 - x4)
        If l1m = l2m Then
            TextBox9.Text = "兩線平行"
        ElseIf l1m * l2m = -1 Then
            TextBox9.Text = "兩線垂直"
        Else
            TextBox9.Text = "兩者皆非"
        End If
    End Sub
End Class
