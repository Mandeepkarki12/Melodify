Imports System.IO

Public Class Albums
    Private Sql As New SQLControl
    Private home As Home ' Declare a variable to hold the passed Home instance

    ' Modify the constructor to accept a Home instance
    Public Sub New(homeInstance As Home)
        InitializeComponent()
        home = homeInstance ' Assign the passed Home instance to the variable
    End Sub
    Public songForm As SongForm
    Public Sub New(songFormInstance As SongForm)
        InitializeComponent()
        songForm = songFormInstance ' Assign the passed Home instance to the variable
    End Sub

    Class Album
        Public albumName As String
        Public albumUserName As String
        Public albumImage As Image = Melodify.My.Resources.albums_sharp_svgrepo_com__1_
        Public albumId As Integer
    End Class

    Private Function AlbumsList(query As String) As List(Of Album)
        Dim albums As New List(Of Album)()
        Sql.ExecQuery(query)
        If Not String.IsNullOrEmpty(Sql.Exception) Then
            MsgBox(Sql.Exception)
            Return albums
        End If
        For Each row As DataRow In Sql.SQLDS.Tables(0).Rows
            Dim album As New Album()
            album.albumName = Convert.ToString(row("AlbumName"))
            album.albumUserName = Convert.ToString(row("ArtistName"))
            album.albumId = Convert.ToInt32(row("AlbumId"))
            albums.Add(album)
        Next
        Return albums
    End Function

    Private Sub loadAlbumData(query As String)
        ' Get the list of albums from the database
        Dim albums As List(Of Album) = AlbumsList(query)

        ' Debug output

        ' Clear any existing controls in the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Clear()

        ' Loop through each album and create controls to display them
        For Each a As Album In albums
            ' Create a new panel for each album
            Dim albumPanel As New RoundedPanel()
            albumPanel.Width = 200
            albumPanel.Height = 200
            albumPanel.Margin = New Padding(20)
            albumPanel.CornerRadius = 10 ' Set the corner radius

            ' Create and add a PictureBox for the album image
            Dim pb As New PictureBox()
            pb.Image = a.albumImage
            pb.Width = 180
            pb.Height = 180 ' Adjust the height to fit the panel properly
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Dock = DockStyle.Top
            albumPanel.Controls.Add(pb)

            ' Create and add a Label for the album name
            Dim titleLbl As New Label()
            titleLbl.Text = a.albumName
            titleLbl.Dock = DockStyle.Top
            titleLbl.TextAlign = ContentAlignment.MiddleCenter
            titleLbl.Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
            titleLbl.Padding = New Padding(0, 5, 0, 0) ' Add padding to give some space
            albumPanel.Controls.Add(titleLbl)

            ' Create and add a Label for the user name
            Dim userLbl As New Label()
            userLbl.Text = a.albumUserName
            userLbl.Dock = DockStyle.Top
            userLbl.TextAlign = ContentAlignment.MiddleCenter
            userLbl.Font = New Font("Microsoft YaHei UI", 8, FontStyle.Regular)
            userLbl.Padding = New Padding(0, 0, 0, 5) ' Add padding to give some space
            albumPanel.Controls.Add(userLbl)

            ' Assign the Tag property to store album information
            albumPanel.Tag = a

            ' Assign the click event handler to the panel and all its child controls
            AddHandler albumPanel.Click, AddressOf AlbumPanel_Click
            AddHandler pb.Click, AddressOf AlbumPanel_Click
            AddHandler titleLbl.Click, AddressOf AlbumPanel_Click
            AddHandler userLbl.Click, AddressOf AlbumPanel_Click

            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(albumPanel)
        Next
    End Sub

    Private Sub AlbumPanel_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked control, which might be the panel or any of its child controls
        Dim clickedControl As Control = DirectCast(sender, Control)
        ' Retrieve the parent panel that contains the album information
        Dim parentPanel As Panel = If(TypeOf clickedControl Is Panel, DirectCast(clickedControl, Panel), DirectCast(clickedControl.Parent, Panel))
        ' Retrieve the album information from the Tag property
        Dim a As Album = DirectCast(parentPanel.Tag, Album)

        ' Create a new instance of SongForm and pass the Home instance
        Dim songForm As New SongForm(home)


        ' Define the SQL query with the INNER JOIN on the Albums table
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
            INNER JOIN 
                dbo.Albums al ON s.AlbumId = al.AlbumId
            WHERE 
                s.AlbumId = " & a.albumId & "  "

        ' Check for SQL errors
        If Not String.IsNullOrEmpty(songForm.sql.Exception) Then
            MsgBox(songForm.sql.Exception)
            Return
        End If

        ' Load the data in the SongForm and show it
        home.childForm(songForm)
        songForm.loadData(query)
    End Sub

    Private Sub Albums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        loadAlbumData("
            SELECT 
                u.UserName AS ArtistName,
                al.Title AS AlbumName,
                al.AlbumId as AlbumId
            FROM 
                Melodifydb.dbo.USERS u
            INNER JOIN 
                Melodifydb.dbo.ARTISTS ar ON u.UserId = ar.UserId
            INNER JOIN 
                Melodifydb.dbo.ALBUMS al ON ar.ArtistId = al.ArtistID
            WHERE 
                u.ArtistCheck = 1
        ")
    End Sub

    Private searchedText As String = ""

    Private Sub searchBtn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchBtn.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                ' If Enter key is pressed, store the text
                searchedText = searchBtn.Text
                searchBtn.Clear()

                ' Add parameter for the wildcard search
                Sql.AddParam("@searchedText", "%" & searchedText & "%")

                ' SQL query with wildcard search using LIKE operator
                Dim query As String = "
                SELECT 
                    u.UserName AS ArtistName,
                    al.Title AS AlbumName,
                    al.AlbumId as AlbumId
                FROM 
                    Melodifydb.dbo.USERS u
                INNER JOIN 
                    Melodifydb.dbo.ARTISTS ar ON u.UserId = ar.UserId
                INNER JOIN 
                    Melodifydb.dbo.ALBUMS al ON ar.ArtistId = al.ArtistID
                WHERE 
                    u.ArtistCheck = 1
                    AND al.Title LIKE @searchedText
            "

                ' Load the album data with the query
                loadAlbumData(query)
                e.Handled = True ' To prevent the ding sound when Enter is pressed
            Catch ex As Exception
                ' Display any runtime errors
                MsgBox("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub



End Class
