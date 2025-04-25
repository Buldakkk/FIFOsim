Imports System.Net

Public Class Form1
    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        prbSplash.Value = prbSplash.Value + 5

        If prbSplash.Value = 100 Then
            tmrSplash.Enabled = False
            Home_Page.Show()
            Me.Hide()


        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSplash.Enabled = True
        prbSplash.Minimum = 0
        prbSplash.Maximum = 100
    End Sub
End Class
