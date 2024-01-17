Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim H As Double
        Dim L As Double
        Dim P As Double
        L = Val(TextBox1.Text)
        H = Val(TextBox4.Text)
        A = L * H
        H = 2 * (L + H)
        TextBox3.Text = A
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A As Double
        Dim H As Double
        Dim L As Double
        Dim P As Double
        L = Val(TextBox1.Text)
        H = Val(TextBox4.Text)
        A = L * H
        H = 2 * (L + H)
        TextBox2.Text = H
    End Sub
End Class
