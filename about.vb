Public Class about

    Private vDest As String

    Public Property dest As String
        Get
            Return vDest
        End Get
        Set(value As String)
            vDest = value
        End Set
    End Property

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If vDest = "" Or vDest.ToLower = "home" Or vDest.ToLower = "index" Then
            vDest = "index.html"
        End If
        Dim path As String = "file:///" & IO.Path.GetFullPath(vDest)
        browser.Navigate(path)
    End Sub
End Class