﻿Option Strict On
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
    Private Shared _YearNewCases() As Integer
    Private Shared _YearRecoveries() As Integer
    Private Shared _YearDeaths() As Integer
    Private Shared _Cross() As Integer 'Number of people cross infected with TB
    Private Shared _NotArt() As Integer 'Number of people without access to Anti RetroViral Treatment
    Private Shared _Condoms() As Boolean 'Whether or not Condoms were freely distributed that year
    Private Shared _NumYears As Integer
    Private _Symptoms(4) As String
    Private _Population As Integer

    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, Population As Integer)
        _NumYears += 1
        ReDim Preserve _YearDeaths(_NumYears)
        ReDim Preserve _YearRecoveries(_NumYears)
        ReDim Preserve _YearNewCases(_NumYears)
        ReDim Preserve _Cross(_NumYears)
        ReDim Preserve _NotArt(_NumYears)
        ReDim Preserve _Condoms(_NumYears)
        _Population = Population
        _Symptoms(1) = "Beans"
        _Symptoms(2) = "Tomatoes"
        _Symptoms(3) = "Chill"
        _Symptoms(4) = "Grugh"
        _Cross(_NumYears) = CrossTB()
    End Sub

    'Calculate no of people cross infected with TB
    Private Function CrossTB() As Integer
        Return CInt(Math.Round(_YearNewCases(_NumYears) * 0.11))
    End Function
    'Property methods for arrays
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
    Public Property Condoms(i As Integer) As Boolean
        Get
            Return _Condoms(i)
        End Get
        Set(value As Boolean)
            _Condoms(i) = value
        End Set
    End Property
End Class
