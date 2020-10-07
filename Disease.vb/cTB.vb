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
    Private _Cross As Integer
    Private _DOTS() As Integer

    Public Property Cross() As Integer
        Get
            Return _Cross
        End Get
        Set(value As Integer)
            value = _Cross
        End Set
    End Property
    Public Property DOTS(i As Integer) As Integer
        Get
            Return _DOTS(i)
        End Get
        Set(value As Integer)
            If value < 0 Then
                _DOTS(i) = 0
            ElseIf value > _YearNewCases(_NumYears) Then
                _DOTS(i) = _YearNewCases(_NumYears)
            Else
                _DOTS(i) = value
            End If
        End Set
    End Property
    'Calculate number of People who are not able to be treated for TB
    Public Function CalcUntreated() As Double
        Return DOTS(_NumYears) / _YearNewCases(_NumYears)
    End Function

End Class
