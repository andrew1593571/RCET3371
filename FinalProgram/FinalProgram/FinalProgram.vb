Public Class FinalProgram

    Private WithEvents QyBoard As New Qy_BoardComClass

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

    Private Sub QyBoard_DigitalInputOneChanged() Handles QyBoard.DigitalInputOneChanged
        If QyBoard.DOutOne Then
            QyBoard.DOutOne = False
        Else
            QyBoard.DOutOne = True
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
End Class
