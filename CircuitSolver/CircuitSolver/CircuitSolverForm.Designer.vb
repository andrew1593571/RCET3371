<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircuitSolverForm
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
        Me.VoltagesGroupBox = New System.Windows.Forms.GroupBox()
        Me.VoltagesLabel = New System.Windows.Forms.Label()
        Me.VoltagesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'VoltagesGroupBox
        '
        Me.VoltagesGroupBox.Controls.Add(Me.VoltagesLabel)
        Me.VoltagesGroupBox.Location = New System.Drawing.Point(192, 217)
        Me.VoltagesGroupBox.Name = "VoltagesGroupBox"
        Me.VoltagesGroupBox.Size = New System.Drawing.Size(200, 155)
        Me.VoltagesGroupBox.TabIndex = 0
        Me.VoltagesGroupBox.TabStop = False
        Me.VoltagesGroupBox.Text = "Voltages"
        '
        'VoltagesLabel
        '
        Me.VoltagesLabel.AutoSize = True
        Me.VoltagesLabel.Location = New System.Drawing.Point(6, 16)
        Me.VoltagesLabel.Name = "VoltagesLabel"
        Me.VoltagesLabel.Size = New System.Drawing.Size(63, 26)
        Me.VoltagesLabel.TabIndex = 0
        Me.VoltagesLabel.Text = "Vgen = __V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vin"
        '
        'CircuitSolverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VoltagesGroupBox)
        Me.Name = "CircuitSolverForm"
        Me.Text = "Circuit Solver"
        Me.VoltagesGroupBox.ResumeLayout(False)
        Me.VoltagesGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VoltagesGroupBox As GroupBox
    Friend WithEvents VoltagesLabel As Label
End Class
