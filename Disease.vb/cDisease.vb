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
' Class name: cDisease
' *****************************************************************
Public Class cDisease
    'Interface Class
    Implements ExtractInfo
    'Variable Declaration
    Private _Name As String 'Disease name.
    Private _RegionName As String 'Name of region
    Private _RegionPopulation As Integer 'Population of region
    Private _InfectionRate As Double 'Infection rate of the disease.
    Private _RecoveryRate As Double 'Recovery rate of the disease.
    Private _Symptoms() As String 'Array string all symptoms of the disease. | _NumSymptoms
    Private _TotalCases As Integer 'Total number of cases for each recorded year.
    Private _TotalDeaths As Integer 'Total number of deaths for each recorded year.
    Private _TotalRecovers As Integer 'Total number of recoveries for each recorded year.
    Private _YearNewCases() As Integer 'Array storing number of new cases for each recorded year. | _NumYears
    Private _YearRecoveries() As Integer 'Array storing number of recoveries for each recorded year. | _NumYears
    Private _YearDeaths() As Integer 'Array storing number of deaths for each recorded year. | _NumYears
    Private _NumSymptoms As Integer 'Number of symptoms to record for.
    Private _NumYears As Integer 'Number of years to record for.
    Public Sub New(Name As String, RegionName As String, Population As Integer, NumSymptoms As Integer, Symptoms() As String)
        _Name = Name
        _RegionName = RegionName
        _RegionPopulation = Population
        _NumSymptoms = NumSymptoms
        ReDim _Symptoms(_NumSymptoms)
        _Symptoms = Symptoms
    End Sub
    Private Sub calcInfectionRate()
        _InfectionRate = _YearNewCases(Len(_YearNewCases)) / _RegionPopulation
    End Sub
    Public ReadOnly Property TotalDeaths As Integer Implements ExtractInfo.TotalDeaths
        Get
            Return funcTotalDeaths()
        End Get
    End Property

    'Interface properties
    Public Property DiseaseName As String Implements ExtractInfo.DiseaseName
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property InfectionRate As Double Implements ExtractInfo.InfectionRate
        Get
            Return _InfectionRate
        End Get
        Set(value As Double)
            _InfectionRate = value
        End Set
    End Property

    Public Property RecoveryRate As Double Implements ExtractInfo.RecoveryRate
        Get
            Return _RecoveryRate
        End Get
        Set(value As Double)
            _RecoveryRate = value
        End Set
    End Property

    Public Property TotalCases As Integer Implements ExtractInfo.TotalCases
        Get
            Return _TotalCases
        End Get
        Set(value As Integer)
            If IsPositive(value) = True Then
                _TotalCases = value
            End If
        End Set
    End Property

    Public Property TotalRecovers As Integer Implements ExtractInfo.TotalRecovers
        Get
            Return _TotalRecovers
        End Get
        Set(value As Integer)
            If IsPositive(value) = True Then
                _TotalRecovers = value
            End If
        End Set
    End Property

    Public Property NumSymptoms As Integer Implements ExtractInfo.NumSymptoms
        Get
            Return _NumSymptoms
        End Get
        Set(value As Integer)
            If IsPositive(value) = True Then
                _NumSymptoms = value
                ReDim Preserve _Symptoms(_NumSymptoms)
            End If
        End Set
    End Property

    Private Function IsPositive(value As Integer) As Boolean
        'Utility function for checking if a value is positive
        If value > 0 Then
            Return True
        Else
            MsgBox("Invalid Input")
            Return False
        End If
    End Function
    Private Function funcTotalDeaths() As Integer
        'Utility function to add all recorded deaths for a disease
        For Each i As Integer In _YearDeaths
            _TotalDeaths += _YearDeaths(i)
        Next
        Return _TotalDeaths
    End Function
End Class