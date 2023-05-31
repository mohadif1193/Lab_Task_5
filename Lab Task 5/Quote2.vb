Public Class Quote2
    Private Sub btCheck_Click(sender As Object, e As EventArgs) Handles btCheck.Click
        rightAns = 0
        If ansTop.Checked = True Then
            rightAns += 1
            MessageBox.Show("Correct! +1 point", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ansMid.Checked = True Or ansBot.Checked = True Then
            MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        lblRightAns.Text = rightAns
        btCheck.Enabled = False
    End Sub

    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        rightAns = 0
        MessageBox.Show("You have answer all the questions, Now returning to the home screen", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Category.Show()
        Me.Hide()
    End Sub
End Class