Imports System.Drawing.Drawing2D


Public Class Simulator



    Private random As New Random()
    Private pageReferences As New List(Of Integer)  ' To store page references
    Private pageQueue As New Queue(Of Integer)  ' Queue for FIFO algorithm
    Private maxFrames As Integer = 3  ' Number of frames to be displayed
    Private pageFaults As Integer = 0  ' Page fault count




    ' This function rounds the corners of a panel
    Private Sub RoundPanelCorners(panel As Panel, radius As Integer)
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        panel.Region = New Region(path)
    End Sub



    Private Sub Simulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' lists the no. of frames to 5
        For i As Integer = 3 To 5
            cmbNoOfString.Items.Add(i)
        Next




        ' round corners of the panel
        RoundPanelCorners(pnlOutput, 50) ' 50 = curve radius




    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        lblRefStringOutput.Text = lblRefStringInput.Text
        lblNoOfStringOutput.Text = cmbNoOfString.Text


        ' displays a message if the reference string is empty
        If String.IsNullOrEmpty(lblRefStringInput.Text) Then
            MessageBox.Show("Please click the 'Generate' button first to create a reference string.", "Input Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If




        ' Reset panel and variables
        'pnlOutput.Controls.Clear()
        pageReferences.Clear()
        pageQueue.Clear()
        pageFaults = 0
        lblPageFaults.Text = " "



        ' Get the number of frames from ComboBox
        If cmbNoOfString.SelectedItem Is Nothing Then
            MessageBox.Show("Please select the number of frames.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        maxFrames = Convert.ToInt32(cmbNoOfString.SelectedItem)















    End Sub





    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Me.Hide()
        About.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Home_Page.Show()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click



        ' Clear previous page references
        pageReferences.Clear()


        ' Generate random page references (between 5 and 25)
        Dim numPages As Integer = random.Next(5, 25)
        For i As Integer = 1 To numPages
            pageReferences.Add(random.Next(0, 10)) ' Numbers between 0 to 9
        Next

        ' Display reference string in the Label
        lblRefStringInput.Text = String.Join(" ", pageReferences)




    End Sub


End Class
