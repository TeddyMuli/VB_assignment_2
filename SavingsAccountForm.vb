Public Class SavingsAccountForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Clear the list box before displaying new results
        ResultsListBox.Items.Clear()

        ' Original amount invested
        Dim P As Double = 1000000

        ' Annual interest rate
        Dim R As Double = 0.05

        ' Calculate and display the amount at the end of each year for 10 years
        For year As Integer = 1 To 10
            Dim A As Double = P * (1 + R) ^ year
            ResultsListBox.Items.Add("Year " & year.ToString() & ": KSh " & A.ToString("N2"))
        Next
    End Sub
End Class
