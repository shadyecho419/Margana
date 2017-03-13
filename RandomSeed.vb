Public Class RandomSeed
    Public _RandSeedCount As Integer
    Dim Rnd As New Random
    Dim _LoopCounter As Integer = 0
    Public Sub RandomSeedGenerator(ByVal _NumberofWords As Integer)
        _RandSeedCount = 0
        For _LoopCounter = 0 To 0
            _RandSeedCount &= (Rnd.Next(_NumberofWords))
        Next
    End Sub

    Public ReadOnly Property RandomSeedGeneratorReturn() As String
        Get
            Return _RandSeedCount
        End Get
    End Property
End Class
