Option Strict On
Option Explicit On

'Cher Hill
'Exercise 4 - Ch3 MPG
Public Class frmMPG

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim IntGallons As Integer
        Dim IntMilesDriven As Integer
        Dim dblMPG As Double
        IntGallons = CInt(txtGasTank.Text)
        IntMilesDriven = CInt(txtMilesDrive.Text)
        dblMPG = IntMilesDriven / IntGallons
        lblMPGTotal.Text = "Miles per gallon are " & CStr(dblMPG) & " miles per gallon"

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExitCancel.Click
        Me.Close()


    End Sub

End Class

