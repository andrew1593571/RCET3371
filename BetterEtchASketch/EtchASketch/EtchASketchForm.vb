Imports System.Linq.Expressions

'Andrew Keller
'RCET3371
'Spring 2025
'Better Etch-A-Sketch
'https://github.com/andrew1593571/RCET3371.git
'Modified from Fall 2024 RCET2265 Repo
'https://github.com/andrew1593571/ComputerFundamentals.git

Public Class EtchASketchForm

    ''' <summary>
    ''' Stores whether or not the system requested the Qy@ board settings readout
    ''' </summary>
    Private queryBoard As Boolean

    ''' <summary>
    ''' Draw a line from (0,0) to (100,100)
    ''' </summary>
    Sub DrawLine()
        Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        Dim pen As New Pen(Color.Blue, PenSize())

        g.DrawLine(pen, 0, 0, 100, 100)

        g.Dispose()
        DrawingPictureBox.Image = StoreBitmap()
    End Sub

    ''' <summary>
    ''' Draw a rectangle from (100,100) to (300,300)
    ''' </summary>
    Sub DrawRectangle()
        Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        Dim pen As New Pen(Color.Blue, PenSize())

        g.DrawRectangle(pen, 100, 100, 300, 300)

        g.Dispose()
        DrawingPictureBox.Image = StoreBitmap()
    End Sub

    ''' <summary>
    ''' Draw an ellipse from (100,100) to (300,300)
    ''' </summary>
    Sub DrawCircle()
        Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        Dim pen As New Pen(Color.Blue, PenSize())

        g.DrawEllipse(pen, 100, 100, 300, 300)

        g.Dispose()
        DrawingPictureBox.Image = StoreBitmap()
    End Sub

    ''' <summary>
    ''' Draw text at 50,50.
    ''' </summary>
    Sub DrawText()
        Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        Dim brush As New SolidBrush(Color.Red)

        g.DrawString("Hello", Me.Font, brush, 50, 50)

        g.Dispose()
        DrawingPictureBox.Image = StoreBitmap()
    End Sub

    ''' <summary>
    ''' Draws an image the full size of the DrawingPictureBox
    ''' </summary>
    ''' <param name="imagePath"></param>
    Sub DrawImage(imagePath As String)
        Dim bmp As Image = StoreBitmap()
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim image As Image = Image.FromFile(imagePath)

        Dim resized As New Bitmap(image, DrawingPictureBox.Width, DrawingPictureBox.Height)

        g.DrawImage(resized, 0, 0)

        StoreBitmap(bmp)
        g.Dispose()
        DrawingPictureBox.Image = StoreBitmap()
    End Sub

    ''' <summary>
    ''' Stores the Pen color for all of the graphics tools
    ''' </summary>
    ''' <param name="newColor"></param>
    ''' <returns></returns>
    Function PenColor(Optional newColor As Color = Nothing) As Color
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

    ''' <summary>
    ''' Draws a straight line from the start x and y to the end x and y
    ''' </summary>
    ''' <param name="startX"></param>
    ''' <param name="startY"></param>
    ''' <param name="endX"></param>
    ''' <param name="endY"></param>
    Sub MouseDraw(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        Dim pen As New Pen(PenColor(), PenSize())

        g.DrawLine(pen, startX, startY, endX, endY)

        g.Dispose()
        DrawingPictureBox.Image = StoreBitmap()
    End Sub

    ''' <summary>
    ''' Draws scope divisions using the MouseDraw Sub
    ''' </summary>
    Sub DrawDivisions()
        Dim xSpace As Integer = DrawingPictureBox.Width \ 10
        Dim ySpace As Integer = DrawingPictureBox.Height \ 8
        Dim existingColor As Color = PenColor()

        PenColor(Color.LightGray)

        For i = 0 To xSpace * 10 Step xSpace
            MouseDraw(i, 0, i, ySpace * 8)
        Next

        For i = 0 To ySpace * 8 Step ySpace
            MouseDraw(0, i, xSpace * 10, i)
        Next

        PenColor(existingColor)

    End Sub

    ''' <summary>
    ''' Draws a sine wave on the bitmap using the MouseDraw function
    ''' </summary>
    Sub DrawSinWave()
        Dim degToRad As Double = Math.PI / 180
        Dim oneDegree As Double = DrawingPictureBox.Width / 360
        Dim peak As Integer = DrawingPictureBox.Height \ 2
        Dim currentY As Integer
        Dim nextX As Integer
        Dim lastY As Integer = peak
        Dim lastX As Integer

        For i = 0 To DrawingPictureBox.Width \ CInt(oneDegree)
            currentY = CInt(peak * Math.Sin(degToRad * i)) + peak
            nextX = lastX + CInt(oneDegree)
            MouseDraw(lastX, lastY, nextX, currentY)
            lastY = currentY
            lastX = nextX
        Next

    End Sub

    ''' <summary>
    ''' creates an empty bitmap with the correct size for the DrawingPictureBox
    ''' </summary>
    ''' <returns></returns>
    Function CreateBitmap() As Image
        Dim bmp As New Bitmap(DrawingPictureBox.Width, DrawingPictureBox.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        g.Clear(DrawingPictureBox.BackColor)

        g.Dispose()
        Return bmp
    End Function

    ''' <summary>
    ''' Stores the bitmap to be drawn on. If not provided with a new image, the bitmap will return the existing
    ''' </summary>
    ''' <param name="image"></param>
    ''' <returns></returns>
    Function StoreBitmap(Optional image As Image = Nothing) As Image
        Static bmp As Bitmap

        If image Is Nothing Then
            Return bmp
        Else
            bmp = New Bitmap(image)
            Return bmp

        End If

    End Function

    '______Event Handlers Below Here______

    ''' <summary>
    ''' When the form is clicked, draws a line, rectangle, and circle on the picturebox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GraphicsExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawRectangle()
        DrawCircle()
        DrawText()
        DrawImage("C:\Users\andre\Downloads\scifi-4916165_1920.jpg")
    End Sub

    ''' <summary>
    ''' closes the form when the exit button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Calls the MouseDraw sub whenever the mouse moves and the left mouse button is held
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown, DrawingPictureBox.MouseMove
        Static oldX%, oldY%

        'Me.Text = $"({e.X.ToString},{e.Y.ToString}) Button: {e.Button.ToString} Color: {PenColor().Name}"

        If e.Button = MouseButtons.Left And MouseRadioButton.Checked Then
            MouseDraw(oldX, oldY, e.X, e.Y)
        End If

        oldX = e.X
        oldY = e.Y

    End Sub

    ''' <summary>
    ''' Changes the pen color with a dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChangePenColor(sender As Object, e As EventArgs) Handles PenColorToolStripMenuItem.Click, PenColorTopToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        PenColor(ColorDialog.Color)
    End Sub

    ''' <summary>
    ''' Creates an empty bitmap and sets the pen to black when the form loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GraphicsExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        PenColor(Color.Black)
        StoreBitmap(CreateBitmap())
        DrawingPictureBox.Image = StoreBitmap()

        'initialize Serial Port
        SerialPortRefreshTimer.Start()
        SerialComStatusLabel.Text = $"Disconnected from {SerialPort.PortName}"
        SerialPort.BaudRate = 9600
        SerialPort.DataBits = 8
        SerialPort.StopBits = IO.Ports.StopBits.One
        SerialPort.Parity = IO.Ports.Parity.None
    End Sub

    ''' <summary>
    ''' overwrites the existing bitmap with a blank bitmap
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearScreen(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        DrawingPictureBox.Image = StoreBitmap(CreateBitmap())
    End Sub

    ''' <summary>
    ''' Sets the background color of the picturebox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChangeBackgroundColor(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click, BackgroundColorTopToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        Dim g As Graphics = Graphics.FromImage(StoreBitmap())
        Dim brush As New SolidBrush(ColorDialog.Color)
        Dim rect As New Rectangle(0, 0, DrawingPictureBox.Width, DrawingPictureBox.Height)

        g.FillRectangle(brush, rect)

        g.Dispose()
        DrawingPictureBox.Image = StoreBitmap()
    End Sub

    ''' <summary>
    ''' draws a oscilloscope view of a sine wave
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DrawWave(sender As Object, e As EventArgs) Handles WaveButton.Click, DrawWaveformToolStripMenuItem.Click
        DrawDivisions()
        DrawSinWave()
    End Sub

    ''' <summary>
    ''' opens and imports an image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenTopMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTopMenuItem.Click

        OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "image files (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif|All files (*.*)|*.*"

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            DrawImage(OpenFileDialog.FileName)
        End If

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

        StoreBitmap().Save(SaveFileDialog.FileName)

    End Sub

    ''' <summary>
    ''' Scales the current bitmap when the form size is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GraphicsExampleForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Visible Then

            Dim newbmp As New Bitmap(StoreBitmap(), DrawingPictureBox.Width, DrawingPictureBox.Height)

            DrawingPictureBox.Image = StoreBitmap(newbmp)

        End If
    End Sub

    ''' <summary>
    ''' sets the pen size whenever the trackbar is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PenSizeTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles PenSizeTrackBar.ValueChanged
        PenSize(PenSizeTrackBar.Value)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
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
        Static oldX%, oldY%
        Dim newX%, newY%

        writeBytes(0) = &H53 'request analog inputs 1 and 2

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

            newX = 50 'analog 1 value
            newY = 50 'analog 2 value

            If BoardRadioButton.Checked Then
                MouseDraw(oldX, oldY, newX, newY)
            End If

            oldX = newX
            oldY = newY
        End If

        SerialPort.Write(writeBytes, 0, 1) 'request analog inputs from Qy@ board
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

    Private Sub BoardRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BoardRadioButton.CheckedChanged
        If Not SerialPort.IsOpen Then
            MsgBox("Please select a COM port to use the Qy@ board to draw.")
        End If
    End Sub
End Class
