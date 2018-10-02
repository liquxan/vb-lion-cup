Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'CP值   A=3.3  B=4.1  C=4.5 D=4  e=0.3  C>B>D>A>E
        Dim r As Integer = TextBox1.Text  '紅利點數
        Dim s As Integer '滿意值
        Dim a As Integer = TextBox2.Text
        Dim b As Integer = TextBox3.Text
        Dim c As Integer = TextBox4.Text
        Dim d As Integer = TextBox5.Text
        Dim f As Integer = TextBox6.Text

        If c > 0 And r > 10 Then         '以C贈品的CP值最高,由C開始計算 c數量大於1 紅利點數夠才執行
            While r > 10 And c > 0
                c -= 1
                s += 45
                r -= 10
            End While
        End If
        If b > 0 And r > 18 Then
            While r > 18 And b > 0
                b -= 1
                s += 75
                r -= 18
            End While
        End If
        If d > 0 And r > 5 Then
            While r > 5 And d > 0
                d -= 1
                s += 20
                r -= 5
            End While
        End If
        If a > 0 And r > 30 Then
            While r > 30 And a > 0
                c -= 1
                s += 100
                r -= 30
            End While
        End If
        If f > 0 And r > 1 Then
            While r > 1 And c > 0
                c -= 1
                s += 3
                r -= 1
            End While
        End If
        TextBox7.Text = s
    End Sub
End Class
