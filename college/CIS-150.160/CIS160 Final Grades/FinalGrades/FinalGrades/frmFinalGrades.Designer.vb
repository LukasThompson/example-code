<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinalGrades))
        Me.lblSalutation = New System.Windows.Forms.Label()
        Me.picGradeBook = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblSaveLocation = New System.Windows.Forms.Label()
        Me.pnlResults = New System.Windows.Forms.Panel()
        CType(Me.picGradeBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSalutation
        '
        Me.lblSalutation.AutoSize = True
        Me.lblSalutation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalutation.Location = New System.Drawing.Point(13, 162)
        Me.lblSalutation.Name = "lblSalutation"
        Me.lblSalutation.Size = New System.Drawing.Size(286, 58)
        Me.lblSalutation.TabIndex = 1
        Me.lblSalutation.Text = "Please click button below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to enter grades:"
        Me.lblSalutation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGradeBook
        '
        Me.picGradeBook.Image = Global.FinalGrades.My.Resources.Resources.TeachersGradebook
        Me.picGradeBook.Location = New System.Drawing.Point(305, 12)
        Me.picGradeBook.Name = "picGradeBook"
        Me.picGradeBook.Size = New System.Drawing.Size(256, 256)
        Me.picGradeBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGradeBook.TabIndex = 2
        Me.picGradeBook.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Red
        Me.lblHeader.Location = New System.Drawing.Point(20, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(272, 84)
        Me.lblHeader.TabIndex = 3
        Me.lblHeader.Text = "Grade Average" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(54, 25)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(218, 24)
        Me.lblResults.TabIndex = 4
        Me.lblResults.Text = "The final average is: 85%"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGrades
        '
        Me.btnGrades.BackColor = System.Drawing.Color.DarkRed
        Me.btnGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.Snow
        Me.btnGrades.Location = New System.Drawing.Point(85, 227)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(143, 41)
        Me.btnGrades.TabIndex = 5
        Me.btnGrades.Text = "Enter Grades"
        Me.btnGrades.UseVisualStyleBackColor = False
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(45, 49)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(236, 24)
        Me.lblFile.TabIndex = 6
        Me.lblFile.Text = "The file has been saved to:"
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaveLocation
        '
        Me.lblSaveLocation.AutoSize = True
        Me.lblSaveLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaveLocation.Location = New System.Drawing.Point(72, 73)
        Me.lblSaveLocation.Name = "lblSaveLocation"
        Me.lblSaveLocation.Size = New System.Drawing.Size(182, 24)
        Me.lblSaveLocation.TabIndex = 7
        Me.lblSaveLocation.Text = "G:\StudentGrades.txt"
        Me.lblSaveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlResults
        '
        Me.pnlResults.Controls.Add(Me.lblResults)
        Me.pnlResults.Controls.Add(Me.lblSaveLocation)
        Me.pnlResults.Controls.Add(Me.lblFile)
        Me.pnlResults.Location = New System.Drawing.Point(124, 292)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(327, 122)
        Me.pnlResults.TabIndex = 8
        Me.pnlResults.Visible = False
        '
        'frmFinalGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 426)
        Me.Controls.Add(Me.pnlResults)
        Me.Controls.Add(Me.btnGrades)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picGradeBook)
        Me.Controls.Add(Me.lblSalutation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFinalGrades"
        Me.Text = "Averages For Class Grades"
        CType(Me.picGradeBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResults.ResumeLayout(False)
        Me.pnlResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSalutation As Label
    Friend WithEvents picGradeBook As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents btnGrades As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents lblSaveLocation As Label
    Friend WithEvents pnlResults As Panel
End Class
