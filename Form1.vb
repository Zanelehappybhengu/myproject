Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Double
        Dim func, fun, result As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)

        func = Math.Cos(x)
        fun = Math.Sin(y)
        result = func * fun

        MsgBox("result is " & result)
    End Sub
End Class
