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
    Private Shared _YearNewCases() As Integer
    Private Shared _YearRecoveries() As Integer
    Private Shared _YearDeaths() As Integer
    Private Shared _NumYears As Integer
    Private Shared ReadOnly Symptoms(4) As String

    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, Population As Integer)
        'Increase numyears by 1
        _NumYears += 1
        'redim all arrays to numyears, preserving past data
        ReDim Preserve _YearDeaths(_NumYears)
        _YearDeaths(_NumYears) = MyBase.validInt(YearDeaths) 'Set the current index of YearDeaths to the value passed to the constructor
        ReDim Preserve _YearRecoveries(_NumYears)
        _YearRecoveries(_NumYears) = MyBase.validInt(YearRecoveries) 'Set the current index of YearRecoveries to the value passed to the constructor
        ReDim Preserve _YearNewCases(_NumYears)
        _YearNewCases(_NumYears) = MyBase.validInt(YearCases) 'Set the current index of YearNewCases to the value passed to the constructor

    End Sub

    Public Sub TotalArrays()
        For i As Integer = 1 To _NumYears
            TotalCases += _YearNewCases(i)
            TotalDeaths += _YearDeaths(i)
            TotalRecovers += _YearRecoveries(i)
        Next i
    End Sub

    Public Sub ResetYears()
        _NumYears = 0
    End Sub
End Class
