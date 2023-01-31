

'stats class used by the person class
Public Class Stats
    Private vStr As Double
    Private vDex As Double
    Private vInt As Double
    Private vWis As Double

    Public ReadOnly Property total As Double
        Get
            Return vStr + vDex + vInt + vWis
        End Get
    End Property

    Public Property Strength As Double
        Get
            Return vStr
        End Get
        Set(value As Double)
            vStr = value
        End Set
    End Property

    Public Property Dexterity As Double
        Get
            Return vDex
        End Get
        Set(value As Double)
            vDex = value
        End Set
    End Property

    Public Property Intelligence As Double
        Get
            Return vInt
        End Get
        Set(value As Double)
            vInt = value
        End Set
    End Property

    Public Property Wisdom As Double
        Get
            Return vWis
        End Get
        Set(value As Double)
            vWis = value
        End Set
    End Property

End Class


'main person class start
Public Class Person

    'basic person info
    Private vName As String
    Private vGender As String

    'non static info
    Private vRole As String
    Private vAge As Integer
    Private vOrigin As String
    Private vFaith As Double 'out of 100

    'highly dynamic info
    Private vParents As New Dictionary(Of String, Person)
    Private vStat As New Stats
    Private doneBTurn As Boolean = False

    Public Property done As Boolean
        Get
            Return doneBTurn
        End Get
        Set(value As Boolean)
            doneBTurn = value
        End Set
    End Property

    Private vPassed As Integer = 0

    Public Sub makeSmart()
        vStat.Intelligence += 25
    End Sub

    Public Sub setStats()

        vStat.Strength = CInt((10 - 6 + 6) * Rnd() + 6)
        vStat.Dexterity = CInt((10 - 6 + 6) * Rnd() + 6)
        vStat.Intelligence = CInt((10 - 6 + 6) * Rnd() + 6)
        vStat.Wisdom = CInt((10 - 6 + 6) * Rnd() + 6)

        'roles have different meanings...
        If (vRole = "Warrior") Then
            vStat.Strength += 50
        End If

        If (vRole = "Slave") Then
            vStat.Wisdom += 10
            vStat.Strength += 20
        End If

        If (vRole = "Caretaker") Then
            vStat.Intelligence += 30
        End If

        If (vRole = "Farmer") Then
            vStat.Dexterity += 20
            vStat.Intelligence += 10
        End If

    End Sub

    'new name for the person based on gender
    Public Sub nname()
        vName = Game.NamesList.getName(Gender)
    End Sub

    'Generates a new random person
    Public Function newPerson(Optional origin As String = "Unknown") As Person
        'parents setup

        Dim p1 As New Person
        If CInt((10 - 1 + 1) * Rnd() + 1) = 5 Then
            p1.Role = "Farmer"
        ElseIf CInt((10 - 1 + 1) * Rnd() + 1) = 6 Then
            p1.Role = "Slave"
        ElseIf CInt((10 - 1 + 1) * Rnd() + 1) = 7 Then
            p1.Role = "Caretaker"
        Else
            p1.Role = "Warrior"
        End If
        p1.Gender = "Male"
        p1.pName = Game.NamesList.getName(p1.Gender)
        p1.Age = CInt((50 - 20 + 20) * Rnd() + 20)
        p1.Faith = 40
        p1.origin = origin
        p1.setStats()


        Dim p2 As New Person
        If CInt((10 - 1 + 1) * Rnd() + 1) = 5 Then
            p2.Role = "Farmer"
        ElseIf CInt((10 - 1 + 1) * Rnd() + 1) = 6 Then
            p2.Role = "Slave"
        ElseIf CInt((10 - 1 + 1) * Rnd() + 1) = 7 Then
            p2.Role = "Caretaker"
        Else
            p2.Role = "Warrior"
        End If
        p2.Gender = "Female"
        p2.pName = Game.NamesList.getName(p1.Gender)
        p2.Age = CInt((50 - 20 + 20) * Rnd() + 20)
        p2.Faith = 40
        p2.origin = origin
        p2.setStats()


        Dim np As New Person
        np.vParents("father") = p1
        np.vParents("mother") = p2
        If CInt((10 - 1 + 1) * Rnd() + 1) = 5 Then
            np.Role = "Farmer"
        ElseIf CInt((10 - 1 + 1) * Rnd() + 1) = 6 Then
            np.Role = "Slave"
        ElseIf CInt((10 - 1 + 1) * Rnd() + 1) = 7 Then
            np.Role = "Caretaker"
        Else
            np.Role = "Warrior"
        End If
        Randomize()
        If CInt((10 - 1 + 1) * Rnd() + 1) >= 5 Then
            np.Gender = "Male"
        Else
            np.Gender = "Female"
        End If

        np.pName = Game.NamesList.getName(np.Gender)
        np.Age = CInt((25 - 1 + 1) * Rnd() + 1)
        np.Faith = 40
        np.origin = origin
        np.setStats()

        Return np
    End Function

    '''property values
    Public Property pName As String
        Get
            Return vName
        End Get
        Set(value As String)
            vName = value
        End Set
    End Property

    Public Property Role As String
        Get
            Return vRole
        End Get
        Set(value As String)
            vRole = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return vGender
        End Get
        Set(value As String)
            vGender = value
        End Set
    End Property

    Public Property passed As Integer
        Get
            Return vPassed
        End Get
        Set(value As Integer)
            vPassed = value
        End Set
    End Property
    Public Property Age As Integer
        Get
            Return vAge
        End Get
        Set(value As Integer)
            vAge = value
        End Set
    End Property

    Public Property Faith As Double
        Get
            If vFaith < 1 Then
                vFaith = 0
            ElseIf vFaith > 100 Then
                vFaith = 100
            End If

            Return vFaith
        End Get
        Set(value As Double)
            vFaith = value
        End Set
    End Property

    Public Property origin As String
        Get
            Return vOrigin
        End Get
        Set(value As String)
            vOrigin = value
        End Set
    End Property

    Public ReadOnly Property stat As Stats
        Get
            Return vStat
        End Get
    End Property

    Public Property father As Person
        Get
            Return vParents("father")
        End Get
        Set(value As Person)
            vParents("father") = value
        End Set
    End Property
    Public Property mother As Person
        Get
            Return vParents("mother")
        End Get
        Set(value As Person)
            vParents("mother") = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return pName
    End Function
End Class
