Public Class randomNumber
    Dim guess As Integer
    Dim secret As Integer
    Dim lives As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lives = 3
        secret = CInt(Rnd() * 10)
        Try
            Do While lives > 0 Or guess = secret
                guess = InputBox("Enter a number from 0 - 10")
                If guess = secret Then
                    MessageBox.Show("You Win!")
                    Stop
                ElseIf guess < secret Then
                    MessageBox.Show("Your guess was too low")
                    lives -= 1
                ElseIf guess > secret Then
                    MessageBox.Show("Your guess was too high")
                    lives -= 1
                End If
                If lives = 0 Then
                    MessageBox.Show("You lose! The number was " & secret)
                End If
            Loop
        Catch ex As Exception
            MessageBox.Show("Please enter a number!")
        End Try
    End Sub

    Private Sub randomNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class