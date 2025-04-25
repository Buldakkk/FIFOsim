Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit


Public Class Home_Page


    ' for round corners of button
    Private Sub RoundButtonCorners(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btn.Region = New Region(path)
    End Sub







    ' for text animation
    Dim fullText As String = "Hello, Welcome To My Simulator!"
    Dim i As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i < fullText.Length Then
            lblVMS.Text &= fullText(i)
            i += 1
        Else
            Timer1.Stop()
        End If
    End Sub





    Private Sub Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' for text animation
        lblVMS.Text = ""
        Timer1.Start()



        RoundButtonCorners(btnClickToStart, 20) ' for round buttons
    End Sub

    Private Sub btnClickToStart_Click(sender As Object, e As EventArgs) Handles btnClickToStart.Click
        Me.Hide()
        Simulator.Show()
    End Sub
End Class