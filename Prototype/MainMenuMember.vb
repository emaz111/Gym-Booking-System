Public Class MainMenuMember

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        BookingsMember.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        UserPinID = ""
        LoginForm.Show()
        Me.Close()
    End Sub


    Private Sub btnSelectJon_Click(sender As Object, e As EventArgs) Handles btnSelectJon.Click
        intructorBookings.Show()
        Me.Close()
    End Sub
End Class