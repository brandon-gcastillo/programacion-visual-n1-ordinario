Public Class Ejercicio3
    Private Sub Ejercicio3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 10
        While i >= 1
            MsgBox(i)
            i -= 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        Me.Hide()

    End Sub
End Class