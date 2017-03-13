Imports System.Collections.ObjectModel
Imports System.IO
Public Class frmMarganaMain

    Dim RandomSeedGenerator As New RandomSeed
    Dim WordScramblerClass As New WordScrambler
    Dim WordRearrangerClass As New WordRearranger
    Dim Correct As Double = 0
    Dim Wrong As Double = 0
    Dim Rnd As Random = New Random
    Dim MIN As Integer
    Dim MAX As Integer
    Dim intWordListSelectIndex As Integer
    Dim strSelectedWord As String = ""
    Dim strNewScrambledWord As String = ""
    Dim strScrambledWordHolder As String = ""
    Dim strRealWord As String = ""
    Dim TempString As String = ""
    Dim ThreeTries As Integer = 0
    Dim NextWordClick As Boolean = True
    Dim OpenPath As String = ""
    Dim OpenWordName As String = ""
    Dim OpenWordName2 As String = ""
    Dim OpenWordName3 As String = ""
    Dim EnteredWords(50) As String
    Dim DoWordComparison As Boolean = False


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub RandomWordIndex()
        'gets maximum number of words in list, finds a random number from it and returns value
        RandomSeedGenerator.RandomSeedGenerator(MAX)
        intWordListSelectIndex = RandomSeedGenerator.RandomSeedGeneratorReturn
    End Sub

    Private Sub WordScrambler()
        'scrabled selected word at random number index
        WordScramblerClass.WordScrambler(strSelectedWord)
        lblScrambledWord.Text = WordScramblerClass.WordScramblerReturn
    End Sub

    Private Sub WordRearranger()
        'rearranges sequence of letters in a word to try and simplify it
        WordRearrangerClass.WordRearranger(lblScrambledWord.Text)
        lblScrambledWord.Text = WordRearrangerClass.WordRearrangerReturn
        txtUserWord.Focus()
    End Sub

    Private Sub btnNextWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextWord.Click
        'calls in new word and initializes randomwordindex which randomly picks the number that will be used to 
        'call the new word to screen by calling the index in the list equivalent to that number
        'also called wordscrambler which scrambles the new word

        '2 points awarded for wrong, going to next word
        Wrong += 5
        My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Wrong Move Next.wav")
        lblWrong.Text = (Wrong) & " Wrong"
        ThreeTries = "0"
        strScrambledWordHolder = ""
        strNewScrambledWord = ""
        txtUserWord.Text = ""
        lblTime.Text = "0"
        RandomWordIndex()
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        strRealWord = strSelectedWord
        WordScrambler()
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub NextWord()
        'calls next word onto screen
        ThreeTries = "0"
        strScrambledWordHolder = ""
        strNewScrambledWord = ""
        txtUserWord.Text = ""
        lblTime.Text = "0"
        RandomWordIndex()
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Text = strSelectedWord
        strRealWord = strSelectedWord
        WordScrambler()
        txtUserWord.Focus()
        NextWordClick = True
    End Sub

    Private Sub btnScrambleWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrambleWord.Click
        WordRearranger()
    End Sub

    Private Sub btnSubmitWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitWord.Click

        Dim files As ReadOnlyCollection(Of String)
        Dim files2 As ReadOnlyCollection(Of String)
        Dim files3 As ReadOnlyCollection(Of String)
        Dim strSuggestedWord As String = ""
        Dim strScrambledWord As String = ""
        Dim WordLengthCheck As String = ""
        Dim strLetterPicker As String = ""
        Dim TempString As String = ""
        Dim intLetterCheckCount As Integer = 0
        Dim strScrambledWordCount As String = ""
        Dim SuggestedWordCounter As Integer = 0
        Dim Counter As Integer = 0
        Dim UnboundCounter As Integer = 0
        Dim ArraySearchCounter As Integer = 0
        Dim WordFoundCheck As Boolean = False
        Dim WordEnteredArrayController As Integer = 0
        Dim LengthCheck As Boolean = False

        If Len(txtUserWord.Text) < 3 Then
            lblWrong.Text = (Wrong + 0.5) & " Wrong)"
            LengthCheck = False
            ThreeTries += 1
        Else
            LengthCheck = True
        End If
        If LCase(txtUserWord.Text) <> strRealWord Then
            'gives three tries for a word before new word is called to screen
            files = My.Computer.FileSystem.FindInFiles(OpenPath, txtUserWord.Text, True, FileIO.SearchOption.SearchTopLevelOnly, OpenWordName)
            files2 = My.Computer.FileSystem.FindInFiles(OpenPath, txtUserWord.Text, True, FileIO.SearchOption.SearchTopLevelOnly, OpenWordName2)
            files3 = My.Computer.FileSystem.FindInFiles(OpenPath, txtUserWord.Text, True, FileIO.SearchOption.SearchTopLevelOnly, OpenWordName3)
            If files.Count = "1" Or files2.Count = "1" Or files3.Count = "1" And LengthCheck = True Then
                strSuggestedWord = txtUserWord.Text
                strScrambledWord = lblScrambledWord.Text
                WordLengthCheck = lblScrambledWord.Text
                strScrambledWordCount = lblScrambledWord.Text

                'search through array
                For ArraySearchCounter = 0 To (EnteredWords.Length - 1)
                    'if search field is available
                    If txtUserWord.Text = EnteredWords(ArraySearchCounter) Then
                        'if word has been entered before for the same scrambled word, no need to process it again
                        DoWordComparison = False
                        txtUserWord.Clear()
                        txtUserWord.Focus()
                        Exit For
                    Else
                        'enter word into array if it not found in it
                        DoWordComparison = True
                        EnteredWords(WordEnteredArrayController) = strSuggestedWord
                        WordEnteredArrayController += 1
                        Exit For
                    End If
                Next

                If DoWordComparison = True Then
                    Do While strScrambledWord.Length <> 0
                        Select Case (strScrambledWord(Counter))
                            Case (strSuggestedWord(UnboundCounter))
                                If (strSuggestedWord(UnboundCounter)) = strScrambledWord(Counter) Then
                                    intLetterCheckCount += 1
                                    TempString = strSuggestedWord.Remove(UnboundCounter, 1)
                                    strSuggestedWord = TempString
                                    TempString = ""
                                    TempString = strScrambledWord.Remove(Counter, 1)
                                    strScrambledWord = TempString
                                    TempString = ""
                                    Counter = 0
                                    WordFoundCheck = True
                                    'expected word may not be users word but users word has same letters and is correct
                                    'this is accounted for here
                                    If strSuggestedWord.Length = strScrambledWord.Length And strSuggestedWord = strScrambledWord Then
                                        If Val(lblTime.Text) < "10" Then
                                            My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Correct 10 Sec.wav")
                                            MessageBox.Show("You got the big word correct in the first 10 seconds, try the next word", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                            Correct += 6
                                            lblCorrect.Text = (Correct) & " Correct"
                                            txtUserWord.Clear()
                                            LengthCheck = False
                                            NextWord()
                                            'clears array for next words
                                            Array.Clear(EnteredWords, 0, 50)
                                            TimeKeeper.Enabled = True
                                            NextWordClick = False
                                            DoWordComparison = False
                                            txtUserWord.Focus()
                                            Exit Sub
                                        Else
                                            My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Correct Big Word.wav")
                                            MessageBox.Show("You got the big word correct , try the next word", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                            Correct += 3
                                            lblCorrect.Text = (Correct) & " Correct"
                                            LengthCheck = False
                                            NextWord()
                                            'clears array for next words
                                            Array.Clear(EnteredWords, 0, 50)
                                            TimeKeeper.Enabled = True
                                            NextWordClick = False
                                            DoWordComparison = False
                                            txtUserWord.Focus()
                                            Exit Sub
                                        End If
                                    End If
                                    'if suggested word variable is clear then all words have been found
                                    If strSuggestedWord = "" And (strScrambledWord.Length - 1) < (strScrambledWordCount.Length - 1) Then
                                        SuggestedWordCounter += 1
                                        My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Correct Other Word.wav")
                                        MessageBox.Show("The word you entered is correct", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        'half a point awarded for correct word but this word is not final word
                                        Correct += 0.5
                                        lblCorrect.Text = (Correct) & " Correct"
                                        txtUserWord.Clear()
                                        txtUserWord.Focus()
                                        Exit Sub
                                    End If
                                End If
                        End Select

                        If Counter = (strScrambledWord.Length - 1) Then
                            Counter = 0
                            Exit Do
                        Else
                            If WordFoundCheck = True Then
                                Counter = 0
                                WordFoundCheck = False
                            Else
                                Counter += 1
                            End If
                        End If
                    Loop
                Else
                End If
            End If

            ThreeTries += 1
            If ThreeTries = "3" Then
                TimeKeeper.Enabled = False
                My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Wrong Move Next.wav")
                MessageBox.Show("Three chances are up! " & "Correct word was " & UCase(strRealWord) & ". Moving onto next word.", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Wrong += 1
                lblWrong.Text = (Wrong) & " Wrong"
                ThreeTries = 0
                NextWord()
                'clears array for next words
                Array.Clear(EnteredWords, 0, 50)
                LengthCheck = True
                TimeKeeper.Enabled = True
                NextWordClick = False
                DoWordComparison = False
                txtUserWord.Clear()
                txtUserWord.Focus()
                Exit Sub
            End If
            'displayed if word is incorrect
            My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Wrong Try Again.wav")
            MessageBox.Show("Incorrect word or you entered the same word twice, try again", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lblWrong.Text = (Wrong + 0.5) & " Wrong)"
            LengthCheck = False
            txtUserWord.Clear()
            txtUserWord.Focus()
            Exit Sub
        Else
            TimeKeeper.Enabled = False
            'displayed if word is correct and new word is called
            If Val(lblTime.Text) < "10" Then
                My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Correct 10 Sec.wav")
                MessageBox.Show("You got the big word correct in the first 10 seconds, try the next word", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Correct += 6
                lblCorrect.Text = (Correct) & " Correct"
                txtUserWord.Clear()
                LengthCheck = False
                NextWord()
                'clears array for next words
                Array.Clear(EnteredWords, 0, 50)
                TimeKeeper.Enabled = True
                NextWordClick = False
                DoWordComparison = False
                txtUserWord.Focus()
            Else
                My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Correct Big Word.wav")
                MessageBox.Show("You got the big word correct , try the next word", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Correct += 3
                lblCorrect.Text = (Correct) & " Correct"
                LengthCheck = False
                NextWord()
                'clears array for next words
                Array.Clear(EnteredWords, 0, 50)
                TimeKeeper.Enabled = True
                NextWordClick = False
                DoWordComparison = False
                txtUserWord.Focus()
            End If
        End If
    End Sub
    Private Sub TimeKeeper_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeKeeper.Tick
        With lblTime
            'increases label count by 1 every pass
            .Text = CStr((CDbl(.Text) + 1))
            ' at t = 30 sec, it will display messagebox and then initialize time to zero and call a new word
            If .Text = "45" Then
                TimeKeeper.Enabled = False
                My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Wrong Move Next.wav")
                MessageBox.Show("Times up! " & "Correct word was " & UCase(strRealWord) & ". Moving onto the next word", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '2 points awarded to wrong for running out of time
                lblWrong.Text = (Wrong + 4) & " Wrong)"
                .Text = "0"
                btnNextWord_Click(sender, e)
                Array.Clear(EnteredWords, 0, 50)
                DoWordComparison = False
                NextWordClick = False
                TimeKeeper.Enabled = True
            End If
        End With
    End Sub

    Private Sub ExitCurrentGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitCurrentGameToolStripMenuItem.Click
        Me.Text = "Margana"
        EnglishToolStripMenuItem.Enabled = True
        PortugueseToolStripMenuItem.Enabled = True
        AfrikaansToolStripMenuItem.Enabled = True
        GermanWordsToolStripMenuItem.Enabled = True
        TimeKeeper.Enabled = False
        lblTime.Text = "0"
        lblScrambledWord.Text = "Word"
        lblRealWord.Text = "Real Word"
        txtUserWord.Text = ""
        Correct = 0
        lblCorrect.Text = (Correct) & " Correct"
        Wrong = 0
        lblWrong.Text = (Wrong) & " Wrong"
        strSelectedWord = ""
        strNewScrambledWord = ""
        strScrambledWordHolder = ""
        strRealWord = ""
        TempString = ""
        ThreeTries = 0
        CheatTimer.Stop()
        CheatTimer.Enabled = False
        CheatTimer.Interval = "1000"
        btnSubmitWord.Enabled = False
        btnNextWord.Enabled = False
        btnScrambleWord.Enabled = False
        ShowWordToolStripMenuItem.Enabled = False
        PauseGameToolStripMenuItem.Text = "Pause Game"
        PauseGameToolStripMenuItem.Enabled = False
        txtUserWord.Enabled = False
        mnuCheat.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        abtGreenBay.Show()
    End Sub

    Private Sub CheatTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheatTimer.Tick
        ';real word label is updated in event below
        If CheatTimer.Interval = "3000" Then
            lblRealWord.Text = "Real Word"
            CheatTimer.Enabled = False
            CheatTimer.Interval = "1000"
            lblRealWord.Visible = False
            btnSubmitWord.Enabled = True
            btnNextWord.Enabled = True
            btnScrambleWord.Enabled = True
            lblRealWord.Visible = False
            ShowWordToolStripMenuItem.Enabled = True
            NextWord()
            'clear array of possible words for next words
            Array.Clear(EnteredWords, 0, 50)
            MenuStrip1.Enabled = True
            TimeKeeper.Enabled = True
            txtUserWord.Enabled = True
            txtUserWord.Clear()
            txtUserWord.Focus()
        End If
        CheatTimer.Interval += 1000
    End Sub

    Private Sub ShowWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowWordToolStripMenuItem.Click
        TimeKeeper.Enabled = False
        MenuStrip1.Enabled = False
        '3 points awarded to wrong for cheating
        Wrong += 5
        My.Computer.Audio.Play("C:\GreenBay Solutions\sounds\Wrong Move Next.wav")
        lblWrong.Text = (Wrong) & " Wrong"
        txtUserWord.Enabled = False
        lblRealWord.Visible = True
        CheatTimer.Enabled = True
        btnSubmitWord.Enabled = False
        btnNextWord.Enabled = False
        btnScrambleWord.Enabled = False
        lblRealWord.Text = strRealWord
        ShowWordToolStripMenuItem.Enabled = False
        CheatTimer.Start()
    End Sub

    Private Sub frmMarganaMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplashScreen1.Close()
    End Sub

    Private Sub PauseGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseGameToolStripMenuItem.Click
        If PauseGameToolStripMenuItem.Text = "Pause Game" Then
            TimeKeeper.Enabled = False
            btnSubmitWord.Enabled = False
            btnNextWord.Enabled = False
            btnScrambleWord.Enabled = False
            txtUserWord.Enabled = False
            mnuCheat.Enabled = False
            PauseGameToolStripMenuItem.Text = "Unpause Game"
        ElseIf PauseGameToolStripMenuItem.Text = "Unpause Game" Then
            TimeKeeper.Enabled = True
            btnSubmitWord.Enabled = True
            btnNextWord.Enabled = True
            btnScrambleWord.Enabled = True
            txtUserWord.Enabled = True
            mnuCheat.Enabled = True
            ShowWordToolStripMenuItem.Enabled = True
            PauseGameToolStripMenuItem.Text = "Pause Game"
            txtUserWord.Focus()
        End If


    End Sub

    Private Sub EasyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyToolStripMenuItem.Click
        Me.Text = "Margana: Afrikaans Easy"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\Afrikaans\Afrikaans Easy.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("Afrikaans words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\Afrikaans\Afrikaans Easy.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\Afrikaans\Afrikaans Easy.txt")
        OpenPath = "C:\GreenBay Solutions\Afrikaans"
        OpenWordName = "Afrikaans Easy.txt"
        OpenWordName2 = "Afrikaans Medium.txt"
        OpenWordName3 = "Afrikaans Hard.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub MediumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem.Click
        Me.Text = "Margana: Afrikaans Medium"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\Afrikaans\Afrikaans Medium.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("Afrikaans words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\Afrikaans\Afrikaans Medium.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\Afrikaans\Afrikaans Medium.txt")
        OpenPath = "C:\GreenBay Solutions\Afrikaans"
        OpenWordName = "Afrikaans Medium.txt"
        OpenWordName2 = "Afrikaans Easy.txt"
        OpenWordName3 = "Afrikaans Hard.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub HardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardToolStripMenuItem.Click
        Me.Text = "Margana: Afrikaans Hard"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\Afrikaans\Afrikaans Hard.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("Afrikaans words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\Afrikaans\Afrikaans Hard.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\Afrikaans\Afrikaans Hard.txt")
        OpenPath = "C:\GreenBay Solutions\Afrikaans"
        OpenWordName = "Afrikaans Hard.txt"
        OpenWordName2 = "Afrikaans Easy.txt"
        OpenWordName3 = "Afrikaans Medium.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub EasyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyToolStripMenuItem1.Click
        Me.Text = "Margana: Easy"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\English\English Easy.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("English words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\English\English Easy.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\English\English Easy.txt")
        OpenPath = "C:\GreenBay Solutions\English\"
        OpenWordName = "English Easy.txt"
        OpenWordName2 = "English Medium.txt"
        OpenWordName3 = "English Hard.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub MediumToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem1.Click
        Me.Text = "Margana: Medium"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\English\English Medium.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("English words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\English\English Medium.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\English\English Medium.txt")
        OpenPath = "C:\GreenBay Solutions\English\"
        OpenWordName = "English Medium.txt"
        OpenWordName2 = "English Easy.txt"
        OpenWordName3 = "English Hard.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub HardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardToolStripMenuItem1.Click
        Me.Text = "Margana: Hard"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\English\English Hard.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("English words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\English\English Hard.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\English\English Hard.txt")
        OpenPath = "C:\GreenBay Solutions\English\"
        OpenWordName = "English Hard.txt"
        OpenWordName2 = "English Easy.txt"
        OpenWordName3 = "English Medium.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub EasyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyToolStripMenuItem2.Click
        Me.Text = "Margana: German Easy"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\German\German Easy.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("German words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\German\German Easy.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\German\German Easy.txt")
        OpenPath = "C:\GreenBay Solutions\German\"
        'do this to check for word in other text files if not found in one before dismissing it
        OpenWordName = "German Easy.txt"
        OpenWordName2 = "German Hard.txt"
        OpenWordName3 = "German Medium.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        'set focus on user input textbox
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub MediumToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem2.Click
        Me.Text = "Margana: German Medium"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\German\German Medium.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("German words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\German\German Medium.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\German\German Medium.txt")
        OpenPath = "C:\GreenBay Solutions\German\"
        'used to check for word in other text files
        OpenWordName = "German Medium.txt"
        OpenWordName2 = "German Hard.txt"
        OpenWordName3 = "German Easy.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        'set focus on user input textbox
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub HardToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardToolStripMenuItem2.Click
        Me.Text = "Margana: German Hard"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\German\German Hard.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("German words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\German\German Hard.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\German\German Hard.txt")
        OpenPath = "C:\GreenBay Solutions\German\"
        OpenWordName = "German Hard.txt"
        OpenWordName2 = "German Easy.txt"
        OpenWordName3 = "German Medium.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0

        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        'set focus on user input textbox
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub EasyToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyToolStripMenuItem3.Click
        Me.Text = "Margana: Portuguese Easy"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\Portuguese\Portuguese Easy.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("Portuguese words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\Portuguese\Portuguese Easy.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\Portuguese\Portuguese Easy.txt")
        OpenPath = "C:\GreenBay Solutions\Portuguese\"
        'used to check for word in other text files before dismissing it
        OpenWordName = "Portuguese Easy.txt"
        OpenWordName2 = "Portuguese Hard.txt"
        OpenWordName3 = "Portuguese Medium.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0
        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub MediumToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem3.Click
        Me.Text = "Margana: Portuguese Medium"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\Portuguese\Portuguese Medium.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("Portuguese words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\Portuguese\Portuguese Medium.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\Portuguese\Portuguese Medium.txt")
        OpenPath = "C:\GreenBay Solutions\Portuguese\"
        OpenWordName = "Portuguese Medium.txt"
        OpenWordName2 = "Portuguese Hard.txt"
        OpenWordName3 = "Portuguese Easy.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0
        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub

    Private Sub HardToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardToolStripMenuItem3.Click
        Me.Text = "Margana: Portuguese Hard"
        EnglishToolStripMenuItem.Enabled = False
        PortugueseToolStripMenuItem.Enabled = False
        AfrikaansToolStripMenuItem.Enabled = False
        GermanWordsToolStripMenuItem.Enabled = False
        btnSubmitWord.Enabled = True
        btnNextWord.Enabled = True
        btnScrambleWord.Enabled = True

        'CLEAR LIST BEFORE USE
        lstWords.Items.Clear()

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\GreenBay Solutions\Portuguese\Portuguese Hard.txt")

        If fileExists = True Then

        Else
            MessageBox.Show("Portuguese words file missing, verify path or reinstall extra files", "Margana Word Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim objReader As New IO.StreamReader("C:\GreenBay Solutions\Portuguese\Portuguese Hard.txt")
        Dim objWordCount As New IO.StreamReader("C:\GreenBay Solutions\Portuguese\Portuguese Hard.txt")
        OpenPath = "C:\GreenBay Solutions\Portuguese\"
        OpenWordName = "Portuguese Hard.txt"
        OpenWordName2 = "Portuguese Easy.txt"
        OpenWordName3 = "Portuguese Medium.txt"
        Dim strWordLoad As String = ""
        Dim intWordCount As Integer = 0
        Dim strWordLineCounter As String = ""
        pbWordLoad.Minimum = 0
        lstWords.Items.Clear()

        'used to measure progress bar maximum before loading text file
        Do While objWordCount.Peek <> -1
            strWordLineCounter = objWordCount.ReadLine()
            intWordCount += 1
        Loop

        pbWordLoad.Maximum = intWordCount
        'reads word by word in the text file until end of file
        Do While objReader.Peek <> -1
            strWordLoad = objReader.ReadLine()
            lstWords.Items.Add(LCase(strWordLoad))
            pbWordLoad.Value += 1
        Loop

        pbWordLoad.Value = 0
        'used in random number generator
        MIN = 0
        MAX = intWordCount

        'picks random number to be used as index in picking new word in list
        RandomWordIndex()

        'new word is recorded and then sent to wordscrambler
        strSelectedWord = lstWords.Items.Item(intWordListSelectIndex)
        lblRealWord.Visible = False
        lblRealWord.Text = "Real Word"
        strRealWord = strSelectedWord
        WordScrambler()
        TimeKeeper.Enabled = True

        PauseGameToolStripMenuItem.Enabled = True

        mnuCheat.Enabled = True
        txtUserWord.Enabled = True
        txtUserWord.Clear()
        txtUserWord.Focus()
    End Sub
End Class
