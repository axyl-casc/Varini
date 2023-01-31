Public Class Negotiation

    Private neigh As New List(Of Tribe)
    Private player As New Tribe
    Private isDip As Boolean = False
    Private avgPowerLevel As Double = 0

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Me.Close()
    End Sub

    Public Sub updateRender(avgPower As Double, playerTribe As Tribe, data As Map, x As Integer, y As Integer)

        Dim isAnyone As Boolean = False
        Dim io As Dictionary(Of String, Tile) = data.getMapData()
        player = playerTribe
        avgPowerLevel = avgPower
        goldLabel.Text = "Gold: " & player.gold.ToString
        neigh.Clear()

        'right
        If Not (io(x + 1 & "," & y).Occupant.Title = "_" Or io(x + 1 & "," & y).Occupant.Title = "~") Then
            isAnyone = True
            neigh.Add(io(x + 1 & "," & y).Occupant)
        End If
        'left
        If Not (io(x - 1 & "," & y).Occupant.Title = "_" Or io(x - 1 & "," & y).Occupant.Title = "~") Then
            isAnyone = True
            neigh.Add(io(x - 1 & "," & y).Occupant)
        End If
        'up
        If Not (io(x & "," & y - 1).Occupant.Title = "_" Or io(x & "," & y - 1).Occupant.Title = "~") Then
            isAnyone = True
            neigh.Add(io(x & "," & y - 1).Occupant)
        End If
        'down
        If Not (io(x & "," & y + 1).Occupant.Title = "_" Or io(x & "," & y + 1).Occupant.Title = "~") Then
            isAnyone = True
            neigh.Add(io(x & "," & y + 1).Occupant)
        End If

        If Not isAnyone Then
            neiList.Visible = False
            errLabel.Visible = True
        Else
            'if negotiations can start

            'disp[lay nearby groups
            For Each t As Tribe In neigh
                neiList.Items.Add(t.Title)
            Next
            neiList.Visible = True
        End If

    End Sub

    Private Sub showStuff(b As Boolean)
        actionBox.Visible = b
        infoGroup.Visible = b
        eventList.Visible = b
    End Sub

    Private Function getSel() As Tribe
        Return neigh(neiList.SelectedIndex())
    End Function

    'get diff in number
    Private Function diff(n1 As Double, n2 As Double) As Double
        If n1 > n2 Then
            Return n1 - n2
        Else
            Return n2 - n1
        End If
    End Function

    Private Sub neiList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles neiList.SelectedIndexChanged
        If neiList.SelectedIndex = -1 Then
            showStuff(False)
            Return
        End If

        showStuff(True)
        Dim selTribe As New Tribe
        'get current selected tribe
        selTribe = getSel()
        infoGroup.Text = selTribe.Title + "'s Info"

        Dim dispString As String
        dispString = "Tribe: " & selTribe.Title & vbCrLf
        dispString += "Members: " & selTribe.members.Count.ToString & vbCrLf
        If selTribe.isDiverse Then
            dispString += "Tribe Diversity: Good" & vbCrLf
        Else
            dispString += "Tribe Diversity: Too Low" & vbCrLf
        End If

        dispString += "Power: " & selTribe.Power.ToString("n") & vbCrLf

        If selTribe.diplomatic And diff(selTribe.Power, player.Power) < avgPowerLevel - 1 And Game.celebrateCooldown <= 10 And Game.celebrateCooldown >= 0 Then
            isDip = True
            dispString += "Tribe is willing to negotiate." & vbCrLf
        Else
            isDip = False
            dispString += "Tribe is not willing to negotiate." & vbCrLf
        End If

        infoLabel.Text = dispString
        goldLabel.Text = "Gold: " & player.gold.ToString
        actionBox.Visible = isDip


    End Sub


    Private Sub knowButton_Click(sender As Object, e As EventArgs) Handles knowButton.Click
        Dim selTribe As New Tribe
        'get current selected tribe
        selTribe = getSel()

        If player.checkGold(20) Then
            selTribe.gold += 20
            If selTribe.diplomatic Then
                player.upgrade("farm")
                player.upgrade("abode")
                selTribe.upgrade("farm")
                selTribe.upgrade("abode")
            Else
                player.upgrade("barracks")
                selTribe.upgrade("barracks")
            End If
            eventList.Items.Insert(0, "Got some knowledge from " & selTribe.ToString & ".")
        Else
            goldLabel.ForeColor = Color.Red
        End If
        goldLabel.Text = "Gold: " & player.gold.ToString
    End Sub

    Private Sub recruitButton_Click(sender As Object, e As EventArgs) Handles recruitButton.Click
        Dim selTribe As New Tribe
        selTribe = getSel()

        If player.checkGold(20) Then
            If selTribe.members.Count > 10 Then
                Dim tempPerson As Person = selTribe.killMember(CInt(Math.Floor(CDbl(selTribe.members.Count / 2))))
                eventList.Items.Insert(0, "Got " & tempPerson.ToString & " from " & selTribe.ToString & ".")
                selTribe.gold += 20
                player.AddMember(tempPerson)
            Else
                eventList.Items.Insert(0, selTribe.ToString & " do not have enough people.")
            End If

        Else
            goldLabel.ForeColor = Color.Red
        End If
        goldLabel.Text = "Gold: " & player.gold.ToString
    End Sub

    Private Sub Negotiation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showStuff(False)
    End Sub
End Class