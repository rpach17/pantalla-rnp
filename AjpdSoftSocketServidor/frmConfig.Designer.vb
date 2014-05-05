<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cboVoces = New System.Windows.Forms.ComboBox()
        Me.btnProbar = New System.Windows.Forms.Button()
        Me.txtPrueba = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(398, 33)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cboVoces
        '
        Me.cboVoces.FormattingEnabled = True
        Me.cboVoces.Location = New System.Drawing.Point(124, 33)
        Me.cboVoces.Name = "cboVoces"
        Me.cboVoces.Size = New System.Drawing.Size(268, 21)
        Me.cboVoces.TabIndex = 3
        '
        'btnProbar
        '
        Me.btnProbar.Location = New System.Drawing.Point(398, 62)
        Me.btnProbar.Name = "btnProbar"
        Me.btnProbar.Size = New System.Drawing.Size(75, 23)
        Me.btnProbar.TabIndex = 4
        Me.btnProbar.Text = "Probar"
        Me.btnProbar.UseVisualStyleBackColor = True
        '
        'txtPrueba
        '
        Me.txtPrueba.Location = New System.Drawing.Point(124, 60)
        Me.txtPrueba.Multiline = True
        Me.txtPrueba.Name = "txtPrueba"
        Me.txtPrueba.Size = New System.Drawing.Size(268, 70)
        Me.txtPrueba.TabIndex = 5
        Me.txtPrueba.Text = "Este es un texto de prueba."
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 177)
        Me.Controls.Add(Me.txtPrueba)
        Me.Controls.Add(Me.btnProbar)
        Me.Controls.Add(Me.cboVoces)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConfig"
        Me.Text = "Configurar Audio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cboVoces As System.Windows.Forms.ComboBox
    Friend WithEvents btnProbar As System.Windows.Forms.Button
    Friend WithEvents txtPrueba As System.Windows.Forms.TextBox
End Class
