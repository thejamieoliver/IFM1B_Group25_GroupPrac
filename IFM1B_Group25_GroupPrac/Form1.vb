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
Public Class FrmDiseaseTracker
    'Declare a constant file name, password
    Const PASSWORD As String = "123"
    Const FNAME As String = "Diseases.txt"
    'Delcare array of disease type and array of disease
    Private Disease() As cDisease
    Private HIV() As cHIV
    Private TB() As cTB
    Private Malaria() As cMalaria
    'Counters to store array length
    Private NumRecords As Integer
    Private NumHIV As Integer
    Private NumTB As Integer
    Private NumMalaria As Integer
    'Whether or not the file is loaded, the poulation has been recorded, and the poulation
    Private isLoaded As Boolean
    Private isPopRecorded As Boolean
    Private Population As Integer
    'Enumeration to store type of disease
    Private Enum enumDisease As Integer
        HIV
        TB
        Malaria
    End Enum
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        'ask user for password, and check if it matches the constant. If not, deny access
        If InputBox("Enter the password" & Environment.NewLine & "Password is 123", "Login") = PASSWORD Then
            pnlDoctor.Visible = True

        Else
            MessageBox.Show("Incorrect Password!", "Error")
        End If
        'Loading into array
        LoadFromFile()
        'Putting the output into the patient panel
        lblTB.Parent = pnlDoctor
        lblHIV.Parent = pnlDoctor
        lblMalaria.Parent = pnlDoctor
        txtTB.Parent = pnlDoctor
        txtHIV.Parent = pnlDoctor
        txtMalaria.Parent = pnlDoctor
        'Display Output
        Display()
    End Sub
    Private Sub Display()
        txtHIV.Clear()
        txtTB.Clear()
        txtMalaria.Clear()
        'Sorts through TB class array and does calculations along with display
        For i As Integer = 1 To NumTB
            TB(i).CalcDeathRate(TB(i).YearDeaths)
            TB(i).CalcRecoverRate(TB(i).YearRecoveries)
            TB(i).CalcInfectionRate(TB(i).YearNewCases)
            txtTB.Text &= TB(i).Display() & vbNewLine
        Next i
        'Sorts through HIV class array and does calculations along with display
        For i As Integer = 1 To NumHIV
            HIV(i).CalcDeathRate(HIV(i).YearDeaths)
            HIV(i).CalcRecoverRate(HIV(i).YearRecoveries)
            HIV(i).CalcInfectionRate(HIV(i).YearNewCases)
            txtHIV.Text &= HIV(i).Display() & vbNewLine
        Next i
        'Sorts through Malaria class array and does calculations along with display
        For i As Integer = 1 To NumMalaria
            Malaria(i).CalcDeathRate(Malaria(i).YearDeaths)
            Malaria(i).CalcRecoverRate(Malaria(i).YearRecoveries)
            Malaria(i).CalcInfectionRate(Malaria(i).YearNewCases)
            txtMalaria.Text &= Malaria(i).Display() & vbNewLine
        Next i
    End Sub
    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        'This doesnt go on the button
        pnlPatient.Visible = True
        'Loading into array
        LoadFromFile()
        'Putting the output into the patient panel
        lblTB.Parent = pnlPatient
        lblHIV.Parent = pnlPatient
        lblMalaria.Parent = pnlPatient
        txtTB.Parent = pnlPatient
        txtHIV.Parent = pnlPatient
        txtMalaria.Parent = pnlPatient
        'Display Output
        Display()
    End Sub
    Private Sub cbDiseases_IndexChange(sender As Object, e As EventArgs) Handles cbDiseases.SelectedIndexChanged
        'Enable the record button
        btnRecordInfo.Enabled = True
        Select Case cbDiseases.SelectedIndex
            'If the user selects HIV, make the inut panel visible
            Case enumDisease.HIV
                pnlHIV.Visible = True
                pnlTB.Visible = False
                pnlMalaria.Visible = False
            Case enumDisease.TB
                'If the user selects TB, make the TB panel visible
                pnlHIV.Visible = False
                pnlTB.Visible = True
                pnlMalaria.Visible = False
            Case enumDisease.Malaria
                'If the user chooses malaria, make the malaria panel visible
                pnlHIV.Visible = False
                pnlTB.Visible = False
                pnlMalaria.Visible = True
            Case -1
                'If no disease is chosen, make all panels invisible
                pnlHIV.Visible = False
                pnlTB.Visible = False
                pnlMalaria.Visible = False
                cbDiseases.Text = "Select a disease..."
        End Select
    End Sub
    Private Sub btnRecordInfo_Click(sender As Object, e As EventArgs) Handles btnRecordInfo.Click
        Select Case cbDiseases.SelectedIndex
            'Based on the index
            Case enumDisease.HIV
                'Create local variables to store HIV objects, and HIV object data
                Dim TempHIV As cHIV
                Dim HIVYearCases As Integer
                Dim HIVYearDeaths As Integer
                Dim noART As Integer
                Dim bCondoms As Boolean
                'Assign values to the local variables from the text boxes
                HIVYearCases = CInt(txtHIVYearCases.Text)
                HIVYearDeaths = CInt(txtHIVYearDeaths.Text)
                noART = CInt(txtNoART.Text)
                bCondoms = cbxCondoms.Checked
                'Assign an HIV object to tempHIV, increase total records, and HIV records
                TempHIV = New cHIV(HIVYearCases, HIVYearDeaths, Population, noART, bCondoms)
                NumHIV += 1
                NumRecords += 1
                'Redim and preserve the arrays, insert object into HIV array
                ReDim Preserve HIV(NumHIV)
                ReDim Preserve Disease(NumRecords)
                HIV(NumHIV) = TempHIV

            Case enumDisease.TB
                'increase total and TB records by 1, redim the respective arrays to these values
                NumTB += 1
                NumRecords += 1
                ReDim Preserve TB(NumTB)
                ReDim Preserve Disease(NumRecords)
                'Create local variables to store the object data, and assign them to the text boxes
                Dim yearCases As Integer = CInt(txtCasesTB.Text())
                Dim yeardeaths As Integer = CInt(txtDeathsTB.Text())
                Dim yearrec As Integer = CInt(txtRecTB.Text())
                Dim noDots As Integer = CInt(txtDOTS.Text())
                'Create new TB object passing the user enterd values
                Dim tempTB As cTB = New cTB(yearCases, yeardeaths, yearrec, Population, noDots)
                'Insert object into TB array
                TB(NumTB) = tempTB
            Case enumDisease.Malaria
                'Increase Malaria and disease count variables, redim respectiva arrays
                NumMalaria += 1
                NumRecords += 1
                ReDim Preserve Malaria(NumMalaria)
                ReDim Preserve Disease(NumRecords)
                'Create local variables for malaria object data, setting them to user input
                Dim yearCases As Integer = CInt(txtMalCases.Text())
                Dim yeardeaths As Integer = CInt(txtNewDeathsMal.Text())
                Dim yearrec As Integer = CInt(txtMalRecoveries.Text())
                Dim perm As Boolean = CBool(cbxPerm.Checked)
                'create new local variable of malaria type, passing the user entered values
                Dim tempMal As cMalaria = New cMalaria(yearCases, yeardeaths, yearrec, Population, perm)
                Malaria(NumMalaria) = tempMal
        End Select
        'set the index of cDiseases to -1, and disable the record button
        cbDiseases.SelectedIndex = -1
        btnRecordInfo.Enabled = False
        Display()
        MsgBox("Click save all to file to commit changes")
        'clearing textboxes
        txtCasesTB.Clear()
        txtDeathsTB.Clear()
        txtDOTS.Clear()
        txtHIVYearCases.Clear()
        txtHIVYearDeaths.Clear()
        txtMalCases.Clear()
        txtMalRecoveries.Clear()
        txtNewDeathsMal.Clear()
        txtNoART.Clear()
        txtRecTB.Clear()
        cbxCondoms.Checked = False
        cbxPerm.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set size panels
        Me.Width = 800
        Me.Height = 500
        'Set posistion and order of panels
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
        'Set isloaded to false, and load the values from the file
        isLoaded = False
        LoadFromFile()
    End Sub
    Private Sub SaveToFile()
        'Declare a new filestream and a binary formatter
        Dim FS As FileStream
        Dim BF As BinaryFormatter
        'Create local variables to store the index of the disease arrays
        Dim HIVIndex As Integer
        Dim TBIndex As Integer
        Dim MalariaIndex As Integer
        'Instantiate filestream and binaryformatter
        FS = New FileStream(FNAME, FileMode.OpenOrCreate, FileAccess.Write)
        BF = New BinaryFormatter()
        'assign the values of the disease array to the values of all disease arrays
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
            'Convert to binary, and write to file
            BF.Serialize(FS, Disease(i))
        Next
        'Close the filestream
        FS.Close()
        MsgBox("Records have been save successfully to " & FNAME)
    End Sub
    Private Sub LoadFromFile()
        'Declare new filestream and binaryformatter
        Dim FS As FileStream
        Dim BF As BinaryFormatter
        If isLoaded = False Then
            'if file is not loaded, create new filestream, and binaryformatter, setting length variables to 0
            NumHIV = 0
            NumTB = 0
            NumMalaria = 0
            FS = New FileStream(FNAME, FileMode.OpenOrCreate, FileAccess.Read)
            BF = New BinaryFormatter()
            FS.Position = 0
            'for every posotion on the file
            While FS.Position < FS.Length
                'Downcasting code
                'Create local variables of each disease type
                Dim tempHIV As cHIV
                Dim tempTB As cTB
                Dim tempMalaria As cMalaria
                'Try
                Try
                    'Try casting the current file posotions object to HIV type
                    tempHIV = TryCast(BF.Deserialize(FS), cHIV)
                Catch
                    Try
                        'Try casting the current file positions object to HIV type
                        tempTB = TryCast(BF.Deserialize(FS), cTB)
                    Catch
                        Try
                            'Try casting the current file positions object to HIV type
                            tempMalaria = TryCast(BF.Deserialize(FS), cMalaria)
                        Catch
                        End Try
                    End Try
                End Try

                If Not (tempHIV Is Nothing) Then 'If it is of HIV type
                    'Increase record number, total records, redim the HIV array, and set the array value to the object
                    NumHIV += 1
                    NumRecords += 1
                    ReDim Preserve HIV(NumHIV)
                    HIV(NumHIV) = tempHIV

                ElseIf Not (tempTB Is Nothing) Then 'If it is of TB type
                    'Increase record number, total records, redim the TB array, and set the array value to the object
                    NumTB += 1
                    NumRecords += 1
                    ReDim Preserve TB(NumTB)
                    TB(NumTB) = tempTB

                ElseIf Not (tempMalaria Is Nothing) Then 'If it is of Malaria type
                    'Increase record number, total records, redim the Malaria array, and set the array value to the objects
                    NumMalaria += 1
                    NumRecords += 1
                    ReDim Preserve Malaria(NumMalaria)
                    Malaria(NumMalaria) = tempMalaria
                End If

            End While
            'Close the filestream, redim the disease array, and set isloaded to true
            FS.Close()
            ReDim Disease(NumRecords)
            isLoaded = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'call save sub
        SaveToFile()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'If user has not selected a symptom, ask again
        If cbSymptoms.Text = "Please Select Value" Then
            MsgBox("Please select a value from the combo box")
            Exit Sub
        End If
        'Create object and display array
        Dim sSymptom, sDisplay() As String
        'set sSymptom to user selected text, create local variables to store an object of each class type
        sSymptom = cbSymptoms.Text
        Dim tempHIV As cHIV
        Dim tempTB As cTB
        Dim tempMalaria As cMalaria
        Dim iCheck As Integer = 0
        'Create a new variable of each disease type, passing arbitrary objects
        tempHIV = New cHIV(1, 1, 1, 1, False) 'I couldnt think of another way to do this at the time, this means we cant use population as a shared variable in the base class because this will change it(Maybe we can but then subtract the pop value?)
        tempHIV.Removeoneyear() 'Check cMalaria for more info on Removeoneyear
        tempTB = New cTB(1, 1, 1, 1, 1)
        tempTB.Removeoneyear()
        tempMalaria = New cMalaria(1, 1, 1, 1, False)
        tempMalaria.Removeoneyear()
        'Check the symptoms of the instantiation against the user selected symptom
        If tempTB.CollectSymptoms(sSymptom) = True Then ' if the symptoms match the TB object
            'Increase the counter, redimming the display array to the counter, and setting the value to the disease name
            iCheck += 1
            ReDim Preserve sDisplay(iCheck)
            sDisplay(iCheck) = "TB"
        End If
        If tempHIV.CollectSymptoms(sSymptom) = True Then
            'Increase the counter, redimming the display array to the counter, and setting the value to the disease name
            iCheck += 1
            ReDim Preserve sDisplay(iCheck)
            sDisplay(iCheck) = "HIV"
        End If
        If tempMalaria.CollectSymptoms(sSymptom) = True Then
            'Increase the counter, redimming the display array to the counter, and setting the value to the disease name
            iCheck += 1
            ReDim Preserve sDisplay(iCheck)
            sDisplay(iCheck) = "Malaria"
        End If
        'Display the symptom, and the disease name
        txtOutputSymptom.Text += sSymptom.ToUpper & ":" & vbNewLine
        For i As Integer = 1 To iCheck
            txtOutputSymptom.Text += sDisplay(i) & vbNewLine
        Next
    End Sub

    Private Sub btnUpdatePop_Click(sender As Object, e As EventArgs) Handles btnUpdatePop.Click 'Ask user for the current poulation
        Population = CInt(InputBox("Enter the new population for the current year.", "Update Population"))
        lblCurrentPop.Text = "Current Population: " & CStr(Population)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'Clear the display symptoms box
        txtOutputSymptom.Text = ""
    End Sub

    Private Sub btnBackAd_Click(sender As Object, e As EventArgs) Handles btnBackAd.Click 'Return to main
        pnlDoctor.Visible = False
    End Sub

    Private Sub btnBackP_Click(sender As Object, e As EventArgs) Handles btnBackP.Click 'Return to main
        pnlPatient.Visible = False
    End Sub
End Class