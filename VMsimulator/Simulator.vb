


Public Class Simulator



    Private random As New Random()
    Private pageReferences As New List(Of Integer)  ' To store page references
    Private maxFrames As Integer = 3  ' Number of frames to be displayed
    Private pageFaults As Integer = 0  ' Page fault count




    Private Sub Simulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' lists the no. of frames to 5
        For i As Integer = 3 To 5
            cmbNoOfString.Items.Add(i)
        Next










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

        pageReferences.Clear()
        pageFaults = 0
        lblPageFaults.Text = "0"



        ' Get the number of frames from ComboBox
        If cmbNoOfString.SelectedItem Is Nothing Then
            MessageBox.Show("Please select the number of frames.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        maxFrames = Convert.ToInt32(cmbNoOfString.SelectedItem)








        ' Parse the reference string from the Label
        Dim referenceArray() As String = lblRefStringInput.Text.Split(" "c)
        pageReferences = referenceArray.Select(Function(x) Convert.ToInt32(x)).ToList()

        ' Run FIFO Algorithm
        FIFOalgo()

        ' Display page fault count
        lblPageFaults.Text = pageFaults



    End Sub



    Private Sub FIFOalgo()
        Dim frameList As New List(Of Integer)() ' To maintain the order of frames
        Dim frameSet As New HashSet(Of Integer)() ' To quickly check if a page exists
        Dim pointer As Integer = 0 ' Pointer to track the oldest page
        pnlFifo.Controls.Clear()

        Dim xOffset As Integer = 10 ' Horizontal position for each step

        For Each pageNum In pageReferences
            Dim isPageFault As Boolean = False
            Dim stepPanel As New Panel()
            stepPanel.Width = 100
            stepPanel.Height = 260
            stepPanel.Left = xOffset
            stepPanel.Top = 50
            stepPanel.BackColor = Color.Beige
            stepPanel.BorderStyle = BorderStyle.FixedSingle

            ' Check if the page is already in memory
            If Not frameSet.Contains(pageNum) Then
                isPageFault = True
                pageFaults += 1

                If frameList.Count < maxFrames Then
                    ' Add the new page if there's still space
                    frameList.Add(pageNum)
                    frameSet.Add(pageNum)
                Else
                    ' Replace the oldest page using the pointer logic
                    Dim removedPage As Integer = frameList(pointer)
                    frameSet.Remove(removedPage)

                    frameList(pointer) = pageNum
                    frameSet.Add(pageNum)

                    ' Move the pointer circularly
                    pointer = (pointer + 1) Mod maxFrames
                End If
            End If

            ' Display current frames in FIFO order
            Dim yOffset As Integer = 10
            For i As Integer = 0 To maxFrames - 1
                Dim lblEmpty As New Label()

                If i < frameList.Count Then
                    lblEmpty.Text = frameList(i).ToString() ' Display the page in the frame
                Else
                    lblEmpty.Text = "-"
                End If

                lblEmpty.Width = 60
                lblEmpty.Height = 30
                lblEmpty.Left = 20
                lblEmpty.Top = yOffset
                lblEmpty.TextAlign = ContentAlignment.MiddleCenter
                lblEmpty.BackColor = If(i < frameList.Count, Color.White, Color.WhiteSmoke)
                lblEmpty.BorderStyle = BorderStyle.FixedSingle
                stepPanel.Controls.Add(lblEmpty)
                yOffset += 40
            Next

            ' Add fault/hit indicator
            Dim faultLabel As New Label()
            faultLabel.Width = 60
            faultLabel.Height = 30
            faultLabel.Left = 20
            faultLabel.Top = stepPanel.Height - 50
            faultLabel.TextAlign = ContentAlignment.MiddleCenter
            faultLabel.Text = If(isPageFault, "Fault", "Hit")
            faultLabel.ForeColor = If(isPageFault, Color.Red, Color.Green)
            stepPanel.Controls.Add(faultLabel)



            pnlFifo.Controls.Add(stepPanel)
            xOffset += 120 ' Move to next position
        Next

        ' Update page fault count
        lblPageFaults.Text = pageFaults.ToString()

        ' Enable scrolling if needed
        pnlFifo.HorizontalScroll.Enabled = (xOffset > pnlFifo.Width)
        pnlFifo.AutoScroll = True


        Console.WriteLine(pageFaults.ToString())
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


        ' Generate random page references (between 20 and 25)
        Dim numPages As Integer = random.Next(20, 25)
        For i As Integer = 1 To numPages
            pageReferences.Add(random.Next(0, 10)) ' Numbers between 0 to 9
        Next

        ' Display reference string in the Label
        lblRefStringInput.Text = String.Join(" ", pageReferences)




    End Sub


End Class
