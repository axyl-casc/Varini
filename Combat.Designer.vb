<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combat
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
        Me.components = New System.ComponentModel.Container()
        Me.battleButtonLocal = New System.Windows.Forms.Button()
        Me.settlementButton = New System.Windows.Forms.Button()
        Me.warButton = New System.Windows.Forms.Button()
        Me.battleBar = New System.Windows.Forms.ProgressBar()
        Me.actionGroupBox = New System.Windows.Forms.GroupBox()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.doneButton = New System.Windows.Forms.Button()
        Me.eventList = New System.Windows.Forms.ListBox()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.selectionList = New System.Windows.Forms.ListBox()
        Me.hideDoneTimer = New System.Windows.Forms.Timer(Me.components)
        Me.actionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'battleButtonLocal
        '
        Me.battleButtonLocal.Location = New System.Drawing.Point(8, 26)
        Me.battleButtonLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.battleButtonLocal.Name = "battleButtonLocal"
        Me.battleButtonLocal.Size = New System.Drawing.Size(176, 28)
        Me.battleButtonLocal.TabIndex = 0
        Me.battleButtonLocal.Text = "Local Tribe Brawl"
        Me.battleButtonLocal.UseVisualStyleBackColor = True
        '
        'settlementButton
        '
        Me.settlementButton.Location = New System.Drawing.Point(8, 63)
        Me.settlementButton.Margin = New System.Windows.Forms.Padding(4)
        Me.settlementButton.Name = "settlementButton"
        Me.settlementButton.Size = New System.Drawing.Size(176, 28)
        Me.settlementButton.TabIndex = 1
        Me.settlementButton.Text = "Raid Villiage"
        Me.settlementButton.UseVisualStyleBackColor = True
        '
        'warButton
        '
        Me.warButton.Location = New System.Drawing.Point(8, 100)
        Me.warButton.Margin = New System.Windows.Forms.Padding(4)
        Me.warButton.Name = "warButton"
        Me.warButton.Size = New System.Drawing.Size(176, 28)
        Me.warButton.TabIndex = 2
        Me.warButton.Text = "Declare National War"
        Me.warButton.UseVisualStyleBackColor = True
        '
        'battleBar
        '
        Me.battleBar.Location = New System.Drawing.Point(17, 400)
        Me.battleBar.Margin = New System.Windows.Forms.Padding(4)
        Me.battleBar.Name = "battleBar"
        Me.battleBar.Size = New System.Drawing.Size(767, 36)
        Me.battleBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.battleBar.TabIndex = 3
        '
        'actionGroupBox
        '
        Me.actionGroupBox.Controls.Add(Me.settlementButton)
        Me.actionGroupBox.Controls.Add(Me.battleButtonLocal)
        Me.actionGroupBox.Controls.Add(Me.warButton)
        Me.actionGroupBox.Location = New System.Drawing.Point(16, 15)
        Me.actionGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.actionGroupBox.Name = "actionGroupBox"
        Me.actionGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.actionGroupBox.Size = New System.Drawing.Size(195, 142)
        Me.actionGroupBox.TabIndex = 4
        Me.actionGroupBox.TabStop = False
        Me.actionGroupBox.Text = "Actions"
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(24, 364)
        Me.aboutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(100, 28)
        Me.aboutButton.TabIndex = 5
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'doneButton
        '
        Me.doneButton.Location = New System.Drawing.Point(684, 364)
        Me.doneButton.Margin = New System.Windows.Forms.Padding(4)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(100, 28)
        Me.doneButton.TabIndex = 6
        Me.doneButton.Text = "Done"
        Me.doneButton.UseVisualStyleBackColor = True
        '
        'eventList
        '
        Me.eventList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.eventList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventList.FormattingEnabled = True
        Me.eventList.ItemHeight = 20
        Me.eventList.Location = New System.Drawing.Point(218, 15)
        Me.eventList.Name = "eventList"
        Me.eventList.Size = New System.Drawing.Size(566, 304)
        Me.eventList.TabIndex = 8
        '
        'confirmButton
        '
        Me.confirmButton.Location = New System.Drawing.Point(24, 164)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(75, 30)
        Me.confirmButton.TabIndex = 9
        Me.confirmButton.Text = "Confirm"
        Me.confirmButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(125, 164)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 30)
        Me.cancelButton.TabIndex = 10
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'selectionList
        '
        Me.selectionList.FormattingEnabled = True
        Me.selectionList.ItemHeight = 16
        Me.selectionList.Location = New System.Drawing.Point(24, 201)
        Me.selectionList.Name = "selectionList"
        Me.selectionList.Size = New System.Drawing.Size(176, 116)
        Me.selectionList.TabIndex = 11
        '
        'hideDoneTimer
        '
        Me.hideDoneTimer.Interval = 10
        '
        'Combat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.selectionList)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.eventList)
        Me.Controls.Add(Me.doneButton)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.actionGroupBox)
        Me.Controls.Add(Me.battleBar)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Combat"
        Me.Text = "Combat"
        Me.actionGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents battleButtonLocal As Button
    Friend WithEvents settlementButton As Button
    Friend WithEvents warButton As Button
    Friend WithEvents battleBar As ProgressBar
    Friend WithEvents actionGroupBox As GroupBox
    Friend WithEvents aboutButton As Button
    Friend WithEvents doneButton As Button
    Friend WithEvents eventList As ListBox
    Friend WithEvents confirmButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents selectionList As ListBox
    Friend WithEvents hideDoneTimer As Timer
End Class
