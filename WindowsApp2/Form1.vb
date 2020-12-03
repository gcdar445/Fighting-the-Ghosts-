Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.J
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
                Me.Refresh()
            Case Keys.Up
                MoveTo(PictureBox1, 0, -5)
            Case Keys.Down
                MoveTo(PictureBox1, 0, 5)
            Case Keys.Left
                MoveTo(PictureBox1, -5, 0)
            Case Keys.Right
                MoveTo(PictureBox1, 5, 0)
            Case Keys.Space
                CreateNew("bullet", PictureBox2, PictureBox1.Location)
            Case Else

        End Select
    End Sub
    Function Collision(p As String, t As String, Optional ByRef other As Object = vbNull)
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                Return Collision(c, t, other)
            End If
        Next
        Return False
    End Function
    Function getobject(n As String) As Object
        For Each c In Controls
            If c.name.toupper.ToString.Contains(n.ToUpper) Then
                Return c
            End If
        Next
    End Function
    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
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
        If IsClear(p, distx, disty, "Wall") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If Collision("bullet", "PictureBox3", other) Then
            'Me.BackColor = Color.Green
            other.visible = False
            getobject("bullet").visible = False
            Return
        End If
    End Sub
    Sub MoveTo(p As String, distx As Integer, disty As Integer)
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                MoveTo(c, distx, disty)
            End If
        Next

    End Sub
    Sub CreateNew(name As String, pic As PictureBox, location As Point)
        Dim p As New PictureBox
        p.Location = location
        p.Image = pic.Image
        p.BackColor = pic.BackColor
        p.Name = name
        p.Width = pic.Width
        p.Height = pic.Height
        p.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(p)

    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoveTo("bullet", 30, 0)
        Chase(PictureBox3)

    End Sub
    Private Sub Follow(p As PictureBox)
        Static Headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        Headstart = Headstart + 1
        If Headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub
    Public Sub Chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -3
        Else
            x = 3
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 3
        Else
            y = -3
        End If
        MoveTo(p, x, y)
    End Sub
End Class
