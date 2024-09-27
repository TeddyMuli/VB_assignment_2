Public Class LengthyProcessForm
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        ' Start the simulation
        ProgressBar1.Value = 0
        Timer1.Enabled = True
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        ' Stop the simulation
        Timer1.Enabled = False
        ProgressBar1.Value = 0
        ProgressLabel.Text = "0%"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update progress bar and label
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 10
            ProgressLabel.Text = ProgressBar1.Value.ToString() & "%"
        Else
            Timer1.Enabled = False
        End If
    End Sub
End Class
