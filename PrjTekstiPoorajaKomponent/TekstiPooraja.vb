Public Class TekstiPooraja
    Implements ITeisendaja

    ' Klassi TekstiPooraja attribuudid (muutujad)
    Private AlgusSymbol As Integer
    Private LoppSymbol As Integer
    Private PooratavTekst As Integer

    ' Atribuut EsimeseTaheAsciiKood seadistamine
    Private Property EsimeseTaheAsciiKood As Integer Implements ITeisendaja.EsimeseTaheAsciiKood
        Get
            Return AlgusSymbol    ' Atribuudi küsimisel tagastame AlgusSymbol väärtuse
        End Get
        Set(value As Integer)
            AlgusSymbol = value   ' Salvestame atribuudile antava väärtuse
        End Set
    End Property

    ' Atribuut ViimaseTaheAsciiKood seadistamine
    Private Property ViimaseTaheAsciiKood As Integer Implements ITeisendaja.ViimaseTaheAsciiKood
        Get
            Return LoppSymbol     ' Atribuudi küsimisel tagastame LoppSymbol väärtuse
        End Get
        Set(value As Integer)
            LoppSymbol = value    ' Salvestame atribuudile antava väärtuse
        End Set
    End Property

    ' Atribuut Tekst seadistamine
    Private Property Tekst As String Implements ITeisendaja.Tekst
        Get
            Return PooratavTekst  ' Atribuudi küsimisel tagastame PooratavTekst väärtuse
        End Get
        Set(value As String)
            PooratavTekst = value ' Salvestame atribuudile antava väärtuse
        End Set
    End Property

    ' Meetod võtab parameetrina edastatud sõne, pöörab
    ' selle tagurpidi ning salvestab atribuuti PooratavTekst
    Private Sub TeisendaTekst(ByRef sisendTekst As String) _
        Implements ITeisendaja.TeisendaTekst
        PooratavTekst = StrReverse(sisendTekst)
    End Sub

    ' Meetod võtab atribuudist PooratavTekst väärtuse, 
    ' pöörab selle tagurpidi ja tagastab selle
    Private Function PooraTekst() As String _
        Implements ITeisendaja.PooraTekst
        Return StrReverse(PooratavTekst)
    End Function
End Class
