<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDiseaseTracker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.pnlDoctor = New System.Windows.Forms.Panel()
        Me.lblCurrentPop = New System.Windows.Forms.Label()
        Me.lblMalaria = New System.Windows.Forms.Label()
        Me.lblHIV = New System.Windows.Forms.Label()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.txtMalaria = New System.Windows.Forms.TextBox()
        Me.txtHIV = New System.Windows.Forms.TextBox()
        Me.btnBackAd = New System.Windows.Forms.Button()
        Me.btnUpdatePop = New System.Windows.Forms.Button()
        Me.txtTB = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbDiseases = New System.Windows.Forms.ComboBox()
        Me.pnlHIV = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCondoms = New System.Windows.Forms.CheckBox()
        Me.txtHIVYearCases = New System.Windows.Forms.TextBox()
        Me.txtHIVYearDeaths = New System.Windows.Forms.TextBox()
        Me.txtNoART = New System.Windows.Forms.TextBox()
        Me.btnRecordInfo = New System.Windows.Forms.Button()
        Me.pnlTB = New System.Windows.Forms.Panel()
        Me.lblCasesTB = New System.Windows.Forms.Label()
        Me.lblDeathsTB = New System.Windows.Forms.Label()
        Me.lblRecTB = New System.Windows.Forms.Label()
        Me.lblDOTS = New System.Windows.Forms.Label()
        Me.txtDOTS = New System.Windows.Forms.TextBox()
        Me.txtRecTB = New System.Windows.Forms.TextBox()
        Me.txtDeathsTB = New System.Windows.Forms.TextBox()
        Me.txtCasesTB = New System.Windows.Forms.TextBox()
        Me.pnlMalaria = New System.Windows.Forms.Panel()
        Me.txtMalRecoveries = New System.Windows.Forms.TextBox()
        Me.lblPerm = New System.Windows.Forms.Label()
        Me.cbxPerm = New System.Windows.Forms.CheckBox()
        Me.lblMalRec = New System.Windows.Forms.Label()
        Me.lblDeaths = New System.Windows.Forms.Label()
        Me.lblCases = New System.Windows.Forms.Label()
        Me.txtNewDeathsMal = New System.Windows.Forms.TextBox()
        Me.txtMalCases = New System.Windows.Forms.TextBox()
        Me.pnlPatient = New System.Windows.Forms.Panel()
        Me.btnBackP = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtOutputSymptom = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbSymptoms = New System.Windows.Forms.ComboBox()
        Me.pnlDoctor.SuspendLayout()
        Me.pnlHIV.SuspendLayout()
        Me.pnlTB.SuspendLayout()
        Me.pnlMalaria.SuspendLayout()
        Me.pnlPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(280, 218)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(250, 60)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnPatient
        '
        Me.btnPatient.Location = New System.Drawing.Point(280, 142)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(250, 60)
        Me.btnPatient.TabIndex = 1
        Me.btnPatient.Text = "Patient"
        Me.btnPatient.UseVisualStyleBackColor = True
        '
        'pnlDoctor
        '
        Me.pnlDoctor.Controls.Add(Me.lblCurrentPop)
        Me.pnlDoctor.Controls.Add(Me.lblMalaria)
        Me.pnlDoctor.Controls.Add(Me.lblHIV)
        Me.pnlDoctor.Controls.Add(Me.lblTB)
        Me.pnlDoctor.Controls.Add(Me.txtMalaria)
        Me.pnlDoctor.Controls.Add(Me.txtHIV)
        Me.pnlDoctor.Controls.Add(Me.btnBackAd)
        Me.pnlDoctor.Controls.Add(Me.btnUpdatePop)
        Me.pnlDoctor.Controls.Add(Me.txtTB)
        Me.pnlDoctor.Controls.Add(Me.btnSave)
        Me.pnlDoctor.Controls.Add(Me.cbDiseases)
        Me.pnlDoctor.Controls.Add(Me.pnlHIV)
        Me.pnlDoctor.Controls.Add(Me.btnRecordInfo)
        Me.pnlDoctor.Location = New System.Drawing.Point(491, 12)
        Me.pnlDoctor.Name = "pnlDoctor"
        Me.pnlDoctor.Size = New System.Drawing.Size(799, 449)
        Me.pnlDoctor.TabIndex = 2
        Me.pnlDoctor.Visible = False
        '
        'lblCurrentPop
        '
        Me.lblCurrentPop.AutoSize = True
        Me.lblCurrentPop.Location = New System.Drawing.Point(62, 67)
        Me.lblCurrentPop.Name = "lblCurrentPop"
        Me.lblCurrentPop.Size = New System.Drawing.Size(100, 13)
        Me.lblCurrentPop.TabIndex = 15
        Me.lblCurrentPop.Text = "Current Population: "
        '
        'lblMalaria
        '
        Me.lblMalaria.AutoSize = True
        Me.lblMalaria.Location = New System.Drawing.Point(353, 270)
        Me.lblMalaria.Name = "lblMalaria"
        Me.lblMalaria.Size = New System.Drawing.Size(41, 13)
        Me.lblMalaria.TabIndex = 14
        Me.lblMalaria.Text = "Malaria"
        '
        'lblHIV
        '
        Me.lblHIV.AutoSize = True
        Me.lblHIV.Location = New System.Drawing.Point(353, 154)
        Me.lblHIV.Name = "lblHIV"
        Me.lblHIV.Size = New System.Drawing.Size(25, 13)
        Me.lblHIV.TabIndex = 13
        Me.lblHIV.Text = "HIV"
        '
        'lblTB
        '
        Me.lblTB.AutoSize = True
        Me.lblTB.Location = New System.Drawing.Point(353, 41)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(21, 13)
        Me.lblTB.TabIndex = 12
        Me.lblTB.Text = "TB"
        '
        'txtMalaria
        '
        Me.txtMalaria.Location = New System.Drawing.Point(356, 286)
        Me.txtMalaria.Multiline = True
        Me.txtMalaria.Name = "txtMalaria"
        Me.txtMalaria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMalaria.Size = New System.Drawing.Size(402, 86)
        Me.txtMalaria.TabIndex = 11
        '
        'txtHIV
        '
        Me.txtHIV.Location = New System.Drawing.Point(356, 170)
        Me.txtHIV.Multiline = True
        Me.txtHIV.Name = "txtHIV"
        Me.txtHIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHIV.Size = New System.Drawing.Size(402, 86)
        Me.txtHIV.TabIndex = 10
        '
        'btnBackAd
        '
        Me.btnBackAd.Location = New System.Drawing.Point(653, 408)
        Me.btnBackAd.Name = "btnBackAd"
        Me.btnBackAd.Size = New System.Drawing.Size(75, 23)
        Me.btnBackAd.TabIndex = 9
        Me.btnBackAd.Text = "Back"
        Me.btnBackAd.UseVisualStyleBackColor = True
        '
        'btnUpdatePop
        '
        Me.btnUpdatePop.Location = New System.Drawing.Point(64, 41)
        Me.btnUpdatePop.Name = "btnUpdatePop"
        Me.btnUpdatePop.Size = New System.Drawing.Size(114, 23)
        Me.btnUpdatePop.TabIndex = 8
        Me.btnUpdatePop.Text = "Update Population"
        Me.btnUpdatePop.UseVisualStyleBackColor = True
        '
        'txtTB
        '
        Me.txtTB.Location = New System.Drawing.Point(356, 57)
        Me.txtTB.Multiline = True
        Me.txtTB.Name = "txtTB"
        Me.txtTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTB.Size = New System.Drawing.Size(402, 86)
        Me.txtTB.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(653, 378)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save All to File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbDiseases
        '
        Me.cbDiseases.FormattingEnabled = True
        Me.cbDiseases.Items.AddRange(New Object() {"HIV", "TB", "Malaria"})
        Me.cbDiseases.Location = New System.Drawing.Point(65, 93)
        Me.cbDiseases.Name = "cbDiseases"
        Me.cbDiseases.Size = New System.Drawing.Size(121, 21)
        Me.cbDiseases.TabIndex = 1
        Me.cbDiseases.Text = "Select a disease..."
        '
        'pnlHIV
        '
        Me.pnlHIV.Controls.Add(Me.Label5)
        Me.pnlHIV.Controls.Add(Me.Label4)
        Me.pnlHIV.Controls.Add(Me.Label2)
        Me.pnlHIV.Controls.Add(Me.Label1)
        Me.pnlHIV.Controls.Add(Me.cbxCondoms)
        Me.pnlHIV.Controls.Add(Me.txtHIVYearCases)
        Me.pnlHIV.Controls.Add(Me.txtHIVYearDeaths)
        Me.pnlHIV.Controls.Add(Me.txtNoART)
        Me.pnlHIV.Location = New System.Drawing.Point(65, 120)
        Me.pnlHIV.Name = "pnlHIV"
        Me.pnlHIV.Size = New System.Drawing.Size(200, 185)
        Me.pnlHIV.TabIndex = 4
        Me.pnlHIV.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Free Condom Distribution:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "People with ART:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Number of Deaths:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Number of New Cases:"
        '
        'cbxCondoms
        '
        Me.cbxCondoms.AutoSize = True
        Me.cbxCondoms.Location = New System.Drawing.Point(171, 155)
        Me.cbxCondoms.Name = "cbxCondoms"
        Me.cbxCondoms.Size = New System.Drawing.Size(15, 14)
        Me.cbxCondoms.TabIndex = 12
        Me.cbxCondoms.UseVisualStyleBackColor = True
        '
        'txtHIVYearCases
        '
        Me.txtHIVYearCases.Location = New System.Drawing.Point(135, 25)
        Me.txtHIVYearCases.Name = "txtHIVYearCases"
        Me.txtHIVYearCases.Size = New System.Drawing.Size(52, 20)
        Me.txtHIVYearCases.TabIndex = 8
        '
        'txtHIVYearDeaths
        '
        Me.txtHIVYearDeaths.Location = New System.Drawing.Point(135, 71)
        Me.txtHIVYearDeaths.Name = "txtHIVYearDeaths"
        Me.txtHIVYearDeaths.Size = New System.Drawing.Size(52, 20)
        Me.txtHIVYearDeaths.TabIndex = 9
        '
        'txtNoART
        '
        Me.txtNoART.Location = New System.Drawing.Point(134, 116)
        Me.txtNoART.Name = "txtNoART"
        Me.txtNoART.Size = New System.Drawing.Size(52, 20)
        Me.txtNoART.TabIndex = 11
        '
        'btnRecordInfo
        '
        Me.btnRecordInfo.Enabled = False
        Me.btnRecordInfo.Location = New System.Drawing.Point(64, 349)
        Me.btnRecordInfo.Name = "btnRecordInfo"
        Me.btnRecordInfo.Size = New System.Drawing.Size(114, 23)
        Me.btnRecordInfo.TabIndex = 0
        Me.btnRecordInfo.Text = "Enter Record"
        Me.btnRecordInfo.UseVisualStyleBackColor = True
        '
        'pnlTB
        '
        Me.pnlTB.Controls.Add(Me.lblCasesTB)
        Me.pnlTB.Controls.Add(Me.lblDeathsTB)
        Me.pnlTB.Controls.Add(Me.lblRecTB)
        Me.pnlTB.Controls.Add(Me.lblDOTS)
        Me.pnlTB.Controls.Add(Me.txtDOTS)
        Me.pnlTB.Controls.Add(Me.txtRecTB)
        Me.pnlTB.Controls.Add(Me.txtDeathsTB)
        Me.pnlTB.Controls.Add(Me.txtCasesTB)
        Me.pnlTB.Location = New System.Drawing.Point(67, 484)
        Me.pnlTB.Name = "pnlTB"
        Me.pnlTB.Size = New System.Drawing.Size(200, 172)
        Me.pnlTB.TabIndex = 5
        Me.pnlTB.Visible = False
        '
        'lblCasesTB
        '
        Me.lblCasesTB.AutoSize = True
        Me.lblCasesTB.Location = New System.Drawing.Point(11, 26)
        Me.lblCasesTB.Name = "lblCasesTB"
        Me.lblCasesTB.Size = New System.Drawing.Size(64, 13)
        Me.lblCasesTB.TabIndex = 31
        Me.lblCasesTB.Text = "New Cases:"
        '
        'lblDeathsTB
        '
        Me.lblDeathsTB.AutoSize = True
        Me.lblDeathsTB.Location = New System.Drawing.Point(11, 62)
        Me.lblDeathsTB.Name = "lblDeathsTB"
        Me.lblDeathsTB.Size = New System.Drawing.Size(69, 13)
        Me.lblDeathsTB.TabIndex = 30
        Me.lblDeathsTB.Text = "New Deaths:"
        '
        'lblRecTB
        '
        Me.lblRecTB.AutoSize = True
        Me.lblRecTB.Location = New System.Drawing.Point(11, 99)
        Me.lblRecTB.Name = "lblRecTB"
        Me.lblRecTB.Size = New System.Drawing.Size(89, 13)
        Me.lblRecTB.TabIndex = 29
        Me.lblRecTB.Text = "New Recoveries:"
        '
        'lblDOTS
        '
        Me.lblDOTS.AutoSize = True
        Me.lblDOTS.Location = New System.Drawing.Point(11, 135)
        Me.lblDOTS.Name = "lblDOTS"
        Me.lblDOTS.Size = New System.Drawing.Size(118, 13)
        Me.lblDOTS.TabIndex = 28
        Me.lblDOTS.Text = "People treated (DOTS):"
        '
        'txtDOTS
        '
        Me.txtDOTS.Location = New System.Drawing.Point(135, 132)
        Me.txtDOTS.Name = "txtDOTS"
        Me.txtDOTS.Size = New System.Drawing.Size(52, 20)
        Me.txtDOTS.TabIndex = 17
        '
        'txtRecTB
        '
        Me.txtRecTB.Location = New System.Drawing.Point(135, 96)
        Me.txtRecTB.Name = "txtRecTB"
        Me.txtRecTB.Size = New System.Drawing.Size(52, 20)
        Me.txtRecTB.TabIndex = 16
        '
        'txtDeathsTB
        '
        Me.txtDeathsTB.Location = New System.Drawing.Point(135, 59)
        Me.txtDeathsTB.Name = "txtDeathsTB"
        Me.txtDeathsTB.Size = New System.Drawing.Size(52, 20)
        Me.txtDeathsTB.TabIndex = 15
        '
        'txtCasesTB
        '
        Me.txtCasesTB.Location = New System.Drawing.Point(135, 23)
        Me.txtCasesTB.Name = "txtCasesTB"
        Me.txtCasesTB.Size = New System.Drawing.Size(52, 20)
        Me.txtCasesTB.TabIndex = 14
        '
        'pnlMalaria
        '
        Me.pnlMalaria.Controls.Add(Me.txtMalRecoveries)
        Me.pnlMalaria.Controls.Add(Me.lblPerm)
        Me.pnlMalaria.Controls.Add(Me.cbxPerm)
        Me.pnlMalaria.Controls.Add(Me.lblMalRec)
        Me.pnlMalaria.Controls.Add(Me.lblDeaths)
        Me.pnlMalaria.Controls.Add(Me.lblCases)
        Me.pnlMalaria.Controls.Add(Me.txtNewDeathsMal)
        Me.pnlMalaria.Controls.Add(Me.txtMalCases)
        Me.pnlMalaria.Location = New System.Drawing.Point(298, 484)
        Me.pnlMalaria.Name = "pnlMalaria"
        Me.pnlMalaria.Size = New System.Drawing.Size(200, 179)
        Me.pnlMalaria.TabIndex = 6
        Me.pnlMalaria.Visible = False
        '
        'txtMalRecoveries
        '
        Me.txtMalRecoveries.Location = New System.Drawing.Point(135, 102)
        Me.txtMalRecoveries.Name = "txtMalRecoveries"
        Me.txtMalRecoveries.Size = New System.Drawing.Size(52, 20)
        Me.txtMalRecoveries.TabIndex = 7
        '
        'lblPerm
        '
        Me.lblPerm.AutoSize = True
        Me.lblPerm.Location = New System.Drawing.Point(28, 141)
        Me.lblPerm.Name = "lblPerm"
        Me.lblPerm.Size = New System.Drawing.Size(102, 13)
        Me.lblPerm.TabIndex = 26
        Me.lblPerm.Text = "Permethrin Sprayed:"
        '
        'cbxPerm
        '
        Me.cbxPerm.AutoSize = True
        Me.cbxPerm.Location = New System.Drawing.Point(172, 140)
        Me.cbxPerm.Name = "cbxPerm"
        Me.cbxPerm.Size = New System.Drawing.Size(15, 14)
        Me.cbxPerm.TabIndex = 25
        Me.cbxPerm.UseVisualStyleBackColor = True
        '
        'lblMalRec
        '
        Me.lblMalRec.AutoSize = True
        Me.lblMalRec.Location = New System.Drawing.Point(28, 107)
        Me.lblMalRec.Name = "lblMalRec"
        Me.lblMalRec.Size = New System.Drawing.Size(89, 13)
        Me.lblMalRec.TabIndex = 24
        Me.lblMalRec.Text = "New Recoveries:"
        '
        'lblDeaths
        '
        Me.lblDeaths.AutoSize = True
        Me.lblDeaths.Location = New System.Drawing.Point(28, 66)
        Me.lblDeaths.Name = "lblDeaths"
        Me.lblDeaths.Size = New System.Drawing.Size(69, 13)
        Me.lblDeaths.TabIndex = 23
        Me.lblDeaths.Text = "New Deaths:"
        '
        'lblCases
        '
        Me.lblCases.AutoSize = True
        Me.lblCases.Location = New System.Drawing.Point(28, 30)
        Me.lblCases.Name = "lblCases"
        Me.lblCases.Size = New System.Drawing.Size(64, 13)
        Me.lblCases.TabIndex = 22
        Me.lblCases.Text = "New Cases:"
        '
        'txtNewDeathsMal
        '
        Me.txtNewDeathsMal.Location = New System.Drawing.Point(135, 63)
        Me.txtNewDeathsMal.Name = "txtNewDeathsMal"
        Me.txtNewDeathsMal.Size = New System.Drawing.Size(52, 20)
        Me.txtNewDeathsMal.TabIndex = 19
        '
        'txtMalCases
        '
        Me.txtMalCases.Location = New System.Drawing.Point(135, 27)
        Me.txtMalCases.Name = "txtMalCases"
        Me.txtMalCases.Size = New System.Drawing.Size(52, 20)
        Me.txtMalCases.TabIndex = 19
        '
        'pnlPatient
        '
        Me.pnlPatient.Controls.Add(Me.btnBackP)
        Me.pnlPatient.Controls.Add(Me.btnClear)
        Me.pnlPatient.Controls.Add(Me.txtOutputSymptom)
        Me.pnlPatient.Controls.Add(Me.btnSearch)
        Me.pnlPatient.Controls.Add(Me.cbSymptoms)
        Me.pnlPatient.Location = New System.Drawing.Point(535, 484)
        Me.pnlPatient.Name = "pnlPatient"
        Me.pnlPatient.Size = New System.Drawing.Size(799, 449)
        Me.pnlPatient.TabIndex = 3
        Me.pnlPatient.Visible = False
        '
        'btnBackP
        '
        Me.btnBackP.Location = New System.Drawing.Point(686, 390)
        Me.btnBackP.Name = "btnBackP"
        Me.btnBackP.Size = New System.Drawing.Size(75, 23)
        Me.btnBackP.TabIndex = 4
        Me.btnBackP.Text = "Back"
        Me.btnBackP.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(43, 189)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtOutputSymptom
        '
        Me.txtOutputSymptom.Location = New System.Drawing.Point(170, 30)
        Me.txtOutputSymptom.Multiline = True
        Me.txtOutputSymptom.Name = "txtOutputSymptom"
        Me.txtOutputSymptom.Size = New System.Drawing.Size(157, 182)
        Me.txtOutputSymptom.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(43, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbSymptoms
        '
        Me.cbSymptoms.FormattingEnabled = True
        Me.cbSymptoms.Items.AddRange(New Object() {"Chronic Diarrhoea", "Night Sweats", "Fever", "Rashes", "Chills", "Sore throat", "Swollen Lymph Nodes", "Ulcers", "Headache", "Vomiting", "Fatigue", "Cough", "Coughing Blood", "Chills", "No Appetite", "Chest pain", "Weight Loss"})
        Me.cbSymptoms.Location = New System.Drawing.Point(43, 30)
        Me.cbSymptoms.Name = "cbSymptoms"
        Me.cbSymptoms.Size = New System.Drawing.Size(121, 21)
        Me.cbSymptoms.TabIndex = 0
        Me.cbSymptoms.Text = "Please Select Value"
        '
        'FrmDiseaseTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.pnlMalaria)
        Me.Controls.Add(Me.pnlTB)
        Me.Controls.Add(Me.pnlPatient)
        Me.Controls.Add(Me.pnlDoctor)
        Me.Controls.Add(Me.btnPatient)
        Me.Controls.Add(Me.btnAdmin)
        Me.Name = "FrmDiseaseTracker"
        Me.Text = "Disease Tracker"
        Me.pnlDoctor.ResumeLayout(False)
        Me.pnlDoctor.PerformLayout()
        Me.pnlHIV.ResumeLayout(False)
        Me.pnlHIV.PerformLayout()
        Me.pnlTB.ResumeLayout(False)
        Me.pnlTB.PerformLayout()
        Me.pnlMalaria.ResumeLayout(False)
        Me.pnlMalaria.PerformLayout()
        Me.pnlPatient.ResumeLayout(False)
        Me.pnlPatient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnPatient As Button
    Friend WithEvents pnlDoctor As Panel
    Friend WithEvents pnlPatient As Panel
    Friend WithEvents cbSymptoms As ComboBox
    Friend WithEvents cbDiseases As ComboBox
    Friend WithEvents btnRecordInfo As Button
    Friend WithEvents pnlTB As Panel
    Friend WithEvents pnlMalaria As Panel
    Friend WithEvents pnlHIV As Panel
    Friend WithEvents txtHIVYearCases As TextBox
    Friend WithEvents txtHIVYearDeaths As TextBox
    Friend WithEvents txtNoART As TextBox
    Friend WithEvents txtDOTS As TextBox
    Friend WithEvents txtRecTB As TextBox
    Friend WithEvents txtDeathsTB As TextBox
    Friend WithEvents txtCasesTB As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents txtNewDeathsMal As TextBox
    Friend WithEvents txtMalCases As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTB As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtOutputSymptom As TextBox
    Friend WithEvents cbxCondoms As CheckBox
    Friend WithEvents btnUpdatePop As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCases As Label
    Friend WithEvents lblDeaths As Label
    Friend WithEvents lblMalRec As Label
    Friend WithEvents lblPerm As Label
    Friend WithEvents cbxPerm As CheckBox
    Friend WithEvents lblDOTS As Label
    Friend WithEvents lblCasesTB As Label
    Friend WithEvents lblDeathsTB As Label
    Friend WithEvents lblRecTB As Label
    Friend WithEvents txtMalRecoveries As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBackAd As Button
    Friend WithEvents btnBackP As Button
    Friend WithEvents lblMalaria As Label
    Friend WithEvents lblHIV As Label
    Friend WithEvents lblTB As Label
    Friend WithEvents txtMalaria As TextBox
    Friend WithEvents txtHIV As TextBox
    Friend WithEvents lblCurrentPop As Label
End Class
