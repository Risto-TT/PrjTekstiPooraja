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
        Me.ChkAlgoritmiline = New System.Windows.Forms.CheckBox()
        Me.LblAscii = New System.Windows.Forms.Label()
        Me.LblTaisHaalik = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(201, 48)
        Me.txtSisendTekst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(388, 26)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(201, 102)
        Me.txtValjundTekst1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(388, 26)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(201, 191)
        Me.txtValjundTekst2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(388, 26)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'btnPooraFunktsiooniga
        '
        Me.btnPooraFunktsiooniga.Location = New System.Drawing.Point(276, 142)
        Me.btnPooraFunktsiooniga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPooraFunktsiooniga.Name = "btnPooraFunktsiooniga"
        Me.btnPooraFunktsiooniga.Size = New System.Drawing.Size(204, 35)
        Me.btnPooraFunktsiooniga.TabIndex = 3
        Me.btnPooraFunktsiooniga.Text = "Pööra funktsiooniga"
        Me.btnPooraFunktsiooniga.UseVisualStyleBackColor = True
        '
        'btnPooraProtseduuriga
        '
        Me.btnPooraProtseduuriga.Location = New System.Drawing.Point(276, 232)
        Me.btnPooraProtseduuriga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPooraProtseduuriga.Name = "btnPooraProtseduuriga"
        Me.btnPooraProtseduuriga.Size = New System.Drawing.Size(204, 35)
        Me.btnPooraProtseduuriga.TabIndex = 4
        Me.btnPooraProtseduuriga.Text = "Pööra protseduuriga"
        Me.btnPooraProtseduuriga.UseVisualStyleBackColor = True
        '
        'lblSisendTekst
        '
        Me.lblSisendTekst.AutoSize = True
        Me.lblSisendTekst.Location = New System.Drawing.Point(99, 52)
        Me.lblSisendTekst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSisendTekst.Name = "lblSisendTekst"
        Me.lblSisendTekst.Size = New System.Drawing.Size(93, 20)
        Me.lblSisendTekst.TabIndex = 5
        Me.lblSisendTekst.Text = "Sisendtekst"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pööramine funktsiooniga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pööramine protseduuriga"
        '
        'TimerUuenda
        '
        Me.TimerUuenda.Interval = 3000
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(246, 331)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 35)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(368, 331)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(112, 35)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stopp"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'LblPikkus
        '
        Me.LblPikkus.AutoSize = True
        Me.LblPikkus.Location = New System.Drawing.Point(602, 57)
        Me.LblPikkus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPikkus.Name = "LblPikkus"
        Me.LblPikkus.Size = New System.Drawing.Size(72, 20)
        Me.LblPikkus.TabIndex = 10
        Me.LblPikkus.Text = "Pikkus: 0"
        '
        'TimerUuenduseni
        '
        Me.TimerUuenduseni.Enabled = True
        '
        'ChkAlgoritmiline
        '
        Me.ChkAlgoritmiline.AutoSize = True
        Me.ChkAlgoritmiline.Location = New System.Drawing.Point(276, 290)
        Me.ChkAlgoritmiline.Name = "ChkAlgoritmiline"
        Me.ChkAlgoritmiline.Size = New System.Drawing.Size(177, 24)
        Me.ChkAlgoritmiline.TabIndex = 11
        Me.ChkAlgoritmiline.Text = "Algoritmiline pööraja"
        Me.ChkAlgoritmiline.UseVisualStyleBackColor = True
        '
        'LblAscii
        '
        Me.LblAscii.AutoSize = True
        Me.LblAscii.Location = New System.Drawing.Point(602, 102)
        Me.LblAscii.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAscii.Name = "LblAscii"
        Me.LblAscii.Size = New System.Drawing.Size(102, 20)
        Me.LblAscii.TabIndex = 12
        Me.LblAscii.Text = "ASCII: [ - :  - ]"
        '
        'LblTaisHaalik
        '
        Me.LblTaisHaalik.AutoSize = True
        Me.LblTaisHaalik.Location = New System.Drawing.Point(602, 142)
        Me.LblTaisHaalik.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTaisHaalik.Name = "LblTaisHaalik"
        Me.LblTaisHaalik.Size = New System.Drawing.Size(64, 20)
        Me.LblTaisHaalik.TabIndex = 13
        Me.LblTaisHaalik.Text = "Täish: 0"
        '
        'FormKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 392)
        Me.Controls.Add(Me.LblTaisHaalik)
        Me.Controls.Add(Me.LblAscii)
        Me.Controls.Add(Me.ChkAlgoritmiline)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents ChkAlgoritmiline As CheckBox
    Friend WithEvents LblAscii As Label
    Friend WithEvents LblTaisHaalik As Label
End Class
