Imports System.Text.RegularExpressions
Public Class Ejercicio11

    Public Function VerifyDate(ByVal dateValue As String) As Boolean
        Dim datePattern As String = "^(((0[1-9]|[12][0-9]|3[01])[- /.](0[13578]|1[02])|(0[1-9]|[12][0-9]|30)[- /.](0[469]|11)|(0[1-9]|1\d|2[0-8])[- /.]02)[- /.]\d{4}|29[- /.]02[- /.](\d{2}(0[48]|[2468][048]|[13579][26])|([02468][048]|[1359][26])00))$"
        Dim regexDate As New Regex(datePattern)

        Dim validDate As Boolean = regexDate.IsMatch(dateValue)

        Return validDate
    End Function

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim inputDate As String = textBoxFecha.Text.Trim()

        Dim IsValidDate As Boolean = VerifyDate(inputDate)

        If Not IsValidDate Then
            MsgBox("Por favor verifica que sea una fecha valida. (dd/mm/aaaa).", Title:="Error")
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

        labelResult.Text = result
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        FormHome.Show()
    End Sub
End Class