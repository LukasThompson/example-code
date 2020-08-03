Public Class frmCalculator
    'Create our Global Constants
    Const _cdecHoursWorked As Decimal = 40D
    Const _cintWeeksWork As Integer = 52
    Const _cintRepititions As Integer = 10


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblRaise.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'The user clicked the calculate button

        'Get our user's input
        Dim strPPH As String = txtPPH.Text
        Dim strRaise As String = txtRaise.Text

        'Test the user's input
        If IsNumeric(strPPH) And IsNumeric(strRaise) Then
            'The user entered a number

            'Create our variables
            Dim decThisYearsPay As Decimal = 0D
            Dim decPPH As Decimal = Convert.ToDecimal(strPPH)
            Dim decRaise As Decimal = Convert.ToDecimal(strRaise)
            Dim decPayIncrease As Decimal = 0D
            Dim intCount As Integer = 0

            If decPPH >= 0 And decRaise > 0 And decRaise <= 1 Then
                'Positive numbers were entered
                decThisYearsPay = (decPPH * _cdecHoursWorked) * _cintWeeksWork
                Do
                    'Add this years pay to our list box
                    lstPayPerDecade.Items.Add(decThisYearsPay.ToString("C"))
                    'Find out next years pay
                    decPayIncrease = decThisYearsPay * decRaise
                    'Set this years pay
                    decThisYearsPay = decThisYearsPay + decPayIncrease
                    'Add 1 to the counter
                    intCount += 1
                Loop Until intCount >= _cintRepititions
            Else
                'Negative numbers were entered
                MsgBox("Please ensure you are using positive numbers and enter a raise between 0.1 and 1.0",, "Correct Data")
            End If

        Else
            'The user did not enter a number
            MsgBox("Please enter only numbers in the input boxes",, "Numbers Only")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub Clear()
        txtPPH.Text = ""
        txtRaise.Text = ""
        lstPayPerDecade.Items.Clear()
        txtPPH.Focus()
    End Sub
End Class
