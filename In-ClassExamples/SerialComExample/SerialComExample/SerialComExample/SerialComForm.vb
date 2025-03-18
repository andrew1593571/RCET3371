Public Class SerialComForm
    Private RequestAnalog As Boolean
    Private Sub SerialComForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComSetup()
        CheckAnalogTimer.Start()
        RequestAnalog = False
    End Sub

    Sub ComSetup()
        Dim bytes(0) As Byte

        bytes(0) = &B11110000

        SerialPort.PortName = "COM4"
        SerialPort.Open()

        SerialPort.Write(bytes, 0, 1)

    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim numberOfBytes = SerialPort.BytesToRead
        Dim bytes(numberOfBytes - 1) As Byte
        Dim writeBytes(1) As Byte
        writeBytes(0) = &B_00100000

        Console.WriteLine(numberOfBytes)

        SerialPort.Read(bytes, 0, numberOfBytes)

        For Each thingy In bytes
            Console.WriteLine($"D: {thingy.ToString.PadLeft(3)} 0x{Hex(thingy).ToString.PadRight(3)} ASCII: {Chr(thingy)}")
        Next

        If RequestAnalog Then
            Select Case bytes(0)
                Case > 224
                    writeBytes(1) = &B_11111111
                Case > 193
                    writeBytes(1) = &B_01111111
                Case > 162
                    writeBytes(1) = &B_00111111
                Case > 131
                    writeBytes(1) = &B_00011111
                Case > 100
                    writeBytes(1) = &B_00001111
                Case > 69
                    writeBytes(1) = &B_00000111
                Case > 38
                    writeBytes(1) = &B_00000011
                Case > 0
                    writeBytes(1) = &B_00000001
            End Select
            SerialPort.Write(writeBytes, 0, 2)
            RequestAnalog = False
        End If
    End Sub

    Private Sub CheckAnalogTimer_Tick(sender As Object, e As EventArgs) Handles CheckAnalogTimer.Tick
        Dim writeBytes(0) As Byte
        writeBytes(0) = &B_01010001

        ;SerialPort.Write(writeBytes, 0, 1) 'Request the analog input 1 value

        RequestAnalog = True
    End Sub
End Class
