Imports System.IO
Public Class Download
    Private Sql As New SQLControl
    Private SelectedSongIDs As New List(Of Integer)

    Public Sub DownloadSelectedSongs(savePath As String)
        Try
            If SelectedSongIDs.Count = 0 Then
                MsgBox("No songs selected.")
                Return
            End If

            For Each songID As Integer In SelectedSongIDs
                ' Define the query to get the song data from the database
                Dim query As String = "SELECT SongData, Title FROM [Melodifydb].[dbo].[Songs] WHERE SongID = @SongID"

                ' Clear any previous parameters and add the songID parameter
                Sql.Params.Clear()
                Sql.AddParam("@SongID", songID)

                ' Execute the query
                Sql.ExecQuery(query)
                If Not String.IsNullOrEmpty(Sql.Exception) Then
                    MsgBox(Sql.Exception)
                    Return
                End If

                ' Check if any song data was retrieved
                If Sql.SQLDS.Tables(0).Rows.Count = 0 Then
                    MsgBox("Song not found for SongID: " & songID)
                    Continue For
                End If

                ' Retrieve the song data and title
                Dim songData As Byte() = CType(Sql.SQLDS.Tables(0).Rows(0)("SongData"), Byte())
                Dim songTitle As String = Convert.ToString(Sql.SQLDS.Tables(0).Rows(0)("Title"))

                ' Define the file path to save the MP3 file
                Dim filePath As String = Path.Combine(savePath, songTitle & ".mp3")

                ' Write the song data to the file
                File.WriteAllBytes(filePath, songData)
            Next

            MsgBox("Selected songs have been downloaded successfully to " & savePath)
        Catch ex As Exception
            MsgBox("An error occurred while downloading the songs: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadSongs()
        Sql.Params.Clear()
        Dim query As String = "
          SELECT 
            s.SongID, 
            s.Title, 
            s.ArtistID, 
            u.UserName As ArtistName,
            s.AlbumID, 
            s.Duration, 
            s.ReleaseDate, 
            s.SongData, 
            s.SongImage,
            u.UserName
        FROM 
            [Melodifydb].[dbo].[Songs] s
        INNER JOIN 
            [Melodifydb].[dbo].[Artists] a ON s.ArtistID = a.ArtistID
        INNER JOIN 
            [Melodifydb].[dbo].[Albums] al ON s.AlbumID = al.AlbumID
        INNER JOIN 
            [Melodifydb].[dbo].[Users] u ON a.UserID = u.UserID;
    "
        Sql.ExecQuery(query)
        If Not String.IsNullOrEmpty(Sql.Exception) Then
            MsgBox(Sql.Exception)
            Return
        End If

        FlowLayoutPanel1.Controls.Clear()
        For Each row As DataRow In Sql.SQLDS.Tables(0).Rows
            Dim songID As Integer = Convert.ToInt32(row("SongID"))
            Dim title As String = Convert.ToString(row("Title"))
            Dim songImage As Byte() = CType(row("SongImage"), Byte())
            ' Create a new panel for each song
            Dim songPanel As New Panel()
            songPanel.Width = 1000
            songPanel.Height = 80
            songPanel.Padding = New Padding(5)
            songPanel.Margin = New Padding(0, 0, 0, 5)
            songPanel.BackColor = Color.LightGray
            ' Create and add a PictureBox for the song image
            Dim pb As New PictureBox()
            pb.Width = 60
            pb.Height = 60
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Image = Image.FromStream(New IO.MemoryStream(songImage))
            pb.Dock = DockStyle.Left
            pb.Margin = New Padding(0, 10, 10, 10)
            ' Create and add a Label for the song title
            Dim titleLbl As New Label()
            titleLbl.Text = title
            titleLbl.Dock = DockStyle.Fill
            titleLbl.TextAlign = ContentAlignment.MiddleCenter
            titleLbl.Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
            ' Create and add a CheckBox for song selection
            Dim songCheckBox As New CheckBox()
            songCheckBox.Dock = DockStyle.Right
            songCheckBox.Tag = songID
            AddHandler songCheckBox.CheckedChanged, AddressOf SongCheckBox_CheckedChanged
            ' Add the controls to the panel
            songPanel.Controls.Add(pb)
            songPanel.Controls.Add(titleLbl)
            songPanel.Controls.Add(songCheckBox)
            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(songPanel)
        Next
    End Sub
    Private Sub SongCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim checkBox As CheckBox = DirectCast(sender, CheckBox)
        Dim songID As Integer = DirectCast(checkBox.Tag, Integer)
        If checkBox.Checked Then
            ' Add to the list if checked
            If Not SelectedSongIDs.Contains(songID) Then
                SelectedSongIDs.Add(songID)
            End If
        Else
            ' Remove from the list if unchecked
            If SelectedSongIDs.Contains(songID) Then
                SelectedSongIDs.Remove(songID)
            End If
        End If
    End Sub
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim savePath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
        DownloadSelectedSongs(savePath)
    End Sub

    Private Sub Download_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        LoadSongs()

    End Sub
End Class