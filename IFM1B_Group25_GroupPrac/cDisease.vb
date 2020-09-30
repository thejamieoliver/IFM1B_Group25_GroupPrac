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
    Private _Name As String
    Private _InfectionRate As Double
    Private _RecoveryRate As Double
    Private _Symptoms() As String
    Private _TotalCases As Integer
    Private _TotalDeaths As Integer
    Private _TotalRecovers As Integer
    Private _YearNewCases() As Integer
    Private _YearDeaths() As Integer
    Private _YearRecoveries() As Integer

    Public Sub New(Name As String, InfectionRate As Double, RecoveryRate As Double)
        _Name = Name
        _InfectionRate = InfectionRate
        _RecoveryRate = RecoveryRate
    End Sub
End Class

