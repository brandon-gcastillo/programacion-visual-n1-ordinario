Public Class Ejercicio12
    Private Sub Ejercicio12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ejercicio12 enlaza con Form y muestra el ejercicio
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        Me.Hide()
        ' Volver al menú
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        ' Funcionamiento del código 
        If Integer.TryParse(TextBox1.Text, numero) Then
            Dim primos As New List(Of Integer)

            For i As Integer = 2 To numero
                If EsPrimo(i) Then
                    primos.Add(i)
                End If
            Next

            Dim primosTexto As String = String.Join(", ", primos)
            Label3.Text = "Números primos hasta " & numero & ": " & primosTexto
        Else
            Label3.Text = "Por favor, ingresa un número entero válido."
        End If
    End Sub

    Private Function EsPrimo(n As Integer) As Boolean
        If n <= 1 Then
            Return False
        End If

        For i As Integer = 2 To Math.Sqrt(n)
            If n Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function
End Class
