Public Class singleMutliPlayer

    Private Sub btnSP_Click(sender As Object, e As EventArgs) Handles btnSP.Click
        Dim frmPongSP As New mainGameSP
        frmPongSP.ShowDialog()
    End Sub

    Private Sub btnMP_Click(sender As Object, e As EventArgs) Handles btnMP.Click
        Dim frmPongMP As New mainGameMP
        frmPongMP.ShowDialog()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Close()
    End Sub

    Private Sub singleMutliPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class