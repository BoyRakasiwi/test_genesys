Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j As Integer
        Dim hasil As String = ""
        For i = 0 To 8
            For j = 1 To i
                Label1.Text &= j & " "
            Next
            Label1.Text &= vbNewLine
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x, y, z As Integer
        x = 1 : y = 5
        TextBox1.Clear()
        Do While x <= y
            z = 1
            TextBox1.Text = _
            TextBox1.Text & Space(y - x)
            Do While z <= x
                TextBox1.Text = _
                TextBox1.Text & " " & z
                z += 1
            Loop
            TextBox1.Text = _
            TextBox1.Text & vbCrLf
            x += 1
        Loop
    End Sub
End Class
