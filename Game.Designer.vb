<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.popList = New System.Windows.Forms.ListBox()
        Me.eventList = New System.Windows.Forms.ListBox()
        Me.battleButton = New System.Windows.Forms.Button()
        Me.negotiateButton = New System.Windows.Forms.Button()
        Me.mapButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.scoutButton = New System.Windows.Forms.Button()
        Me.commandButton = New System.Windows.Forms.Button()
        Me.travelButton = New System.Windows.Forms.Button()
        Me.turnButton = New System.Windows.Forms.Button()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWebBrowserAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BattleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextTurnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TravelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetPowerLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoBackInTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoAheadInTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RandomEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add100GoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RandomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeirdInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.commandGroup = New System.Windows.Forms.GroupBox()
        Me.findMemButton = New System.Windows.Forms.Button()
        Me.buildButton = New System.Windows.Forms.Button()
        Me.celebrateButton = New System.Windows.Forms.Button()
        Me.travelGroup = New System.Windows.Forms.GroupBox()
        Me.eastButton = New System.Windows.Forms.Button()
        Me.southButton = New System.Windows.Forms.Button()
        Me.westButton = New System.Windows.Forms.Button()
        Me.northButton = New System.Windows.Forms.Button()
        Me.buildGroup = New System.Windows.Forms.GroupBox()
        Me.buildResidentialButton = New System.Windows.Forms.Button()
        Me.buildBarracksButton = New System.Windows.Forms.Button()
        Me.buildFarmButton = New System.Windows.Forms.Button()
        Me.viewPersonButton = New System.Windows.Forms.Button()
        Me.goldLabel = New System.Windows.Forms.Label()
        Me.viewTribeButton = New System.Windows.Forms.Button()
        Me.VariniGodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.commandGroup.SuspendLayout()
        Me.travelGroup.SuspendLayout()
        Me.buildGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'popList
        '
        Me.popList.BackColor = System.Drawing.SystemColors.Info
        Me.popList.FormattingEnabled = True
        Me.popList.ItemHeight = 16
        Me.popList.Location = New System.Drawing.Point(16, 65)
        Me.popList.Margin = New System.Windows.Forms.Padding(4)
        Me.popList.Name = "popList"
        Me.popList.Size = New System.Drawing.Size(204, 484)
        Me.popList.TabIndex = 0
        '
        'eventList
        '
        Me.eventList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.eventList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.eventList.FormattingEnabled = True
        Me.eventList.ItemHeight = 16
        Me.eventList.Location = New System.Drawing.Point(272, 464)
        Me.eventList.Margin = New System.Windows.Forms.Padding(4)
        Me.eventList.Name = "eventList"
        Me.eventList.Size = New System.Drawing.Size(751, 112)
        Me.eventList.TabIndex = 2
        '
        'battleButton
        '
        Me.battleButton.Location = New System.Drawing.Point(17, 57)
        Me.battleButton.Margin = New System.Windows.Forms.Padding(4)
        Me.battleButton.Name = "battleButton"
        Me.battleButton.Size = New System.Drawing.Size(100, 28)
        Me.battleButton.TabIndex = 1
        Me.battleButton.Text = "Battle"
        Me.battleButton.UseVisualStyleBackColor = True
        '
        'negotiateButton
        '
        Me.negotiateButton.Location = New System.Drawing.Point(125, 21)
        Me.negotiateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.negotiateButton.Name = "negotiateButton"
        Me.negotiateButton.Size = New System.Drawing.Size(100, 28)
        Me.negotiateButton.TabIndex = 3
        Me.negotiateButton.Text = "Negotiate"
        Me.negotiateButton.UseVisualStyleBackColor = True
        '
        'mapButton
        '
        Me.mapButton.Location = New System.Drawing.Point(17, 21)
        Me.mapButton.Margin = New System.Windows.Forms.Padding(4)
        Me.mapButton.Name = "mapButton"
        Me.mapButton.Size = New System.Drawing.Size(100, 28)
        Me.mapButton.TabIndex = 0
        Me.mapButton.Text = "Map"
        Me.mapButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.scoutButton)
        Me.GroupBox1.Controls.Add(Me.commandButton)
        Me.GroupBox1.Controls.Add(Me.travelButton)
        Me.GroupBox1.Controls.Add(Me.turnButton)
        Me.GroupBox1.Controls.Add(Me.mapButton)
        Me.GroupBox1.Controls.Add(Me.battleButton)
        Me.GroupBox1.Controls.Add(Me.negotiateButton)
        Me.GroupBox1.Location = New System.Drawing.Point(789, 276)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(235, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'scoutButton
        '
        Me.scoutButton.Location = New System.Drawing.Point(125, 94)
        Me.scoutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.scoutButton.Name = "scoutButton"
        Me.scoutButton.Size = New System.Drawing.Size(100, 28)
        Me.scoutButton.TabIndex = 5
        Me.scoutButton.Text = "Scout"
        Me.scoutButton.UseVisualStyleBackColor = True
        '
        'commandButton
        '
        Me.commandButton.Location = New System.Drawing.Point(17, 94)
        Me.commandButton.Margin = New System.Windows.Forms.Padding(4)
        Me.commandButton.Name = "commandButton"
        Me.commandButton.Size = New System.Drawing.Size(100, 28)
        Me.commandButton.TabIndex = 2
        Me.commandButton.Text = "Command"
        Me.commandButton.UseVisualStyleBackColor = True
        '
        'travelButton
        '
        Me.travelButton.Location = New System.Drawing.Point(125, 58)
        Me.travelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.travelButton.Name = "travelButton"
        Me.travelButton.Size = New System.Drawing.Size(100, 28)
        Me.travelButton.TabIndex = 4
        Me.travelButton.Text = "Travel"
        Me.travelButton.UseVisualStyleBackColor = True
        '
        'turnButton
        '
        Me.turnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.turnButton.Location = New System.Drawing.Point(125, 142)
        Me.turnButton.Margin = New System.Windows.Forms.Padding(4)
        Me.turnButton.Name = "turnButton"
        Me.turnButton.Size = New System.Drawing.Size(100, 28)
        Me.turnButton.TabIndex = 6
        Me.turnButton.Text = "Next Turn"
        Me.turnButton.UseVisualStyleBackColor = True
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Location = New System.Drawing.Point(706, 401)
        Me.yearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(67, 17)
        Me.yearLabel.TabIndex = 9
        Me.yearLabel.Text = "YEAR BC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Populice:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 421)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Events:"
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ActionsToolStripMenuItem, Me.OtherToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuBar.Size = New System.Drawing.Size(1039, 28)
        Me.MenuBar.TabIndex = 10
        Me.MenuBar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.closeToolBar})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'closeToolBar
        '
        Me.closeToolBar.Name = "closeToolBar"
        Me.closeToolBar.Size = New System.Drawing.Size(224, 26)
        Me.closeToolBar.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.OpenWebBrowserAboutToolStripMenuItem, Me.VariniGodsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.EditToolStripMenuItem.Text = "Tools"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenWebBrowserAboutToolStripMenuItem
        '
        Me.OpenWebBrowserAboutToolStripMenuItem.Name = "OpenWebBrowserAboutToolStripMenuItem"
        Me.OpenWebBrowserAboutToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.OpenWebBrowserAboutToolStripMenuItem.Text = "Open WebBrowser About"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapToolStripMenuItem, Me.BattleToolStripMenuItem, Me.NegotiateToolStripMenuItem, Me.NextTurnToolStripMenuItem, Me.TravelToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'MapToolStripMenuItem
        '
        Me.MapToolStripMenuItem.Name = "MapToolStripMenuItem"
        Me.MapToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MapToolStripMenuItem.Text = "Map"
        '
        'BattleToolStripMenuItem
        '
        Me.BattleToolStripMenuItem.Name = "BattleToolStripMenuItem"
        Me.BattleToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BattleToolStripMenuItem.Text = "Battle"
        '
        'NegotiateToolStripMenuItem
        '
        Me.NegotiateToolStripMenuItem.Name = "NegotiateToolStripMenuItem"
        Me.NegotiateToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NegotiateToolStripMenuItem.Text = "Negotiate"
        '
        'NextTurnToolStripMenuItem
        '
        Me.NextTurnToolStripMenuItem.Name = "NextTurnToolStripMenuItem"
        Me.NextTurnToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NextTurnToolStripMenuItem.Text = "Next Turn"
        '
        'TravelToolStripMenuItem
        '
        Me.TravelToolStripMenuItem.Name = "TravelToolStripMenuItem"
        Me.TravelToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TravelToolStripMenuItem.Text = "Travel"
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.CheatsToolStripMenuItem})
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.OtherToolStripMenuItem.Text = "Other"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CheatsToolStripMenuItem
        '
        Me.CheatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewMemberToolStripMenuItem, Me.GetPowerLevelToolStripMenuItem, Me.GoBackInTimeToolStripMenuItem, Me.GoAheadInTimeToolStripMenuItem, Me.RandomEventToolStripMenuItem, Me.Add100GoldToolStripMenuItem, Me.RandomizeToolStripMenuItem, Me.WeirdInfoToolStripMenuItem})
        Me.CheatsToolStripMenuItem.Name = "CheatsToolStripMenuItem"
        Me.CheatsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CheatsToolStripMenuItem.Text = "Cheats"
        '
        'AddNewMemberToolStripMenuItem
        '
        Me.AddNewMemberToolStripMenuItem.Name = "AddNewMemberToolStripMenuItem"
        Me.AddNewMemberToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.AddNewMemberToolStripMenuItem.Text = "Add New Member"
        '
        'GetPowerLevelToolStripMenuItem
        '
        Me.GetPowerLevelToolStripMenuItem.Name = "GetPowerLevelToolStripMenuItem"
        Me.GetPowerLevelToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.GetPowerLevelToolStripMenuItem.Text = "Get PowerLevel"
        '
        'GoBackInTimeToolStripMenuItem
        '
        Me.GoBackInTimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YearToolStripMenuItem, Me.YearsToolStripMenuItem, Me.YearsToolStripMenuItem1})
        Me.GoBackInTimeToolStripMenuItem.Name = "GoBackInTimeToolStripMenuItem"
        Me.GoBackInTimeToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.GoBackInTimeToolStripMenuItem.Text = "Go back in Time"
        '
        'YearToolStripMenuItem
        '
        Me.YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        Me.YearToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.YearToolStripMenuItem.Text = "1 Year"
        '
        'YearsToolStripMenuItem
        '
        Me.YearsToolStripMenuItem.Name = "YearsToolStripMenuItem"
        Me.YearsToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.YearsToolStripMenuItem.Text = "5 Years"
        '
        'YearsToolStripMenuItem1
        '
        Me.YearsToolStripMenuItem1.Name = "YearsToolStripMenuItem1"
        Me.YearsToolStripMenuItem1.Size = New System.Drawing.Size(154, 26)
        Me.YearsToolStripMenuItem1.Text = "100 Years"
        '
        'GoAheadInTimeToolStripMenuItem
        '
        Me.GoAheadInTimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YearToolStripMenuItem1, Me.YearsToolStripMenuItem2, Me.YearsToolStripMenuItem3})
        Me.GoAheadInTimeToolStripMenuItem.Name = "GoAheadInTimeToolStripMenuItem"
        Me.GoAheadInTimeToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.GoAheadInTimeToolStripMenuItem.Text = "Go ahead in Time"
        '
        'YearToolStripMenuItem1
        '
        Me.YearToolStripMenuItem1.Name = "YearToolStripMenuItem1"
        Me.YearToolStripMenuItem1.Size = New System.Drawing.Size(154, 26)
        Me.YearToolStripMenuItem1.Text = "1 Year"
        '
        'YearsToolStripMenuItem2
        '
        Me.YearsToolStripMenuItem2.Name = "YearsToolStripMenuItem2"
        Me.YearsToolStripMenuItem2.Size = New System.Drawing.Size(154, 26)
        Me.YearsToolStripMenuItem2.Text = "5 Years"
        '
        'YearsToolStripMenuItem3
        '
        Me.YearsToolStripMenuItem3.Name = "YearsToolStripMenuItem3"
        Me.YearsToolStripMenuItem3.Size = New System.Drawing.Size(154, 26)
        Me.YearsToolStripMenuItem3.Text = "100 Years"
        '
        'RandomEventToolStripMenuItem
        '
        Me.RandomEventToolStripMenuItem.Name = "RandomEventToolStripMenuItem"
        Me.RandomEventToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.RandomEventToolStripMenuItem.Text = "Random Event"
        '
        'Add100GoldToolStripMenuItem
        '
        Me.Add100GoldToolStripMenuItem.Name = "Add100GoldToolStripMenuItem"
        Me.Add100GoldToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.Add100GoldToolStripMenuItem.Text = "Add 100 Gold"
        '
        'RandomizeToolStripMenuItem
        '
        Me.RandomizeToolStripMenuItem.Name = "RandomizeToolStripMenuItem"
        Me.RandomizeToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.RandomizeToolStripMenuItem.Text = "Randomize()"
        '
        'WeirdInfoToolStripMenuItem
        '
        Me.WeirdInfoToolStripMenuItem.Name = "WeirdInfoToolStripMenuItem"
        Me.WeirdInfoToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.WeirdInfoToolStripMenuItem.Text = "Weird Info"
        '
        'commandGroup
        '
        Me.commandGroup.Controls.Add(Me.findMemButton)
        Me.commandGroup.Controls.Add(Me.buildButton)
        Me.commandGroup.Controls.Add(Me.celebrateButton)
        Me.commandGroup.Location = New System.Drawing.Point(229, 42)
        Me.commandGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.commandGroup.Name = "commandGroup"
        Me.commandGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.commandGroup.Size = New System.Drawing.Size(402, 73)
        Me.commandGroup.TabIndex = 11
        Me.commandGroup.TabStop = False
        Me.commandGroup.Text = "Issue a Command to your People"
        '
        'findMemButton
        '
        Me.findMemButton.Location = New System.Drawing.Point(266, 25)
        Me.findMemButton.Name = "findMemButton"
        Me.findMemButton.Size = New System.Drawing.Size(129, 28)
        Me.findMemButton.TabIndex = 16
        Me.findMemButton.Text = "Find People (5G)"
        Me.findMemButton.UseVisualStyleBackColor = True
        '
        'buildButton
        '
        Me.buildButton.Location = New System.Drawing.Point(151, 25)
        Me.buildButton.Margin = New System.Windows.Forms.Padding(4)
        Me.buildButton.Name = "buildButton"
        Me.buildButton.Size = New System.Drawing.Size(108, 28)
        Me.buildButton.TabIndex = 15
        Me.buildButton.Text = "Build"
        Me.buildButton.UseVisualStyleBackColor = True
        '
        'celebrateButton
        '
        Me.celebrateButton.Location = New System.Drawing.Point(9, 25)
        Me.celebrateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.celebrateButton.Name = "celebrateButton"
        Me.celebrateButton.Size = New System.Drawing.Size(134, 28)
        Me.celebrateButton.TabIndex = 12
        Me.celebrateButton.Text = "Celebrate (5G)"
        Me.celebrateButton.UseVisualStyleBackColor = True
        '
        'travelGroup
        '
        Me.travelGroup.Controls.Add(Me.eastButton)
        Me.travelGroup.Controls.Add(Me.southButton)
        Me.travelGroup.Controls.Add(Me.westButton)
        Me.travelGroup.Controls.Add(Me.northButton)
        Me.travelGroup.Location = New System.Drawing.Point(229, 162)
        Me.travelGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.travelGroup.Name = "travelGroup"
        Me.travelGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.travelGroup.Size = New System.Drawing.Size(341, 165)
        Me.travelGroup.TabIndex = 12
        Me.travelGroup.TabStop = False
        Me.travelGroup.Text = "Travel Directions"
        '
        'eastButton
        '
        Me.eastButton.Location = New System.Drawing.Point(228, 74)
        Me.eastButton.Margin = New System.Windows.Forms.Padding(4)
        Me.eastButton.Name = "eastButton"
        Me.eastButton.Size = New System.Drawing.Size(100, 28)
        Me.eastButton.TabIndex = 3
        Me.eastButton.Text = "East"
        Me.eastButton.UseVisualStyleBackColor = True
        '
        'southButton
        '
        Me.southButton.Location = New System.Drawing.Point(119, 107)
        Me.southButton.Margin = New System.Windows.Forms.Padding(4)
        Me.southButton.Name = "southButton"
        Me.southButton.Size = New System.Drawing.Size(100, 28)
        Me.southButton.TabIndex = 2
        Me.southButton.Text = "South"
        Me.southButton.UseVisualStyleBackColor = True
        '
        'westButton
        '
        Me.westButton.Location = New System.Drawing.Point(9, 74)
        Me.westButton.Margin = New System.Windows.Forms.Padding(4)
        Me.westButton.Name = "westButton"
        Me.westButton.Size = New System.Drawing.Size(100, 28)
        Me.westButton.TabIndex = 1
        Me.westButton.Text = "West"
        Me.westButton.UseVisualStyleBackColor = True
        '
        'northButton
        '
        Me.northButton.Location = New System.Drawing.Point(119, 43)
        Me.northButton.Margin = New System.Windows.Forms.Padding(4)
        Me.northButton.Name = "northButton"
        Me.northButton.Size = New System.Drawing.Size(100, 28)
        Me.northButton.TabIndex = 0
        Me.northButton.Text = "North"
        Me.northButton.UseVisualStyleBackColor = True
        '
        'buildGroup
        '
        Me.buildGroup.Controls.Add(Me.buildResidentialButton)
        Me.buildGroup.Controls.Add(Me.buildBarracksButton)
        Me.buildGroup.Controls.Add(Me.buildFarmButton)
        Me.buildGroup.Location = New System.Drawing.Point(870, 32)
        Me.buildGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.buildGroup.Name = "buildGroup"
        Me.buildGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.buildGroup.Size = New System.Drawing.Size(144, 161)
        Me.buildGroup.TabIndex = 14
        Me.buildGroup.TabStop = False
        Me.buildGroup.Text = "Build Menu (10G)"
        '
        'buildResidentialButton
        '
        Me.buildResidentialButton.Location = New System.Drawing.Point(8, 117)
        Me.buildResidentialButton.Margin = New System.Windows.Forms.Padding(4)
        Me.buildResidentialButton.Name = "buildResidentialButton"
        Me.buildResidentialButton.Size = New System.Drawing.Size(128, 28)
        Me.buildResidentialButton.TabIndex = 2
        Me.buildResidentialButton.Text = "Abode"
        Me.buildResidentialButton.UseVisualStyleBackColor = True
        '
        'buildBarracksButton
        '
        Me.buildBarracksButton.Location = New System.Drawing.Point(8, 81)
        Me.buildBarracksButton.Margin = New System.Windows.Forms.Padding(4)
        Me.buildBarracksButton.Name = "buildBarracksButton"
        Me.buildBarracksButton.Size = New System.Drawing.Size(128, 28)
        Me.buildBarracksButton.TabIndex = 1
        Me.buildBarracksButton.Text = "Barracks"
        Me.buildBarracksButton.UseVisualStyleBackColor = True
        '
        'buildFarmButton
        '
        Me.buildFarmButton.Location = New System.Drawing.Point(8, 44)
        Me.buildFarmButton.Margin = New System.Windows.Forms.Padding(4)
        Me.buildFarmButton.Name = "buildFarmButton"
        Me.buildFarmButton.Size = New System.Drawing.Size(128, 28)
        Me.buildFarmButton.TabIndex = 0
        Me.buildFarmButton.Text = "Farm"
        Me.buildFarmButton.UseVisualStyleBackColor = True
        '
        'viewPersonButton
        '
        Me.viewPersonButton.Location = New System.Drawing.Point(79, 39)
        Me.viewPersonButton.Name = "viewPersonButton"
        Me.viewPersonButton.Size = New System.Drawing.Size(141, 23)
        Me.viewPersonButton.TabIndex = 17
        Me.viewPersonButton.Text = "View Selected"
        Me.viewPersonButton.UseVisualStyleBackColor = True
        '
        'goldLabel
        '
        Me.goldLabel.AutoSize = True
        Me.goldLabel.Location = New System.Drawing.Point(706, 418)
        Me.goldLabel.Name = "goldLabel"
        Me.goldLabel.Size = New System.Drawing.Size(62, 17)
        Me.goldLabel.TabIndex = 18
        Me.goldLabel.Text = "Gold: ##"
        '
        'viewTribeButton
        '
        Me.viewTribeButton.Location = New System.Drawing.Point(16, 553)
        Me.viewTribeButton.Name = "viewTribeButton"
        Me.viewTribeButton.Size = New System.Drawing.Size(204, 32)
        Me.viewTribeButton.TabIndex = 19
        Me.viewTribeButton.Text = "View Tribe"
        Me.viewTribeButton.UseVisualStyleBackColor = True
        '
        'VariniGodsToolStripMenuItem
        '
        Me.VariniGodsToolStripMenuItem.Name = "VariniGodsToolStripMenuItem"
        Me.VariniGodsToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.VariniGodsToolStripMenuItem.Text = "Varini Gods"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1039, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.viewTribeButton)
        Me.Controls.Add(Me.goldLabel)
        Me.Controls.Add(Me.viewPersonButton)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.commandGroup)
        Me.Controls.Add(Me.buildGroup)
        Me.Controls.Add(Me.travelGroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.eventList)
        Me.Controls.Add(Me.popList)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.commandGroup.ResumeLayout(False)
        Me.travelGroup.ResumeLayout(False)
        Me.buildGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents popList As ListBox
    Friend WithEvents eventList As ListBox
    Friend WithEvents battleButton As Button
    Friend WithEvents negotiateButton As Button
    Friend WithEvents mapButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents turnButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BattleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegotiateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextTurnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents commandButton As Button
    Friend WithEvents travelButton As Button
    Friend WithEvents TravelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents commandGroup As GroupBox
    Friend WithEvents buildButton As Button
    Friend WithEvents celebrateButton As Button
    Friend WithEvents travelGroup As GroupBox
    Friend WithEvents eastButton As Button
    Friend WithEvents southButton As Button
    Friend WithEvents westButton As Button
    Friend WithEvents northButton As Button
    Friend WithEvents buildGroup As GroupBox
    Friend WithEvents buildResidentialButton As Button
    Friend WithEvents buildBarracksButton As Button
    Friend WithEvents buildFarmButton As Button
    Friend WithEvents closeToolBar As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetPowerLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents scoutButton As Button
    Friend WithEvents GoBackInTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GoAheadInTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents YearsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents YearsToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents OpenWebBrowserAboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents viewPersonButton As Button
    Friend WithEvents RandomEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents goldLabel As Label
    Friend WithEvents Add100GoldToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RandomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeirdInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents findMemButton As Button
    Friend WithEvents viewTribeButton As Button
    Friend WithEvents VariniGodsToolStripMenuItem As ToolStripMenuItem
End Class
