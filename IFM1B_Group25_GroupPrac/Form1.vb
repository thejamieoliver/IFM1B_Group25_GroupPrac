﻿Option Strict On
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
    Const FNAME As String = "/Diseases.txt"
    Private Disease() As cDisease
    Private HIV() As cHIV
    Private TB() As cTB
    Private Malaria() As cMalaria
    Private NumRecords As Integer
    Private NumHIV As Integer
    Private NumTB As Integer
    Private NumMalaria As Integer
    Private isLoaded As Boolean
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
        pnlPatient.Visible = True
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

                TempHIV = New cHIV()
            Case enumDisease.TB

            Case enumDisease.Malaria

        End Select
        cbDiseases.SelectedIndex = -1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 450
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
        FS = New FileStream(FNAME, FileMode.OpenOrCreate, FileAccess.Write)
        BF = New BinaryFormatter()
        For i As Integer = 1 To Len(Disease)
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
                    ReDim Preserve HIV(NumHIV)
                    HIV(NumHIV) = tempHIV
                ElseIf Not (tempTB Is Nothing) Then
                    NumTB += 1
                    ReDim Preserve TB(NumTB)
                    TB(NumTB) = tempTB
                ElseIf Not (tempMalaria Is Nothing) Then
                    ReDim Preserve Malaria(NumMalaria)
                    NumMalaria += 1
                    Malaria(NumMalaria) = tempMalaria
                End If
            End While
            FS.Close()
            isLoaded = True
        End If
    End Sub
End Class