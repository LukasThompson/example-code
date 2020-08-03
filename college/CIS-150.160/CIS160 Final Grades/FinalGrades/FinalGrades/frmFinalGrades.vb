' Program Name: Grade Calcluator
' Author: Lukas Thompson
' Date: 10-17-2016
' Purpose: This windows application is designed to take input from the user. It then sums the user input, afterwards it figures the average minus the two worst scores.
' The program then displays the average to the user and saves the list of scores in a text file. 


Option Strict On
' With this option enabled, you can't accidentally convert one data type to another that is less precise (e.g. from an Integer to a Byte). -StackOverflow Definition

Public Class frmFinalGrades

    ' Declare our variables
    Dim decScore As Decimal
    Dim decAverage As Decimal = 0D
    Dim decSum As Decimal = 0D
    Const cintMaxSizeToEnter As Integer = 13
    Dim decGrades(12) As Decimal
    Const cstrFileLocation As String = "G:\StudentsGrades.txt"
    ' Location should be changed based on file system



    Private Sub frmFinalGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        ' Run our procedures in the proper order
        GatherInput()
        ' First we gather our information
        ArraySort()
        ' Next we sort our array from lowest to greatest then reverse the order
        Averages()
        ' Now we do all of our calculations
        DisplayResults()
        ' Display the result to the user
        SaveFile()
        ' Finally save a text file of the scores
    End Sub


    Private Sub GatherInput()
        ' Create a sub routine to gather input from our user
        Dim intCounter As Integer = 0
        Do
            ' Create an input box for the user
            Dim strInput As String = InputBox("Please enter 13 grades:")
            Try
                Dim decInput As Decimal = Convert.ToDecimal(strInput)
                If decInput > 0 And decInput <= 100 Then
                    ' The user has entered a number that fits our scope
                    decGrades(intCounter) = decInput
                    ReDim Preserve decGrades(12)
                    intCounter += 1
                Else
                    ' The user did not enter a valid number
                    MsgBox("Please enter a number from 0 to 100 only",, "Error")
                End If
            Catch ex As Exception
                ' The user did not enter a number
                MsgBox("Please enter a valid number into the input box",, "Error")
            End Try
        Loop Until intCounter >= cintMaxSizeToEnter
    End Sub

    Private Sub ArraySort()
        ' Sort the array
        Array.Sort(decGrades)
        Array.Reverse(decGrades)
    End Sub

    Private Sub Averages()
        ' Find the average minus the two lowest scores
        ReDim Preserve decGrades(10)
        ' Get rid of the two lowest scores
        Dim intDivisor As Integer = decGrades.Length
        ' Set our divisor unit 
        For Each decScore In decGrades
            decSum += decScore
        Next
        decAverage = decSum / intDivisor
        ' Find our Average
    End Sub

    Private Sub DisplayResults()
        lblResults.Text = "The final average is: " & decAverage.ToString("N2")
        ' Sets text property
        pnlResults.Visible = True
        ' Activates our panel
    End Sub

    Private Sub SaveFile()
        Dim objWrite As New IO.StreamWriter(cstrFileLocation)
        ' Create reader object
        For Each decScore In decGrades
            ' Find each score in our array
            objWrite.WriteLine(decScore.ToString)
            ' Write our scores to a text file
        Next
        objWrite.Close()
        ' Close our file, we are finished with it
    End Sub
End Class
