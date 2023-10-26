Public Class Ejercicio1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num As Integer = Integer.Parse(TextBox1.Text)
        If num Mod 2 = 0 Then
            Label3.Text = "El numero es par."
        Else
            Label3.Text = "El numero es impar."

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        Me.Hide()

    End Sub

    Private Sub Ejercicio1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class