Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tick.Enabled = True
        GameTick.Enabled = True
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            Player.Top = Player.Top - 35
        ElseIf e.KeyCode = Keys.S Then
            Player.Top = Player.Top + 35
        End If

        If e.KeyCode = Keys.A Then
            Player.Left = Player.Left - 35
        ElseIf e.KeyCode = Keys.D Then
            Player.Left = Player.Left + 35
        End If
    End Sub

    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles Tick.Tick
        Dim Row1() = {car_r1c1, car_r1c2, car_r1c3}
        Dim Row2() = {car_r2c1, car_r2c2, car_r2c3}


        For a = 0 To 2
            If Row1(a).Left < Me.Width Then
                Row1(a).Left = Row1(a).Left + 4
            Else
                Row1(a).Left = 0
            End If
        Next

        For a = 0 To 2
            If Row2(a).Left > 0 - Row2(a).Width Then
                Row2(a).Left = Row2(a).Left - 4
            Else
                Row2(a).Left = Me.Width
            End If
        Next

        For a = 0 To 2
            If Player.Bounds.IntersectsWith(Row1(a).Bounds) Or Player.Bounds.IntersectsWith(Row2(a).Bounds) Then
                Player.Top = 484
                Player.Left = 195
                MessageBox.Show("You dummy *facepalm*")
                'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            End If
        Next
    End Sub

    Private Sub car_r1c3_Click(sender As Object, e As EventArgs) Handles car_r1c3.Click

    End Sub

    Private Sub car_r1c2_Click(sender As Object, e As EventArgs) Handles car_r1c2.Click

    End Sub

    Private Sub car_r1c1_Click(sender As Object, e As EventArgs) Handles car_r1c1.Click

    End Sub

End Class
