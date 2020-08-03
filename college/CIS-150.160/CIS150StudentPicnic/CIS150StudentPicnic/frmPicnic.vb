Public Class frmPicnic
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        lblLocation.Visible = True
        lblDate.Visible = True
        btnInfo.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
