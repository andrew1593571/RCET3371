﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicsForm
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
        Me.DrawPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.CoordinatesStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PlotTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawPictureBox
        '
        Me.DrawPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DrawPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DrawPictureBox.Name = "DrawPictureBox"
        Me.DrawPictureBox.Size = New System.Drawing.Size(471, 258)
        Me.DrawPictureBox.TabIndex = 0
        Me.DrawPictureBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(386, 276)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(97, 38)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(283, 276)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(97, 38)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(180, 276)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(97, 38)
        Me.DrawButton.TabIndex = 3
        Me.DrawButton.Text = "&Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoordinatesStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 322)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(495, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'CoordinatesStatusLabel
        '
        Me.CoordinatesStatusLabel.Name = "CoordinatesStatusLabel"
        Me.CoordinatesStatusLabel.Size = New System.Drawing.Size(29, 17)
        Me.CoordinatesStatusLabel.Text = "(x,y)"
        '
        'PlotTimer
        '
        Me.PlotTimer.Enabled = True
        Me.PlotTimer.Interval = 10
        '
        'GraphicsForm
        '
        Me.AcceptButton = Me.DrawButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(495, 344)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DrawPictureBox)
        Me.Name = "GraphicsForm"
        Me.Text = "Graphics!"
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DrawButton As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents CoordinatesStatusLabel As ToolStripStatusLabel
    Friend WithEvents PlotTimer As Timer
End Class
