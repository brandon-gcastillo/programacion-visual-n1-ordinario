<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio9
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
        Me.labelCadenaTexto = New System.Windows.Forms.Label()
        Me.textBoxCadenaTexto = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.labelCadenaTexto)
        Me.FlowLayoutPanel1.Controls.Add(Me.textBoxCadenaTexto)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEnviar)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGoBack)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(12)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(776, 474)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(740, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ejercicio 09: Cadena de texto y luego muestre cuántas veces aparece una letra "
        '
        'labelCadenaTexto
        '
        Me.labelCadenaTexto.AutoSize = True
        Me.labelCadenaTexto.Location = New System.Drawing.Point(15, 49)
        Me.labelCadenaTexto.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.labelCadenaTexto.Name = "labelCadenaTexto"
        Me.labelCadenaTexto.Size = New System.Drawing.Size(128, 19)
        Me.labelCadenaTexto.TabIndex = 1
        Me.labelCadenaTexto.Text = "Cadena de texto:"
        '
        'textBoxCadenaTexto
        '
        Me.textBoxCadenaTexto.Location = New System.Drawing.Point(15, 71)
        Me.textBoxCadenaTexto.Margin = New System.Windows.Forms.Padding(3, 3, 3, 12)
        Me.textBoxCadenaTexto.Name = "textBoxCadenaTexto"
        Me.textBoxCadenaTexto.Size = New System.Drawing.Size(304, 27)
        Me.textBoxCadenaTexto.TabIndex = 2
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(15, 113)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(128, 34)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelResult)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 251)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado:"
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.Location = New System.Drawing.Point(6, 23)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(0, 19)
        Me.labelResult.TabIndex = 0
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(15, 410)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(128, 32)
        Me.btnGoBack.TabIndex = 5
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Ejercicio9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Ejercicio9"
        Me.Text = "Ejercicio 9"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents labelCadenaTexto As Label
    Friend WithEvents textBoxCadenaTexto As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelResult As Label
    Friend WithEvents btnGoBack As Button
End Class
