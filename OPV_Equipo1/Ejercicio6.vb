Public Class Ejercicio6
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ejercicio6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numero1, numero2, resultado As Integer
        numero1 = Val(TextBox1.Text)
        numero2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)
        resultado = Val(numero1) + Val(numero2)

        TextBox3.Text = resultado

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numero1, numero2, resultado As Integer
        numero1 = Val(TextBox1.Text)
        numero2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)
        resultado = Val(numero1) - Val(numero2)

        TextBox3.Text = resultado
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim numero1, numero2, resultado As Integer
        numero1 = Val(TextBox1.Text)
        numero2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)
        resultado = Val(numero1) / Val(numero2)

        TextBox3.Text = resultado
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim numero1, numero2, resultado As Integer
        numero1 = Val(TextBox1.Text)
        numero2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)
        resultado = Val(numero1) * Val(numero2)

        TextBox3.Text = resultado
    End Sub
End Class