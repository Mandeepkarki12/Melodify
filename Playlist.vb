Imports Melodify
Public Class Playlist
    Private sql As New SQLControl
    Private home As Home ' Declare a variable to hold the passed Home instance

    ' Modify the constructor to accept a Home instance
    Public Sub New(homeInstance As Home)
        InitializeComponent()
        home = homeInstance ' Assign the passed Home instance to the variable
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim addplay As New AddPlaylist(Me) ' Pass the current instance of Playlist form
        addplay.Show()
    End Sub

    Class play
        Public Title As String
        Public Description As String
        Public PlayImage As Image = Melodify.My.Resources.playlist_minimalistic_2_svgrepo_com__1_
        Public playlistId As Integer
    End Class

    Private Function PlaylistInfos(query As String) As List(Of play)
        Dim playInf As New List(Of play)()
        sql.ExecQuery(query)
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return playInf
        End If
        For Each row As DataRow In sql.SQLDS.Tables(0).Rows
            Dim plays As New play()
            plays.playlistId = Convert.ToInt32(row("PlaylistId"))
            plays.Title = Convert.ToString(row("Title"))
            plays.Description = Convert.ToString(row("Descriptions"))
            playInf.Add(plays)
        Next
        Return playInf
    End Function

    Public Sub LoadPlaylistData()
        Dim query = "SELECT PlaylistId, Title, Descriptions FROM Melodifydb.dbo.Playlists WHERE UserID = @UserId;"
        sql.AddParam("@UserId", userId)
        Dim playitem As List(Of play) = PlaylistInfos(query)

        FlowLayoutPanel1.Controls.Clear()
        For Each a As play In playitem
            Dim playlistPanel As New RoundedPanel()
            playlistPanel.Width = 200
            playlistPanel.Height = 200
            playlistPanel.Margin = New Padding(20)
            playlistPanel.CornerRadius = 10

            Dim pb As New PictureBox()
            pb.Image = a.PlayImage
            pb.Width = 180
            pb.Height = 180
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Dock = DockStyle.Right
            playlistPanel.Controls.Add(pb)

            Dim titleLbl As New Label()
            titleLbl.Text = a.Title
            titleLbl.Dock = DockStyle.Top
            titleLbl.TextAlign = ContentAlignment.TopCenter
            titleLbl.Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
            playlistPanel.Controls.Add(titleLbl)

            playlistPanel.Tag = a

            AddHandler playlistPanel.Click, AddressOf PlaylistPanel_Click
            AddHandler pb.Click, AddressOf PlaylistPanel_Click
            AddHandler titleLbl.Click, AddressOf PlaylistPanel_Click

            FlowLayoutPanel1.Controls.Add(playlistPanel)
        Next
    End Sub

    Private Sub PlaylistPanel_Click(sender As Object, e As EventArgs)
        Dim clickedControl As Control = DirectCast(sender, Control)
        Dim parentPanel As Panel = If(TypeOf clickedControl Is Panel, DirectCast(clickedControl, Panel), DirectCast(clickedControl.Parent, Panel))
        Dim p As play = DirectCast(parentPanel.Tag, play)
        playlistId = p.playlistId
        Me.Close()
        Dim songplaylist As New SongPlaylist(home)
        home.childForm(songplaylist)
    End Sub

    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        LoadPlaylistData()
    End Sub
End Class
