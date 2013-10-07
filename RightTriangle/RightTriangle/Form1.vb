Option Strict On
Public Class Form1



    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim a, b, z As Double


        a = CDbl(txtSideOne.Text)
        b = CDbl(txtSideTwo.Text)
        z = Hypotenuse(a, b)
        txtHyp.Text = CStr(z)
    End Sub

    Function Hypotenuse(ByVal a As Double, ByVal b As Double) As Double
        Dim C As Double
        C = Math.Sqrt(a ^ 2 + b ^ 2)

        Return C
    End Function
End Class
