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
<Serializable> Public Class cHIV

    Inherits cDisease
    Implements InterDisease
    Private _YearNewCases As Integer
    Private _YearRecoveries As Integer
    Private _YearDeaths As Integer
    Private _Cross As Integer 'Number of people cross infected with TB
    Private _NotArt As Integer 'Number of people without access to Anti RetroViral Treatment
    Private _Condoms As Boolean 'Whether or not Condoms were freely distributed that year
    Private Shared _NumYears As Integer 'Number of years of Observation
    Private ReadOnly _Symptoms(8) As String 'Array of Symptoms
    Private _NumSymp As Integer

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
        _Symptoms(5) = "Chills"
        _Symptoms(6) = "Sore throat"
        _Symptoms(7) = "Swollen Lymph Nodes"
        _Symptoms(8) = "Ulcers"
        _NumSymp = _Symptoms.Length
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
    ' Property methods From interDisease
    Public ReadOnly Property YearNewCases As Integer Implements InterDisease.YearNewCases
        Get
            Return _YearNewCases
        End Get
    End Property

    Public ReadOnly Property YearRecoveries As Integer Implements InterDisease.YearRecoveries
        Get
            Return _YearRecoveries
        End Get
    End Property

    Public ReadOnly Property YearDeaths As Integer Implements InterDisease.YearDeaths
        Get
            Return _YearDeaths
        End Get
    End Property

    Public Overrides Function Display() As String
        'Return the year number, and the value of the base classes display
        Dim dis As String = "Year: " & _NumYears & Environment.NewLine & MyBase.Display
        'Add the derived class unique variables
        dis &= "Cases: " & _YearNewCases & Environment.NewLine _
            & "Deaths: " & _YearDeaths & Environment.NewLine _
              & "Untreated: " & _NotArt & Environment.NewLine _
               & "Free Condoms: " & _Condoms & Environment.NewLine
        Return dis
    End Function

    'Private Function calcTotalCases() As Integer
    'Dim td As Integer
    'td = _TotalCases - (_Yearnewdeaths(_NumYears) + recoveries())
    'End Function
    Public Sub Removeoneyear()
        _NumYears -= 1
    End Sub

    Public Function CollectSymptoms(value As String) As Boolean
        For i As Integer = 1 To _Symptoms.Length - 1
            If value = _Symptoms(i) Then
                Return True
                Exit Function
            End If
        Next i
        Return False
    End Function
End Class
