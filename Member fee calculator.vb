Public Class Form1

    Dim monthNumber As Integer
    Dim monthlyFee As Integer
    Dim total As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        monthlyfee.Text = "......"
        totalfee.Text = "......"
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub month_TextChanged(sender As Object, e As EventArgs) Handles month.TextChanged

        Select Case monthNumber
            Case "1"
                monthlyfee = 

        End Select


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub options_Enter(sender As Object, e As EventArgs) Handles options.Enter

    End Sub
End Class
