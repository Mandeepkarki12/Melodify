Imports System.Data.SqlClient
Imports System.IO
Public Class SongPlaylist
    Private Sql As New SQLControl
    Private SelectedSongIDs As New List(Of Integer)
    Private Home As Home

    ' Constructor to accept a Home instance
    Public Sub New(homeInstance As Home)
        InitializeComponent()
        Home = homeInstance ' Assign the passed Home instance to the variable
    End Sub
    Class song
        Public songTitle As String
        Public artistName As String
        Public songImage As Image
        Public songData As String
    End Class

    Public Function SongsList(query As String) As List(Of song)
        Dim songs As New List(Of song)()
        Sql.ExecQuery(query)
        ' Check for SQL errors
        If Not String.IsNullOrEmpty(Sql.Exception) Then
            MsgBox(Sql.Exception)
            Return songs
        End If

        For Each row As DataRow In Sql.SQLDS.Tables(0).Rows
            Dim song As New song()
            song.songTitle = Convert.ToString(row("SongTitle"))
            song.artistName = Convert.ToString(row("UserName"))
            Dim buffer As Byte() = DirectCast(row("SongImage"), Byte())
            If buffer IsNot Nothing Then
                Using ms As New MemoryStream(buffer, 0, buffer.Length)
                    ms.Write(buffer, 0, buffer.Length)
                    song.songImage = System.Drawing.Image.FromStream(ms, True)
                End Using
            End If
            Dim songData As Byte() = DirectCast(row("SongData"), Byte())
            Dim tempFilePath As String = Path.GetTempFileName()
            File.WriteAllBytes(tempFilePath, songData)
            song.songData = tempFilePath
            songs.Add(song)
        Next

        Return songs
    End Function

    Public Sub loadData(query As String)
        ' Get the list of songs from the database
        Dim songs As List(Of song) = SongsList(query)
        MsgBox(songs.Count)
        ' Clear any existing controls in the FlowLayoutPanel
        FlowLayoutPanel2.Controls.Clear()

        ' Loop through each song and create controls to display them
        For Each s As song In songs
            ' Create a new panel for each song
            Dim songPanel As New RoundedPanel()
            songPanel.Width = 200
            songPanel.Height = 200
            songPanel.Margin = New Padding(20)
            songPanel.CornerRadius = 10 ' Set the corner radius

            ' Create and add a PictureBox for the song image
            Dim pb As New PictureBox()
            If s.songImage IsNot Nothing Then
                pb.Image = s.songImage
                pb.Width = 180
                pb.Height = 180
                pb.SizeMode = PictureBoxSizeMode.StretchImage
                pb.Dock = DockStyle.Top
                songPanel.Controls.Add(pb)
            End If

            ' Create and add a Label for the song title
            Dim titleLbl As New Label()
            titleLbl.Text = s.songTitle
            titleLbl.Dock = DockStyle.Top
            titleLbl.TextAlign = ContentAlignment.MiddleCenter
            titleLbl.Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
            songPanel.Controls.Add(titleLbl)

            ' Create and add a Label for the artist name
            Dim artistLbl As New Label()
            artistLbl.Text = s.artistName
            artistLbl.Dock = DockStyle.Top
            artistLbl.TextAlign = ContentAlignment.MiddleCenter
            artistLbl.Font = New Font("Microsoft YaHei UI", 8, FontStyle.Regular)
            songPanel.Controls.Add(artistLbl)

            ' Assign the Tag property to store song information
            songPanel.Tag = s

            ' Assign the click event handler to the panel and all its child controls
            AddHandler songPanel.Click, AddressOf SongPanel_Click
            AddHandler pb.Click, AddressOf SongPanel_Click
            AddHandler titleLbl.Click, AddressOf SongPanel_Click
            AddHandler artistLbl.Click, AddressOf SongPanel_Click

            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel2.Controls.Add(songPanel)
        Next
    End Sub

    Private Sub SongPanel_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked control, which might be the panel or any of its child controls
        Dim clickedControl As Control = DirectCast(sender, Control)
        ' Retrieve the parent panel that contains the song information
        Dim parentPanel As Panel = If(TypeOf clickedControl Is Panel, DirectCast(clickedControl, Panel), DirectCast(clickedControl.Parent, Panel))
        ' Retrieve the song information from the Tag property
        Dim s As song = DirectCast(parentPanel.Tag, song)
        ' Update Label1 with the song name
        displayMusictemp(s.songImage, s.songTitle, s.artistName, s.songData)
    End Sub

    Public Sub displayMusictemp(picBox As Image, musicName As String, SingerName As String, fileP As String)
        Home.Guna2ImageButton15.Checked = False
        Home.ClearSong()
        Home.Files = ""
        Home.Guna2PictureBox14.Image = picBox
        Home.Label34.Text = musicName
        Home.Label33.Text = SingerName
        Home.Files = fileP
    End Sub

    Private Sub LoadSongs()
        Sql.Params.Clear()
        Dim query As String = "
        SELECT s.SongID, s.Title, s.ArtistID, s.AlbumID, s.Duration, s.ReleaseDate, s.SongData, s.SongImage
        FROM [Melodifydb].[dbo].[Songs] s
        LEFT JOIN [Melodifydb].[dbo].[PlaylistSongs] ps
        ON s.SongID = ps.SongID AND ps.PlaylistID = @PlaylistID
        WHERE ps.SongID IS NULL;
    "
        Sql.AddParam("@PlaylistID", playlistId)
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

    Private Sub SongPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel2.Visible = True  ' Ensure FlowLayoutPanel2 is initially visible
        FlowLayoutPanel2.Dock = DockStyle.Bottom ' Adjust docking as needed
        Dim query As String = "SELECT s.SongData, s.Title AS SongTitle, s.SongImage, u.Username
                           FROM Melodifydb.dbo.Songs s
                           JOIN Melodifydb.dbo.PlaylistSongs ps ON s.SongID = ps.SongID
                           JOIN Melodifydb.dbo.Playlists p ON ps.PlaylistID = p.PlaylistID
                           JOIN Melodifydb.dbo.Users u ON p.UserID = u.UserID
                           WHERE ps.PlaylistID = @PlaylistID;"
        Sql.AddParam("@PlaylistID", playlistId)
        loadData(query)
        FlowLayoutPanel1.Visible = False
        FlowLayoutPanel1.Dock = DockStyle.Bottom
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim playlist As New Playlist(Home)
        Home.childForm(playlist)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        LoadSongs()
        FlowLayoutPanel1.Visible = True
        FlowLayoutPanel2.Visible = False  ' Ensure FlowLayoutPanel2 is hidden when not needed
        Guna2Button2.Visible = True
    End Sub
    Private Sub SaveSelectedSongs()
        If SelectedSongIDs.Count > 0 Then
            Dim query As String = "INSERT INTO [Melodifydb].[dbo].[PlaylistSongs] (PlaylistID, SongID) VALUES (@PlaylistID, @SongID)"
            Try
                For Each songID In SelectedSongIDs
                    Sql.AddParam("@PlaylistID", playlistId)
                    Sql.AddParam("@SongID", songID)
                    Sql.ExecQuery(query)
                    If Not String.IsNullOrEmpty(Sql.Exception) Then
                        MsgBox(Sql.Exception)
                        Return
                    End If
                Next
                MsgBox("Selected songs have been saved to the playlist successfully.")
            Catch ex As Exception
                MsgBox("An error occurred while saving the songs to the playlist: " & ex.Message)
            End Try
        Else
            MsgBox("No songs selected.")
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SaveSelectedSongs()
        FlowLayoutPanel1.Visible = False
        Guna2Button2.Visible = False
        FlowLayoutPanel2.Visible = True  ' Make FlowLayoutPanel2 visible after saving selected songs
    End Sub
End Class
