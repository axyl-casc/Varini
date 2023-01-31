<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'browser
        '
        Me.browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser.Location = New System.Drawing.Point(0, 0)
        Me.browser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.browser.MinimumSize = New System.Drawing.Size(27, 25)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(1425, 590)
        Me.browser.TabIndex = 0
        Me.browser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1425, 590)
        Me.Controls.Add(Me.browser)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "about"
        Me.Text = "About"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents browser As WebBrowser
End Class
