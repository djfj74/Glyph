Public Class Form1
    Dim currentserver As String = ""
    Private Sub AdobeButton1_Click(sender As Object, e As EventArgs) Handles AdobeButton1.Click
        Dim token As String = Xauth.authenticate(TextBox1.Text, TextBox2.Text, currentServer)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Glyph"
    End Sub
End Class
