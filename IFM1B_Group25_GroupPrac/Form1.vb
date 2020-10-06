Option Strict On
Option Explicit On
Option Infer Off
Imports Disease
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
    Private Disease As cDisease
    Private HIV As cHIV
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Disease = New cDisease()
        HIV = New cHIV()
    End Sub
End Class
