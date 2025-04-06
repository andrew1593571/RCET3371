Option Strict On
Option Explicit On
Option Compare Text

'Andrew Keller
'RCET3371
'Spring 2025
'Circuit Solver
'https://github.com/andrew1593571/RCET3371.git

Public Class CircuitSolverForm
    ''' <summary>
    ''' verifies and converts all of the input textboxes to an array of doubles. Returns array.
    ''' 0 is frequency, 1 is Vgen, 2 is Rgen, 3 is R1, 4 is C1, 5 is C2, 6 is L1, 7 is Rw
    ''' </summary>
    ''' <returns></returns>
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

    ''' <summary>
    ''' converts radians into degrees
    ''' </summary>
    ''' <param name="rad"></param>
    ''' <returns></returns>
    Function RadToDeg(rad As Double) As Double
        Return rad * (180 / Math.PI)
    End Function

    Function DegToRad(Deg As Double) As Double
        Return Deg * (Math.PI / 180)
    End Function

    ''' <summary>
    ''' Returns an array with the real and imaginary components in an array.
    ''' 0 is real, 1 is imaginary
    ''' angle is in radians.
    ''' </summary>
    ''' <param name="magnitude"></param>
    ''' <param name="angle"></param>
    ''' <returns></returns>
    Function PolarToRectangle(magnitude As Double, angle As Double) As Double()
        Dim _rectangular(1) As Double
        _rectangular(0) = magnitude * Math.Cos(angle) 'real component
        _rectangular(1) = magnitude * Math.Sin(angle) 'imaginary component
        Return _rectangular
    End Function

    ''' <summary>
    ''' Returns an array with the magnitude and angle in radians
    ''' 0 is magnitude, 1 is angle
    ''' </summary>
    ''' <param name="real"></param>
    ''' <param name="imaginary"></param>
    ''' <returns></returns>
    Function RectangleToPolar(real As Double, imaginary As Double) As Double()
        Dim _polar(1) As Double
        _polar(0) = Math.Sqrt((real ^ 2) + (imaginary ^ 2))
        _polar(1) = Math.Atan(imaginary / real)
        Return _polar
    End Function

    ''' <summary>
    ''' Adds x and y together as polar numbers. Returns and array.
    ''' 0 is real, 1 is imaginary
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Function AddPolar(x() As Double, y() As Double) As Double()
        Dim sumPolar(1) As Double
        Dim sumRectangle(1) As Double
        Dim xRectangle(1) As Double
        Dim yRectangle(1) As Double

        'Convert both x and y to rectangle
        xRectangle = PolarToRectangle(x(0), x(1))
        yRectangle = PolarToRectangle(y(0), y(1))

        'add the rectangle forms together
        sumRectangle(0) = xRectangle(0) + yRectangle(0)
        sumRectangle(1) = xRectangle(1) + yRectangle(1)

        'convert the sum to polar
        sumPolar = RectangleToPolar(sumRectangle(0), sumRectangle(1))
        Return sumPolar
    End Function

    ''' <summary>
    ''' Returns a human-readable string of the polar voltage value.
    ''' Handles Polar vs rectangular, RMS vs peak
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function CreateVoltageString(value() As Double) As String
        Dim voltage As Double
        Dim designator As String

        If RMSRadioButton.Checked Then
            voltage = value(0) * 0.707
            designator = "V"
        Else
            voltage = value(0)
            designator = "Vp"
        End If

    End Function

    Sub calculateValues()
        Dim inputs(7) As Double '0 is frequency, 1 is Vgen, 2 is Rgen, 3 is R1, 4 is C1, 5 is C2, 6 is L1, 7 is Rw
        Dim ZCOne(1) As Double '0 is impedance, 1 is angle
        Dim ZCTwo(1) As Double '0 is impedance, 1 is angle
        Dim ZLOne(1) As Double '0 is impedance, 1 is angle
        Dim ZParallel(1) As Double
        Dim ZSeries(1) As Double
        Dim ROneRGen(1) As Double
        Dim ZTotal(1) As Double
        Dim ITotal(1) As Double
        Dim VParallel(1) As Double

        'NOTE: ALL ANGLES ARE IN RADIANS UNTIL CONVERTED FOR DISPLAY

        'convert the inputs
        inputs = ConvertInputs()
        'if the ConvertInputs returned nothing, exit the sub
        If inputs Is Nothing Then
            Exit Sub
        End If

        'C1 impedance
        ZCOne(0) = 1 / (2 * Math.PI * inputs(4) * inputs(0))
        ZCOne(1) = DegToRad(-90)

        'C2 impedance
        ZCTwo(0) = 1 / (2 * Math.PI * inputs(5) * inputs(0))
        ZCTwo(1) = DegToRad(-90)

        ROneRGen(0) = inputs(2) + inputs(3)
        ROneRGen(1) = 0

        'L1 impedance
        ZLOne = RectangleToPolar(inputs(7), 2 * Math.PI * inputs(0) * inputs(6))

        'Parallel impedance
        ZParallel(0) = (ZLOne(0) * ZCTwo(0)) / (AddPolar(ZLOne, ZCTwo)(0))
        ZParallel(1) = (ZLOne(1) + ZCTwo(1)) - AddPolar(ZLOne, ZCTwo)(1)

        'series impedance, Rgen+R1+C1
        ZSeries = AddPolar(ROneRGen, ZCOne)
        ZTotal = AddPolar(ZSeries, ZParallel)

        'total current
        ITotal(0) = inputs(1) / ZTotal(0)
        ITotal(1) = 0 - ZTotal(1)

        MsgBox(ITotal(0) & vbNewLine & RadToDeg(ITotal(1)))

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        calculateValues()
    End Sub

    Private Sub CircuitSolverForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set the default input units
        FrequencyComboBox.SelectedIndex = 1
        VGenComboBox.SelectedIndex = 1
        RGenComboBox.SelectedIndex = 1
        R1ComboBox.SelectedIndex = 1
        RWComboBox.SelectedIndex = 2
        C1ComboBox.SelectedIndex = 2
        C2ComboBox.SelectedIndex = 2
        L1ComboBox.SelectedIndex = 0

        FrequencyTextBox.Text = "5"
        VGenTextBox.Text = "5"
        RGenTextBox.Text = "5"
        R1TextBox.Text = "5"
        RWTextBox.Text = "500"
        C1TextBox.Text = "5"
        C2TextBox.Text = "5"
        L1TextBox.Text = "5"
    End Sub
End Class
