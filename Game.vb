'by axyl schulz
'dec 4 2019
'game where you play as the Varini tribe and link it to them historically.

Public Class Game

    'add in events per turn
    'add in info for about menu ***

    Public averagePower As Double
    Public tribeList As New List(Of Tribe)

    Public NamesList As New Names
    Public cYear As Integer
    Private BC As Boolean
    Public cTribe As New Tribe
    Private RandomEvent As New rEvent
    Public celebrateCooldown As Integer = 0

    'check to see if you can cross it on map, also check map data

    'window declarations
    Private mapWindow As New Map
    Private scoutWin As New ScoutWindow

    Public Sub closeGame()
        MainMenu.playButton.Enabled = True
        MainMenu.playButton.Focus()
        mapWindow.Close()
        scoutWin.Close()
        Me.Close()
    End Sub

    'x and y POS
    Public xPos As Integer = 20
    Public yPos As Integer = 9

    'GAME YEARS GO DOWN TO 50, THEN START GOING UP...
    'SO IF cYear IS MORE THAN 50, 100+ TURNS HAVE PASSED.. SO UP DIFFICULTY
    Public Sub updateTribes()
        scoutWin.updateRender(mapWindow, xPos, yPos)
        'cTribe.AIupdate(cYear, mapWindow, Me)
        'tribeList(0).setpos(xPos, yPos)
        Dim i As Integer
        For i = 0 To tribeList.Count - 1
            If tribeList(i).dead Then
                tribeList.RemoveAt(i)
                updateTribes()
                Return
            End If
        Next

        For Each t As Tribe In tribeList
            t.AIupdate(cYear, mapWindow, Me)
            If Not (t.Sym = "v" Or t.Sym = "V") Then
                mapWindow.addToMap(t)
            End If

        Next

        cTribe.update(Me)

    End Sub

    'game load menu
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cYear = 50
        BC = True

        yearLabel.Text = cYear.ToString + " BC"
        commandGroup.Visible = False
        buildGroup.Visible = False
        travelGroup.Visible = False
        scoutWin.Visible = False

        'Create Seeer
        Dim seeer As New Person
        seeer = seeer.newPerson()
        seeer.Role = "Caretaker"
        seeer.setStats()
        seeer.pName = "Askr"
        seeer.Gender = "Male"
        seeer.Age = 16
        seeer.Faith = 100
        seeer.origin = "Varini"

        'generic things that need to be added...
        cTribe.AddMember(seeer)
        cTribe.Title = "Varini"
        cTribe.setpos(xPos, yPos)
        cTribe.update(Me)

        mapWindow.setPlayerPos(xPos, yPos)
        mapWindow.newSet()


        'positionLabel.Text = xPos.ToString + ", " + yPos.ToString
        tribeList.Add(cTribe)


        'play pos is 20, 9
        'SET ALL TRIBES BEFORE GAME STARTS
        'NAME, POPULATION, X, Y, NEGOTIATION

        newTribe("Roman Empire", 10, 20, 13, False)
        newTribe("Roman Empire", 10, 23, 13, False)
        newTribe("Roman Empire", 25, 22, 13, True)
        newTribe("Roman Empire", 50, 21, 14, True)
        newTribe("Roman Empire", 25, 21, 15, True)
        newTribe("Roman Empire", 40, 21, 13, True)

        newTribe("Saxons", 10, 16, 10, False)
        newTribe("Saxons", 15, 17, 10, False)

        newTribe("Lemovii", 20, 22, 10, True)

        newTribe("Eudonses", 20, 18, 9, True)

        newTribe("Huns", 45, 17, 6, False)
        newTribe("Huns", 45, 18, 5, False)

        newTribe("Semnones", 45, 22, 11, True)
        newTribe("Semnones", 45, 23, 11, True)
        newTribe("Semnones", 45, 24, 11, True)

        'adds someone smart for the tribe when its diplomatic
        For Each element As Tribe In tribeList
            If element.diplomatic Then
                Dim entity As New Person
                entity = entity.newPerson()
                entity.Age = 12
                entity.Role = "Caretaker"
                entity.setStats()
                entity.makeSmart()

                element.AddMember(entity)
            End If
        Next

        'random update subs.... help
        updateTribes()
        cTribe.update(Me)
        mapWindow.updatePlayerPos(xPos, yPos, cTribe)
        scoutWin.updateRender(mapWindow, xPos, yPos)
        gameOver()

        'display gold
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub
    Public Sub newTribe(title As String, members As Integer, x As Integer, y As Integer, diplomatic As Boolean)
        Dim tempTribe As New Tribe
        tempTribe.Title = title
        tempTribe.setpos(x, y)
        tempTribe.diplomatic = diplomatic
        Dim a As Integer

        For a = 0 To members Step 1
            Dim tempPerson As New Person
            tempPerson = tempPerson.newPerson()
            tempPerson.origin = tempTribe.Title
            tempTribe.AddMember(tempPerson)
        Next

        tribeList.Add(tempTribe)

    End Sub

    'add text to event cmd thingy on window
    Public Sub addEvent(msg As String)
        msg = vbCrLf + Now().ToShortTimeString + ": " + msg
        eventList.Items.Insert(0, msg)
    End Sub

    Public Sub addPop(msg As String)
        popList.Items.Add(msg)
    End Sub

    Private Sub gameOver()
        If cTribe.dead Then
            MessageBox.Show("Game Over", "You have died...", MessageBoxButtons.OK)
            closeGame()
        End If
    End Sub

    'actions ****************
    'when turn button is pressed... (next turn)
    Private Sub turn()
        Dim totalTribalPower As Double = 0
        For Each element As Tribe In tribeList
            totalTribalPower += element.Power
        Next
        averagePower = totalTribalPower / tribeList.Count

        addEvent("Next turn...")
        If (BC) Then
            cYear -= 2
            yearLabel.Text = cYear.ToString + " BC"
        Else
            cYear += 2
            yearLabel.Text = cYear.ToString + " AD"
        End If

        'could break if user uses cheats
        If (cYear = 0) Then
            BC = False
        End If

        ' positionLabel.Text = xPos.ToString + ", " + yPos.ToString
        RandomEvent.start(Me)

        celebrateCooldown += 1
        updateTribes()
        cTribe.update(Me)
        mapWindow.updatePlayerPos(xPos, yPos, cTribe)
        scoutWin.updateRender(mapWindow, xPos, yPos)
        gameOver()
        'display gold
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub
    Private Sub battle()
        Dim battleWin As New Combat

        addEvent("Battle started...")
        battleWin.updateData(Me, mapWindow)

        battleWin.ShowDialog()

        'update after battle
        gameOver()
        turn()

        'display gold
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub

    Private Sub negotiate()
        'force negotiation window
        Dim negWin As New Negotiation
        addEvent("Negotiations started...")
        negWin.updateRender(averagePower, cTribe, mapWindow, xPos, yPos)
        negWin.ShowDialog()

        'update after negotiation

        cTribe.update(Me)
        mapWindow.updatePlayerPos(xPos, yPos, cTribe)
        scoutWin.updateRender(mapWindow, xPos, yPos)

        'display gold
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub

    Private Sub map()
        If (mapWindow.Visible) Then
            mapWindow.Visible = False
        Else
            mapWindow.updatePlayerPos(xPos, yPos, cTribe)
            mapWindow.Visible = True
            addEvent("Displaying map...")

        End If

    End Sub

    Private Sub WorldMove(dir As String, nx As Integer, ny As Integer)
        If (mapWindow.checkPos(dir)) Then
            mapWindow.clearTile(xPos, yPos)
            yPos += ny
            xPos += nx
            addEvent("You travelled " + dir + "...")
            turn()
        Else
            addEvent("You cannot travel " + dir + "...")
            mapWindow.updatePlayerPos(xPos, yPos, cTribe)
            mapWindow.Visible = True
        End If
    End Sub

    'stuff for other classes to use
    Public Sub addMember(entity As Person)
        cTribe.AddMember(entity)
    End Sub

    Private Sub TurnButton_Click(sender As Object, e As EventArgs) Handles turnButton.Click
        turn()
    End Sub

    'cheats
    'add random member to tribe
    Private Sub AddNewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        Dim entity As New Person
        entity = entity.newPerson()
        entity.Age = 20
        addMember(entity)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        closeGame()
    End Sub

    Private Sub NextTurnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextTurnToolStripMenuItem.Click
        turn()
    End Sub

    Private Sub MapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapToolStripMenuItem.Click
        map()
    End Sub

    Private Sub BattleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BattleToolStripMenuItem.Click
        battle()
    End Sub

    Private Sub NegotiateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegotiateToolStripMenuItem.Click
        negotiate()
    End Sub

    Private Sub MapButton_Click(sender As Object, e As EventArgs) Handles mapButton.Click
        map()
    End Sub

    Private Sub BattleButton_Click(sender As Object, e As EventArgs) Handles battleButton.Click
        battle()
    End Sub

    Private Sub NegotiateButton_Click(sender As Object, e As EventArgs) Handles negotiateButton.Click
        negotiate()
    End Sub

    Private Sub CommandButton_Click(sender As Object, e As EventArgs) Handles commandButton.Click
        If (commandGroup.Visible) Then
            commandGroup.Visible = False
            buildGroup.Visible = False
        Else
            commandGroup.Visible = True
        End If
    End Sub

    Private Sub TravelButton_Click(sender As Object, e As EventArgs) Handles travelButton.Click
        If (travelGroup.Visible) Then
            travelGroup.Visible = False
        Else
            travelGroup.Visible = True
            northButton.Focus()
        End If

    End Sub

    Private Sub BuildButton_Click(sender As Object, e As EventArgs) Handles buildButton.Click
        If (buildGroup.Visible) Then
            buildGroup.Visible = False
        Else
            buildGroup.Visible = True
        End If
    End Sub

    Private Sub NorthButton_Click(sender As Object, e As EventArgs) Handles northButton.Click
        WorldMove("North", 0, -1)
    End Sub

    Private Sub SouthButton_Click(sender As Object, e As EventArgs) Handles southButton.Click
        WorldMove("South", 0, 1)
    End Sub

    Private Sub EastButton_Click(sender As Object, e As EventArgs) Handles eastButton.Click
        WorldMove("East", 1, 0)
    End Sub

    Private Sub WestButton_Click(sender As Object, e As EventArgs) Handles westButton.Click
        WorldMove("West", -1, 0)
    End Sub

    Private Sub GetPowerLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetPowerLevelToolStripMenuItem.Click
        addEvent("Current Tribe Power Level: " + cTribe.Power.ToString)
    End Sub

    Private Sub YearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem.Click
        cYear -= 2
        turn()
    End Sub

    Private Sub YearsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearsToolStripMenuItem.Click
        cYear -= 6
        turn()
    End Sub

    Private Sub YearsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YearsToolStripMenuItem1.Click
        cYear -= 101
        turn()
    End Sub

    Private Sub YearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem1.Click
        cYear += 1
        turn()
    End Sub

    Private Sub YearsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles YearsToolStripMenuItem2.Click
        cYear += 5
        turn()
    End Sub

    Private Sub YearsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles YearsToolStripMenuItem3.Click
        cYear += 100
        turn()
    End Sub

    Private Sub ScoutButton_Click(sender As Object, e As EventArgs) Handles scoutButton.Click
        scoutWin.updateRender(mapWindow, xPos, yPos)
        If (scoutWin.Visible) Then
            scoutWin.Visible = False
        Else
            scoutWin.Visible = True
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub about()
        Dim winAbout As New about
        'set file dest before going ***
        winAbout.dest = "home"
        winAbout.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about()
    End Sub

    'open about page in default browser
    Private Sub OpenWebBrowserAboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenWebBrowserAboutToolStripMenuItem.Click
        Process.Start("file:///" & IO.Path.GetFullPath("index.html"))
    End Sub

    Private Sub closeToolBar_Click(sender As Object, e As EventArgs) Handles closeToolBar.Click
        closeGame()
    End Sub

    Private Sub viewPersonButton_Click(sender As Object, e As EventArgs) Handles viewPersonButton.Click
        Dim i As Integer = popList.SelectedIndex
        '"error checking".. hueheu
        Try
            Dim data As Person = cTribe.getMemInfo(i)
            Dim dispString As String
            dispString = "Name: " & data.pName & vbCrLf
            dispString += "Age: " & data.Age & vbCrLf
            dispString += "Role: " & data.Role & vbCrLf
            dispString += "Gender: " & data.Gender & vbCrLf
            dispString += "Stats: " & data.stat.total & vbCrLf
            dispString += "Origin: " & data.origin & vbCrLf
            dispString += "Father: " & data.father.ToString & vbCrLf
            dispString += "Mother: " & data.mother.ToString & vbCrLf

            MessageBox.Show(dispString, data.pName & "s Info", MessageBoxButtons.OK)
            Return
        Catch
            Dim dispString As String
            dispString = "Tribe: " & cTribe.Title & vbCrLf
            dispString += "Members: " & cTribe.members.Count.ToString & vbCrLf
            If cTribe.isDiverse Then
                dispString += "Tribe Diversity: Good" & vbCrLf
            Else
                dispString += "Tribe Diversity: Too Low" & vbCrLf
            End If

            dispString += "Power: " & cTribe.Power.ToString("n") & vbCrLf
            MessageBox.Show(dispString, cTribe.Title, MessageBoxButtons.OK)
            Return
        End Try
    End Sub

    Private Sub RandomEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandomEventToolStripMenuItem.Click
        RandomEvent.start(Me)
    End Sub

    Private Sub build(s As String)

        If (cTribe.has("slave") Or cTribe.has("farmer")) And cTribe.iq > 30 And cTribe.checkGold(10) Then
            If mapWindow.build(s, xPos, yPos) Then
                addEvent("You were able to build a " & s & "!")
                'upgrade troops if built something
                cTribe.upgrade(s)
                turn()
            Else
                addEvent("You were unable to build a " & s & "... There is something already built here!")
            End If
        Else
            addEvent("You were unable to build a " & s & "... Nobody knows how!")
        End If
    End Sub



    'build sub buttons
    Private Sub buildFarmButton_Click(sender As Object, e As EventArgs) Handles buildFarmButton.Click
        build("farm")
    End Sub
    Private Sub buildBarracksButton_Click(sender As Object, e As EventArgs) Handles buildBarracksButton.Click
        build("barracks")
    End Sub
    Private Sub buildResidentialButton_Click(sender As Object, e As EventArgs) Handles buildResidentialButton.Click
        build("abode")
    End Sub

    'more cheats
    Private Sub Add100GoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Add100GoldToolStripMenuItem.Click
        cTribe.gold += 100
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub

    Private Sub RandomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandomizeToolStripMenuItem.Click
        Randomize()
    End Sub

    Private Sub WeirdInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeirdInfoToolStripMenuItem.Click
        Dim disMsg As String
        disMsg += "Average Power: " & averagePower.ToString & vbCrLf
        disMsg += "Tribe Count: " & tribeList.Count.ToString & vbCrLf
        Dim totalPpl As Integer
        For Each t As Tribe In tribeList
            totalPpl += t.members.Count
        Next
        disMsg += "People per tribe: " & (totalPpl / tribeList.Count).ToString & vbCrLf

        MessageBox.Show(disMsg, "Info", MessageBoxButtons.OK)
    End Sub

    Private Sub celebrateButton_Click(sender As Object, e As EventArgs) Handles celebrateButton.Click
        If cTribe.checkGold(5) Then
            celebrateCooldown = 0
            addEvent("The camp is crazy from all the celebrations in Herthums name!")
        Else
            addEvent("Not enough gold to celebrate.")
        End If
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub

    Private Sub findMemButton_Click(sender As Object, e As EventArgs) Handles findMemButton.Click
        Dim rNum As New Random
        If rNum.Next(0, 2) = 1 And celebrateCooldown <= 10 And celebrateCooldown > 0 And cTribe.checkGold(5) Then
            Dim entity As New Person
            entity = entity.newPerson()
            entity.Age = rNum.Next(10, 20)
            cTribe.AddMember(entity)
            addEvent("Your Tribe has found a friend to join them. Say hello to " & entity.pName & ". ")
        Else
            addEvent("You could not find anyone to join your tribe...")
        End If
        cTribe.update(Me)
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub

    Private Sub viewTribeButton_Click(sender As Object, e As EventArgs) Handles viewTribeButton.Click
        Dim dispString As String
        dispString = "Tribe: " & cTribe.Title & vbCrLf
        dispString += "Members: " & cTribe.members.Count.ToString & vbCrLf
        If cTribe.isDiverse Then
            dispString += "Tribe Diversity: Good" & vbCrLf
        Else
            dispString += "Tribe Diversity: Too Low" & vbCrLf
        End If

        dispString += "Power: " & cTribe.Power.ToString("n") & vbCrLf
        MessageBox.Show(dispString, cTribe.Title, MessageBoxButtons.OK)
        goldLabel.Text = "Gold: " & cTribe.gold.ToString
    End Sub

    Private Sub VariniGodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariniGodsToolStripMenuItem.Click
        Dim abWin As New about
        abWin.dest = "data/info/godsinfo.html"
        abWin.Show()
    End Sub
End Class
