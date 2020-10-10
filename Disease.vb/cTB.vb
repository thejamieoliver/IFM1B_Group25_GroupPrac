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
    Private _NoDots As Integer 'People unable to be treated
    Private ReadOnly _Symptoms(6) As String 'Array of Symptoms
    Private _NumSymp As Integer
    Public Sub New(YearCases As Integer, YearDeaths As Integer, YearRecoveries As Integer, Population As Integer, noDOts As Integer)
        'Increase numyears by 1
        _NumYears += 1
        'redim all arrays to numyears, preserving past data
        _YearDeaths = MyBase.validInt(YearDeaths) 'Set the current index of YearDeaths to the value passed to the constructor
        _YearRecoveries = MyBase.validInt(YearRecoveries) 'Set the current index of YearRecoveries to the value passed to the constructor
        _YearNewCases = MyBase.validInt(YearCases) 'Set the current index of YearNewCases to the value passed to the constructor
        _NoDots = MyBase.validInt(noDOts) 'Set the current index of this classes NoDots to the value passed to the constructor
        MyBase.Population = Population
        _Symptoms(1) = "Coughing Blood" 'Give values to the symptoms array
        _Symptoms(2) = "Chills"
        _Symptoms(3) = "No Appetite"
        _Symptoms(4) = "Chest pain"
        _Symptoms(5) = "Weight Loss"
        _Symptoms(6) = "Night Sweats"
        _NumSymp = _Symptoms.Length
    End Sub

    Public Sub ResetYears()
        _NumYears = 0
    End Sub

    Public Property NoDOTS() As Integer
        Get
            'Return _NoDots at the index
            Return _NoDots
        End Get
        Set(value As Integer)
            'Check that the passed value is not negative, or gretaer than the given cases
            If value < 0 Then
                _NoDots = 0
            ElseIf value > _YearNewCases Then
                _NoDots = _YearNewCases
            Else
                _NoDots = value
            End If
        End Set
    End Property
    ' Property methods From interDisease
    Public ReadOnly Property YearNewCases As Integer Implements InterDisease.YearNewCases
        Get
            Return _YearNewCases
        End Get
    End Property

    Public ReadOnly Property YearRecoveries As Integer Implements InterDisease.YearRecoveries
        Get
            Return _YearRecoveries
        End Get
    End Property

    Public ReadOnly Property YearDeaths As Integer Implements InterDisease.YearDeaths
        Get
            Return _YearDeaths
        End Get
    End Property

    Private ReadOnly Property InterDisease_YearNewCases As Integer Implements InterDisease.YearNewCases
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private ReadOnly Property InterDisease_YearRecoveries As Integer Implements InterDisease.YearRecoveries
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private ReadOnly Property InterDisease_YearDeaths As Integer Implements InterDisease.YearDeaths
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Function Display() As String
        'Return the year number, and the value of the base classes display
        Dim dis As String = "Year: " & _NumYears & Environment.NewLine & MyBase.Display
        'Add the derived class unique variables
        dis &= "Cases: " & _YearNewCases & Environment.NewLine _
        & "Recoveries: " & _YearRecoveries & Environment.NewLine _
        & "Deaths: " & _YearDeaths & Environment.NewLine _
        & "Untreated: " & _NoDots & Environment.NewLine
        Return dis
    End Function
    Public Sub Removeoneyear()
        _NumYears -= 1
    End Sub
    Public Function CollectSymptoms(value As String) As String
        If value = _Symptoms(_NumSymp) Then
            Return _Symptoms(_NumSymp)
        Else
            Return "Null"
        End If
        _NumSymp -= 1
    End Function
End Class