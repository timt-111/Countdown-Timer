Public Class Form_messages

    Private Sub Form_messages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_message_entry.Text = TimerWindow.presenter_message
        Me.txt_message_entry.SelectAll()
    End Sub

    Private Sub Cmd_Msg_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Msg_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Msg_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Msg_Ok.Click
        'Frm_Message.TxtMessages.Text = Me.txt_message_entry.Text
        Frm_Message.LblMessages.Text = Me.txt_message_entry.Text
        TimerWindow.presenter_message = Me.txt_message_entry.Text
        Frm_Message.Show()
        Me.Close()
    End Sub
End Class