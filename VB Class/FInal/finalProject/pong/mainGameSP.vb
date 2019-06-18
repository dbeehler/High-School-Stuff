Public Class mainGameSP
    Dim xSpeedOfBall As Double = 10.5
    Dim ySpeedOfBall As Double = 5.0
    Dim playerOneLives As Integer = 3
    Dim scorePlayer1 As Integer = 0
    Dim running As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Me.Size = New Size(900, 450)
        randomNumberMaker()
    End Sub

    Private Sub paddle1Move(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            picPaddle1.Top -= 12
            If picPaddle1.Top < 35 Then
                picPaddle1.Top = 37
            End If
        ElseIf e.KeyCode = Keys.S Then
            picPaddle1.Top += 12
            If picPaddle1.Top > 350 Then
                picPaddle1.Top = 350
            End If
        End If
    End Sub

    Private Sub Collison(sender As Object, e As EventArgs) Handles mainGameTimer.Tick
        'AI
        picPaddle2.Location = New Point(862, picBallMain.Location.Y)

        'Bounds for AI paddle
        If picPaddle2.Top < 35 Then
            picPaddle2.Top = 37
        End If
        If picPaddle2.Top > 350 Then
            picPaddle2.Top = 350
        End If
        'Moves ball to new point by creating (X, Y) based on speed variable
        picBallMain.Location = New Point(picBallMain.Location.X + xSpeedOfBall, picBallMain.Location.Y + ySpeedOfBall)

        'Paddle 2 collision
        If picBallMain.Bounds.IntersectsWith(picPaddle2.Bounds) Then
            picBallMain.Location = New Point(picPaddle2.Location.X - picBallMain.Size.Width, _picBallMain.Location.Y)
            xSpeedOfBall = -xSpeedOfBall
            My.Computer.Audio.Play(My.Resources.pongCollision, AudioPlayMode.Background)
        End If

        'Paddle 1 collision
        If picBallMain.Bounds.IntersectsWith(picPaddle1.Bounds) Then
            scorePlayer1 += 1
            picBallMain.Location = New Point(picPaddle1.Location.X + picBallMain.Size.Width + 1, _picBallMain.Location.Y)
            xSpeedOfBall = -xSpeedOfBall
            lblScorePlayer1.Text = "Player 1 Score: " & scorePlayer1
            My.Computer.Audio.Play(My.Resources.pongCollision, AudioPlayMode.Background)
        End If

        'Bottom wall collision
        If picBallMain.Location.Y > Me.Height - picBallMain.Size.Height - 45 Then
            picBallMain.Location = New Point(picBallMain.Location.X, Me.Height - picBallMain.Size.Height - 45)
            ySpeedOfBall = -ySpeedOfBall
        End If

        'Top wall
        If picBallMain.Location.Y < 35 Then
            picBallMain.Location = New Point(picBallMain.Location.X, 35)
            ySpeedOfBall = -ySpeedOfBall
        End If

        'Scoring
        If picBallMain.Location.X < 12 Then
            playerOneLives -= 1
            scorePlayer1 -= 3
            picBallMain.Location = New Point(65, 175)
            lblLivesPlayer1.Text = "Player 1 Lives: " & playerOneLives
            lblScorePlayer1.Text = "Player 1 Score: " & scorePlayer1
            Threading.Thread.Sleep(500)
            randomNumberMaker()
        End If

        If playerOneLives = 0 Then
            mainGameTimer.Enabled = False
            MessageBox.Show("You Lost. Your score was " & scorePlayer1)
            Dim result As Integer = MessageBox.Show("Would you like to play again?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If result = DialogResult.Cancel Then
                'nothing
            ElseIf result = DialogResult.No Then
                Me.Close()
            ElseIf result = DialogResult.Yes Then
                scorePlayer1 = 0
                picBallMain.Location = New Point(65, 175)
                randomNumberMaker()
                lblScorePlayer1.Text = "Player 1 Score: " & scorePlayer1
                mainGameTimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub randomNumberMaker()
        xSpeedOfBall = CDbl(Rnd() * 10 + 5)
        ySpeedOfBall = CDbl(Rnd() * 7.5 + 1)
    End Sub

    Private Sub picPaddle1_Click(sender As Object, e As EventArgs) Handles picPaddle1.Click
        lblScorePlayer1.Text = "I'm done"
    End Sub
End Class
