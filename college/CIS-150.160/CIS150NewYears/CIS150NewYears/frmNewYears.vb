Public Class frmNewYears
    'Declare our Global Constants
    Const _cdecAppetizers As Decimal = 75D
    Const _cdecFullDinner As Decimal = 125D
    Const _cdecMilitary As Decimal = 125D
    Const _cdecDiscount As Decimal = 0.45D


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Create variables
        Dim decCostOfTickets As Decimal
        Dim decMilDiscount As Decimal

        'Run through IF block to determine which radio button Is being used
        If radAppetizers.Checked Then
            'If Appetizers was picked execute
            decCostOfTickets = _cdecAppetizers
            Debug.Print("We picked a button!")
        ElseIf radFullDinner.Checked Then
            'If Full Dinner was picked execute
            decCostOfTickets = _cdecFullDinner
            Debug.Print("We picked a button!")
        ElseIf radMilitary.Checked Then
            'If Military was picked we must get our discount
            Dim decMilPrice As Decimal
            decMilDiscount = _cdecMilitary * _cdecDiscount
            decMilPrice = _cdecMilitary - decMilDiscount
            decCostOfTickets = decMilPrice
            Debug.Print("We picked a button!")
        End If
        'We have determined which radio button was picked


        'Grab Number from the user using field txtTickets
        Dim strNumberOfTickets As String = txtTickets.Text
        Debug.Print("We got the number of tickets from the user")
        'Test the user's input from the txtTickets field
        If IsNumeric(strNumberOfTickets) Then
            Debug.Print("The user entered a number")
            Dim intNumberOfTickets As Integer = Convert.ToInt32(strNumberOfTickets)
            'Create variable to hold the answer for our formula
            Dim decTotalCost As Decimal
            Debug.Print("Conversions made, prepare the calculations my boy!")
            'Check to see if the number is greater than 0
            If intNumberOfTickets >= 0 Then
                'User entered a number that is greater than 0, check to see if user is military
                If radMilitary.Checked Then
                    'If user is also military, and has entered a number greater than 0
                    decTotalCost = decCostOfTickets * intNumberOfTickets
                    'Display discount
                    Dim decDiscountTotal
                    decDiscountTotal = intNumberOfTickets * decMilDiscount
                    'I tried the ToString and the ('C') here but it was giving me an error, was going to ask you about it during class but got stuck in Michigan for a couple days
                    'So didn't have the time to update everything like I wanted to, am still running late and trying to upload everything before class
                    MsgBox("You recieved a discount of $" & decDiscountTotal, , "Military Discount")
                    'Display answer
                    lblFinalCostAnswer.Text = decTotalCost.ToString("C")
                Else
                    'User is not military and entered a number that is greater than zero
                    decTotalCost = decCostOfTickets * intNumberOfTickets
                    'Display discount
                    MsgBox("You did not earn a discount at this time.",, "No Discounts")
                    'Display answer
                    lblFinalCostAnswer.Text = decTotalCost.ToString("C")
                End If
            Else
                'User entered a negative number
                MsgBox("Please enter a positive number into the box.",, "Negative Numbers Are Bad")
            End If

        Else
            'User entered a non-numeric key
            MsgBox("Please enter a number into the box.",, "No Numbers Are Bad")
        End If

    End Sub
End Class
