<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CircuitSolverForm
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
        Me.InputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalculateContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryContextToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.HistoryContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutContextToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrequencyGroupBox = New System.Windows.Forms.GroupBox()
        Me.FrequencyComboBox = New System.Windows.Forms.ComboBox()
        Me.FrequencyTextBox = New System.Windows.Forms.TextBox()
        Me.RWGroupBox = New System.Windows.Forms.GroupBox()
        Me.RWComboBox = New System.Windows.Forms.ComboBox()
        Me.RWTextBox = New System.Windows.Forms.TextBox()
        Me.L1GroupBox = New System.Windows.Forms.GroupBox()
        Me.L1ComboBox = New System.Windows.Forms.ComboBox()
        Me.L1TextBox = New System.Windows.Forms.TextBox()
        Me.C2GroupBox = New System.Windows.Forms.GroupBox()
        Me.C2ComboBox = New System.Windows.Forms.ComboBox()
        Me.C2TextBox = New System.Windows.Forms.TextBox()
        Me.C1GroupBox = New System.Windows.Forms.GroupBox()
        Me.C1ComboBox = New System.Windows.Forms.ComboBox()
        Me.C1TextBox = New System.Windows.Forms.TextBox()
        Me.R1GroupBox = New System.Windows.Forms.GroupBox()
        Me.R1ComboBox = New System.Windows.Forms.ComboBox()
        Me.R1TextBox = New System.Windows.Forms.TextBox()
        Me.RGenGroupBox = New System.Windows.Forms.GroupBox()
        Me.RGenComboBox = New System.Windows.Forms.ComboBox()
        Me.RGenTextBox = New System.Windows.Forms.TextBox()
        Me.VGenGroupBox = New System.Windows.Forms.GroupBox()
        Me.VGenComboBox = New System.Windows.Forms.ComboBox()
        Me.VGenTextBox = New System.Windows.Forms.TextBox()
        Me.OutputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OutputTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.L1PowerLabel = New System.Windows.Forms.Label()
        Me.L1CurrentLabel = New System.Windows.Forms.Label()
        Me.L1VoltageLabel = New System.Windows.Forms.Label()
        Me.L1ImpedanceLabel = New System.Windows.Forms.Label()
        Me.C2PowerLabel = New System.Windows.Forms.Label()
        Me.C2CurrentLabel = New System.Windows.Forms.Label()
        Me.C2VoltageLabel = New System.Windows.Forms.Label()
        Me.C2ImpedanceLabel = New System.Windows.Forms.Label()
        Me.C1PowerLabel = New System.Windows.Forms.Label()
        Me.C1CurrentLabel = New System.Windows.Forms.Label()
        Me.C1VoltageLabel = New System.Windows.Forms.Label()
        Me.C1ImpedanceLabel = New System.Windows.Forms.Label()
        Me.R1PowerLabel = New System.Windows.Forms.Label()
        Me.R1CurrentLabel = New System.Windows.Forms.Label()
        Me.R1VoltageLabel = New System.Windows.Forms.Label()
        Me.R1ImpedanceLabel = New System.Windows.Forms.Label()
        Me.TotalPowerLabel = New System.Windows.Forms.Label()
        Me.TotalCurrentLabel = New System.Windows.Forms.Label()
        Me.TotalVoltageLabel = New System.Windows.Forms.Label()
        Me.ImpedanceLabel = New System.Windows.Forms.Label()
        Me.ComponentLabel = New System.Windows.Forms.Label()
        Me.CurrentLabel = New System.Windows.Forms.Label()
        Me.PowerLabel = New System.Windows.Forms.Label()
        Me.VoltageLabel = New System.Windows.Forms.Label()
        Me.R1Label = New System.Windows.Forms.Label()
        Me.C1Label = New System.Windows.Forms.Label()
        Me.C2Label = New System.Windows.Forms.Label()
        Me.L1Label = New System.Windows.Forms.Label()
        Me.RGenLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.RGenImpedanceLabel = New System.Windows.Forms.Label()
        Me.RGenVoltageLabel = New System.Windows.Forms.Label()
        Me.RGenCurrentLabel = New System.Windows.Forms.Label()
        Me.RGenPowerLabel = New System.Windows.Forms.Label()
        Me.TotalImpedanceLabel = New System.Windows.Forms.Label()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.PeakRMSGroupBox = New System.Windows.Forms.GroupBox()
        Me.RMSRadioButton = New System.Windows.Forms.RadioButton()
        Me.PeakRadioButton = New System.Windows.Forms.RadioButton()
        Me.PolarRectangleGroupBox = New System.Windows.Forms.GroupBox()
        Me.RectangularRadioButton = New System.Windows.Forms.RadioButton()
        Me.PolarRadioButton = New System.Windows.Forms.RadioButton()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryTopToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.HistoryTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchematicPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputsGroupBox.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.FrequencyGroupBox.SuspendLayout()
        Me.RWGroupBox.SuspendLayout()
        Me.L1GroupBox.SuspendLayout()
        Me.C2GroupBox.SuspendLayout()
        Me.C1GroupBox.SuspendLayout()
        Me.R1GroupBox.SuspendLayout()
        Me.RGenGroupBox.SuspendLayout()
        Me.VGenGroupBox.SuspendLayout()
        Me.OutputsGroupBox.SuspendLayout()
        Me.OutputTableLayoutPanel.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.PeakRMSGroupBox.SuspendLayout()
        Me.PolarRectangleGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        CType(Me.SchematicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputsGroupBox
        '
        Me.InputsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InputsGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.InputsGroupBox.Controls.Add(Me.FrequencyGroupBox)
        Me.InputsGroupBox.Controls.Add(Me.RWGroupBox)
        Me.InputsGroupBox.Controls.Add(Me.L1GroupBox)
        Me.InputsGroupBox.Controls.Add(Me.C2GroupBox)
        Me.InputsGroupBox.Controls.Add(Me.C1GroupBox)
        Me.InputsGroupBox.Controls.Add(Me.R1GroupBox)
        Me.InputsGroupBox.Controls.Add(Me.RGenGroupBox)
        Me.InputsGroupBox.Controls.Add(Me.VGenGroupBox)
        Me.InputsGroupBox.Location = New System.Drawing.Point(12, 242)
        Me.InputsGroupBox.Name = "InputsGroupBox"
        Me.InputsGroupBox.Size = New System.Drawing.Size(175, 363)
        Me.InputsGroupBox.TabIndex = 0
        Me.InputsGroupBox.TabStop = False
        Me.InputsGroupBox.Text = "Inputs"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateContextMenuItem, Me.ResetContextMenuItem, Me.HistoryContextToolStripSeparator, Me.HistoryContextMenuItem, Me.AboutContextToolStripSeparator, Me.AboutContextMenuItem, Me.ExitContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(181, 126)
        '
        'CalculateContextMenuItem
        '
        Me.CalculateContextMenuItem.Name = "CalculateContextMenuItem"
        Me.CalculateContextMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculateContextMenuItem.Text = "&Calculate"
        '
        'ResetContextMenuItem
        '
        Me.ResetContextMenuItem.Name = "ResetContextMenuItem"
        Me.ResetContextMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetContextMenuItem.Text = "&Reset"
        '
        'HistoryContextToolStripSeparator
        '
        Me.HistoryContextToolStripSeparator.Name = "HistoryContextToolStripSeparator"
        Me.HistoryContextToolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'HistoryContextMenuItem
        '
        Me.HistoryContextMenuItem.Name = "HistoryContextMenuItem"
        Me.HistoryContextMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HistoryContextMenuItem.Text = "&Open History Folder"
        '
        'AboutContextToolStripSeparator
        '
        Me.AboutContextToolStripSeparator.Name = "AboutContextToolStripSeparator"
        Me.AboutContextToolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'AboutContextMenuItem
        '
        Me.AboutContextMenuItem.Name = "AboutContextMenuItem"
        Me.AboutContextMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutContextMenuItem.Text = "&About"
        '
        'ExitContextMenuItem
        '
        Me.ExitContextMenuItem.Name = "ExitContextMenuItem"
        Me.ExitContextMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitContextMenuItem.Text = "E&xit"
        '
        'FrequencyGroupBox
        '
        Me.FrequencyGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.FrequencyGroupBox.Controls.Add(Me.FrequencyComboBox)
        Me.FrequencyGroupBox.Controls.Add(Me.FrequencyTextBox)
        Me.FrequencyGroupBox.Location = New System.Drawing.Point(6, 18)
        Me.FrequencyGroupBox.Name = "FrequencyGroupBox"
        Me.FrequencyGroupBox.Size = New System.Drawing.Size(162, 40)
        Me.FrequencyGroupBox.TabIndex = 7
        Me.FrequencyGroupBox.TabStop = False
        Me.FrequencyGroupBox.Text = "Frequency"
        '
        'FrequencyComboBox
        '
        Me.FrequencyComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.FrequencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrequencyComboBox.FormattingEnabled = True
        Me.FrequencyComboBox.Items.AddRange(New Object() {"Hz", "KHz", "MHz", "GHz"})
        Me.FrequencyComboBox.Location = New System.Drawing.Point(112, 15)
        Me.FrequencyComboBox.Name = "FrequencyComboBox"
        Me.FrequencyComboBox.Size = New System.Drawing.Size(40, 21)
        Me.FrequencyComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.FrequencyComboBox, "Engineering notation for the frequency")
        '
        'FrequencyTextBox
        '
        Me.FrequencyTextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.FrequencyTextBox.Location = New System.Drawing.Point(6, 15)
        Me.FrequencyTextBox.Name = "FrequencyTextBox"
        Me.FrequencyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FrequencyTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.FrequencyTextBox, "Frequency of the generator")
        '
        'RWGroupBox
        '
        Me.RWGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.RWGroupBox.Controls.Add(Me.RWComboBox)
        Me.RWGroupBox.Controls.Add(Me.RWTextBox)
        Me.RWGroupBox.Location = New System.Drawing.Point(6, 318)
        Me.RWGroupBox.Name = "RWGroupBox"
        Me.RWGroupBox.Size = New System.Drawing.Size(162, 40)
        Me.RWGroupBox.TabIndex = 6
        Me.RWGroupBox.TabStop = False
        Me.RWGroupBox.Text = "L1 - Winding"
        '
        'RWComboBox
        '
        Me.RWComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.RWComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RWComboBox.FormattingEnabled = True
        Me.RWComboBox.Items.AddRange(New Object() {"mΩ", "Ω", "kΩ", "MΩ"})
        Me.RWComboBox.Location = New System.Drawing.Point(112, 15)
        Me.RWComboBox.Name = "RWComboBox"
        Me.RWComboBox.Size = New System.Drawing.Size(40, 21)
        Me.RWComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.RWComboBox, "Engineering Notation of L1 Winding")
        '
        'RWTextBox
        '
        Me.RWTextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.RWTextBox.Location = New System.Drawing.Point(6, 15)
        Me.RWTextBox.Name = "RWTextBox"
        Me.RWTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RWTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.RWTextBox, "Winding resistance of L1")
        '
        'L1GroupBox
        '
        Me.L1GroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1GroupBox.Controls.Add(Me.L1ComboBox)
        Me.L1GroupBox.Controls.Add(Me.L1TextBox)
        Me.L1GroupBox.Location = New System.Drawing.Point(6, 276)
        Me.L1GroupBox.Name = "L1GroupBox"
        Me.L1GroupBox.Size = New System.Drawing.Size(162, 40)
        Me.L1GroupBox.TabIndex = 5
        Me.L1GroupBox.TabStop = False
        Me.L1GroupBox.Text = "L1"
        '
        'L1ComboBox
        '
        Me.L1ComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.L1ComboBox.FormattingEnabled = True
        Me.L1ComboBox.Items.AddRange(New Object() {"H", "mH", "µH", "nH", "pH"})
        Me.L1ComboBox.Location = New System.Drawing.Point(112, 15)
        Me.L1ComboBox.Name = "L1ComboBox"
        Me.L1ComboBox.Size = New System.Drawing.Size(40, 21)
        Me.L1ComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.L1ComboBox, "Engineering notation of L1")
        '
        'L1TextBox
        '
        Me.L1TextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1TextBox.Location = New System.Drawing.Point(6, 15)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.L1TextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.L1TextBox, "Inductance of L1")
        '
        'C2GroupBox
        '
        Me.C2GroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2GroupBox.Controls.Add(Me.C2ComboBox)
        Me.C2GroupBox.Controls.Add(Me.C2TextBox)
        Me.C2GroupBox.Location = New System.Drawing.Point(6, 235)
        Me.C2GroupBox.Name = "C2GroupBox"
        Me.C2GroupBox.Size = New System.Drawing.Size(162, 40)
        Me.C2GroupBox.TabIndex = 4
        Me.C2GroupBox.TabStop = False
        Me.C2GroupBox.Text = "C2"
        '
        'C2ComboBox
        '
        Me.C2ComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C2ComboBox.FormattingEnabled = True
        Me.C2ComboBox.Items.AddRange(New Object() {"F", "mF", "µF", "nF", "pF"})
        Me.C2ComboBox.Location = New System.Drawing.Point(112, 14)
        Me.C2ComboBox.Name = "C2ComboBox"
        Me.C2ComboBox.Size = New System.Drawing.Size(40, 21)
        Me.C2ComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.C2ComboBox, "Engineering notation of C2")
        '
        'C2TextBox
        '
        Me.C2TextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2TextBox.Location = New System.Drawing.Point(6, 14)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.C2TextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.C2TextBox, "Capacitance of C2")
        '
        'C1GroupBox
        '
        Me.C1GroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1GroupBox.Controls.Add(Me.C1ComboBox)
        Me.C1GroupBox.Controls.Add(Me.C1TextBox)
        Me.C1GroupBox.Location = New System.Drawing.Point(6, 193)
        Me.C1GroupBox.Name = "C1GroupBox"
        Me.C1GroupBox.Size = New System.Drawing.Size(162, 40)
        Me.C1GroupBox.TabIndex = 3
        Me.C1GroupBox.TabStop = False
        Me.C1GroupBox.Text = "C1"
        '
        'C1ComboBox
        '
        Me.C1ComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C1ComboBox.FormattingEnabled = True
        Me.C1ComboBox.Items.AddRange(New Object() {"F", "mF", "µF", "nF", "pF"})
        Me.C1ComboBox.Location = New System.Drawing.Point(112, 15)
        Me.C1ComboBox.Name = "C1ComboBox"
        Me.C1ComboBox.Size = New System.Drawing.Size(40, 21)
        Me.C1ComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.C1ComboBox, "Engineering notation of C1")
        '
        'C1TextBox
        '
        Me.C1TextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1TextBox.Location = New System.Drawing.Point(6, 15)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.C1TextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.C1TextBox, "Capacitance of C1")
        '
        'R1GroupBox
        '
        Me.R1GroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1GroupBox.Controls.Add(Me.R1ComboBox)
        Me.R1GroupBox.Controls.Add(Me.R1TextBox)
        Me.R1GroupBox.Location = New System.Drawing.Point(6, 151)
        Me.R1GroupBox.Name = "R1GroupBox"
        Me.R1GroupBox.Size = New System.Drawing.Size(162, 40)
        Me.R1GroupBox.TabIndex = 2
        Me.R1GroupBox.TabStop = False
        Me.R1GroupBox.Text = "R1"
        '
        'R1ComboBox
        '
        Me.R1ComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.R1ComboBox.FormattingEnabled = True
        Me.R1ComboBox.Items.AddRange(New Object() {"mΩ", "Ω", "kΩ", "MΩ"})
        Me.R1ComboBox.Location = New System.Drawing.Point(112, 15)
        Me.R1ComboBox.Name = "R1ComboBox"
        Me.R1ComboBox.Size = New System.Drawing.Size(40, 21)
        Me.R1ComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.R1ComboBox, "Engineering notation of R1")
        '
        'R1TextBox
        '
        Me.R1TextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1TextBox.Location = New System.Drawing.Point(6, 15)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.R1TextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.R1TextBox, "Resistance of R1")
        '
        'RGenGroupBox
        '
        Me.RGenGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenGroupBox.Controls.Add(Me.RGenComboBox)
        Me.RGenGroupBox.Controls.Add(Me.RGenTextBox)
        Me.RGenGroupBox.Location = New System.Drawing.Point(6, 105)
        Me.RGenGroupBox.Name = "RGenGroupBox"
        Me.RGenGroupBox.Size = New System.Drawing.Size(162, 40)
        Me.RGenGroupBox.TabIndex = 1
        Me.RGenGroupBox.TabStop = False
        Me.RGenGroupBox.Text = "Rgen"
        Me.ToolTip.SetToolTip(Me.RGenGroupBox, "Resistance of the generator")
        '
        'RGenComboBox
        '
        Me.RGenComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RGenComboBox.FormattingEnabled = True
        Me.RGenComboBox.Items.AddRange(New Object() {"mΩ", "Ω", "kΩ", "MΩ"})
        Me.RGenComboBox.Location = New System.Drawing.Point(112, 15)
        Me.RGenComboBox.Name = "RGenComboBox"
        Me.RGenComboBox.Size = New System.Drawing.Size(40, 21)
        Me.RGenComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.RGenComboBox, "Engineering Notation of Rgen")
        '
        'RGenTextBox
        '
        Me.RGenTextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenTextBox.Location = New System.Drawing.Point(6, 15)
        Me.RGenTextBox.Name = "RGenTextBox"
        Me.RGenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RGenTextBox.TabIndex = 0
        '
        'VGenGroupBox
        '
        Me.VGenGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.VGenGroupBox.Controls.Add(Me.VGenComboBox)
        Me.VGenGroupBox.Controls.Add(Me.VGenTextBox)
        Me.VGenGroupBox.Location = New System.Drawing.Point(6, 59)
        Me.VGenGroupBox.Name = "VGenGroupBox"
        Me.VGenGroupBox.Size = New System.Drawing.Size(162, 40)
        Me.VGenGroupBox.TabIndex = 0
        Me.VGenGroupBox.TabStop = False
        Me.VGenGroupBox.Text = "Vgen"
        '
        'VGenComboBox
        '
        Me.VGenComboBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.VGenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VGenComboBox.FormattingEnabled = True
        Me.VGenComboBox.Items.AddRange(New Object() {"mVp", "Vp", "mV", "V"})
        Me.VGenComboBox.Location = New System.Drawing.Point(112, 15)
        Me.VGenComboBox.Name = "VGenComboBox"
        Me.VGenComboBox.Size = New System.Drawing.Size(40, 21)
        Me.VGenComboBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.VGenComboBox, "Engineering notation and peak vs RMS for Vgen")
        '
        'VGenTextBox
        '
        Me.VGenTextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.VGenTextBox.Location = New System.Drawing.Point(6, 15)
        Me.VGenTextBox.Name = "VGenTextBox"
        Me.VGenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VGenTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.VGenTextBox, "Voltage of the generator")
        '
        'OutputsGroupBox
        '
        Me.OutputsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputsGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.OutputsGroupBox.Controls.Add(Me.OutputTableLayoutPanel)
        Me.OutputsGroupBox.Location = New System.Drawing.Point(193, 242)
        Me.OutputsGroupBox.Name = "OutputsGroupBox"
        Me.OutputsGroupBox.Size = New System.Drawing.Size(595, 267)
        Me.OutputsGroupBox.TabIndex = 1
        Me.OutputsGroupBox.TabStop = False
        Me.OutputsGroupBox.Text = "Outputs"
        '
        'OutputTableLayoutPanel
        '
        Me.OutputTableLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.OutputTableLayoutPanel.ColumnCount = 5
        Me.OutputTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OutputTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OutputTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OutputTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OutputTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.OutputTableLayoutPanel.ContextMenuStrip = Me.ContextMenuStrip
        Me.OutputTableLayoutPanel.Controls.Add(Me.L1PowerLabel, 4, 6)
        Me.OutputTableLayoutPanel.Controls.Add(Me.L1CurrentLabel, 3, 6)
        Me.OutputTableLayoutPanel.Controls.Add(Me.L1VoltageLabel, 2, 6)
        Me.OutputTableLayoutPanel.Controls.Add(Me.L1ImpedanceLabel, 1, 6)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C2PowerLabel, 4, 5)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C2CurrentLabel, 3, 5)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C2VoltageLabel, 2, 5)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C2ImpedanceLabel, 1, 5)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C1PowerLabel, 4, 4)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C1CurrentLabel, 3, 4)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C1VoltageLabel, 2, 4)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C1ImpedanceLabel, 1, 4)
        Me.OutputTableLayoutPanel.Controls.Add(Me.R1PowerLabel, 4, 3)
        Me.OutputTableLayoutPanel.Controls.Add(Me.R1CurrentLabel, 3, 3)
        Me.OutputTableLayoutPanel.Controls.Add(Me.R1VoltageLabel, 2, 3)
        Me.OutputTableLayoutPanel.Controls.Add(Me.R1ImpedanceLabel, 1, 3)
        Me.OutputTableLayoutPanel.Controls.Add(Me.TotalPowerLabel, 4, 1)
        Me.OutputTableLayoutPanel.Controls.Add(Me.TotalCurrentLabel, 3, 1)
        Me.OutputTableLayoutPanel.Controls.Add(Me.TotalVoltageLabel, 2, 1)
        Me.OutputTableLayoutPanel.Controls.Add(Me.ImpedanceLabel, 1, 0)
        Me.OutputTableLayoutPanel.Controls.Add(Me.ComponentLabel, 0, 0)
        Me.OutputTableLayoutPanel.Controls.Add(Me.CurrentLabel, 3, 0)
        Me.OutputTableLayoutPanel.Controls.Add(Me.PowerLabel, 4, 0)
        Me.OutputTableLayoutPanel.Controls.Add(Me.VoltageLabel, 2, 0)
        Me.OutputTableLayoutPanel.Controls.Add(Me.R1Label, 0, 3)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C1Label, 0, 4)
        Me.OutputTableLayoutPanel.Controls.Add(Me.C2Label, 0, 5)
        Me.OutputTableLayoutPanel.Controls.Add(Me.L1Label, 0, 6)
        Me.OutputTableLayoutPanel.Controls.Add(Me.RGenLabel, 0, 2)
        Me.OutputTableLayoutPanel.Controls.Add(Me.TotalLabel, 0, 1)
        Me.OutputTableLayoutPanel.Controls.Add(Me.RGenImpedanceLabel, 1, 2)
        Me.OutputTableLayoutPanel.Controls.Add(Me.RGenVoltageLabel, 2, 2)
        Me.OutputTableLayoutPanel.Controls.Add(Me.RGenCurrentLabel, 3, 2)
        Me.OutputTableLayoutPanel.Controls.Add(Me.RGenPowerLabel, 4, 2)
        Me.OutputTableLayoutPanel.Controls.Add(Me.TotalImpedanceLabel, 1, 1)
        Me.OutputTableLayoutPanel.Location = New System.Drawing.Point(6, 19)
        Me.OutputTableLayoutPanel.Name = "OutputTableLayoutPanel"
        Me.OutputTableLayoutPanel.RowCount = 7
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.OutputTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OutputTableLayoutPanel.Size = New System.Drawing.Size(583, 242)
        Me.OutputTableLayoutPanel.TabIndex = 3
        '
        'L1PowerLabel
        '
        Me.L1PowerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L1PowerLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1PowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1PowerLabel.Location = New System.Drawing.Point(468, 205)
        Me.L1PowerLabel.Name = "L1PowerLabel"
        Me.L1PowerLabel.Size = New System.Drawing.Size(111, 36)
        Me.L1PowerLabel.TabIndex = 35
        Me.L1PowerLabel.Text = "-"
        Me.L1PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.L1PowerLabel, "Power on L1")
        '
        'L1CurrentLabel
        '
        Me.L1CurrentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L1CurrentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1CurrentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1CurrentLabel.Location = New System.Drawing.Point(352, 205)
        Me.L1CurrentLabel.Name = "L1CurrentLabel"
        Me.L1CurrentLabel.Size = New System.Drawing.Size(109, 36)
        Me.L1CurrentLabel.TabIndex = 34
        Me.L1CurrentLabel.Text = "-"
        Me.L1CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.L1CurrentLabel, "Current through L1")
        '
        'L1VoltageLabel
        '
        Me.L1VoltageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L1VoltageLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1VoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1VoltageLabel.Location = New System.Drawing.Point(236, 205)
        Me.L1VoltageLabel.Name = "L1VoltageLabel"
        Me.L1VoltageLabel.Size = New System.Drawing.Size(109, 36)
        Me.L1VoltageLabel.TabIndex = 33
        Me.L1VoltageLabel.Text = "-"
        Me.L1VoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.L1VoltageLabel, "Voltage of L1")
        '
        'L1ImpedanceLabel
        '
        Me.L1ImpedanceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L1ImpedanceLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1ImpedanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1ImpedanceLabel.Location = New System.Drawing.Point(120, 205)
        Me.L1ImpedanceLabel.Name = "L1ImpedanceLabel"
        Me.L1ImpedanceLabel.Size = New System.Drawing.Size(109, 36)
        Me.L1ImpedanceLabel.TabIndex = 32
        Me.L1ImpedanceLabel.Text = "-"
        Me.L1ImpedanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.L1ImpedanceLabel, "Impedance of L1")
        '
        'C2PowerLabel
        '
        Me.C2PowerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2PowerLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2PowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2PowerLabel.Location = New System.Drawing.Point(468, 171)
        Me.C2PowerLabel.Name = "C2PowerLabel"
        Me.C2PowerLabel.Size = New System.Drawing.Size(111, 33)
        Me.C2PowerLabel.TabIndex = 31
        Me.C2PowerLabel.Text = "-"
        Me.C2PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C2PowerLabel, "Power on C2")
        '
        'C2CurrentLabel
        '
        Me.C2CurrentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2CurrentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2CurrentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2CurrentLabel.Location = New System.Drawing.Point(352, 171)
        Me.C2CurrentLabel.Name = "C2CurrentLabel"
        Me.C2CurrentLabel.Size = New System.Drawing.Size(109, 33)
        Me.C2CurrentLabel.TabIndex = 30
        Me.C2CurrentLabel.Text = "-"
        Me.C2CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C2CurrentLabel, "Current through C2")
        '
        'C2VoltageLabel
        '
        Me.C2VoltageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2VoltageLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2VoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2VoltageLabel.Location = New System.Drawing.Point(236, 171)
        Me.C2VoltageLabel.Name = "C2VoltageLabel"
        Me.C2VoltageLabel.Size = New System.Drawing.Size(109, 33)
        Me.C2VoltageLabel.TabIndex = 29
        Me.C2VoltageLabel.Text = "-"
        Me.C2VoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C2VoltageLabel, "Voltage of C2")
        '
        'C2ImpedanceLabel
        '
        Me.C2ImpedanceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2ImpedanceLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2ImpedanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2ImpedanceLabel.Location = New System.Drawing.Point(120, 171)
        Me.C2ImpedanceLabel.Name = "C2ImpedanceLabel"
        Me.C2ImpedanceLabel.Size = New System.Drawing.Size(109, 33)
        Me.C2ImpedanceLabel.TabIndex = 28
        Me.C2ImpedanceLabel.Text = "-"
        Me.C2ImpedanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C2ImpedanceLabel, "Impedance of C2")
        '
        'C1PowerLabel
        '
        Me.C1PowerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1PowerLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1PowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1PowerLabel.Location = New System.Drawing.Point(468, 137)
        Me.C1PowerLabel.Name = "C1PowerLabel"
        Me.C1PowerLabel.Size = New System.Drawing.Size(111, 33)
        Me.C1PowerLabel.TabIndex = 27
        Me.C1PowerLabel.Text = "-"
        Me.C1PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C1PowerLabel, "Power on C1")
        '
        'C1CurrentLabel
        '
        Me.C1CurrentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1CurrentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1CurrentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1CurrentLabel.Location = New System.Drawing.Point(352, 137)
        Me.C1CurrentLabel.Name = "C1CurrentLabel"
        Me.C1CurrentLabel.Size = New System.Drawing.Size(109, 33)
        Me.C1CurrentLabel.TabIndex = 15
        Me.C1CurrentLabel.Text = "-"
        Me.C1CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C1CurrentLabel, "Current through C1")
        '
        'C1VoltageLabel
        '
        Me.C1VoltageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1VoltageLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1VoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1VoltageLabel.Location = New System.Drawing.Point(236, 137)
        Me.C1VoltageLabel.Name = "C1VoltageLabel"
        Me.C1VoltageLabel.Size = New System.Drawing.Size(109, 33)
        Me.C1VoltageLabel.TabIndex = 26
        Me.C1VoltageLabel.Text = "-"
        Me.C1VoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C1VoltageLabel, "Voltage of C1")
        '
        'C1ImpedanceLabel
        '
        Me.C1ImpedanceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1ImpedanceLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1ImpedanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1ImpedanceLabel.Location = New System.Drawing.Point(120, 137)
        Me.C1ImpedanceLabel.Name = "C1ImpedanceLabel"
        Me.C1ImpedanceLabel.Size = New System.Drawing.Size(109, 33)
        Me.C1ImpedanceLabel.TabIndex = 25
        Me.C1ImpedanceLabel.Text = "-"
        Me.C1ImpedanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.C1ImpedanceLabel, "Impedance of C1")
        '
        'R1PowerLabel
        '
        Me.R1PowerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R1PowerLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1PowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1PowerLabel.Location = New System.Drawing.Point(468, 103)
        Me.R1PowerLabel.Name = "R1PowerLabel"
        Me.R1PowerLabel.Size = New System.Drawing.Size(111, 33)
        Me.R1PowerLabel.TabIndex = 24
        Me.R1PowerLabel.Text = "-"
        Me.R1PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.R1PowerLabel, "Power on R1")
        '
        'R1CurrentLabel
        '
        Me.R1CurrentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R1CurrentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1CurrentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1CurrentLabel.Location = New System.Drawing.Point(352, 103)
        Me.R1CurrentLabel.Name = "R1CurrentLabel"
        Me.R1CurrentLabel.Size = New System.Drawing.Size(109, 33)
        Me.R1CurrentLabel.TabIndex = 23
        Me.R1CurrentLabel.Text = "-"
        Me.R1CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.R1CurrentLabel, "Current through R1")
        '
        'R1VoltageLabel
        '
        Me.R1VoltageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R1VoltageLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1VoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1VoltageLabel.Location = New System.Drawing.Point(236, 103)
        Me.R1VoltageLabel.Name = "R1VoltageLabel"
        Me.R1VoltageLabel.Size = New System.Drawing.Size(109, 33)
        Me.R1VoltageLabel.TabIndex = 22
        Me.R1VoltageLabel.Text = "-"
        Me.R1VoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.R1VoltageLabel, "Voltage of R1")
        '
        'R1ImpedanceLabel
        '
        Me.R1ImpedanceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R1ImpedanceLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1ImpedanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1ImpedanceLabel.Location = New System.Drawing.Point(120, 103)
        Me.R1ImpedanceLabel.Name = "R1ImpedanceLabel"
        Me.R1ImpedanceLabel.Size = New System.Drawing.Size(109, 33)
        Me.R1ImpedanceLabel.TabIndex = 21
        Me.R1ImpedanceLabel.Text = "-"
        Me.R1ImpedanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.R1ImpedanceLabel, "Impedance of R1")
        '
        'TotalPowerLabel
        '
        Me.TotalPowerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPowerLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.TotalPowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPowerLabel.Location = New System.Drawing.Point(468, 35)
        Me.TotalPowerLabel.Name = "TotalPowerLabel"
        Me.TotalPowerLabel.Size = New System.Drawing.Size(111, 33)
        Me.TotalPowerLabel.TabIndex = 20
        Me.TotalPowerLabel.Text = "-"
        Me.TotalPowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.TotalPowerLabel, "Total Power")
        '
        'TotalCurrentLabel
        '
        Me.TotalCurrentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalCurrentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.TotalCurrentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCurrentLabel.Location = New System.Drawing.Point(352, 35)
        Me.TotalCurrentLabel.Name = "TotalCurrentLabel"
        Me.TotalCurrentLabel.Size = New System.Drawing.Size(109, 33)
        Me.TotalCurrentLabel.TabIndex = 19
        Me.TotalCurrentLabel.Text = "-"
        Me.TotalCurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.TotalCurrentLabel, "Total Current")
        '
        'TotalVoltageLabel
        '
        Me.TotalVoltageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalVoltageLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.TotalVoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVoltageLabel.Location = New System.Drawing.Point(236, 35)
        Me.TotalVoltageLabel.Name = "TotalVoltageLabel"
        Me.TotalVoltageLabel.Size = New System.Drawing.Size(109, 33)
        Me.TotalVoltageLabel.TabIndex = 18
        Me.TotalVoltageLabel.Text = "-"
        Me.TotalVoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.TotalVoltageLabel, "Total Voltage")
        '
        'ImpedanceLabel
        '
        Me.ImpedanceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImpedanceLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.ImpedanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpedanceLabel.Location = New System.Drawing.Point(120, 1)
        Me.ImpedanceLabel.Name = "ImpedanceLabel"
        Me.ImpedanceLabel.Size = New System.Drawing.Size(109, 33)
        Me.ImpedanceLabel.TabIndex = 4
        Me.ImpedanceLabel.Text = "Impedance"
        Me.ImpedanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComponentLabel
        '
        Me.ComponentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComponentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.ComponentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComponentLabel.Location = New System.Drawing.Point(4, 1)
        Me.ComponentLabel.Name = "ComponentLabel"
        Me.ComponentLabel.Size = New System.Drawing.Size(109, 33)
        Me.ComponentLabel.TabIndex = 3
        Me.ComponentLabel.Text = "Component"
        Me.ComponentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrentLabel
        '
        Me.CurrentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.CurrentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentLabel.Location = New System.Drawing.Point(352, 1)
        Me.CurrentLabel.Name = "CurrentLabel"
        Me.CurrentLabel.Size = New System.Drawing.Size(109, 33)
        Me.CurrentLabel.TabIndex = 6
        Me.CurrentLabel.Text = "Current"
        Me.CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PowerLabel
        '
        Me.PowerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PowerLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.PowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerLabel.Location = New System.Drawing.Point(468, 1)
        Me.PowerLabel.Name = "PowerLabel"
        Me.PowerLabel.Size = New System.Drawing.Size(111, 33)
        Me.PowerLabel.TabIndex = 7
        Me.PowerLabel.Text = "Power"
        Me.PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VoltageLabel
        '
        Me.VoltageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VoltageLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.VoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoltageLabel.Location = New System.Drawing.Point(236, 1)
        Me.VoltageLabel.Name = "VoltageLabel"
        Me.VoltageLabel.Size = New System.Drawing.Size(109, 33)
        Me.VoltageLabel.TabIndex = 5
        Me.VoltageLabel.Text = "Voltage"
        Me.VoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R1Label
        '
        Me.R1Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R1Label.ContextMenuStrip = Me.ContextMenuStrip
        Me.R1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1Label.Location = New System.Drawing.Point(4, 103)
        Me.R1Label.Name = "R1Label"
        Me.R1Label.Size = New System.Drawing.Size(109, 33)
        Me.R1Label.TabIndex = 10
        Me.R1Label.Text = "R1"
        Me.R1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1Label
        '
        Me.C1Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Label.ContextMenuStrip = Me.ContextMenuStrip
        Me.C1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Label.Location = New System.Drawing.Point(4, 137)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(109, 33)
        Me.C1Label.TabIndex = 11
        Me.C1Label.Text = "C1"
        Me.C1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C2Label
        '
        Me.C2Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2Label.ContextMenuStrip = Me.ContextMenuStrip
        Me.C2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2Label.Location = New System.Drawing.Point(4, 171)
        Me.C2Label.Name = "C2Label"
        Me.C2Label.Size = New System.Drawing.Size(109, 33)
        Me.C2Label.TabIndex = 12
        Me.C2Label.Text = "C2"
        Me.C2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L1Label
        '
        Me.L1Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L1Label.ContextMenuStrip = Me.ContextMenuStrip
        Me.L1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1Label.Location = New System.Drawing.Point(4, 205)
        Me.L1Label.Name = "L1Label"
        Me.L1Label.Size = New System.Drawing.Size(109, 36)
        Me.L1Label.TabIndex = 13
        Me.L1Label.Text = "L1"
        Me.L1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RGenLabel
        '
        Me.RGenLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RGenLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGenLabel.Location = New System.Drawing.Point(4, 69)
        Me.RGenLabel.Name = "RGenLabel"
        Me.RGenLabel.Size = New System.Drawing.Size(109, 33)
        Me.RGenLabel.TabIndex = 4
        Me.RGenLabel.Text = "Rgen"
        Me.RGenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalLabel
        '
        Me.TotalLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(4, 35)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(109, 33)
        Me.TotalLabel.TabIndex = 9
        Me.TotalLabel.Text = "Total"
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RGenImpedanceLabel
        '
        Me.RGenImpedanceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RGenImpedanceLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenImpedanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGenImpedanceLabel.Location = New System.Drawing.Point(120, 69)
        Me.RGenImpedanceLabel.Name = "RGenImpedanceLabel"
        Me.RGenImpedanceLabel.Size = New System.Drawing.Size(109, 33)
        Me.RGenImpedanceLabel.TabIndex = 14
        Me.RGenImpedanceLabel.Text = "-"
        Me.RGenImpedanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.RGenImpedanceLabel, "Impedance of Rgen")
        '
        'RGenVoltageLabel
        '
        Me.RGenVoltageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RGenVoltageLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenVoltageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGenVoltageLabel.Location = New System.Drawing.Point(236, 69)
        Me.RGenVoltageLabel.Name = "RGenVoltageLabel"
        Me.RGenVoltageLabel.Size = New System.Drawing.Size(109, 33)
        Me.RGenVoltageLabel.TabIndex = 15
        Me.RGenVoltageLabel.Text = "-"
        Me.RGenVoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.RGenVoltageLabel, "Voltage of Rgen")
        '
        'RGenCurrentLabel
        '
        Me.RGenCurrentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RGenCurrentLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenCurrentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGenCurrentLabel.Location = New System.Drawing.Point(352, 69)
        Me.RGenCurrentLabel.Name = "RGenCurrentLabel"
        Me.RGenCurrentLabel.Size = New System.Drawing.Size(109, 33)
        Me.RGenCurrentLabel.TabIndex = 15
        Me.RGenCurrentLabel.Text = "-"
        Me.RGenCurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.RGenCurrentLabel, "Current through Rgen")
        '
        'RGenPowerLabel
        '
        Me.RGenPowerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RGenPowerLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.RGenPowerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGenPowerLabel.Location = New System.Drawing.Point(468, 69)
        Me.RGenPowerLabel.Name = "RGenPowerLabel"
        Me.RGenPowerLabel.Size = New System.Drawing.Size(111, 33)
        Me.RGenPowerLabel.TabIndex = 16
        Me.RGenPowerLabel.Text = "-"
        Me.RGenPowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.RGenPowerLabel, "Power on Rgen")
        '
        'TotalImpedanceLabel
        '
        Me.TotalImpedanceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalImpedanceLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.TotalImpedanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalImpedanceLabel.Location = New System.Drawing.Point(120, 35)
        Me.TotalImpedanceLabel.Name = "TotalImpedanceLabel"
        Me.TotalImpedanceLabel.Size = New System.Drawing.Size(109, 33)
        Me.TotalImpedanceLabel.TabIndex = 17
        Me.TotalImpedanceLabel.Text = "-"
        Me.TotalImpedanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.TotalImpedanceLabel, "Total Impedance")
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlsGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.ControlsGroupBox.Controls.Add(Me.Button2)
        Me.ControlsGroupBox.Controls.Add(Me.CalculateButton)
        Me.ControlsGroupBox.Controls.Add(Me.PeakRMSGroupBox)
        Me.ControlsGroupBox.Controls.Add(Me.PolarRectangleGroupBox)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(193, 515)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(595, 90)
        Me.ControlsGroupBox.TabIndex = 2
        Me.ControlsGroupBox.TabStop = False
        Me.ControlsGroupBox.Text = "Controls"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.ContextMenuStrip = Me.ContextMenuStrip
        Me.Button2.Location = New System.Drawing.Point(460, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 65)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.Button2, "Exit the Circuit Solver")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalculateButton.ContextMenuStrip = Me.ContextMenuStrip
        Me.CalculateButton.Location = New System.Drawing.Point(329, 19)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(125, 65)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip.SetToolTip(Me.CalculateButton, "Calculate the circuit values")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'PeakRMSGroupBox
        '
        Me.PeakRMSGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeakRMSGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.PeakRMSGroupBox.Controls.Add(Me.RMSRadioButton)
        Me.PeakRMSGroupBox.Controls.Add(Me.PeakRadioButton)
        Me.PeakRMSGroupBox.Location = New System.Drawing.Point(137, 19)
        Me.PeakRMSGroupBox.Name = "PeakRMSGroupBox"
        Me.PeakRMSGroupBox.Size = New System.Drawing.Size(125, 65)
        Me.PeakRMSGroupBox.TabIndex = 1
        Me.PeakRMSGroupBox.TabStop = False
        Me.PeakRMSGroupBox.Text = "Output Style"
        '
        'RMSRadioButton
        '
        Me.RMSRadioButton.AutoSize = True
        Me.RMSRadioButton.ContextMenuStrip = Me.ContextMenuStrip
        Me.RMSRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.RMSRadioButton.Name = "RMSRadioButton"
        Me.RMSRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.RMSRadioButton.TabIndex = 1
        Me.RMSRadioButton.Text = "RMS"
        Me.ToolTip.SetToolTip(Me.RMSRadioButton, "Voltage and Current output in RMS")
        Me.RMSRadioButton.UseVisualStyleBackColor = True
        '
        'PeakRadioButton
        '
        Me.PeakRadioButton.AutoSize = True
        Me.PeakRadioButton.Checked = True
        Me.PeakRadioButton.ContextMenuStrip = Me.ContextMenuStrip
        Me.PeakRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.PeakRadioButton.Name = "PeakRadioButton"
        Me.PeakRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.PeakRadioButton.TabIndex = 0
        Me.PeakRadioButton.TabStop = True
        Me.PeakRadioButton.Text = "Peak"
        Me.ToolTip.SetToolTip(Me.PeakRadioButton, "Voltage and Current output in Peak")
        Me.PeakRadioButton.UseVisualStyleBackColor = True
        '
        'PolarRectangleGroupBox
        '
        Me.PolarRectangleGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PolarRectangleGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.PolarRectangleGroupBox.Controls.Add(Me.RectangularRadioButton)
        Me.PolarRectangleGroupBox.Controls.Add(Me.PolarRadioButton)
        Me.PolarRectangleGroupBox.Location = New System.Drawing.Point(6, 19)
        Me.PolarRectangleGroupBox.Name = "PolarRectangleGroupBox"
        Me.PolarRectangleGroupBox.Size = New System.Drawing.Size(125, 65)
        Me.PolarRectangleGroupBox.TabIndex = 0
        Me.PolarRectangleGroupBox.TabStop = False
        Me.PolarRectangleGroupBox.Text = "Output Format"
        '
        'RectangularRadioButton
        '
        Me.RectangularRadioButton.AutoSize = True
        Me.RectangularRadioButton.ContextMenuStrip = Me.ContextMenuStrip
        Me.RectangularRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.RectangularRadioButton.Name = "RectangularRadioButton"
        Me.RectangularRadioButton.Size = New System.Drawing.Size(83, 17)
        Me.RectangularRadioButton.TabIndex = 1
        Me.RectangularRadioButton.Text = "Rectangular"
        Me.ToolTip.SetToolTip(Me.RectangularRadioButton, "Outputs in Rectangular Format")
        Me.RectangularRadioButton.UseVisualStyleBackColor = True
        '
        'PolarRadioButton
        '
        Me.PolarRadioButton.AutoSize = True
        Me.PolarRadioButton.Checked = True
        Me.PolarRadioButton.ContextMenuStrip = Me.ContextMenuStrip
        Me.PolarRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.PolarRadioButton.Name = "PolarRadioButton"
        Me.PolarRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.PolarRadioButton.TabIndex = 0
        Me.PolarRadioButton.TabStop = True
        Me.PolarRadioButton.Text = "Polar"
        Me.ToolTip.SetToolTip(Me.PolarRadioButton, "Outputs in Polar format")
        Me.PolarRadioButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ContextMenuStrip = Me.ContextMenuStrip
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.TopMenuStrip.TabIndex = 3
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateTopMenuItem, Me.ResetTopMenuItem, Me.HistoryTopToolStripSeparator, Me.HistoryTopMenuItem, Me.ExitTopToolStripSeparator, Me.ExitTopMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'CalculateTopMenuItem
        '
        Me.CalculateTopMenuItem.Name = "CalculateTopMenuItem"
        Me.CalculateTopMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculateTopMenuItem.Text = "&Calculate"
        '
        'ResetTopMenuItem
        '
        Me.ResetTopMenuItem.Name = "ResetTopMenuItem"
        Me.ResetTopMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetTopMenuItem.Text = "&Reset"
        '
        'HistoryTopToolStripSeparator
        '
        Me.HistoryTopToolStripSeparator.Name = "HistoryTopToolStripSeparator"
        Me.HistoryTopToolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'HistoryTopMenuItem
        '
        Me.HistoryTopMenuItem.Name = "HistoryTopMenuItem"
        Me.HistoryTopMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HistoryTopMenuItem.Text = "&Open History Folder"
        '
        'ExitTopToolStripSeparator
        '
        Me.ExitTopToolStripSeparator.Name = "ExitTopToolStripSeparator"
        Me.ExitTopToolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'ExitTopMenuItem
        '
        Me.ExitTopMenuItem.Name = "ExitTopMenuItem"
        Me.ExitTopMenuItem.Size = New System.Drawing.Size(180, 22)
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
        '
        'SchematicPictureBox
        '
        Me.SchematicPictureBox.BackgroundImage = Global.CircuitSolver.My.Resources.Resources.CircuitSchematic
        Me.SchematicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SchematicPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.SchematicPictureBox.Location = New System.Drawing.Point(12, 27)
        Me.SchematicPictureBox.Name = "SchematicPictureBox"
        Me.SchematicPictureBox.Size = New System.Drawing.Size(776, 209)
        Me.SchematicPictureBox.TabIndex = 4
        Me.SchematicPictureBox.TabStop = False
        Me.ToolTip.SetToolTip(Me.SchematicPictureBox, "Schematic for the solver")
        '
        'CircuitSolverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 617)
        Me.Controls.Add(Me.SchematicPictureBox)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.OutputsGroupBox)
        Me.Controls.Add(Me.InputsGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "CircuitSolverForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circuit Solver"
        Me.InputsGroupBox.ResumeLayout(False)
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.FrequencyGroupBox.ResumeLayout(False)
        Me.FrequencyGroupBox.PerformLayout()
        Me.RWGroupBox.ResumeLayout(False)
        Me.RWGroupBox.PerformLayout()
        Me.L1GroupBox.ResumeLayout(False)
        Me.L1GroupBox.PerformLayout()
        Me.C2GroupBox.ResumeLayout(False)
        Me.C2GroupBox.PerformLayout()
        Me.C1GroupBox.ResumeLayout(False)
        Me.C1GroupBox.PerformLayout()
        Me.R1GroupBox.ResumeLayout(False)
        Me.R1GroupBox.PerformLayout()
        Me.RGenGroupBox.ResumeLayout(False)
        Me.RGenGroupBox.PerformLayout()
        Me.VGenGroupBox.ResumeLayout(False)
        Me.VGenGroupBox.PerformLayout()
        Me.OutputsGroupBox.ResumeLayout(False)
        Me.OutputTableLayoutPanel.ResumeLayout(False)
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.PeakRMSGroupBox.ResumeLayout(False)
        Me.PeakRMSGroupBox.PerformLayout()
        Me.PolarRectangleGroupBox.ResumeLayout(False)
        Me.PolarRectangleGroupBox.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        CType(Me.SchematicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputsGroupBox As GroupBox
    Friend WithEvents VGenGroupBox As GroupBox
    Friend WithEvents VGenTextBox As TextBox
    Friend WithEvents VGenComboBox As ComboBox
    Friend WithEvents RGenGroupBox As GroupBox
    Friend WithEvents RGenComboBox As ComboBox
    Friend WithEvents RGenTextBox As TextBox
    Friend WithEvents R1GroupBox As GroupBox
    Friend WithEvents R1ComboBox As ComboBox
    Friend WithEvents R1TextBox As TextBox
    Friend WithEvents C1GroupBox As GroupBox
    Friend WithEvents C1ComboBox As ComboBox
    Friend WithEvents C1TextBox As TextBox
    Friend WithEvents L1GroupBox As GroupBox
    Friend WithEvents L1ComboBox As ComboBox
    Friend WithEvents L1TextBox As TextBox
    Friend WithEvents C2GroupBox As GroupBox
    Friend WithEvents C2ComboBox As ComboBox
    Friend WithEvents C2TextBox As TextBox
    Friend WithEvents OutputsGroupBox As GroupBox
    Friend WithEvents ComponentLabel As Label
    Friend WithEvents OutputTableLayoutPanel As TableLayoutPanel
    Friend WithEvents ImpedanceLabel As Label
    Friend WithEvents VoltageLabel As Label
    Friend WithEvents CurrentLabel As Label
    Friend WithEvents PowerLabel As Label
    Friend WithEvents RGenLabel As Label
    Friend WithEvents RGenCurrentLabel As Label
    Friend WithEvents RGenVoltageLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents R1Label As Label
    Friend WithEvents C1Label As Label
    Friend WithEvents C2Label As Label
    Friend WithEvents L1Label As Label
    Friend WithEvents RGenImpedanceLabel As Label
    Friend WithEvents RGenPowerLabel As Label
    Friend WithEvents TotalVoltageLabel As Label
    Friend WithEvents TotalImpedanceLabel As Label
    Friend WithEvents RWGroupBox As GroupBox
    Friend WithEvents RWComboBox As ComboBox
    Friend WithEvents RWTextBox As TextBox
    Friend WithEvents L1PowerLabel As Label
    Friend WithEvents L1CurrentLabel As Label
    Friend WithEvents L1VoltageLabel As Label
    Friend WithEvents L1ImpedanceLabel As Label
    Friend WithEvents C2PowerLabel As Label
    Friend WithEvents C2CurrentLabel As Label
    Friend WithEvents C2VoltageLabel As Label
    Friend WithEvents C2ImpedanceLabel As Label
    Friend WithEvents C1PowerLabel As Label
    Friend WithEvents C1CurrentLabel As Label
    Friend WithEvents C1VoltageLabel As Label
    Friend WithEvents C1ImpedanceLabel As Label
    Friend WithEvents R1PowerLabel As Label
    Friend WithEvents R1CurrentLabel As Label
    Friend WithEvents R1VoltageLabel As Label
    Friend WithEvents R1ImpedanceLabel As Label
    Friend WithEvents TotalPowerLabel As Label
    Friend WithEvents TotalCurrentLabel As Label
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents PolarRectangleGroupBox As GroupBox
    Friend WithEvents PolarRadioButton As RadioButton
    Friend WithEvents CalculateButton As Button
    Friend WithEvents PeakRMSGroupBox As GroupBox
    Friend WithEvents RMSRadioButton As RadioButton
    Friend WithEvents PeakRadioButton As RadioButton
    Friend WithEvents RectangularRadioButton As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateTopMenuItem As ToolStripMenuItem
    Friend WithEvents ResetTopMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryTopToolStripSeparator As ToolStripSeparator
    Friend WithEvents HistoryTopMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopToolStripSeparator As ToolStripSeparator
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents CalculateContextMenuItem As ToolStripMenuItem
    Friend WithEvents ResetContextMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryContextToolStripSeparator As ToolStripSeparator
    Friend WithEvents HistoryContextMenuItem As ToolStripMenuItem
    Friend WithEvents AboutContextToolStripSeparator As ToolStripSeparator
    Friend WithEvents AboutContextMenuItem As ToolStripMenuItem
    Friend WithEvents ExitContextMenuItem As ToolStripMenuItem
    Friend WithEvents FrequencyGroupBox As GroupBox
    Friend WithEvents FrequencyComboBox As ComboBox
    Friend WithEvents FrequencyTextBox As TextBox
    Friend WithEvents SchematicPictureBox As PictureBox
    Friend WithEvents ToolTip As ToolTip
End Class
