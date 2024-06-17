Imports System.ComponentModel
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports NAudio
Imports NAudio.Wave
Public Class Home
    Public Imagemusic As New Func
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Private myPlayer As IWavePlayer = New WaveOut()
    Private FileReader As AudioFileReader
    Private Files As String = "C:\Users\karki\Downloads\Farkanna Hola ( Official Lyrical Video ) #shotoniphone.mp3"
    Private volume As Single
    Private musicName As String
    Private singer As String
    Private volumes As Single = 0.5F
    Private Sub ClearSong()
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
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub Guna2ImageButton15_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton15.Click
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
    Private Sub Guna2TrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2TrackBar1.Scroll
        Try
            Dim positionInMilliseconds As Long = (FileReader.TotalTime.TotalMilliseconds / 100) * Guna2TrackBar1.Value
            FileReader.CurrentTime = TimeSpan.FromMilliseconds(positionInMilliseconds)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FileReader IsNot Nothing Then
            Dim positionPercentage As Double = (FileReader.CurrentTime.TotalMilliseconds / FileReader.TotalTime.TotalMilliseconds) * 100
            Guna2TrackBar1.Value = CInt(positionPercentage)
        End If
    End Sub
    Private Sub Guna2TrackBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2TrackBar2.Scroll
        volumes = Guna2TrackBar2.Value / 100.0F
        If myPlayer IsNot Nothing Then
            myPlayer.Volume = volumes
        End If
    End Sub
    ' Popular songs Section :
    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        'farkanna hola 
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.Farkanna_Hola
        musicName = "Farkanna Hola"
        singer = "John Chamling Rai"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Farkanna Hola ( Official Lyrical Video ) #shotoniphone.mp3"
    End Sub
    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        'sunflower 
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.Sunflowefr
        musicName = "Sunflower"
        singer = "Post Malone"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Post Malone, Swae Lee - Sunflower (Spider-Man_ Into the Spider-Verse).mp3"
    End Sub
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        ' Like That
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.LikeThat
        musicName = "Like That"
        singer = "Kendrik Lemar"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Future, Metro Boomin - Like That (Official Audio).mp3"
    End Sub
    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox7.Click
        ' I Had Some Help
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.PostMalone
        musicName = "I Had Some Help"
        singer = "Post Malone"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Post Malone ft. Morgan Wallen - I Had Some Help (Official Lyric Video).mp3"
    End Sub
    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        'Expresso
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.Espresso___Sabrina_Carpenter
        musicName = "Expresso"
        singer = "Sabrina Carpenter"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Sabrina Carpenter - Espresso (Official Video).mp3"
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        'Never Let Go
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.Never_Let_go
        musicName = "Never Let Go"
        singer = "Jeon Jungkook"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Jung Kook (정국) 'Never Let Go' Lyrics.mp3"
    End Sub
    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        ' like That
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.LikeThat
        musicName = "Like That"
        singer = "Kendrik Lemar"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Future, Metro Boomin - Like That (Official Audio).mp3"
    End Sub
    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        ' vanana matra
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.vanana
        musicName = "Vanana Matra"
        singer = "John Champling Rai"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Vanana Matra.mp3"
    End Sub
    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        'Dynamite
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.Dynamite
        musicName = "Dynamite"
        singer = "BTS"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\BTS (방탄소년단) 'Dynamite' Official MV.mp3"
    End Sub
    Private Sub Guna2ImageButton9_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton9.Click
        ' chitthi Bitra
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.Chitthi_bitra
        musicName = "Chitthi Bitra"
        singer = "Sajjan Raj Vaidya"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Sajjan Raj Vaidya - Chitthi Bhitra [Official Release].mp3"
    End Sub
    Private Sub Guna2ImageButton11_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton11.Click
        ' Pick It Up
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.PickItUpDexter
        musicName = "Pick It Up"
        singer = "Famous Dex"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\Famous Dex - Pick It Up ft. ASAP Rocky (Official Audio).mp3"
    End Sub
    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        ' Super Shy
        Guna2ImageButton15.Checked = False
        ClearSong()
        Files = ""
        Guna2PictureBox14.Image = Melodify.My.Resources.Resources.SuperShy
        musicName = "Super Shy"
        singer = "New Jeans"
        Label34.Text = musicName
        Label33.Text = singer
        Files = "C:\Users\karki\Downloads\NewJeans - Super Shy (Lyrics).mp3"
    End Sub
    Sub childForm(ByVal panel As Form)
        Guna2Panel11.Show()
        Guna2Panel11.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Guna2Panel11.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        childForm(Artist)
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        childForm(Song)
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        childForm(Albums)
    End Sub
    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        childForm(Setting)
    End Sub
End Class
