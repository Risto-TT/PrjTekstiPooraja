Public Class TekstiOmadused
    Implements ITeisendaja


    ' Klassi TekstiPooraja attribuudid (muutujad)
    Private AlgusSymbol As Integer
    Private LoppSymbol As Integer
    Private PooratavTekst As String

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

    Public Sub TeisendaTekst(ByRef sisendTekst As String) Implements ITeisendaja.TeisendaTekst
        Throw New NotImplementedException()
    End Sub

    Public Function PooraTekst() As String Implements ITeisendaja.PooraTekst
        Throw New NotImplementedException()
    End Function

    Public Function GetVowelCount() As Integer Implements ITeisendaja.GetVowelCount
        Dim VowelCount As Integer = 0
        Dim Vowels As String = "aeiouöäüõ"

        For Each ch In PooratavTekst.ToLower

            If Vowels.Contains(ch) Then
                VowelCount += 1
            End If
        Next
        Return VowelCount
    End Function

    Public Sub ProcessASCII(ByRef sisendTekst As String) Implements ITeisendaja.ProcessASCII

        PooratavTekst = sisendTekst

        If (sisendTekst.Length < 1) Then
            Exit Sub
        Else
            EsimeseTaheAsciiKood = Asc(sisendTekst(0))
            ViimaseTaheAsciiKood = Asc(sisendTekst(sisendTekst.Length - 1))
        End If

    End Sub

End Class
