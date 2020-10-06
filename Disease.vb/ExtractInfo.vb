Public Interface ExtractInfo
    Property DiseaseName As String
    ReadOnly Property RegionName As String
    Property Population As Integer
    ReadOnly Property InfectionRate As Double
    ReadOnly Property RecoveryRate As Double
    Property NumSymptoms As Integer
    Property TotalCases As Integer
    ReadOnly Property TotalDeaths As Integer
    ReadOnly Property TotalRecovers As Integer
    ReadOnly Property DeathRate As Double
End Interface
