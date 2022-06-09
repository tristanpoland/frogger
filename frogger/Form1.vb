'Install driver to interact with MongoDB
Imports MongoDB.Driver
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

'Primary form class for level
Public Class Form1

    'Global declarations
    Private currentFrameRate As Integer
    Private score As Integer
    Public placementid As Integer = 0
    Public candidateid As Integer = 0
    Public candidatename As String = ""
    Public clientid As Integer = 0
    Public clientname As String = ""
    Public placementstartdate As Date = Nothing
    Public placementenddate As Date = Nothing
    Public readyforbilling As Boolean = False
    Public fullday As Integer = 0
    Public halfday As Integer = 0
    Public chargerate As Decimal = 0.0
    Public payrate As Decimal = 0.0
    Public dateworked As Date = Nothing
    Public candidatephone As String = ""
    Public clientphone As String = ""
    Public status As String = ""
    Public key As String = ""

    Public Function Clone() As Object
        Dim m As New MemoryStream()
        Dim f As New BinaryFormatter()
        f.Serialize(m, Me)
        m.Seek(0, SeekOrigin.Begin)
        Return f.Deserialize(m)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tick.Enabled = True
        DBConnect()
    End Sub

    Sub DBConnect()
        Dim client = New MongoClient("mongodb://localhost:27017")
        Dim database = client.GetDatabase("Frog_Game")
        'Dim collection = database.GetCollection("High_Scores")
    End Sub

    'Handles movement for player
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim movedist As Integer
        movedist = 45
        If e.KeyCode = Keys.W Then
            score = score + 1
            ScoreText.Text = score
            Player.Top = Player.Top - movedist
        ElseIf e.KeyCode = Keys.S Then
            score = score - 1
            Player.Top = Player.Top + movedist
        End If

        If e.KeyCode = Keys.A Then
            If Player.Left > 1 Then
                Player.Left = Player.Left - movedist
            End If
        ElseIf e.KeyCode = Keys.D Then
            If Player.Left < 600 Then
                Player.Left = Player.Left + movedist
            End If
        End If
    End Sub

    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles Tick.Tick

        'Declare vars for game tick
        Dim Row1() = {car_r1c1, car_r1c2, car_r1c3, r3c1, r3c2, r3c3, r1l1, r1l2, r3l1, r3l2}
        Dim Row2() = {car_r2c1, car_r2c2, car_r2c3, r4c1, r4c2, r4c3, r2l1, r2l2, r2l3, r4l1, r4l2}
        Dim insults() = {"Those who welcome death have only tried it from the ears up. —Wilson Mizner (playwright)", "The worst time To have a heart attack Is during a game Of charades, especially If your teammates are bad guessers. —Demetri Martin (comedian)", "I intend To live forever Or die trying. —Groucho Marx (comedian)", "Death Is a very dull, dreary affair, And my advice To you Is To have Nothing whatsoever To Do With it. William Somerset Maugham (author)", "The art Of dying graciously Is nowhere advertised In spite Of the fact that its market potential Is great. —Milton Mayer (author)", "At my age, I Do what Mark Twain did. I Get my daily paper, look at the obituaries page And If Im Not there, I carry On As usual. -Patrick Moore (astronomer)", "He Is one Of those people who would be enormously improved by death. —HH Munro (author)", "My father was from Aberdeen, And a more generous man you couldn't wish to meet. I have a gold watch that belonged to him. He sold it to me on his deathbed. I wrote him a cheque for it, post-dated of course. —Chic Murray (comedian)", "When I die, I hope to go to heaven, whatever the hell that is. —Ayn Rand (author)", "The only difference between death and taxes is that death doesnt get worse every time congress meets. —Will Rogers (actor)", "I can't afford to die; I'd lose too much money. —George Burns (comedian)", "If at first you don't suceed... Quit because it wasnt worth it anyway!", "Scardy cat!", "You dummyhead *facepalm*", "That was just embarrassing", "I do not fear death. I had been dead for billions of years before I was born and had not suffered the slightest inconvenience. —Mark Twain (author)"}
        Dim seeding As New Random
        Dim seed As Integer



        'Define vars for game tick
        seed = (seeding.Next(10) + 0)

        ' The Call statement is not needed, but makes it obvious.
        Call advanceFrameRate()

        'Debug screen
        debug_height.Text = "X: " + Player.Top.ToString + ",    Y: " + Player.Left.ToString + "    FPS: " + currentFrameRate.ToString

        'Player Array manager #1
        If Player.Top = 252 Then
            If Player.Bounds.IntersectsWith(r1l1.Bounds) Or Player.Bounds.IntersectsWith(r1l2.Bounds) Then

            Else
                Player.Top = 522
                Player.Left = 241
                WaterDeath()
                MessageBox.Show(insults(seed))
            End If

            If Row1.Length = 10 Then
                Dim newItem As PictureBox = Player
                Row1 = Row1.Concat({newItem}).ToArray
            End If
        End If

        'Player Array manager #2
        If Player.Top = 207 Then
            If Player.Bounds.IntersectsWith(r2l1.Bounds) Or Player.Bounds.IntersectsWith(r2l2.Bounds) Or Player.Bounds.IntersectsWith(r2l3.Bounds) Then

            Else
                Player.Top = 522
                Player.Left = 241
                WaterDeath()
                MessageBox.Show(insults(seed))
            End If
            If Row2.Length = 11 Then
                Dim newItem As PictureBox = Player
                Row2 = Row2.Concat({newItem}).ToArray
            End If
        End If

        'Player Array manager #3
        If Player.Top = 162 Then
            If Player.Bounds.IntersectsWith(r3l1.Bounds) Or Player.Bounds.IntersectsWith(r3l2.Bounds) Then

            Else
                Player.Top = 522
                Player.Left = 241
                WaterDeath()
                MessageBox.Show(insults(seed))
            End If
            If Row1.Length = 10 Then
                Dim newItem As PictureBox = Player
                Row1 = Row1.Concat({newItem}).ToArray
            End If
        End If

        'Player Array manager #4
        If Player.Top = 117 Then
            If Player.Bounds.IntersectsWith(r4l1.Bounds) Or Player.Bounds.IntersectsWith(r4l2.Bounds) Then

            Else
                Player.Top = 522
                Player.Left = 241
                WaterDeath()
                MessageBox.Show(insults(seed))
            End If
            If Row2.Length = 11 Then
                Dim newItem As PictureBox = Player
                Row2 = Row2.Concat({newItem}).ToArray
            End If
        End If

        For a = 0 To Row1.Length - 1
            If Row1(a).Left < Me.Width Then
                Row1(a).Left = Row1(a).Left + 4
            Else
                Row1(a).Left = -100 - Row1(a).Width
            End If
        Next

        For a = 0 To Row2.Length - 1
            If Row2(a).Left > 0 - Row2(a).Width Then
                Row2(a).Left = Row2(a).Left - 4
            Else
                Row2(a).Left = Me.Width
            End If
        Next

        'Death handlers (cars and offsides)
        For a = 0 To 5
            If Player.Bounds.IntersectsWith(Row1(a).Bounds) Or Player.Bounds.IntersectsWith(Row2(a).Bounds) Then
                Player.Top = 522
                Player.Left = 241
                MessageBox.Show(insults(seed))
            End If
            If Player.Bounds.IntersectsWith(Row1(a).Bounds) Or Player.Bounds.IntersectsWith(Row2(a).Bounds) Then

            End If
        Next
        For a = 0 To 5
            If Player.Left < 0 Or Player.Left > Me.Width Then
                Player.Top = 522
                Player.Left = 241
                MessageBox.Show(insults(seed))
            End If
        Next

    End Sub

    ' Framerate Counter
    Private Sub advanceFrameRate()
        Static ptlu As Double ' Time of last framerate update.
        ' Show me hardware that can do 32k F/sec...
        Static callCount As Integer
        ' Increment the callCounter
        callCount += 1
        ' Change 1000 if an alternate time value is desired.
        If (Environment.TickCount - ptlu) >= 1000 Then

            currentFrameRate = callCount
            ' Reset the callCount, AFTER updating the value.
            callCount = 0
            ' Reset the timeUpdated
            ptlu = Environment.TickCount
        Else
        End If
    End Sub

    Sub WaterDeath()
        Dim MyPlayer As System.Media.SoundPlayer
        MyPlayer = New System.Media.SoundPlayer(My.Resources.cannonball)
        MyPlayer.Play()
    End Sub

End Class