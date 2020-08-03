Public Class frmMobileDev
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If radAndroid.Checked Then
            ' The User has selected to attend android Pre-Conference
            Try
                If mtbCorporateID.MaskFull Then
                    If System.Text.RegularExpressions.Regex.Match(txtFirstName.Text, "^[a-z]*$", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Success Then
                        ' First name is only letters
                        If System.Text.RegularExpressions.Regex.Match(txtLastName.Text, "^[a-z]*$", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Success Then
                            ' Last name is only letters                       
                            Dim intNumOfDays As Integer = Convert.ToInt32(txtNumOfDays.Text)
                            Select Case intNumOfDays
                                Case 1 To 4
                                    ' Everything is good
                                    Dim cusPreConferenceCustomer As New PreConferenceCustomer(txtFirstName.Text, txtLastName.Text, Convert.ToInt32(txtNumOfDays.Text), Convert.ToInt32(mtbCorporateID.Text))
                                    ' Create a new pre-conference customer
                                    Dim intTotalCost As Integer = cusPreConferenceCustomer.CalculateCostPlusConference()
                                    lblAnswer.Text = "The total conference costs will be: " & intTotalCost.ToString("C")
                                Case Else
                                    ' Number of days must be 1-4
                                    MsgBox("Number of days must be 1-4",, "Error")
                            End Select
                        Else
                            MsgBox("Check Last Name Field",, "Last Name Incorrect")
                        End If
                    Else
                        MsgBox("Check First Name Field",, "First Name Incorrect")
                    End If
                Else
                    MsgBox("Corporate ID must be 5 numbers",, "Corporate ID Not Valid")
                End If
            Catch ex As Exception
                MsgBox("Please ensure all data is valid before proceeding",, "Error")
            End Try
        ElseIf radWindows.Checked Then
            ' The User selected windows conference 
            Try
                If mtbCorporateID.MaskFull Then
                    If System.Text.RegularExpressions.Regex.Match(txtFirstName.Text, "^[a-z]*$", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Success Then
                        ' First name is only letters
                        If System.Text.RegularExpressions.Regex.Match(txtLastName.Text, "^[a-z]*$", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Success Then
                            ' Last name is only letters                       
                            Dim intNumOfDays As Integer = Convert.ToInt32(txtNumOfDays.Text)
                            Select Case intNumOfDays
                                Case 1 To 4
                                    ' Everything is good
                                    Dim cusPreConferenceCustomer As New PreConferenceCustomer(txtFirstName.Text, txtLastName.Text, Convert.ToInt32(txtNumOfDays.Text), Convert.ToInt32(mtbCorporateID.Text))
                                    ' Create a new pre-conference customer
                                    Dim intTotalCost As Integer = cusPreConferenceCustomer.CalculateCostPlusConference()
                                    lblAnswer.Text = "The total conference costs will be: " & intTotalCost.ToString("C")
                                Case Else
                                    ' Number of days must be 1-4
                                    MsgBox("Number of days must be 1-4",, "Error")
                            End Select
                        Else
                            MsgBox("Check Last Name Field",, "Last Name Incorrect")
                        End If
                    Else
                        MsgBox("Check First Name Field",, "First Name Incorrect")
                    End If
                Else
                    MsgBox("Corporate ID must be 5 numbers",, "Corporate ID Not Valid")
                End If
            Catch ex As Exception
                MsgBox("Please ensure all data is valid before proceeding",, "Error")
            End Try
        Else
            ' The User does not wish to attend a pre-conference
            Try
                If System.Text.RegularExpressions.Regex.Match(txtFirstName.Text, "^[a-z]*$", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Success Then
                    ' First name is only letters
                    If System.Text.RegularExpressions.Regex.Match(txtLastName.Text, "^[a-z]*$", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Success Then
                        ' Last name is only letters                       
                        Dim intNumOfDays As Integer = Convert.ToInt32(txtNumOfDays.Text)
                        Select Case intNumOfDays
                            Case 1 To 4
                                ' Everything is good
                                Dim cusCustomer As New Customer(txtFirstName.Text, txtLastName.Text, Convert.ToInt32(txtNumOfDays.Text), Convert.ToInt32(mtbCorporateID.Text))
                                ' Create a new customer
                                Dim intTotalCost As Integer = cusCustomer.CalculateCost()
                                lblAnswer.Text = "The total conference costs will be: " & intTotalCost.ToString("C")
                            Case Else
                                ' Number of days must be 1-4
                                MsgBox("Number of days must be 1-4",, "Error")
                        End Select
                    Else
                        MsgBox("Check Last Name Field",, "Last Name Incorrect")
                    End If
                Else
                    MsgBox("Check First Name Field",, "First Name Incorrect")
                End If
            Catch ex As Exception
                MsgBox("Please ensure all data is valid before proceeding",, "Error")
            End Try
        End If
    End Sub

    Private Sub Clear()
        mtbCorporateID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtNumOfDays.Text = ""
        radAndroid.Checked = False
        radWindows.Checked = False
        radDatabases.Checked = False
        radDesign.Checked = False
        radSecurity.Checked = False
        mtbCorporateID.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub
End Class


