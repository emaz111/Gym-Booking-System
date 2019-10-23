Public Class intructorBookings

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Found As Boolean
        Dim Finder = UserPinID

        FileOpen(1, "Member_Details.txt", OpenMode.Random, , , Len(MemberInfo))
        Do While Not EOF(1)
            FileGet(1, MemberInfo)
            recordPosition = recordPosition + 1
            If Finder = Trim(UserPinID) Then
                Found = True
                For Index = 1 To NumberOfRecords
                    FileGet(1, BookingInfo)
                    FilePut(1, MemberInfo, NumberOfRecords + 1)
                Next Index
                UserPinID = Finder
            End If
        Loop




    End Sub


    Private Sub intructorBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index As Integer = 0
        FileOpen(1, "Member_Details.txt", OpenMode.Random, , , Len(MemberInfo))
        Do While Not EOF(1)
            FileGet(1, MemberInfo)
            With MultiMembers(index)
                .FirstName = MemberInfo.FirstName
                .LastName = MemberInfo.LastName
                .Digit = MemberInfo.Digit
                .EmailAddress = MemberInfo.EmailAddress
                .Gender = MemberInfo.Gender
                .DOB = MemberInfo.DOB
                .MembershipPin = MemberInfo.MembershipPin
            End With
            index = index + 1
        Loop
    End Sub
End Class