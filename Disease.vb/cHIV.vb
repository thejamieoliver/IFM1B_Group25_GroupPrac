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
    Private _Cross() As Integer
    Private _NotArt() As Integer
    Private _Condoms() As Boolean
    Private _Untreated() As Double

    Public Sub New(RegionName As String, Population As Integer, NumSymptoms As Integer, Symptoms() As String, NumYears As Integer)
        MyBase.New("HIV", RegionName, Population, NumSymptoms, Symptoms, NumYears)
        ReDim _Cross(_NumYears)
        ReDim _NotArt(_NumYears)
        ReDim _Condoms(_NumYears)
        ReDim _Untreated(_NumYears)
    End Sub

    'Calculate no of people cross infected with TB
    Public Function CrossTB(i As Integer) As Integer
        Return CInt(Math.Round(_YearNewCases(i) * 0.11))
    End Function
    Public Sub resize(val As Integer)
        ReDim Preserve _Cross(_NumYears)
        ReDim Preserve _NotArt(_NumYears)
        ReDim Preserve _Condoms(_NumYears)
        ReDim Preserve _Untreated(_NumYears)
    End Sub
    Public Property Cross(i As Integer) As Integer
        Get
            Return _Cross(i)
        End Get
        Set(value As Integer)
            If value < 0 Then
                _Cross(i) = 0
            ElseIf value > _YearNewCases(_NumYears) Then
                _Cross(i) = _YearNewCases(_NumYears)
            Else
                _Cross(i) = value
            End If
        End Set
    End Property

    Public Property NotArt(i As Integer) As Integer
        Get
            Return _NotArt(i)
        End Get
        Set(value As Integer)
            If value < 0 Then
                _NotArt(i) = 0
            ElseIf value > _YearNewCases(_NumYears) Then
                _NotArt(i) = _YearNewCases(_NumYears)
            Else
                _NotArt(i) = value
            End If
        End Set
    End Property

    Public Property Untreated(i As Integer) As Double
        Get
            Return _Untreated(i)
        End Get
        Set(value As Double)
            _Untreated(i) = value
        End Set
    End Property
    'Return percentage of people not being treated
    Public Function CalcUntreated() As Double
        Return NotArt(_NumYears) / _YearNewCases(_NumYears)
    End Function

    'Returns whether or not condoms are freely dispensed in the area
    Public Property Condoms(i As Integer) As Boolean
        Get
            Return _Condoms(i)
        End Get
        Set(value As Boolean)
            _Condoms(i) = value
        End Set
    End Property
End Class
