
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
' Class name: cDisease
' *****************************************************************
Public Class cDisease
    'Variable Declaration
    Private _Name As String 'Disease name.
    Private _InfectionRate As Double 'Infection rate of the disease.
    Private _RecoveryRate As Double 'Recovery rate of the disease.
    Private _Symptoms() As String 'Array string all symptoms of the disease. | _NumSymptoms
    Private _TotalCases As Integer 'Total number of cases for each recorded year.
    Private _TotalDeaths As Integer 'Total number of deaths for each recorded year.
    Private _TotalRecovers As Integer 'Total number of recoveries for each recorded year.
    Private _YearNewCases() As Integer 'Array storing number of new cases for each recorded year. | _NumYears
    Private _YearDeaths() As Integer 'Array storing number of deaths for each recorded year. | _NumYears
    Private _YearRecoveries() As Integer 'Array storing number of recoveries for each recorded year. | _NumYears
    Private _NumSymptoms As Integer 'Number of symptoms to record for.
    Private _NumYears As Integer 'Number of years to record for.
    Public Sub New(Name As String, InfectionRate As Double, RecoveryRate As Double, NumSymptoms As Integer, Symptoms() As String)
        _Name = Name
        _InfectionRate = InfectionRate
        _RecoveryRate = RecoveryRate
        _NumSymptoms = NumSymptoms
        ReDim _Symptoms(_NumSymptoms)
        _Symptoms = Symptoms
    End Sub
    Public Sub New()

    End Sub
    Public ReadOnly Property TotalDeaths As Integer
        Get
            Dim tempTotal As Integer
            For Each i As Integer In _YearDeaths
                tempTotal += _YearDeaths(i)
            Next
            Return tempTotal
        End Get
    End Property
End Class
