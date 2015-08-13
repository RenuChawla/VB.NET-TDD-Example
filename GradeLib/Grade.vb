
Public Class Grade
    Implements IGrade

    Private _score As Integer

    Sub New(score As Integer)
        Select Case score
            Case Is < 0, Is > 100 : Throw New Exception("Wrong Parameter")
        End Select

        _score = score
    End Sub

    Public ReadOnly Property Score As Integer Implements IGrade.Score
        Get
            Return _score
        End Get
    End Property

    Public Function Calculate() As String Implements IGrade.Calculate
        Select Case _score
            Case Is > 80 : Return "A"
            Case Is > 70 : Return "B"
            Case Is > 60 : Return "C"
            Case Is > 50 : Return "D"
            Case Else : Return "F"
        End Select
    End Function
End Class
