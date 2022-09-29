Public Class Form1
    Dim ballupinteger As Integer
    Dim ballleftinteger As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ballleftinteger = -3
        ballupinteger = 3
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Ball.Top += ballupinteger
        Ball.Left += ballleftinteger


        If Ball.Top < 0 Then
            ballupinteger = ballupinteger * -1
        End If
        If Ball.Top > Me.Height - 60 Then
            ballupinteger = ballupinteger * -1
        End If

        If Ball.Left < 0 Then
            ballleftinteger = ballleftinteger * -1
        End If
        If Ball.Left > Me.Width - 30 Then
            ballleftinteger = ballleftinteger * -1
        End If


    End Sub

    Private Sub Ball_Click(sender As Object, e As EventArgs) Handles Ball.Click

    End Sub
End Class
