Public Class Form1

    Dim Linus As PictureBox
    Private Sub CreateNew(v As String, bullet As PictureBox)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                MoveTo(Wario, 0, -80)
            Case Keys.Down
                MoveTo(Wario, 0, 30)
            Case Keys.Left
                MoveTo(Wario, -30, 0)
            Case Keys.Right
                MoveTo(Wario, 30, 0)
            Case Keys.Space
                CreateNew("Fire", Fire)
                Fire.Location = Wario.Location
                Fire.Visible = True
                Fire.BackColor = PictureBox1.BackColor
                Fire_Timer.Enabled = True
                MoveTo(Fire, 15, 0)
            Case Keys.R
                Wario.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                Me.Refresh()
                MoveTo(Fire, -15, 0)
        End Select
    End Sub
    Private Sub Fire_Timer_Tick(sender As Object, e As EventArgs) Handles Fire_Timer.Tick
        Move(Fire, 15, 0)
    End Sub


    Sub Move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    End Sub
    Sub Follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(Wario.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub Chase(p As PictureBox)
        Dim x, y As Integer
        If Linus.Location.X > Wario.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If Linus.Location.Y < Wario.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(Linus, x, y)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Linus_Timer.Tick
        Chase(Linus)
    End Sub


    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
            If p.Name = "Fire" And Collision(Linus, "Fire") Then
                Linus.Visible = False
                you_win.Visible = True
                Linus_Timer.Enabled = False
                Fire.Visible = False
            End If
            Return
            End If
            If p.Name = "Linus" And Collision(Wario, "Linus") Then
            Wario.Visible = False
            You_Lose.Visible = True
            Fire.Visible = False
            Fire.Enabled = False
            Linus_Timer.Enabled = False
            Fire_Timer.Enabled = False
            BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Gravity_Timer.Tick
        MoveTo(Wario, 0, 4)
    End Sub
End Class





