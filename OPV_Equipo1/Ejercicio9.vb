Public Class Ejercicio9

    Public Function CountCharacter(ByVal value As String, ByVal letter As Char) As Integer
        Dim contador As Integer = 0
        For index As Integer = 0 To value.Length - 1
            If value(index) = letter Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim strMsg As String = textBoxCadenaTexto.Text.Trim()
        Dim itemsFound As Integer() = New Integer(strMsg.Length - 1) {}
        Dim resultLabel As String = ""

        For index As Integer = 0 To strMsg.Length - 1
            Dim contador As Integer = CountCharacter(strMsg, Convert.ToChar(strMsg(index)))
            itemsFound(index) = contador
        Next

        For index As Integer = 0 To itemsFound.Length - 1
            resultLabel += "La letra '" & strMsg(index) & "' ha aparecido: " & itemsFound(index) & " veces." & vbNewLine
        Next

        labelResult.Text = resultLabel

    End Sub
End Class