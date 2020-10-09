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
    Private _Population As Integer

    'Functions and Subroutines ***********************************************************************************************

    Public Function CalcInfectionRate(TotalCases As Integer) As Double
        _InfectionRate = TotalCases / _Population
        Return _InfectionRate
    End Function

    Public Function CalcDeathRate(TotalDeaths As Integer) As Double
        _DeathRate = TotalDeaths / _Population
        Return _DeathRate
    End Function

    Public Overridable Function CalcRecoverRate(TotalRecovers As Integer) As Double
        _RecoveryRate = TotalRecovers / _Population
        Return _DeathRate
    End Function

    'Interface properties ****************************************************************************************************

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

    Protected Function validInt(i As Integer) As Integer
        If i < 0 Then
            i = 0
        End If
        Return i
    End Function
    '************************************************************************************************************************

End Class