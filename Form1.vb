Imports System.Threading
Public Class Form1


    Sub GetSerialPortNames()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            CB_Sports.Items.Add(sp)
        Next
    End Sub
    Sub ReadSerialPort()
        Debug.WriteLine(CB_Sports.Items(CB_Sports.SelectedIndex).ToString())
        CB_Sports.Items(CB_Sports.SelectedIndex).ToString()
        Dim serialPort = My.Computer.Ports.OpenSerialPort(CB_Sports.SelectedItem, Int(CB_BAUD.SelectedItem))
        serialPort.DataBits = Int(CB_Data_Bits.SelectedItem)
        serialPort.StopBits = Int(CB_StopBits.SelectedItem)
        serialPort.WriteLine("TEST")
        serialPort.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetSerialPortNames()
        CB_BAUD.SelectedIndex = 0
        CB_Data_Bits.SelectedIndex = 0
        CB_StopBits.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CB_Sports.SelectedIndex <> -1 And CB_BAUD.SelectedIndex <> -1 And CB_Data_Bits.SelectedIndex <> -1 And CB_StopBits.SelectedIndex <> -1 Then
            ReadSerialPort()
        Else
            MsgBox("Invalid Parameters selected", MsgBoxStyle.OkOnly, "Parameter error.")
        End If
    End Sub
End Class
