<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalProgram
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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CoolDownButton = New System.Windows.Forms.Button()
        Me.CoolUpButton = New System.Windows.Forms.Button()
        Me.CurrentTimeLabel = New System.Windows.Forms.Label()
        Me.CurrentTemperatureLabel = New System.Windows.Forms.Label()
        Me.HeatToGroupBox = New System.Windows.Forms.GroupBox()
        Me.HeatToTextBox = New System.Windows.Forms.TextBox()
        Me.CoolToGroupBox = New System.Windows.Forms.GroupBox()
        Me.CoolToTextBox = New System.Windows.Forms.TextBox()
        Me.ModeLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HeatDownButton = New System.Windows.Forms.Button()
        Me.HeatUpButton = New System.Windows.Forms.Button()
        Me.ErrorMessageLabel = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.COMPortSplitButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.COMPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectDisconnectMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.COMPortRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TempUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SafetyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FanDelayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.HeatToGroupBox.SuspendLayout()
        Me.CoolToGroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel.ColumnCount = 5
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.Controls.Add(Me.TableLayoutPanel2, 3, 3)
        Me.TableLayoutPanel.Controls.Add(Me.CurrentTimeLabel, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.CurrentTemperatureLabel, 2, 2)
        Me.TableLayoutPanel.Controls.Add(Me.HeatToGroupBox, 4, 2)
        Me.TableLayoutPanel.Controls.Add(Me.CoolToGroupBox, 4, 3)
        Me.TableLayoutPanel.Controls.Add(Me.ModeLabel, 0, 5)
        Me.TableLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 3, 2)
        Me.TableLayoutPanel.Controls.Add(Me.ErrorMessageLabel, 2, 5)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(800, 398)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CoolDownButton, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CoolUpButton, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(603, 200)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(34, 93)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'CoolDownButton
        '
        Me.CoolDownButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoolDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolDownButton.Location = New System.Drawing.Point(0, 46)
        Me.CoolDownButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CoolDownButton.Name = "CoolDownButton"
        Me.CoolDownButton.Size = New System.Drawing.Size(34, 47)
        Me.CoolDownButton.TabIndex = 1
        Me.CoolDownButton.Text = "˅"
        Me.CoolDownButton.UseVisualStyleBackColor = True
        '
        'CoolUpButton
        '
        Me.CoolUpButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoolUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolUpButton.Location = New System.Drawing.Point(0, 0)
        Me.CoolUpButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CoolUpButton.Name = "CoolUpButton"
        Me.CoolUpButton.Size = New System.Drawing.Size(34, 46)
        Me.CoolUpButton.TabIndex = 0
        Me.CoolUpButton.Text = "˄"
        Me.CoolUpButton.UseVisualStyleBackColor = True
        '
        'CurrentTimeLabel
        '
        Me.CurrentTimeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTimeLabel.Location = New System.Drawing.Point(3, 0)
        Me.CurrentTimeLabel.Name = "CurrentTimeLabel"
        Me.CurrentTimeLabel.Size = New System.Drawing.Size(154, 79)
        Me.CurrentTimeLabel.TabIndex = 1
        Me.CurrentTimeLabel.Text = "00:00 AM"
        '
        'CurrentTemperatureLabel
        '
        Me.CurrentTemperatureLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentTemperatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTemperatureLabel.Location = New System.Drawing.Point(203, 98)
        Me.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel"
        Me.TableLayoutPanel.SetRowSpan(Me.CurrentTemperatureLabel, 2)
        Me.CurrentTemperatureLabel.Size = New System.Drawing.Size(394, 198)
        Me.CurrentTemperatureLabel.TabIndex = 0
        Me.CurrentTemperatureLabel.Text = "72°F"
        Me.CurrentTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HeatToGroupBox
        '
        Me.HeatToGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeatToGroupBox.Controls.Add(Me.HeatToTextBox)
        Me.HeatToGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatToGroupBox.Location = New System.Drawing.Point(643, 101)
        Me.HeatToGroupBox.Name = "HeatToGroupBox"
        Me.HeatToGroupBox.Size = New System.Drawing.Size(154, 93)
        Me.HeatToGroupBox.TabIndex = 2
        Me.HeatToGroupBox.TabStop = False
        Me.HeatToGroupBox.Text = "Heat To"
        '
        'HeatToTextBox
        '
        Me.HeatToTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.HeatToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HeatToTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.HeatToTextBox.Location = New System.Drawing.Point(6, 34)
        Me.HeatToTextBox.Name = "HeatToTextBox"
        Me.HeatToTextBox.Size = New System.Drawing.Size(139, 28)
        Me.HeatToTextBox.TabIndex = 0
        Me.HeatToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CoolToGroupBox
        '
        Me.CoolToGroupBox.Controls.Add(Me.CoolToTextBox)
        Me.CoolToGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolToGroupBox.Location = New System.Drawing.Point(643, 200)
        Me.CoolToGroupBox.Name = "CoolToGroupBox"
        Me.CoolToGroupBox.Size = New System.Drawing.Size(154, 93)
        Me.CoolToGroupBox.TabIndex = 3
        Me.CoolToGroupBox.TabStop = False
        Me.CoolToGroupBox.Text = "Cool To"
        '
        'CoolToTextBox
        '
        Me.CoolToTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoolToTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.CoolToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CoolToTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CoolToTextBox.Location = New System.Drawing.Point(6, 34)
        Me.CoolToTextBox.Name = "CoolToTextBox"
        Me.CoolToTextBox.Size = New System.Drawing.Size(139, 28)
        Me.CoolToTextBox.TabIndex = 0
        Me.CoolToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModeLabel
        '
        Me.ModeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModeLabel.Location = New System.Drawing.Point(3, 315)
        Me.ModeLabel.Name = "ModeLabel"
        Me.ModeLabel.Size = New System.Drawing.Size(154, 83)
        Me.ModeLabel.TabIndex = 4
        Me.ModeLabel.Text = "OFF"
        Me.ModeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HeatDownButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HeatUpButton, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(603, 101)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(34, 93)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'HeatDownButton
        '
        Me.HeatDownButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeatDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatDownButton.Location = New System.Drawing.Point(0, 46)
        Me.HeatDownButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HeatDownButton.Name = "HeatDownButton"
        Me.HeatDownButton.Size = New System.Drawing.Size(34, 47)
        Me.HeatDownButton.TabIndex = 1
        Me.HeatDownButton.Text = "˅"
        Me.HeatDownButton.UseVisualStyleBackColor = True
        '
        'HeatUpButton
        '
        Me.HeatUpButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeatUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatUpButton.Location = New System.Drawing.Point(0, 0)
        Me.HeatUpButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HeatUpButton.Name = "HeatUpButton"
        Me.HeatUpButton.Size = New System.Drawing.Size(34, 46)
        Me.HeatUpButton.TabIndex = 0
        Me.HeatUpButton.Text = "˄"
        Me.HeatUpButton.UseVisualStyleBackColor = True
        '
        'ErrorMessageLabel
        '
        Me.ErrorMessageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorMessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessageLabel.Location = New System.Drawing.Point(203, 315)
        Me.ErrorMessageLabel.Name = "ErrorMessageLabel"
        Me.ErrorMessageLabel.Size = New System.Drawing.Size(394, 83)
        Me.ErrorMessageLabel.TabIndex = 7
        Me.ErrorMessageLabel.Text = "Error"
        Me.ErrorMessageLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMPortSplitButton, Me.COMStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip"
        '
        'COMPortSplitButton
        '
        Me.COMPortSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.COMPortSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMPortComboBox, Me.ConnectDisconnectMenuItem})
        Me.COMPortSplitButton.Image = Global.FinalProgram.My.Resources.Resources.serial_port
        Me.COMPortSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.COMPortSplitButton.Name = "COMPortSplitButton"
        Me.COMPortSplitButton.Size = New System.Drawing.Size(32, 20)
        Me.COMPortSplitButton.Text = "COM Port"
        '
        'COMPortComboBox
        '
        Me.COMPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPortComboBox.Name = "COMPortComboBox"
        Me.COMPortComboBox.Size = New System.Drawing.Size(121, 23)
        '
        'ConnectDisconnectMenuItem
        '
        Me.ConnectDisconnectMenuItem.Name = "ConnectDisconnectMenuItem"
        Me.ConnectDisconnectMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ConnectDisconnectMenuItem.Text = "Connect"
        '
        'COMStatusLabel
        '
        Me.COMStatusLabel.Name = "COMStatusLabel"
        Me.COMStatusLabel.Size = New System.Drawing.Size(145, 17)
        Me.COMStatusLabel.Text = "Disconnected from COM1"
        '
        'COMPortRefreshTimer
        '
        Me.COMPortRefreshTimer.Interval = 1000
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.TopMenuStrip.TabIndex = 2
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'RealTimeTimer
        '
        Me.RealTimeTimer.Enabled = True
        Me.RealTimeTimer.Interval = 1000
        '
        'TempUpdateTimer
        '
        Me.TempUpdateTimer.Enabled = True
        '
        'SafetyTimer
        '
        '
        'FanDelayTimer
        '
        Me.FanDelayTimer.Interval = 5000
        '
        'FinalProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Name = "FinalProgram"
        Me.Text = "Final Program"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.HeatToGroupBox.ResumeLayout(False)
        Me.HeatToGroupBox.PerformLayout()
        Me.CoolToGroupBox.ResumeLayout(False)
        Me.CoolToGroupBox.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents COMPortSplitButton As ToolStripSplitButton
    Friend WithEvents COMPortComboBox As ToolStripComboBox
    Friend WithEvents ConnectDisconnectMenuItem As ToolStripMenuItem
    Friend WithEvents COMPortRefreshTimer As Timer
    Friend WithEvents COMStatusLabel As ToolStripStatusLabel
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentTemperatureLabel As Label
    Friend WithEvents CurrentTimeLabel As Label
    Friend WithEvents HeatToGroupBox As GroupBox
    Friend WithEvents HeatToTextBox As TextBox
    Friend WithEvents CoolToGroupBox As GroupBox
    Friend WithEvents CoolToTextBox As TextBox
    Friend WithEvents ModeLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CoolDownButton As Button
    Friend WithEvents CoolUpButton As Button
    Friend WithEvents HeatDownButton As Button
    Friend WithEvents HeatUpButton As Button
    Friend WithEvents RealTimeTimer As Timer
    Friend WithEvents ErrorMessageLabel As Label
    Friend WithEvents TempUpdateTimer As Timer
    Friend WithEvents SafetyTimer As Timer
    Friend WithEvents FanDelayTimer As Timer
End Class
