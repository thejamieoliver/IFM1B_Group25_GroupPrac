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
' Class name: cMalaria
' *****************************************************************
Public Class cMalaria
    Inherits cDisease
    Private _YearNewCases As Integer
    Private _YearRecoveries As Integer
    Private _YearDeaths As Integer
    Private Shared _NumYears As Integer
    Private ReadOnly _Symptoms(7) As String

    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, Population As Integer)
        'Increase numyears by 1
        _NumYears += 1
        'redim all arrays to numyears, preserving past data
        _YearDeaths = MyBase.validInt(YearDeaths) 'Set the current index of YearDeaths to the value passed to the constructor
        _YearRecoveries = MyBase.validInt(YearRecoveries) 'Set the current index of YearRecoveries to the value passed to the constructor
        _YearNewCases = MyBase.validInt(YearCases) 'Set the current index of YearNewCases to the value passed to the constructor
        MyBase.Population = Population
        _Symptoms(1) = "Fever"
        _Symptoms(2) = "Chills"
        _Symptoms(3) = "Headache"
        _Symptoms(5) = "Vomiting"
        _Symptoms(6) = "Fatigue"
        _Symptoms(7) = "Cough"
    End Sub

    Public Sub ResetYears()
        _NumYears = 0
    End Sub
End Class
