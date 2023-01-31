Public Class MainMenu
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        Dim winAbout As New about
        winAbout.dest = "home"
        winAbout.Show()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        playButton.Enabled = False
        Dim GameWindow As New Game
        'Me.Hide()
        GameWindow.Show()
        'Me.Show()
    End Sub
End Class
