Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
' *****************************************************************
' Team Number: 25
' Team Member 1 Details: Crossling, CJ (220108433)
' Team Member 2 Details: Milne, R (220036931)
' Team Member 3 Details: Ogden, AR (220078628)
' Team Member 4 Details: Oliver, J (220015262)
' Practical: Team Project
' Class name: (name of the class)
' *****************************************************************
Public Class Form1
    Const PASSWORD As String = "123"
    Const FNAME As String = "Diseases.txt"
    Private Disease() As cDisease
    Private HIV() As cHIV
    Private TB() As cTB
    Private Malaria() As cMalaria
    Private NumRecords As Integer
    Private NumHIV As Integer
    Private NumTB As Integer
    Private NumMalaria As Integer
    Private isLoaded As Boolean
    Private isPopRecorded As Boolean
    Private Population As Integer
    Private Enum enumDisease As Integer
        HIV
        TB
        Malaria
    End Enum
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        If InputBox("Enter the password", "Login") = PASSWORD Then
            pnlDoctor.Visible = True
            LoadFromFile()
        Else
            MessageBox.Show("Incorrect Password!", "Error")
        End If
    End Sub
    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        LoadFromFile()
        'This doesnt go on the button
        pnlPatient.Visible = True
        'I cant see the stuff on the form, so ive put the code here for the button (everything from here to Next i)
        Dim sSymptom, sDisplay() As String
        'sSymptom is the value in the combobox
        Dim tempHIV As cHIV
        Dim tempTB As cTB
        Dim tempMalaria As cMalaria
        Dim iCheck As Integer = 0
        tempHIV = New cHIV(1, 1, 1, 1, 1, False) 'I couldnt think of another way to do this at the time, this means we cant use population as a shared variable in the base class because this will change it(Maybe we can but then subtract the pop value?)
        tempHIV.Removeoneyear() 'Check cMalaria for more info on Removeoneyear
        For i As Integer = 1 To 8 'The highest number of symptoms in a variable
            If tempHIV.CollectSymptoms(sSymptom) <> "Null" Then 'Check cMalaria for more info on Collectsymptoms
                iCheck += 1
                ReDim Preserve sDisplay(iCheck)
                sDisplay(iCheck) = tempHIV.CollectSymptoms(sSymptom)
            End If
            tempTB = New cTB(1, 1, 1, 1, 1)
            tempTB.Removeoneyear()
            If tempTB.CollectSymptoms(sSymptom) <> "Null" Then
                iCheck += 1
                ReDim Preserve sDisplay(iCheck)
                sDisplay(iCheck) = tempTB.CollectSymptoms(sSymptom)
            End If
            tempMalaria = New cMalaria(1, 1, 1, 1)
            tempMalaria.Removeoneyear()
            If tempMalaria.CollectSymptoms(sSymptom) <> "Null" Then
                iCheck += 1
                ReDim Preserve sDisplay(iCheck)
                sDisplay(iCheck) = tempMalaria.CollectSymptoms(sSymptom)
            End If
        Next i
        For i As Integer = 1 To iCheck 'I hope that this works, couldnt test it because i cant access the form
            If sDisplay(i) = sDisplay(i + 1) Then
                For z As Integer = (i + 1) To iCheck
                    sDisplay(z) = sDisplay(z + 1)
                    iCheck -= 1
                Next z
            End If
        Next i
        'Display from the array sDisplay
    End Sub
    Private Sub cbDiseases_IndexChange(sender As Object, e As EventArgs) Handles cbDiseases.SelectedIndexChanged
        Select Case cbDiseases.SelectedIndex
            Case enumDisease.HIV
                pnlHIV.Visible = True
                pnlTB.Visible = False
                pnlMalaria.Visible = False
            Case enumDisease.TB
                pnlHIV.Visible = False
                pnlTB.Visible = True
                pnlMalaria.Visible = False
            Case enumDisease.Malaria
                pnlHIV.Visible = False
                pnlTB.Visible = False
                pnlMalaria.Visible = True
            Case -1
                pnlHIV.Visible = False
                pnlTB.Visible = False
                pnlMalaria.Visible = False
                cbDiseases.Text = "Select a disease..."
        End Select
    End Sub
    Private Sub btnRecordInfo_Click(sender As Object, e As EventArgs) Handles btnRecordInfo.Click
        Select Case cbDiseases.SelectedIndex
            Case enumDisease.HIV
                Dim TempHIV As cHIV
                Dim HIVYearCases As Integer
                Dim HIVYearDeaths As Integer
                Dim HIVYearRecoveries As Integer
                Dim noART As Integer
                Dim bCondoms As Boolean
                HIVYearCases = CInt(txtHIVYearCases.Text)
                HIVYearDeaths = CInt(txtHIVYearDeaths.Text)
                HIVYearRecoveries = CInt(txtHIVYearRecoveries.Text)
                noART = CInt(txtNoART.Text)
                bCondoms = cbxCondoms.Checked
                TempHIV = New cHIV(HIVYearCases, HIVYearDeaths, HIVYearRecoveries, Population, noART, bCondoms)
                NumHIV += 1
                NumRecords += 1
                ReDim Preserve HIV(NumHIV)
                ReDim Preserve Disease(NumRecords)
                HIV(NumHIV) = TempHIV

            Case enumDisease.TB
                NumTB += 1
                NumRecords += 1
                ReDim Preserve TB(NumTB)
                ReDim Preserve Disease(NumRecords)
            Case enumDisease.Malaria
                NumMalaria += 1
                NumRecords += 1
                ReDim Preserve Malaria(NumMalaria)
                ReDim Preserve Disease(NumRecords)
        End Select
        cbDiseases.SelectedIndex = -1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
        pnlDoctor.Left = 0
        pnlDoctor.Top = 0
        pnlHIV.Parent = pnlDoctor
        pnlTB.Parent = pnlDoctor
        pnlTB.Left = pnlHIV.Left
        pnlTB.Top = pnlHIV.Top
        pnlMalaria.Parent = pnlDoctor
        pnlMalaria.Left = pnlHIV.Left
        pnlMalaria.Top = pnlHIV.Top
        btnRecordInfo.Parent = pnlDoctor
        isLoaded = False
    End Sub
    Private Sub SaveToFile()
        Dim FS As FileStream
        Dim BF As BinaryFormatter
        Dim HIVIndex As Integer
        Dim TBIndex As Integer
        Dim MalariaIndex As Integer
        FS = New FileStream(FNAME, FileMode.Open, FileAccess.Write)
        BF = New BinaryFormatter()
        For i As Integer = 1 To NumRecords
            For HIVIndex = 1 To Len(HIV)
                Disease(i) = HIV(HIVIndex)
            Next
            For TBIndex = 1 To Len(TB)
                Disease(i) = TB(TBIndex)
            Next
            For MalariaIndex = 1 To Len(Malaria)
                Disease(i) = TB(TBIndex)
            Next
            BF.Serialize(FS, Disease(i))
        Next
        FS.Close()
    End Sub
    Private Sub LoadFromFile()
        Dim FS As FileStream
        Dim BF As BinaryFormatter
        If isLoaded = False Then
            NumHIV = 0
            NumTB = 0
            NumMalaria = 0
            FS = New FileStream(FNAME, FileMode.Open, FileAccess.Read)
            BF = New BinaryFormatter()
            While FS.Position < FS.Length
                'Downcasting code
                Dim tempHIV As cHIV
                Dim tempTB As cTB
                Dim tempMalaria As cMalaria
                tempHIV = TryCast(BF.Deserialize(FS), cHIV)
                tempTB = TryCast(BF.Deserialize(FS), cTB)
                tempMalaria = TryCast(BF.Deserialize(FS), cMalaria)
                If Not (tempHIV Is Nothing) Then
                    NumHIV += 1
                    NumRecords += 1
                    ReDim Preserve HIV(NumHIV)
                    HIV(NumHIV) = tempHIV
                ElseIf Not (tempTB Is Nothing) Then
                    NumTB += 1
                    NumRecords += 1
                    ReDim Preserve TB(NumTB)
                    TB(NumTB) = tempTB
                ElseIf Not (tempMalaria Is Nothing) Then
                    NumMalaria += 1
                    NumRecords += 1
                    ReDim Preserve Malaria(NumMalaria)
                    Malaria(NumMalaria) = tempMalaria
                End If
            End While
            FS.Close()
            isLoaded = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveToFile()
    End Sub
End Class