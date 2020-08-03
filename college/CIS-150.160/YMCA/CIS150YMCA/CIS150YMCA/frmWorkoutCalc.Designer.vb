<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkoutCalc
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtDOBMonth = New System.Windows.Forms.TextBox()
        Me.txtDateMonth = New System.Windows.Forms.TextBox()
        Me.txtDateDay = New System.Windows.Forms.TextBox()
        Me.txtDOBDay = New System.Windows.Forms.TextBox()
        Me.txtDOBYear = New System.Windows.Forms.TextBox()
        Me.txtDateYear = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(38, 229)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(210, 40)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Please enter your first name," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " DOB, and today's date"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(17, 165)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(256, 24)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "WORKOUT CALCULATOR"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(63, 305)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(48, 334)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(48, 20)
        Me.lblDOB.TabIndex = 3
        Me.lblDOB.Text = "DOB:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(49, 360)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(125, 307)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 5
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(43, 406)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(173, 406)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(108, 583)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(66, 465)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(158, 80)
        Me.lblOutput.TabIndex = 17
        Me.lblOutput.Text = "Hello ""Friend"" " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have worked out " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXX " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hours in your lifetime."
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDOBMonth
        '
        Me.txtDOBMonth.Location = New System.Drawing.Point(103, 333)
        Me.txtDOBMonth.Name = "txtDOBMonth"
        Me.txtDOBMonth.Size = New System.Drawing.Size(37, 20)
        Me.txtDOBMonth.TabIndex = 18
        Me.txtDOBMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDateMonth
        '
        Me.txtDateMonth.Location = New System.Drawing.Point(103, 360)
        Me.txtDateMonth.Name = "txtDateMonth"
        Me.txtDateMonth.Size = New System.Drawing.Size(37, 20)
        Me.txtDateMonth.TabIndex = 19
        Me.txtDateMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDateDay
        '
        Me.txtDateDay.Location = New System.Drawing.Point(146, 360)
        Me.txtDateDay.Name = "txtDateDay"
        Me.txtDateDay.Size = New System.Drawing.Size(37, 20)
        Me.txtDateDay.TabIndex = 20
        Me.txtDateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDOBDay
        '
        Me.txtDOBDay.Location = New System.Drawing.Point(145, 334)
        Me.txtDOBDay.Name = "txtDOBDay"
        Me.txtDOBDay.Size = New System.Drawing.Size(37, 20)
        Me.txtDOBDay.TabIndex = 21
        Me.txtDOBDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDOBYear
        '
        Me.txtDOBYear.Location = New System.Drawing.Point(188, 333)
        Me.txtDOBYear.Name = "txtDOBYear"
        Me.txtDOBYear.Size = New System.Drawing.Size(55, 20)
        Me.txtDOBYear.TabIndex = 22
        Me.txtDOBYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDateYear
        '
        Me.txtDateYear.Location = New System.Drawing.Point(189, 360)
        Me.txtDateYear.Name = "txtDateYear"
        Me.txtDateYear.Size = New System.Drawing.Size(55, 20)
        Me.txtDateYear.TabIndex = 23
        Me.txtDateYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.CIS150YMCA.My.Resources.Resources.YMCA__logo
        Me.picLogo.Location = New System.Drawing.Point(-1, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(296, 153)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 24
        Me.picLogo.TabStop = False
        '
        'frmWorkoutCalc
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(290, 616)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtDateYear)
        Me.Controls.Add(Me.txtDOBYear)
        Me.Controls.Add(Me.txtDOBDay)
        Me.Controls.Add(Me.txtDateDay)
        Me.Controls.Add(Me.txtDateMonth)
        Me.Controls.Add(Me.txtDOBMonth)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "frmWorkoutCalc"
        Me.Text = "YMCA Workout Calculator"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtDOBMonth As TextBox
    Friend WithEvents txtDateMonth As TextBox
    Friend WithEvents txtDateDay As TextBox
    Friend WithEvents txtDOBDay As TextBox
    Friend WithEvents txtDOBYear As TextBox
    Friend WithEvents txtDateYear As TextBox
    Friend WithEvents picLogo As PictureBox
End Class
