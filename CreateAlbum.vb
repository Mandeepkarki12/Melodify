Public Class CreateAlbum
    Private Sql As New SQLControl
    Private Sub GetStartedButton_Click(sender As Object, e As EventArgs) Handles GetStartedButton.Click
        Sql.AddParam("@Title", Guna2TextBox1.Text)
        Sql.AddParam("@Genre", Guna2ComboBox1.Text)
        Sql.AddParam("@Date", DateTime.Now)
        Sql.AddParam("@artistId", artistId)
        Sql.ExecQuery("INSERT INTO ALBUMS (ArtistId, Title, Genre, ReleaseDate) VALUES (@artistId, @Title, @Genre, @Date)")
        If Not String.IsNullOrEmpty(Sql.Exception) Then
            MsgBox(Sql.Exception)
        Else
            MsgBox("Album created successfully")
        End If
    End Sub
    Private Sub CreateAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class