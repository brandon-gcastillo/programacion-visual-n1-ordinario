<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio16
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VENTAS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtValorUnitario = New System.Windows.Forms.TextBox()
        Me.txtVentaTotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.listBoxProductos = New System.Windows.Forms.ListBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.btnSiguienteProducto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VENTAS
        '
        Me.VENTAS.AutoSize = True
        Me.VENTAS.Location = New System.Drawing.Point(36, 27)
        Me.VENTAS.Name = "VENTAS"
        Me.VENTAS.Size = New System.Drawing.Size(62, 16)
        Me.VENTAS.TabIndex = 0
        Me.VENTAS.Text = "VENTAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor Unitario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Venta Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "IVA 16%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "a Pagar"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(146, 103)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 22)
        Me.txtProducto.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(146, 147)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 8
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.Location = New System.Drawing.Point(146, 193)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(100, 22)
        Me.txtValorUnitario.TabIndex = 9
        '
        'txtVentaTotal
        '
        Me.txtVentaTotal.Location = New System.Drawing.Point(146, 237)
        Me.txtVentaTotal.Name = "txtVentaTotal"
        Me.txtVentaTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtVentaTotal.TabIndex = 10
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(146, 284)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(100, 22)
        Me.txtIVA.TabIndex = 11
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Location = New System.Drawing.Point(146, 331)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalPagar.TabIndex = 12
        '
        'listBoxProductos
        '
        Me.listBoxProductos.FormattingEnabled = True
        Me.listBoxProductos.ItemHeight = 16
        Me.listBoxProductos.Location = New System.Drawing.Point(342, 57)
        Me.listBoxProductos.Name = "listBoxProductos"
        Me.listBoxProductos.Size = New System.Drawing.Size(192, 308)
        Me.listBoxProductos.TabIndex = 13
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(30, 393)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 14
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(126, 393)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarCampos.TabIndex = 15
        Me.btnLimpiarCampos.Text = "Limpiar"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(226, 393)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(75, 23)
        Me.Regresar.TabIndex = 16
        Me.Regresar.Text = "Salir"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'btnSiguienteProducto
        '
        Me.btnSiguienteProducto.Location = New System.Drawing.Point(459, 393)
        Me.btnSiguienteProducto.Name = "btnSiguienteProducto"
        Me.btnSiguienteProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguienteProducto.TabIndex = 17
        Me.btnSiguienteProducto.Text = "Siguiente"
        Me.btnSiguienteProducto.UseVisualStyleBackColor = True
        '
        'Ejercicio16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSiguienteProducto)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.listBoxProductos)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.txtVentaTotal)
        Me.Controls.Add(Me.txtValorUnitario)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VENTAS)
        Me.Name = "Ejercicio16"
        Me.Text = "Ejercicio16"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VENTAS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtValorUnitario As TextBox
    Friend WithEvents txtVentaTotal As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents listBoxProductos As ListBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents Regresar As Button
    Friend WithEvents btnSiguienteProducto As Button
End Class
