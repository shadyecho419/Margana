Public Class WordScrambler


    Dim _WordRemover As Integer = 0
    Dim _strNewScrambledWord As String = ""
    Dim _TempString As String = ""
    Dim _strScrambledWordHolder As String = ""
    Dim Rnd As New Random
    'takes correct word and randomomises it before displaying it on screen
    ' it randomly picks a word and then picks a random word one by one
    'rearranging the letter sequence within the word

    Public Sub WordScrambler(ByVal _SelectedWord As String)

        _strScrambledWordHolder = ""
        _strNewScrambledWord = ""

        Do While _SelectedWord.Length <> 0
            _strNewScrambledWord = _SelectedWord.Chars(Rnd.Next(_SelectedWord.Length))
            For _WordRemover = 0 To (_SelectedWord.Length) - 1
                Select Case (_SelectedWord(_WordRemover))
                    Case _strNewScrambledWord

                        If (_SelectedWord(_WordRemover)) = _strNewScrambledWord Then
                            _TempString = _SelectedWord.Remove(_WordRemover, 1)
                            _SelectedWord = _TempString
                            _TempString = ""
                            Exit For
                        End If
                End Select
            Next
            _strScrambledWordHolder &= _strNewScrambledWord
        Loop

    End Sub

    Public ReadOnly Property WordScramblerReturn() As String
        Get
            Return _strScrambledWordHolder
        End Get
    End Property
End Class
