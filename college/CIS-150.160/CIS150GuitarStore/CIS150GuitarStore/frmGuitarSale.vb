'AUTHOR: Lukas Thompson
'DATE: 9/5/16
'PURPOSE: Display sales for guitar shop



Public Class frmGuitarSale
    Private Sub btnClassical_Click(sender As Object, e As EventArgs) Handles btnClassical.Click
        'Here we set which images will be visible to the user
        picDefault.Visible = False
        picClassical.Visible = True
        picElectric.Visible = False
        picSteelString.Visible = False

        'Here we set what information will be displayed to the user
        lblClassicInfo.Visible = True
        lblElectricInfo.Visible = False
        lblSteelInfo.Visible = False

        'Here we enable the check box
        chkBuyMe.Enabled = True
    End Sub

    Private Sub btnElectric_Click(sender As Object, e As EventArgs) Handles btnElectric.Click
        'Here we set which images will be visible to the user
        picDefault.Visible = False
        picClassical.Visible = False
        picElectric.Visible = True
        picSteelString.Visible = False

        'Here we set what information will be displayed to the user
        lblClassicInfo.Visible = False
        lblElectricInfo.Visible = True
        lblSteelInfo.Visible = False

        'Here we enable the check box
        chkBuyMe.Enabled = True
    End Sub

    Private Sub btnSteel_Click(sender As Object, e As EventArgs) Handles btnSteel.Click
        'Here we set which images will be visible to the user
        picDefault.Visible = False
        picClassical.Visible = False
        picElectric.Visible = False
        picSteelString.Visible = True

        'Here we set what information will be displayed to the user
        lblClassicInfo.Visible = False
        lblElectricInfo.Visible = False
        lblSteelInfo.Visible = True

        'Here we enable the check box
        chkBuyMe.Enabled = True
    End Sub

    Private Sub chkBuyMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuyMe.CheckedChanged
        'Here we enable the purchase button when the check box is active and disable it when the check box is not active
        If chkBuyMe.Checked = True Then btnPurchase.Enabled = True Else btnPurchase.Enabled = False
        'Here we disable guitar selection buttons when the check box is active and enable them when the box is not active
        If chkBuyMe.Checked = True Then btnClassical.Enabled = False Else btnClassical.Enabled = True
        If chkBuyMe.Checked = True Then btnElectric.Enabled = False Else btnElectric.Enabled = True
        If chkBuyMe.Checked = True Then btnSteel.Enabled = False Else btnSteel.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        MsgBox("Thank you for your purchase. Enjoy your new guitar!")
        btnPurchase.Enabled = False
        chkBuyMe.Enabled = False
    End Sub
End Class
