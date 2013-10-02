Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim a, b, c, a1, b1, c1 As Double


        a = CDbl(txtSideOne.Text)
        b = CDbl(txtSideTwo.Text)
        a1 = CDbl(a ^ 2)
        b1 = CDbl(b ^ 2)
        c1 = CDbl((a1 + b1) ^ 0.5)

        txtHyp.Text = CStr(c1)

    End Sub

End Class
