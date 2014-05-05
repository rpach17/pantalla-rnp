Imports System.Speech.Synthesis
Imports System.Xml

Public Class frmConfig
    Dim voz As New SpeechSynthesizer

    Private Sub frmConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox(String.Format("¿Desea salir?{0}¿Configuro la voz correcta?", vbCrLf), MsgBoxStyle.Question + vbYesNo, "Configuracion de Voz") = MsgBoxResult.Yes Then
            Try
                End
            Catch ex As Exception
            End Try
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each v As InstalledVoice In voz.GetInstalledVoices
            cboVoces.Items.Add(v.VoiceInfo.Name.ToString())
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        My.Settings.Voz = cboVoces.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub btnProbar_Click(sender As Object, e As EventArgs) Handles btnProbar.Click
        Try
            With voz
                .SelectVoice(cboVoces.SelectedItem)
                .Rate = -2
                .Speak(txtPrueba.Text)
            End With
        Catch ex As Exception
            MsgBox("Voz no soportada", MsgBoxStyle.Information, "Configuración de Voz")
        End Try
        
    End Sub
End Class