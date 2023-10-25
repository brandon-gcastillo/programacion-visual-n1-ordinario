Public Class Ejercicio9

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim ocurrenciasDic As New Dictionary(Of Char, Integer)
        Dim cadenaTexto As String = textBoxCadenaTexto.Text.Trim()
        Dim resultLabel As String = ""

        If cadenaTexto = "" Then
            MsgBox("Por favor, introduce una cadena de texto.", Title:="Error")
            textBoxCadenaTexto.Text = ""
        End If

        For Each letra In cadenaTexto

            'Saltar caracter si es un espacio
            If letra = " " Then
                Continue For
            End If

            'Si el diccionario ya contiene la letra, incrementar ocurrencia del caracter
            If ocurrenciasDic.ContainsKey(letra) Then
                ocurrenciasDic(letra) += 1
            Else
                'Agregar palabra y ocurrencia al diccionario
                ocurrenciasDic.Add(letra, 1)
            End If

        Next

        For Each par In ocurrenciasDic
            resultLabel += "La letra '" & par.Key & "' ha aparecido: " & par.Value & " veces." & vbNewLine
        Next

        'Agregar resultado al label
        textBoxResult.Text = resultLabel

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        FormHome.Show()
    End Sub
End Class