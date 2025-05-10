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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.COMPortSplitButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.COMPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectDisconnectMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPortRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.COMStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(776, 381)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'COMPortRefreshTimer
        '
        Me.COMPortRefreshTimer.Interval = 1000
        '
        'COMStatusLabel
        '
        Me.COMStatusLabel.Name = "COMStatusLabel"
        Me.COMStatusLabel.Size = New System.Drawing.Size(145, 17)
        Me.COMStatusLabel.Text = "Disconnected from COM1"
        '
        'FinalProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FinalProgram"
        Me.Text = "Form1"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents COMPortSplitButton As ToolStripSplitButton
    Friend WithEvents COMPortComboBox As ToolStripComboBox
    Friend WithEvents ConnectDisconnectMenuItem As ToolStripMenuItem
    Friend WithEvents COMPortRefreshTimer As Timer
    Friend WithEvents COMStatusLabel As ToolStripStatusLabel
End Class
