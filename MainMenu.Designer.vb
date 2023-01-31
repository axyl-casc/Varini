<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.playButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(227, 477)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 28)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(124, 477)
        Me.aboutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(100, 28)
        Me.aboutButton.TabIndex = 1
        Me.aboutButton.Text = "&About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'playButton
        '
        Me.playButton.Location = New System.Drawing.Point(16, 477)
        Me.playButton.Margin = New System.Windows.Forms.Padding(4)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(100, 28)
        Me.playButton.TabIndex = 0
        Me.playButton.Text = "&Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TheVarini.My.Resources.Resources.title
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 416)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Location = New System.Drawing.Point(13, 517)
        Me.titleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(186, 17)
        Me.titleLabel.TabIndex = 4
        Me.titleLabel.Text = "Warring Warini - Axyl Schulz"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Photo by Artem Maltsev on Unsplash"
        '
        'MainMenu
        '
        Me.AcceptButton = Me.playButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.exitButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INST"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents playButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents Label1 As Label
End Class
