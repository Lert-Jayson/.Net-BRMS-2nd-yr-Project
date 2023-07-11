Imports System.Speech.Synthesis
Imports System.Data.Odbc

Public Class frm_loadscreen
    Dim readUser As OdbcDataReader
    Dim speaker As New SpeechSynthesizer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            frm_login.Show()
            Me.Close()

        End If
    End Sub

    Private Sub frm_loadscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class