' *****************************************************************
' Team Number: 25
' Team Member 1 Details: Crossling, CJ (220108433)
' Team Member 2 Details: Milne, R (220036931)
' Team Member 3 Details: Ogden, AR (220078628)
' Team Member 4 Details: Oliver, J (220015262)
' Practical: Team Project
' Class name: ExtractInfo
' *****************************************************************
Public Interface ExtractInfo
    Property Population As Integer
    Property TotalCases As Integer
    Property TotalDeaths As Integer
    Property TotalRecovers As Integer
    ReadOnly Property InfectionRate As Double
    ReadOnly Property DeathRate As Double
    ReadOnly Property RecoveryRate As Double
End Interface
