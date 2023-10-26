Imports System.ComponentModel

Public Class ImpostazioniPorta
    'All'avvio aggiunge items alla combo
    Private Sub ImpostazioniPorta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub
    'btnAggiorna
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub
    'btnConnetti
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSim.SerialPort1.Close()
        'to work
        'frmSim.connesso = True
        'Label3.Text = "Connesso"
        'Label3.ForeColor = Color.Green
        'Button4.Enabled = True
        'Button2.Enabled = False
        'Button3.Enabled = False
        'frmSim.Text = "Simulatore tabellone - ON " & frmSim.SerialPort1.PortName
        'frmSim.Timer1.Start()
        'TimerSerial.Stop()
        'MsgBox("Connessione avvenuta con successo!!", vbInformation)
        '/towork
        If ComboBox1.Text Is "" Then
            MsgBox("La porta non può essere vuota!!!", MsgBoxStyle.Critical, "Errore")
        Else
            Try
                'inizializzo la porta seriale
                frmSim.SerialPort1.Encoding = System.Text.Encoding.Default
                frmSim.SerialPort1.PortName = ComboBox1.Text
                frmSim.SerialPort1.Open()
                'invio un messaggio di verifica
                frmSim.SerialPort1.Write("Sei Arduino?" & vbLf)
                scaduta = False
                TimerSerial.Start()
                'Timer1.Start()
                Serial.Timer1.Stop()
            Catch ex As Exception
                MsgBox("Errore: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub
    'btnChiudi
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmSim.SerialPort1.Write("Disconesso")
        frmSim.SerialPort1.Close()
        frmSim.connesso = False
        Button2.Enabled = True
        Button3.Enabled = True
        ComboBox1.Enabled = True
        Button4.Enabled = False
        Label3.Text = "Disconnesso"
        Label3.ForeColor = Color.Red
        frmSim.Text = "Simulatore tabellone"
    End Sub
    Function ricevi() As String
        Dim dati As String, datiArr() As String
        Try
            dati = frmSim.SerialPort1.ReadExisting
            'dati = frmSim.SerialPort1.ReadLine
            If dati <> Nothing Then
                'If InStr(dati, vbLf) > 0 Then
                'datiArr = Split(dati, vbCrLf)
                'If datiArr(0).Length > 9 Then
                'Return datiArr(0) + vbLf
                'End If
                'End If
                Return dati
            End If
            Return ""
        Catch ex As Exception
            Return "Errore: " & ex.Message
        End Try
    End Function
    Dim scaduta As Boolean = False
    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Dim str As String
        str = ricevi()
        If str <> "" Then
            If scaduta = False Then
                'If str = "Si sono Arduino!" & vbLf Then
                frmSim.connesso = True
                    Label3.Text = "Connesso"
                    Label3.ForeColor = Color.Green
                    Button4.Enabled = True
                    Button2.Enabled = False
                    Button3.Enabled = False
                    frmSim.Text = "Simulatore tabellone - ON " & frmSim.SerialPort1.PortName
                    frmSim.Timer1.Start()
                    TimerSerial.Stop()
                    MsgBox("Connessione avvenuta con successo!!", vbInformation)
                'Hide()
                'End If
            Else
                TimerSerial.Stop()
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If frmSim.connesso = False Then
            Timer1.Stop()
            MsgBox("Connessione non avvenuta con successo!!", vbCritical + vbOKOnly, "Err")
            frmSim.SerialPort1.Close()
            scaduta = True
        Else
            Timer1.Stop()
        End If
        Timer1.Stop()
    End Sub
End Class