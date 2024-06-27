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
        Dim addplay As New AddPlaylist
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
    Private Sub loadPlaylistData(query As String)
        ' Get the list of albums from the database
        Dim playitem As List(Of play) = PlaylistInfos(query)
        ' Debug output
        ' Clear any existing controls in the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Clear()
        ' Loop through each album and create controls to display them
        For Each a As play In playitem
            ' Create a new panel for each album
            Dim playlistPanel As New RoundedPanel()
            playlistPanel.Width = 200
            playlistPanel.Height = 200
            playlistPanel.Margin = New Padding(20)
            playlistPanel.CornerRadius = 10 ' Set the corner radius
            ' Create and add a PictureBox for the album image
            Dim pb As New PictureBox()
            pb.Image = a.PlayImage
            pb.Width = 180
            pb.Height = 180 ' Adjust the height to fit the panel properly
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Dock = DockStyle.Right
            playlistPanel.Controls.Add(pb)
            ' Create and add a Label for the album name
            Dim titleLbl As New Label()
            titleLbl.Text = a.Title
            titleLbl.Dock = DockStyle.Top
            titleLbl.TextAlign = ContentAlignment.TopCenter
            titleLbl.Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
            playlistPanel.Controls.Add(titleLbl)
            ' Assign the Tag property to store album information
            playlistPanel.Tag = a
            ' Assign the click event handler to the panel and all its child controls
            AddHandler playlistPanel.Click, AddressOf PlaylistPanel_Click
            AddHandler pb.Click, AddressOf PlaylistPanel_Click
            AddHandler titleLbl.Click, AddressOf PlaylistPanel_Click
            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(playlistPanel)
        Next
    End Sub
    Private Sub PlaylistPanel_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked control, which might be the panel or any of its child controls
        Dim clickedControl As Control = DirectCast(sender, Control)
        ' Retrieve the parent panel that contains the album information
        Dim parentPanel As Panel = If(TypeOf clickedControl Is Panel, DirectCast(clickedControl, Panel), DirectCast(clickedControl.Parent, Panel))
        ' Retrieve the album information from the Tag property
        Dim p As play = DirectCast(parentPanel.Tag, play)
        ' You can add code here to handle the click event
        playlistId = p.playlistId
        Me.Close()
        Dim songplaylist As New SongPlaylist(home)
        home.childForm(songplaylist)





    End Sub
    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        Dim query = "SELECT 
      PlaylistId,
      Title,
      Descriptions
  FROM Melodifydb.dbo.Playlists
  WHERE UserID = @UserId;
"
        sql.AddParam("@UserId", userId)
        loadPlaylistData(query)
    End Sub
End Class