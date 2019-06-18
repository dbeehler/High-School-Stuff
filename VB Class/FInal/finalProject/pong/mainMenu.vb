Public Class mainMenu

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        If ListCredis.Visible = True Then
            ListCredis.Visible = False
        ElseIf ListCredis.Visible = False Then
            ListCredis.Visible = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        btnDuck.Visible = True
        btnNumber.Visible = True
        If btnPlay.Text = "Pong" Then
            Dim frmDecide As New singleMutliPlayer
            frmDecide.ShowDialog()
        End If
        btnPlay.Text = "Pong"
    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        Dim frmNumber As New randomNumber
        frmNumber.ShowDialog()
    End Sub

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class