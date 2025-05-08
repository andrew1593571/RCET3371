'Andrew Keller
'RCET3371
'Spring 2025
'Better Etch-A-Sketch
'https://github.com/andrew1593571/RCET3371.git
'Modified from Fall 2024 RCET2265 Repo
'https://github.com/andrew1593571/ComputerFundamentals.git

Public Class AboutForm
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.Close()
        DataLoggerForm.Show()
    End Sub

End Class