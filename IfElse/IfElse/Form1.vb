Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double

        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("error:please type a number")
            Return
        End If
        If num1 < 0 Or num2 < 0 Then
            MessageBox.Show("Error:PLEASE TYPE A POSITIVE NUMBER")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If (num1 > num2) Then
            txtResult.Text = "the larger Number is" & num1

        ElseIf (num1 < num2) Then
            txtResult.Text = "the larger Number is" & num2


        Else
            txtResult.Text = "they are equal"
        End If


    End Sub
End Class
