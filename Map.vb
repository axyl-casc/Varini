Public Class Map
    Private vxpos As Integer
    Private vypos As Integer
    Private vMap As New List(Of String)

    Private vMapData As New Dictionary(Of String, Tile)

    Private vMap_x As Integer
    Private vMap_y As Integer

    Private mapLoaded As Boolean = False

    'builds somethign, returns false if you caannot build there.
    Public Function build(e As String, x As Integer, y As Integer) As Boolean

        If vMapData(x.ToString + "," + y.ToString).subtype = "" Then
            Select Case e.ToLower
                Case "farm"
                    vMapData(x.ToString + "," + y.ToString).subtype = "Farmland"
                    Return True
                Case "barracks"
                    vMapData(x.ToString + "," + y.ToString).subtype = "Military land"
                    Return True
                Case "abode"
                    vMapData(x.ToString + "," + y.ToString).subtype = "Housing"
                    Return True
            End Select
        End If

        Return False
    End Function

    'get map data held at a x and y coord
    Public Function getInfo(x As Integer, y As Integer) As String
        Return vMapData(x.ToString + "," + y.ToString).info
    End Function

    'move them around?
    Public Sub newSet()
        Dim y As Integer
        Dim x As Integer
        vMap_x = Len(vMap(0)) - 1
        vMap_y = vMap.Count - 1
        'populate map with tribes
        For y = 0 To vMap_y
            For x = 0 To vMap_x
                clearTile(x, y)
            Next
        Next
        mapLoaded = True
    End Sub

    Public Function checkPos(dir As String) As Boolean
        'north dir check
        If (dir = "North") Then
            If (Not Mid(vMap(vypos - 1), vxpos + 1, 1) = "_" Or vypos <= 0) Then
                Return False
            End If


            'South dir check
        ElseIf (dir = "South") Then
            If (Not Mid(vMap(vypos + 1), vxpos + 1, 1) = "_" Or vypos >= vMap.Count) Then
                Return False
            End If


            'east dir check
        ElseIf (dir = "East") Then
            If (Not Mid(vMap(vypos), vxpos + 2, 1) = "_" Or vxpos >= (Len(vMap(0)) - 1)) Then
                Return False
            End If

            'west dir check
        ElseIf (dir = "West") Then
            If (Not Mid(vMap(vypos), vxpos, 1) = "_" Or vxpos <= 0) Then
                Return False
            End If
        End If
        Return True

    End Function

    Public Function getMapData() As Dictionary(Of String, Tile)
        Return vMapData
    End Function

    Public Sub clearTile(x As Integer, y As Integer)
        Dim tempTile As New Tile
        Dim tempKey As String
        tempKey = x.ToString + "," + y.ToString

        'take old info
        If mapLoaded Then
            tempTile = vMapData(tempKey)
        End If

        Dim emptyTibe As New Tribe
        emptyTibe.Title = "_"
        emptyTibe.setpos(x, y)
        emptyTibe.diplomatic = False

        If (Mid(vMap(y), x + 1, 1) = "~") Then
            'if its in the ocean
            Dim tempPerson As New Person
            tempPerson = tempPerson.newPerson()
            tempPerson.Role = "Farmer"
            tempPerson.setStats()
            emptyTibe.AddMember(tempPerson)
            emptyTibe.Title = "~"
            tempTile.Occupant = emptyTibe
            tempTile.Type = "Ocean"
        Else
            'if its land without an official tribe
            Dim r As New Random
            Dim n As Integer

            For n = 0 To r.Next(1, 2)
                Dim tempPerson As New Person
                tempPerson = tempPerson.newPerson()
                tempPerson.Role = "Farmer"
                tempPerson.setStats()
                emptyTibe.AddMember(tempPerson)
            Next
            tempTile.Occupant = emptyTibe
            tempTile.Type = "Healthy Land"
        End If
        vMapData(tempKey) = tempTile
    End Sub

    Public Sub updatePlayerPos(x As Integer, y As Integer, cTribe As Tribe)
        vxpos = x
        vypos = y
        'modify templist
        Dim tempMap As New List(Of String)
        For Each element As String In vMap
            tempMap.Add(element.Replace(cTribe.Sym, "_"))
        Next

        tempMap(y) = tempMap(y).Remove(x, 1).Insert(x, "V")
        mapList.Items.Clear()
        'display templist
        For Each element As String In tempMap
            mapList.Items.Add(element)
        Next


        'mapdata stuff update as well
        Dim tempTile As New Tile
        Dim tempKey As String
        tempKey = x.ToString + "," + y.ToString
        tempTile.Occupant = cTribe
        tempTile.Type = "Used Land"
        tempTile.subtype = vMapData(tempKey).subtype
        vMapData(tempKey) = tempTile
    End Sub

    Public Sub setPlayerPos(x As Integer, y As Integer)
        vxpos = x
        vypos = y
        Dim tempList As New List(Of String)
        'get temp list 
        For Each element As String In getFile().Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            tempList.Add(element.Replace("1", "_").Replace("0", "~"))
        Next
        vMap = tempList

        mapList.Items.Clear()
        'display templist
        For Each element As String In vMap
            mapList.Items.Add(element)
        Next



    End Sub

    Public Sub addToMap(unit As Tribe)
        Dim x As Integer = unit.xpos
        Dim y As Integer = unit.ypos

        If unit.dead Then
            clearTile(x, y)
            vMap(y) = vMap(y).Remove(x, 1).Insert(x, "_")
        Else
            'mapdata stuff update as well
            Dim tempTile As New Tile
            tempTile.Occupant = unit
            tempTile.Type = "Used Land"
            Dim tempKey As String
            tempKey = x.ToString + "," + y.ToString
            vMapData(tempKey) = tempTile
            'modify templist
            vMap(y) = vMap(y).Remove(x, 1).Insert(x, unit.Sym)
        End If


        mapList.Items.Clear()
        'display templist
        For Each element As String In vMap
            mapList.Items.Add(element)
        Next



    End Sub

    'open file and get map data
    Public Function getFile() As String
        Dim data As IO.StreamReader = IO.File.OpenText("map.txt")
        Dim temp As String = data.ReadToEnd.ToString
        data.Close()
        Return temp

    End Function

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Me.Visible = False
    End Sub

    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        'newSet()
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        Dim winAbout As New about
        winAbout.dest = "data/info/map.html"
        winAbout.Show()
    End Sub
End Class