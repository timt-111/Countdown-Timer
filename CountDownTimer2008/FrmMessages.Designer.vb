<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Message
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
        Me.LblMessages = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblMessages
        '
        Me.LblMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.LblMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 63.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessages.ForeColor = System.Drawing.Color.Yellow
        Me.LblMessages.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblMessages.Location = New System.Drawing.Point(0, 0)
        Me.LblMessages.Name = "LblMessages"
        Me.LblMessages.Size = New System.Drawing.Size(1366, 424)
        Me.LblMessages.TabIndex = 4
        Me.LblMessages.Text = "LblMessages"
        Me.LblMessages.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frm_Message
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1366, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblMessages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Message"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Message"
        Me.TransparencyKey = System.Drawing.SystemColors.WindowText
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblMessages As Label
End Class
