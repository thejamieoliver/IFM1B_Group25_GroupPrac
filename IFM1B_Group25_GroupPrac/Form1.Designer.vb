<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.cbDiseases = New System.Windows.Forms.ComboBox()
        Me.pnlHIV = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnRecordInfo = New System.Windows.Forms.Button()
        Me.pnlTB = New System.Windows.Forms.Panel()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.pnlMalaria = New System.Windows.Forms.Panel()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.pnlPatient = New System.Windows.Forms.Panel()
        Me.cbSymptoms = New System.Windows.Forms.ComboBox()
        Me.UjGrid1 = New UJGrid.UJGrid()
        Me.pnlDoctor.SuspendLayout()
        Me.pnlHIV.SuspendLayout()
        Me.pnlTB.SuspendLayout()
        Me.pnlMalaria.SuspendLayout()
        Me.pnlPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(313, 236)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnPatient
        '
        Me.btnPatient.Location = New System.Drawing.Point(313, 152)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(75, 23)
        Me.btnPatient.TabIndex = 1
        Me.btnPatient.Text = "Patient"
        Me.btnPatient.UseVisualStyleBackColor = True
        '
        'pnlDoctor
        '
        Me.pnlDoctor.Controls.Add(Me.UjGrid1)
        Me.pnlDoctor.Controls.Add(Me.cbDiseases)
        Me.pnlDoctor.Controls.Add(Me.pnlHIV)
        Me.pnlDoctor.Controls.Add(Me.btnRecordInfo)
        Me.pnlDoctor.Location = New System.Drawing.Point(0, 0)
        Me.pnlDoctor.Name = "pnlDoctor"
        Me.pnlDoctor.Size = New System.Drawing.Size(799, 449)
        Me.pnlDoctor.TabIndex = 2
        Me.pnlDoctor.Visible = False
        '
        'cbDiseases
        '
        Me.cbDiseases.FormattingEnabled = True
        Me.cbDiseases.Items.AddRange(New Object() {"HIV", "TB", "Malaria"})
        Me.cbDiseases.Location = New System.Drawing.Point(65, 30)
        Me.cbDiseases.Name = "cbDiseases"
        Me.cbDiseases.Size = New System.Drawing.Size(121, 21)
        Me.cbDiseases.TabIndex = 1
        Me.cbDiseases.Text = "Select a disease..."
        '
        'pnlHIV
        '
        Me.pnlHIV.Controls.Add(Me.TextBox2)
        Me.pnlHIV.Controls.Add(Me.TextBox1)
        Me.pnlHIV.Controls.Add(Me.TextBox3)
        Me.pnlHIV.Controls.Add(Me.TextBox4)
        Me.pnlHIV.Controls.Add(Me.TextBox5)
        Me.pnlHIV.Controls.Add(Me.TextBox6)
        Me.pnlHIV.Location = New System.Drawing.Point(65, 57)
        Me.pnlHIV.Name = "pnlHIV"
        Me.pnlHIV.Size = New System.Drawing.Size(200, 315)
        Me.pnlHIV.TabIndex = 4
        Me.pnlHIV.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(135, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(52, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(135, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(52, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(135, 165)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(52, 20)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(135, 212)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(52, 20)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(135, 261)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(52, 20)
        Me.TextBox6.TabIndex = 13
        '
        'btnRecordInfo
        '
        Me.btnRecordInfo.Location = New System.Drawing.Point(43, 378)
        Me.btnRecordInfo.Name = "btnRecordInfo"
        Me.btnRecordInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnRecordInfo.TabIndex = 0
        Me.btnRecordInfo.Text = "New Year"
        Me.btnRecordInfo.UseVisualStyleBackColor = True
        '
        'pnlTB
        '
        Me.pnlTB.Controls.Add(Me.TextBox11)
        Me.pnlTB.Controls.Add(Me.TextBox10)
        Me.pnlTB.Controls.Add(Me.TextBox9)
        Me.pnlTB.Controls.Add(Me.TextBox8)
        Me.pnlTB.Controls.Add(Me.TextBox7)
        Me.pnlTB.Location = New System.Drawing.Point(437, 470)
        Me.pnlTB.Name = "pnlTB"
        Me.pnlTB.Size = New System.Drawing.Size(200, 315)
        Me.pnlTB.TabIndex = 5
        Me.pnlTB.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(135, 230)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(52, 20)
        Me.TextBox11.TabIndex = 18
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(135, 177)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(52, 20)
        Me.TextBox10.TabIndex = 17
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(135, 130)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(52, 20)
        Me.TextBox9.TabIndex = 16
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(135, 79)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(52, 20)
        Me.TextBox8.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(135, 27)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(52, 20)
        Me.TextBox7.TabIndex = 14
        '
        'pnlMalaria
        '
        Me.pnlMalaria.Controls.Add(Me.TextBox15)
        Me.pnlMalaria.Controls.Add(Me.TextBox14)
        Me.pnlMalaria.Controls.Add(Me.TextBox13)
        Me.pnlMalaria.Controls.Add(Me.TextBox12)
        Me.pnlMalaria.Location = New System.Drawing.Point(65, 470)
        Me.pnlMalaria.Name = "pnlMalaria"
        Me.pnlMalaria.Size = New System.Drawing.Size(200, 315)
        Me.pnlMalaria.TabIndex = 6
        Me.pnlMalaria.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(135, 177)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(52, 20)
        Me.TextBox15.TabIndex = 21
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(135, 130)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(52, 20)
        Me.TextBox14.TabIndex = 20
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(135, 79)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(52, 20)
        Me.TextBox13.TabIndex = 19
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(135, 27)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(52, 20)
        Me.TextBox12.TabIndex = 19
        '
        'pnlPatient
        '
        Me.pnlPatient.Controls.Add(Me.cbSymptoms)
        Me.pnlPatient.Location = New System.Drawing.Point(855, 493)
        Me.pnlPatient.Name = "pnlPatient"
        Me.pnlPatient.Size = New System.Drawing.Size(317, 209)
        Me.pnlPatient.TabIndex = 3
        Me.pnlPatient.Visible = False
        '
        'cbSymptoms
        '
        Me.cbSymptoms.FormattingEnabled = True
        Me.cbSymptoms.Location = New System.Drawing.Point(158, 25)
        Me.cbSymptoms.Name = "cbSymptoms"
        Me.cbSymptoms.Size = New System.Drawing.Size(121, 21)
        Me.cbSymptoms.TabIndex = 0
        '
        'UjGrid1
        '
        Me.UjGrid1.FixedCols = 1
        Me.UjGrid1.FixedRows = 1
        Me.UjGrid1.Location = New System.Drawing.Point(539, 66)
        Me.UjGrid1.Name = "UjGrid1"
        Me.UjGrid1.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.UjGrid1.Size = New System.Drawing.Size(229, 150)
        Me.UjGrid1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 749)
        Me.Controls.Add(Me.pnlMalaria)
        Me.Controls.Add(Me.pnlTB)
        Me.Controls.Add(Me.pnlPatient)
        Me.Controls.Add(Me.pnlDoctor)
        Me.Controls.Add(Me.btnPatient)
        Me.Controls.Add(Me.btnAdmin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlDoctor.ResumeLayout(False)
        Me.pnlHIV.ResumeLayout(False)
        Me.pnlHIV.PerformLayout()
        Me.pnlTB.ResumeLayout(False)
        Me.pnlTB.PerformLayout()
        Me.pnlMalaria.ResumeLayout(False)
        Me.pnlMalaria.PerformLayout()
        Me.pnlPatient.ResumeLayout(False)
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents UjGrid1 As UJGrid.UJGrid
End Class
