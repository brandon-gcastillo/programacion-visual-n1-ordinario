Public Class Ejercicio4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String = InputBox("Ingresa una cadena : ")
        For Each c As Char In cadena
            MsgBox(c)

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        Me.Hide()

    End Sub
End Class