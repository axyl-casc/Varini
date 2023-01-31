<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Negotiation
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
        Me.okButton = New System.Windows.Forms.Button()
        Me.errLabel = New System.Windows.Forms.Label()
        Me.neiList = New System.Windows.Forms.ListBox()
        Me.infoGroup = New System.Windows.Forms.GroupBox()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.knowButton = New System.Windows.Forms.Button()
        Me.recruitButton = New System.Windows.Forms.Button()
        Me.actionBox = New System.Windows.Forms.GroupBox()
        Me.goldLabel = New System.Windows.Forms.Label()
        Me.eventList = New System.Windows.Forms.ListBox()
        Me.infoGroup.SuspendLayout()
        Me.actionBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'okButton
        '
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.okButton.Location = New System.Drawing.Point(380, 272)
        Me.okButton.Margin = New System.Windows.Forms.Padding(4)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(100, 28)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "Ok"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'errLabel
        '
        Me.errLabel.AutoSize = True
        Me.errLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errLabel.Location = New System.Drawing.Point(13, 13)
        Me.errLabel.Name = "errLabel"
        Me.errLabel.Size = New System.Drawing.Size(445, 39)
        Me.errLabel.TabIndex = 1
        Me.errLabel.Text = "There are no tribes around..."
        Me.errLabel.Visible = False
        '
        'neiList
        '
        Me.neiList.FormattingEnabled = True
        Me.neiList.ItemHeight = 16
        Me.neiList.Location = New System.Drawing.Point(9, 13)
        Me.neiList.Name = "neiList"
        Me.neiList.Size = New System.Drawing.Size(103, 116)
        Me.neiList.TabIndex = 2
        '
        'infoGroup
        '
        Me.infoGroup.Controls.Add(Me.infoLabel)
        Me.infoGroup.Location = New System.Drawing.Point(153, 12)
        Me.infoGroup.Name = "infoGroup"
        Me.infoGroup.Size = New System.Drawing.Size(328, 116)
        Me.infoGroup.TabIndex = 3
        Me.infoGroup.TabStop = False
        Me.infoGroup.Text = "Info"
        '
        'infoLabel
        '
        Me.infoLabel.Location = New System.Drawing.Point(7, 26)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(315, 91)
        Me.infoLabel.TabIndex = 0
        '
        'knowButton
        '
        Me.knowButton.Location = New System.Drawing.Point(6, 21)
        Me.knowButton.Name = "knowButton"
        Me.knowButton.Size = New System.Drawing.Size(181, 30)
        Me.knowButton.TabIndex = 4
        Me.knowButton.Text = "Gain Knowledge (20G)"
        Me.knowButton.UseVisualStyleBackColor = True
        '
        'recruitButton
        '
        Me.recruitButton.Location = New System.Drawing.Point(6, 57)
        Me.recruitButton.Name = "recruitButton"
        Me.recruitButton.Size = New System.Drawing.Size(181, 27)
        Me.recruitButton.TabIndex = 5
        Me.recruitButton.Text = "Recruit Member (20G)"
        Me.recruitButton.UseVisualStyleBackColor = True
        '
        'actionBox
        '
        Me.actionBox.Controls.Add(Me.goldLabel)
        Me.actionBox.Controls.Add(Me.knowButton)
        Me.actionBox.Controls.Add(Me.recruitButton)
        Me.actionBox.Location = New System.Drawing.Point(9, 136)
        Me.actionBox.Name = "actionBox"
        Me.actionBox.Size = New System.Drawing.Size(193, 158)
        Me.actionBox.TabIndex = 6
        Me.actionBox.TabStop = False
        Me.actionBox.Text = "Actions"
        '
        'goldLabel
        '
        Me.goldLabel.AutoSize = True
        Me.goldLabel.Location = New System.Drawing.Point(6, 136)
        Me.goldLabel.Name = "goldLabel"
        Me.goldLabel.Size = New System.Drawing.Size(46, 17)
        Me.goldLabel.TabIndex = 7
        Me.goldLabel.Text = "Gold: "
        '
        'eventList
        '
        Me.eventList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.eventList.FormattingEnabled = True
        Me.eventList.ItemHeight = 16
        Me.eventList.Location = New System.Drawing.Point(202, 136)
        Me.eventList.Name = "eventList"
        Me.eventList.Size = New System.Drawing.Size(278, 100)
        Me.eventList.TabIndex = 7
        '
        'Negotiation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.okButton
        Me.ClientSize = New System.Drawing.Size(504, 307)
        Me.ControlBox = False
        Me.Controls.Add(Me.eventList)
        Me.Controls.Add(Me.actionBox)
        Me.Controls.Add(Me.infoGroup)
        Me.Controls.Add(Me.neiList)
        Me.Controls.Add(Me.errLabel)
        Me.Controls.Add(Me.okButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Negotiation"
        Me.Text = "Negotiation"
        Me.TopMost = True
        Me.infoGroup.ResumeLayout(False)
        Me.actionBox.ResumeLayout(False)
        Me.actionBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents okButton As Button
    Friend WithEvents errLabel As Label
    Friend WithEvents neiList As ListBox
    Friend WithEvents infoGroup As GroupBox
    Friend WithEvents infoLabel As Label
    Friend WithEvents knowButton As Button
    Friend WithEvents recruitButton As Button
    Friend WithEvents actionBox As GroupBox
    Friend WithEvents goldLabel As Label
    Friend WithEvents eventList As ListBox
End Class
