Imports System.ComponentModel
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports NAudio
Imports NAudio.Wave
Public Class Home
    Public Imagemusic As New Func
    Public Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Public myPlayer As IWavePlayer = New WaveOut()
    Public FileReader As AudioFileReader
    Public Files As String = "C:\Users\karki\Downloads\Farkanna Hola ( Official Lyrical Video ) #shotoniphone.mp3"
    Public volume As Single
    Public musicName As String
    Public singer As String
    Public volumes As Single = 0.5F
    Public Sql As New SQLControl
    Public Sub ClearSong()
        Try
            If myPlayer.PlaybackState = PlaybackState.Playing Then
                myPlayer.Stop()
            End If
            If FileReader IsNot Nothing Then
                FileReader.Dispose()
                FileReader = Nothing
            End If
            Files = String.Empty
            Guna2TrackBar1.Value = 0 ' Reset the trackbar position
        Catch ex As Exception
            ' Handle exceptions if needed
        End Try
    End Sub
    Public Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel11.Hide()
        Imagemusic.LoadImage(Guna2CirclePictureBox2, userId)
        ' track
        Guna2TrackBar1.Minimum = 0
        Guna2TrackBar1.Maximum = 100
        Timer1.Interval = 100
        ' volume 
        Guna2TrackBar2.Minimum = 0
        Guna2TrackBar2.Maximum = 100
        Guna2TrackBar2.Value = 50
    End Sub
    Public Sub Guna2ImageButton15_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton15.Click
        If Guna2ImageButton15.Checked = True Then
            Guna2ImageButton15.Checked = False
        Else
            Guna2ImageButton15.Checked = True
        End If

        If myPlayer.PlaybackState = PlaybackState.Playing Then
            myPlayer.Pause()
        Else
            If FileReader Is Nothing Then
                FileReader = New AudioFileReader(Files)
                myPlayer.Init(FileReader)
                myPlayer.Volume = volumes ' Set initial volume
            End If
            myPlayer.Play()
            Timer1.Start() ' Start the timer when playback starts
        End If
    End Sub
    Public Sub Guna2TrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2TrackBar1.Scroll
        Try
            Dim positionInMilliseconds As Long = (FileReader.TotalTime.TotalMilliseconds / 100) * Guna2TrackBar1.Value
            FileReader.CurrentTime = TimeSpan.FromMilliseconds(positionInMilliseconds)
        Catch ex As Exception

        End Try
    End Sub
   Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FileReader IsNot Nothing Then
            Dim positionPercentage As Double = (FileReader.CurrentTime.TotalMilliseconds / FileReader.TotalTime.TotalMilliseconds) * 100
            Guna2TrackBar1.Value = CInt(positionPercentage)
        End If
    End Sub

    Public Sub Guna2TrackBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2TrackBar2.Scroll
        volumes = Guna2TrackBar2.Value / 100.0F
        If myPlayer IsNot Nothing Then
            myPlayer.Volume = volumes
        End If
    End Sub

    Public Function getMusictemp(musicName As String) As String
        Try
            Sql.AddParam("@music", musicName)
            Dim query As String = "SELECT SongData FROM PreSongs WHERE Title = @music "
            Sql.ExecQuery(query)
            ' Check for exceptions
            If Not String.IsNullOrEmpty(Sql.Exception) Then
                MessageBox.Show("An error occurred during SQL query execution: " & Sql.Exception)
                Return Nothing
            End If

            If Sql.RecordCount > 0 Then
                Dim songData As Byte() = DirectCast(Sql.SQLDS.Tables(0).Rows(0)("SongData"), Byte())
                Dim tempFilePath As String = Path.GetTempFileName()
                File.WriteAllBytes(tempFilePath, songData)
                Return tempFilePath
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Sub displayMusictemp(picBox As Object, musicName As String, SingerName As String)
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = picBox
        Label34.Text = musicName
        Label33.Text = SingerName
        Files = getMusictemp(musicName)
    End Sub

    ' Popular songs Section :
    Public Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        'farkanna hola 
        displayMusictemp(Melodify.My.Resources.Resources.Farkanna_Hola, "Farkanna Hola", "John Chamling Rai")
    End Sub

    Public Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        'sunflower 
        displayMusictemp(Melodify.My.Resources.Resources.Sunflowefr, "Sunflower", "Post Malone")

    End Sub

    Public Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        ' Like That
        displayMusictemp(Melodify.My.Resources.Resources.LikeThat, "Like That", "Kendrik Lemar")
    End Sub

    Public Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox7.Click
        ' I Had Some Help
        displayMusictemp(Melodify.My.Resources.Resources.PostMalone, "I had Some Help", "Post Malone")
    End Sub

    Public Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        'Expresso
        displayMusictemp(Melodify.My.Resources.Resources.Espresso___Sabrina_Carpenter, "Espresso", "Sabrina Carpenter")
    End Sub

    Public Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        'Never Let Go
        displayMusictemp(Melodify.My.Resources.Resources.Never_Let_go, "Never Let Go", "Jeon JungKook")
    End Sub

    Public Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        ' like That
        displayMusictemp(Melodify.My.Resources.Resources.LikeThat, "Like That", "Kendrik Lemar")
    End Sub

    Public Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        ' vanana matra
        displayMusictemp(Melodify.My.Resources.Resources.vanana, "Vanana Matra", "John Chamling Rai")
    End Sub

    Public Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        'Dynamite
        displayMusictemp(Melodify.My.Resources.Resources.Dynamite, "Dynamite", "BTS")
    End Sub

    Public Sub Guna2ImageButton9_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton9.Click
        ' chitthi Bitra
        displayMusictemp(Melodify.My.Resources.Resources.Chitthi_bitra, "Chitthi Bhitra", "Sajjan Raj Vaidya")
    End Sub

    Public Sub Guna2ImageButton11_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton11.Click
        ' Pick It Up
        displayMusictemp(Melodify.My.Resources.Resources.PickItUpDexter, "Pick It Up", "Famous Dex")

    End Sub

    Public Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        ' Super Shy
        displayMusictemp(Melodify.My.Resources.Resources.SuperShy, "Super Shy", "New Jeans")
    End Sub

    Public Sub childForm(ByVal panel As Form)
        Guna2Panel11.Show()
        Guna2Panel11.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Guna2Panel11.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim artistForm As New Artist(Me)
        childForm(artistForm)
    End Sub

    Public Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim songForm As New SongForm(Me)
        childForm(songForm)
    End Sub

    Public Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim albumForm As New Albums(Me)
        childForm(albumForm)
    End Sub
    Public Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        childForm(Setting)
    End Sub
    Public Sub Guna2PictureBox14_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox14.Click

    End Sub
    Public Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Guna2Panel11.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim PlaylistForm As New Playlist(Me)
        childForm(PlaylistForm)
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim DownloadForm As New Download
        childForm(DownloadForm)
    End Sub
End Class
