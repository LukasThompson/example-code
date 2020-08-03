<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuitarSale
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
        Me.btnClassical = New System.Windows.Forms.Button()
        Me.btnElectric = New System.Windows.Forms.Button()
        Me.btnSteel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkBuyMe = New System.Windows.Forms.CheckBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.picElectric = New System.Windows.Forms.PictureBox()
        Me.picSteelString = New System.Windows.Forms.PictureBox()
        Me.picClassical = New System.Windows.Forms.PictureBox()
        Me.picDefault = New System.Windows.Forms.PictureBox()
        Me.lblClassicInfo = New System.Windows.Forms.Label()
        Me.lblElectricInfo = New System.Windows.Forms.Label()
        Me.lblSteelInfo = New System.Windows.Forms.Label()
        CType(Me.picElectric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSteelString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClassical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClassical
        '
        Me.btnClassical.Location = New System.Drawing.Point(318, 92)
        Me.btnClassical.Name = "btnClassical"
        Me.btnClassical.Size = New System.Drawing.Size(125, 23)
        Me.btnClassical.TabIndex = 1
        Me.btnClassical.Text = "Classical Guitar"
        Me.btnClassical.UseVisualStyleBackColor = True
        '
        'btnElectric
        '
        Me.btnElectric.Location = New System.Drawing.Point(318, 218)
        Me.btnElectric.Name = "btnElectric"
        Me.btnElectric.Size = New System.Drawing.Size(125, 23)
        Me.btnElectric.TabIndex = 2
        Me.btnElectric.Text = "Electric Guitar"
        Me.btnElectric.UseVisualStyleBackColor = True
        '
        'btnSteel
        '
        Me.btnSteel.Location = New System.Drawing.Point(318, 337)
        Me.btnSteel.Name = "btnSteel"
        Me.btnSteel.Size = New System.Drawing.Size(125, 23)
        Me.btnSteel.TabIndex = 3
        Me.btnSteel.Text = "Steel String Guitar"
        Me.btnSteel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(448, 439)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkBuyMe
        '
        Me.chkBuyMe.AutoSize = True
        Me.chkBuyMe.Enabled = False
        Me.chkBuyMe.Location = New System.Drawing.Point(110, 468)
        Me.chkBuyMe.Name = "chkBuyMe"
        Me.chkBuyMe.Size = New System.Drawing.Size(104, 17)
        Me.chkBuyMe.TabIndex = 5
        Me.chkBuyMe.Text = "Buy This Guitar?"
        Me.chkBuyMe.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.Location = New System.Drawing.Point(318, 439)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 6
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'lblSale
        '
        Me.lblSale.AutoSize = True
        Me.lblSale.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSale.Location = New System.Drawing.Point(150, 34)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(234, 23)
        Me.lblSale.TabIndex = 8
        Me.lblSale.Text = "This Weeks Sale Items!"
        '
        'picElectric
        '
        Me.picElectric.Image = Global.CIS150GuitarStore.My.Resources.Resources.Electric
        Me.picElectric.Location = New System.Drawing.Point(50, 92)
        Me.picElectric.Name = "picElectric"
        Me.picElectric.Size = New System.Drawing.Size(236, 370)
        Me.picElectric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picElectric.TabIndex = 11
        Me.picElectric.TabStop = False
        Me.picElectric.Visible = False
        '
        'picSteelString
        '
        Me.picSteelString.Image = Global.CIS150GuitarStore.My.Resources.Resources.Steel
        Me.picSteelString.Location = New System.Drawing.Point(50, 92)
        Me.picSteelString.Name = "picSteelString"
        Me.picSteelString.Size = New System.Drawing.Size(236, 370)
        Me.picSteelString.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSteelString.TabIndex = 10
        Me.picSteelString.TabStop = False
        Me.picSteelString.Visible = False
        '
        'picClassical
        '
        Me.picClassical.Image = Global.CIS150GuitarStore.My.Resources.Resources.Classical
        Me.picClassical.Location = New System.Drawing.Point(50, 92)
        Me.picClassical.Name = "picClassical"
        Me.picClassical.Size = New System.Drawing.Size(236, 370)
        Me.picClassical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClassical.TabIndex = 9
        Me.picClassical.TabStop = False
        Me.picClassical.Visible = False
        '
        'picDefault
        '
        Me.picDefault.Image = Global.CIS150GuitarStore.My.Resources.Resources.guitarcircle
        Me.picDefault.Location = New System.Drawing.Point(50, 92)
        Me.picDefault.Name = "picDefault"
        Me.picDefault.Size = New System.Drawing.Size(236, 370)
        Me.picDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDefault.TabIndex = 0
        Me.picDefault.TabStop = False
        '
        'lblClassicInfo
        '
        Me.lblClassicInfo.AutoSize = True
        Me.lblClassicInfo.Location = New System.Drawing.Point(323, 118)
        Me.lblClassicInfo.Name = "lblClassicInfo"
        Me.lblClassicInfo.Size = New System.Drawing.Size(83, 52)
        Me.lblClassicInfo.TabIndex = 12
        Me.lblClassicInfo.Text = "Brand: Ibanez" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MSRP: $399.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale: $299.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save $100!!!!"
        Me.lblClassicInfo.Visible = False
        '
        'lblElectricInfo
        '
        Me.lblElectricInfo.AutoSize = True
        Me.lblElectricInfo.Location = New System.Drawing.Point(323, 244)
        Me.lblElectricInfo.Name = "lblElectricInfo"
        Me.lblElectricInfo.Size = New System.Drawing.Size(83, 52)
        Me.lblElectricInfo.TabIndex = 13
        Me.lblElectricInfo.Text = "Brand: Dean" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MSRP: $699.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale: $549.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save $150!!!!"
        Me.lblElectricInfo.Visible = False
        '
        'lblSteelInfo
        '
        Me.lblSteelInfo.AutoSize = True
        Me.lblSteelInfo.Location = New System.Drawing.Point(323, 363)
        Me.lblSteelInfo.Name = "lblSteelInfo"
        Me.lblSteelInfo.Size = New System.Drawing.Size(83, 52)
        Me.lblSteelInfo.TabIndex = 14
        Me.lblSteelInfo.Text = "Brand: Martin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MSRP: $799.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale: $649.99" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save $50!!!!!"
        Me.lblSteelInfo.Visible = False
        '
        'frmGuitarSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 492)
        Me.Controls.Add(Me.lblSteelInfo)
        Me.Controls.Add(Me.lblElectricInfo)
        Me.Controls.Add(Me.lblClassicInfo)
        Me.Controls.Add(Me.picElectric)
        Me.Controls.Add(Me.picSteelString)
        Me.Controls.Add(Me.picClassical)
        Me.Controls.Add(Me.lblSale)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.chkBuyMe)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSteel)
        Me.Controls.Add(Me.btnElectric)
        Me.Controls.Add(Me.btnClassical)
        Me.Controls.Add(Me.picDefault)
        Me.Name = "frmGuitarSale"
        Me.Text = "Guitar Sale"
        CType(Me.picElectric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSteelString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClassical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDefault As PictureBox
    Friend WithEvents btnClassical As Button
    Friend WithEvents btnElectric As Button
    Friend WithEvents btnSteel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkBuyMe As CheckBox
    Friend WithEvents btnPurchase As Button
    Friend WithEvents lblSale As Label
    Friend WithEvents picClassical As PictureBox
    Friend WithEvents picSteelString As PictureBox
    Friend WithEvents picElectric As PictureBox
    Friend WithEvents lblClassicInfo As Label
    Friend WithEvents lblElectricInfo As Label
    Friend WithEvents lblSteelInfo As Label
End Class
