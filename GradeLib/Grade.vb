
Public Class Grade
    Implements IGrade

    Private _score As Integer

    Sub New(score As Integer)
        If score < 0 Then Throw New Exception("Wrong Parameter")
        If score > 100 Then Throw New Exception("Wrong Parameter")

        _score = score
    End Sub

    Public ReadOnly Property Score As Integer Implements IGrade.Score
        Get
            Return _score
        End Get
    End Property

    Public Function Calculate() As String Implements IGrade.Calculate
        Select Case _score
            Case 80 : Return "A"
            Case 70 : Return "B"
            Case 60 : Return "C"
            Case Else : Return ""
        End Select
    End Function
End Class
