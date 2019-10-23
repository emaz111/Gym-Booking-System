Public Class ForgotID

    Private Sub btnForgotPass_Click(sender As Object, e As EventArgs) Handles btnForgotPass.Click
        Dim lines() As String
        Dim searchString As String = txtEmail.Text
        Dim searchString2 As String = txtDigit.Text
        lines = IO.File.ReadAllLines("Member_Details.txt")

        'loops through the text file
        For i = 0 To lines.Length() - 1
            'checks every id thats been loaded into file and removes "" 
            lines(i) = lines(i).Replace(Chr(34), "").Trim()

            'checks if string matches
            If lines(i) = searchString And searchString2 Then
                'logs in
                MsgBox("LOGGED IN")
                lblPin.Text = "Membership Pin: " + lines(i)
                Me.Hide()
                Return
            End If
        Next
        MsgBox("Login ID incorrect or does not exist")


        txtEmail.Clear()

        Dim Counter As String = IO.File.ReadAllLines("Member_Details.txt")(2)
        lblPin.Text = "Membership Pin: " + Counter
    End Sub
End Class