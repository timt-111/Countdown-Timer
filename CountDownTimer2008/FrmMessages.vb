Public Class Frm_Message

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.Close()

    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblMessages_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LblMessages.KeyPress
        Me.Close()
    End Sub

    Private Sub Frm_Message_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Me.Close()
    End Sub
End Class