Public Class frmComic
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperhero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D
        ' Make sure user enters a numeric value
        If IsNumeric(txtGroup.Text) Then
            intGroup = Convert.ToInt32(txtGroup.Text)
            If intGroup > 0 And intGroup < 20 Then
                If radSuperhero.Checked Then
                    decRegistration = decSuperhero
                ElseIf radAutographs.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If
                decTotalCost = (intGroup * decRegistration)
                lblCostTicket.Text = decTotalCost.ToString("C")
            Else
                'Error message
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            'Error message
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Entry Error")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCostTicket.Text = ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroup.Clear()
        lblCostTicket.Text = ""
        radAutographs.Checked = False
        radConvention.Checked = False
        radSuperhero.Checked = True
        txtGroup.Focus()
    End Sub
End Class
