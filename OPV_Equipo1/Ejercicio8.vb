Public Class Ejercicio8
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numeros As String = lblResultado.Text
        Dim numerosSeparados As String() = numeros.Split(","c)
        Dim suma As Double = 0

        For Each numero As String In numerosSeparados
            Dim valor As Double
            If Double.TryParse(numero, valor) Then
                suma += valor
            End If
        Next

        lblResultado.Text = "Resultado: " & suma.ToString()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormHome.Show()
        Me.Hide()

    End Sub
End Class