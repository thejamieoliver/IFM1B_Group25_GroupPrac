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
<Serializable> Public Class cDisease
    'Interface Class
    Implements ExtractInfo
    'Variable Declaration
    Private _InfectionRate As Double 'Infection rate of the disease.
    Private _DeathRate As Double 'Death rate of the disease.
    Private _RecoveryRate As Double 'Recovery rate of the disease.
    Private _Population As Integer

    'Functions and Subroutines ***********************************************************************************************

    Public Sub CalcInfectionRate(TotalCases As Integer)
        'Return the total cases/population
        _InfectionRate = TotalCases / _Population
    End Sub

    Public Sub CalcDeathRate(TotalDeaths As Integer)
        'Return totaldeaths/population
        _DeathRate = TotalDeaths / _Population
    End Sub

    Public Overridable Sub CalcRecoverRate(TotalRecovers As Integer)
        'Return totalrecoveries/ population
        _RecoveryRate = TotalRecovers / _Population
    End Sub

    'Interface properties ****************************************************************************************************

    Public Property Population As Integer Implements ExtractInfo.Population
        Get
            'Return poulation
            Return _Population
        End Get
        Set(value As Integer)
            'set _poulation to the validation of value
            _Population = validInt(value)
        End Set
    End Property

    Public ReadOnly Property InfectionRate As Double Implements ExtractInfo.InfectionRate
        Get
            'Return infectionrate
            Return _InfectionRate
        End Get
    End Property

    Public ReadOnly Property DeathRate As Double Implements ExtractInfo.DeathRate
        Get
            'Return deathrate
            Return _DeathRate
        End Get
    End Property

    Public Property RecoveryRate As Double Implements ExtractInfo.RecoveryRate
        Get
            'Return Recovery rate
            Return _RecoveryRate
        End Get
        Set(value As Double)

        End Set
    End Property
    '************************************************************************************************************************

    'Utility Methods ********************************************************************************************************
    Protected Function validInt(i As Integer) As Integer
        'Check if the passed value is posistive
        If i < 0 Then
            'if not, set it to 0
            i = 0
        End If
        'Return passed value
        Return i
    End Function

    Public Overridable Function Display() As String
        'Return the recovery rate, the death rate, and infection rate
        Return "Infection rate: " & InfectionRate & Environment.NewLine _
           & "Death rate: " & DeathRate & Environment.NewLine _
           & "Recovery rate: " & RecoveryRate & Environment.NewLine
    End Function
    '************************************************************************************************************************

End Class