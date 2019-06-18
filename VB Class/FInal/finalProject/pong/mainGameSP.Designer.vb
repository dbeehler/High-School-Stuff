<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainGameSP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainGameSP))
        Me.mainGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScorePlayer1 = New System.Windows.Forms.Label()
        Me.lblLivesPlayer1 = New System.Windows.Forms.Label()
        Me.picBallMain = New System.Windows.Forms.PictureBox()
        Me.picPaddle2 = New System.Windows.Forms.PictureBox()
        Me.picPaddle1 = New System.Windows.Forms.PictureBox()
        CType(Me.picBallMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaddle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaddle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainGameTimer
        '
        Me.mainGameTimer.Enabled = True
        Me.mainGameTimer.Interval = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(0, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(886, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'lblScorePlayer1
        '
        Me.lblScorePlayer1.AutoSize = True
        Me.lblScorePlayer1.ForeColor = System.Drawing.Color.White
        Me.lblScorePlayer1.Location = New System.Drawing.Point(106, 5)
        Me.lblScorePlayer1.Name = "lblScorePlayer1"
        Me.lblScorePlayer1.Size = New System.Drawing.Size(88, 13)
        Me.lblScorePlayer1.TabIndex = 4
        Me.lblScorePlayer1.Text = "Player 1 Score: 0"
        '
        'lblLivesPlayer1
        '
        Me.lblLivesPlayer1.AutoSize = True
        Me.lblLivesPlayer1.ForeColor = System.Drawing.Color.White
        Me.lblLivesPlayer1.Location = New System.Drawing.Point(12, 5)
        Me.lblLivesPlayer1.Name = "lblLivesPlayer1"
        Me.lblLivesPlayer1.Size = New System.Drawing.Size(85, 13)
        Me.lblLivesPlayer1.TabIndex = 5
        Me.lblLivesPlayer1.Text = "Player 1 Lives: 3"
        '
        'picBallMain
        '
        Me.picBallMain.Image = Global.pong.My.Resources.Resources.ball
        Me.picBallMain.Location = New System.Drawing.Point(65, 175)
        Me.picBallMain.Name = "picBallMain"
        Me.picBallMain.Size = New System.Drawing.Size(20, 20)
        Me.picBallMain.TabIndex = 2
        Me.picBallMain.TabStop = False
        '
        'picPaddle2
        '
        Me.picPaddle2.Image = Global.pong.My.Resources.Resources.Paddle
        Me.picPaddle2.Location = New System.Drawing.Point(862, 35)
        Me.picPaddle2.Name = "picPaddle2"
        Me.picPaddle2.Size = New System.Drawing.Size(10, 50)
        Me.picPaddle2.TabIndex = 1
        Me.picPaddle2.TabStop = False
        '
        'picPaddle1
        '
        Me.picPaddle1.Image = Global.pong.My.Resources.Resources.Paddle
        Me.picPaddle1.Location = New System.Drawing.Point(12, 35)
        Me.picPaddle1.Name = "picPaddle1"
        Me.picPaddle1.Size = New System.Drawing.Size(10, 50)
        Me.picPaddle1.TabIndex = 0
        Me.picPaddle1.TabStop = False
        '
        'mainGameSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(884, 412)
        Me.Controls.Add(Me.lblLivesPlayer1)
        Me.Controls.Add(Me.lblScorePlayer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBallMain)
        Me.Controls.Add(Me.picPaddle2)
        Me.Controls.Add(Me.picPaddle1)
        Me.Name = "mainGameSP"
        Me.ShowIcon = False
        Me.Text = "Pong"
        CType(Me.picBallMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaddle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaddle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPaddle1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPaddle2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBallMain As System.Windows.Forms.PictureBox
    Friend WithEvents mainGameTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScorePlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblLivesPlayer1 As System.Windows.Forms.Label

End Class
