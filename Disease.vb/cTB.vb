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
<Serializable> Public Class cTB
    Inherits cDisease
    Implements InterDisease
    Private _YearNewCases As Integer
    Private _YearRecoveries As Integer
    Private _YearDeaths As Integer
    Private Shared _NumYears As Integer
    Private _NoDOTs As Integer 'People able to be treated
    Private ReadOnly _Symptoms(6) As String 'Array of Symptoms
    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, noDOTs As Integer)
        'Increase numyears by 1
        _NumYears += 1
        'redim all arrays to numyears, preserving past data
        _YearDeaths = MyBase.validInt(YearDeaths) 'Set the current index of YearDeaths to the value passed to the constructor
        _YearRecoveries = MyBase.validInt(YearRecoveries) 'Set the current index of YearRecoveries to the value passed to the constructor
        _YearNewCases = MyBase.validInt(YearCases) 'Set the current index of YearNewCases to the value passed to the constructor
        _NoDOTs = MyBase.validInt(noDOTs) 'Set the current index of this classes NoDots to the value passed to the constructor
        _Symptoms(1) = "Coughing Blood" 'Give values to the symptoms array
        _Symptoms(2) = "Chills"
        _Symptoms(3) = "No Appetite"
        _Symptoms(4) = "Chest pain"
        _Symptoms(5) = "Weight Loss"
        _Symptoms(6) = "Night Sweats"
    End Sub

    Public Sub ResetYears()
        'Set _numyears to 0
        _NumYears = 0
    End Sub

    Public Property NoDOTS() As Integer
        Get
            'Return _NoDots at the index
            Return _NoDOTs
        End Get
        Set(value As Integer)
            'Check that the passed value is not negative, or gretaer than the given cases
            If value < 0 Then
                _NoDOTs = 0
            ElseIf value > _YearNewCases Then
                _NoDOTs = _YearNewCases
            Else
                _NoDOTs = value
            End If
        End Set
    End Property
    ' Property methods From interDisease
    Public ReadOnly Property YearNewCases As Integer Implements InterDisease.YearNewCases
        Get
            'Return _YearNewCases
            Return _YearNewCases
        End Get
    End Property

    Public ReadOnly Property YearRecoveries As Integer Implements InterDisease.YearRecoveries
        Get
            ' Return _YearRecoveries
            Return _YearRecoveries
        End Get
    End Property

    Public ReadOnly Property YearDeaths As Integer Implements InterDisease.YearDeaths
        Get
            'Return _YearDeaths
            Return _YearDeaths
        End Get
    End Property

    Public Overrides Function Display() As String
        'Return the year number, and the value of the base classes display
        Dim dis As String = "Year: " & _NumYears & Environment.NewLine & MyBase.Display
        'Add the derived class unique variables
        dis &= "Cases: " & _YearNewCases & Environment.NewLine _
        & "Recoveries: " & _YearRecoveries & Environment.NewLine _
        & "Deaths: " & _YearDeaths & Environment.NewLine _
        & "Treated: " & _NoDOTs & Environment.NewLine
        Return dis
    End Function
    Public Sub Removeoneyear()
        'Remove 1 from numyears
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