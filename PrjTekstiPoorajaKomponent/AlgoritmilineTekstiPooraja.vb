﻿Public Class AlgoritmilineTekstiPooraja
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

    Public Sub ProcessASCII(ByRef sisendTekst As String) Implements ITeisendaja.ProcessASCII
        Throw New NotImplementedException()
    End Sub

    ' Meetod võtab parameetrina edastatud sõne, pöörab
    ' selle tagurpidi ning salvestab atribuuti PooratavTekst
    Private Sub TeisendaTekst(ByRef sisendTekst As String) _
        Implements ITeisendaja.TeisendaTekst

        For Each ch In sisendTekst
            PooratavTekst = ch + PooratavTekst
        Next


    End Sub

    Public Function GetVowelCount() As Integer Implements ITeisendaja.GetVowelCount
        Throw New NotImplementedException()
    End Function

    ' Meetod võtab atribuudist PooratavTekst väärtuse, 
    ' pöörab selle tagurpidi ja tagastab selle
    Private Function PooraTekst() As String Implements ITeisendaja.PooraTekst
        Dim ans As String = ""
        For Each ch In PooratavTekst
            ans = ch + ans
        Next
        Return ans
    End Function
End Class
