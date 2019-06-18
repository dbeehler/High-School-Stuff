<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListCredis = New System.Windows.Forms.ListBox()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.btnDuck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(95, 204)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnCredits
        '
        Me.btnCredits.Location = New System.Drawing.Point(241, 204)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(75, 23)
        Me.btnCredits.TabIndex = 1
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(386, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ListCredis
        '
        Me.ListCredis.FormattingEnabled = True
        Me.ListCredis.Items.AddRange(New Object() {"Dusty: Pong, Flow Chart", "", "Rebecca: Bird Shoot", "", "Andrew: Main Menu"})
        Me.ListCredis.Location = New System.Drawing.Point(223, 84)
        Me.ListCredis.Name = "ListCredis"
        Me.ListCredis.Size = New System.Drawing.Size(120, 95)
        Me.ListCredis.TabIndex = 3
        Me.ListCredis.Visible = False
        '
        'btnNumber
        '
        Me.btnNumber.Location = New System.Drawing.Point(43, 233)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(90, 25)
        Me.btnNumber.TabIndex = 4
        Me.btnNumber.Text = "Number Guess"
        Me.btnNumber.UseVisualStyleBackColor = True
        Me.btnNumber.Visible = False
        '
        'btnDuck
        '
        Me.btnDuck.Location = New System.Drawing.Point(139, 233)
        Me.btnDuck.Name = "btnDuck"
        Me.btnDuck.Size = New System.Drawing.Size(90, 25)
        Me.btnDuck.TabIndex = 5
        Me.btnDuck.Text = "Duck Shoot"
        Me.btnDuck.UseVisualStyleBackColor = True
        Me.btnDuck.Visible = False
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.btnDuck)
        Me.Controls.Add(Me.btnNumber)
        Me.Controls.Add(Me.ListCredis)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.btnPlay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainMenu"
        Me.ShowIcon = False
        Me.Text = "mainMenu"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ListCredis As System.Windows.Forms.ListBox
    Friend WithEvents btnNumber As System.Windows.Forms.Button
    Friend WithEvents btnDuck As System.Windows.Forms.Button
End Class
