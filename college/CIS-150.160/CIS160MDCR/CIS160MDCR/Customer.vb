Option Strict On
Public Class Customer
    Private _strFirstName As String = ""
    Private _strLastName As String = ""
    Private _intNumberOfDays As Integer = 0
    Private _intCorporateID As Integer = 0
    Private Const _cintDailyCost As Integer = 350

    Public Sub New(strFirstName As String, strLastName As String, intNumberOfDays As Integer, intCorporateID As Integer)
        _strFirstName = strFirstName
        _strLastName = strLastName
        _intNumberOfDays = intNumberOfDays
        _intCorporateID = intCorporateID
    End Sub

    Public Function CalculateCost() As Integer
        Dim intToReturn As Integer = _cintDailyCost
        intToReturn *= _intNumberOfDays
        Return intToReturn
    End Function



End Class
