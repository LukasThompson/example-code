<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculator))
        Me.txtPPH = New System.Windows.Forms.TextBox()
        Me.txtRaise = New System.Windows.Forms.TextBox()
        Me.lblPPH = New System.Windows.Forms.Label()
        Me.lblRaise = New System.Windows.Forms.Label()
        Me.lblEstimatedPay = New System.Windows.Forms.Label()
        Me.lstPayPerDecade = New System.Windows.Forms.ListBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPPH
        '
        Me.txtPPH.Location = New System.Drawing.Point(120, 83)
        Me.txtPPH.Name = "txtPPH"
        Me.txtPPH.Size = New System.Drawing.Size(100, 20)
        Me.txtPPH.TabIndex = 0
        '
        'txtRaise
        '
        Me.txtRaise.Location = New System.Drawing.Point(120, 128)
        Me.txtRaise.Name = "txtRaise"
        Me.txtRaise.Size = New System.Drawing.Size(100, 20)
        Me.txtRaise.TabIndex = 1
        '
        'lblPPH
        '
        Me.lblPPH.AutoSize = True
        Me.lblPPH.Location = New System.Drawing.Point(19, 86)
        Me.lblPPH.Name = "lblPPH"
        Me.lblPPH.Size = New System.Drawing.Size(73, 13)
        Me.lblPPH.TabIndex = 3
        Me.lblPPH.Text = "Pay Per Hour:"
        '
        'lblRaise
        '
        Me.lblRaise.AutoSize = True
        Me.lblRaise.Location = New System.Drawing.Point(19, 135)
        Me.lblRaise.Name = "lblRaise"
        Me.lblRaise.Size = New System.Drawing.Size(95, 13)
        Me.lblRaise.TabIndex = 4
        Me.lblRaise.Text = "Raise % Per Year: "
        '
        'lblEstimatedPay
        '
        Me.lblEstimatedPay.AutoSize = True
        Me.lblEstimatedPay.Location = New System.Drawing.Point(270, 70)
        Me.lblEstimatedPay.Name = "lblEstimatedPay"
        Me.lblEstimatedPay.Size = New System.Drawing.Size(77, 13)
        Me.lblEstimatedPay.TabIndex = 5
        Me.lblEstimatedPay.Text = "Estimated Pay:"
        '
        'lstPayPerDecade
        '
        Me.lstPayPerDecade.FormattingEnabled = True
        Me.lstPayPerDecade.Location = New System.Drawing.Point(248, 86)
        Me.lstPayPerDecade.Name = "lstPayPerDecade"
        Me.lstPayPerDecade.Size = New System.Drawing.Size(120, 173)
        Me.lstPayPerDecade.TabIndex = 6
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(16, 23)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(338, 29)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Next Decade Pay Calculator"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(22, 167)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(198, 40)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(22, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(198, 40)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(384, 282)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lstPayPerDecade)
        Me.Controls.Add(Me.lblEstimatedPay)
        Me.Controls.Add(Me.lblRaise)
        Me.Controls.Add(Me.lblPPH)
        Me.Controls.Add(Me.txtRaise)
        Me.Controls.Add(Me.txtPPH)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCalculator"
        Me.Text = "Decade Pay Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPPH As TextBox
    Friend WithEvents txtRaise As TextBox
    Friend WithEvents lblPPH As Label
    Friend WithEvents lblRaise As Label
    Friend WithEvents lblEstimatedPay As Label
    Friend WithEvents lstPayPerDecade As ListBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As Button
End Class
