Public Class Sales
    Const weeklyBasePay As Double = 2500
    Const quota As Double = 1000
    Const commissionRate As Double = 0.15

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim name As String = NameTextBox.Text
        Dim dailySales As Double = Double.Parse(SalesTextBox.Text)

        Dim weeklySales As Double = dailySales * 7

        Dim commission As Double = 0
        If weeklySales > quota Then
            commission = commissionRate * weeklySales
        End If

        Dim weeklySalary As Double = weeklyBasePay + commission

        ResultsListBox.Items.Add("Salesperson Name: " & name)
        ResultsListBox.Items.Add("Daily Sales: KSh " & dailySales.ToString("N2"))
        ResultsListBox.Items.Add("Weekly Sales: KSh " & weeklySales.ToString("N2"))
        ResultsListBox.Items.Add("Commission: KSh " & commission.ToString("N2"))
        ResultsListBox.Items.Add("Weekly Salary: KSh " & weeklySalary.ToString("N2"))
        ResultsListBox.Items.Add("")
    End Sub
End Class
