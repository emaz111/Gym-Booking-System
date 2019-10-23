Public Class Members




    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("Member_ID.txt", False)

        file.Close()
    End Sub

    Private Sub dntAdd_Click(sender As Object, e As EventArgs) Handles dntAdd.Click
        FileOpen(1, "Member_Details.txt", OpenMode.Random, , , Len(MemberInfo))
        NumberOfRecords = LOF(1) / Len(MemberInfo)
        MemberInfo.FirstName = txtFname.Text
        MemberInfo.LastName = txtLname.Text
        MemberInfo.Digit = txtDigit.Text
        MemberInfo.EmailAddress = txtEmail.Text
        MemberInfo.Gender = txtGender.Text
        MemberInfo.DOB = txtDob.Text
        MemberInfo.MembershipPin = txtMpin.Text
        FilePut(1, MemberInfo, NumberOfRecords + 1)
        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FileOpen(1, "Member_ID.txt", OpenMode.Append)

        If txtMpin.Text <> "" Then
            WriteLine(1, txtMpin.Text)
            MsgBox("Successful")
        Else
            MsgBox("Unsuccessful")
        End If

        FileClose(1)
    End Sub

    Private Sub delete2Btn_Click(sender As Object, e As EventArgs)
        Dim file2 As System.IO.StreamWriter

        file2 = My.Computer.FileSystem.OpenTextFileWriter("Member_Details.txt", False)

        file2.Close()
    End Sub


    Private Sub Debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class