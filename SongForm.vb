Imports System.IO
Public Class SongForm
    Public sql As New SQLControl
    Private home As Home ' Declare a variable to hold the passed Home instance
    ' Modify the constructor to accept a Home instance
    Public Sub New(homeInstance As Home)
        InitializeComponent()
        home = homeInstance ' Assign the passed Home instance to the variable
    End Sub
    Public Sub Song_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        Dim query As String = "
            SELECT 
                s.SongID,
                s.Title AS SongTitle,
                a.ArtistId,
                u.UserName,
                s.SongData,
                s.SongImage
            FROM 
                dbo.Songs s
            INNER JOIN 
                dbo.Artists a ON s.ArtistID = a.ArtistId
            INNER JOIN 
                dbo.Users u ON a.UserId = u.UserId
        "
        loadData(query)
    End Sub
    Class song
        Public songTitle As String
        Public artistName As String
        Public songImage As Image
        Public songData As String
    End Class
    Public Function SongsList(query As String) As List(Of song)
        Dim songs As New List(Of song)()
        sql.ExecQuery(query)
        ' Check for SQL errors
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return songs
        End If
        For Each row As DataRow In sql.SQLDS.Tables(0).Rows
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
        ' Clear any existing controls in the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Clear()
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
            FlowLayoutPanel1.Controls.Add(songPanel)
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
        home.Guna2ImageButton15.Checked = False
        home.ClearSong()
        home.Files = ""
        home.Guna2PictureBox14.Image = picBox
        home.Label34.Text = musicName
        home.Label33.Text = SingerName
        home.Files = fileP
    End Sub

    Private searchedText As String = ""
    Public Sub searchBtn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchBtn.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' If Enter key is pressed, store the text
            searchedText = searchBtn.Text
            searchBtn.Clear()
            ' Add parameter for the wildcard search
            sql.AddParam("@searchedText", "%" & searchedText & "%")
            ' SQL query with wildcard search using LIKE operator
            Dim query As String = "
                SELECT 
                    s.SongID,
                    s.Title AS SongTitle,
                    a.ArtistId,
                    u.UserName,
                    s.SongData,
                    s.SongImage
                FROM 
                    dbo.Songs s
                INNER JOIN 
                    dbo.Artists a ON s.ArtistID = a.ArtistId
                INNER JOIN 
                    dbo.Users u ON a.UserId = u.UserId
                WHERE
                    s.Title LIKE @searchedText OR
                    u.UserName LIKE @searchedText
            "
            loadData(query)
            e.Handled = True ' To prevent the ding sound when Enter is pressed
        End If
    End Sub
End Class
