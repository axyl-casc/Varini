Public Class Combat

    Private data As New Dictionary(Of String, Tile)
    Private options As New List(Of Tribe)
    Private xPos As Integer
    Private yPos As Integer
    Private sel As Tribe

    Private FriendlyTribe As Tribe
    Public Sub updateData(g As Game, m As Map)
        data = m.getMapData()
        xPos = g.xPos
        yPos = g.yPos

        FriendlyTribe = g.cTribe
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        Dim winAbout As New about
        winAbout.dest = "data/info/battle.html"
        winAbout.Show()
    End Sub

    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click
        hideDoneTimer.Enabled = False
        Me.Close()
    End Sub

    Private Sub process(rx As Integer, ry As Integer)
        'oh no
        If Not data((xPos + rx).ToString & "," & (yPos + ry).ToString).Occupant.ToString = "_" And Not data((xPos + rx).ToString & "," & (yPos + ry).ToString).Occupant.ToString = "~" Then
            selectionList.Items.Add(data((xPos + rx).ToString & "," & (yPos + ry).ToString).Occupant.ToString)
            options.Add(data((xPos + rx).ToString & "," & (yPos + ry).ToString).Occupant)
        End If
    End Sub

    Private Sub Combat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectionList.Visible = False
        confirmButton.Visible = False
        cancelButton.Visible = False
        hideDoneTimer.Enabled = True

        process(1, 0)
        process(-1, 0)
        process(0, 1)
        process(0, -1)


    End Sub

    Private Sub addEvent(s As String)
        eventList.Items.Insert(0, s)
    End Sub

    Private Sub warButton_Click(sender As Object, e As EventArgs) Handles warButton.Click
        eventList.Items.Clear()

        If selectionList.Items.Count < 1 Then
            Return
        End If
        battleBar.Value = 25
        selectionList.Visible = True
        addEvent("Please select who you want to attack.")
    End Sub

    Private Sub selectionList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectionList.SelectedIndexChanged
        If selectionList.SelectedIndex >= 0 Then
            battleBar.Value = 50
            eventList.Items.Clear()
            sel = options(selectionList.SelectedIndex)
            addEvent("Target: " & sel.ToString & " - Power: " & sel.Power.ToString("n"))
            addEvent("You: " & FriendlyTribe.ToString & " - Power: " & FriendlyTribe.Power.ToString("n"))
            confirmButton.Visible = True
            cancelButton.Visible = True
        End If
    End Sub


    Private Sub lapse()
        For Each ePerson As Person In sel.members
            For Each fPerson As Person In FriendlyTribe.members
                Dim rNum As New Random

                'goes to every member and compares strength stat
                If (ePerson.stat.Strength * sel.members.Count + rNum.Next(0, 5)) > (fPerson.stat.Strength * FriendlyTribe.members.Count + rNum.Next(0, 5)) Then
                    FriendlyTribe.members.Remove(fPerson)
                    lapse()
                    Return
                Else
                    sel.members.Remove(ePerson)
                    lapse()
                    Return
                End If
            Next
        Next
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click

        battleBar.Value = 75

        Dim before_F As Integer = FriendlyTribe.members.Count
        Dim before_E As Integer = sel.members.Count

        lapse()

        eventList.Items.Clear()

        addEvent(" ")

        addEvent("After: " & sel.members.Count.ToString)
        addEvent("Casualties: " & (before_E - sel.members.Count).ToString)
        addEvent("Before: " & before_E.ToString)
        addEvent(sel.ToString & ":")

        addEvent(" ")

        addEvent("Remaining: " & FriendlyTribe.members.Count.ToString)
        addEvent("Casualties: " & (before_F - FriendlyTribe.members.Count).ToString)
        addEvent("Before: " & before_F.ToString)
        addEvent(FriendlyTribe.ToString & ":")

        battleBar.Value = 100

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        selectionList.Visible = False
        confirmButton.Visible = False
        cancelButton.Visible = False
        battleBar.Value = 0

        eventList.Items.Clear()
    End Sub

    Private Sub settlementButton_Click(sender As Object, e As EventArgs) Handles settlementButton.Click
        addEvent("There are no villages to raid.")
    End Sub

    Private Sub battleButtonLocal_Click(sender As Object, e As EventArgs) Handles battleButtonLocal.Click
        addEvent("Your tribe rallies. Warcries can be heard for miles.")
        FriendlyTribe.upgrade("barracks")
    End Sub

    Private Sub hideDoneTimer_Tick(sender As Object, e As EventArgs) Handles hideDoneTimer.Tick
        If battleBar.Value = 0 Or battleBar.Value = 100 Then
            doneButton.Enabled = True
        Else
            doneButton.Enabled = False
        End If
    End Sub
End Class
