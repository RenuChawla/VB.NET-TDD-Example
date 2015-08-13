
Public Class Grade
    Implements IGrade

    Private _score As Integer

    Sub New(score As Integer)
        If score < 0 Then Throw New Exception("Wrong Parameter")
        If score > 100 Then Throw New Exception("Wrong Parameter")
    End Sub

    Public ReadOnly Property Score As Integer Implements IGrade.Score
        Get

        End Get
    End Property

    Public Function Calculate() As String Implements IGrade.Calculate

    End Function
End Class
