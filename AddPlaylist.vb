Public Class AddPlaylist
    Private sql As New SQLControl
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If String.IsNullOrEmpty(TitleTxt.Text) Or String.IsNullOrEmpty(DescTxt.Text) Then
            MsgBox("Please Fill Up All Information !!")
        End If
        sql.AddParam("@Title", TitleTxt.Text)
        sql.AddParam("@Desc", DescTxt.Text)
        sql.AddParam("@dat", DateTime.Now)
        sql.AddParam("@userId", userId)
        sql.ExecQuery("INSERT INTO Playlists VALUES (@userId,@Title,@Desc,@dat)")
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
        Else
            MsgBox("Playlist Created Sucessfully !!")
            Me.Close()
        End If
    End Sub
End Class