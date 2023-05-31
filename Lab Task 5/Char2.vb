Public Class Char2
    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        MessageBox.Show("You have answer all the questions, Now returning to the home screen", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Category.Show()
        Me.Hide()
    End Sub

    Private Sub btCheck_Click(sender As Object, e As EventArgs) Handles btCheck.Click
        If ansBot.Checked = True Then
            rightAns += 1
            MessageBox.Show("Correct! +1 point", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ansMid.Checked = True Or ansTop.Checked = True Then
            MessageBox.Show("Wrong Answer", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        lblRightAns.Text = rightAns
        btCheck.Enabled = False
    End Sub
End Class