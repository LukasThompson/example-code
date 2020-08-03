<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicnic
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
        Me.imgPicnic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.imgPicnic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgPicnic
        '
        Me.imgPicnic.Image = Global.CIS150StudentPicnic.My.Resources.Resources.Picnic
        Me.imgPicnic.Location = New System.Drawing.Point(24, 28)
        Me.imgPicnic.Name = "imgPicnic"
        Me.imgPicnic.Size = New System.Drawing.Size(320, 330)
        Me.imgPicnic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPicnic.TabIndex = 0
        Me.imgPicnic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(407, 28)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(280, 25)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Annual Spring Fling Picnic"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(452, 70)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(190, 19)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "All Students are Welcome"
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.YellowGreen
        Me.btnInfo.Location = New System.Drawing.Point(410, 121)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(275, 49)
        Me.btnInfo.TabIndex = 3
        Me.btnInfo.Text = "View Picnic Information"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(491, 206)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(112, 19)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "April 17, 2015"
        Me.lblDate.Visible = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(434, 237)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(227, 38)
        Me.lblLocation.TabIndex = 5
        Me.lblLocation.Text = "Located in the Quad in front of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        the Barnard Building"
        Me.lblLocation.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.YellowGreen
        Me.btnExit.Location = New System.Drawing.Point(410, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(275, 49)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmPicnic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(726, 401)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.imgPicnic)
        Me.Name = "frmPicnic"
        Me.Text = "Student Picnic"
        CType(Me.imgPicnic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgPicnic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents btnExit As Button
End Class
