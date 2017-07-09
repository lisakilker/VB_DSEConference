<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevelopersSkillsConference
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.picDevs = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalCostForAttendees = New System.Windows.Forms.Label()
        Me.lblDevelopersSkillsEnhancement = New System.Windows.Forms.Label()
        Me.lblHostedByDIMC = New System.Windows.Forms.Label()
        Me.grpPreviousAttendance = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.lblHowManyEmployees = New System.Windows.Forms.Label()
        Me.txtNumberAttending = New System.Windows.Forms.TextBox()
        Me.lblEmployees = New System.Windows.Forms.Label()
        CType(Me.picDevs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPreviousAttendance.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(329, 344)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 24)
        Me.lblTotalCost.TabIndex = 17
        '
        'picDevs
        '
        Me.picDevs.Image = Global.DSEConferenceApplication.My.Resources.Resources.DevPhoto
        Me.picDevs.Location = New System.Drawing.Point(10, 71)
        Me.picDevs.Margin = New System.Windows.Forms.Padding(4)
        Me.picDevs.Name = "picDevs"
        Me.picDevs.Size = New System.Drawing.Size(248, 212)
        Me.picDevs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picDevs.TabIndex = 16
        Me.picDevs.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(267, 302)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 28)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(144, 302)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 28)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalCostForAttendees
        '
        Me.lblTotalCostForAttendees.AutoSize = True
        Me.lblTotalCostForAttendees.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostForAttendees.Location = New System.Drawing.Point(76, 344)
        Me.lblTotalCostForAttendees.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalCostForAttendees.Name = "lblTotalCostForAttendees"
        Me.lblTotalCostForAttendees.Size = New System.Drawing.Size(213, 24)
        Me.lblTotalCostForAttendees.TabIndex = 12
        Me.lblTotalCostForAttendees.Text = "Total Cost for Attendees:"
        '
        'lblDevelopersSkillsEnhancement
        '
        Me.lblDevelopersSkillsEnhancement.AutoSize = True
        Me.lblDevelopersSkillsEnhancement.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevelopersSkillsEnhancement.Location = New System.Drawing.Point(12, 9)
        Me.lblDevelopersSkillsEnhancement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDevelopersSkillsEnhancement.Name = "lblDevelopersSkillsEnhancement"
        Me.lblDevelopersSkillsEnhancement.Size = New System.Drawing.Size(464, 25)
        Me.lblDevelopersSkillsEnhancement.TabIndex = 9
        Me.lblDevelopersSkillsEnhancement.Text = "Developers Skills Enhacement Conference"
        '
        'lblHostedByDIMC
        '
        Me.lblHostedByDIMC.AutoSize = True
        Me.lblHostedByDIMC.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostedByDIMC.Location = New System.Drawing.Point(174, 34)
        Me.lblHostedByDIMC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHostedByDIMC.Name = "lblHostedByDIMC"
        Me.lblHostedByDIMC.Size = New System.Drawing.Size(140, 21)
        Me.lblHostedByDIMC.TabIndex = 18
        Me.lblHostedByDIMC.Text = "Hosted by DIMC"
        '
        'grpPreviousAttendance
        '
        Me.grpPreviousAttendance.BackColor = System.Drawing.Color.Transparent
        Me.grpPreviousAttendance.Controls.Add(Me.radNo)
        Me.grpPreviousAttendance.Controls.Add(Me.radYes)
        Me.grpPreviousAttendance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPreviousAttendance.Location = New System.Drawing.Point(273, 190)
        Me.grpPreviousAttendance.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPreviousAttendance.Name = "grpPreviousAttendance"
        Me.grpPreviousAttendance.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPreviousAttendance.Size = New System.Drawing.Size(203, 94)
        Me.grpPreviousAttendance.TabIndex = 12
        Me.grpPreviousAttendance.TabStop = False
        Me.grpPreviousAttendance.Text = "Have you attended a previous conference?"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNo.Location = New System.Drawing.Point(11, 62)
        Me.radNo.Margin = New System.Windows.Forms.Padding(4)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(47, 23)
        Me.radNo.TabIndex = 3
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radYes.Location = New System.Drawing.Point(11, 40)
        Me.radYes.Margin = New System.Windows.Forms.Padding(4)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(49, 23)
        Me.radYes.TabIndex = 0
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'lblHowManyEmployees
        '
        Me.lblHowManyEmployees.AutoSize = True
        Me.lblHowManyEmployees.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowManyEmployees.Location = New System.Drawing.Point(273, 71)
        Me.lblHowManyEmployees.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHowManyEmployees.Name = "lblHowManyEmployees"
        Me.lblHowManyEmployees.Size = New System.Drawing.Size(186, 42)
        Me.lblHowManyEmployees.TabIndex = 19
        Me.lblHowManyEmployees.Text = "How many Employees " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be attending?"
        Me.lblHowManyEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumberAttending
        '
        Me.txtNumberAttending.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberAttending.Location = New System.Drawing.Point(295, 123)
        Me.txtNumberAttending.Name = "txtNumberAttending"
        Me.txtNumberAttending.Size = New System.Drawing.Size(30, 30)
        Me.txtNumberAttending.TabIndex = 20
        Me.txtNumberAttending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEmployees
        '
        Me.lblEmployees.AutoSize = True
        Me.lblEmployees.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployees.Location = New System.Drawing.Point(328, 129)
        Me.lblEmployees.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployees.Name = "lblEmployees"
        Me.lblEmployees.Size = New System.Drawing.Size(113, 24)
        Me.lblEmployees.TabIndex = 21
        Me.lblEmployees.Text = "Employee(s)"
        '
        'frmDevelopersSkillsConference
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(489, 391)
        Me.Controls.Add(Me.lblEmployees)
        Me.Controls.Add(Me.txtNumberAttending)
        Me.Controls.Add(Me.lblHowManyEmployees)
        Me.Controls.Add(Me.grpPreviousAttendance)
        Me.Controls.Add(Me.lblHostedByDIMC)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCostForAttendees)
        Me.Controls.Add(Me.lblDevelopersSkillsEnhancement)
        Me.Controls.Add(Me.picDevs)
        Me.Name = "frmDevelopersSkillsConference"
        Me.Text = "Developers Skills Enhancement Conference"
        CType(Me.picDevs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPreviousAttendance.ResumeLayout(False)
        Me.grpPreviousAttendance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents picDevs As System.Windows.Forms.PictureBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTotalCostForAttendees As System.Windows.Forms.Label
    Friend WithEvents lblDevelopersSkillsEnhancement As System.Windows.Forms.Label
    Friend WithEvents lblHostedByDIMC As System.Windows.Forms.Label
    Friend WithEvents grpPreviousAttendance As System.Windows.Forms.GroupBox
    Friend WithEvents radNo As System.Windows.Forms.RadioButton
    Friend WithEvents radYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblHowManyEmployees As System.Windows.Forms.Label
    Friend WithEvents txtNumberAttending As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployees As System.Windows.Forms.Label

End Class
