Public Class _Default
    Inherits Page

    ' Declare our variables
    Dim strName As String = ""
    Dim intCoffeeSelection As Integer = -1
    Dim intCoffeeSize As Integer = -1
    Dim decPriceOfCoffee As Decimal = 0D
    Dim decTotalPrice As Decimal = 0D
    Dim strCoffeeSelection As String = ""
    Dim decAdditionsCost As Decimal = 0D
    ' The strings below could be declared as constants if needed
    Dim strThankYou As String = "Thanks for your order a "
    Dim strRightOut As String = " will be right out for you!"
    Dim strYourTotal As String = "The total cost with additional items comes to: "
    Dim strGoodbye As String = "Have a great day, "



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        ' We need to gather our information, Name, Coffee Flavor, Coffee Size, Any Extra Toppings
        ' We then need to add any additional charges
        ' Lastly, we must calculate the total of all items
        GatherInfo()
        ComputeAdditions()
        ComputeAndDisplay()
    End Sub

    Private Sub GatherInfo()
        Try
            strName = Convert.ToString(txtName.Text)
            ' We got our name!
            intCoffeeSelection = ddlCoffeeSelection.SelectedIndex
            ' We know what our coffee selection is!
            strCoffeeSelection = ddlCoffeeSelection.SelectedItem.ToString
            ' We have set our coffee name, we will need this later for display purposes
            intCoffeeSize = rblCoffeeSize.SelectedIndex
            ' We know what size our coffee is
            Select Case intCoffeeSize
                ' We are using a select case because our prices are written in the HTML coding
                Case 0
                    decPriceOfCoffee = 2.59D
                Case 1
                    decPriceOfCoffee = 3.09D
                Case 2
                    decPriceOfCoffee = 3.59D
            End Select
            ' We have set the base price of our cup of coffee, we will need this later to make calculations
        Catch ex As Exception
            ' Something went wrong!
            MsgBox("OH NO! We broke it! Call help!",, "Critical Error")
        End Try
    End Sub

    Protected Sub cblAdditions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblAdditions.SelectedIndexChanged

    End Sub

    Private Sub ComputeAdditions()
        Try
            For Each itemSelected In cblAdditions.Items
                ' Find items selected in our checkboxlist
                If itemSelected.Selected Then
                    decAdditionsCost += 0.49D
                    ' If items are seleceted we add $0.49 for each selected item
                Else
                    decAdditionsCost += 0D
                    ' If it isn't selected we do not add anything to the price
                End If
            Next
        Catch ex As Exception
            ' This should not happen
            MsgBox("Something went wrong!",, "Critical Error!")
        End Try
    End Sub

    Private Sub ComputeAndDisplay()
        decTotalPrice = decPriceOfCoffee + decAdditionsCost
        lblResults.Text = strThankYou & rblCoffeeSize.SelectedItem.ToString & " " & strCoffeeSelection & " " & strRightOut & vbCrLf &
            strYourTotal & " " & decTotalPrice.ToString("C") & " " & strGoodbye & strName & "!"
        ' MsgBox(decTotalPrice.ToString("C"))
    End Sub


End Class