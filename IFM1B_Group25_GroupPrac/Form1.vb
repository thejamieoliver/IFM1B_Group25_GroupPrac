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

        Else
            MessageBox.Show("Incorrect Password!", "Error")
        End If
    End Sub
    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        'This doesnt go on the button
        pnlPatient.Visible = True
    End Sub
    Private Sub cbDiseases_IndexChange(sender As Object, e As EventArgs) Handles cbDiseases.SelectedIndexChanged
        btnRecordInfo.Enabled = True
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
                Dim noART As Integer
                Dim bCondoms As Boolean
                HIVYearCases = CInt(txtHIVYearCases.Text)
                HIVYearDeaths = CInt(txtHIVYearDeaths.Text)
                noART = CInt(txtNoART.Text)
                bCondoms = cbxCondoms.Checked
                TempHIV = New cHIV(HIVYearCases, HIVYearDeaths, Population, noART, bCondoms)
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
                Dim yearCases As Integer = CInt(txtCasesTB.Text())
                Dim yeardeaths As Integer = CInt(txtDeathsTB.Text())
                Dim yearrec As Integer = CInt(txtRecTB.Text())
                Dim noDots As Integer = CInt(txtDOTS.Text())
                Dim tempTB As cTB = New cTB(yearCases, yeardeaths, yearrec, Population, noDots)
                TB(NumTB) = tempTB
            Case enumDisease.Malaria
                NumMalaria += 1
                NumRecords += 1
                ReDim Preserve Malaria(NumMalaria)
                ReDim Preserve Disease(NumRecords)
                Dim yearCases As Integer = CInt(txtMalCases.Text())
                Dim yeardeaths As Integer = CInt(txtNewDeathsMal.Text())
                Dim yearrec As Integer = CInt(txtMalRecoveries.Text())
                Dim perm As Boolean = CBool(cbxPerm.Checked)
                Dim tempMal As cMalaria = New cMalaria(yearCases, yeardeaths, yearrec, Population, perm)
                Malaria(NumMalaria) = tempMal
        End Select
        cbDiseases.SelectedIndex = -1
        btnRecordInfo.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
        pnlDoctor.Left = 0
        pnlDoctor.Top = 0
        pnlPatient.Left = 0
        pnlPatient.Top = 0
        pnlHIV.Parent = pnlDoctor
        pnlTB.Parent = pnlDoctor
        pnlTB.Left = pnlHIV.Left
        pnlTB.Top = pnlHIV.Top
        pnlMalaria.Parent = pnlDoctor
        pnlMalaria.Left = pnlHIV.Left
        pnlMalaria.Top = pnlHIV.Top
        btnRecordInfo.Parent = pnlDoctor
        isLoaded = False
        LoadFromFile()
    End Sub
    Private Sub SaveToFile()
        Dim FS As FileStream
        Dim BF As BinaryFormatter
        Dim HIVIndex As Integer
        Dim TBIndex As Integer
        Dim MalariaIndex As Integer
        FS = New FileStream(FNAME, FileMode.OpenOrCreate, FileAccess.Write)
        BF = New BinaryFormatter()

        For HIVIndex = 1 To NumHIV
            Disease(HIVIndex) = HIV(HIVIndex)
        Next
        For TBIndex = 1 To NumTB
            Disease(TBIndex + NumHIV) = TB(TBIndex)
        Next
        For MalariaIndex = 1 To NumMalaria
            Disease(NumTB + NumHIV + MalariaIndex) = Malaria(MalariaIndex)
        Next
        For i As Integer = 1 To NumRecords
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
            FS = New FileStream(FNAME, FileMode.OpenOrCreate, FileAccess.Read)
            BF = New BinaryFormatter()
            FS.Position = 0
            While FS.Position < FS.Length
                'Downcasting code
                Dim tempHIV As cHIV
                Dim tempTB As cTB
                Dim tempMalaria As cMalaria
                Try
                    tempHIV = TryCast(BF.Deserialize(FS), cHIV)
                Catch
                    Try
                        tempTB = TryCast(BF.Deserialize(FS), cTB)
                    Catch
                        Try
                            tempMalaria = TryCast(BF.Deserialize(FS), cMalaria)
                        Catch
                        End Try
                    End Try
                End Try
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
            ReDim Disease(NumRecords)
            isLoaded = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveToFile()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbSymptoms.Text = "Please Select Value" Then
            MsgBox("Please select a value from the combo box")
            Exit Sub
        End If
        Dim sSymptom, sDisplay() As String
        sSymptom = cbSymptoms.Text
        Dim tempHIV As cHIV
        Dim tempTB As cTB
        Dim tempMalaria As cMalaria
        Dim iCheck As Integer = 0
        tempHIV = New cHIV(1, 1, 1, 1, False) 'I couldnt think of another way to do this at the time, this means we cant use population as a shared variable in the base class because this will change it(Maybe we can but then subtract the pop value?)
        tempHIV.Removeoneyear() 'Check cMalaria for more info on Removeoneyear
        tempTB = New cTB(1, 1, 1, 1, 1)
        tempTB.Removeoneyear()
        tempMalaria = New cMalaria(1, 1, 1, 1, False)
        tempMalaria.Removeoneyear()
        If tempTB.CollectSymptoms(sSymptom) = True Then
            iCheck += 1
            ReDim Preserve sDisplay(iCheck)
            sDisplay(iCheck) = "TB"
        End If
        If tempHIV.CollectSymptoms(sSymptom) = True Then
            iCheck += 1
            ReDim Preserve sDisplay(iCheck)
            sDisplay(iCheck) = "HIV"
        End If
        If tempMalaria.CollectSymptoms(sSymptom) = True Then
            iCheck += 1
            ReDim Preserve sDisplay(iCheck)
            sDisplay(iCheck) = "Malaria"
        End If
        txtOutputSymptom.Text += sSymptom.ToUpper & ":" & vbNewLine
        For i As Integer = 1 To iCheck
            txtOutputSymptom.Text += sDisplay(i) & vbNewLine
        Next
    End Sub

    Private Sub btnUpdatePop_Click(sender As Object, e As EventArgs) Handles btnUpdatePop.Click
        Population = CInt(InputBox("Enter the new population for the current year.", "Update Population"))
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOutputSymptom.Text = ""
    End Sub
End Class