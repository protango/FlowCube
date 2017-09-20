Public Class Form1
    Dim started As Boolean = False
    Dim relevant As Object = PictureBox2
    Dim relevants As String = "PictureBox2"
    Dim Speedy As Double = 1
    Dim Speed As Integer = 3
    Dim z As Integer = 0
    Dim score As Integer = 0
    Dim splash(8) As Object
    Dim boxes(4) As Object
    Dim goals(3) As Object
    Dim uidspd As Integer = 1
    Dim animy = New Integer() {0, 0, 0, 0}
    Dim animd = New Integer() {1, 1, 1, 1}
    Dim closest = New Double() {1, 100}
    Dim xc As Integer = 0
    Dim Dobj As Object
    Dim insane As Boolean = False
    Dim insanespd As Integer = 1
    Dim Cheating As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
        splash(0) = PictureBox16
        splash(1) = PictureBox12
        splash(2) = PictureBox13
        splash(3) = PictureBox14
        splash(4) = PictureBox15
        splash(5) = PictureBox17
        splash(6) = PictureBox18
        splash(7) = PictureBox19
        splash(8) = PictureBox20
        boxes(0) = PictureBox2
        boxes(1) = PictureBox3
        boxes(2) = PictureBox4
        boxes(3) = PictureBox5
        boxes(4) = PictureBox6
        goals(0) = PictureBox1
        goals(1) = PictureBox9
        goals(2) = PictureBox10
        goals(3) = PictureBox11
        Byline.Visible = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
    End Sub
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.D1 Then
            PictureBox1.BackColor = Color.Red
        End If
        If e.KeyCode = Keys.D2 Then
            PictureBox9.BackColor = Color.Red
        End If
        If e.KeyCode = Keys.D3 Then
            PictureBox10.BackColor = Color.Red
        End If
        If e.KeyCode = Keys.D4 Then
            PictureBox11.BackColor = Color.Red
        End If
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            If PictureBox16.Visible Then
                Level.Enabled = False
                Level.Enabled = True
            End If
            MaskedTextBox1.Visible = False
            MaskedTextBox1.ReadOnly = True
            MaskedTextBox1.Enabled = False
            Speed = 3
            Me.Focus()
            For Each item As Object In splash
                item.Visible = False
            Next
            If insane Then
                Insanitytimer.Enabled = True
            Else
                Insanitytimer.Enabled = False
            End If
            Pre_Anim.Enabled = False
            Timer6.Enabled = True
        End If
        If e.KeyCode = Keys.D1 Then
            PictureBox1.BackColor = Color.Orange
            If PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox3.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox4.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox5.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox6.Bounds) Then

            Else
                Gameoveranim("PH1")
            End If
        End If
        If e.KeyCode = Keys.D2 Then
            PictureBox9.BackColor = Color.Orange
            If PictureBox9.Bounds.IntersectsWith(PictureBox2.Bounds) Or PictureBox9.Bounds.IntersectsWith(PictureBox3.Bounds) Or PictureBox9.Bounds.IntersectsWith(PictureBox4.Bounds) Or PictureBox9.Bounds.IntersectsWith(PictureBox5.Bounds) Or PictureBox9.Bounds.IntersectsWith(PictureBox6.Bounds) Then

            Else
                Gameoveranim("PH2")
            End If
        End If
        If e.KeyCode = Keys.D3 Then
            PictureBox10.BackColor = Color.Orange
            If PictureBox10.Bounds.IntersectsWith(PictureBox2.Bounds) Or PictureBox10.Bounds.IntersectsWith(PictureBox3.Bounds) Or PictureBox10.Bounds.IntersectsWith(PictureBox4.Bounds) Or PictureBox10.Bounds.IntersectsWith(PictureBox5.Bounds) Or PictureBox10.Bounds.IntersectsWith(PictureBox6.Bounds) Then

            Else
                Gameoveranim("PH3")
            End If
        End If
        If e.KeyCode = Keys.D4 Then
            PictureBox11.BackColor = Color.Orange
            If PictureBox11.Bounds.IntersectsWith(PictureBox2.Bounds) Or PictureBox11.Bounds.IntersectsWith(PictureBox3.Bounds) Or PictureBox11.Bounds.IntersectsWith(PictureBox4.Bounds) Or PictureBox11.Bounds.IntersectsWith(PictureBox5.Bounds) Or PictureBox11.Bounds.IntersectsWith(PictureBox6.Bounds) Then

            Else
                Gameoveranim("PH4")
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            If Cheating Then Cheating = False
        End If
        'UNIMPLEMENTED GAME MECHANIC
        If e.KeyCode = Keys.Up Then
            For Each item As Object In goals
                item.location = New Point(item.Location.X, item.Location.Y - 115)
            Next
        End If
        If e.KeyCode = Keys.Down Then
            For Each item As Object In goals
                item.location = New Point(item.Location.X, item.Location.Y + 115)
            Next
        End If
    End Sub
    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        If PictureBox16.Visible Then
            Level.Enabled = False
            Level.Enabled = True
        End If
        MaskedTextBox1.Visible = False
        MaskedTextBox1.ReadOnly = True
        MaskedTextBox1.Enabled = False
        Speed = 3
        Me.Focus()
        For Each item As Object In splash
            item.Visible = False
        Next
        If insane Then
            Insanitytimer.Enabled = True
        Else
            Insanitytimer.Enabled = False
        End If
        Pre_Anim.Enabled = False
        Timer6.Enabled = True
    End Sub
    Private Function Repos() As Boolean
        If Not PictureBox2.Bounds.IntersectsWith(PictureBox7.Bounds) And Not PictureBox3.Bounds.IntersectsWith(PictureBox7.Bounds) And Not PictureBox4.Bounds.IntersectsWith(PictureBox7.Bounds) And Not PictureBox5.Bounds.IntersectsWith(PictureBox7.Bounds) And Not PictureBox6.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            z = z + 1
            If z = 6 Then z = 1
            Select Case z
                Case 1
                    relevant = PictureBox2
                    relevants = "PictureBox2"
                Case 2
                    relevant = PictureBox3
                    relevants = "PictureBox3"
                Case 3
                    relevant = PictureBox4
                    relevants = "PictureBox4"
                Case 4
                    relevant = PictureBox5
                    relevants = "PictureBox5"
                Case 5
                    relevant = PictureBox6
                    relevants = "PictureBox6"
            End Select
            Dim spos As Integer = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1
            Select Case spos
                Case 1
                    relevant.Location = New Point(0, 0)
                Case 2
                    relevant.Location = New Point(98, 0)
                Case 3
                    relevant.Location = New Point(196, 0)
                Case 4
                    relevant.Location = New Point(294, 0)
            End Select
            Select Case relevants
                Case "PictureBox2"
                    Timer1.Enabled = True
                Case "PictureBox3"
                    Timer2.Enabled = True
                Case "PictureBox4"
                    Timer3.Enabled = True
                Case "PictureBox5"
                    Timer4.Enabled = True
                Case "PictureBox6"
                    Timer5.Enabled = True
            End Select
            relevant.Visible = True
        End If
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y + Speed)
        If PictureBox2.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            If Not PictureBox2.BackColor = Color.DarkGray Then
                Gameoveranim("PC2C")
            End If
            Timer1.Enabled = False
            PictureBox2.Visible = False
            PictureBox2.BackColor = Color.Black
            score = score + 1
        End If
        If PictureBox2.Location.Y > 332 Then
            Select Case PictureBox2.Location.X
                Case 0
                    If PictureBox1.BackColor = Color.Orange Then PictureBox2.BackColor = Color.DarkGray
                Case 98
                    If PictureBox9.BackColor = Color.Orange Then PictureBox2.BackColor = Color.DarkGray
                Case 196
                    If PictureBox10.BackColor = Color.Orange Then PictureBox2.BackColor = Color.DarkGray
                Case 294
                    If PictureBox11.BackColor = Color.Orange Then PictureBox2.BackColor = Color.DarkGray
            End Select
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox3.Location = New Point(PictureBox3.Location.X, PictureBox3.Location.Y + Speed)
        If PictureBox3.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            If Not PictureBox3.BackColor = Color.DarkGray Then
                Gameoveranim("PC3C")
            End If
            Timer2.Enabled = False
            PictureBox3.Visible = False
            PictureBox3.BackColor = Color.Black
            score = score + 1
        End If
        If PictureBox3.Location.Y > 332 Then
            Select Case PictureBox3.Location.X
                Case 0
                    If PictureBox1.BackColor = Color.Orange Then PictureBox3.BackColor = Color.DarkGray
                Case 98
                    If PictureBox9.BackColor = Color.Orange Then PictureBox3.BackColor = Color.DarkGray
                Case 196
                    If PictureBox10.BackColor = Color.Orange Then PictureBox3.BackColor = Color.DarkGray
                Case 294
                    If PictureBox11.BackColor = Color.Orange Then PictureBox3.BackColor = Color.DarkGray
            End Select
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        PictureBox4.Location = New Point(PictureBox4.Location.X, PictureBox4.Location.Y + Speed)
        If PictureBox4.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            If Not PictureBox4.BackColor = Color.DarkGray Then
                Gameoveranim("PC4C")
            End If
            Timer3.Enabled = False
            PictureBox4.Visible = False
            PictureBox4.BackColor = Color.Black
            score = score + 1
        End If
        If PictureBox4.Location.Y > 332 Then
            Select Case PictureBox4.Location.X
                Case 0
                    If PictureBox1.BackColor = Color.Orange Then PictureBox4.BackColor = Color.DarkGray
                Case 98
                    If PictureBox9.BackColor = Color.Orange Then PictureBox4.BackColor = Color.DarkGray
                Case 196
                    If PictureBox10.BackColor = Color.Orange Then PictureBox4.BackColor = Color.DarkGray
                Case 294
                    If PictureBox11.BackColor = Color.Orange Then PictureBox4.BackColor = Color.DarkGray
            End Select
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        PictureBox5.Location = New Point(PictureBox5.Location.X, PictureBox5.Location.Y + Speed)
        If PictureBox5.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            If Not PictureBox5.BackColor = Color.DarkGray Then
                Gameoveranim("PC5C")
            End If
            Timer4.Enabled = False
            PictureBox5.Visible = False
            PictureBox5.BackColor = Color.Black
            score = score + 1
        End If
        If PictureBox5.Location.Y > 332 Then
            Select Case PictureBox5.Location.X
                Case 0
                    If PictureBox1.BackColor = Color.Orange Then PictureBox5.BackColor = Color.DarkGray
                Case 98
                    If PictureBox9.BackColor = Color.Orange Then PictureBox5.BackColor = Color.DarkGray
                Case 196
                    If PictureBox10.BackColor = Color.Orange Then PictureBox5.BackColor = Color.DarkGray
                Case 294
                    If PictureBox11.BackColor = Color.Orange Then PictureBox5.BackColor = Color.DarkGray
            End Select
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        PictureBox6.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y + Speed)
        If PictureBox6.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            If Not PictureBox6.BackColor = Color.DarkGray Then
                Gameoveranim("PC6C")
            End If
            Timer5.Enabled = False
            PictureBox6.Visible = False
            PictureBox6.BackColor = Color.Black
            score = score + 1
        End If
        If (PictureBox6.Bounds.IntersectsWith(PictureBox1.Bounds) And PictureBox1.BackColor = Color.Orange) Or (PictureBox6.Bounds.IntersectsWith(PictureBox9.Bounds) And PictureBox9.BackColor = Color.Orange) Or (PictureBox6.Bounds.IntersectsWith(PictureBox10.Bounds) And PictureBox10.BackColor = Color.Orange) Or (PictureBox6.Bounds.IntersectsWith(PictureBox11.Bounds) And PictureBox11.BackColor = Color.Orange) Then
            PictureBox6.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Repos()
        Label2.Text = score
        Label4.Text = Speed
        If insane Then
            Speed = insanespd
            If Insanitytimer.Enabled = False And Insanitytimer.Interval = 900 Then
                For Each item As Object In boxes
                    If item.backcolor = Color.DarkGray Then item.Image = My.Resources.bk_rbones Else item.Image = My.Resources.bk_bones
                Next
            End If

        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
    Private Function Gameover() As Boolean
        insane = False
        Label5.Visible = False
        Level.Interval = 10000
        Cheating = False
        insanespd = 1
        Insanitytimer.Interval = 10000
        My.Computer.Audio.Stop()
        For Each item As Object In boxes
            item.Visible = False
            item.Location = New Point(0, 326)
            item.BackColor = Color.Black
            item.image = Nothing
        Next
        For Each Item As Object In splash
            Item.Visible = True
        Next
        Pre_Anim.Enabled = True
        score = 0
        Speed = 3
    End Function
    Private Function Gameoveranim(ByVal type As String) As Boolean
        If Not cheating Then
            If PictureBox16.Visible = False Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
                Timer4.Enabled = False
                Timer5.Enabled = False
                Timer6.Enabled = False
                Insanitytimer.Enabled = False
                Level.Enabled = False
                Select Case type
                    Case "PC2C"
                        Dobj = PictureBox2
                    Case "PC3C"
                        Dobj = PictureBox3
                    Case "PC4C"
                        Dobj = PictureBox4
                    Case "PC5C"
                        Dobj = PictureBox5
                    Case "PC6C"
                        Dobj = PictureBox6
                    Case "PH1"
                        Dobj = PictureBox1
                    Case "PH2"
                        Dobj = PictureBox9
                    Case "PH3"
                        Dobj = PictureBox10
                    Case "PH4"
                        Dobj = PictureBox11
                End Select
                xc = 0
                GO_anim.Enabled = True
            End If
        End If
    End Function

    Private Sub Pre_Anim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pre_Anim.Tick
        For i As Integer = 5 To 8
            Dim ud As Integer = CInt(Int((2 * Rnd()) + 1))
            If animy(i - 5) > 50 Then
                animd(i - 5) = ud
                animy(i - 5) = 0
            End If
            If animd(i - 5) = 1 Then splash(i).Location = New Point(splash(i).Location.X, splash(i).Location.Y + uidspd)
            If animd(i - 5) = 2 Then splash(i).Location = New Point(splash(i).Location.X, splash(i).Location.Y - uidspd)
            If splash(i).Location.Y < 1 Then
                animd(i - 5) = 1
                animy(i - 5) = 0
            End If
            If splash(i).Location.Y > 326 Then
                animd(i - 5) = 2
                animy(i - 5) = 0
            End If
            animy(i - 5) = animy(i - 5) + 1
        Next
    End Sub
    Function gcd(ByVal a As Long, ByVal b As Long) As Integer
        Dim temp As Long
        Do While b > 0
            temp = b
            b = a Mod b
            a = temp
        Loop
        gcd = a
    End Function

    Private Sub Level_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level.Tick
        Speed = Speed + 1
        Level.Interval = Level.Interval * 1.2
    End Sub

    Private Sub GO_anim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GO_anim.Tick
        If Dobj.Visible = False Then
            Dobj.Visible = True
        Else
            Dobj.Visible = False
        End If
        xc = xc + 1
        If xc = 6 Then
            Dobj.Visible = True
            GO_anim.Enabled = False
            Gameover()
        End If

    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        MaskedTextBox1.Visible = True
        MaskedTextBox1.ReadOnly = False
        MaskedTextBox1.Enabled = True
        If Not MaskedTextBox1.Text = Nothing Then
            If MaskedTextBox1.Text = "INSANE" Then
                insane = True
                Label5.Visible = True
                MaskedTextBox1.Visible = False
                MaskedTextBox1.ReadOnly = True
                MaskedTextBox1.Enabled = False
                Me.Focus()
            End If
        End If
    End Sub

    Private Sub Insanitytimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insanitytimer.Tick
        If Insanitytimer.Interval = 900 Then
            insanespd = 9
            Insanitytimer.Enabled = False
        End If
        If Insanitytimer.Interval = 20000 Then
            My.Computer.Audio.Play(My.Resources.bangarang, AudioPlayMode.BackgroundLoop)
            Insanitytimer.Interval = 900
        End If
        If Insanitytimer.Interval = 10000 Then
            insanespd = 3
            Insanitytimer.Interval = 20000
        End If

    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        MsgBox("Bet'cha feel real special right now...")
        Cheating = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub
End Class
