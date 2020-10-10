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
<Serializable> Public Class cMalaria
    'Inherit disease class, implement the interface
    Inherits cDisease
    Implements InterDisease
    'declare all needed variables
    Private _YearNewCases As Integer
    Private _YearRecoveries As Integer
    Private _YearDeaths As Integer
    Private _Perm As Boolean 'Whether or not the region was sprayed with permethrin
    Private Shared _NumYears As Integer
    Private ReadOnly _Symptoms(7) As String 'A constant array of symptoms
    Private _NumSymp As Integer

    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, p As Boolean)
        'Increase numyears by 1
        _NumYears += 1
        'Redim all arrays to numyears, preserving past data
        _YearDeaths = MyBase.validInt(YearDeaths) 'Set the current index of YearDeaths to the value passed to the constructor
        _YearRecoveries = MyBase.validInt(YearRecoveries) 'Set the current index of YearRecoveries to the value passed to the constructor
        _YearNewCases = MyBase.validInt(YearCases) 'Set the current index of YearNewCases to the value passed to the constructor
        perm = p
        _Symptoms(1) = "Fever" 'Give values to solutions array
        _Symptoms(2) = "Chills"
        _Symptoms(3) = "Headache"
        _Symptoms(4) = "Vomiting"
        _Symptoms(5) = "Fatigue"
        _Symptoms(6) = "Cough"
        _NumSymp = _Symptoms.Length
    End Sub

    Public Property perm As Boolean
        Get
            'Return _Perm
            Return _Perm
        End Get
        Set(value As Boolean)
            'Set _perm to value
            _Perm = value
        End Set
    End Property
    ' Property methods From interDisease
    Public ReadOnly Property YearNewCases As Integer Implements InterDisease.YearNewCases
        Get
            'Return newcases
            Return _YearNewCases
        End Get
    End Property

    Public ReadOnly Property YearRecoveries As Integer Implements InterDisease.YearRecoveries
        Get
            'return _newrecoveries
            Return _YearRecoveries
        End Get
    End Property

    Public ReadOnly Property YearDeaths As Integer Implements InterDisease.YearDeaths
        Get
            'return _YearDeaths
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
            & "Permethrin Sprayed: " & _Perm & Environment.NewLine
        Return dis
    End Function
    Public Sub ResetYears() ' Set years to 0
        _NumYears = 0
    End Sub
    Public Sub Removeoneyear() 'Subtracts a year so that values wont be used
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
