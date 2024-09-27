Public Class ASCII
    Private Sub GetNextCharacterButton_Click(sender As Object, e As EventArgs) Handles GetNextCharacterButton.Click
        Dim inputChar As String = InputBox("Enter a character:", "Input Character")

        Dim nextChar As String = GetNextCharacter(inputChar)

        MessageBox.Show("The next character after '" & inputChar & "' is '" & nextChar & "'.", "Next Character")
    End Sub

    Private Function GetNextCharacter(inputChar As String) As String
        ' Get the ASCII value of the input character
        Dim asciiValue As Integer = Asc(inputChar)

        ' Increment the ASCII value to get the next character
        Dim nextAsciiValue As Integer = asciiValue + 1

        ' Convert the next ASCII value back to a character
        Dim nextChar As String = Chr(nextAsciiValue)

        ' Return the next character
        Return nextChar
    End Function
End Class
