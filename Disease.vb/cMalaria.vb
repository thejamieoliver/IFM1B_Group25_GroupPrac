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
    Private Shared _YearCases() As Integer
    Private Shared _YearRecoveries() As Integer
    Private Shared _YearDeaths() As Integer
    Private Shared _NumYears As Integer
    Private Symptoms(4) As String

    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, Population As Integer)
        _NumYears += 1
        ReDim Preserve _YearDeaths(_NumYears)
        _YearDeaths(_NumYears) = YearDeaths
        ReDim Preserve _YearRecoveries(_NumYears)
        _YearRecoveries(_NumYears) = YearRecoveries
        ReDim Preserve _YearCases(_NumYears)
        _YearCases(_NumYears) = YearCases
        MyBase.Population = Population
    End Sub

    Public Sub TotalArrays()
        For i As Integer = 1 To _NumYears
            TotalCases += _YearCases(i)
            TotalDeaths += _YearDeaths(i)
            TotalRecovers += _YearRecoveries(i)
        Next i
    End Sub

    Public Sub ResetYears()
        _NumYears = 0
    End Sub
End Class
