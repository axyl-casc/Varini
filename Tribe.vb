Public Class Tribe

    'target # of people in a tribe
    Private numPeople As Double = 20

    Private vMembers As New List(Of Person)
    Private vName As String = "Error"
    Private visDead As Boolean = False
    Private vSymbol As String

    Private vBreedable As Boolean
    Private vx As Integer
    Private vy As Integer
    Private vDiplomatic As Boolean = False

    Private minAge As Integer = 16

    Private blessed As Boolean = False
    'spawn freyja once

    Private vgold As Integer
    Private tribesAvg As Double = 100000


    Public Function isDiverse() As Boolean
        Dim amm As Integer
        If has("warrior") Then
            amm += 1
        End If
        If has("caretaker") Then
            amm += 1
        End If
        If has("farmer") Then
            amm += 1
        End If
        If has("slave") Then
            amm += 1
        End If
        If vBreedable Then
            amm += 3
        End If

        'sees if its diverse in roles
        If amm >= 5 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function has(role As String) As Boolean
        For Each element As Person In vMembers
            If element.Role.ToLower = role.ToLower Then
                Return True
            End If
        Next
        Return False
    End Function

    'upgrade a stat based on what is build
    Public Sub upgrade(s As String)
        For Each element As Person In vMembers
            element.Faith += 5
            Select Case s.ToLower
                Case "farm"
                    element.stat.Wisdom += 5
                    element.stat.Intelligence += 5
                Case "barracks"
                    element.stat.Strength += 10
                Case "abode"
                    element.stat.Wisdom += 10
            End Select
        Next
    End Sub

    'get lowerNum
    Private Function low(n1 As Double, n2 As Double) As Double
        If n1 > n2 Then
            Return n2
        Else
            Return n1
        End If
    End Function


    Private Sub checkDeaths(g As Game)
        'number of people a tribe should have

        Dim rNum As New Random

        Dim min As Integer = 30
        Dim max As Integer = 60
        If vMembers.Count <= numPeople Then
            min += 40
            max += 40
        End If

        Dim toRemove As New List(Of Person)

        For Each element As Person In vMembers
            'check age and remove when too old...
            If element.Age > rNum.Next(min, max) Then
                toRemove.Add(element)
            Else
                If rNum.Next(0, CInt(Math.Floor(vMembers.Count / 3))) = 1 Then
                    element.passed -= 1
                End If
            End If
        Next

        Dim num As Integer = 0
        For Each element As Person In toRemove
            vMembers.Remove(element)
            num += 1
        Next

        If Sym.ToLower = "v" And num > 0 Then
            'MessageBox.Show(element.pName & " has passed away...", "Tribe Member Death", MessageBoxButtons.OK)
            g.addEvent(num.ToString & " people have passed away this turn.")
        End If

    End Sub

    Private Sub AIBoost()
        Dim e1 As New Person
        e1 = e1.newPerson()
        e1.Age = minAge
        e1.origin = Title
        e1.Gender = "Male"
        e1.nname()
        vMembers.Add(e1)

        Dim e2 As New Person
        e2 = e2.newPerson()
        e2.Age = minAge
        e2.origin = Title
        e2.Gender = "Female"
        e2.nname()
        vMembers.Add(e2)
    End Sub

    Public Sub AIupdate(cYear As Integer, cMap As Map, g As Game)
        tribesAvg = g.averagePower
        'make game harder after 50AD
        If cYear > 40 And Not (Sym.ToLower = "v") And vMembers.Count < numPeople Then
            AIBoost()

            If cYear > 100 Then
                AIBoost()
                upgrade("abode")
                upgrade("barracks")
                upgrade("farn")
            End If
        End If

        'make rome not bad
        If Sym.ToLower = "r" And vMembers.Count < numPeople Then
            AIBoost()
            upgrade("barracks")
        End If

        Dim rNum As New Random
        If Not (Sym.ToLower = "v") Then
            If rNum.Next(0, 20) < 4 Then
                upgrade("farm")
            End If
        End If

        'check dead
        checkDeaths(g)
        If vMembers.Count <= 0 Then
            visDead = True
            Return
        End If

        'age stuff
        For Each element As Person In vMembers
            element.Age += 2
            If (element.ToString = "Askr" Or element.ToString = "Embla") And vMembers.Count < numPeople Then
                element.passed = 0
            End If
        Next

        'check if tribe can have kids
        Dim nMale As Integer = 0
        Dim nFemale As Integer = 0
        'keep this last
        'only 1 person can die per turn
        For Each element As Person In vMembers
            'check if breedable
            If element.Age > minAge Then
                If element.Gender = "Male" And element.passed <= 10 Then
                    nMale += 1
                ElseIf element.Gender = "Female" And element.passed <= 4 Then
                    nFemale += 1
                End If
            End If
        Next

        'final comparison
        If nFemale > 0 And nMale > 0 Then
            vBreedable = True
        Else
            vBreedable = False
        End If

        Dim newMembers As New List(Of Person)
        Dim beforeN As Integer = vMembers.Count

        If vBreedable Then

            'get a male/female
            For Each element As Person In vMembers
                If element.Gender = "Male" Then
                    For Each f_element As Person In vMembers
                        Dim chance As New Random
                        Randomize()
                        Dim n As Integer = chance.Next(0, g.celebrateCooldown)
                        If f_element.Age > minAge And f_element.Gender = "Female" And f_element.passed <= 10 And element.Age > minAge And element.passed <= 10 And (numPeople * 1.1) >= vMembers.Count And Not element.done And Not f_element.done Then
                            If Sym.ToLower = "v" And n = 1 Then
                                f_element.passed += 1
                                element.passed += 1

                                f_element.done = True
                                element.done = True
                                Dim entity As New Person
                                entity = entity.newPerson()
                                entity.Age = 1
                                entity.origin = Title
                                entity.father = element
                                entity.mother = f_element
                                newMembers.Add(entity)

                            ElseIf Not (Sym.ToLower = "v") Then
                                'now makes a new person
                                f_element.passed += 1
                                element.passed += 1
                                f_element.done = True
                                element.done = True
                                Dim entity As New Person
                                entity = entity.newPerson()
                                entity.Age = 1
                                entity.origin = Title
                                entity.father = element
                                entity.mother = f_element
                                newMembers.Add(entity)
                            End If
                        End If
                    Next

                End If
            Next
        End If

        'add all the new people
        For Each mem As Person In newMembers
            vMembers.Add(mem)
        Next

        If Sym.ToLower = "v" And newMembers.Count > 0 Then
            g.addEvent("Your tribe had " & (vMembers.Count - beforeN).ToString & " new little ones this year.")
        End If

        'if you cannot find anyone
        If (Not vBreedable And vgold >= 20 And Not blessed And Sym.ToLower = "v") Then
            blessed = True
            Dim entity As New Person
            entity = entity.newPerson()
            entity.Age = minAge
            entity.Role = "Warrior"
            entity.Gender = "Female"
            entity.pName = "Embla"
            entity.setStats()

            vMembers.Add(entity)
            g.addEvent("Your tribe has a new member: " & entity.pName & ". It must be a blessing!")
        End If

        For Each elem As Person In vMembers
            elem.done = False
        Next

        'add some money every turn?
        vgold += CInt(0.1 * iq())
    End Sub

    Public Function checkGold(ammount As Integer) As Boolean
        If vgold >= ammount Then
            vgold -= ammount
            Return True
        Else
            Return False
        End If
    End Function

    Public Function killMember(i As Integer) As Person
        Dim tempPerson As New Person
        tempPerson = vMembers(i)
        vMembers.RemoveAt(i)
        Return tempPerson
    End Function

    Public Function iq() As Double
        Dim highest As Double = 0

        'find highest int stat in tribe
        For Each element As Person In vMembers
            If element.stat.Intelligence > highest Then
                highest = element.stat.Intelligence
            End If
        Next

        'get average int stat
        Dim total As Double = 0
        Dim ppl As Double = 0
        For Each element As Person In vMembers
            ppl += 1
            total += element.stat.Intelligence
        Next

        Dim avg As Double = total / ppl

        'return a weighted plus average
        Return ((highest * 10) + avg) / 11

    End Function

    'update tribe positions
    Public Sub setpos(x As Integer, y As Integer)
        vx = x
        vy = y
    End Sub
    Public ReadOnly Property xpos As Integer
        Get
            Return vx
        End Get
    End Property
    Public ReadOnly Property ypos As Integer
        Get
            Return vy
        End Get
    End Property

    Public ReadOnly Property dead As Boolean
        Get
            Return visDead
        End Get
    End Property
    Public Property members As List(Of Person)
        Get
            Return vMembers
        End Get
        Set(value As List(Of Person))
            vMembers = value
        End Set
    End Property

    Public Property gold As Integer
        Get
            Return vgold
        End Get
        Set(value As Integer)
            vgold = value
        End Set
    End Property

    'returns info for this tribe
    Public Property info() As String
        Get
            Return "Tribe: " + vName + vbCrLf + "Members: " + vMembers.Count.ToString + vbCrLf + "Power: " + Power.ToString("n")
        End Get
        Set(TribeName As String)
            vName = TribeName
        End Set
    End Property

    Public Sub update(g As Game)
        g.popList.Items.Clear()

        Dim i As Integer = 0
        For Each element As Person In vMembers
            i += 1
            g.addPop(element.pName)
        Next
    End Sub

    Public Function getMemInfo(i As Integer) As Person
        Return vMembers(i)
    End Function

    Public Sub AddMember(f As Person)
        vMembers.Add(f)
    End Sub

    Public Property diplomatic As Boolean
        Get
            Return vDiplomatic
        End Get
        Set(value As Boolean)
            vDiplomatic = value
        End Set
    End Property
    Public ReadOnly Property Sym As String
        Get
            vSymbol = vName.Substring(0, 1)
            If Power > tribesAvg Then
                Return vSymbol.ToUpper
            Else
                Return vSymbol.ToLower
            End If

            Return vSymbol
        End Get
    End Property
    'gets overall tribe combat power from a simple calculation
    Public ReadOnly Property Power As Double
        Get
            Dim numPeople As Double = 0
            Dim total As Double = 0
            Dim totalAge As Double = 0
            For Each element As Person In vMembers
                numPeople += 1
                Dim str As Double = element.stat.Strength
                Dim dex As Double = element.stat.Dexterity
                Dim int As Double = element.stat.Intelligence
                Dim fth As Double = element.Faith
                Dim age As Double = element.Age
                Dim temp As Double
                totalAge += age
                'total += ((element.stat.Strength * 2 + (element.stat.Dexterity / 2) + (element.stat.Intelligence / 2)) * (element.Faith / 2)) * element.Age
                temp += str * 2
                temp += dex * 1.5
                temp += int * 1.4
                temp += fth
                temp += age
                total += temp / 400
            Next
            Dim avgAge As Double = totalAge / numPeople

            Dim tempPower As Double = (((Math.Abs(-(avgAge) * (avgAge - 50) * 0.001) - ((-(avgAge) * (avgAge - 50) * 0.001) / -1)) + 1) * total)

            Return tempPower
        End Get
    End Property

    Public Property Title As String
        Get
            Return vName
        End Get
        Set(value As String)
            vName = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Title
    End Function
End Class
