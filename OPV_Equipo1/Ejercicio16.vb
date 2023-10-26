Public Class Ejercicio16
    Private Sub Ejercicio16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        FormHome.Show()
        Me.Hide()

    End Sub

    Dim productosAcumulativos As New List(Of String)

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim producto As String = txtProducto.Text
        Dim cantidad As Integer = Decimal.Parse(txtCantidad.Text)

        Dim productos As New Dictionary(Of String, Decimal) From {
            {"Leche", 20},
            {"Pan", 5},
            {"Huevo", 70},
            {"Carne", 50}
        }

        Dim valorUnitario As Decimal = If(productos.ContainsKey(producto), productos(producto), 0)
        Dim ventaTotal As Decimal = valorUnitario * cantidad
        Dim iva As Decimal = ventaTotal * 0.16D
        Dim totalPagar As Decimal = ventaTotal + iva

        txtValorUnitario.Text = valorUnitario.ToString("C")
        txtVentaTotal.Text = ventaTotal.ToString("C")
        txtIVA.Text = iva.ToString("C")
        txtTotalPagar.Text = totalPagar.ToString("C")

        listBoxProductos.Items.Add($"{producto}: {ventaTotal.ToString("C")}")

        productosAcumulativos.Add($"{producto}: {ventaTotal.ToString("C")}")

        txtProducto.Clear()
        txtCantidad.Clear()
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtProducto.Clear()
        txtCantidad.Clear()
        txtValorUnitario.Clear()
        txtVentaTotal.Clear()
        txtIVA.Clear()
        txtTotalPagar.Clear()
    End Sub

    Private Sub btnSiguienteProducto_Click(sender As Object, e As EventArgs) Handles btnSiguienteProducto.Click
        Dim producto As String = txtProducto.Text
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)

        Dim productos As New Dictionary(Of String, Decimal) From {
            {"Leche", 20},
            {"Pan", 5},
            {"Huevo", 70},
            {"Carne", 50}
        }

        Dim valorUnitario As Decimal = If(productos.ContainsKey(producto), productos(producto), 0)
        Dim ventaTotal As Decimal = valorUnitario * cantidad
        Dim iva As Decimal = ventaTotal * 0.16D
        Dim totalPagar As Decimal = ventaTotal + iva

        txtValorUnitario.Text = valorUnitario.ToString("C")
        txtVentaTotal.Text = ventaTotal.ToString("C")
        txtIVA.Text = iva.ToString("C")
        txtTotalPagar.Text = totalPagar.ToString("C")

        listBoxProductos.Items.Add($"{producto}: {ventaTotal.ToString("C")}")

        productosAcumulativos.Add($"{producto}: {ventaTotal.ToString("C")}")

        txtProducto.Clear()
        txtCantidad.Clear()
    End Sub
End Class
