Imports System.Speech.Synthesis
Public Class frmSecuencia
    Dim voz As New SpeechSynthesizer


    Private _llamada As String
    Public Property Llamada() As String
        Get
            Return _llamada
        End Get
        Set(ByVal value As String)
            _llamada = value
        End Set
    End Property

    Private _texto As String
    Public Property Texto() As String
        Get
            Return _texto
        End Get
        Set(ByVal value As String)
            _texto = value
        End Set
    End Property

    Private Sub frmSecuencia_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label1.Text = Texto

    End Sub

    Private Sub frmSecuencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
    End Sub

    Private Sub frmSecuencia_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        Label1.Text = Texto
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Close()
    End Sub

    Public Sub Hablar()
        Dim leer As New Prompt(_llamada)
        With voz
            .SelectVoice(My.Settings.Voz)
            .Rate = -2
            .SetOutputToDefaultAudioDevice()
            .SpeakAsync(leer)
        End With
    End Sub

    Private Sub frmSecuencia_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Hablar()
    End Sub

End Class