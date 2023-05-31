Public Class Movie
    Private Sub btCheck_Click(sender As Object, e As EventArgs) Handles btCheck.Click
        rightAns = 0
        If ans4.Checked = True Then
            MessageBox.Show("Here are the answers", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ans1.Checked = True
            ans2.Checked = True
            ans3.Checked = True
            ans4.Checked = False
            ans5.Checked = True
            ans6.Checked = True
            ans1.Enabled = False
            ans2.Enabled = False
            ans3.Enabled = False
            ans4.Enabled = False
            ans5.Enabled = False
            ans6.Enabled = False
            lblRightAns.Text = rightAns
        Else
            If ans1.Checked = True Then
                rightAns += 1
                lblRightAns.Text = rightAns
            End If
            If ans2.Checked = True Then
                rightAns += 1
                lblRightAns.Text = rightAns
            End If
            If ans3.Checked = True Then
                rightAns += 1
                lblRightAns.Text = rightAns
            End If
            If ans5.Checked = True Then
                rightAns += 1
                lblRightAns.Text = rightAns
            End If
            If ans6.Checked = True Then
                rightAns += 1
                lblRightAns.Text = rightAns
            End If
        End If
    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        rightAns = 0
        MessageBox.Show("You have answer the question, Now returning to the home screen", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Category.Show()
        Me.Hide()
    End Sub
End Class