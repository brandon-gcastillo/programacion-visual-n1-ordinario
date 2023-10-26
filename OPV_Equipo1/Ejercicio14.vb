Public Class Ejercicio14
    Private Sub Ejercicio14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        Me.Hide()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeros As String() = TextBox1.Text.Split(","c) ' Divide la cadena por comas

        ' Validación de entrada
        If numeros.Length = 0 Then
            MessageBox.Show("Por favor, ingresa una lista de números.")
            Exit Sub
        End If

        Dim numerosEnteros As New List(Of Integer)

        ' Convierte los números a enteros y valida la entrada
        For Each numero As String In numeros
            Dim num As Integer
            If Integer.TryParse(numero, num) Then
                numerosEnteros.Add(num)
            Else
                MessageBox.Show("Por favor, ingresa una lista válida de números separados por comas.")
                Exit Sub
            End If
        Next

        ' Ordena los números
        numerosEnteros.Sort()

        ' Muestra el número más grande y el más pequeño
        Label4.Text = "Número más grande: " & numerosEnteros.Last()
        Label5.Text = "Número más pequeño: " & numerosEnteros.First()

        ' Muestra la lista ordenada con saltos de línea cada 10 números
        Dim listaOrdenada As String = ""
        For i As Integer = 0 To numerosEnteros.Count - 1
            listaOrdenada &= numerosEnteros(i)
            If (i + 1) Mod 10 = 0 AndAlso (i + 1) < numerosEnteros.Count Then
                listaOrdenada &= Environment.NewLine
            Else
                listaOrdenada &= ", "
            End If
        Next

        Label3.Text = "Lista ordenada:" & Environment.NewLine & listaOrdenada
    End Sub
End Class
