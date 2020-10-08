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
' Class name: cTB
' *****************************************************************
Public Class cTB
    Inherits cDisease
    Private Shared _YearNewCases() As Integer
    Private Shared _YearRecoveries() As Integer
    Private Shared _YearDeaths() As Integer
    Private Shared _NumYears As Integer
    Private _Population As Integer
    Private _Cross As Integer
    Private Shared _NoDots() As Integer
    Private Shared _Untreated() As Integer
    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, Population As Integer, noDOts As Integer)
        _NumYears += 1
        ReDim Preserve _YearDeaths(_NumYears)
        _YearDeaths(_NumYears) = YearDeaths
        ReDim Preserve _YearRecoveries(_NumYears)
        _YearRecoveries(_NumYears) = YearRecoveries
        ReDim Preserve _YearNewCases(_NumYears)
        _YearNewCases(_NumYears) = YearCases
        ReDim Preserve _NoDots(_NumYears)
        Me.NoDOTS(_NumYears) = noDOts
        _Population = Population
    End Sub

    Public Sub ResetYears()
        _NumYears = 0
    End Sub

    Public Property Cross() As Integer
        Get
            Return _Cross
        End Get
        Set(value As Integer)
            value = _Cross
        End Set
    End Property
    Public Property NoDOTS(i As Integer) As Integer
        Get
            Return _NoDots(i)
        End Get
        Set(value As Integer)
            If value < 0 Then
                _NoDots(i) = 0
            ElseIf value > _YearNewCases(i) Then
                _NoDots(i) = _YearNewCases(i)
            Else
                _NoDots(i) = value
            End If
        End Set
    End Property
End Class