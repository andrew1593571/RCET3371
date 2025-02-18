<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DartGameForm
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
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewHistoryContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHistoryTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnGroupBox = New System.Windows.Forms.GroupBox()
        Me.DartTotalLabel = New System.Windows.Forms.Label()
        Me.DartOfLabel = New System.Windows.Forms.Label()
        Me.DartNumberLabel = New System.Windows.Forms.Label()
        Me.DartLabel = New System.Windows.Forms.Label()
        Me.TurnNumberLabel = New System.Windows.Forms.Label()
        Me.TurnLabel = New System.Windows.Forms.Label()
        Me.ThrowButton = New System.Windows.Forms.Button()
        Me.BoardPictureBox = New System.Windows.Forms.PictureBox()
        Me.TopMenuStrip.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.TurnGroupBox.SuspendLayout()
        CType(Me.BoardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ContextMenuStrip = Me.ContextMenuStrip
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(722, 24)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHistoryContextMenuItem, Me.AboutContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(181, 70)
        '
        'ViewHistoryContextMenuItem
        '
        Me.ViewHistoryContextMenuItem.Name = "ViewHistoryContextMenuItem"
        Me.ViewHistoryContextMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewHistoryContextMenuItem.Text = "&View History"
        '
        'AboutContextMenuItem
        '
        Me.AboutContextMenuItem.Name = "AboutContextMenuItem"
        Me.AboutContextMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutContextMenuItem.Text = "&About"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHistoryTopMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'ViewHistoryTopMenuItem
        '
        Me.ViewHistoryTopMenuItem.Name = "ViewHistoryTopMenuItem"
        Me.ViewHistoryTopMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ViewHistoryTopMenuItem.Text = "&View History"
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
        Me.TurnGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.TurnGroupBox.Controls.Add(Me.DartTotalLabel)
        Me.TurnGroupBox.Controls.Add(Me.DartOfLabel)
        Me.TurnGroupBox.Controls.Add(Me.DartNumberLabel)
        Me.TurnGroupBox.Controls.Add(Me.DartLabel)
        Me.TurnGroupBox.Controls.Add(Me.TurnNumberLabel)
        Me.TurnGroupBox.Controls.Add(Me.TurnLabel)
        Me.TurnGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.TurnGroupBox.Name = "TurnGroupBox"
        Me.TurnGroupBox.Size = New System.Drawing.Size(192, 80)
        Me.TurnGroupBox.TabIndex = 2
        Me.TurnGroupBox.TabStop = False
        '
        'DartTotalLabel
        '
        Me.DartTotalLabel.ContextMenuStrip = Me.ContextMenuStrip
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
        Me.DartOfLabel.ContextMenuStrip = Me.ContextMenuStrip
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
        Me.DartNumberLabel.ContextMenuStrip = Me.ContextMenuStrip
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
        Me.DartLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.DartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DartLabel.Location = New System.Drawing.Point(6, 39)
        Me.DartLabel.Name = "DartLabel"
        Me.DartLabel.Size = New System.Drawing.Size(48, 23)
        Me.DartLabel.TabIndex = 7
        Me.DartLabel.Text = "Dart: "
        Me.DartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TurnNumberLabel
        '
        Me.TurnNumberLabel.ContextMenuStrip = Me.ContextMenuStrip
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
        Me.TurnLabel.ContextMenuStrip = Me.ContextMenuStrip
        Me.TurnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnLabel.Location = New System.Drawing.Point(6, 16)
        Me.TurnLabel.Name = "TurnLabel"
        Me.TurnLabel.Size = New System.Drawing.Size(48, 23)
        Me.TurnLabel.TabIndex = 3
        Me.TurnLabel.Text = "Turn: "
        Me.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ThrowButton
        '
        Me.ThrowButton.ContextMenuStrip = Me.ContextMenuStrip
        Me.ThrowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowButton.Location = New System.Drawing.Point(12, 321)
        Me.ThrowButton.Name = "ThrowButton"
        Me.ThrowButton.Size = New System.Drawing.Size(183, 81)
        Me.ThrowButton.TabIndex = 0
        Me.ThrowButton.Text = "&Throw"
        Me.ThrowButton.UseVisualStyleBackColor = True
        '
        'BoardPictureBox
        '
        Me.BoardPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoardPictureBox.BackgroundImage = Global.DartGame.My.Resources.Resources.dartboard
        Me.BoardPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BoardPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.BoardPictureBox.Location = New System.Drawing.Point(210, 27)
        Me.BoardPictureBox.Name = "BoardPictureBox"
        Me.BoardPictureBox.Size = New System.Drawing.Size(500, 375)
        Me.BoardPictureBox.TabIndex = 1
        Me.BoardPictureBox.TabStop = False
        '
        'DartGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 418)
        Me.Controls.Add(Me.ThrowButton)
        Me.Controls.Add(Me.TurnGroupBox)
        Me.Controls.Add(Me.BoardPictureBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "DartGameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dart Game"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.TurnGroupBox.ResumeLayout(False)
        CType(Me.BoardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHistoryTopMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHistoryContextMenuItem As ToolStripMenuItem
    Friend WithEvents AboutContextMenuItem As ToolStripMenuItem
    Friend WithEvents BoardPictureBox As PictureBox
    Friend WithEvents TurnGroupBox As GroupBox
    Friend WithEvents TurnLabel As Label
    Friend WithEvents DartTotalLabel As Label
    Friend WithEvents DartOfLabel As Label
    Friend WithEvents DartNumberLabel As Label
    Friend WithEvents DartLabel As Label
    Friend WithEvents TurnNumberLabel As Label
    Friend WithEvents ThrowButton As Button
End Class
