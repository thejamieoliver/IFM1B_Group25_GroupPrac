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
        Me.btnRecordInfo = New System.Windows.Forms.Button()
        Me.pnlPatient = New System.Windows.Forms.Panel()
        Me.cbSymptoms = New System.Windows.Forms.ComboBox()
        Me.pnlNewDisease = New System.Windows.Forms.Panel()
        Me.pnlDoctor.SuspendLayout()
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
        Me.pnlDoctor.Controls.Add(Me.pnlNewDisease)
        Me.pnlDoctor.Controls.Add(Me.pnlPatient)
        Me.pnlDoctor.Controls.Add(Me.cbDiseases)
        Me.pnlDoctor.Controls.Add(Me.btnRecordInfo)
        Me.pnlDoctor.Location = New System.Drawing.Point(1, 1)
        Me.pnlDoctor.Name = "pnlDoctor"
        Me.pnlDoctor.Size = New System.Drawing.Size(799, 449)
        Me.pnlDoctor.TabIndex = 2
        Me.pnlDoctor.Visible = False
        '
        'cbDiseases
        '
        Me.cbDiseases.FormattingEnabled = True
        Me.cbDiseases.Items.AddRange(New Object() {"HIV", "TB", "Malaria"})
        Me.cbDiseases.Location = New System.Drawing.Point(65, 64)
        Me.cbDiseases.Name = "cbDiseases"
        Me.cbDiseases.Size = New System.Drawing.Size(121, 21)
        Me.cbDiseases.TabIndex = 1
        Me.cbDiseases.Text = "Select a disease..."
        '
        'btnRecordInfo
        '
        Me.btnRecordInfo.Location = New System.Drawing.Point(65, 91)
        Me.btnRecordInfo.Name = "btnRecordInfo"
        Me.btnRecordInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnRecordInfo.TabIndex = 0
        Me.btnRecordInfo.Text = "New Year"
        Me.btnRecordInfo.UseVisualStyleBackColor = True
        '
        'pnlPatient
        '
        Me.pnlPatient.Controls.Add(Me.cbSymptoms)
        Me.pnlPatient.Location = New System.Drawing.Point(103, 137)
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
        'pnlNewDisease
        '
        Me.pnlNewDisease.Location = New System.Drawing.Point(572, 26)
        Me.pnlNewDisease.Name = "pnlNewDisease"
        Me.pnlNewDisease.Size = New System.Drawing.Size(200, 100)
        Me.pnlNewDisease.TabIndex = 3
        Me.pnlNewDisease.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlDoctor)
        Me.Controls.Add(Me.btnPatient)
        Me.Controls.Add(Me.btnAdmin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlDoctor.ResumeLayout(False)
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
    Friend WithEvents pnlNewDisease As Panel
End Class
