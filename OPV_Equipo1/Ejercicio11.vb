Public Class Ejercicio11

    Public Function VerifyDate(ByVal dateValue As String) As Boolean
        Dim IsValueCorrect As Boolean = True
        Dim splittedValue As String() = dateValue.Split("/"c)

        If splittedValue.Length - 1 < 2 Or Not dateValue.Contains("/"c) Then
            IsValueCorrect = False
        End If

        For Each item In splittedValue
            If Not IsNumeric(Convert.ToInt32(item)) Then
                IsValueCorrect = False
            End If
        Next

        Return IsValueCorrect
    End Function

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim inputDate As String = textBoxFecha.Text

        Dim IsValidDate As Boolean = VerifyDate(inputDate)

        If Not IsValidDate Then
            MsgBox("Por favor verifica que sea una fecha valida. (dd/mm/aaaa).")
            Exit Sub
        End If

        Dim splittedDate As String() = inputDate.Split("/"c)

        Dim result As String = ""

        For index As Integer = 0 To splittedDate.Length - 1
            Select Case index
                Case 0
                    result += "Dia: " & splittedDate(index) & vbNewLine
                Case 1
                    result += "Mes: " & splittedDate(index) & vbNewLine
                Case 2
                    result += "Año: " & splittedDate(index) & vbNewLine
            End Select
        Next

        labelResult11.Text = result
    End Sub

End Class