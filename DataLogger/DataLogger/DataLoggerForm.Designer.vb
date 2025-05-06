<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataLoggerForm
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
        Me.GraphPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GraphGroupBox = New System.Windows.Forms.GroupBox()
        Me.SecondsRadioButton = New System.Windows.Forms.RadioButton()
        Me.AllTimeRadioButton = New System.Windows.Forms.RadioButton()
        Me.CurrentSampleRateLabel = New System.Windows.Forms.Label()
        Me.SampleRateLabel = New System.Windows.Forms.Label()
        Me.SampleRateTrackBar = New System.Windows.Forms.TrackBar()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.COMToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SerialPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SerialComStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SavePathLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.COMTimeoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SampleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.GraphGroupBox.SuspendLayout()
        CType(Me.SampleRateTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GraphPictureBox
        '
        Me.GraphPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.GraphPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.GraphPictureBox.Location = New System.Drawing.Point(18, 27)
        Me.GraphPictureBox.Name = "GraphPictureBox"
        Me.GraphPictureBox.Size = New System.Drawing.Size(788, 272)
        Me.GraphPictureBox.TabIndex = 0
        Me.GraphPictureBox.TabStop = False
        Me.ToolTip.SetToolTip(Me.GraphPictureBox, "Graph of collected Data")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveContextMenuItem, Me.ContextToolStripSeparator3, Me.ExitContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(99, 54)
        '
        'SaveContextMenuItem
        '
        Me.SaveContextMenuItem.Name = "SaveContextMenuItem"
        Me.SaveContextMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveContextMenuItem.Text = "Save"
        '
        'ContextToolStripSeparator3
        '
        Me.ContextToolStripSeparator3.Name = "ContextToolStripSeparator3"
        Me.ContextToolStripSeparator3.Size = New System.Drawing.Size(95, 6)
        '
        'ExitContextMenuItem
        '
        Me.ExitContextMenuItem.Name = "ExitContextMenuItem"
        Me.ExitContextMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitContextMenuItem.Text = "Exit"
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlsGroupBox.Controls.Add(Me.GraphGroupBox)
        Me.ControlsGroupBox.Controls.Add(Me.CurrentSampleRateLabel)
        Me.ControlsGroupBox.Controls.Add(Me.SampleRateLabel)
        Me.ControlsGroupBox.Controls.Add(Me.SampleRateTrackBar)
        Me.ControlsGroupBox.Controls.Add(Me.StartStopButton)
        Me.ControlsGroupBox.Controls.Add(Me.SaveButton)
        Me.ControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(12, 305)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(788, 100)
        Me.ControlsGroupBox.TabIndex = 1
        Me.ControlsGroupBox.TabStop = False
        '
        'GraphGroupBox
        '
        Me.GraphGroupBox.Controls.Add(Me.SecondsRadioButton)
        Me.GraphGroupBox.Controls.Add(Me.AllTimeRadioButton)
        Me.GraphGroupBox.Location = New System.Drawing.Point(140, 19)
        Me.GraphGroupBox.Name = "GraphGroupBox"
        Me.GraphGroupBox.Size = New System.Drawing.Size(114, 75)
        Me.GraphGroupBox.TabIndex = 6
        Me.GraphGroupBox.TabStop = False
        Me.GraphGroupBox.Text = "Graph Time"
        Me.ToolTip.SetToolTip(Me.GraphGroupBox, "Sets the time scale axis of the graph")
        '
        'SecondsRadioButton
        '
        Me.SecondsRadioButton.AutoSize = True
        Me.SecondsRadioButton.Location = New System.Drawing.Point(7, 43)
        Me.SecondsRadioButton.Name = "SecondsRadioButton"
        Me.SecondsRadioButton.Size = New System.Drawing.Size(105, 17)
        Me.SecondsRadioButton.TabIndex = 1
        Me.SecondsRadioButton.Text = "Last 30 Seconds"
        Me.ToolTip.SetToolTip(Me.SecondsRadioButton, "Sets the graph time scale to the last 30 seconds")
        Me.SecondsRadioButton.UseVisualStyleBackColor = True
        '
        'AllTimeRadioButton
        '
        Me.AllTimeRadioButton.AutoSize = True
        Me.AllTimeRadioButton.Checked = True
        Me.AllTimeRadioButton.Location = New System.Drawing.Point(7, 20)
        Me.AllTimeRadioButton.Name = "AllTimeRadioButton"
        Me.AllTimeRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.AllTimeRadioButton.TabIndex = 0
        Me.AllTimeRadioButton.TabStop = True
        Me.AllTimeRadioButton.Text = "All Time"
        Me.ToolTip.SetToolTip(Me.AllTimeRadioButton, "Sets the graph time scale to all recorded time")
        Me.AllTimeRadioButton.UseVisualStyleBackColor = True
        '
        'CurrentSampleRateLabel
        '
        Me.CurrentSampleRateLabel.Location = New System.Drawing.Point(3, 74)
        Me.CurrentSampleRateLabel.Name = "CurrentSampleRateLabel"
        Me.CurrentSampleRateLabel.Size = New System.Drawing.Size(131, 17)
        Me.CurrentSampleRateLabel.TabIndex = 5
        Me.CurrentSampleRateLabel.Text = "10 samples/s"
        Me.CurrentSampleRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.CurrentSampleRateLabel, "The current data sample rate")
        '
        'SampleRateLabel
        '
        Me.SampleRateLabel.Location = New System.Drawing.Point(3, 16)
        Me.SampleRateLabel.Name = "SampleRateLabel"
        Me.SampleRateLabel.Size = New System.Drawing.Size(131, 17)
        Me.SampleRateLabel.TabIndex = 4
        Me.SampleRateLabel.Text = "Samples"
        Me.SampleRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.SampleRateLabel, "Adjusts the samples taken every second")
        '
        'SampleRateTrackBar
        '
        Me.SampleRateTrackBar.Location = New System.Drawing.Point(6, 36)
        Me.SampleRateTrackBar.Maximum = 100
        Me.SampleRateTrackBar.Minimum = 1
        Me.SampleRateTrackBar.Name = "SampleRateTrackBar"
        Me.SampleRateTrackBar.Size = New System.Drawing.Size(128, 45)
        Me.SampleRateTrackBar.TabIndex = 3
        Me.SampleRateTrackBar.TabStop = False
        Me.SampleRateTrackBar.TickFrequency = 10
        Me.ToolTip.SetToolTip(Me.SampleRateTrackBar, "Adjusts the samples taken every second")
        Me.SampleRateTrackBar.Value = 10
        '
        'StartStopButton
        '
        Me.StartStopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartStopButton.Location = New System.Drawing.Point(386, 19)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(128, 75)
        Me.StartStopButton.TabIndex = 1
        Me.StartStopButton.Text = "S&tart"
        Me.StartStopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip.SetToolTip(Me.StartStopButton, "Start or Stop data recording")
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SaveButton.Location = New System.Drawing.Point(520, 19)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(128, 75)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "&Save"
        Me.ToolTip.SetToolTip(Me.SaveButton, "Save the obtained data to File")
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(654, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 75)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exits the Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(812, 24)
        Me.TopMenuStrip.TabIndex = 2
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartTopMenuItem, Me.SaveTopMenuItem, Me.ExitTopMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'StartTopMenuItem
        '
        Me.StartTopMenuItem.Name = "StartTopMenuItem"
        Me.StartTopMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.StartTopMenuItem.Text = "S&tart"
        '
        'SaveTopMenuItem
        '
        Me.SaveTopMenuItem.Name = "SaveTopMenuItem"
        Me.SaveTopMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveTopMenuItem.Text = "&Save"
        Me.SaveTopMenuItem.ToolTipText = "Save the Current Screen as a BMP"
        '
        'ExitTopMenuItem
        '
        Me.ExitTopMenuItem.Name = "ExitTopMenuItem"
        Me.ExitTopMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitTopMenuItem.Text = "E&xit"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpTopMenuItem.Text = "&Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutTopMenuItem.Text = "&About"
        Me.AboutTopMenuItem.ToolTipText = "About this Program"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMToolStripDropDownButton, Me.SerialComStatusLabel, Me.SavePathLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 408)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(812, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'COMToolStripDropDownButton
        '
        Me.COMToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.COMToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialPortComboBox})
        Me.COMToolStripDropDownButton.Image = Global.DataLogger.My.Resources.Resources.serial_port
        Me.COMToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.COMToolStripDropDownButton.Name = "COMToolStripDropDownButton"
        Me.COMToolStripDropDownButton.Size = New System.Drawing.Size(29, 20)
        Me.COMToolStripDropDownButton.Text = "COMStatusStripButton"
        Me.COMToolStripDropDownButton.ToolTipText = "Change the COM port of the Qy@ Board"
        '
        'SerialPortComboBox
        '
        Me.SerialPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialPortComboBox.Name = "SerialPortComboBox"
        Me.SerialPortComboBox.Size = New System.Drawing.Size(121, 23)
        Me.SerialPortComboBox.ToolTipText = "Change the active COM port"
        '
        'SerialComStatusLabel
        '
        Me.SerialComStatusLabel.Name = "SerialComStatusLabel"
        Me.SerialComStatusLabel.Size = New System.Drawing.Size(108, 17)
        Me.SerialComStatusLabel.Text = "Disconnected from"
        Me.SerialComStatusLabel.ToolTipText = "Current COM Port"
        '
        'SavePathLabel
        '
        Me.SavePathLabel.Name = "SavePathLabel"
        Me.SavePathLabel.Size = New System.Drawing.Size(104, 17)
        Me.SavePathLabel.Text = "Current Save Path:"
        '
        'SerialPort
        '
        '
        'SerialPortRefreshTimer
        '
        Me.SerialPortRefreshTimer.Interval = 500
        '
        'COMTimeoutTimer
        '
        Me.COMTimeoutTimer.Interval = 2000
        '
        'SampleTimer
        '
        Me.SampleTimer.Interval = 5
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'DataLoggerForm
        '
        Me.AcceptButton = Me.StartStopButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SaveButton
        Me.ClientSize = New System.Drawing.Size(812, 430)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.GraphPictureBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "DataLoggerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Logger"
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.ControlsGroupBox.PerformLayout()
        Me.GraphGroupBox.ResumeLayout(False)
        Me.GraphGroupBox.PerformLayout()
        CType(Me.SampleRateTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GraphPictureBox As PictureBox
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents StartStopButton As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents SampleRateLabel As Label
    Friend WithEvents SampleRateTrackBar As TrackBar
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents SerialComStatusLabel As ToolStripStatusLabel
    Friend WithEvents COMToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents SerialPortComboBox As ToolStripComboBox
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents SerialPortRefreshTimer As Timer
    Friend WithEvents COMTimeoutTimer As Timer
    Friend WithEvents SampleTimer As Timer
    Friend WithEvents CurrentSampleRateLabel As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents GraphGroupBox As GroupBox
    Friend WithEvents SecondsRadioButton As RadioButton
    Friend WithEvents AllTimeRadioButton As RadioButton
    Friend WithEvents SaveContextMenuItem As ToolStripMenuItem
    Friend WithEvents ContextToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitContextMenuItem As ToolStripMenuItem
    Friend WithEvents SavePathLabel As ToolStripStatusLabel
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents StartTopMenuItem As ToolStripMenuItem
End Class
