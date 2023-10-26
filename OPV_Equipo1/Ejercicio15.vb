Public Class Ejercicio15
    Private Sub btnMostrarNaturales_Click(sender As Object, e As EventArgs) Handles btnMostrarNaturales.Click
        lstNaturales.Items.Clear() ' Limpia la lista de números naturales anteriores

        Dim numero As Integer

        If Integer.TryParse(txtNumero.Text, numero) Then
            ' Asegurémonos de que el número ingresado sea un número entero válido.

            For i As Integer = 1 To numero - 1
                ' Comenzando desde 1 y avanzando hasta el número ingresado menos uno.
                lstNaturales.Items.Add(i) ' Agrega el número natural a la lista.
            Next
        Else
            MessageBox.Show("Por favor, ingrese un número válido.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormHome.Show()
        Me.Hide()

    End Sub
End Class