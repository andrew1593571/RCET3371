﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchASketchForm
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PenColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.PenSizeLabel = New System.Windows.Forms.Label()
        Me.PenSizeTrackBar = New System.Windows.Forms.TrackBar()
        Me.WaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenColorTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.COMToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SerialPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SerialComStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.COMTimeoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ControlSelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.BoardRadioButton = New System.Windows.Forms.RadioButton()
        Me.MouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.BoardDrawTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        CType(Me.PenSizeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ControlSelectGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DrawingPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 27)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(788, 272)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        Me.ToolTip.SetToolTip(Me.DrawingPictureBox, "Right Click to Change Colors")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(171, 48)
        '
        'PenColorToolStripMenuItem
        '
        Me.PenColorToolStripMenuItem.Name = "PenColorToolStripMenuItem"
        Me.PenColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PenColorToolStripMenuItem.Text = "Color"
        Me.PenColorToolStripMenuItem.ToolTipText = "Change the Pen Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        Me.BackgroundColorToolStripMenuItem.ToolTipText = "Change the Background Color"
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlsGroupBox.Controls.Add(Me.PenSizeLabel)
        Me.ControlsGroupBox.Controls.Add(Me.PenSizeTrackBar)
        Me.ControlsGroupBox.Controls.Add(Me.WaveButton)
        Me.ControlsGroupBox.Controls.Add(Me.ClearButton)
        Me.ControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(169, 305)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(631, 100)
        Me.ControlsGroupBox.TabIndex = 1
        Me.ControlsGroupBox.TabStop = False
        '
        'PenSizeLabel
        '
        Me.PenSizeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PenSizeLabel.Location = New System.Drawing.Point(92, 19)
        Me.PenSizeLabel.Name = "PenSizeLabel"
        Me.PenSizeLabel.Size = New System.Drawing.Size(131, 27)
        Me.PenSizeLabel.TabIndex = 4
        Me.PenSizeLabel.Text = "Pen Size"
        Me.PenSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.PenSizeLabel, "Adjusts the Pen Size")
        '
        'PenSizeTrackBar
        '
        Me.PenSizeTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PenSizeTrackBar.Location = New System.Drawing.Point(95, 49)
        Me.PenSizeTrackBar.Minimum = 1
        Me.PenSizeTrackBar.Name = "PenSizeTrackBar"
        Me.PenSizeTrackBar.Size = New System.Drawing.Size(128, 45)
        Me.PenSizeTrackBar.TabIndex = 3
        Me.PenSizeTrackBar.TabStop = False
        Me.ToolTip.SetToolTip(Me.PenSizeTrackBar, "Adjusts the Pen Size")
        Me.PenSizeTrackBar.Value = 1
        '
        'WaveButton
        '
        Me.WaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WaveButton.Location = New System.Drawing.Point(229, 19)
        Me.WaveButton.Name = "WaveButton"
        Me.WaveButton.Size = New System.Drawing.Size(128, 75)
        Me.WaveButton.TabIndex = 1
        Me.WaveButton.Text = "&Wave"
        Me.WaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip.SetToolTip(Me.WaveButton, "Displays a Sine Wave and Divisions")
        Me.WaveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(363, 19)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 75)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clears the Screen")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(497, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 75)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exits the Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.EditToolStripMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(812, 24)
        Me.TopMenuStrip.TabIndex = 2
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenTopMenuItem, Me.SaveTopMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'OpenTopMenuItem
        '
        Me.OpenTopMenuItem.Name = "OpenTopMenuItem"
        Me.OpenTopMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenTopMenuItem.Text = "&Open"
        Me.OpenTopMenuItem.ToolTipText = "Open an Image File"
        '
        'SaveTopMenuItem
        '
        Me.SaveTopMenuItem.Name = "SaveTopMenuItem"
        Me.SaveTopMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveTopMenuItem.Text = "&Save"
        Me.SaveTopMenuItem.ToolTipText = "Save the Current Screen as a BMP"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorTopToolStripMenuItem, Me.PenColorTopToolStripMenuItem, Me.DrawWaveformToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'BackgroundColorTopToolStripMenuItem
        '
        Me.BackgroundColorTopToolStripMenuItem.Name = "BackgroundColorTopToolStripMenuItem"
        Me.BackgroundColorTopToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorTopToolStripMenuItem.Text = "&Background Color"
        Me.BackgroundColorTopToolStripMenuItem.ToolTipText = "Change the Background Color"
        '
        'PenColorTopToolStripMenuItem
        '
        Me.PenColorTopToolStripMenuItem.Name = "PenColorTopToolStripMenuItem"
        Me.PenColorTopToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PenColorTopToolStripMenuItem.Text = "&Pen Color"
        Me.PenColorTopToolStripMenuItem.ToolTipText = "Change the Pen Color"
        '
        'DrawWaveformToolStripMenuItem
        '
        Me.DrawWaveformToolStripMenuItem.Name = "DrawWaveformToolStripMenuItem"
        Me.DrawWaveformToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DrawWaveformToolStripMenuItem.Text = "Draw &Waveform"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpTopMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "About this Program"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMToolStripDropDownButton, Me.SerialComStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 408)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(812, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'COMToolStripDropDownButton
        '
        Me.COMToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.COMToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.SerialPortComboBox})
        Me.COMToolStripDropDownButton.Image = Global.EtchASketch.My.Resources.Resources.serial_port
        Me.COMToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.COMToolStripDropDownButton.Name = "COMToolStripDropDownButton"
        Me.COMToolStripDropDownButton.Size = New System.Drawing.Size(29, 20)
        Me.COMToolStripDropDownButton.Text = "COMStatusStripButton"
        Me.COMToolStripDropDownButton.ToolTipText = "Change the COM port of the Qy@ Board"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
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
        'ControlSelectGroupBox
        '
        Me.ControlSelectGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ControlSelectGroupBox.Controls.Add(Me.BoardRadioButton)
        Me.ControlSelectGroupBox.Controls.Add(Me.MouseRadioButton)
        Me.ControlSelectGroupBox.Location = New System.Drawing.Point(12, 305)
        Me.ControlSelectGroupBox.Name = "ControlSelectGroupBox"
        Me.ControlSelectGroupBox.Size = New System.Drawing.Size(151, 100)
        Me.ControlSelectGroupBox.TabIndex = 5
        Me.ControlSelectGroupBox.TabStop = False
        Me.ControlSelectGroupBox.Text = "Control Mode"
        '
        'BoardRadioButton
        '
        Me.BoardRadioButton.AutoSize = True
        Me.BoardRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.BoardRadioButton.Name = "BoardRadioButton"
        Me.BoardRadioButton.Size = New System.Drawing.Size(130, 17)
        Me.BoardRadioButton.TabIndex = 1
        Me.BoardRadioButton.TabStop = True
        Me.BoardRadioButton.Text = "Draw with Qy@ Board"
        Me.BoardRadioButton.UseVisualStyleBackColor = True
        '
        'MouseRadioButton
        '
        Me.MouseRadioButton.AutoSize = True
        Me.MouseRadioButton.Checked = True
        Me.MouseRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.MouseRadioButton.Name = "MouseRadioButton"
        Me.MouseRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.MouseRadioButton.TabIndex = 0
        Me.MouseRadioButton.TabStop = True
        Me.MouseRadioButton.Text = "Draw with Mouse"
        Me.MouseRadioButton.UseVisualStyleBackColor = True
        '
        'BoardDrawTimer
        '
        Me.BoardDrawTimer.Interval = 5
        '
        'EtchASketchForm
        '
        Me.AcceptButton = Me.WaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(812, 430)
        Me.Controls.Add(Me.ControlSelectGroupBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "EtchASketchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.ControlsGroupBox.PerformLayout()
        CType(Me.PenSizeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ControlSelectGroupBox.ResumeLayout(False)
        Me.ControlSelectGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents PenColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaveButton As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTopMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents PenSizeLabel As Label
    Friend WithEvents PenSizeTrackBar As TrackBar
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenColorTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents SerialComStatusLabel As ToolStripStatusLabel
    Friend WithEvents COMToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents SerialPortComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents SerialPortRefreshTimer As Timer
    Friend WithEvents COMTimeoutTimer As Timer
    Friend WithEvents ControlSelectGroupBox As GroupBox
    Friend WithEvents MouseRadioButton As RadioButton
    Friend WithEvents BoardRadioButton As RadioButton
    Friend WithEvents BoardDrawTimer As Timer
End Class
