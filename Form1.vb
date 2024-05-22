Public Class Form1
    Private secretCode As String
    Private attempts As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartGame()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim guess As String = txtGuess.Text 'Converts input in textbox from string to numerical value
        If IsValidGuess(guess) Then
            attempts += 1
            Dim feedback As String = GetFeedback(guess)
            lblFeedback.Text = feedback
            lstGuesses.Items.Add($"Attempt {attempts}: {guess} - {feedback}")
            If feedback.Contains("4 correct and in correct position") Then
                MessageBox.Show($"Congratulations! You've unlocked the box in {attempts} attempts")
                btnSubmit.Enabled = False
            End If

        Else
            MessageBox.Show("Invalid guess. Please enter 2 to 4 non-repititive digits between 1 and 9.")

        End If
    End Sub


    Private Sub StartGame()
        secretCode = GenerateSecretCode()
        attempts = 0
        lblFeedback.Text = String.Empty
        txtGuess.Text = String.Empty
        lstGuesses.Items.Clear()
        btnSubmit.Enabled = True
        MessageBox.Show("New game started! Enter your guess.")

    End Sub

    Private Function GenerateSecretCode() As String
        Dim digits As List(Of Integer) = Enumerable.Range(1, 9).ToList()
        Dim rnd As New Random()
        Dim codelength As Integer = rnd.Next(2, 5)
        Dim code As String = String.Empty

        For i As Integer = 1 To codelength
            Dim index As Integer = rnd.Next(digits.Count)
            code &= digits(index).ToString()
            digits.RemoveAt(index)
        Next
        Return code
    End Function

    Private Function IsValidGuess(guess As String) As Boolean
        If guess.Length < 2 OrElse guess.Length > 4 Then
            Return False
        End If

        For Each ch As Char In guess
            If Not Char.IsDigit(ch) OrElse ch = "0"c OrElse guess.Count(Function(C) C = ch) > 1 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function GetFeedback(guess As String) As String
        Dim correct As Integer = 0
        Dim correctPosition As Integer = 0

        For i As Integer = 0 To Math.Min(guess.Length, secretCode.Length) - 1
            If secretCode.Contains(guess(i)) Then
                correct += 1
                If secretCode(i) = guess(i) Then
                    correctPosition += 1
                End If
            End If
        Next

        Return $"{correct} correct and {correctPosition} in correct position"

    End Function

End Class
