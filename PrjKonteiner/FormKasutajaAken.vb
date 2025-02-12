Public Class FormKasutajaAken
    Private Sub btnPooraFunktsiooniga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraFunktsiooniga.Click

        ' Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Seadistame referentsmuutuja viitama uuele objektile
        If ChkAlgoritmiline.Checked Then
            pooraja = New PrjTekstiPoorajaKomponent.AlgoritmilineTekstiPooraja
        Else
            pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja
        End If


        ' Teostame teksti pööramise kasutades parametriseerimata funktsiooni pooraTekst 
        ' ning liidese atribuuti strTekst

        ' Omistame liidese adribuudile txtSisendTekst tekstiväljal oleva sõne
        pooraja.Tekst = txtSisendTekst.Text

        ' Kasutades komponendis sisalduvat funktsiooni määrame tagastatud
        ' sõne tekstivälja txtValjundTekst1 tekstiks
        txtValjundTekst1.Text = pooraja.PooraTekst
    End Sub

    Private Sub btnPooraProtseduuriga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraProtseduuriga.Click

        ' Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Seadistame referentsmuutuja viitama uuele objektile
        If ChkAlgoritmiline.Checked Then
            pooraja = New PrjTekstiPoorajaKomponent.AlgoritmilineTekstiPooraja
        Else
            pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja
        End If

        ' Teostame teksti pööramise kasutades parametriseeritud protseduuri teisendatekst() 
        ' ning liidese atribuuti strTekst

        ' Kutsume välja komponendis sisalduva protseduuri,
        ' andes kaasa tekstiväljal txtSisendTekst oleva sõne
        pooraja.TeisendaTekst(txtSisendTekst.Text)

        ' Omistame tekstivälja txtValjundTekst2 väärtuseks liidese atribuudi väärtuse
        txtValjundTekst2.Text = pooraja.Tekst
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Vajutus nupul lülitab taimeri TimerUuenda sisse
        TimerUuenda.Enabled = True

        ' Nupp btnStart ise lülitatakse välja, vältimaks korduvat vajutamist
        btnStart.Enabled = False

        ' Nupp btnStop lülitatakse sisse, et taimerit saaks välja lülitad
        btnStop.Enabled = True
    End Sub

    Private Sub TimerUuenda_Tick(sender As Object, e As EventArgs) Handles TimerUuenda.Tick
        ' Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja

        ' Teostame teksti pööramise kasutades parametriseerimata funktsiooni pooraTekst 
        ' ning liidese atribuuti strTekst

        ' Omistame liidese adribuudile txtSisendTekst tekstiväljal oleva sõne
        pooraja.Tekst = txtSisendTekst.Text

        ' Kasutades komponendis sisalduvat funktsiooni määrame tagastatud
        ' sõne tekstivälja txtValjundTekst1 tekstiks
        txtValjundTekst1.Text = pooraja.PooraTekst
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        TimerUuenda.Enabled = False

        btnStart.Enabled = True

        btnStop.Enabled = False
    End Sub

    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        ' Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPoorajaKomponent.TekstiOmadused

        pooraja.ProcessASCII(txtSisendTekst.Text)



        LblTaisHaalik.Text = "Täish " + pooraja.GetVowelCount.ToString

        If txtSisendTekst.Text.Length > 0 Then
            'LblAscii.Text = "[ " + pooraja.EsimeseTaheAsciiKood.ToString + " | " + pooraja.ViimaseTaheAsciiKood.ToString + "]"
            LblAscii.Text = String.Format("[ {0, 3} | {1, 3} ]", pooraja.EsimeseTaheAsciiKood, pooraja.ViimaseTaheAsciiKood)

        Else
            LblAscii.Text = "[ - | - ]"
        End If

        LblPikkus.Text = "Pikkus: " + txtSisendTekst.Text.Length.ToString
    End Sub

End Class
