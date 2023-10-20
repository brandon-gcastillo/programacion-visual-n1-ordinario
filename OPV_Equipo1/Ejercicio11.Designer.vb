<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio11
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textBoxFecha = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.groupBoxResult = New System.Windows.Forms.GroupBox()
        Me.labelResult11 = New System.Windows.Forms.Label()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.groupBoxResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEnviar)
        Me.FlowLayoutPanel1.Controls.Add(Me.groupBoxResult)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGoBack)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(12)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(826, 471)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(780, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ejercicio 11: Fecha en formato ""dd/mm/aaaa"" y luego muestre el día, mes y año por" &
    " separado"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.labelFecha)
        Me.FlowLayoutPanel2.Controls.Add(Me.textBoxFecha)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(15, 65)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(743, 73)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFecha.Location = New System.Drawing.Point(8, 5)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(136, 19)
        Me.labelFecha.TabIndex = 1
        Me.labelFecha.Text = "Ingrese una fecha:"
        '
        'textBoxFecha
        '
        Me.textBoxFecha.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxFecha.Location = New System.Drawing.Point(150, 8)
        Me.textBoxFecha.Name = "textBoxFecha"
        Me.textBoxFecha.Size = New System.Drawing.Size(187, 27)
        Me.textBoxFecha.TabIndex = 2
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(15, 144)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(139, 32)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'groupBoxResult
        '
        Me.groupBoxResult.Controls.Add(Me.labelResult11)
        Me.groupBoxResult.Controls.Add(Me.labelResult)
        Me.groupBoxResult.Font = New System.Drawing.Font("Lato Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxResult.Location = New System.Drawing.Point(15, 182)
        Me.groupBoxResult.Name = "groupBoxResult"
        Me.groupBoxResult.Size = New System.Drawing.Size(743, 213)
        Me.groupBoxResult.TabIndex = 6
        Me.groupBoxResult.TabStop = False
        Me.groupBoxResult.Text = "Resultado:"
        '
        'labelResult11
        '
        Me.labelResult11.AutoSize = True
        Me.labelResult11.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelResult11.Location = New System.Drawing.Point(7, 32)
        Me.labelResult11.Name = "labelResult11"
        Me.labelResult11.Size = New System.Drawing.Size(0, 19)
        Me.labelResult11.TabIndex = 1
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelResult.Location = New System.Drawing.Point(7, 27)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(0, 19)
        Me.labelResult.TabIndex = 0
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(15, 401)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(139, 32)
        Me.btnGoBack.TabIndex = 7
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Ejercicio11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(850, 495)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ejercicio11"
        Me.Text = "Ejercicio 11"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.groupBoxResult.ResumeLayout(False)
        Me.groupBoxResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents labelFecha As Label
    Friend WithEvents textBoxFecha As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents groupBoxResult As GroupBox
    Friend WithEvents labelResult As Label
    Friend WithEvents labelResult11 As Label
    Friend WithEvents btnGoBack As Button
End Class
