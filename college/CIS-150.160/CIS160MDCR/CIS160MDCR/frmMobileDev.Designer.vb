<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMobileDev
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
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblCorpID = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtNumOfDays = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpCourses = New System.Windows.Forms.GroupBox()
        Me.radDatabases = New System.Windows.Forms.RadioButton()
        Me.radDesign = New System.Windows.Forms.RadioButton()
        Me.radSecurity = New System.Windows.Forms.RadioButton()
        Me.grpPreConference = New System.Windows.Forms.GroupBox()
        Me.radWindows = New System.Windows.Forms.RadioButton()
        Me.radAndroid = New System.Windows.Forms.RadioButton()
        Me.mtbCorporateID = New System.Windows.Forms.MaskedTextBox()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCourses.SuspendLayout()
        Me.grpPreConference.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBanner
        '
        Me.picBanner.Image = Global.CIS160MDCR.My.Resources.Resources.Mobile
        Me.picBanner.Location = New System.Drawing.Point(164, 12)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(497, 149)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner.TabIndex = 0
        Me.picBanner.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(227, 179)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(387, 82)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Mobile Developer's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conference Registration"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorpID
        '
        Me.lblCorpID.AutoSize = True
        Me.lblCorpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorpID.Location = New System.Drawing.Point(283, 297)
        Me.lblCorpID.Name = "lblCorpID"
        Me.lblCorpID.Size = New System.Drawing.Size(124, 18)
        Me.lblCorpID.TabIndex = 2
        Me.lblCorpID.Text = "Corporation ID:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(413, 331)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(94, 18)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number Of Days:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(273, 575)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(294, 18)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.Text = "Total conference costs are: $1,725.00"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(234, 329)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(136, 22)
        Me.txtFirstName.TabIndex = 7
        '
        'txtNumOfDays
        '
        Me.txtNumOfDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOfDays.Location = New System.Drawing.Point(234, 366)
        Me.txtNumOfDays.Name = "txtNumOfDays"
        Me.txtNumOfDays.Size = New System.Drawing.Size(60, 22)
        Me.txtNumOfDays.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(528, 332)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(266, 22)
        Me.txtLastName.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Salmon
        Me.btnCalculate.Location = New System.Drawing.Point(164, 522)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(206, 36)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate Costs"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Salmon
        Me.btnClear.Location = New System.Drawing.Point(455, 522)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(206, 36)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'grpCourses
        '
        Me.grpCourses.Controls.Add(Me.radDatabases)
        Me.grpCourses.Controls.Add(Me.radDesign)
        Me.grpCourses.Controls.Add(Me.radSecurity)
        Me.grpCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCourses.Location = New System.Drawing.Point(416, 366)
        Me.grpCourses.Name = "grpCourses"
        Me.grpCourses.Size = New System.Drawing.Size(334, 100)
        Me.grpCourses.TabIndex = 13
        Me.grpCourses.TabStop = False
        Me.grpCourses.Text = "Courses"
        '
        'radDatabases
        '
        Me.radDatabases.AutoSize = True
        Me.radDatabases.Location = New System.Drawing.Point(7, 66)
        Me.radDatabases.Name = "radDatabases"
        Me.radDatabases.Size = New System.Drawing.Size(161, 22)
        Me.radDatabases.TabIndex = 2
        Me.radDatabases.TabStop = True
        Me.radDatabases.Text = "Mobile Databases"
        Me.radDatabases.UseVisualStyleBackColor = True
        '
        'radDesign
        '
        Me.radDesign.AutoSize = True
        Me.radDesign.Location = New System.Drawing.Point(7, 43)
        Me.radDesign.Name = "radDesign"
        Me.radDesign.Size = New System.Drawing.Size(133, 22)
        Me.radDesign.TabIndex = 1
        Me.radDesign.TabStop = True
        Me.radDesign.Text = "Mobile Design"
        Me.radDesign.UseVisualStyleBackColor = True
        '
        'radSecurity
        '
        Me.radSecurity.AutoSize = True
        Me.radSecurity.Location = New System.Drawing.Point(7, 20)
        Me.radSecurity.Name = "radSecurity"
        Me.radSecurity.Size = New System.Drawing.Size(142, 22)
        Me.radSecurity.TabIndex = 0
        Me.radSecurity.TabStop = True
        Me.radSecurity.Text = "Mobile Security"
        Me.radSecurity.UseVisualStyleBackColor = True
        '
        'grpPreConference
        '
        Me.grpPreConference.Controls.Add(Me.radWindows)
        Me.grpPreConference.Controls.Add(Me.radAndroid)
        Me.grpPreConference.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPreConference.Location = New System.Drawing.Point(50, 416)
        Me.grpPreConference.Name = "grpPreConference"
        Me.grpPreConference.Size = New System.Drawing.Size(244, 100)
        Me.grpPreConference.TabIndex = 14
        Me.grpPreConference.TabStop = False
        Me.grpPreConference.Text = "Pre-Conference"
        '
        'radWindows
        '
        Me.radWindows.AutoSize = True
        Me.radWindows.Location = New System.Drawing.Point(6, 66)
        Me.radWindows.Name = "radWindows"
        Me.radWindows.Size = New System.Drawing.Size(193, 22)
        Me.radWindows.TabIndex = 2
        Me.radWindows.TabStop = True
        Me.radWindows.Text = "Window's Store Track"
        Me.radWindows.UseVisualStyleBackColor = True
        '
        'radAndroid
        '
        Me.radAndroid.AutoSize = True
        Me.radAndroid.Location = New System.Drawing.Point(7, 20)
        Me.radAndroid.Name = "radAndroid"
        Me.radAndroid.Size = New System.Drawing.Size(145, 40)
        Me.radAndroid.TabIndex = 0
        Me.radAndroid.TabStop = True
        Me.radAndroid.Text = "Pre-Conference" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Android Track"
        Me.radAndroid.UseVisualStyleBackColor = True
        '
        'mtbCorporateID
        '
        Me.mtbCorporateID.Location = New System.Drawing.Point(423, 295)
        Me.mtbCorporateID.Mask = "00000"
        Me.mtbCorporateID.Name = "mtbCorporateID"
        Me.mtbCorporateID.Size = New System.Drawing.Size(100, 20)
        Me.mtbCorporateID.TabIndex = 15
        Me.mtbCorporateID.ValidatingType = GetType(Integer)
        '
        'frmMobileDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 604)
        Me.Controls.Add(Me.mtbCorporateID)
        Me.Controls.Add(Me.grpPreConference)
        Me.Controls.Add(Me.grpCourses)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtNumOfDays)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblCorpID)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picBanner)
        Me.Name = "frmMobileDev"
        Me.Text = "Mobile Developer Conference"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCourses.ResumeLayout(False)
        Me.grpCourses.PerformLayout()
        Me.grpPreConference.ResumeLayout(False)
        Me.grpPreConference.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBanner As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblCorpID As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtNumOfDays As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpCourses As GroupBox
    Friend WithEvents radDatabases As RadioButton
    Friend WithEvents radDesign As RadioButton
    Friend WithEvents radSecurity As RadioButton
    Friend WithEvents grpPreConference As GroupBox
    Friend WithEvents radWindows As RadioButton
    Friend WithEvents radAndroid As RadioButton
    Friend WithEvents mtbCorporateID As MaskedTextBox
End Class
