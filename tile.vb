Public Class Tile


    Private vType As String = ""
    Private vSubType As String = ""

    Private vOccupant As Tribe

    Public ReadOnly Property info As String
        Get
            Dim msg As String
            Dim acc As String
            If vOccupant.Title = "_" Then
                acc = "Empty"
            Else
                acc = vOccupant.Title
            End If

            msg = "Occupant: " + vbCrLf + acc + "= " + vbCrLf
            msg += "Type: " + vType + "= " + vbCrLf
            msg += "Sub Type: " + vSubType + "= " + vbCrLf
            msg += "Power: " + vOccupant.Power.ToString("n") + "=" + vbCrLf
            msg += "Population: " + vOccupant.members.Count.ToString + "=" + vbCrLf
            msg += "Intellegence: " + vOccupant.iq.ToString("n") + "=" + vbCrLf
            Return msg

        End Get
    End Property

    Public Property Occupant As Tribe
        Get
            Return vOccupant
        End Get
        Set(value As Tribe)
            vOccupant = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return vType
        End Get
        Set(value As String)
            vType = value
        End Set
    End Property

    Public Property subtype As String
        Get
            Return vSubType
        End Get
        Set(value As String)
            vSubType = value
        End Set
    End Property

End Class
