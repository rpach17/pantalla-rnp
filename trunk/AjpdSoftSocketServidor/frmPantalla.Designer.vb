<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPantalla
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
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.lblV1 = New System.Windows.Forms.Label()
        Me.lblV2 = New System.Windows.Forms.Label()
        Me.lblS2 = New System.Windows.Forms.Label()
        Me.lblV3 = New System.Windows.Forms.Label()
        Me.lblS3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblS1
        '
        Me.lblS1.AutoSize = True
        Me.lblS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblS1.Location = New System.Drawing.Point(3, 42)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(309, 126)
        Me.lblS1.TabIndex = 2
        Me.lblS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblV1
        '
        Me.lblV1.AutoSize = True
        Me.lblV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblV1.Location = New System.Drawing.Point(475, 42)
        Me.lblV1.Name = "lblV1"
        Me.lblV1.Size = New System.Drawing.Size(311, 126)
        Me.lblV1.TabIndex = 3
        Me.lblV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblV2
        '
        Me.lblV2.AutoSize = True
        Me.lblV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblV2.Location = New System.Drawing.Point(475, 168)
        Me.lblV2.Name = "lblV2"
        Me.lblV2.Size = New System.Drawing.Size(311, 126)
        Me.lblV2.TabIndex = 5
        Me.lblV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS2
        '
        Me.lblS2.AutoSize = True
        Me.lblS2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblS2.Location = New System.Drawing.Point(3, 168)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(309, 126)
        Me.lblS2.TabIndex = 4
        Me.lblS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblV3
        '
        Me.lblV3.AutoSize = True
        Me.lblV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblV3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblV3.Location = New System.Drawing.Point(475, 294)
        Me.lblV3.Name = "lblV3"
        Me.lblV3.Size = New System.Drawing.Size(311, 128)
        Me.lblV3.TabIndex = 7
        Me.lblV3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS3
        '
        Me.lblS3.AutoSize = True
        Me.lblS3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblS3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblS3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblS3.Location = New System.Drawing.Point(3, 294)
        Me.lblS3.Name = "lblS3"
        Me.lblS3.Size = New System.Drawing.Size(309, 128)
        Me.lblS3.TabIndex = 6
        Me.lblS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblS1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblV3, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblS2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblV2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblS3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblV1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(789, 422)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(783, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Registro Nacional de las Personas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Image = Global.PantallaServidor.My.Resources.Resources._1393727701_arrow_right
        Me.Label2.Location = New System.Drawing.Point(318, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 126)
        Me.Label2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Image = Global.PantallaServidor.My.Resources.Resources._1393727701_arrow_right
        Me.Label3.Location = New System.Drawing.Point(318, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 126)
        Me.Label3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Image = Global.PantallaServidor.My.Resources.Resources._1393727701_arrow_right
        Me.Label4.Location = New System.Drawing.Point(318, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 128)
        Me.Label4.TabIndex = 14
        '
        'frmPantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 422)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmPantalla"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblS1 As System.Windows.Forms.Label
    Friend WithEvents lblV1 As System.Windows.Forms.Label
    Friend WithEvents lblV2 As System.Windows.Forms.Label
    Friend WithEvents lblS2 As System.Windows.Forms.Label
    Friend WithEvents lblV3 As System.Windows.Forms.Label
    Friend WithEvents lblS3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
