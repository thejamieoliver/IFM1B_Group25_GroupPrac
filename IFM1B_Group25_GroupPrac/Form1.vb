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
' Class name: (name of the class)
' *****************************************************************
Public Class Form1
    Const PASSWORD As String = "123"
    Private Disease As cDisease
    Private HIV As cHIV

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

    Private Sub btnNewDisease_Click(sender As Object, e As EventArgs) Handles btnNewDisease.Click
        Select Case cbDiseases.SelectedIndex
            Case 1
        End Select
    End Sub
End Class
