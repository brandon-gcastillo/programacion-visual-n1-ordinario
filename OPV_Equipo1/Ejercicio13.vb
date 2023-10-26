Public Class Ejercicio13
    Private Sub btnMostrarPares_Click(sender As Object, e As EventArgs) Handles btnMostrarPares.Click
        lstPares.Items.Clear() ' Limpia la lista de números pares anteriores

        Dim numero As Integer

        If Integer.TryParse(txtNumero.Text, numero) Then
            ' Asegurémonos de que el número ingresado sea un número entero válido.

            For i As Integer = 2 To numero Step 2
                ' Comenzando desde 2 (el primer número par), incrementa de 2 en 2 hasta alcanzar o superar el número ingresado.
                lstPares.Items.Add(i) ' Agrega el número par a la lista.
            Next
        Else
            MessageBox.Show("Por favor, ingrese un número válido.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormHome.Show()
        Me.Hide()
    End Sub
End Class