<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasutajaAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.btnPooraFunktsiooniga = New System.Windows.Forms.Button()
        Me.btnPooraProtseduuriga = New System.Windows.Forms.Button()
        Me.lblSisendTekst = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.LblPikkus = New System.Windows.Forms.Label()
        Me.TimerUuenduseni = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(134, 31)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(260, 20)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(134, 66)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(260, 20)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(134, 124)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(260, 20)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'btnPooraFunktsiooniga
        '
        Me.btnPooraFunktsiooniga.Location = New System.Drawing.Point(184, 92)
        Me.btnPooraFunktsiooniga.Name = "btnPooraFunktsiooniga"
        Me.btnPooraFunktsiooniga.Size = New System.Drawing.Size(136, 23)
        Me.btnPooraFunktsiooniga.TabIndex = 3
        Me.btnPooraFunktsiooniga.Text = "Pööra funktsiooniga"
        Me.btnPooraFunktsiooniga.UseVisualStyleBackColor = True
        '
        'btnPooraProtseduuriga
        '
        Me.btnPooraProtseduuriga.Location = New System.Drawing.Point(184, 151)
        Me.btnPooraProtseduuriga.Name = "btnPooraProtseduuriga"
        Me.btnPooraProtseduuriga.Size = New System.Drawing.Size(136, 23)
        Me.btnPooraProtseduuriga.TabIndex = 4
        Me.btnPooraProtseduuriga.Text = "Pööra protseduuriga"
        Me.btnPooraProtseduuriga.UseVisualStyleBackColor = True
        '
        'lblSisendTekst
        '
        Me.lblSisendTekst.AutoSize = True
        Me.lblSisendTekst.Location = New System.Drawing.Point(66, 34)
        Me.lblSisendTekst.Name = "lblSisendTekst"
        Me.lblSisendTekst.Size = New System.Drawing.Size(62, 13)
        Me.lblSisendTekst.TabIndex = 5
        Me.lblSisendTekst.Text = "Sisendtekst"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pööramine funktsiooniga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pööramine protseduuriga"
        '
        'TimerUuenda
        '
        Me.TimerUuenda.Interval = 3000
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(164, 196)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(245, 196)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stopp"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'LblPikkus
        '
        Me.LblPikkus.AutoSize = True
        Me.LblPikkus.Location = New System.Drawing.Point(401, 37)
        Me.LblPikkus.Name = "LblPikkus"
        Me.LblPikkus.Size = New System.Drawing.Size(51, 13)
        Me.LblPikkus.TabIndex = 10
        Me.LblPikkus.Text = "Pikkus: 0"
        '
        'TimerUuenduseni
        '
        Me.TimerUuenduseni.Enabled = True
        '
        'FormKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 253)
        Me.Controls.Add(Me.LblPikkus)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSisendTekst)
        Me.Controls.Add(Me.btnPooraProtseduuriga)
        Me.Controls.Add(Me.btnPooraFunktsiooniga)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Name = "FormKasutajaAken"
        Me.Text = "Tekstitöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents btnPooraFunktsiooniga As Button
    Friend WithEvents btnPooraProtseduuriga As Button
    Friend WithEvents lblSisendTekst As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TimerUuenda As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents LblPikkus As Label
    Friend WithEvents TimerUuenduseni As Timer
End Class
