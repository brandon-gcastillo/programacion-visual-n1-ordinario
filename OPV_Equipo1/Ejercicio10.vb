Public Class Ejercicio10
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        FormHome.Show()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim listadoNombres As String = textBoxListaNombres.Text.Trim()
        Dim ArrListadoNombres As String() = listadoNombres.Split(","c)
        Dim resultado As String = ""

        If Not listadoNombres.Contains(",") Then
            MsgBox("Porfavor, los nombres tienen que estar separados por comas (,)." & vbNewLine & "Vuelve a intentarlo.", Title:="Error")
        End If

        'Sorting Array
        Array.Sort(ArrListadoNombres)

        For Each nombre As String In ArrListadoNombres
            resultado += "" & nombre & vbNewLine
        Next

        textBoxResult.Text = resultado

    End Sub
End Class