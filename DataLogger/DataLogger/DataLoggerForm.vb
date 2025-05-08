Option Explicit On
Option Strict On
Imports System.IO




'Andrew Keller
'RCET3371
'Spring 2025
'Data Logger
'https://github.com/andrew1593571/RCET3371.git

Public Class DataLoggerForm

    ''' <summary>
    ''' Stores whether or not the system requested the Qy@ board settings readout
    ''' </summary>
    Private queryBoard As Boolean

    ''' <summary>
    ''' Stores the received data value as the appropriate integer value
    ''' </summary>
    Private receivedDataQueue As New Queue(Of Integer)

    Private currentValue As Integer

    ''' <summary>
    ''' Set to true when a valid file path has been provided by the user
    ''' </summary>
    Private saveToFile As Boolean

    ''' <summary>
    ''' stores the save folder path
    ''' </summary>
    Private folderPath As String

    ''' <summary>
    ''' Updates the graph for all recorded time.
    ''' </summary>
    Sub UpdateTraceAllTime()
        Dim traceArray As Integer()
        traceArray = receivedDataQueue.ToArray

        Dim g As Graphics = GraphPictureBox.CreateGraphics()
        Dim heightScale As Single, widthScale As Single
        Dim pen As New Pen(Color.Black, 5)
        Dim lastX As Integer, lastY As Integer

        heightScale = CSng(GraphPictureBox.Height / 1023)
        widthScale = CSng(GraphPictureBox.Width / receivedDataQueue.Count)

        g.ScaleTransform(widthScale, heightScale)

        g.DrawLine(pen, receivedDataQueue.Count, traceArray(0), receivedDataQueue.Count, traceArray(0))
        lastX = 0
        lastY = traceArray(0)

        For i = 1 To traceArray.Length - 1
            Try
                g.FillRectangle(Brushes.White, lastX, 0, i - lastX, 1023)
                g.DrawLine(pen, lastX, lastY, i, traceArray(i))

            Catch ex As Exception

            End Try
            lastX = i
            lastY = traceArray(i)
        Next

        g.Dispose()
        pen.Dispose()
    End Sub

    ''' <summary>
    ''' Shows the last 30 seconds on the graph
    ''' </summary>
    Sub UpdateTraceThirty()
        Dim traceArray As Integer()
        traceArray = receivedDataQueue.ToArray

        Dim g As Graphics = GraphPictureBox.CreateGraphics()
        Dim heightScale As Single, widthScale As Single
        Dim pen As New Pen(Color.Black, 5)
        Dim lastX As Integer, lastY As Integer
        Dim lastThirty As Integer = SampleRateTrackBar.Value * 30
        Dim xCount As Integer = 0


        If traceArray.Length > lastThirty Then
            heightScale = CSng(GraphPictureBox.Height / 1023)
            widthScale = CSng(GraphPictureBox.Width / lastThirty)

            g.ScaleTransform(widthScale, heightScale)

            g.DrawLine(pen, receivedDataQueue.Count, traceArray(0), receivedDataQueue.Count, traceArray(0))
            lastX = xCount
            lastY = traceArray(0)

            For i = traceArray.Length - lastThirty To traceArray.Length - 1
                Try
                    g.FillRectangle(Brushes.White, lastX, 0, xCount, 1023)
                    g.DrawLine(pen, lastX, lastY, xCount, traceArray(i))
                Catch ex As Exception

                End Try
                lastX = xCount
                lastY = traceArray(i)
                xCount += 1
            Next
        Else
            UpdateTraceAllTime()
        End If

        g.Dispose()
        pen.Dispose()
    End Sub

    '______Event Handlers Below Here______

    ''' <summary>
    ''' closes the form when the exit button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenuItem.Click, ExitContextMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Creates an empty bitmap and sets the pen to black when the form loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataLoggerForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'initialize Serial Port
        SerialPortRefreshTimer.Start()
        SerialComStatusLabel.Text = $"Disconnected from {SerialPort.PortName}"
        SerialPort.BaudRate = 9600
        SerialPort.DataBits = 8
        SerialPort.StopBits = IO.Ports.StopBits.One
        SerialPort.Parity = IO.Ports.Parity.None

        SampleTimer.Interval = 1000 \ SampleRateTrackBar.Value
        SampleTimer.Stop()
    End Sub

    ''' <summary>
    ''' prompts the user to save the current bitmap to file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click, SaveTopMenuItem.Click, SaveContextMenuItem.Click

        SaveFolderDialog.RootFolder = Environment.SpecialFolder.MyDocuments

        'opens the SaveFolderDialog
        If SaveFolderDialog.ShowDialog() = DialogResult.OK Then
            saveToFile = True
            folderPath = SaveFolderDialog.SelectedPath
            SavePathLabel.Text = $"Current Save Path: {folderPath}"
        End If


    End Sub

    ''' <summary>
    ''' Show the about form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        AboutForm.Show()
    End Sub

    ''' <summary>
    ''' When the serial port timer ticks, update the SerialPortComboBox entries with active COM ports
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SerialPortRefreshTimer_Tick(sender As Object, e As EventArgs) Handles SerialPortRefreshTimer.Tick
        'If a serial port is not open or the user isnt changing it update the list
        If Not SerialPort.IsOpen And Not SerialPortComboBox.DroppedDown Then
            SerialPortComboBox.Items.Clear()
            For Each sp As String In My.Computer.Ports.SerialPortNames
                SerialPortComboBox.Items.Add(sp)
            Next
            SerialPortComboBox.Text = SerialPort.PortName
        End If
    End Sub

    ''' <summary>
    ''' When the selected value in the COM selection changes, disconnect the COM and reopen the new one.
    ''' Verify that the Qy@ board is the connected port
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SerialPortComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SerialPortComboBox.SelectedIndexChanged
        Dim writeBytes(0) As Byte
        writeBytes(0) = &HF0

        If Not SerialPortComboBox.Text = SerialPort.PortName Then 'If the port is open and the serial port name does not match the connected
            If SerialPort.IsOpen Then 'close the port if it is open
                SerialPort.Close()
            End If

            SerialPort.PortName = SerialPortComboBox.Text
            Try 'try opening the new selected port
                SerialPort.Open()
                SerialComStatusLabel.Text = $"Connected to {SerialPort.PortName}"
            Catch ex As Exception
                MsgBox($"Failed to connect to the Qy@ board on {SerialPort.PortName}.{vbNewLine}{vbNewLine}Please select a valid COM port.")
                Exit Sub
            End Try

            'verify that the connected port is the Qy@ board
            SerialPort.Write(writeBytes, 0, 1)
            queryBoard = True
            COMTimeoutTimer.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Occurs when data is received by the Serial Port
    ''' Handles data as needed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim numberOfBytes = SerialPort.BytesToRead
        Dim readBytes(numberOfBytes - 1) As Byte
        Dim writeBytes(0) As Byte

        writeBytes(0) = &H53 'request analog inputs 1 and 2
        Console.WriteLine($"{numberOfBytes} received")
        'MsgBox($"{numberOfBytes} received")
        Try
            SerialPort.Read(readBytes, 0, numberOfBytes)
        Catch ex As Exception

        End Try

        'If a board query was requested, verify the Qy@ board signature
        If queryBoard Then
            queryBoard = False
            If readBytes.Length = 64 Then
                If Not (readBytes(58) = &H51 And readBytes(59) = &H79 And readBytes(60) = &H40) Then
                    MsgBox("Incorrect Device. Please select a Qy@ Board.")
                    SerialPort.Close()
                    SerialComStatusLabel.Text = $"Disconnected from {SerialPort.PortName}"
                    Exit Sub
                Else
                    'Qy@ board detected, disable the timeout timer
                    COMTimeoutTimer.Enabled = False
                End If
            Else
                MsgBox("Incorrect Device. Please select a Qy@ Board.")
                SerialPort.Close()
                SerialComStatusLabel.Text = $"Disconnected from {SerialPort.PortName}"
                Exit Sub
            End If

        Else
            'if not querying board, interpret analog input data

            Try
                currentValue = (readBytes(0) * 4)
            Catch ex As Exception

            End Try

        End If
        If SerialPort.IsOpen Then
            SerialPort.Write(writeBytes, 0, 1) 'request analog inputs from Qy@ board
        End If

    End Sub

    ''' <summary>
    ''' If the serial port does not respond within specified time, close the port and notify the user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub COMTimeoutTimer_Tick(sender As Object, e As EventArgs) Handles COMTimeoutTimer.Tick
        COMTimeoutTimer.Enabled = False
        MsgBox("Qy@ board not detected on the selected COM port. Please select a different port or verify connection.")
        SerialPort.Close()
        SerialComStatusLabel.Text = $"Disconnected from {SerialPort.PortName}"
    End Sub

    Private Sub DataLoggerForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        SerialPort.Close()
    End Sub

    Private Sub SampleRateTrackBar_Scroll(sender As Object, e As EventArgs) Handles SampleRateTrackBar.Scroll
        CurrentSampleRateLabel.Text = $"{SampleRateTrackBar.Value} samples/s"
        SampleTimer.Interval = 1000 \ SampleRateTrackBar.Value
    End Sub

    Private Sub SampleTimer_Tick(sender As Object, e As EventArgs) Handles SampleTimer.Tick
        receivedDataQueue.Enqueue(currentValue)
        If saveToFile Then
            Try
                FileOpen(1, $"{folderPath}\DataLog-{DateTime.Today.Now.ToString("yyMMddhh")}.log", OpenMode.Append)
                Write(1, "$$AN1")
                Write(1, currentValue)
                WriteLine(1, DateTime.Today.Now.ToString("yyyymmddhhmmssfff"))
                FileClose(1)
            Catch ex As Exception

            End Try
        End If
        If receivedDataQueue.Count > 0 Then
            If AllTimeRadioButton.Checked Then
                UpdateTraceAllTime()
            Else
                UpdateTraceThirty()
            End If
        End If
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click, StartTopMenuItem.Click
        SampleTimer.Start()
    End Sub

    Private Sub AllTimeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllTimeRadioButton.CheckedChanged
        GraphPictureBox.Refresh()
    End Sub
End Class
