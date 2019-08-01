
Public Class DataEntry
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        If MsgBox("Are you sure you want to exit??", MsgBoxStyle.YesNo, "Exit Program") = MsgBoxResult.Yes Then
            Me.Close()
            TimerWindow.Close()
        End If


    End Sub
    Private Sub Cmd_FullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FullScreen.Click
        'ok, so we clicked fullscreen, let's validate the info in the textboxes, number boxes, times, etc.

        'if there is nothing entered in the event end time textbox, let's go ahead and hide those items:
        If Txt_End_Time.Text = "" Then
            TimerWindow.Lbl_time_remaining.Visible = False
            TimerWindow.lbl_time_remaining_colon2.Visible = False
            TimerWindow.Lbl_Time_remaining_colon_1.Visible = False
            TimerWindow.Text_Remaining_Hours.Visible = False
            TimerWindow.Text_Remaining_Minutes.Visible = False
            TimerWindow.Text_Remaining_Seconds.Visible = False
            TimerWindow.ProgressBar_Event.Visible = False
            TimerWindow.Label4.Visible = False

        Else
            TimerWindow.Label4.Visible = True
            TimerWindow.ProgressBar_Event.Visible = True
            TimerWindow.Lbl_time_remaining.Visible = True
            TimerWindow.lbl_time_remaining_colon2.Visible = True
            TimerWindow.Lbl_Time_remaining_colon_1.Visible = True
            TimerWindow.Text_Remaining_Hours.Visible = True
            TimerWindow.Text_Remaining_Minutes.Visible = True
            TimerWindow.Text_Remaining_Seconds.Visible = True
        End If

        TimerWindow.Visible = True

    End Sub


    Private Sub Txt_Minutes_1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_1.ValueChanged
        calc_total_time()
    End Sub
    Private Sub calc_total_time()
        Txt_minutes_total.Text = (Txt_Minutes_1.Value + Txt_Minutes_2.Value + Txt_Minutes_3.Value + Txt_Minutes_4.Value + Txt_Minutes_5.Value + Txt_Minutes_6.Value + Txt_Minutes_7.Value + Txt_Minutes_8.Value + Txt_Minutes_9.Value + Txt_Minutes_10.Value)
    End Sub
    Private Sub Txt_End_Time_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_End_Time.Validating
        'verify that the data entered is a proper time value that is some amount of time past the current time.
        If Not IsDate(Txt_End_Time.Text) Then
            'data entered is not a valid date
            Txt_End_Time.BackColor = Color.Yellow
            MsgBox("Please enter a valid time that is in the future", MsgBoxStyle.Exclamation, "Error")
            Txt_End_Time.Text = ""
            Txt_End_Time.Focus()
        ElseIf Txt_End_Time.Text > Now() Then
            Txt_End_Time.BackColor = Color.Yellow
            MsgBox("Please enter a valid time that is in the future", MsgBoxStyle.Exclamation, "Error")
            Txt_End_Time.Text = ""
            Txt_End_Time.Focus()
        Else
            'all is well, so far
            Txt_End_Time.BackColor = Color.White
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim TimeDiff As Long  'in seconds
        Dim CurrentTime As Date
        Dim r_hours As Long
        Dim r_minutes As Long
        Dim r_seconds As Long

        CurrentTime = Format(Now(), "Medium Time")
        Txt_Current_Time.Text = CurrentTime
        If IsDate(Txt_End_Time.Text) Then
            'calculate time remaining in Hours, minutes, seconds
            timediff = DateDiff(DateInterval.Second, CurrentTime, CDate(Txt_End_Time.Text))
            If timediff >= 0 Then
                Label_remaining.Text = "Time Remaining"
                TimerWindow.Lbl_time_remaining.Text = "Event Time Remaining"
                TimerWindow.Lbl_time_remaining.ForeColor = Color.White
            ElseIf timediff < 0 Then
                Label_remaining.Text = "Time OVER"
                TimerWindow.Lbl_time_remaining.Text = "Event OVERTIME"
                TimerWindow.Lbl_time_remaining.ForeColor = Color.Red
                TimeDiff = Math.Abs(TimeDiff)
            End If
            r_hours = Int(TimeDiff / 3600)
            r_minutes = Int((TimeDiff - r_hours * 3600) / 60)
            r_seconds = Int(TimeDiff - (r_hours * 3600) - (r_minutes * 60))
            Txt_Remaining_Hours.Text = Format(r_hours, "##")
            TimerWindow.Text_Remaining_Hours.Text = Format(r_hours, "##")
            Txt_Remaining_Minutes.Text = Format(r_minutes, "00")
            TimerWindow.Text_Remaining_Minutes.Text = Format(r_minutes, "00")
            Txt_Remaining_Seconds.Text = Format(r_seconds, "00")
            TimerWindow.Text_Remaining_Seconds.Text = Format(r_seconds, "00")
        End If
        'MsgBox("start time=" & TimerWindow.Txt_Event_start_time.Text, MsgBoxStyle.OkOnly, "Debug")
        'set event_progressbar values
        If TimerWindow.Txt_Event_start_time.Text <> "" Then
            If IsDate(CDate(TimerWindow.Txt_Event_start_time.Text)) And Txt_End_Time.Text <> "" Then
                TimerWindow.ProgressBar_Event.Visible = True
                Dim elapsed_seconds As Long
                elapsed_seconds = DateDiff(DateInterval.Second, CDate(TimerWindow.Txt_Event_start_time.Text), Now())
                If elapsed_seconds <= TimerWindow.ProgressBar_Event.Maximum Then
                    TimerWindow.ProgressBar_Event.Value = elapsed_seconds
                End If
            End If
        End If
    End Sub

    Private Sub Txt_Minutes_10_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_10.ValueChanged
        calc_total_time()
    End Sub
    Private Sub Txt_Minutes_2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_2.ValueChanged
        calc_total_time()
    End Sub

    Private Sub Txt_Minutes_3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_3.ValueChanged
        calc_total_time()
    End Sub

    Private Sub Txt_Minutes_4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_4.ValueChanged
        calc_total_time()
    End Sub

    Private Sub Txt_Minutes_5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_5.ValueChanged
        calc_total_time()
    End Sub

    Private Sub Txt_Minutes_6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_6.ValueChanged
        calc_total_time()
    End Sub

    Private Sub Txt_Minutes_7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_7.ValueChanged
        calc_total_time()
    End Sub

    Private Sub Txt_Minutes_8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_8.ValueChanged
        calc_total_time()
    End Sub

    Private Sub Txt_Minutes_9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Minutes_9.ValueChanged
        calc_total_time()
    End Sub
    Private Sub AboutCountdownTimer2008ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutCountdownTimer2008ToolStripMenuItem.Click
        Frm_about.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'open file chooser dialog to select appropriate logo file types
    End Sub

End Class