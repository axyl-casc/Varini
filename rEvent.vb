Public Class rEvent

    Private Function newPerson(g As Game) As String
        Dim entity As New Person
        entity = entity.newPerson()
        entity.Age = 12
        g.addMember(entity)
        Return "Your Tribe has found a friend to join them. Say hello to " & entity.pName & ". "
    End Function

    Private Function depression(g As Game) As String
        For Each element As Person In g.cTribe.members
            element.Faith -= 10
        Next
        Return "Something horrible has happened within the tribe... Men are losing their spirits"
    End Function

    Private Function hurt(g As Game) As String
        For Each element As Person In g.cTribe.members
            element.stat.Strength -= 5
            Return "A great weakness has befallen one of your tribesmen..."
        Next
    End Function

    Public Sub start(g As Game)
        Randomize()
        Dim maxN As Integer = 3

        Dim num As Integer
        maxN *= 3
        '1 in 3 chance that something happens...
        num = CInt((maxN - 1 + 1) * Rnd() + 1)

        Select Case num
            Case 1
                g.addEvent(newPerson(g))
            Case 2
                g.addEvent(depression(g))
            Case 3
                g.addEvent(hurt(g))
        End Select



    End Sub

End Class
