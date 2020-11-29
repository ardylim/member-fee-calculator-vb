Public Class Form1

    Dim baseFee As Double
    Dim discount As Double
    Dim totalfee As Double
    Dim intmonths As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Clear the form, reset the buttons and check boxes.
        adult.Checked = True
        yoga.Checked = True
        karate.Checked = False
        personalTrainer.Checked = False
        month.Clear()
        monthlyfee.Text = "...."
        result.Text = "...."
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles personalTrainer.CheckedChanged

    End Sub

    Private Sub month_TextChanged(sender As Object, e As EventArgs) Handles month.TextChanged

        If Not Integer.TryParse(month.Text, intmonths) Then
            MessageBox.Show("please... input a valid integer (1-24) :)",
            "Error")
            Return
        End If
        ' Check the month range: must be 1-24.
        If (intmonths < 1) Or (intmonths > 24) Then
            MessageBox.Show("please... input a valid integer (1-24) :)",
            "Error")
            Return
        End If

        ' If we reach this point, we assume the input data is valid.
        ' Calculate the base monthly fee.
        If adult.Checked = True Then
            baseFee = 40
        ElseIf child.Checked = True Then
            baseFee = 20
        ElseIf student.Checked = True Then
            baseFee = 25
        ElseIf senior.Checked = True Then
            baseFee = 30
        End If

        ' Look for additional services.
        If yoga.Checked = True Then
            baseFee += 10
        End If
        If karate.Checked = True Then
            baseFee += 30
        End If
        If personalTrainer.Checked = True Then
            baseFee += 50
        End If

        ' Determine the discount, based on membership months.
        Select Case intmonths
            Case Is <= 3
                discount = 0
            Case 4 To 6
                discount = baseFee * 0.05
            Case 7 To 9
                discount = baseFee * 0.08
            Case Is >= 10
                discount = baseFee * 0.1
        End Select




    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles yoga.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Adjust for discounts, calculate total fee.
        baseFee -= discount
        totalfee = baseFee * intmonths
        ' Display the fees.
        monthlyfee.Text = baseFee
        result.Text = totalfee

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles result.Click

    End Sub

    Private Sub type_Enter(sender As Object, e As EventArgs) Handles type.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub monthlyfee_Click(sender As Object, e As EventArgs) Handles monthlyfee.Click

    End Sub
End Class
