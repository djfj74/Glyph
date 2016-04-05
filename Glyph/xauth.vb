Imports System.Security.Cryptography

Module Xauth

    Function authenticate(p1 As String, p2 As String, server As String) As String
        Dim u As String = getSHA1Hash(p1)
        Dim p As String = getSHA1Hash(p2)
        Dim token As String = Nothing



        Return token
    End Function

    Function getSHA1Hash(ByVal strToHash As String) As String

        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function

End Module
