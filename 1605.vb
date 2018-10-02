Dim i As Integer, n As Integer = Val(TextBox1.Text)
Dim fn1 As Integer, fn As Integer
fn1 = 0
For i = 1 To n
    fn = ((fn1 * 10 + 9) \ i) * i
    fn1 = fn
Next
TextBox2.Text = fn
