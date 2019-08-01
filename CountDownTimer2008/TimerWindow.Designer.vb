<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimerWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar_Event = New System.Windows.Forms.ProgressBar()
        Me.Label_Overtime = New System.Windows.Forms.Label()
        Me.LblColon1 = New System.Windows.Forms.Label()
        Me.LblColon2 = New System.Windows.Forms.Label()
        Me.Lbl_time_remaining = New System.Windows.Forms.Label()
        Me.Lbl_Time_remaining_colon_1 = New System.Windows.Forms.Label()
        Me.lbl_time_remaining_colon2 = New System.Windows.Forms.Label()
        Me.Section_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Txt_Target_Time = New System.Windows.Forms.TextBox()
        Me.ProgressBar_Section = New System.Windows.Forms.ProgressBar()
        Me.Txt_section_start_time = New System.Windows.Forms.TextBox()
        Me.Txt_Event_start_time = New System.Windows.Forms.TextBox()
        Me.timer_bar_update = New System.Windows.Forms.Timer(Me.components)
        Me.Text_Label_Text = New System.Windows.Forms.Label()
        Me.Text_Timer_Hours = New System.Windows.Forms.Label()
        Me.Text_Timer_Minutes = New System.Windows.Forms.Label()
        Me.Text_Timer_Seconds = New System.Windows.Forms.Label()
        Me.Text_Remaining_Hours = New System.Windows.Forms.Label()
        Me.Text_Remaining_Minutes = New System.Windows.Forms.Label()
        Me.Text_Remaining_Seconds = New System.Windows.Forms.Label()
        Me.Lbl_Paused = New System.Windows.Forms.Label()
        Me.Lbl_Start = New System.Windows.Forms.Label()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar_Event
        '
        Me.ProgressBar_Event.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar_Event.Location = New System.Drawing.Point(12, 688)
        Me.ProgressBar_Event.Name = "ProgressBar_Event"
        Me.ProgressBar_Event.Size = New System.Drawing.Size(1342, 23)
        Me.ProgressBar_Event.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_Event.TabIndex = 0
        Me.ProgressBar_Event.Visible = False
        '
        'Label_Overtime
        '
        Me.Label_Overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 125.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Overtime.ForeColor = System.Drawing.Color.Red
        Me.Label_Overtime.Location = New System.Drawing.Point(178, 262)
        Me.Label_Overtime.Name = "Label_Overtime"
        Me.Label_Overtime.Size = New System.Drawing.Size(1010, 159)
        Me.Label_Overtime.TabIndex = 1
        Me.Label_Overtime.Text = "OVERTIME"
        Me.Label_Overtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Overtime.Visible = False
        '
        'LblColon1
        '
        Me.LblColon1.AutoSize = True
        Me.LblColon1.BackColor = System.Drawing.Color.Transparent
        Me.LblColon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColon1.Location = New System.Drawing.Point(427, 403)
        Me.LblColon1.Name = "LblColon1"
        Me.LblColon1.Size = New System.Drawing.Size(151, 226)
        Me.LblColon1.TabIndex = 6
        Me.LblColon1.Text = ":"
        '
        'LblColon2
        '
        Me.LblColon2.AutoSize = True
        Me.LblColon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColon2.Location = New System.Drawing.Point(784, 403)
        Me.LblColon2.Name = "LblColon2"
        Me.LblColon2.Size = New System.Drawing.Size(151, 226)
        Me.LblColon2.TabIndex = 7
        Me.LblColon2.Text = ":"
        '
        'Lbl_time_remaining
        '
        Me.Lbl_time_remaining.AutoSize = True
        Me.Lbl_time_remaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_time_remaining.Location = New System.Drawing.Point(425, 722)
        Me.Lbl_time_remaining.Name = "Lbl_time_remaining"
        Me.Lbl_time_remaining.Size = New System.Drawing.Size(338, 37)
        Me.Lbl_time_remaining.TabIndex = 8
        Me.Lbl_time_remaining.Text = "Event Time Remaining"
        Me.Lbl_time_remaining.Visible = False
        '
        'Lbl_Time_remaining_colon_1
        '
        Me.Lbl_Time_remaining_colon_1.AutoSize = True
        Me.Lbl_Time_remaining_colon_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Time_remaining_colon_1.Location = New System.Drawing.Point(812, 719)
        Me.Lbl_Time_remaining_colon_1.Name = "Lbl_Time_remaining_colon_1"
        Me.Lbl_Time_remaining_colon_1.Size = New System.Drawing.Size(26, 37)
        Me.Lbl_Time_remaining_colon_1.TabIndex = 12
        Me.Lbl_Time_remaining_colon_1.Text = ":"
        Me.Lbl_Time_remaining_colon_1.Visible = False
        '
        'lbl_time_remaining_colon2
        '
        Me.lbl_time_remaining_colon2.AutoSize = True
        Me.lbl_time_remaining_colon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time_remaining_colon2.Location = New System.Drawing.Point(869, 720)
        Me.lbl_time_remaining_colon2.Name = "lbl_time_remaining_colon2"
        Me.lbl_time_remaining_colon2.Size = New System.Drawing.Size(26, 37)
        Me.lbl_time_remaining_colon2.TabIndex = 13
        Me.lbl_time_remaining_colon2.Text = ":"
        Me.lbl_time_remaining_colon2.Visible = False
        '
        'Section_Timer
        '
        Me.Section_Timer.Interval = 1000
        '
        'Txt_Target_Time
        '
        Me.Txt_Target_Time.Location = New System.Drawing.Point(1344, 736)
        Me.Txt_Target_Time.Name = "Txt_Target_Time"
        Me.Txt_Target_Time.Size = New System.Drawing.Size(10, 20)
        Me.Txt_Target_Time.TabIndex = 14
        Me.Txt_Target_Time.Visible = False
        '
        'ProgressBar_Section
        '
        Me.ProgressBar_Section.BackColor = System.Drawing.Color.Black
        Me.ProgressBar_Section.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar_Section.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar_Section.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressBar_Section.Name = "ProgressBar_Section"
        Me.ProgressBar_Section.Size = New System.Drawing.Size(1342, 23)
        Me.ProgressBar_Section.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_Section.TabIndex = 15
        '
        'Txt_section_start_time
        '
        Me.Txt_section_start_time.Location = New System.Drawing.Point(1312, 736)
        Me.Txt_section_start_time.Name = "Txt_section_start_time"
        Me.Txt_section_start_time.Size = New System.Drawing.Size(10, 20)
        Me.Txt_section_start_time.TabIndex = 16
        Me.Txt_section_start_time.Visible = False
        '
        'Txt_Event_start_time
        '
        Me.Txt_Event_start_time.Location = New System.Drawing.Point(1328, 736)
        Me.Txt_Event_start_time.Name = "Txt_Event_start_time"
        Me.Txt_Event_start_time.Size = New System.Drawing.Size(10, 20)
        Me.Txt_Event_start_time.TabIndex = 17
        Me.Txt_Event_start_time.Visible = False
        '
        'timer_bar_update
        '
        Me.timer_bar_update.Enabled = True
        Me.timer_bar_update.Interval = 5000
        '
        'Text_Label_Text
        '
        Me.Text_Label_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Label_Text.Location = New System.Drawing.Point(12, 38)
        Me.Text_Label_Text.Name = "Text_Label_Text"
        Me.Text_Label_Text.Size = New System.Drawing.Size(1342, 252)
        Me.Text_Label_Text.TabIndex = 18
        Me.Text_Label_Text.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Text_Timer_Hours
        '
        Me.Text_Timer_Hours.BackColor = System.Drawing.Color.Transparent
        Me.Text_Timer_Hours.CausesValidation = False
        Me.Text_Timer_Hours.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Timer_Hours.ForeColor = System.Drawing.Color.Lime
        Me.Text_Timer_Hours.Location = New System.Drawing.Point(159, 413)
        Me.Text_Timer_Hours.Margin = New System.Windows.Forms.Padding(0)
        Me.Text_Timer_Hours.Name = "Text_Timer_Hours"
        Me.Text_Timer_Hours.Size = New System.Drawing.Size(323, 247)
        Me.Text_Timer_Hours.TabIndex = 19
        Me.Text_Timer_Hours.Text = "00"
        Me.Text_Timer_Hours.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Text_Timer_Hours.Visible = False
        '
        'Text_Timer_Minutes
        '
        Me.Text_Timer_Minutes.BackColor = System.Drawing.Color.Transparent
        Me.Text_Timer_Minutes.CausesValidation = False
        Me.Text_Timer_Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Timer_Minutes.ForeColor = System.Drawing.Color.Lime
        Me.Text_Timer_Minutes.Location = New System.Drawing.Point(523, 413)
        Me.Text_Timer_Minutes.Margin = New System.Windows.Forms.Padding(0)
        Me.Text_Timer_Minutes.Name = "Text_Timer_Minutes"
        Me.Text_Timer_Minutes.Size = New System.Drawing.Size(321, 247)
        Me.Text_Timer_Minutes.TabIndex = 20
        Me.Text_Timer_Minutes.Text = "00"
        Me.Text_Timer_Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Text_Timer_Minutes.Visible = False
        '
        'Text_Timer_Seconds
        '
        Me.Text_Timer_Seconds.BackColor = System.Drawing.Color.Transparent
        Me.Text_Timer_Seconds.CausesValidation = False
        Me.Text_Timer_Seconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Timer_Seconds.ForeColor = System.Drawing.Color.Lime
        Me.Text_Timer_Seconds.Location = New System.Drawing.Point(884, 413)
        Me.Text_Timer_Seconds.Margin = New System.Windows.Forms.Padding(0)
        Me.Text_Timer_Seconds.Name = "Text_Timer_Seconds"
        Me.Text_Timer_Seconds.Size = New System.Drawing.Size(321, 247)
        Me.Text_Timer_Seconds.TabIndex = 21
        Me.Text_Timer_Seconds.Text = "00"
        Me.Text_Timer_Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Text_Timer_Seconds.Visible = False
        '
        'Text_Remaining_Hours
        '
        Me.Text_Remaining_Hours.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Remaining_Hours.ForeColor = System.Drawing.Color.Lime
        Me.Text_Remaining_Hours.Location = New System.Drawing.Point(769, 722)
        Me.Text_Remaining_Hours.Name = "Text_Remaining_Hours"
        Me.Text_Remaining_Hours.Size = New System.Drawing.Size(53, 37)
        Me.Text_Remaining_Hours.TabIndex = 22
        Me.Text_Remaining_Hours.Text = "12"
        Me.Text_Remaining_Hours.Visible = False
        '
        'Text_Remaining_Minutes
        '
        Me.Text_Remaining_Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Remaining_Minutes.ForeColor = System.Drawing.Color.Lime
        Me.Text_Remaining_Minutes.Location = New System.Drawing.Point(825, 722)
        Me.Text_Remaining_Minutes.Name = "Text_Remaining_Minutes"
        Me.Text_Remaining_Minutes.Size = New System.Drawing.Size(53, 37)
        Me.Text_Remaining_Minutes.TabIndex = 23
        Me.Text_Remaining_Minutes.Text = "12"
        Me.Text_Remaining_Minutes.Visible = False
        '
        'Text_Remaining_Seconds
        '
        Me.Text_Remaining_Seconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Remaining_Seconds.ForeColor = System.Drawing.Color.Lime
        Me.Text_Remaining_Seconds.Location = New System.Drawing.Point(882, 722)
        Me.Text_Remaining_Seconds.Name = "Text_Remaining_Seconds"
        Me.Text_Remaining_Seconds.Size = New System.Drawing.Size(53, 37)
        Me.Text_Remaining_Seconds.TabIndex = 24
        Me.Text_Remaining_Seconds.Text = "12"
        Me.Text_Remaining_Seconds.Visible = False
        '
        'Lbl_Paused
        '
        Me.Lbl_Paused.AutoSize = True
        Me.Lbl_Paused.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Paused.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Paused.Location = New System.Drawing.Point(535, 495)
        Me.Lbl_Paused.Name = "Lbl_Paused"
        Me.Lbl_Paused.Size = New System.Drawing.Size(296, 73)
        Me.Lbl_Paused.TabIndex = 25
        Me.Lbl_Paused.Text = "PAUSED"
        Me.Lbl_Paused.Visible = False
        '
        'Lbl_Start
        '
        Me.Lbl_Start.AutoSize = True
        Me.Lbl_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Start.Location = New System.Drawing.Point(306, 123)
        Me.Lbl_Start.Name = "Lbl_Start"
        Me.Lbl_Start.Size = New System.Drawing.Size(783, 51)
        Me.Lbl_Start.TabIndex = 26
        Me.Lbl_Start.Text = "Press the 'S' Key to start the first preset."
        '
        'LogoBox
        '
        Me.LogoBox.Location = New System.Drawing.Point(197, 294)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(621, 127)
        Me.LogoBox.TabIndex = 27
        Me.LogoBox.TabStop = False
        Me.LogoBox.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 9)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Section Progress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 676)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 9)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Overall Progress"
        '
        'TimerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Paused)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_Start)
        Me.Controls.Add(Me.Text_Remaining_Seconds)
        Me.Controls.Add(Me.Text_Remaining_Minutes)
        Me.Controls.Add(Me.Text_Remaining_Hours)
        Me.Controls.Add(Me.Text_Timer_Seconds)
        Me.Controls.Add(Me.Label_Overtime)
        Me.Controls.Add(Me.Text_Timer_Minutes)
        Me.Controls.Add(Me.Txt_Event_start_time)
        Me.Controls.Add(Me.Txt_section_start_time)
        Me.Controls.Add(Me.ProgressBar_Section)
        Me.Controls.Add(Me.Txt_Target_Time)
        Me.Controls.Add(Me.Lbl_time_remaining)
        Me.Controls.Add(Me.ProgressBar_Event)
        Me.Controls.Add(Me.lbl_time_remaining_colon2)
        Me.Controls.Add(Me.Lbl_Time_remaining_colon_1)
        Me.Controls.Add(Me.Text_Label_Text)
        Me.Controls.Add(Me.Text_Timer_Hours)
        Me.Controls.Add(Me.LogoBox)
        Me.Controls.Add(Me.LblColon1)
        Me.Controls.Add(Me.LblColon2)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "TimerWindow"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TimerWindow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ProgressBar_Event As System.Windows.Forms.ProgressBar
    Public WithEvents Label_Overtime As System.Windows.Forms.Label
    Public WithEvents LblColon1 As System.Windows.Forms.Label
    Public WithEvents LblColon2 As System.Windows.Forms.Label
    Public WithEvents Lbl_time_remaining As System.Windows.Forms.Label
    Public WithEvents Lbl_Time_remaining_colon_1 As System.Windows.Forms.Label
    Public WithEvents lbl_time_remaining_colon2 As System.Windows.Forms.Label
    Friend WithEvents Section_Timer As System.Windows.Forms.Timer
    Friend WithEvents Txt_Target_Time As System.Windows.Forms.TextBox
    Public WithEvents ProgressBar_Section As System.Windows.Forms.ProgressBar
    Friend WithEvents Txt_section_start_time As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Event_start_time As System.Windows.Forms.TextBox
    Friend WithEvents timer_bar_update As System.Windows.Forms.Timer
    Friend WithEvents Text_Label_Text As System.Windows.Forms.Label
    Friend WithEvents Text_Timer_Hours As System.Windows.Forms.Label
    Friend WithEvents Text_Timer_Minutes As System.Windows.Forms.Label
    Friend WithEvents Text_Timer_Seconds As System.Windows.Forms.Label
    Friend WithEvents Text_Remaining_Hours As System.Windows.Forms.Label
    Friend WithEvents Text_Remaining_Minutes As System.Windows.Forms.Label
    Friend WithEvents Text_Remaining_Seconds As System.Windows.Forms.Label
    Friend WithEvents Lbl_Paused As System.Windows.Forms.Label
    Friend WithEvents Lbl_Start As System.Windows.Forms.Label
    Friend WithEvents LogoBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
