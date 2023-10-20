<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio10
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
        Me.labelIntro = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.labelListaDeNombres = New System.Windows.Forms.Label()
        Me.textBoxListaNombres = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.textBoxResult = New System.Windows.Forms.TextBox()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelIntro
        '
        Me.labelIntro.AutoSize = True
        Me.labelIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelIntro.Font = New System.Drawing.Font("Lato Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIntro.Location = New System.Drawing.Point(15, 12)
        Me.labelIntro.Margin = New System.Windows.Forms.Padding(3, 0, 3, 12)
        Me.labelIntro.Name = "labelIntro"
        Me.labelIntro.Size = New System.Drawing.Size(745, 25)
        Me.labelIntro.TabIndex = 0
        Me.labelIntro.Text = "Ejercicio 10: Lista de nombres y luego los ordene alfabéticamente y los muestre." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.labelIntro)
        Me.FlowLayoutPanel1.Controls.Add(Me.labelListaDeNombres)
        Me.FlowLayoutPanel1.Controls.Add(Me.textBoxListaNombres)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEnviar)
        Me.FlowLayoutPanel1.Controls.Add(Me.labelResult)
        Me.FlowLayoutPanel1.Controls.Add(Me.textBoxResult)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGoBack)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(12)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(776, 593)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'labelListaDeNombres
        '
        Me.labelListaDeNombres.AutoSize = True
        Me.labelListaDeNombres.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelListaDeNombres.Location = New System.Drawing.Point(15, 49)
        Me.labelListaDeNombres.Name = "labelListaDeNombres"
        Me.labelListaDeNombres.Size = New System.Drawing.Size(365, 19)
        Me.labelListaDeNombres.TabIndex = 1
        Me.labelListaDeNombres.Text = "Ingresa una lista de nombres (separados por coma):"
        '
        'textBoxListaNombres
        '
        Me.textBoxListaNombres.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxListaNombres.Location = New System.Drawing.Point(15, 71)
        Me.textBoxListaNombres.Multiline = True
        Me.textBoxListaNombres.Name = "textBoxListaNombres"
        Me.textBoxListaNombres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxListaNombres.Size = New System.Drawing.Size(488, 72)
        Me.textBoxListaNombres.TabIndex = 2
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(15, 149)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(136, 33)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.Font = New System.Drawing.Font("Lato Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelResult.Location = New System.Drawing.Point(15, 197)
        Me.labelResult.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(83, 19)
        Me.labelResult.TabIndex = 4
        Me.labelResult.Text = "Resultado:"
        '
        'textBoxResult
        '
        Me.textBoxResult.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textBoxResult.Location = New System.Drawing.Point(15, 219)
        Me.textBoxResult.Multiline = True
        Me.textBoxResult.Name = "textBoxResult"
        Me.textBoxResult.ReadOnly = True
        Me.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxResult.Size = New System.Drawing.Size(488, 190)
        Me.textBoxResult.TabIndex = 5
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(15, 415)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(136, 33)
        Me.btnGoBack.TabIndex = 6
        Me.btnGoBack.Text = "Regresar"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Ejercicio10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(800, 617)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Ejercicio10"
        Me.Text = "Ejercicio 10"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelIntro As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents labelListaDeNombres As Label
    Friend WithEvents textBoxListaNombres As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents labelResult As Label
    Friend WithEvents textBoxResult As TextBox
    Friend WithEvents btnGoBack As Button
End Class
