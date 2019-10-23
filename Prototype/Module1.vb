Module Module1
    Public UserPinID As String
    Public NumberOfRecords As Integer
    Public recordPosition As Integer

    Structure MemberType
        <VBFixedString(20)> Public FirstName As String
        <VBFixedString(20)> Public LastName As String
        <VBFixedString(4)> Public Digit As String
        <VBFixedString(30)> Public EmailAddress As String
        <VBFixedString(1)> Public Gender As String
        <VBFixedString(10)> Public DOB As String
        <VBFixedString(8)> Public MembershipPin As String
    End Structure
    Public MemberInfo As MemberType

    Public MultiMembers(100) As MemberType

    Structure InstructorType
        <VBFixedString(20)> Public FirstName As String
        <VBFixedString(20)> Public LastName As String
        <VBFixedString(1)> Public Gender As String
        <VBFixedString(10)> Public DOB As String
        <VBFixedString(10)> Public UniquePin As String
    End Structure
    Public InstructorInfo As InstructorType

    Structure BookingType
        <VBFixedString(10)> Public BookingDay As String
        <VBFixedString(11)> Public BookingTime As String
        <VBFixedString(8)> Public UserPinID As String
    End Structure

    Public BookingInfo As BookingType
End Module
