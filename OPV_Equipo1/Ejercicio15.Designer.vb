<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio15
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnMostrarNaturales = New System.Windows.Forms.Button()
        Me.lstNaturales = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(257, 97)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 0
        '
        'btnMostrarNaturales
        '
        Me.btnMostrarNaturales.Location = New System.Drawing.Point(272, 142)
        Me.btnMostrarNaturales.Name = "btnMostrarNaturales"
        Me.btnMostrarNaturales.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrarNaturales.TabIndex = 1
        Me.btnMostrarNaturales.Text = "Mostrar"
        Me.btnMostrarNaturales.UseVisualStyleBackColor = True
        '
        'lstNaturales
        '
        Me.lstNaturales.FormattingEnabled = True
        Me.lstNaturales.Location = New System.Drawing.Point(574, 247)
        Me.lstNaturales.Name = "lstNaturales"
        Me.lstNaturales.Size = New System.Drawing.Size(120, 95)
        Me.lstNaturales.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ejercicio 15"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Regresar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ejercicio15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNaturales)
        Me.Controls.Add(Me.btnMostrarNaturales)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "Ejercicio15"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumero As TextBox
    Friend WithEvents btnMostrarNaturales As Button
    Friend WithEvents lstNaturales As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
