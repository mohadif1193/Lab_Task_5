Public Class Category
    Private Sub btChar_Click(sender As Object, e As EventArgs) Handles btChar.Click
        Char1.Show()
        Me.Hide()
    End Sub

    Private Sub btMovie_Click(sender As Object, e As EventArgs) Handles btMovie.Click
        Movie.Show()
        Me.Hide()
    End Sub

    Private Sub btQuote_Click(sender As Object, e As EventArgs) Handles btQuote.Click
        Quote.Show()
        Me.Hide()
    End Sub

    Private Sub btPlanet_Click(sender As Object, e As EventArgs) Handles btPlanet.Click
        Planet.Show()
        Me.Hide()
    End Sub
End Class