Imports System.Threading
Public Class Form1


    Sub GetSerialPortNames()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            CB_Sports.Items.Add(sp)
        Next
    End Sub
    Sub ReadSerialPort(Port As String, Baudrate As Integer)
        My.Computer.Ports.OpenSerialPort(Port, Baudrate)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetSerialPortNames()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
