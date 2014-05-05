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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPantalla))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblV3 = New System.Windows.Forms.Label()
        Me.lblS3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblV2 = New System.Windows.Forms.Label()
        Me.lblS2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wmpVideos = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblV1 = New System.Windows.Forms.Label()
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.wmpVideos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.wmpVideos, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(891, 464)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblV3, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblS3, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(597, 327)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(291, 134)
        Me.TableLayoutPanel4.TabIndex = 15
        '
        'lblV3
        '
        Me.lblV3.AutoSize = True
        Me.lblV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblV3.ForeColor = System.Drawing.Color.Black
        Me.lblV3.Location = New System.Drawing.Point(3, 67)
        Me.lblV3.Name = "lblV3"
        Me.lblV3.Size = New System.Drawing.Size(285, 67)
        Me.lblV3.TabIndex = 3
        Me.lblV3.Text = "-"
        Me.lblV3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblS3
        '
        Me.lblS3.AutoSize = True
        Me.lblS3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblS3.ForeColor = System.Drawing.Color.Black
        Me.lblS3.Location = New System.Drawing.Point(3, 0)
        Me.lblS3.Name = "lblS3"
        Me.lblS3.Size = New System.Drawing.Size(285, 67)
        Me.lblS3.TabIndex = 1
        Me.lblS3.Text = "-"
        Me.lblS3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblV2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblS2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(597, 188)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(291, 133)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'lblV2
        '
        Me.lblV2.AutoSize = True
        Me.lblV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblV2.ForeColor = System.Drawing.Color.Black
        Me.lblV2.Location = New System.Drawing.Point(3, 66)
        Me.lblV2.Name = "lblV2"
        Me.lblV2.Size = New System.Drawing.Size(285, 67)
        Me.lblV2.TabIndex = 2
        Me.lblV2.Text = "-"
        Me.lblV2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblS2
        '
        Me.lblS2.AutoSize = True
        Me.lblS2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblS2.ForeColor = System.Drawing.Color.Black
        Me.lblS2.Location = New System.Drawing.Point(3, 0)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(285, 66)
        Me.lblS2.TabIndex = 1
        Me.lblS2.Text = "-"
        Me.lblS2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(885, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Registro Nacional de las Personas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wmpVideos
        '
        Me.wmpVideos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wmpVideos.Enabled = True
        Me.wmpVideos.Location = New System.Drawing.Point(3, 49)
        Me.wmpVideos.Name = "wmpVideos"
        Me.wmpVideos.OcxState = CType(resources.GetObject("wmpVideos.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TableLayoutPanel1.SetRowSpan(Me.wmpVideos, 3)
        Me.wmpVideos.Size = New System.Drawing.Size(588, 412)
        Me.wmpVideos.TabIndex = 12
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblV1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblS1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(597, 49)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(291, 133)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'lblV1
        '
        Me.lblV1.AutoSize = True
        Me.lblV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblV1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblV1.Location = New System.Drawing.Point(3, 66)
        Me.lblV1.Name = "lblV1"
        Me.lblV1.Size = New System.Drawing.Size(285, 67)
        Me.lblV1.TabIndex = 1
        Me.lblV1.Text = "-"
        Me.lblV1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblS1
        '
        Me.lblS1.AutoSize = True
        Me.lblS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblS1.ForeColor = System.Drawing.Color.Red
        Me.lblS1.Location = New System.Drawing.Point(3, 0)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(285, 66)
        Me.lblS1.TabIndex = 0
        Me.lblS1.Text = "-"
        Me.lblS1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmPantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 464)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmPantalla"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.wmpVideos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wmpVideos As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblS1 As System.Windows.Forms.Label
    Friend WithEvents lblS3 As System.Windows.Forms.Label
    Friend WithEvents lblS2 As System.Windows.Forms.Label
    Friend WithEvents lblV1 As System.Windows.Forms.Label
    Friend WithEvents lblV3 As System.Windows.Forms.Label
    Friend WithEvents lblV2 As System.Windows.Forms.Label
End Class
