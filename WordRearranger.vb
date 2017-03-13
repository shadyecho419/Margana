Public Class WordRearranger

    Dim _WordRemover As Integer = 0
    Dim _strNewScrambledWord As String = ""
    Dim _TempString As String = ""
    Dim _strNewScrambledWordHolder As String = ""
    Dim Rnd As New Random


    Public Sub WordRearranger(ByVal _WordOnScreen As String)
        _strNewScrambledWordHolder = ""
        _strNewScrambledWord = ""

        Do While _WordOnScreen.Length <> 0
            _strNewScrambledWord = _WordOnScreen.Chars(Rnd.Next(_WordOnScreen.Length))
            For _WordRemover = 0 To (_WordOnScreen.Length) - 1
                Select Case (_WordOnScreen(_WordRemover))
                    Case _strNewScrambledWord

                        If (_WordOnScreen(_WordRemover)) = _strNewScrambledWord Then
                            _TempString = _WordOnScreen.Remove(_WordRemover, 1)
                            _WordOnScreen = _TempString
                            _TempString = ""
                            Exit For
                        End If
                End Select
            Next
            _strNewScrambledWordHolder &= _strNewScrambledWord
        Loop
        'take randomised word to screen

    End Sub

    Public ReadOnly Property WordRearrangerReturn() As String
        Get
            Return _strNewScrambledWordHolder
        End Get
    End Property
End Class
