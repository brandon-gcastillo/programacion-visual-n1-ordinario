Public Class Ejercicio2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = Val(txtb1.Text)
        Dim mensaje As String

        If num > 0 Then
            mensaje = "El numero es positivo."

        ElseIf num < 0 Then
            mensaje = "El numero es negativo."

        Else
            mensaje = "El numero es cero."

        End If

        Label4.Text = mensaje

    End Sub
End Class