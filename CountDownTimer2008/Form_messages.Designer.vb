<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_messages
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_message_entry = New System.Windows.Forms.TextBox()
        Me.Cmd_Msg_Ok = New System.Windows.Forms.Button()
        Me.Cmd_Msg_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Message to be displayed to presenter:"
        '
        'txt_message_entry
        '
        Me.txt_message_entry.Location = New System.Drawing.Point(3, 17)
        Me.txt_message_entry.Name = "txt_message_entry"
        Me.txt_message_entry.Size = New System.Drawing.Size(442, 20)
        Me.txt_message_entry.TabIndex = 1
        '
        'Cmd_Msg_Ok
        '
        Me.Cmd_Msg_Ok.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Cmd_Msg_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Msg_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Msg_Ok.ForeColor = System.Drawing.Color.Snow
        Me.Cmd_Msg_Ok.Location = New System.Drawing.Point(451, 13)
        Me.Cmd_Msg_Ok.Name = "Cmd_Msg_Ok"
        Me.Cmd_Msg_Ok.Size = New System.Drawing.Size(29, 21)
        Me.Cmd_Msg_Ok.TabIndex = 2
        Me.Cmd_Msg_Ok.Text = "ok"
        Me.Cmd_Msg_Ok.UseVisualStyleBackColor = False
        '
        'Cmd_Msg_Cancel
        '
        Me.Cmd_Msg_Cancel.BackColor = System.Drawing.SystemColors.MenuText
        Me.Cmd_Msg_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Msg_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Cmd_Msg_Cancel.ForeColor = System.Drawing.SystemColors.Control
        Me.Cmd_Msg_Cancel.Location = New System.Drawing.Point(484, 13)
        Me.Cmd_Msg_Cancel.Name = "Cmd_Msg_Cancel"
        Me.Cmd_Msg_Cancel.Size = New System.Drawing.Size(54, 21)
        Me.Cmd_Msg_Cancel.TabIndex = 3
        Me.Cmd_Msg_Cancel.Text = "cancel"
        Me.Cmd_Msg_Cancel.UseVisualStyleBackColor = False
        '
        'Form_messages
        '
        Me.AcceptButton = Me.Cmd_Msg_Ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InfoText
        Me.ClientSize = New System.Drawing.Size(534, 33)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cmd_Msg_Cancel)
        Me.Controls.Add(Me.Cmd_Msg_Ok)
        Me.Controls.Add(Me.txt_message_entry)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(10, 700)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_messages"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_message_entry As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Msg_Ok As System.Windows.Forms.Button
    Friend WithEvents Cmd_Msg_Cancel As System.Windows.Forms.Button
End Class
