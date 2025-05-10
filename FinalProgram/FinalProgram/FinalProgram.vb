Public Class FinalProgram

    Private WithEvents QyBoard As New Qy_BoardComClass
    Private heatToTemperature As Double
    Private coolToTemperature As Double
    Private heatMode As Boolean
    Private fanMode As Boolean
    Private coolMode As Boolean
    Private interlockTripped As Boolean
    Private notCoolingError As Boolean
    Private notHeatingError As Boolean
    Private noFanError As Boolean

    Sub UpdateTemperatureTextBoxes()
        HeatToTextBox.Text = $"{heatToTemperature}"
        CoolToTextBox.Text = $"{coolToTemperature}"

    End Sub

    ''' <summary>
    ''' If connect is true, sets the status strip to connected to..., connect/disconnect button to disconnect, lock COM port selection
    ''' If connect is false, sets the status strip to disconnected from, connect/disconnect button to connect, unlocks COM port selection
    ''' </summary>
    ''' <param name="connect"></param>
    Sub UpdateSerialControls(connect As Boolean)
        If connect Then
            COMStatusLabel.Text = $"Connected to {QyBoard.COMPort}" 'set the status bar label
            ConnectDisconnectMenuItem.Text = "Disconnect" 'set the connect/disconnect button to disconnect
            COMPortComboBox.Enabled = False 'disable COM port selection
            COMPortRefreshTimer.Enabled = False 'stop refreshing the available COM ports

            'cycle the timer to reset the count
            COMPortRefreshTimer.Stop()
            COMPortRefreshTimer.Start()
        Else
            ConnectDisconnectMenuItem.Text = "Connect" 'set the connect/disconnect button to connect
            COMStatusLabel.Text = $"Disconnected from {QyBoard.COMPort}" 'set the status bar label
            COMPortComboBox.Enabled = True 'enable COM port selection
            COMPortRefreshTimer.Start() 'starts the timer to periodically update the available COM ports
        End If
    End Sub

    Sub StartFan()
        MsgBox("Started Fan")
        QyBoard.DOutThree = True 'turn on the fan
        SafetyTimer.Interval = 5000 'turn on the safety checks

        FanDelayTimer.Stop()
        FanDelayTimer.Start()

    End Sub

    Private Sub COMPortSplitButton_ButtonClick(sender As Object, e As EventArgs) Handles COMPortSplitButton.ButtonClick
        COMPortSplitButton.ShowDropDown()
    End Sub

    ''' <summary>
    ''' Update the available COM ports when the board is not connected and a user is not actively selecting one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub COMPortRefreshTimer_Tick(sender As Object, e As EventArgs) Handles COMPortRefreshTimer.Tick
        If Not QyBoard.Connected And Not COMPortComboBox.DroppedDown Then
            COMPortComboBox.Items.Clear()
            For Each sp As String In My.Computer.Ports.SerialPortNames
                COMPortComboBox.Items.Add(sp)
            Next
            COMPortComboBox.Text = QyBoard.COMPort
        End If
    End Sub


    Private Sub FinalProgram_Load(sender As Object, e As EventArgs) Handles Me.Load
        COMPortRefreshTimer.Start()

        UpdateSerialControls(False)

        TableLayoutPanel.BackColor = Color.FromArgb(130, 130, 130)
        CurrentTemperatureLabel.ForeColor = Color.FromArgb(230, 231, 232)
        CurrentTimeLabel.ForeColor = Color.FromArgb(230, 231, 232)
        HeatToGroupBox.ForeColor = Color.FromArgb(230, 231, 232)
        CoolToGroupBox.ForeColor = Color.FromArgb(230, 231, 232)
        ModeLabel.ForeColor = Color.FromArgb(230, 231, 232)

        If My.Computer.FileSystem.FileExists("HVAC_Settings.txt") Then
            'load settings from file
            Try
                FileOpen(1, "HVAC_Settings.txt", OpenMode.Input)
                Input(1, heatToTemperature)
                Input(1, coolToTemperature)
                FileClose(1)

                UpdateTemperatureTextBoxes()
            Catch ex As Exception

            End Try
        Else 'use defaults if no file
            heatToTemperature = 70
            coolToTemperature = 74

            UpdateTemperatureTextBoxes()
        End If

        CurrentTimeLabel.Text = $"{DateTime.Today.Now.ToString("hh:mm tt")}"
        ErrorMessageLabel.Text = ""

    End Sub

    Private Sub COMPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMPortComboBox.SelectedIndexChanged
        QyBoard.COMPort = COMPortComboBox.Text
        UpdateSerialControls(False)
    End Sub

    Private Sub ConnectDisconnectMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectDisconnectMenuItem.Click
        If QyBoard.Connected Then
            QyBoard.StopConnection()
            UpdateSerialControls(False)
        Else
            QyBoard.StartConnection()
            UpdateSerialControls(True)
        End If
    End Sub

    ''' <summary>
    ''' Heat mode button pressed
    ''' </summary>
    Private Sub QyBoard_DigitalInputTwoChanged() Handles QyBoard.DigitalInputTwoChanged
        If QyBoard.DInTwo Then
            If heatMode Then
                heatMode = False
            Else
                heatMode = True
                fanMode = False
                coolMode = False
                StartFan()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Fan mode button pressed
    ''' </summary>
    Private Sub QyBoard_DigitalInputThreeChanged() Handles QyBoard.DigitalInputThreeChanged
        If QyBoard.DInThree Then
            If fanMode Then
                fanMode = False
            Else
                heatMode = False
                fanMode = True
                coolMode = False
                StartFan()
            End If
        End If
    End Sub

    ''' <summary>
    ''' cool mode button pressed
    ''' </summary>
    Private Sub QyBoard_DigitalInputFourChanged() Handles QyBoard.DigitalInputFourChanged
        If QyBoard.DInFour Then
            If coolMode Then
                coolMode = False
            Else
                heatMode = False
                fanMode = False
                coolMode = True
                StartFan()
            End If
        End If
    End Sub

    ''' <summary>
    ''' interlock tripped
    ''' </summary>
    Private Sub QyBoard_DigitalInputOneChanged() Handles QyBoard.DigitalInputOneChanged
        If QyBoard.DInOne Then
            QyBoard.DOutOne = False
            interlockTripped = False
            'TODO SAVE TO FILE
        Else
            QyBoard.DOutOne = True
            interlockTripped = True
            heatMode = False
            fanMode = False
            coolMode = False
            QyBoard.DOutTwo = False
            QyBoard.DOutThree = False
            QyBoard.DOutFour = False
            'TODO SAVE TO FILE
        End If
    End Sub

    Private Sub QyBoard_InvalidComPort() Handles QyBoard.InvalidComPort
        UpdateSerialControls(False)
        MsgBox("Qy@ Board not found on the selected COM port.")
    End Sub

    Private Sub QyBoard_Disconnected(message As String) Handles QyBoard.Disconnected
        UpdateSerialControls(False)
        MsgBox("Qy@ Board disconnected unexpectedly.")
    End Sub

    Private Sub HeatUpButton_Click(sender As Object, e As EventArgs) Handles HeatUpButton.Click
        heatToTemperature += 0.5
        UpdateTemperatureTextBoxes()
    End Sub

    Private Sub HeatDownButton_Click(sender As Object, e As EventArgs) Handles HeatDownButton.Click
        heatToTemperature -= 0.5
        UpdateTemperatureTextBoxes()
    End Sub

    Private Sub CoolUpButton_Click(sender As Object, e As EventArgs) Handles CoolUpButton.Click
        coolToTemperature += 0.5
        UpdateTemperatureTextBoxes()
    End Sub

    Private Sub CoolDownButton_Click(sender As Object, e As EventArgs) Handles CoolDownButton.Click
        coolToTemperature -= 0.5
        UpdateTemperatureTextBoxes()
    End Sub

    Private Sub RealTimeTimer_Tick(sender As Object, e As EventArgs) Handles RealTimeTimer.Tick
        CurrentTimeLabel.Text = $"{DateTime.Today.Now.ToString("hh:mm tt")}"
    End Sub

    Private Sub TempUpdateTimer_Tick(sender As Object, e As EventArgs) Handles TempUpdateTimer.Tick
        Dim homeTemperature As Double
        Dim unitTemperature As Double

        homeTemperature = ((QyBoard.AN1 * (3.3 / 1023)) / 0.66) / 0.01
        unitTemperature = ((QyBoard.AN2 * (3.3 / 1023)) / 0.66) / 0.01

        CurrentTemperatureLabel.Text = $"{homeTemperature.ToString("0.0")} °F"

        If interlockTripped Then
            ErrorMessageLabel.Text = "Error: Interlock Tripped"
        ElseIf notHeatingError Then
            ErrorMessageLabel.Text = "Error: Unit Not Heating"
        ElseIf notCoolingError Then
            ErrorMessageLabel.Text = "Error: Unit Not Cooling"
        ElseIf noFanError Then
            ErrorMessageLabel.Text = "Error: Fan not running"
        Else
            ErrorMessageLabel.Text = ""
        End If

        If heatMode And Not interlockTripped Then
            ModeLabel.Text = "Heat"
        ElseIf coolMode And Not interlockTripped Then
            ModeLabel.Text = "Cool"
        ElseIf fanMode And Not interlockTripped Then
            ModeLabel.Text = "Fan"
        Else
            ModeLabel.Text = "OFF"
        End If
    End Sub

    Private Sub SafetyTimer_Tick(sender As Object, e As EventArgs) Handles SafetyTimer.Tick
        SafetyTimer.Interval = 120000
        If QyBoard.DInFive Then
            heatMode = False
            coolMode = False
            fanMode = False
            noFanError = True 'error with fan
            QyBoard.DOutTwo = False
            QyBoard.DOutThree = False
            QyBoard.DOutFour = False
            'TODO SAVE TO FILE
        End If
    End Sub

    Private Sub FanDelayTimer_Tick(sender As Object, e As EventArgs) Handles FanDelayTimer.Tick
        FanDelayTimer.Stop()
        MsgBox("FanDelay")
        SafetyTimer.Stop()
        SafetyTimer.Start()
        If QyBoard.DOutThree Then
            Select Case True
                Case heatMode
                    QyBoard.DOutTwo = True 'turn on the heater
                Case coolMode
                    QyBoard.DOutFour = True 'turn on the cooler
            End Select
        End If
    End Sub
End Class
