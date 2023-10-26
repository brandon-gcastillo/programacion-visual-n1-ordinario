<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio13
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
        Me.btnMostrarPares = New System.Windows.Forms.Button()
        Me.lstPares = New System.Windows.Forms.ListBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMostrarPares
        '
        Me.btnMostrarPares.Location = New System.Drawing.Point(218, 146)
        Me.btnMostrarPares.Name = "btnMostrarPares"
        Me.btnMostrarPares.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrarPares.TabIndex = 0
        Me.btnMostrarPares.Text = "Mostrar"
        Me.btnMostrarPares.UseVisualStyleBackColor = True
        '
        'lstPares
        '
        Me.lstPares.FormattingEnabled = True
        Me.lstPares.Location = New System.Drawing.Point(546, 250)
        Me.lstPares.Name = "lstPares"
        Me.lstPares.Size = New System.Drawing.Size(120, 95)
        Me.lstPares.TabIndex = 1
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(207, 96)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ejercicio 13"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ejercicio13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lstPares)
        Me.Controls.Add(Me.btnMostrarPares)
        Me.Name = "Ejercicio13"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrarPares As Button
    Friend WithEvents lstPares As ListBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
