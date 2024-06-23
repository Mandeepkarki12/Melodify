Imports System.IO
Imports Guna.UI2.WinForms
Public Class Func
    Public sql As New SQLControl
    Public Function FetchImage(user As Integer) As Byte()
        sql.AddParam("@user", user)
        sql.ExecQuery("SELECT ProfilePicture FROM USERS WHERE UserId = @user")
        If Not String.IsNullOrEmpty(sql.Exception) OrElse sql.RecordCount < 1 Then
            Return Nothing
        End If
        Dim buffer As Byte() = sql.SQLDS.Tables(0).Rows(0)("ProfilePicture")
        Return buffer
    End Function
    Public Sub LoadImage(im As Guna2CirclePictureBox, user As Integer)
        Dim buffer As Byte() = FetchImage(user)
        If buffer IsNot Nothing Then
            Using ms As New MemoryStream(buffer, 0, buffer.Length)
                ms.Write(buffer, 0, buffer.Length)
                im.Image = System.Drawing.Image.FromStream(ms, True)
            End Using
        End If
    End Sub
    Public Sub musicSave(filePath As String, comboBox As Guna2ComboBox, text1 As Guna2TextBox, imagePath As String)
        Try
            If Not sql.hasConnection() Then
                MessageBox.Show("Connection to the database failed.")
                Return
            End If
            Dim img As Image = Image.FromFile(imagePath)
            Dim ms As New MemoryStream()
            img.Save(ms, img.RawFormat)
            Dim buffer As Byte() = ms.GetBuffer
            ' Read file data
            Dim fileData As Byte() = File.ReadAllBytes(filePath)
            ' Insert file data into database
            Dim query As String = "INSERT INTO Songs (Title, ArtistID , AlbumID, ReleaseDate , SongData, SongImage) VALUES (@Title ,@ArtistId, @AlbumId , @Dat ,  @SongData, @image)"
            sql.AddParam("@SongData", fileData)
            sql.AddParam("@image", buffer)
            sql.AddParam("@Album", comboBox.Text)
            sql.AddParam("@Dat", DateTime.Now)
            sql.AddParam("@Title", text1.Text)
            sql.AddParam("@ArtistId", artistId)
            sql.AddParam("@AlbumId", albumId)
            sql.ExecQuery(query)
            ' Check for exceptions
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MessageBox.Show("An error occurred during SQL query execution: " & sql.Exception)
            Else
                MessageBox.Show("Data inserted successfully.")
            End If
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class
