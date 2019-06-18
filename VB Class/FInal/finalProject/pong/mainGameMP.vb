Public Class mainGameMP
    Dim xSpeedOfBall As Double = 10.5
    Dim ySpeedOfBall As Double = 5.0
    Dim scorePlayer1 As Integer = 0
    Dim scorePlayer2 As Integer = 0
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

    Private Sub paddle2move(ByVal sender As System.Object, ByVal d As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If d.keycode = keys.up Then
            picpaddle2.top -= 12
            If picpaddle2.top < 35 Then
                picpaddle2.top = 37
            End If
        ElseIf d.keycode = keys.down Then
            picpaddle2.top += 12
            If picpaddle2.top > 350 Then
                picpaddle2.top = 350
            End If
        End If
    End Sub

    Private Sub Collison(sender As Object, e As EventArgs) Handles mainGameTimer.Tick
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
            picBallMain.Location = New Point(picPaddle1.Location.X + picBallMain.Size.Width + 1, _picBallMain.Location.Y)
            xSpeedOfBall = -xSpeedOfBall
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
            scorePlayer2 += 1
            picBallMain.Location = New Point(65, 175)
            lblScorePlayer2.Text = "Player 2 Score: " & scorePlayer2
            Threading.Thread.Sleep(500)
            randomNumberMaker()
        ElseIf picBallMain.Location.X > 865 Then
            scorePlayer1 += 1
            picBallMain.Location = New Point(800, 175)
            lblScorePlayer1.Text = "Player 1 Score: " & scorePlayer1
            Threading.Thread.Sleep(500)
            randomNumberMaker()
            xSpeedOfBall = -xSpeedOfBall
        End If

        If scorePlayer2 >= 8 Or scorePlayer1 >= 8 Then
            mainGameTimer.Enabled = False
            Dim result As Integer = MessageBox.Show("Would you like to play again?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If result = DialogResult.Cancel Then
                'nothing
            ElseIf result = DialogResult.No Then
                Me.Close()
            ElseIf result = DialogResult.Yes Then
                scorePlayer1 = 0
                scorePlayer2 = 0
                picBallMain.Location = New Point(65, 175)
                randomNumberMaker()
                lblScorePlayer1.Text = "Player 1 Score: " & scorePlayer1
                lblScorePlayer2.Text = "Player 2 Score: " & scorePlayer2
                mainGameTimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub randomNumberMaker()
        xSpeedOfBall = CDbl(Rnd() * 10 + 10)
        ySpeedOfBall = CDbl(Rnd() * 7.5 + 1)
    End Sub

    Private Sub picPaddle1_Click(sender As Object, e As EventArgs) Handles picPaddle1.Click
        lblScorePlayer1.Text = "I'm done"
    End Sub
End Class
