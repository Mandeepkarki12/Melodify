Imports Melodify.SongForm
Imports System.IO

Public Class Artist
    Private sql As New SQLControl
    Private home As Home ' Declare a variable to hold the passed Home instance

    ' Modify the constructor to accept a Home instance
    Public Sub New(homeInstance As Home)
        InitializeComponent()
        home = homeInstance ' Assign the passed Home instance to the variable
    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
    Public Class ArtistInfo
        Public artistName As String
        Public artistBio As String
        Public artistImage As Image
    End Class
    Private Function ArtistsList(query As String) As List(Of ArtistInfo)
        Dim ArtisL As New List(Of ArtistInfo)() ' Initialize the list
        sql.ExecQuery(query)
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return ArtisL ' Return the empty list if there is an exception
        End If
        For Each row As DataRow In sql.SQLDS.Tables(0).Rows
            Dim artis As New ArtistInfo()
            artis.artistName = Convert.ToString(row("ArtistName"))
            artis.artistBio = Convert.ToString(row("ArtistBio"))
            Dim buffer As Byte() = DirectCast(row("ArtistImage"), Byte())
            If buffer IsNot Nothing Then
                Using ms As New MemoryStream(buffer, 0, buffer.Length)
                    ms.Write(buffer, 0, buffer.Length)
                    artis.artistImage = System.Drawing.Image.FromStream(ms, True)
                End Using
            End If
            ArtisL.Add(artis)
        Next
        Return ArtisL
    End Function

    Private Sub loadArtistData(query As String)
        ' Get the list of artists from the database
        Dim artists As List(Of ArtistInfo) = ArtistsList(query)
        ' Clear any existing controls in the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Clear()

        ' Loop through each artist and create controls to display them
        For Each a As ArtistInfo In artists
            ' Create a new panel for each artist
            Dim artistPanel As New RoundedPanel()
            artistPanel.Width = 615
            artistPanel.Height = 100
            artistPanel.Margin = New Padding(20)
            artistPanel.CornerRadius = 10 ' Set the corner radius

            ' Create and add a PictureBox for the artist image
            Dim pb As New PictureBox()
            If a.artistImage IsNot Nothing Then
                pb.Image = a.artistImage
                pb.Width = 80
                pb.Height = 80
                pb.SizeMode = PictureBoxSizeMode.StretchImage
                pb.Location = New Point(10, 10) ' Set the location within the panel
                artistPanel.Controls.Add(pb)
            End If

            ' Create and add a Label for the artist name
            Dim nameLbl As New Label()
            nameLbl.Text = a.artistName
            nameLbl.Location = New Point(100, 10) ' Set the location to the right of the PictureBox
            nameLbl.TextAlign = ContentAlignment.MiddleLeft
            nameLbl.Font = New Font("Microsoft YaHei UI", 10, FontStyle.Bold)
            artistPanel.Controls.Add(nameLbl)

            ' Create and add a Label for the artist bio
            Dim bioLbl As New Label()
            bioLbl.Text = a.artistBio
            bioLbl.Location = New Point(100, 35) ' Set the location below the nameLbl
            bioLbl.TextAlign = ContentAlignment.MiddleLeft
            bioLbl.Font = New Font("Microsoft YaHei UI", 8, FontStyle.Regular)
            bioLbl.Width = 500 ' Ensure the label has enough width for the bio text
            bioLbl.Height = 50 ' Ensure the label has enough height for the bio text
            artistPanel.Controls.Add(bioLbl)

            ' Assign the Tag property to store artist information
            artistPanel.Tag = a

            ' Assign the click event handler to the panel and all its child controls
            AddHandler artistPanel.Click, AddressOf ArtistPanel_Click
            AddHandler pb.Click, AddressOf ArtistPanel_Click
            AddHandler nameLbl.Click, AddressOf ArtistPanel_Click
            AddHandler bioLbl.Click, AddressOf ArtistPanel_Click

            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(artistPanel)
        Next
    End Sub

    Private Sub ArtistPanel_Click(sender As Object, e As EventArgs)
        ' Retrieve the clicked control, which might be the panel or any of its child controls
        Dim clickedControl As Control = DirectCast(sender, Control)
        ' Retrieve the parent panel that contains the artist information
        Dim parentPanel As Panel = If(TypeOf clickedControl Is Panel, DirectCast(clickedControl, Panel), DirectCast(clickedControl.Parent, Panel))
        ' Retrieve the artist information from the Tag property
        Dim a As ArtistInfo = DirectCast(parentPanel.Tag, ArtistInfo)
        ' Display or process the artist information as needed
        MsgBox("Artist: " & a.artistName & vbCrLf & "Bio: " & a.artistBio)
    End Sub

    Private Sub Artist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        loadArtistData("SELECT 
    u.UserName AS ArtistName,
    a.ArtistBio,
    u.ProfilePicture AS ArtistImage
FROM 
    Melodifydb.dbo.USERS u
INNER JOIN 
    Melodifydb.dbo.ARTISTS a ON u.UserId = a.UserId
WHERE 
    u.ArtistCheck = 1
")


    End Sub
    Private searchedText As String = ""
    Private Sub searchBtn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchBtn.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' If Enter key is pressed, store the text
            Dim searchedText As String = searchBtn.Text
            searchBtn.Clear()
            sql.AddParam("@searchedText", searchedText)

            Dim query As String = "
        SELECT 
            u.UserName AS ArtistName,
            a.ArtistBio,
            u.ProfilePicture AS ArtistImage
        FROM 
            Melodifydb.dbo.USERS u
        INNER JOIN 
            Melodifydb.dbo.ARTISTS a ON u.UserId = a.UserId
        WHERE 
            u.ArtistCheck = 1 AND 
            (u.UserName LIKE '%' + @searchedText + '%' OR a.ArtistBio LIKE '%' + @searchedText + '%')"

            ' Load the data with the new query
            loadArtistData(query)

            e.Handled = True ' To prevent the ding sound when Enter is pressed
        End If
    End Sub
End Class