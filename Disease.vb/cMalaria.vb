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
    Inherits cDisease
    Private _YearNewCases As Integer
    Private _YearRecoveries As Integer
    Private _YearDeaths As Integer
    Private _Perm As Boolean
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

    Public Property perm As Boolean
        Get
            Return _Perm
        End Get
        Set(value As Boolean)
            _Perm = value
        End Set
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
    Public Sub ResetYears()
        _NumYears = 0
    End Sub
End Class
