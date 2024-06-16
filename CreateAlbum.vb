Public Class CreateAlbum
    Public sql As New SQLControl
    Private settingsForm As Setting ' Reference to Setting form
    Public Sub New(ByRef settings As Setting)
        InitializeComponent()
        settingsForm = settings
    End Sub
    Private Sub GetStartedButton_Click(sender As Object, e As EventArgs) Handles GetStartedButton.Click
        sql.AddParam("@Title", Guna2TextBox1.Text)
        sql.AddParam("@Genre", Guna2ComboBox1.Text)
        sql.AddParam("@Date", DateTime.Now)
        sql.AddParam("@artistId", artistId)
        sql.ExecQuery("INSERT INTO ALBUMS (ArtistId, Title, Genre, ReleaseDate) VALUES (@artistId, @Title, @Genre, @Date)")
        If Not String.IsNullOrEmpty(Sql.Exception) Then
            MsgBox(Sql.Exception)
        Else
            MsgBox("Album created successfully")
            sql.AddParam("@artistId", artistId)
            sql.ExecQuery("SELECT AlbumID FROM ALBUMS WHERE ArtistID = @artistId")
            If sql.RecordCount = 1 Then
                albumId = Convert.ToInt32(sql.SQLDS.Tables(0).Rows(0)("AlbumID"))
            End If
            settingsForm.Refresh()
            Me.Close()
            settingsForm.clearAlbum()
            settingsForm.getAlbums()
        End If
    End Sub
    Private Sub CreateAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class