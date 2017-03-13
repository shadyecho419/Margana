<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarganaMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarganaMain))
        Me.btnNextWord = New System.Windows.Forms.Button
        Me.btnSubmitWord = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblScrambledWord = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUserWord = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblCorrect = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblWrong = New System.Windows.Forms.ToolStripStatusLabel
        Me.pbWordLoad = New System.Windows.Forms.ToolStripProgressBar
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GameOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AfrikaansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EasyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MediumToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GermanWordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EasyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.MediumToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.HardToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.PortugueseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EasyToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.MediumToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.HardToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.PauseGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitCurrentGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCheat = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lstWords = New System.Windows.Forms.ListBox
        Me.btnScrambleWord = New System.Windows.Forms.Button
        Me.lblRealWord = New System.Windows.Forms.Label
        Me.TimeKeeper = New System.Windows.Forms.Timer(Me.components)
        Me.CheatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNextWord
        '
        Me.btnNextWord.BackColor = System.Drawing.Color.Transparent
        Me.btnNextWord.BackgroundImage = CType(resources.GetObject("btnNextWord.BackgroundImage"), System.Drawing.Image)
        Me.btnNextWord.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNextWord.Enabled = False
        Me.btnNextWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextWord.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextWord.ForeColor = System.Drawing.Color.Green
        Me.btnNextWord.Location = New System.Drawing.Point(238, 160)
        Me.btnNextWord.Name = "btnNextWord"
        Me.btnNextWord.Size = New System.Drawing.Size(158, 76)
        Me.btnNextWord.TabIndex = 5
        Me.btnNextWord.Text = "Next Word"
        Me.btnNextWord.UseVisualStyleBackColor = False
        '
        'btnSubmitWord
        '
        Me.btnSubmitWord.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmitWord.BackgroundImage = CType(resources.GetObject("btnSubmitWord.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmitWord.Enabled = False
        Me.btnSubmitWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmitWord.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitWord.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnSubmitWord.Location = New System.Drawing.Point(74, 160)
        Me.btnSubmitWord.Name = "btnSubmitWord"
        Me.btnSubmitWord.Size = New System.Drawing.Size(158, 76)
        Me.btnSubmitWord.TabIndex = 4
        Me.btnSubmitWord.Text = "Submit Word"
        Me.btnSubmitWord.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your Word:"
        '
        'lblScrambledWord
        '
        Me.lblScrambledWord.AutoSize = True
        Me.lblScrambledWord.BackColor = System.Drawing.Color.Transparent
        Me.lblScrambledWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScrambledWord.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScrambledWord.ForeColor = System.Drawing.Color.Crimson
        Me.lblScrambledWord.Location = New System.Drawing.Point(261, 56)
        Me.lblScrambledWord.Name = "lblScrambledWord"
        Me.lblScrambledWord.Size = New System.Drawing.Size(89, 32)
        Me.lblScrambledWord.TabIndex = 1
        Me.lblScrambledWord.Text = "Word"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(3, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 30)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Scrambled Word:"
        '
        'txtUserWord
        '
        Me.txtUserWord.Enabled = False
        Me.txtUserWord.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserWord.ForeColor = System.Drawing.Color.Blue
        Me.txtUserWord.Location = New System.Drawing.Point(252, 107)
        Me.txtUserWord.Name = "txtUserWord"
        Me.txtUserWord.Size = New System.Drawing.Size(308, 35)
        Me.txtUserWord.TabIndex = 3
        Me.txtUserWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = CType(resources.GetObject("StatusStrip1.BackgroundImage"), System.Drawing.Image)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.lblTime, Me.lblCorrect, Me.lblWrong, Me.pbWordLoad})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 263)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(572, 35)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(139, 30)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Margana "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(74, 30)
        Me.ToolStripStatusLabel2.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblTime.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(26, 30)
        Me.lblTime.Text = "0"
        '
        'lblCorrect
        '
        Me.lblCorrect.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.lblCorrect.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.ForeColor = System.Drawing.Color.White
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(116, 30)
        Me.lblCorrect.Text = "0 Correct"
        '
        'lblWrong
        '
        Me.lblWrong.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.lblWrong.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.White
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(100, 30)
        Me.lblWrong.Text = "0 Wrong"
        '
        'pbWordLoad
        '
        Me.pbWordLoad.Name = "pbWordLoad"
        Me.pbWordLoad.Size = New System.Drawing.Size(100, 29)
        Me.pbWordLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameOptionsToolStripMenuItem, Me.mnuCheat})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 34)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameOptionsToolStripMenuItem
        '
        Me.GameOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.NewGameToolStripMenuItem, Me.PauseGameToolStripMenuItem, Me.ExitCurrentGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.GameOptionsToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.GameOptionsToolStripMenuItem.Name = "GameOptionsToolStripMenuItem"
        Me.GameOptionsToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.GameOptionsToolStripMenuItem.Text = "Game Options"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(336, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfrikaansToolStripMenuItem, Me.EnglishToolStripMenuItem, Me.GermanWordsToolStripMenuItem, Me.PortugueseToolStripMenuItem})
        Me.NewGameToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(336, 30)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        Me.NewGameToolStripMenuItem.ToolTipText = "Select a language to play"
        '
        'AfrikaansToolStripMenuItem
        '
        Me.AfrikaansToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.MediumToolStripMenuItem, Me.HardToolStripMenuItem})
        Me.AfrikaansToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue
        Me.AfrikaansToolStripMenuItem.Name = "AfrikaansToolStripMenuItem"
        Me.AfrikaansToolStripMenuItem.Size = New System.Drawing.Size(329, 30)
        Me.AfrikaansToolStripMenuItem.Text = "Afrikaans Words"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(194, 30)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(194, 30)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(194, 30)
        Me.HardToolStripMenuItem.Text = "Hard"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem1, Me.MediumToolStripMenuItem1, Me.HardToolStripMenuItem1})
        Me.EnglishToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(329, 30)
        Me.EnglishToolStripMenuItem.Text = "English Words"
        '
        'EasyToolStripMenuItem1
        '
        Me.EasyToolStripMenuItem1.ForeColor = System.Drawing.Color.Green
        Me.EasyToolStripMenuItem1.Name = "EasyToolStripMenuItem1"
        Me.EasyToolStripMenuItem1.Size = New System.Drawing.Size(194, 30)
        Me.EasyToolStripMenuItem1.Text = "Easy"
        '
        'MediumToolStripMenuItem1
        '
        Me.MediumToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange
        Me.MediumToolStripMenuItem1.Name = "MediumToolStripMenuItem1"
        Me.MediumToolStripMenuItem1.Size = New System.Drawing.Size(194, 30)
        Me.MediumToolStripMenuItem1.Text = "Medium"
        '
        'HardToolStripMenuItem1
        '
        Me.HardToolStripMenuItem1.ForeColor = System.Drawing.Color.Red
        Me.HardToolStripMenuItem1.Name = "HardToolStripMenuItem1"
        Me.HardToolStripMenuItem1.Size = New System.Drawing.Size(194, 30)
        Me.HardToolStripMenuItem1.Text = "Hard"
        '
        'GermanWordsToolStripMenuItem
        '
        Me.GermanWordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem2, Me.MediumToolStripMenuItem2, Me.HardToolStripMenuItem2})
        Me.GermanWordsToolStripMenuItem.ForeColor = System.Drawing.Color.Olive
        Me.GermanWordsToolStripMenuItem.Name = "GermanWordsToolStripMenuItem"
        Me.GermanWordsToolStripMenuItem.Size = New System.Drawing.Size(329, 30)
        Me.GermanWordsToolStripMenuItem.Text = "German Words"
        '
        'EasyToolStripMenuItem2
        '
        Me.EasyToolStripMenuItem2.ForeColor = System.Drawing.Color.Green
        Me.EasyToolStripMenuItem2.Name = "EasyToolStripMenuItem2"
        Me.EasyToolStripMenuItem2.Size = New System.Drawing.Size(194, 30)
        Me.EasyToolStripMenuItem2.Text = "Easy"
        '
        'MediumToolStripMenuItem2
        '
        Me.MediumToolStripMenuItem2.ForeColor = System.Drawing.Color.Orange
        Me.MediumToolStripMenuItem2.Name = "MediumToolStripMenuItem2"
        Me.MediumToolStripMenuItem2.Size = New System.Drawing.Size(194, 30)
        Me.MediumToolStripMenuItem2.Text = "Medium"
        '
        'HardToolStripMenuItem2
        '
        Me.HardToolStripMenuItem2.ForeColor = System.Drawing.Color.Red
        Me.HardToolStripMenuItem2.Name = "HardToolStripMenuItem2"
        Me.HardToolStripMenuItem2.Size = New System.Drawing.Size(194, 30)
        Me.HardToolStripMenuItem2.Text = "Hard"
        '
        'PortugueseToolStripMenuItem
        '
        Me.PortugueseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem3, Me.MediumToolStripMenuItem3, Me.HardToolStripMenuItem3})
        Me.PortugueseToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.PortugueseToolStripMenuItem.Name = "PortugueseToolStripMenuItem"
        Me.PortugueseToolStripMenuItem.Size = New System.Drawing.Size(329, 30)
        Me.PortugueseToolStripMenuItem.Text = "Portuguese Words"
        '
        'EasyToolStripMenuItem3
        '
        Me.EasyToolStripMenuItem3.ForeColor = System.Drawing.Color.Green
        Me.EasyToolStripMenuItem3.Name = "EasyToolStripMenuItem3"
        Me.EasyToolStripMenuItem3.Size = New System.Drawing.Size(194, 30)
        Me.EasyToolStripMenuItem3.Text = "Easy"
        '
        'MediumToolStripMenuItem3
        '
        Me.MediumToolStripMenuItem3.ForeColor = System.Drawing.Color.Orange
        Me.MediumToolStripMenuItem3.Name = "MediumToolStripMenuItem3"
        Me.MediumToolStripMenuItem3.Size = New System.Drawing.Size(194, 30)
        Me.MediumToolStripMenuItem3.Text = "Medium"
        '
        'HardToolStripMenuItem3
        '
        Me.HardToolStripMenuItem3.ForeColor = System.Drawing.Color.Red
        Me.HardToolStripMenuItem3.Name = "HardToolStripMenuItem3"
        Me.HardToolStripMenuItem3.Size = New System.Drawing.Size(194, 30)
        Me.HardToolStripMenuItem3.Text = "Hard"
        '
        'PauseGameToolStripMenuItem
        '
        Me.PauseGameToolStripMenuItem.Enabled = False
        Me.PauseGameToolStripMenuItem.ForeColor = System.Drawing.Color.Orchid
        Me.PauseGameToolStripMenuItem.Name = "PauseGameToolStripMenuItem"
        Me.PauseGameToolStripMenuItem.Size = New System.Drawing.Size(336, 30)
        Me.PauseGameToolStripMenuItem.Text = "Pause Game"
        '
        'ExitCurrentGameToolStripMenuItem
        '
        Me.ExitCurrentGameToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen
        Me.ExitCurrentGameToolStripMenuItem.Name = "ExitCurrentGameToolStripMenuItem"
        Me.ExitCurrentGameToolStripMenuItem.Size = New System.Drawing.Size(336, 30)
        Me.ExitCurrentGameToolStripMenuItem.Text = "Exit Current Game"
        Me.ExitCurrentGameToolStripMenuItem.ToolTipText = "Click here to terminate running game and select a new game if you wish a differen" & _
            "t game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Coral
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(336, 30)
        Me.ExitToolStripMenuItem.Text = "Exit Program"
        Me.ExitToolStripMenuItem.ToolTipText = "Exit Margnana "
        '
        'mnuCheat
        '
        Me.mnuCheat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowWordToolStripMenuItem})
        Me.mnuCheat.Enabled = False
        Me.mnuCheat.ForeColor = System.Drawing.Color.Gold
        Me.mnuCheat.Name = "mnuCheat"
        Me.mnuCheat.Size = New System.Drawing.Size(106, 30)
        Me.mnuCheat.Text = "Cheat!"
        '
        'ShowWordToolStripMenuItem
        '
        Me.ShowWordToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna
        Me.ShowWordToolStripMenuItem.Name = "ShowWordToolStripMenuItem"
        Me.ShowWordToolStripMenuItem.Size = New System.Drawing.Size(235, 30)
        Me.ShowWordToolStripMenuItem.Text = "Show Word"
        Me.ShowWordToolStripMenuItem.ToolTipText = "You are penalised 3 points for this!"
        '
        'lstWords
        '
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 17
        Me.lstWords.Location = New System.Drawing.Point(0, 242)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.ScrollAlwaysVisible = True
        Me.lstWords.Size = New System.Drawing.Size(246, 21)
        Me.lstWords.Sorted = True
        Me.lstWords.TabIndex = 10
        Me.lstWords.Visible = False
        '
        'btnScrambleWord
        '
        Me.btnScrambleWord.BackColor = System.Drawing.Color.Transparent
        Me.btnScrambleWord.BackgroundImage = CType(resources.GetObject("btnScrambleWord.BackgroundImage"), System.Drawing.Image)
        Me.btnScrambleWord.Enabled = False
        Me.btnScrambleWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnScrambleWord.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScrambleWord.ForeColor = System.Drawing.Color.BlueViolet
        Me.btnScrambleWord.Location = New System.Drawing.Point(402, 160)
        Me.btnScrambleWord.Name = "btnScrambleWord"
        Me.btnScrambleWord.Size = New System.Drawing.Size(158, 76)
        Me.btnScrambleWord.TabIndex = 11
        Me.btnScrambleWord.Text = "Scramble Word"
        Me.btnScrambleWord.UseVisualStyleBackColor = False
        '
        'lblRealWord
        '
        Me.lblRealWord.AutoSize = True
        Me.lblRealWord.BackColor = System.Drawing.Color.Transparent
        Me.lblRealWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRealWord.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealWord.ForeColor = System.Drawing.Color.White
        Me.lblRealWord.Location = New System.Drawing.Point(399, 56)
        Me.lblRealWord.Name = "lblRealWord"
        Me.lblRealWord.Size = New System.Drawing.Size(161, 32)
        Me.lblRealWord.TabIndex = 12
        Me.lblRealWord.Text = "Real Word"
        Me.lblRealWord.Visible = False
        '
        'TimeKeeper
        '
        Me.TimeKeeper.Interval = 1000
        '
        'CheatTimer
        '
        Me.CheatTimer.Interval = 1000
        '
        'frmMarganaMain
        '
        Me.AcceptButton = Me.btnSubmitWord
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnNextWord
        Me.ClientSize = New System.Drawing.Size(572, 298)
        Me.Controls.Add(Me.lblRealWord)
        Me.Controls.Add(Me.btnScrambleWord)
        Me.Controls.Add(Me.lstWords)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtUserWord)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblScrambledWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmitWord)
        Me.Controls.Add(Me.btnNextWord)
        Me.Font = New System.Drawing.Font("Ravie", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMarganaMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Margana"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNextWord As System.Windows.Forms.Button
    Friend WithEvents btnSubmitWord As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScrambledWord As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUserWord As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfrikaansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortugueseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstWords As System.Windows.Forms.ListBox
    Friend WithEvents pbWordLoad As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnScrambleWord As System.Windows.Forms.Button
    Friend WithEvents lblRealWord As System.Windows.Forms.Label
    Friend WithEvents TimeKeeper As System.Windows.Forms.Timer
    Friend WithEvents ExitCurrentGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCheat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheatTimer As System.Windows.Forms.Timer
    Friend WithEvents lblCorrect As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblWrong As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GermanWordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem

End Class
