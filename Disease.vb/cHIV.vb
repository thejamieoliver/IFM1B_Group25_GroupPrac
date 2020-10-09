Option Strict On
Option Explicit On
Option Infer Off
' *****************************************************************
' Team Number: 25
' Team Member 1 Details: Crossling, CJ (220108433)
' Team Member 2 Details: Milne, R (220036931)
' Team Member 3 Details: Ogden, AR (220078628)
' Team Member 4 Details: Oliver, J (220015262)
' Practical: Team Project
' Class name: cHIV
' *****************************************************************
Public Class cHIV

    Inherits cDisease
    Private _YearNewCases As Integer
    Private _YearRecoveries As Integer
    Private _YearDeaths As Integer
    Private _Cross As Integer 'Number of people cross infected with TB
    Private _NotArt As Integer 'Number of people without access to Anti RetroViral Treatment
    Private _Condoms As Boolean 'Whether or not Condoms were freely distributed that year
    Private Shared _NumYears As Integer 'Number of years of Observation
    Private ReadOnly _Symptoms(4) As String 'Array of Symptoms

    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, Population As Integer, noART As Integer, cond As Boolean)
        'Increase numyears by 1
        _NumYears += 1
        'redim all arrays to numyears, preserving past data
        _YearDeaths = MyBase.validInt(YearDeaths) 'Set the current index of YearDeaths to the value passed to the constructor
        _YearRecoveries = MyBase.validInt(YearRecoveries) 'Set the current index of YearRecoveries to the value passed to the constructor
        _YearNewCases = MyBase.validInt(YearCases) 'Set the current index of YearNewCases to the value passed to the constructor
        Cross = CrossTB() 'Set the current index of Cross to the value passed to the constructor (pass it through property method)
        NotArt(_NumYears) = noART 'Set the current index of NotArt to the value passed to the constructor after it has been validated
        _Condoms = cond 'Set the current index of Condoms to the value passed to the constructor 
        MyBase.Population = Population
        _Symptoms(1) = "Chronic Diarrhoea" 'Assign values to the symptoms array
        _Symptoms(2) = "Night Sweats"
        _Symptoms(3) = "Fever"
        _Symptoms(4) = "Rashes"
    End Sub

    'Calculate no of people cross infected with TB
    Private Function CrossTB() As Integer
        Return CInt(Math.Round(_YearNewCases * 0.11))
    End Function
    'Property methods for arrays
    Public Property Cross As Integer
        Get
            Return _Cross
        End Get
        Set(value As Integer)
            'Check if the value _cross is being set to is not Negative
            If value < 0 Then
                _Cross = 0
                'Or Greater than the cases for that year
            ElseIf value > _YearNewCases Then
                _Cross = _YearNewCases
            Else
                'If not, set _Cross to the value
                _Cross = value
            End If
        End Set
    End Property

    Public Property NotArt(i As Integer) As Integer
        Get
            Return _NotArt
        End Get
        Set(value As Integer)
            'Check if the value _NotArt is being set to is not Negative
            If value < 0 Then
                _NotArt = 0
                'Or Greater than the cases for that year
            ElseIf value > _YearNewCases Then
                _NotArt = _YearNewCases
            Else
                'If not, set _Cross to the value
                _NotArt = value
            End If
        End Set
    End Property
    Public Property Condoms(i As Integer) As Boolean
        Get
            Return _Condoms
        End Get
        Set(value As Boolean)
            _Condoms = value
        End Set
    End Property

    'Private Function calcTotalCases() As Integer
    'Dim td As Integer
    'td = _TotalCases - (_Yearnewdeaths(_NumYears) + recoveries())
    'End Function
End Class
