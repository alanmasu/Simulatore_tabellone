Public Class frmSim
    Public componetsArr = New String(7) {"punti1", "punti2", "tempo_gioco", "crono_min", "crono_sec", "crono", "punti", "tabellone"}
    Public connesso As Boolean = False
    Public dati As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImpostazioniPorta.Location = New Point(Location.X + Size.Width, Location.Y)
        ImpostazioniPorta.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dati = ImpostazioniPorta.ricevi()
        loopSub(dati)
    End Sub
    Sub loopSub(data As String)
        Dim dataArr() As String
        Dim component As String = ""
        Dim comand As String = ""
        Dim parameter As String
        Dim adder As String = ""
        If data <> "" Then
            dataArr = Split(data, ".")
            If dataArr.Length > 1 Then
                component = dataArr(0)
                comand = dataArr(1)
                If dataArr.Length = 3 Then
                    parameter = dataArr(2)
                End If
            End If
        End If
        For i As Byte = 0 To 7
            If componetsArr(i) = component Then
                If comand = "write" Then
                    Select Case component
                        Case "punti1"
                            punti1.Text = parameter
                        Case "punti2"
                            punti2.Text = parameter
                        Case "tempo_gioco"
                            tempo_gioco.Text = parameter
                        Case "crono_min"
                            crono_min.Text = parameter
                        Case "crono_sec"
                            crono_sec.Text = parameter
                    End Select

                ElseIf comand = "read" & vbcrLf Then
                    Select Case component
                        Case "punti1"
                            parameter = CInt(punti1.Text)
                        Case "punti2"
                            parameter = CInt(punti2.Text)
                        Case "tempo_gioco"
                            parameter = tempo_gioco.Text
                        Case "crono_min"
                            parameter = crono_min.Text
                        Case "crono_sec"
                            parameter = crono_sec.Text
                    End Select
                    Dim toSend As String
                    toSend = "read;" & component & ";" & parameter & vbLf
                    SerialPort1.Write(toSend)
                ElseIf comand = "reset" & vbCrLf Then
                    Select Case component
                        Case "punti"
                            punti1.Text = "0"
                            punti2.Text = "0"
                        Case "crono"
                            crono_min.Text = "0"
                            crono_sec.Text = "0"
                        Case "tempo_gioco"
                            tempo_gioco.Text = "0"
                        Case "tabellone"
                            punti1.Text = "0"
                            punti2.Text = "0"
                            crono_sec.Text = "0"
                            crono_min.Text = "0"
                            tempo_gioco.Text = "0"
                    End Select
                Else
                    If component = "crono" Then
                        crono_min.Text = comand
                        crono_sec.Text = parameter
                    End If
                End If
            End If
        Next

    End Sub
    Private Sub frmSim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connesso = True Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If connesso = True Then
            Serial.Location = New Point(Location.X + Size.Width, Location.Y + ImpostazioniPorta.Size.Height)
            Serial.Show()
        Else
            MsgBox("Porta seriale non connessa!!!", vbCritical + vbOKOnly, "Err")
        End If
    End Sub
End Class
