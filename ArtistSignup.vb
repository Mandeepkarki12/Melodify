
Public Class ArtistSignup
    Private sql As New SQLControl
    Private Function SignUp() As Boolean

        If String.IsNullOrEmpty(BioTxt.Text) Or String.IsNullOrEmpty(GenreTxt.Text) Then
            MsgBox("Please fill up all your information.")
            Return False
        End If
        sql.AddParam("@user", userId)
        sql.AddParam("@Bio", BioTxt.Text)
        sql.AddParam("@Genre", GenreTxt.Text)
        sql.ExecQuery("INSERT INTO ARTISTS (UserId, ArtistBIO, Genre) VALUES (@user, @Bio, @Genre)")
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return False
        End If
        Return True
    End Function
    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        If SignUp() Then
            Dim settings As New Setting
            sql.AddParam("@user", userId)
            sql.ExecQuery("UPDATE Users SET ArtistCheck = 1 WHERE UserId = @user")
            settings.Guna2Button1.Hide()
            settings.Guna2Button2.Show()
            MsgBox("You signed up as an artist.")
        Else
            MsgBox("Failed to sign up.")
        End If
    End Sub

    Private Sub ArtistSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(userId)
    End Sub
End Class
