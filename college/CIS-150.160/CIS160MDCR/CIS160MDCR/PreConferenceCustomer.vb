Option Strict On
Public Class PreConferenceCustomer
    Inherits Customer

    Private Const _cintPreConferenceCost As Integer = 675

    Public Sub New(strFirstName As String, strLastName As String, intNumberOfDays As Integer, intCorporateID As Integer)
        MyBase.New(strFirstName, strLastName, intNumberOfDays, intCorporateID)
    End Sub

    Public Function CalculateCostPlusConference() As Integer
        Dim intToReturn As Integer = MyBase.CalculateCost()
        intToReturn += _cintPreConferenceCost
        Return intToReturn
    End Function

End Class
