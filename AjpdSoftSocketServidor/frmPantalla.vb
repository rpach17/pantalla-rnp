Public Class frmPantalla
    Dim WithEvents socketServidor As New ClaseServidorSocket()
    Public salir As Boolean = True

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If salir Then End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Voz = "" Then
            frmConfig.Show()
            salir = False
            Close()
        End If
        CheckForIllegalCrossThreadCalls = False
        IniciarServidor()
    End Sub

    Private Sub IniciarServidor()
        Try
            socketServidor.Puerto = 11000
            socketServidor.IniciarEscucha()
            Text = "Listo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub socketServidor_NuevaConexion(ByVal IDTerminal As System.Net.IPEndPoint) Handles socketServidor.NuevaConexion
        Text = String.Format("Ventanilla disponible [{0}:{1}]", IDTerminal.Address.ToString, IDTerminal.Port)
    End Sub

    Private Sub socketServidor_ConexionTerminada(ByVal IDTerminal As System.Net.IPEndPoint) Handles socketServidor.ConexionTerminada
        Text = String.Format("Ventanilla fuera de servicio [{0}:{1}]", IDTerminal.Address.ToString, IDTerminal.Port)
    End Sub

    Private Sub socketServidor_DatosRecibidos(ByVal IDTerminal As System.Net.IPEndPoint) Handles socketServidor.DatosRecibidos
        Dim misdatos As String() = socketServidor.ObtenerDatos(IDTerminal).Split("@")

        If misdatos(2) = 0 Then
            SyncLock Me
                Using frmS As New frmSecuencia
                    frmS.Texto = String.Format("{0} - {1}", misdatos(0).Replace(" ", ""), misdatos(1))
                    frmS.Llamada = String.Format("Ticket, {0} pasar a ventanilla {1}", misdatos(0), misdatos(1))
                    frmS.ShowDialog()
                End Using
            End SyncLock

            lblS3.Text = lblS2.Text
            lblS2.Text = lblS1.Text
            lblS1.Text = misdatos(0).Replace(" ", "")

            lblV3.Text = lblV2.Text
            lblV2.Text = lblV1.Text
            lblV1.Text = String.Format("Ventanilla #{0}", misdatos(1))
        Else
            SyncLock Me
                Using frmS As New frmSecuencia
                    frmS.Texto = String.Format("{0} - {1}", misdatos(0).Replace(" ", ""), misdatos(1))
                    frmS.Llamada = String.Format("Ticket, {0} pasar a ventanilla {1}", misdatos(0), misdatos(1))
                    frmS.ShowDialog()
                End Using
            End SyncLock
        End If
    End Sub
End Class
