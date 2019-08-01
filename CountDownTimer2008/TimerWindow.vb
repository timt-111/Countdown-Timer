
Public Class TimerWindow
    Public presenter_message As String
    Public section_minutes As Long
    Public section_start_time As Date
    Public event_start_time As Date
    Public event_minutes As Long
    Public timer_paused As Boolean



    Private Sub TimerWindow_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim key As Char
        Dim tmp1 As Integer

        key = e.KeyChar
        If key = "f" Then
            Me.Visible = False
            DataEntry.Visible = True
        End If

        If key = "p" Then 'PAUSE / resume THE section TIMER'
            If timer_paused = True Then
                timer_paused = False
                Lbl_Paused.Visible = False
                update_section_bar()
            Else
                timer_paused = True
                Lbl_Paused.Visible = True
            End If
        End If

        If key = "1" Then
            If Lbl_Start.Visible = False Then
                If Me.Txt_Event_start_time.Text = "" Then
                    Me.Txt_Event_start_time.Text = Now()
                    'add other event bar setup items here
                End If
                'get value for textbox from other form, reset timer
                'validate value in textbox
                If DataEntry.Txt_Minutes_1.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_1.Value, DataEntry.Txt_Label_1.Text)
                End If
            End If
        End If
        If key = "2" Then
            If Lbl_Start.Visible = False Then
                If DataEntry.Txt_Minutes_2.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_2.Value, DataEntry.Txt_Label_2.Text)
                End If
            End If

        End If
        If key = "3" Then
            If Lbl_Start.Visible = False Then
                If DataEntry.Txt_Minutes_3.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_3.Value, DataEntry.Txt_Label_3.Text)
                End If
            End If
        End If

        If key = "4" Then
            If Lbl_Start.Visible = False Then
                If DataEntry.Txt_Minutes_4.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_4.Value, DataEntry.Txt_Label_4.Text)
                End If
            End If

        End If
        If key = "5" Then
            If Lbl_Start.Visible = False Then

                If DataEntry.Txt_Minutes_5.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_5.Value, DataEntry.Txt_Label_5.Text)
                End If
            End If
        End If

        If key = "6" Then
            If Lbl_Start.Visible = False Then

                If DataEntry.Txt_Minutes_6.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_6.Value, DataEntry.Txt_Label_6.Text)
                End If
            End If
        End If
        If key = "7" Then
            If Lbl_Start.Visible = False Then
                If DataEntry.Txt_Minutes_7.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_7.Value, DataEntry.Txt_Label_7.Text)
                End If
            End If
        End If

        If key = "8" Then
            If Lbl_Start.Visible = False Then
                If DataEntry.Txt_Minutes_8.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_8.Value, DataEntry.Txt_Label_8.Text)
                End If
            End If
        End If

        If key = "9" Then
            If Lbl_Start.Visible = False Then
                If DataEntry.Txt_Minutes_9.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_9.Value, DataEntry.Txt_Label_9.Text)
                End If
            End If
        End If

        If key = "0" Then
            If Lbl_Start.Visible = False Then
                If DataEntry.Txt_Minutes_10.Value > 0 Then
                    start_preset(DataEntry.Txt_Minutes_10.Value, DataEntry.Txt_Label_10.Text)
                End If
            End If
        End If

        If key = "-" Or key = "_" Then
            'subtract 1 minute to txt_target_time.txt
            Txt_Target_Time.Text = DateAdd(DateInterval.Minute, -1, CDate(Txt_Target_Time.Text))
            update_section_bar()
        End If

        If key = "+" Or key = "=" Then
            Txt_Target_Time.Text = DateAdd(DateInterval.Minute, 1, CDate(Txt_Target_Time.Text))
            update_section_bar()
        End If

        If key = "s" Then
            Lbl_Start.Visible = False
            Text_Timer_Hours.Visible = True
            Text_Timer_Minutes.Visible = True
            Text_Timer_Seconds.Visible = True
            'start event timer, setup event progressbar, start countdown
            DataEntry.Timer1.Enabled = True
            event_start_time = Now()
            Me.Txt_Event_start_time.Text = event_start_time
            If DataEntry.Txt_End_Time.Text <> "" Then
                tmp1 = DateDiff(DateInterval.Second, TimeValue(Now()), TimeValue(DataEntry.Txt_End_Time.Text))
                If tmp1 > 0 Then
                    ProgressBar_Event.Maximum = DateDiff(DateInterval.Second, TimeValue(Now()), TimeValue(DataEntry.Txt_End_Time.Text))
                    ProgressBar_Event.Visible = True
                End If

            End If
            'load first preset
            If DataEntry.Txt_Minutes_1.Value > 0 Then
                start_preset(DataEntry.Txt_Minutes_1.Value, DataEntry.Txt_Label_1.Text)
            End If
        End If


        If key = "m" Then
            Form_messages.Show()
            Form_messages.Visible = True
            Form_messages.Update()
        End If

    End Sub

    Private Sub TimerWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar_Section.BackColor = Color.Black
        ProgressBar_Event.BackColor = Color.Black
        ProgressBar_Section.Style = ProgressBarStyle.Continuous
        ProgressBar_Event.Style = ProgressBarStyle.Continuous

    End Sub



    Private Sub Section_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Section_Timer.Tick
        Dim TimeDiff As Long ' in seconds
        Dim DTarget As Date
        Dim r_hours As Integer
        Dim r_minutes As Integer
        Dim r_seconds As Integer
        Dim Itmp As Integer

        If Txt_Target_Time.Text <> "" Then
            If timer_paused Then
                Txt_Target_Time.Text = DateAdd(DateInterval.Second, 1, CDate(Txt_Target_Time.Text))
                update_section_bar()
            End If
            DTarget = CDate(Txt_Target_Time.Text)
        End If

        'main timer countdown section
        'Txt_Target_Time.Text
        'calculate time difference between now and target time
        TimeDiff = DateDiff(DateInterval.Second, Now(), DTarget)

        'update section timer progress bar
        Itmp = DateDiff(DateInterval.Second, section_start_time, Now())
        If Itmp <= ProgressBar_Section.Maximum Then
            ProgressBar_Section.Value = Itmp
        End If

        'Calculate time remaining for section counter
        If TimeDiff >= 0 Then
            Label_Overtime.Visible = False
        Else
            Label_Overtime.Visible = True
            TimeDiff = Math.Abs(TimeDiff)
        End If
        r_hours = Int(TimeDiff / 3600)
        r_minutes = Int((TimeDiff - (r_hours * 3600)) / 60)
        r_seconds = Int((TimeDiff - (r_hours * 3600) - (r_minutes * 60)))

        'set color of timer appropriately
        If TimeDiff >= (Val(DataEntry.Txt_Yellow.Text) * 60) And Label_Overtime.Visible = False Then
            Text_Timer_Hours.ForeColor = Color.Lime
            Text_Timer_Minutes.ForeColor = Color.Lime
            Text_Timer_Seconds.ForeColor = Color.Lime
            ProgressBar_Section.ForeColor = Color.Lime
        ElseIf (TimeDiff < (Val(DataEntry.Txt_Yellow.Text) * 60)) And TimeDiff > (Val(DataEntry.Txt_Red.Text) * 60) And Label_Overtime.Visible = False Then
            Text_Timer_Hours.ForeColor = Color.Yellow
            Text_Timer_Minutes.ForeColor = Color.Yellow
            Text_Timer_Seconds.ForeColor = Color.Yellow
            ProgressBar_Section.ForeColor = Color.Yellow
        Else
            Text_Timer_Hours.ForeColor = Color.Red
            Text_Timer_Minutes.ForeColor = Color.Red
            Text_Timer_Seconds.ForeColor = Color.Red
            ProgressBar_Section.ForeColor = Color.Red
        End If

        'Update time remaining boxes

        If Text_Timer_Hours.Text <> Format(r_hours, "##") Then
            Text_Timer_Hours.Text = Format(r_hours, "##")
            If r_hours = 0 Then
                LblColon1.Visible = False
                'maybe shift the whole shebang over to the left at this point??
            Else
                LblColon1.Visible = True
            End If
            Text_Timer_Hours.Update()
        End If
        If r_hours = 0 Then 'if no hours, then we can use ## for format of the minutes
            'we can also move the minutes and seconds to center on screen
            If Text_Timer_Seconds.Location.X <> 558 Then
                Dim NewPoint As New System.Drawing.Point(351, 413)
                Text_Timer_Minutes.Location = NewPoint
                NewPoint = New System.Drawing.Point(612, 403)
                LblColon2.Location = NewPoint
                NewPoint = New System.Drawing.Point(712, 413)
                Text_Timer_Seconds.Location = NewPoint
            End If
            If Text_Timer_Minutes.Text <> Format(r_minutes, "#0") Then
                Text_Timer_Minutes.Text = Format(r_minutes, "#0")
                Text_Timer_Minutes.Update()
            End If
        Else 'move timer elements back to standard position to show hours, minutes, seconds
            If Text_Timer_Seconds.Location.X <> 688 Then
                Dim NewPoint As New System.Drawing.Point(523, 413)
                Text_Timer_Minutes.Location = NewPoint
                NewPoint = New System.Drawing.Point(784, 403)
                LblColon2.Location = NewPoint
                NewPoint = New System.Drawing.Point(884, 413)
                Text_Timer_Seconds.Location = NewPoint
            End If
            If Text_Timer_Minutes.Text <> Format(r_minutes, "00") Then
                Text_Timer_Minutes.Text = Format(r_minutes, "00")
                Text_Timer_Minutes.Update()
            End If
        End If

        Text_Timer_Seconds.Text = Format(r_seconds, "00")
        Text_Timer_Seconds.Update()



    End Sub

    Private Sub timer_bar_update_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_bar_update.Tick
        ProgressBar_Section.Update()
        ProgressBar_Event.Update()
    End Sub

    Private Sub start_preset(ByVal s_minutes As Long, ByVal s_label As String)
        If s_minutes > 0 Then
            Section_Timer.Enabled = True
            Text_Label_Text.Text = s_label
            Label_Overtime.Visible = False
            Txt_Target_Time.Text = DateAdd(DateInterval.Minute, s_minutes, Now())
            section_start_time = Now()
            section_minutes = s_minutes
            update_section_bar()
        End If
    End Sub
    Private Sub update_section_bar()
        Dim tmp_diff As Long
        Dim tmp_currentmax As Long
        Dim tmp_currentval As Long
        Dim tmp_newval As Long

        tmp_currentmax = ProgressBar_Section.Maximum
        tmp_currentval = ProgressBar_Section.Value
        tmp_diff = DateDiff(DateInterval.Second, section_start_time, CDate(Txt_Target_Time.Text))
        'set new max if diff is positive, if negative, leave alone
        If tmp_diff > 0 Then
            If tmp_currentval <= tmp_diff Then
                ProgressBar_Section.Maximum = tmp_diff
            End If
        End If
        tmp_newval = DateDiff(DateInterval.Second, section_start_time, Now())
        If tmp_newval <= ProgressBar_Section.Maximum Then
            ProgressBar_Section.Value = tmp_newval
        End If
    End Sub

End Class