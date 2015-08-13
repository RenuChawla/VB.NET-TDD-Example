
Public Class Grade
    Implements IGrade

    Private _score As Integer

    Sub New(score As Integer)

    End Sub

    Public ReadOnly Property Score As Integer Implements IGrade.Score
        Get

        End Get
    End Property

    Public Function Calculate() As String Implements IGrade.Calculate

    End Function
End Class
