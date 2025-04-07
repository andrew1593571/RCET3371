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
    ''' Multiplies x and y together as polar numbers. Returns an array.
    ''' 0 is real, 1 is imaginary
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Function MultiplyPolar(x() As Double, y() As Double) As Double()
        Dim resultPolar(1) As Double

        resultPolar(0) = x(0) * y(0)
        resultPolar(1) = x(1) + y(1)

        Return resultPolar
    End Function

    ''' <summary>
    ''' Multiplies x by y as polar numbers. Returns an array.
    ''' 0 is real, 1 is imaginary
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Function DividePolar(x() As Double, y() As Double) As Double()
        Dim resultPolar(1) As Double

        resultPolar(0) = x(0) / y(0)
        resultPolar(1) = x(1) - y(1)

        Return resultPolar
    End Function

    ''' <summary>
    ''' takes voltage and current peak in polar and outputs power in RMS with an angle
    ''' </summary>
    ''' <param name="voltage"></param>
    ''' <param name="current"></param>
    ''' <returns></returns>
    Function CalculatePower(voltage() As Double, current() As Double) As Double()
        Dim power(1) As Double

        power(0) = (voltage(0) * 0.707) * (current(0) * 0.707)
        power(1) = voltage(1) + current(1)

        Return power
    End Function

    ''' <summary>
    ''' Converts a double value to a engineering notation string
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function ConvertToEngineering(value As Double) As String
        Dim absValue As Double

        absValue = Math.Abs(value)

        Select Case absValue
            Case >= 1000000000 'G
                Return $"{Math.Round(absValue * (10 ^ -9), 3)}G"
            Case >= 1000000 'M
                Return $"{Math.Round(absValue * (10 ^ -6), 3)}M"
            Case >= 1000 'K
                Return $"{Math.Round(absValue * (10 ^ -3), 3)}K"
            Case >= 1 'standard unit
                Return $"{Math.Round(absValue, 3)}"
            Case >= 0.001 'm
                Return $"{Math.Round(absValue * (10 ^ 3), 3)}m"
            Case >= 0.000001 'µ
                Return $"{Math.Round(absValue * (10 ^ 6), 3)}µ"
            Case >= 0.000000001 'n
                Return $"{Math.Round(absValue * (10 ^ 9), 3)}n"
            Case >= 0.000000000001 'p
                Return $"{Math.Round(absValue * (10 ^ 12), 3)}p"
            Case Else
                Return "0"
        End Select

    End Function

    ''' <summary>
    ''' Returns a human-readable string of the polar impedance value
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function CreateImpedanceString(value() As Double) As String
        Dim rectangular(1) As Double
        Dim retString As String

        rectangular = PolarToRectangle(value(0), value(1))

        If PolarRadioButton.Checked Then
            retString = $"{ConvertToEngineering(value(0))}Ω ∠{Math.Round(RadToDeg(value(1)), 3)}°"
        Else
            If rectangular(1) < 0 Then
                retString = $"{ConvertToEngineering(rectangular(0))}Ω - j{ConvertToEngineering(rectangular(1))}Ω"
            Else
                retString = $"{ConvertToEngineering(rectangular(0))}Ω + j{ConvertToEngineering(rectangular(1))}Ω"
            End If
        End If
        Return retString
    End Function

    ''' <summary>
    ''' Returns a human-readable string of the polar voltage value.
    ''' Handles Polar vs rectangular, RMS vs peak
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function CreateVoltageString(value() As Double) As String
        Dim polar(1) As Double
        Dim rectangular(1) As Double
        Dim designator As String
        Dim retString As String

        polar(1) = value(1)

        If RMSRadioButton.Checked Then
            polar(0) = value(0) * 0.707
            designator = "V"
        Else
            polar(0) = value(0)
            designator = "Vp"
        End If

        rectangular = PolarToRectangle(polar(0), polar(1))

        If PolarRadioButton.Checked Then
            retString = $"{ConvertToEngineering(polar(0))}{designator} ∠{Math.Round(RadToDeg(polar(1)), 3)}°"
        Else
            If rectangular(0) < 0 Then 'real voltage is negative
                retString = $"-{ConvertToEngineering(rectangular(0))}{designator} "
            Else 'real voltage is positive
                retString = $"{ConvertToEngineering(rectangular(0))}{designator} "
            End If
            If rectangular(1) < 0 Then 'imaginary voltage is negative
                retString &= $"- j{ConvertToEngineering(rectangular(0))}{designator}"
            Else
                retString &= $"+ j{ConvertToEngineering(rectangular(0))}{designator}"
            End If
        End If
        Return retString
    End Function

    ''' <summary>
    ''' Returns a human-readable string of the polar current value.
    ''' Handles Polar vs rectangular, RMS vs peak
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function CreateCurrentString(value() As Double) As String
        Dim polar(1) As Double
        Dim rectangular(1) As Double
        Dim designator As String
        Dim retString As String

        polar(1) = value(1)

        If RMSRadioButton.Checked Then
            polar(0) = value(0) * 0.707
            designator = "A"
        Else
            polar(0) = value(0)
            designator = "Ap"
        End If

        rectangular = PolarToRectangle(polar(0), polar(1))

        If PolarRadioButton.Checked Then
            retString = $"{ConvertToEngineering(polar(0))}{designator} ∠{Math.Round(RadToDeg(polar(1)), 3)}°"
        Else
            If rectangular(0) < 0 Then 'real current is negative
                retString = $"-{ConvertToEngineering(rectangular(0))}{designator} "
            Else 'real current is positive
                retString = $"{ConvertToEngineering(rectangular(0))}{designator} "
            End If
            If rectangular(1) < 0 Then 'imaginary current is negative
                retString &= $"- j{ConvertToEngineering(rectangular(0))}{designator}"
            Else 'imaginary current is positive
                retString &= $"+ j{ConvertToEngineering(rectangular(0))}{designator}"
            End If
        End If
        Return retString
    End Function

    ''' <summary>
    ''' Returns a human-readable string of the polar power value
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function CreatePowerString(value() As Double) As String
        Dim retString As String

        retString = $"{ConvertToEngineering(value(0))}W"

        Return retString
    End Function

    Sub calculateValues()
        Dim inputs(7) As Double '0 is frequency, 1 is Vgen, 2 is Rgen, 3 is R1, 4 is C1, 5 is C2, 6 is L1, 7 is Rw

        'impedance variables, 0 is impedance, 1 is angle
        Dim ZCOne(1) As Double '0 is impedance, 1 is angle
        Dim ZCTwo(1) As Double '0 is impedance, 1 is angle
        Dim ZLOne(1) As Double '0 is impedance, 1 is angle
        Dim ZParallel(1) As Double
        Dim ZSeries(1) As Double
        Dim RGen(1) As Double
        Dim ROne(1) As Double
        Dim ROneRGen(1) As Double
        Dim ZTotal(1) As Double

        'current variables, 0 is current, 1 is angle
        Dim ITotal(1) As Double
        Dim ICTwo(1) As Double
        Dim ILOne(1) As Double

        'voltage variables, 0 is voltage, 1 is angle
        Dim VTotal(1) As Double
        Dim VParallel(1) As Double
        Dim VCOne(1) As Double
        Dim VROne(1) As Double
        Dim VRGen(1) As Double

        'power variables, 0 is power, 1 is angle
        Dim PTotal(1) As Double
        Dim PLOne(1) As Double
        Dim PCTwo(1) As Double
        Dim PCOne(1) As Double
        Dim PROne(1) As Double
        Dim PRGen(1) As Double

        'NOTE: ALL ANGLES ARE IN RADIANS UNTIL CONVERTED FOR DISPLAY

        'convert the inputs
        inputs = ConvertInputs()
        'if the ConvertInputs returned nothing, exit the sub
        If inputs Is Nothing Then
            Exit Sub
        End If

        VTotal(0) = inputs(1)
        VTotal(1) = 0

        RGen(0) = inputs(2)
        RGen(1) = 0

        ROne(0) = inputs(3)
        ROne(1) = 0

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

        'calculate component voltages
        VParallel = MultiplyPolar(ITotal, ZParallel)
        VCOne = MultiplyPolar(ITotal, ZCOne)
        VROne = MultiplyPolar(ITotal, ROne)
        VRGen = MultiplyPolar(ITotal, RGen)

        'parallel current values
        ILOne = DividePolar(VParallel, ZLOne)
        ICTwo = DividePolar(VParallel, ZCTwo)

        'calculate powers
        PTotal = CalculatePower(VTotal, ITotal)
        PRGen = CalculatePower(VRGen, ITotal)
        PROne = CalculatePower(VROne, ITotal)
        PCOne = CalculatePower(VCOne, ITotal)
        PCTwo = CalculatePower(VParallel, ICTwo)
        PLOne = CalculatePower(VParallel, ILOne)

        'MsgBox(ITotal(0) & vbNewLine & RadToDeg(ITotal(1)))
        'MsgBox(CreateImpedanceString(ZTotal))

        'set all impedance labels in the table
        TotalImpedanceLabel.Text = CreateImpedanceString(ZTotal)
        RGenImpedanceLabel.Text = CreateImpedanceString(RGen)
        R1ImpedanceLabel.Text = CreateImpedanceString(ROne)
        C1ImpedanceLabel.Text = CreateImpedanceString(ZCOne)
        C2ImpedanceLabel.Text = CreateImpedanceString(ZCTwo)
        L1ImpedanceLabel.Text = CreateImpedanceString(ZLOne)

        'set all voltage labels in the table
        L1VoltageLabel.Text = CreateVoltageString(VParallel)
        C2VoltageLabel.Text = CreateVoltageString(VParallel)
        C1VoltageLabel.Text = CreateVoltageString(VCOne)
        R1VoltageLabel.Text = CreateVoltageString(VROne)
        RGenVoltageLabel.Text = CreateVoltageString(VRGen)
        TotalVoltageLabel.Text = CreateVoltageString(VTotal)

        'set all current labels in the table
        TotalCurrentLabel.Text = CreateCurrentString(ITotal)
        RGenCurrentLabel.Text = CreateCurrentString(ITotal)
        R1CurrentLabel.Text = CreateCurrentString(ITotal)
        C1CurrentLabel.Text = CreateCurrentString(ITotal)
        C2CurrentLabel.Text = CreateCurrentString(ICTwo)
        L1CurrentLabel.Text = CreateCurrentString(ILOne)

        'set all power labels in the table
        TotalPowerLabel.Text = CreatePowerString(PTotal)
        RGenPowerLabel.Text = CreatePowerString(PRGen)
        R1PowerLabel.Text = CreatePowerString(PROne)
        C1PowerLabel.Text = CreatePowerString(PCOne)
        C2PowerLabel.Text = CreatePowerString(PCTwo)
        L1PowerLabel.Text = CreatePowerString(PLOne)
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateContextMenuItem.Click, CalculateTopMenuItem.Click
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

    ''' <summary>
    ''' If either the format or style of the outputs has changed, recalculate values
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormatChanged(sender As Object, e As EventArgs) Handles PeakRadioButton.CheckedChanged, PolarRadioButton.CheckedChanged
        If TotalImpedanceLabel.Text <> "-" Then 'only recalculate if it has been calculated before
            calculateValues()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitContextMenuItem.Click, ExitTopMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HistoryTopMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryTopMenuItem.Click, HistoryContextMenuItem.Click
        Process.Start("explorer.exe", My.Application.Info.DirectoryPath)
    End Sub
End Class