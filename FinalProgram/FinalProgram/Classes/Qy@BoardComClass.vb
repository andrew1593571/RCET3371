Option Strict On
Option Explicit On
Imports System.IO.Ports

Public Class Qy_BoardComClass

    '######______Event Declarations______######
    Public Event ConnectionMade()
    Public Event Disconnected(message As String)
    Public Event InvalidComPort()
    Public Event DigitalInputOneChanged()
    Public Event DigitalInputTwoChanged()
    Public Event DigitalInputThreeChanged()
    Public Event DigitalInputFourChanged()
    Public Event DigitalInputFiveChanged()
    Public Event DigitalInputSixChanged()
    Public Event DigitalInputSevenChanged()
    Public Event DigitalInputEightChanged()
    Public Event AN1Changed()
    Public Event AN2Changed()

    '######______Object With Events Declarations______######
    Private WithEvents serialPort As New SerialPort
    Private WithEvents verificationTimer As New Timer
    Private WithEvents disconnectTimer As New Timer

    '######______Class properties and variables______######
    Private _queryBoard As Boolean

    Private _connected As Boolean

    Private _AN1Current As Integer
    Private _AN2Current As Integer

    Private _digitalInOne As Boolean = True
    Private _digitalInTwo As Boolean = True
    Private _digitalInThree As Boolean = True
    Private _digitalInFour As Boolean = True
    Private _digitalInFive As Boolean = True
    Private _digitalInSix As Boolean = True
    Private _digitalInSeven As Boolean = True
    Private _digitalInEight As Boolean = True

    Private _digitalOutOne As Boolean
    Private _digitalOutTwo As Boolean
    Private _digitalOutThree As Boolean
    Private _digitalOutFour As Boolean
    Private _digitalOutFive As Boolean
    Private _digitalOutSix As Boolean
    Private _digitalOutSeven As Boolean
    Private _digitalOutEight As Boolean

    ''' <summary>
    ''' Returns true if the connection to the Qy@ board is configured correctly.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Connected As Boolean
        Get
            Return _connected
        End Get
    End Property

    ''' <summary>
    ''' Sets the COMPort for the Qy@ board if it is not already connected.
    ''' </summary>
    ''' <returns></returns>
    Public Property COMPort As String
        Get
            Return serialPort.PortName
        End Get
        Set(value As String)
            Try
                serialPort.PortName = value
            Catch ex As Exception

            End Try
        End Set
    End Property

    ''' <summary>
    ''' Returns the current integer value of AN1. From 0 to 1023.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property AN1() As Integer
        Get
            Return _AN1Current
        End Get
    End Property

    ''' <summary>
    ''' Returns the current integer value of AN2. From 0 to 1023.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property AN2() As Integer
        Get
            Return _AN2Current
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital one input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInOne As Boolean
        Get
            Return _digitalInOne
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital two input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInTwo As Boolean
        Get
            Return _digitalInTwo
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital three input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInThree As Boolean
        Get
            Return _digitalInThree
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital four input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInFour As Boolean
        Get
            Return _digitalInFour
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital five input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInFive As Boolean
        Get
            Return _digitalInFive
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital six input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInSix As Boolean
        Get
            Return _digitalInSix
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital seven input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInSeven As Boolean
        Get
            Return _digitalInSeven
        End Get
    End Property

    ''' <summary>
    ''' Returns the state of the digital eight input.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DInEight As Boolean
        Get
            Return _digitalInEight
        End Get
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output one.
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutOne As Boolean
        Get
            Return _digitalOutOne
        End Get
        Set(value As Boolean)
            _digitalOutOne = value
            UpdateDigitalOutputs()
        End Set
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output two
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutTwo As Boolean
        Get
            Return _digitalOutTwo
        End Get
        Set(value As Boolean)
            _digitalOutTwo = value
            UpdateDigitalOutputs()
        End Set
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output three.
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutThree As Boolean
        Get
            Return _digitalOutThree
        End Get
        Set(value As Boolean)
            _digitalOutThree = value
            UpdateDigitalOutputs()
        End Set
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output four.
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutFour As Boolean
        Get
            Return _digitalOutFour
        End Get
        Set(value As Boolean)
            _digitalOutFour = value
            UpdateDigitalOutputs()
        End Set
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output five.
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutFive As Boolean
        Get
            Return _digitalOutFive
        End Get
        Set(value As Boolean)
            _digitalOutFive = value
            UpdateDigitalOutputs()
        End Set
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output six.
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutSix As Boolean
        Get
            Return _digitalOutSix
        End Get
        Set(value As Boolean)
            _digitalOutSix = value
            UpdateDigitalOutputs()
        End Set
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output seven.
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutSeven As Boolean
        Get
            Return _digitalOutSeven
        End Get
        Set(value As Boolean)
            _digitalOutSeven = value
            UpdateDigitalOutputs()
        End Set
    End Property

    ''' <summary>
    ''' State of the Qy@ board digital output eight.
    ''' </summary>
    ''' <returns></returns>
    Public Property DOutEight As Boolean
        Get
            Return _digitalOutEight
        End Get
        Set(value As Boolean)
            _digitalOutEight = value
            UpdateDigitalOutputs()
        End Set
    End Property

    '######______Private Subroutines______######

    Private Sub UpdateDigitalOutputs()
        Dim writeBytes(1) As Byte
        writeBytes(0) = &B_00100000
        Dim digitalOutputs As Integer = 0

        If _digitalOutEight Then
            digitalOutputs += 128
        End If
        If _digitalOutSeven Then
            digitalOutputs += 64
        End If
        If _digitalOutSix Then
            digitalOutputs += 32
        End If
        If _digitalOutFive Then
            digitalOutputs += 16
        End If
        If _digitalOutFour Then
            digitalOutputs += 8
        End If
        If _digitalOutThree Then
            digitalOutputs += 4
        End If
        If _digitalOutTwo Then
            digitalOutputs += 2
        End If
        If _digitalOutOne Then
            digitalOutputs += 1
        End If

        writeBytes(1) = CByte(digitalOutputs)

        Try
            serialPort.Write(writeBytes, 0, 2)
        Catch ex As Exception

        End Try
    End Sub


    '######______Public Subroutines______######

    Public Sub New()
        'set timer intervals
        verificationTimer.Interval = 3000
        disconnectTimer.Interval = 100

        'configure serial port
        serialPort.BaudRate = 9600
        serialPort.DataBits = 8
        serialPort.StopBits = IO.Ports.StopBits.One
        serialPort.Parity = Parity.None
    End Sub

    ''' <summary>
    ''' Start the COM connection to the Qy@ board
    ''' </summary>
    Public Sub StartConnection()
        Dim writeBytes(0) As Byte
        writeBytes(0) = &HF0

        Try
            serialPort.Open()
        Catch ex As Exception
            RaiseEvent InvalidComPort()
        End Try

        If serialPort.IsOpen Then
            Try
                serialPort.Write(writeBytes, 0, 1)
                verificationTimer.Start()
                _queryBoard = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    ''' <summary>
    ''' Stop the COM connection to the Qy@ board
    ''' </summary>
    Public Sub StopConnection()
        Try
            serialPort.Close()
            _connected = False
        Catch ex As Exception

        End Try
    End Sub


    '######______Event Handlers______######

    ''' <summary>
    ''' Handles receiving data from the Qy@ board. Also requests all input values.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub serialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        Dim requestInputs(1) As Byte
        requestInputs(0) = &H53 'request AN1 and AN2
        requestInputs(1) = &B_00110000 'request digital inputs

        Dim bytesToRead As Integer = serialPort.BytesToRead
        Console.WriteLine($"{bytesToRead} Received")
        Dim readBytes(bytesToRead - 1) As Byte
        Dim digitalInput As Integer
        Dim tempDigital As Boolean

        If _queryBoard Then
            If bytesToRead >= 64 Then
                Try
                    serialPort.Read(readBytes, 0, bytesToRead) 'read the Qy@ board settings out
                Catch ex As Exception
                End Try
                If Not (readBytes(58) = &H51 And readBytes(59) = &H79 And readBytes(60) = &H40) Then
                    serialPort.Close()
                    verificationTimer.Stop()
                    _queryBoard = False
                    RaiseEvent InvalidComPort() 'not the Qy@ board, raise the invalid event
                    Exit Sub
                Else
                    'Qy@ board detected, disable the timeout timer, start the disconnect check timer, request status of inputs
                    verificationTimer.Stop()
                    _queryBoard = False
                    disconnectTimer.Enabled = True
                    disconnectTimer.Start()
                    _connected = True

                    RaiseEvent ConnectionMade()

                    Try
                        serialPort.Write(requestInputs, 0, 2)
                    Catch ex As Exception

                    End Try

                End If
            Else
                Exit Sub 'skip everything if querying the board and not enough data has showed up.
            End If

        Else 'connected to serial port, expecting inputs back
            If bytesToRead >= 5 Then 'if bytes to read is greater than or equal to the expected number of bytes
                Try
                    serialPort.Read(readBytes, 0, 5) 'read the Qy@ board settings out

                    If Not _AN1Current = (readBytes(0) * 4) + (readBytes(1) \ 64) Then
                        _AN1Current = (readBytes(0) * 4) + (readBytes(1) \ 64)
                        RaiseEvent AN1Changed()
                    Else
                        _AN1Current = (readBytes(0) * 4) + (readBytes(1) \ 64)
                    End If

                    If Not _AN2Current = (readBytes(2) * 4) + (readBytes(3) \ 64) Then
                        _AN2Current = (readBytes(2) * 4) + (readBytes(3) \ 64)
                        RaiseEvent AN2Changed()
                    Else
                        _AN2Current = (readBytes(2) * 4) + (readBytes(3) \ 64)
                    End If

                    digitalInput = CInt(readBytes(4))

                    'check digital input eight
                    tempDigital = _digitalInEight
                    If digitalInput - 128 >= 0 Then
                        _digitalInEight = True
                        digitalInput -= 128
                    Else
                        _digitalInEight = False
                    End If
                    If Not tempDigital = _digitalInEight Then
                        RaiseEvent DigitalInputEightChanged()
                    End If

                    'check digital input seven
                    tempDigital = _digitalInSeven
                    If digitalInput - 64 >= 0 Then
                        _digitalInSeven = True
                        digitalInput -= 64
                    Else
                        _digitalInSeven = False
                    End If
                    If Not tempDigital = _digitalInSeven Then
                        RaiseEvent DigitalInputSevenChanged()
                    End If

                    'check digital input six
                    tempDigital = _digitalInSix
                    If digitalInput - 32 >= 0 Then
                        _digitalInSix = True
                        digitalInput -= 32
                    Else
                        _digitalInSix = False
                    End If
                    If Not tempDigital = _digitalInSix Then
                        RaiseEvent DigitalInputSixChanged()
                    End If

                    'check digital input five
                    tempDigital = _digitalInFive
                    If digitalInput - 16 >= 0 Then
                        _digitalInFive = True
                        digitalInput -= 16
                    Else
                        _digitalInFive = False
                    End If
                    If Not tempDigital = _digitalInFive Then
                        RaiseEvent DigitalInputFiveChanged()
                    End If

                    'check digital input four
                    tempDigital = _digitalInFour
                    If digitalInput - 8 >= 0 Then
                        _digitalInFour = True
                        digitalInput -= 8
                    Else
                        _digitalInFour = False
                    End If
                    If Not tempDigital = _digitalInFour Then
                        RaiseEvent DigitalInputFourChanged()
                    End If

                    'check digital input three
                    tempDigital = _digitalInThree
                    If digitalInput - 4 >= 0 Then
                        _digitalInThree = True
                        digitalInput -= 4
                    Else
                        _digitalInThree = False
                    End If
                    If Not tempDigital = _digitalInThree Then
                        RaiseEvent DigitalInputThreeChanged()
                    End If

                    'check digital input two
                    tempDigital = _digitalInTwo
                    If digitalInput - 2 >= 0 Then
                        _digitalInTwo = True
                        digitalInput -= 2
                    Else
                        _digitalInTwo = False
                    End If
                    If Not tempDigital = _digitalInTwo Then
                        RaiseEvent DigitalInputTwoChanged()
                    End If

                    'check digital input one
                    tempDigital = _digitalInOne
                    If digitalInput - 1 >= 0 Then
                        _digitalInOne = True
                        digitalInput -= 1
                    Else
                        _digitalInOne = False
                    End If
                    If Not tempDigital = _digitalInOne Then
                        RaiseEvent DigitalInputOneChanged()
                    End If

                Catch ex As Exception
                End Try

                Try
                    serialPort.Write(requestInputs, 0, 2)
                Catch ex As Exception

                End Try
            Else
                Exit Sub 'skip everything, still receiving data
            End If
        End If

    End Sub

    ''' <summary>
    ''' If the Qy@ board did not verify in time, raise the InvalidComPort event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub verificationTimer_Tick(sender As Object, e As EventArgs) Handles verificationTimer.Tick
        verificationTimer.Stop()
        _queryBoard = False
        RaiseEvent InvalidComPort()
    End Sub

    ''' <summary>
    ''' If the Qy@ board disconnects after connection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub disconnectTimer_Tick(sender As Object, e As EventArgs) Handles disconnectTimer.Tick
        If Not serialPort.IsOpen Then
            disconnectTimer.Stop()
            _connected = False
            RaiseEvent Disconnected("Qy@ board unexpectedly disconnected.")
        End If
    End Sub
End Class
