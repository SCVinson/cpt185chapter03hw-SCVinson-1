'Program Name: Fall Marathon
'Developer:    Selena Vinson
'Date:         09/14/2021
'Purpose: The purpose of this program is to display information for the fall marathon.

Public Class frmFallMarathon
    Private Sub btnViewInfo_Click(sender As Object, e As EventArgs) Handles btnViewInfo.Click
        'This code shows all information about the marathon when the user chooses to view information
        lblDate.Visible = True
        lblLocation.Visible = True
        lblTime.Visible = True
        lblMoreInfo.Visible = True

        'This code only allows you to exit the window after the user views the marathon information.
        btnViewInfo.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code closes the window and terminates the program execution.
        Close()
    End Sub
End Class
