Option Explicit On
Option Strict On


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

    ''' <summary>
    ''' Draw a line from (0,0) to (100,100)
    ''' </summary>
    Sub DrawLine()
        'Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        'Dim pen As New Pen(Color.Blue, PenSize())

        'g.DrawLine(pen, 0, 0, 100, 100)

        'g.Dispose()
        'GraphPictureBox.Image = StoreBitmap()
    End Sub


    ''' <summary>
    ''' Stores the trace color for all of the graphics tools
    ''' </summary>
    ''' <param name="newColor"></param>
    ''' <returns></returns>
    Function TraceColor(Optional newColor As Color = Nothing) As Color
        Static _color As Color

        If newColor <> Nothing Then
            _color = newColor
        End If

        Return _color
    End Function

    ''' <summary>
    ''' Stores the pen size for all of the graphics tools.
    ''' </summary>
    ''' <param name="newSize"></param>
    ''' <returns></returns>
    Function PenSize(Optional newSize As Single = 0) As Single
        Static _size As Single

        If newSize <> 0 Then
            _size = newSize
        End If

        Return _size
    End Function

    Sub UpdateTrace()
        Dim traceArray As Integer()
        traceArray = receivedDataQueue.ToArray

        Dim g As Graphics = GraphPictureBox.CreateGraphics()
        Dim heightScale As Single, widthScale As Single
        Dim pen As New Pen(Color.Black, 10)

        GraphPictureBox.Refresh()

        heightScale = CSng(GraphPictureBox.Height / 1023)
        widthScale = CSng(GraphPictureBox.Width / receivedDataQueue.Count)

        g.ScaleTransform(widthScale, heightScale)

        g.DrawLine(pen, receivedDataQueue.Count, traceArray(0), receivedDataQueue.Count, traceArray(0))

        For i = 1 To traceArray.Length - 1
            g.DrawRectangle(pen, i - 1, traceArray(i - 1), i, traceArray(i))
        Next

        g.Dispose()
        pen.Dispose()
    End Sub

    ''' <summary>
    ''' Draws a straight line from the start x and y to the end x and y
    ''' </summary>
    ''' <param name="startX"></param>
    ''' <param name="startY"></param>
    ''' <param name="endX"></param>
    ''' <param name="endY"></param>
    Sub DrawLine(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        'Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        'Dim pen As New Pen(TraceColor(), PenSize())

        'g.DrawLine(pen, startX, startY, endX, endY)

        'g.Dispose()
        'GraphPictureBox.Image = StoreBitmap()
    End Sub

    '______Event Handlers Below Here______

    ''' <summary>
    ''' closes the form when the exit button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Changes the pen color with a dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChangePenColor(sender As Object, e As EventArgs) Handles ColorContextMenuItem.Click, PenColorTopMenuItem.Click
        ColorDialog.ShowDialog()
        TraceColor(ColorDialog.Color)
    End Sub

    ''' <summary>
    ''' Creates an empty bitmap and sets the pen to black when the form loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GraphicsExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TraceColor(Color.Black)

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
    Private Sub SaveTopMenuItem_Click(sender As Object, e As EventArgs) Handles SaveTopMenuItem.Click

        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        SaveFileDialog.FileName = $"Untitled-{DateTime.Today.Now.ToString("yyMMddhhmmss")}.bmp"

        'opens the SaveFileDialog
        SaveFileDialog.ShowDialog()

        'StoreBitmap().Save(SaveFileDialog.FileName)

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
        SerialPort.Read(readBytes, 0, numberOfBytes)

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
                receivedDataQueue.Enqueue((readBytes(0) * 4))
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
        SampleTimer.Interval = 1000 \ SampleRateTrackBar.Value
    End Sub

    Private Sub SampleTimer_Tick(sender As Object, e As EventArgs) Handles SampleTimer.Tick
        If receivedDataQueue.Count > 0 Then
            UpdateTrace()
        End If
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        SampleTimer.Start()
    End Sub
End Class
