Public Class frmWorkoutCalc
    'Declare Global Constants
    Const _cintDaysPerYear As Integer = 365
    Const _cintDaysPerMonth As Integer = 30
    Const _cdecDaysPerWeek As Decimal = 7.5D
    Const _cintHoursWorkedOutPerWeek As Integer = 3
    Const _cintHoursWorkedOutPerMonth As Integer = 12


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Grab numbers from DOB + Today's Date
        Dim strDOBMonth As String = txtDOBMonth.Text
        Dim strDOBDay As String = txtDOBDay.Text
        Dim strDOBYear As String = txtDOBYear.Text

        Dim strDateMonth As String = txtDateMonth.Text
        Dim strDateDay As String = txtDateDay.Text
        Dim strDateYear As String = txtDateYear.Text

        'Grab User's Name
        Dim strFirstName As String = txtFirstName.Text

        'Convert textboxes into Integers
        Dim intDOBMonth As Integer = Convert.ToInt32(strDOBMonth)
        Dim intDOBDay As Integer = Convert.ToInt32(strDOBDay)
        Dim intDOBYear As Integer = Convert.ToInt32(strDOBYear)

        Dim intDateMonth As Integer = Convert.ToInt32(strDateMonth)
        Dim intDateDay As Integer = Convert.ToInt32(strDateDay)
        Dim intDateYear As Integer = Convert.ToInt32(strDateYear)

        'Calculate time worked out based on provided numbers
        Dim intMonths As Integer
        Dim intDays As Integer
        Dim intYears As Integer

        intMonths = intDateMonth - intDOBMonth
        intDays = intDateDay - intDOBDay
        intYears = intDateYear - intDOBYear

        Dim intMonthsAsDays
        Dim intYearsAsDays
        Dim intDaysAsDays

        intMonthsAsDays = intMonths * _cintDaysPerMonth
        intYearsAsDays = intYears * _cintDaysPerYear
        intDaysAsDays = intDays

        Dim intTotalDays

        intTotalDays = intMonthsAsDays + intYearsAsDays + intDaysAsDays

        Dim intHoursWorkedOut

        intHoursWorkedOut = (intTotalDays / _cintDaysPerMonth) * 12

        'Output user's name and time worked out on the screen
        lblOutput.Text = "Hello " & strFirstName & "," & vbNewLine & " you have worked out:" & vbNewLine & intHoursWorkedOut & vbNewLine & " hours in your lifetime!"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset textboxes “”
        txtDOBMonth.Text = ""
        txtDOBDay.Text = ""
        txtDOBYear.Text = ""
        txtDateMonth.Text = ""
        txtDateDay.Text = ""
        txtDateYear.Text = ""
        txtFirstName.Text = ""

        'Reset labels to “”
        lblOutput.Text = ""

        'Set focus to appropriate text box 
        txtFirstName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub frmWorkoutCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset textboxes “”
        txtDOBMonth.Text = ""
        txtDOBDay.Text = ""
        txtDOBYear.Text = ""
        txtDateMonth.Text = ""
        txtDateDay.Text = ""
        txtDateYear.Text = ""
        txtFirstName.Text = ""

        'Reset labels to “”
        lblOutput.Text = ""

        'Set focus to appropriate text box 
        txtFirstName.Focus()
    End Sub
End Class
