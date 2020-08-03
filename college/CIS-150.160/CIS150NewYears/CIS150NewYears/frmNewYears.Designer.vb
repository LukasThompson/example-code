<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewYears
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.grpTicketType = New System.Windows.Forms.GroupBox()
        Me.radMilitary = New System.Windows.Forms.RadioButton()
        Me.radAppetizers = New System.Windows.Forms.RadioButton()
        Me.radFullDinner = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblFinalCostText = New System.Windows.Forms.Label()
        Me.lblFinalCostAnswer = New System.Windows.Forms.Label()
        Me.picCelebrate = New System.Windows.Forms.PictureBox()
        Me.grpTicketType.SuspendLayout()
        CType(Me.picCelebrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Adamsky SF", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(431, 17)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(325, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Celebrate New Year's Eve"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(451, 60)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(168, 24)
        Me.lblTickets.TabIndex = 1
        Me.lblTickets.Text = "Number of Tickets:"
        '
        'txtTickets
        '
        Me.txtTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTickets.Location = New System.Drawing.Point(639, 60)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(72, 26)
        Me.txtTickets.TabIndex = 2
        Me.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpTicketType
        '
        Me.grpTicketType.BackColor = System.Drawing.Color.White
        Me.grpTicketType.Controls.Add(Me.radMilitary)
        Me.grpTicketType.Controls.Add(Me.radAppetizers)
        Me.grpTicketType.Controls.Add(Me.radFullDinner)
        Me.grpTicketType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTicketType.Location = New System.Drawing.Point(451, 98)
        Me.grpTicketType.Name = "grpTicketType"
        Me.grpTicketType.Size = New System.Drawing.Size(260, 100)
        Me.grpTicketType.TabIndex = 3
        Me.grpTicketType.TabStop = False
        Me.grpTicketType.Text = "Ticket Type: Select One"
        '
        'radMilitary
        '
        Me.radMilitary.AutoSize = True
        Me.radMilitary.Location = New System.Drawing.Point(7, 68)
        Me.radMilitary.Name = "radMilitary"
        Me.radMilitary.Size = New System.Drawing.Size(150, 20)
        Me.radMilitary.TabIndex = 2
        Me.radMilitary.TabStop = True
        Me.radMilitary.Text = "Military ID Full Dinner"
        Me.radMilitary.UseVisualStyleBackColor = True
        '
        'radAppetizers
        '
        Me.radAppetizers.AutoSize = True
        Me.radAppetizers.Location = New System.Drawing.Point(7, 44)
        Me.radAppetizers.Name = "radAppetizers"
        Me.radAppetizers.Size = New System.Drawing.Size(90, 20)
        Me.radAppetizers.TabIndex = 1
        Me.radAppetizers.TabStop = True
        Me.radAppetizers.Text = "Appetizers"
        Me.radAppetizers.UseVisualStyleBackColor = True
        '
        'radFullDinner
        '
        Me.radFullDinner.AutoSize = True
        Me.radFullDinner.Location = New System.Drawing.Point(7, 20)
        Me.radFullDinner.Name = "radFullDinner"
        Me.radFullDinner.Size = New System.Drawing.Size(161, 20)
        Me.radFullDinner.TabIndex = 0
        Me.radFullDinner.TabStop = True
        Me.radFullDinner.Text = "Full Dinner Celebration"
        Me.radFullDinner.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(451, 248)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(598, 248)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblFinalCostText
        '
        Me.lblFinalCostText.AutoSize = True
        Me.lblFinalCostText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCostText.Location = New System.Drawing.Point(451, 213)
        Me.lblFinalCostText.Name = "lblFinalCostText"
        Me.lblFinalCostText.Size = New System.Drawing.Size(130, 20)
        Me.lblFinalCostText.TabIndex = 6
        Me.lblFinalCostText.Text = "Final Ticket Cost:"
        '
        'lblFinalCostAnswer
        '
        Me.lblFinalCostAnswer.AutoSize = True
        Me.lblFinalCostAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCostAnswer.Location = New System.Drawing.Point(622, 213)
        Me.lblFinalCostAnswer.Name = "lblFinalCostAnswer"
        Me.lblFinalCostAnswer.Size = New System.Drawing.Size(89, 20)
        Me.lblFinalCostAnswer.TabIndex = 7
        Me.lblFinalCostAnswer.Text = "$00,000.00"
        '
        'picCelebrate
        '
        Me.picCelebrate.Image = Global.CIS150NewYears.My.Resources.Resources.NYE
        Me.picCelebrate.Location = New System.Drawing.Point(18, 17)
        Me.picCelebrate.Name = "picCelebrate"
        Me.picCelebrate.Size = New System.Drawing.Size(411, 254)
        Me.picCelebrate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCelebrate.TabIndex = 8
        Me.picCelebrate.TabStop = False
        '
        'frmNewYears
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(775, 289)
        Me.Controls.Add(Me.picCelebrate)
        Me.Controls.Add(Me.lblFinalCostAnswer)
        Me.Controls.Add(Me.lblFinalCostText)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpTicketType)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmNewYears"
        Me.Text = "New Year's Eve Reservation"
        Me.grpTicketType.ResumeLayout(False)
        Me.grpTicketType.PerformLayout()
        CType(Me.picCelebrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblTickets As Label
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents grpTicketType As GroupBox
    Friend WithEvents radMilitary As RadioButton
    Friend WithEvents radAppetizers As RadioButton
    Friend WithEvents radFullDinner As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblFinalCostText As Label
    Friend WithEvents lblFinalCostAnswer As Label
    Friend WithEvents picCelebrate As PictureBox
End Class
