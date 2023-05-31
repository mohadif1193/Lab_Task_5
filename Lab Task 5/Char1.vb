Public Class Char1
    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        Char2.Show()
        Me.Hide()
    End Sub

    Private Sub btCheck_Click(sender As Object, e As EventArgs) Handles btCheck.Click
        If ansMid.Checked = True Then
            rightAns += 1
            MessageBox.Show("Correct! +1 point", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ansBot.Checked = True Or ansTop.Checked = True Then
            MsgBox("Wrong Answer")
        End If
        lblRightAns.Text = rightAns
        btCheck.Enabled = False
    End Sub
End Class
