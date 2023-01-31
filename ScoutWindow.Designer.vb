<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScoutWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.listBoxNorth = New System.Windows.Forms.ListBox()
        Me.listBoxEast = New System.Windows.Forms.ListBox()
        Me.listBoxWest = New System.Windows.Forms.ListBox()
        Me.listBoxSouth = New System.Windows.Forms.ListBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.listBoxLocal = New System.Windows.Forms.ListBox()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBoxNorth
        '
        Me.listBoxNorth.FormattingEnabled = True
        Me.listBoxNorth.ItemHeight = 16
        Me.listBoxNorth.Location = New System.Drawing.Point(336, 15)
        Me.listBoxNorth.Margin = New System.Windows.Forms.Padding(4)
        Me.listBoxNorth.Name = "listBoxNorth"
        Me.listBoxNorth.Size = New System.Drawing.Size(399, 116)
        Me.listBoxNorth.TabIndex = 0
        '
        'listBoxEast
        '
        Me.listBoxEast.FormattingEnabled = True
        Me.listBoxEast.ItemHeight = 16
        Me.listBoxEast.Location = New System.Drawing.Point(744, 139)
        Me.listBoxEast.Margin = New System.Windows.Forms.Padding(4)
        Me.listBoxEast.Name = "listBoxEast"
        Me.listBoxEast.Size = New System.Drawing.Size(305, 116)
        Me.listBoxEast.TabIndex = 1
        '
        'listBoxWest
        '
        Me.listBoxWest.FormattingEnabled = True
        Me.listBoxWest.ItemHeight = 16
        Me.listBoxWest.Location = New System.Drawing.Point(16, 139)
        Me.listBoxWest.Margin = New System.Windows.Forms.Padding(4)
        Me.listBoxWest.Name = "listBoxWest"
        Me.listBoxWest.Size = New System.Drawing.Size(311, 116)
        Me.listBoxWest.TabIndex = 2
        '
        'listBoxSouth
        '
        Me.listBoxSouth.FormattingEnabled = True
        Me.listBoxSouth.ItemHeight = 16
        Me.listBoxSouth.Location = New System.Drawing.Point(336, 263)
        Me.listBoxSouth.Margin = New System.Windows.Forms.Padding(4)
        Me.listBoxSouth.Name = "listBoxSouth"
        Me.listBoxSouth.Size = New System.Drawing.Size(399, 116)
        Me.listBoxSouth.TabIndex = 3
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(951, 389)
        Me.okButton.Margin = New System.Windows.Forms.Padding(4)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(100, 28)
        Me.okButton.TabIndex = 4
        Me.okButton.Text = "Ok"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'listBoxLocal
        '
        Me.listBoxLocal.FormattingEnabled = True
        Me.listBoxLocal.ItemHeight = 16
        Me.listBoxLocal.Location = New System.Drawing.Point(336, 140)
        Me.listBoxLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.listBoxLocal.Name = "listBoxLocal"
        Me.listBoxLocal.Size = New System.Drawing.Size(399, 116)
        Me.listBoxLocal.TabIndex = 5
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(843, 389)
        Me.aboutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(100, 28)
        Me.aboutButton.TabIndex = 6
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'ScoutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.listBoxLocal)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.listBoxSouth)
        Me.Controls.Add(Me.listBoxWest)
        Me.Controls.Add(Me.listBoxEast)
        Me.Controls.Add(Me.listBoxNorth)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScoutWindow"
        Me.Text = "ScoutWindow"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listBoxNorth As ListBox
    Friend WithEvents listBoxEast As ListBox
    Friend WithEvents listBoxWest As ListBox
    Friend WithEvents listBoxSouth As ListBox
    Friend WithEvents okButton As Button
    Friend WithEvents listBoxLocal As ListBox
    Friend WithEvents aboutButton As Button
End Class
