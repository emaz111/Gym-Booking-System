Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Finder As String
        Dim Found As Boolean
        Finder = txtLogin.Text

        'login for members
        If chkInstructor.Checked = False Then
            FileOpen(1, "Member_Details.txt", OpenMode.Random, , , Len(MemberInfo))
            Do While Not EOF(1)
                FileGet(1, MemberInfo)
                recordPosition = recordPosition + 1
                If Finder = Trim(MemberInfo.MembershipPin) Then
                    Found = True
                    UserPinID = Finder
                    MainMenuMember.Show()
                End If
            Loop
        Else
            'login for instructor
            FileOpen(1, "Instructor_Details.txt", OpenMode.Random, , , Len(InstructorInfo))
            Do While Not EOF(1)
                FileGet(1, InstructorInfo)
                recordPosition = recordPosition + 1
                If Finder = Trim(InstructorInfo.UniquePin) Then
                    Found = True
                    Members.Show()
                End If
            Loop
        End If
        FileClose(1)
    End Sub
    Private Sub btnForgotPass_Click(sender As Object, e As EventArgs) Handles btnForgotPass.Click
        ForgotID.Show()
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Members.Show()
    End Sub
End Class
