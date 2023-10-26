<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSim
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.punti1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.punti2 = New System.Windows.Forms.Label()
        Me.tempo_gioco = New System.Windows.Forms.Label()
        Me.crono_sec = New System.Windows.Forms.Label()
        Me.crono_min = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(613, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'punti1
        '
        Me.punti1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punti1.ForeColor = System.Drawing.Color.Red
        Me.punti1.Location = New System.Drawing.Point(61, 57)
        Me.punti1.Name = "punti1"
        Me.punti1.Size = New System.Drawing.Size(140, 73)
        Me.punti1.TabIndex = 5
        Me.punti1.Text = "000"
        Me.punti1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Punti 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(447, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Punti 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'punti2
        '
        Me.punti2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punti2.ForeColor = System.Drawing.Color.Red
        Me.punti2.Location = New System.Drawing.Point(447, 57)
        Me.punti2.Name = "punti2"
        Me.punti2.Size = New System.Drawing.Size(140, 73)
        Me.punti2.TabIndex = 7
        Me.punti2.Text = "000"
        Me.punti2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tempo_gioco
        '
        Me.tempo_gioco.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempo_gioco.ForeColor = System.Drawing.Color.Red
        Me.tempo_gioco.Location = New System.Drawing.Point(271, 174)
        Me.tempo_gioco.Name = "tempo_gioco"
        Me.tempo_gioco.Size = New System.Drawing.Size(68, 73)
        Me.tempo_gioco.TabIndex = 9
        Me.tempo_gioco.Text = "0"
        Me.tempo_gioco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'crono_sec
        '
        Me.crono_sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crono_sec.ForeColor = System.Drawing.Color.Red
        Me.crono_sec.Location = New System.Drawing.Point(345, 305)
        Me.crono_sec.Name = "crono_sec"
        Me.crono_sec.Size = New System.Drawing.Size(104, 73)
        Me.crono_sec.TabIndex = 10
        Me.crono_sec.Text = "00"
        Me.crono_sec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'crono_min
        '
        Me.crono_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crono_min.ForeColor = System.Drawing.Color.Red
        Me.crono_min.Location = New System.Drawing.Point(179, 305)
        Me.crono_min.Name = "crono_min"
        Me.crono_min.Size = New System.Drawing.Size(104, 73)
        Me.crono_min.TabIndex = 11
        Me.crono_min.Text = "00"
        Me.crono_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(289, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 73)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = ":"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(237, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 32)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tempo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(324, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 32)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Secondi"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(161, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 32)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Minuti"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(613, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "S"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(657, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.crono_min)
        Me.Controls.Add(Me.crono_sec)
        Me.Controls.Add(Me.tempo_gioco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.punti2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.punti1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Simulatore tabellone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents punti1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents punti2 As Label
    Friend WithEvents tempo_gioco As Label
    Friend WithEvents crono_sec As Label
    Friend WithEvents crono_min As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
End Class
