<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOfWarForm
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
        Me.TablePictureBox = New System.Windows.Forms.PictureBox()
        Me.PlayerControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.PlayerOneGroupBox = New System.Windows.Forms.GroupBox()
        Me.PlayerOneRoundsWonLabel = New System.Windows.Forms.Label()
        Me.PlayerOneLastCardLabel = New System.Windows.Forms.Label()
        Me.PlayerOneRemainingLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoGroupBox = New System.Windows.Forms.GroupBox()
        Me.PlayerTwoRoundsWonLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoLastCardLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoRemainingLabel = New System.Windows.Forms.Label()
        Me.GameGroupBox = New System.Windows.Forms.GroupBox()
        Me.LastWinnerLabel = New System.Windows.Forms.Label()
        Me.RoundsLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.TablePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerControlsGroupBox.SuspendLayout()
        Me.PlayerOneGroupBox.SuspendLayout()
        Me.PlayerTwoGroupBox.SuspendLayout()
        Me.GameGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TablePictureBox
        '
        Me.TablePictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablePictureBox.Location = New System.Drawing.Point(12, 76)
        Me.TablePictureBox.Name = "TablePictureBox"
        Me.TablePictureBox.Size = New System.Drawing.Size(632, 461)
        Me.TablePictureBox.TabIndex = 0
        Me.TablePictureBox.TabStop = False
        '
        'PlayerControlsGroupBox
        '
        Me.PlayerControlsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.PlayerControlsGroupBox.Controls.Add(Me.PlayButton)
        Me.PlayerControlsGroupBox.Controls.Add(Me.StartButton)
        Me.PlayerControlsGroupBox.Location = New System.Drawing.Point(352, 543)
        Me.PlayerControlsGroupBox.Name = "PlayerControlsGroupBox"
        Me.PlayerControlsGroupBox.Size = New System.Drawing.Size(292, 71)
        Me.PlayerControlsGroupBox.TabIndex = 1
        Me.PlayerControlsGroupBox.TabStop = False
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(6, 19)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(88, 39)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "&Play Round"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(100, 19)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(88, 39)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "&Start Game"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'PlayerOneGroupBox
        '
        Me.PlayerOneGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlayerOneGroupBox.Controls.Add(Me.PlayerOneRoundsWonLabel)
        Me.PlayerOneGroupBox.Controls.Add(Me.PlayerOneLastCardLabel)
        Me.PlayerOneGroupBox.Controls.Add(Me.PlayerOneRemainingLabel)
        Me.PlayerOneGroupBox.Location = New System.Drawing.Point(12, 543)
        Me.PlayerOneGroupBox.Name = "PlayerOneGroupBox"
        Me.PlayerOneGroupBox.Size = New System.Drawing.Size(163, 71)
        Me.PlayerOneGroupBox.TabIndex = 2
        Me.PlayerOneGroupBox.TabStop = False
        Me.PlayerOneGroupBox.Text = "Player One"
        '
        'PlayerOneRoundsWonLabel
        '
        Me.PlayerOneRoundsWonLabel.AutoSize = True
        Me.PlayerOneRoundsWonLabel.Location = New System.Drawing.Point(6, 48)
        Me.PlayerOneRoundsWonLabel.Name = "PlayerOneRoundsWonLabel"
        Me.PlayerOneRoundsWonLabel.Size = New System.Drawing.Size(82, 13)
        Me.PlayerOneRoundsWonLabel.TabIndex = 2
        Me.PlayerOneRoundsWonLabel.Text = "Rounds Won: 0"
        '
        'PlayerOneLastCardLabel
        '
        Me.PlayerOneLastCardLabel.AutoSize = True
        Me.PlayerOneLastCardLabel.Location = New System.Drawing.Point(6, 32)
        Me.PlayerOneLastCardLabel.Name = "PlayerOneLastCardLabel"
        Me.PlayerOneLastCardLabel.Size = New System.Drawing.Size(61, 13)
        Me.PlayerOneLastCardLabel.TabIndex = 1
        Me.PlayerOneLastCardLabel.Text = "Last Card: -"
        '
        'PlayerOneRemainingLabel
        '
        Me.PlayerOneRemainingLabel.AutoSize = True
        Me.PlayerOneRemainingLabel.Location = New System.Drawing.Point(6, 16)
        Me.PlayerOneRemainingLabel.Name = "PlayerOneRemainingLabel"
        Me.PlayerOneRemainingLabel.Size = New System.Drawing.Size(99, 13)
        Me.PlayerOneRemainingLabel.TabIndex = 0
        Me.PlayerOneRemainingLabel.Text = "Remaining: 0 Cards"
        '
        'PlayerTwoGroupBox
        '
        Me.PlayerTwoGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlayerTwoGroupBox.Controls.Add(Me.PlayerTwoRoundsWonLabel)
        Me.PlayerTwoGroupBox.Controls.Add(Me.PlayerTwoLastCardLabel)
        Me.PlayerTwoGroupBox.Controls.Add(Me.PlayerTwoRemainingLabel)
        Me.PlayerTwoGroupBox.Location = New System.Drawing.Point(181, 543)
        Me.PlayerTwoGroupBox.Name = "PlayerTwoGroupBox"
        Me.PlayerTwoGroupBox.Size = New System.Drawing.Size(163, 71)
        Me.PlayerTwoGroupBox.TabIndex = 3
        Me.PlayerTwoGroupBox.TabStop = False
        Me.PlayerTwoGroupBox.Text = "Player Two"
        '
        'PlayerTwoRoundsWonLabel
        '
        Me.PlayerTwoRoundsWonLabel.AutoSize = True
        Me.PlayerTwoRoundsWonLabel.Location = New System.Drawing.Point(6, 48)
        Me.PlayerTwoRoundsWonLabel.Name = "PlayerTwoRoundsWonLabel"
        Me.PlayerTwoRoundsWonLabel.Size = New System.Drawing.Size(82, 13)
        Me.PlayerTwoRoundsWonLabel.TabIndex = 2
        Me.PlayerTwoRoundsWonLabel.Text = "Rounds Won: 0"
        '
        'PlayerTwoLastCardLabel
        '
        Me.PlayerTwoLastCardLabel.AutoSize = True
        Me.PlayerTwoLastCardLabel.Location = New System.Drawing.Point(6, 32)
        Me.PlayerTwoLastCardLabel.Name = "PlayerTwoLastCardLabel"
        Me.PlayerTwoLastCardLabel.Size = New System.Drawing.Size(61, 13)
        Me.PlayerTwoLastCardLabel.TabIndex = 1
        Me.PlayerTwoLastCardLabel.Text = "Last Card: -"
        '
        'PlayerTwoRemainingLabel
        '
        Me.PlayerTwoRemainingLabel.AutoSize = True
        Me.PlayerTwoRemainingLabel.Location = New System.Drawing.Point(6, 16)
        Me.PlayerTwoRemainingLabel.Name = "PlayerTwoRemainingLabel"
        Me.PlayerTwoRemainingLabel.Size = New System.Drawing.Size(99, 13)
        Me.PlayerTwoRemainingLabel.TabIndex = 0
        Me.PlayerTwoRemainingLabel.Text = "Remaining: 0 Cards"
        '
        'GameGroupBox
        '
        Me.GameGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameGroupBox.Controls.Add(Me.LastWinnerLabel)
        Me.GameGroupBox.Controls.Add(Me.RoundsLabel)
        Me.GameGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GameGroupBox.Name = "GameGroupBox"
        Me.GameGroupBox.Size = New System.Drawing.Size(632, 58)
        Me.GameGroupBox.TabIndex = 4
        Me.GameGroupBox.TabStop = False
        '
        'LastWinnerLabel
        '
        Me.LastWinnerLabel.AutoSize = True
        Me.LastWinnerLabel.Location = New System.Drawing.Point(6, 32)
        Me.LastWinnerLabel.Name = "LastWinnerLabel"
        Me.LastWinnerLabel.Size = New System.Drawing.Size(108, 13)
        Me.LastWinnerLabel.TabIndex = 1
        Me.LastWinnerLabel.Text = "Last Round Winner: -"
        '
        'RoundsLabel
        '
        Me.RoundsLabel.AutoSize = True
        Me.RoundsLabel.Location = New System.Drawing.Point(6, 16)
        Me.RoundsLabel.Name = "RoundsLabel"
        Me.RoundsLabel.Size = New System.Drawing.Size(91, 13)
        Me.RoundsLabel.TabIndex = 0
        Me.RoundsLabel.Text = "Rounds Played: 0"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(194, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 39)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GameOfWarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 626)
        Me.Controls.Add(Me.GameGroupBox)
        Me.Controls.Add(Me.PlayerTwoGroupBox)
        Me.Controls.Add(Me.PlayerOneGroupBox)
        Me.Controls.Add(Me.PlayerControlsGroupBox)
        Me.Controls.Add(Me.TablePictureBox)
        Me.Name = "GameOfWarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of War"
        CType(Me.TablePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayerControlsGroupBox.ResumeLayout(False)
        Me.PlayerOneGroupBox.ResumeLayout(False)
        Me.PlayerOneGroupBox.PerformLayout()
        Me.PlayerTwoGroupBox.ResumeLayout(False)
        Me.PlayerTwoGroupBox.PerformLayout()
        Me.GameGroupBox.ResumeLayout(False)
        Me.GameGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablePictureBox As PictureBox
    Friend WithEvents PlayerControlsGroupBox As GroupBox
    Friend WithEvents PlayButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents PlayerOneGroupBox As GroupBox
    Friend WithEvents PlayerOneRoundsWonLabel As Label
    Friend WithEvents PlayerOneLastCardLabel As Label
    Friend WithEvents PlayerOneRemainingLabel As Label
    Friend WithEvents PlayerTwoGroupBox As GroupBox
    Friend WithEvents PlayerTwoRoundsWonLabel As Label
    Friend WithEvents PlayerTwoLastCardLabel As Label
    Friend WithEvents PlayerTwoRemainingLabel As Label
    Friend WithEvents GameGroupBox As GroupBox
    Friend WithEvents LastWinnerLabel As Label
    Friend WithEvents RoundsLabel As Label
    Friend WithEvents ExitButton As Button
End Class
