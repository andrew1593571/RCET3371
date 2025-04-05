Option Strict On
Option Explicit On
Option Compare Text

'Andrew Keller
'RCET3371
'Spring 2025
'Circuit Solver
'https://github.com/andrew1593571/RCET3371.git

Public Class CircuitSolverForm

    Function ConvertInputs() As Double()
        Dim _inputs(7) As Double '0 is frequency, 1 is Vgen, 2 is Rgen, 3 is R1, 4 is C1, 5 is C2, 6 is L1, 7 is Rw
        Dim convertError As Boolean
        Dim errorMessage As String = ""

        'convert frequency
        If FrequencyTextBox.Text = "" Then
            convertError = True
            errorMessage &= "Frequency" & vbNewLine
        Else
            Try
                Select Case FrequencyComboBox.SelectedIndex
                    Case 0 'Hz
                        _inputs(0) = CDbl(FrequencyTextBox.Text)
                    Case 1 'KHz
                        _inputs(0) = CDbl(FrequencyTextBox.Text) * (10 ^ 3)
                    Case 2 'MHz
                        _inputs(0) = CDbl(FrequencyTextBox.Text) * (10 ^ 6)
                    Case 3 'GHz
                        _inputs(0) = CDbl(FrequencyTextBox.Text) * (10 ^ 9)
                End Select
            Catch ex As Exception 'if frequency does not convert correctly
                convertError = True
                errorMessage &= "Frequency" & vbNewLine
            End Try
        End If

        'convert Vgen
        If VGenTextBox.Text = "" Then
            convertError = True
            errorMessage &= "Vgen" & vbNewLine
        Else
            Try
                Select Case VGenComboBox.SelectedIndex
                    Case 3 '"V"
                        _inputs(1) = CDbl(VGenTextBox.Text) / 0.707
                    Case 2 '"mV"
                        _inputs(1) = (CDbl(VGenTextBox.Text) * (10 ^ -3)) / 0.707
                    Case 1 '"Vp"
                        _inputs(1) = CDbl(VGenTextBox.Text)
                    Case 0 '"mVp"
                        _inputs(1) = CDbl(VGenTextBox.Text) * (10 ^ -3)
                End Select
            Catch ex As Exception 'if Vgen does not convert correctly
                convertError = True
                errorMessage &= "Vgen" & vbNewLine
            End Try
        End If

        'convert Rgen
        If RGenTextBox.Text = "" Then
            convertError = True
            errorMessage &= "Rgen" & vbNewLine
        Else
            Try
                Select Case RGenComboBox.SelectedIndex
                    Case 0 '"mΩ"
                        _inputs(2) = CDbl(RGenTextBox.Text) * (10 ^ -3)
                    Case 1 '"Ω"
                        _inputs(2) = CDbl(RGenTextBox.Text)
                    Case 2 '"kΩ"
                        _inputs(2) = CDbl(RGenTextBox.Text) * (10 ^ 3)
                    Case 3 '"MΩ"
                        _inputs(2) = CDbl(RGenTextBox.Text) * (10 ^ 6)
                End Select
            Catch ex As Exception 'if Rgen does not convert correctly
                convertError = True
                errorMessage &= "Rgen" & vbNewLine
            End Try
        End If

        'convert R1
        If R1TextBox.Text = "" Then
            convertError = True
            errorMessage &= "R1" & vbNewLine
        Else
            Try
                Select Case R1ComboBox.SelectedIndex
                    Case 0 '"mΩ"
                        _inputs(3) = CDbl(R1TextBox.Text) * (10 ^ -3)
                    Case 1 '"Ω"
                        _inputs(3) = CDbl(R1TextBox.Text)
                    Case 2 '"kΩ"
                        _inputs(3) = CDbl(R1TextBox.Text) * (10 ^ 3)
                    Case 3 '"MΩ"
                        _inputs(3) = CDbl(R1TextBox.Text) * (10 ^ 6)
                End Select
            Catch ex As Exception 'if R1 does not convert correctly
                convertError = True
                errorMessage &= "R1" & vbNewLine
            End Try
        End If

        'convert C1
        If C1TextBox.Text = "" Then
            convertError = True
            errorMessage &= "C1" & vbNewLine
        Else
            Try
                Select Case C1ComboBox.SelectedIndex
                    Case 0 '"F"
                        _inputs(4) = CDbl(C1TextBox.Text)
                    Case 1 '"mF"
                        _inputs(4) = CDbl(C1TextBox.Text) * (10 ^ -3)
                    Case 2 '"µF"
                        _inputs(4) = CDbl(C1TextBox.Text) * (10 ^ -6)
                    Case 3 '"nF"
                        _inputs(4) = CDbl(C1TextBox.Text) * (10 ^ -9)
                    Case 4 '"pF"
                        _inputs(4) = CDbl(C1TextBox.Text) * (10 ^ -12)
                End Select
            Catch ex As Exception 'if C1 does not convert correctly
                convertError = True
                errorMessage &= "C1" & vbNewLine
            End Try
        End If

        'convert C2
        If C2TextBox.Text = "" Then
            convertError = True
            errorMessage &= "C2" & vbNewLine
        Else
            Try
                Select Case C2ComboBox.SelectedIndex
                    Case 0 '"F"
                        _inputs(5) = CDbl(C2TextBox.Text)
                    Case 1 '"mF"
                        _inputs(5) = CDbl(C2TextBox.Text) * (10 ^ -3)
                    Case 2 '"µF"
                        _inputs(5) = CDbl(C2TextBox.Text) * (10 ^ -6)
                    Case 3 '"nF"
                        _inputs(5) = CDbl(C2TextBox.Text) * (10 ^ -9)
                    Case 4 '"pF"
                        _inputs(5) = CDbl(C2TextBox.Text) * (10 ^ -12)
                End Select
            Catch ex As Exception 'if C2 does not convert correctly
                convertError = True
                errorMessage &= "C2" & vbNewLine
            End Try
        End If

        'convert L1
        If L1TextBox.Text = "" Then
            convertError = True
            errorMessage &= "L1" & vbNewLine
        Else
            Try
                Select Case L1ComboBox.SelectedIndex
                    Case 0 '"H"
                        _inputs(6) = CDbl(L1TextBox.Text)
                    Case 1 '"mH"
                        _inputs(6) = CDbl(L1TextBox.Text) * (10 ^ -3)
                    Case 2 '"µH"
                        _inputs(6) = CDbl(L1TextBox.Text) * (10 ^ -6)
                    Case 3 '"nH"
                        _inputs(6) = CDbl(L1TextBox.Text) * (10 ^ -9)
                    Case 4 '"pH"
                        _inputs(6) = CDbl(L1TextBox.Text) * (10 ^ -12)
                End Select
            Catch ex As Exception 'if L1 does not convert correctly
                convertError = True
                errorMessage &= "L1" & vbNewLine
            End Try
        End If

        'convert Rwinding
        If RWTextBox.Text = "" Then
            convertError = True
            errorMessage &= "L1 Winding" & vbNewLine
        Else
            Try
                Select Case RWComboBox.SelectedIndex
                    Case 0 '"mΩ"
                        _inputs(7) = CDbl(RWTextBox.Text) * (10 ^ -3)
                    Case 1 '"Ω"
                        _inputs(7) = CDbl(RWTextBox.Text)
                    Case 2 '"kΩ"
                        _inputs(7) = CDbl(RWTextBox.Text) * (10 ^ 3)
                    Case 3 '"MΩ"
                        _inputs(7) = CDbl(RWTextBox.Text) * (10 ^ 6)
                End Select
            Catch ex As Exception 'if Rwinding does not convert correctly
                convertError = True
                errorMessage &= "L1 Winding" & vbNewLine
            End Try
        End If

        'if any of the inputs have errors, display error and return nothing
        If convertError Then
            MsgBox("The below inputs do not contain a number:" & vbNewLine & errorMessage)
            Return Nothing
            Exit Function
        Else
            Return _inputs
        End If

    End Function

    Sub calculateValues(_inputs() As Double)

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim inputs(7) As Double '0 is frequency, 1 is Vgen, 2 is Rgen, 3 is R1, 4 is C1, 5 is C2, 6 is L1, 7 is Rw
        Dim ZCTwo(1) As Double '0 is impedance, 1 is angle

        'convert the inputs
        inputs = ConvertInputs()
        'if the ConvertInputs returned nothing, exit the sub
        If inputs Is Nothing Then
            Exit Sub
        End If
        MsgBox(inputs(0))

        ZCTwo(0) = 1 / (2 * Math.PI * inputs(5) * inputs(0))
        ZCTwo(1) = -90
    End Sub

    Private Sub CircuitSolverForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set the default input units
        FrequencyComboBox.SelectedIndex = 0
        VGenComboBox.SelectedIndex = 1
        RGenComboBox.SelectedIndex = 1
        R1ComboBox.SelectedIndex = 1
        RWComboBox.SelectedIndex = 1
        C1ComboBox.SelectedIndex = 2
        C2ComboBox.SelectedIndex = 2
        L1ComboBox.SelectedIndex = 1
    End Sub
End Class
