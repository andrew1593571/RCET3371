<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToGameTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnGroupBox = New System.Windows.Forms.GroupBox()
        Me.DartTotalLabel = New System.Windows.Forms.Label()
        Me.DartOfLabel = New System.Windows.Forms.Label()
        Me.DartNumberLabel = New System.Windows.Forms.Label()
        Me.DartLabel = New System.Windows.Forms.Label()
        Me.TotalTurnLabel = New System.Windows.Forms.Label()
        Me.TurnOfLabel = New System.Windows.Forms.Label()
        Me.TurnNumberLabel = New System.Windows.Forms.Label()
        Me.TurnLabel = New System.Windows.Forms.Label()
        Me.BoardPictureBox = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip.SuspendLayout()
        Me.TurnGroupBox.SuspendLayout()
        CType(Me.BoardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(722, 24)
        Me.TopMenuStrip.TabIndex = 1
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToGameTopMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'BackToGameTopMenuItem
        '
        Me.BackToGameTopMenuItem.Name = "BackToGameTopMenuItem"
        Me.BackToGameTopMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.BackToGameTopMenuItem.Text = "&Back to Game"
        Me.BackToGameTopMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
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
        'TurnGroupBox
        '
        Me.TurnGroupBox.Controls.Add(Me.DartTotalLabel)
        Me.TurnGroupBox.Controls.Add(Me.DartOfLabel)
        Me.TurnGroupBox.Controls.Add(Me.DartNumberLabel)
        Me.TurnGroupBox.Controls.Add(Me.DartLabel)
        Me.TurnGroupBox.Controls.Add(Me.TotalTurnLabel)
        Me.TurnGroupBox.Controls.Add(Me.TurnOfLabel)
        Me.TurnGroupBox.Controls.Add(Me.TurnNumberLabel)
        Me.TurnGroupBox.Controls.Add(Me.TurnLabel)
        Me.TurnGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.TurnGroupBox.Name = "TurnGroupBox"
        Me.TurnGroupBox.Size = New System.Drawing.Size(192, 80)
        Me.TurnGroupBox.TabIndex = 3
        Me.TurnGroupBox.TabStop = False
        '
        'DartTotalLabel
        '
        Me.DartTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DartTotalLabel.Location = New System.Drawing.Point(135, 39)
        Me.DartTotalLabel.Name = "DartTotalLabel"
        Me.DartTotalLabel.Size = New System.Drawing.Size(48, 23)
        Me.DartTotalLabel.TabIndex = 10
        Me.DartTotalLabel.Text = "3"
        Me.DartTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DartOfLabel
        '
        Me.DartOfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DartOfLabel.Location = New System.Drawing.Point(103, 39)
        Me.DartOfLabel.Name = "DartOfLabel"
        Me.DartOfLabel.Size = New System.Drawing.Size(26, 23)
        Me.DartOfLabel.TabIndex = 9
        Me.DartOfLabel.Text = "of"
        Me.DartOfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DartNumberLabel
        '
        Me.DartNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DartNumberLabel.Location = New System.Drawing.Point(60, 39)
        Me.DartNumberLabel.Name = "DartNumberLabel"
        Me.DartNumberLabel.Size = New System.Drawing.Size(37, 23)
        Me.DartNumberLabel.TabIndex = 8
        Me.DartNumberLabel.Text = "0"
        Me.DartNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DartLabel
        '
        Me.DartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DartLabel.Location = New System.Drawing.Point(6, 39)
        Me.DartLabel.Name = "DartLabel"
        Me.DartLabel.Size = New System.Drawing.Size(48, 23)
        Me.DartLabel.TabIndex = 7
        Me.DartLabel.Text = "Dart: "
        Me.DartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalTurnLabel
        '
        Me.TotalTurnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTurnLabel.Location = New System.Drawing.Point(135, 16)
        Me.TotalTurnLabel.Name = "TotalTurnLabel"
        Me.TotalTurnLabel.Size = New System.Drawing.Size(48, 23)
        Me.TotalTurnLabel.TabIndex = 6
        Me.TotalTurnLabel.Text = "000"
        Me.TotalTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TurnOfLabel
        '
        Me.TurnOfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnOfLabel.Location = New System.Drawing.Point(103, 16)
        Me.TurnOfLabel.Name = "TurnOfLabel"
        Me.TurnOfLabel.Size = New System.Drawing.Size(26, 23)
        Me.TurnOfLabel.TabIndex = 5
        Me.TurnOfLabel.Text = "of"
        Me.TurnOfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TurnNumberLabel
        '
        Me.TurnNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnNumberLabel.Location = New System.Drawing.Point(60, 16)
        Me.TurnNumberLabel.Name = "TurnNumberLabel"
        Me.TurnNumberLabel.Size = New System.Drawing.Size(37, 23)
        Me.TurnNumberLabel.TabIndex = 4
        Me.TurnNumberLabel.Text = "000"
        Me.TurnNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TurnLabel
        '
        Me.TurnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnLabel.Location = New System.Drawing.Point(6, 16)
        Me.TurnLabel.Name = "TurnLabel"
        Me.TurnLabel.Size = New System.Drawing.Size(48, 23)
        Me.TurnLabel.TabIndex = 3
        Me.TurnLabel.Text = "Turn: "
        Me.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BoardPictureBox
        '
        Me.BoardPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoardPictureBox.BackgroundImage = Global.DartGame.My.Resources.Resources.dartboard
        Me.BoardPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BoardPictureBox.Location = New System.Drawing.Point(210, 27)
        Me.BoardPictureBox.Name = "BoardPictureBox"
        Me.BoardPictureBox.Size = New System.Drawing.Size(500, 375)
        Me.BoardPictureBox.TabIndex = 4
        Me.BoardPictureBox.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(12, 321)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(183, 81)
        Me.BackButton.TabIndex = 5
        Me.BackButton.Text = "&Back To Game"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(12, 234)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(183, 81)
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "&Next Turn"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousButton.Location = New System.Drawing.Point(12, 147)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(183, 81)
        Me.PreviousButton.TabIndex = 7
        Me.PreviousButton.Text = "&Previous Turn"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 418)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.BoardPictureBox)
        Me.Controls.Add(Me.TurnGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Name = "HistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View History"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.TurnGroupBox.ResumeLayout(False)
        CType(Me.BoardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents BackToGameTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents TurnGroupBox As GroupBox
    Friend WithEvents DartTotalLabel As Label
    Friend WithEvents DartOfLabel As Label
    Friend WithEvents DartNumberLabel As Label
    Friend WithEvents DartLabel As Label
    Friend WithEvents TotalTurnLabel As Label
    Friend WithEvents TurnOfLabel As Label
    Friend WithEvents TurnNumberLabel As Label
    Friend WithEvents TurnLabel As Label
    Friend WithEvents BoardPictureBox As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
End Class
