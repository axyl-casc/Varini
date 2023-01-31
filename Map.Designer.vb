<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Map
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
        Me.components = New System.ComponentModel.Container()
        Me.mapList = New System.Windows.Forms.ListBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mapList
        '
        Me.mapList.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mapList.FormattingEnabled = True
        Me.mapList.ItemHeight = 20
        Me.mapList.Location = New System.Drawing.Point(17, 16)
        Me.mapList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mapList.Name = "mapList"
        Me.mapList.Size = New System.Drawing.Size(775, 464)
        Me.mapList.TabIndex = 0
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(692, 521)
        Me.okButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(100, 28)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "Ok"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'updateTimer
        '
        Me.updateTimer.Interval = 50
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(584, 521)
        Me.aboutButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(100, 28)
        Me.aboutButton.TabIndex = 2
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Symbol: V"
        '
        'Map
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(817, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.mapList)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Map"
        Me.Text = "Map"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mapList As ListBox
    Friend WithEvents okButton As Button
    Friend WithEvents updateTimer As Timer
    Friend WithEvents aboutButton As Button
    Friend WithEvents Label1 As Label
End Class
