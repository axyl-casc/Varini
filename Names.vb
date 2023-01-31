Imports System.IO

Public Class Names

    Private vFirstNames_F As New List(Of String)
    Private vFirstNames_M As New List(Of String)
    Private vLastNames As New List(Of String)

    Public Sub load()

        Dim M_NameReader As New StreamReader("names/male_names.txt")
        Dim F_NameReader As New StreamReader("names/female_names.txt")
        Dim lastNameReader As New StreamReader("names/lastnames.txt")

        Do While M_NameReader.Peek <> -1
            vFirstNames_M.Add(M_NameReader.ReadLine())
        Loop

        Do While F_NameReader.Peek <> -1
            vFirstNames_F.Add(F_NameReader.ReadLine())
        Loop

        Do While lastNameReader.Peek <> -1
            vLastNames.Add(lastNameReader.ReadLine())
        Loop

        M_NameReader.Close()
        F_NameReader.Close()
        lastNameReader.Close()
    End Sub

    'generate a random name
    Public Function getName(g As String, Optional lastName As String = "") As String
        load()

        Dim lnrnd As New Random
        Dim lnrndNum As Integer = lnrnd.Next(vLastNames.Count)
        Dim lastNameS As String = lastName
        If lastNameS = "" Then
            lastNameS = vLastNames(lnrndNum)
        End If

        If g = "Female" Then
            Dim fnrnd As New Random
            Dim fnrndNum As Integer = fnrnd.Next(vFirstNames_F.Count)
            Return vFirstNames_F(fnrndNum) + " " + lastNameS
        Else
            Dim fnrnd As New Random
            Dim fnrndNum As Integer = fnrnd.Next(vFirstNames_M.Count)
            Return vFirstNames_M(fnrndNum) + " " + lastNameS
        End If
    End Function


End Class
