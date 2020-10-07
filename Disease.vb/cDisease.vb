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
    Private _InfectionRate As Double 'Infection rate of the disease.
    Private _DeathRate As Double 'Death rate of the disease.
    Private _RecoveryRate As Double 'Recovery rate of the disease.
    Private _TotalCases As Integer 'Total number of cases for each recorded year.
    Private _TotalDeaths As Integer 'Total number of deaths for each recorded year.
    Private _TotalRecovers As Integer 'Total number of recoveries for each recorded year.
    Private _Population As Integer

    'Functions and Subroutines ***********************************************************************************************

    Public Function CalcInfectionRate() As Double
        _InfectionRate = _TotalCases / _Population
        Return _InfectionRate
    End Function

    Public Function CalcDeathRate() As Double
        _DeathRate = _TotalDeaths / _Population
        Return _DeathRate
    End Function

    Public Overridable Function CalcRecoverRate() As Double
        _RecoveryRate = _TotalRecovers / _Population
        Return _DeathRate
    End Function

    'Interface properties ****************************************************************************************************

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

    Public Property TotalDeaths As Integer Implements ExtractInfo.TotalDeaths
        Get
            Return _TotalDeaths
        End Get
        Set(value As Integer)
            If IsPositive(value) = True Then
                _TotalDeaths = value
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

    Public Property Population As Integer Implements ExtractInfo.Population
        Get
            Return _Population
        End Get
        Set(value As Integer)
            If IsPositive(value) = True Then
                _Population = value
            End If
        End Set
    End Property

    Public ReadOnly Property InfectionRate As Double Implements ExtractInfo.InfectionRate
        Get
            Return _InfectionRate
        End Get
    End Property

    Public ReadOnly Property DeathRate As Double Implements ExtractInfo.DeathRate
        Get
            Return _DeathRate
        End Get
    End Property

    Public ReadOnly Property RecoveryRate As Double Implements ExtractInfo.RecoveryRate
        Get
            Return _RecoveryRate
        End Get
    End Property
    '************************************************************************************************************************

    'Utility Methods ********************************************************************************************************
    Private Function IsPositive(value As Integer) As Boolean
        'Utility function for checking if a value is positive
        If value > 0 Then
            Return True
        Else
            MsgBox("Invalid Input")
            Return False
        End If
    End Function
    '************************************************************************************************************************

End Class