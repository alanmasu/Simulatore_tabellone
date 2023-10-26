Imports System.ComponentModel

Public Class Serial
    Private Sub Serial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSim.Timer1.Stop()
        Timer1.Start()
        If frmSim.connesso = True Then
            Text = "Serial - ON " & frmSim.SerialPort1.PortName
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim data As String = ImpostazioniPorta.ricevi()
        If frmSim.connesso = True Then
            If data <> "" Then
                TextBox2.Text += data
                TextBox2.SelectionStart = Len(TextBox2.Text)
                TextBox2.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If frmSim.connesso = True Then
            frmSim.SerialPort1.Write(TextBox1.Text)
        End If
    End Sub
    Private Sub Serial_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmSim.Timer1.Start()
    End Sub
End Class