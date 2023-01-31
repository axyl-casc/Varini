Public Class ScoutWindow
    Public Sub updateRender(data As Map, x As Integer, y As Integer)
        'clear boxes on update
        listBoxNorth.Items.Clear()
        listBoxEast.Items.Clear()
        listBoxLocal.Items.Clear()
        listBoxSouth.Items.Clear()
        listBoxWest.Items.Clear()

        'add info for north box
        listBoxNorth.Items.Add("Northern Region:")
        For Each bit As String In data.getInfo(x, y - 1).Split(CChar("="))
            listBoxNorth.Items.Add(bit)
        Next

        'add info for south box
        listBoxSouth.Items.Add("Southern Region:")
        For Each bit As String In data.getInfo(x, y + 1).Split(CChar("="))
            listBoxSouth.Items.Add(bit)
        Next

        'add info for local box
        listBoxLocal.Items.Add("Local Region:")
        For Each bit As String In data.getInfo(x, y).Split(CChar("="))
            listBoxLocal.Items.Add(bit)
        Next

        'add info for east box
        listBoxEast.Items.Add("Eastern Region:")
        For Each bit As String In data.getInfo(x + 1, y).Split(CChar("="))
            listBoxEast.Items.Add(bit)
        Next

        'add info for west box
        listBoxWest.Items.Add("Western Region:")
        For Each bit As String In data.getInfo(x - 1, y).Split(CChar("="))
            listBoxWest.Items.Add(bit)
        Next

    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Me.Visible = False
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        Dim winAbout As New about
        winAbout.dest = "data/info/scout.html"
        winAbout.Show()
    End Sub

    Private Sub ScoutWindow_Load(sender As Object, e As EventArgs)

    End Sub
End Class