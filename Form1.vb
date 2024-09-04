Public Class Form1

    Dim runningColor As Color = Color.Black
    Dim pausedColor As Color = Color.White


    Dim hours As Long = 0
    Dim minutes As Integer = 0
    Dim seconds As Integer = 0
    Dim milliseconds As Integer = 0

    Dim timerRunningBackColor As Color = Color.Black
    Dim timerRunningForeColor As Color = Color.White
    Dim timerPausedBackColor As Color = Color.White
    Dim timerPausedForeColor As Color = Color.Black

    Dim buttonRunningForeColor As Color = Color.Black
    Dim buttonRunningBackColor As Color = Color.White
    Dim buttonPausedBackColor As Color = Color.Black
    Dim buttonPausedForeColor As Color = Color.White


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Timer1.Start()
        Me.BackColor = runningColor

        lblTimer.BackColor = timerRunningBackColor
        lblTimer.ForeColor = timerRunningForeColor

        btnStart.BackColor = buttonRunningBackColor
        btnStop.BackColor = buttonRunningBackColor
        btnReset.BackColor = buttonRunningBackColor
        btnLap.BackColor = buttonRunningBackColor

        btnStart.ForeColor = buttonRunningForeColor
        btnStop.ForeColor = buttonRunningForeColor
        btnReset.ForeColor = buttonRunningForeColor
        btnLap.ForeColor = buttonRunningForeColor

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTimer.Text = hours & " : " & minutes & " : " & seconds & " : " & milliseconds

        milliseconds += 1

        If milliseconds = 100 Then

            seconds += 1
            milliseconds = 0

            If seconds = 60 Then

                minutes += 1
                seconds = 0

            End If
            If minutes = 60 Then

                hours += 1
                minutes = 0

            End If

        End If

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
        Me.BackColor = pausedColor


        lblTimer.BackColor = timerPausedBackColor
        lblTimer.ForeColor = timerPausedForeColor


        btnStart.BackColor = buttonPausedBackColor
        btnStop.BackColor = buttonPausedBackColor
        btnReset.BackColor = buttonPausedBackColor
        btnLap.BackColor = buttonPausedBackColor



        btnStart.ForeColor = buttonPausedForeColor
        btnStop.ForeColor = buttonPausedForeColor
        btnReset.ForeColor = buttonPausedForeColor
        btnLap.ForeColor = buttonPausedForeColor


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Timer1.Stop()
        Me.BackColor = runningColor

        Laps.Items.Clear()

        lblTimer.BackColor = timerRunningBackColor
        lblTimer.ForeColor = timerRunningForeColor


        btnStart.BackColor = buttonRunningBackColor
        btnStop.BackColor = buttonRunningBackColor
        btnReset.BackColor = buttonRunningBackColor
        btnLap.BackColor = buttonRunningBackColor

        btnStart.ForeColor = buttonRunningForeColor
        btnStop.ForeColor = buttonRunningForeColor
        btnReset.ForeColor = buttonRunningForeColor
        btnLap.ForeColor = buttonRunningForeColor


        hours = 0
        minutes = 0
        seconds = 0
        milliseconds = 0

        lblTimer.Text = hours & " : " & minutes & " : " & seconds & " : " & milliseconds

    End Sub

    Private Sub btnLap_Click(sender As Object, e As EventArgs) Handles btnLap.Click
        Dim lapTime As String = hours & " : " & minutes & " : " & seconds & " : " & milliseconds
        Laps.Items.Add("Lap " & Laps.Items.Count + 1 & ": " & lapTime)
    End Sub

End Class
