Public Interface ITeisendaja
    Property EsimeseTaheAsciiKood As Integer ' Teksti esimese sümboli ASCII kood
    Property ViimaseTaheAsciiKood As Integer ' Teksti viimase sümboli ASCII kood
    Property Tekst As String                 ' Kasutaja sisestatud tekst

    Function PooraTekst() As String          ' Liidese meetodid koodi ei oma
    Sub TeisendaTekst(ByRef sisendTekst As String)

    Function GetVowelCount() As Integer

    Sub ProcessASCII(ByRef sisendTekst As String)

End Interface

