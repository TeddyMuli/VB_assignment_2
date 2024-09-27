Public Class MultiplicationTableForm
    Private Sub GenerateTableButton_Click(sender As Object, e As EventArgs) Handles GenerateTableButton.Click
        ' Clear the text box before generating the table
        MultiplicationTableTextBox.Clear()

        ' Append the header row to the text box
        MultiplicationTableTextBox.AppendText("* 1 2 3 4 5 6 7" & vbCrLf)

        ' Generate and append the multiplication table to the text box
        For i As Integer = 1 To 7
            Dim row As String = i.ToString() & " "
            For j As Integer = 1 To 7
                row &= (i * j).ToString() & " "
            Next
            MultiplicationTableTextBox.AppendText(row.Trim() & vbCrLf)
        Next
    End Sub
End Class
