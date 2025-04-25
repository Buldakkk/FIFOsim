Public Class Simulator



    ' lists the no. of frames to 100
    Private Sub Simulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 100
            cmbNoOfString.Items.Add(i)
        Next
    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        lblRefStringOutput.Text = lblRefStringInput.Text
        lblNoOfStringOutput.Text = cmbNoOfString.Text

    End Sub
End Class