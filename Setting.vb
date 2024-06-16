Public Class Setting
    Dim sql As New SQLControl
    Public userName As String
    Private ArtistCheck As Boolean
    Public imageHandler As New ImageFunc
    Dim selectedFilePath As String
    Public Sub buttonVisible()
        sql.AddParam("@user", userId)
        sql.ExecQuery("SELECT UserName, ArtistCheck FROM USERS WHERE UserId = @user")

        If sql.RecordCount = 1 Then
            userName = Convert.ToString(sql.SQLDS.Tables(0).Rows(0)("UserName"))
            ArtistCheck = Convert.ToBoolean(sql.SQLDS.Tables(0).Rows(0)("ArtistCheck"))

            If ArtistCheck Then
                Guna2Button1.Visible = False
                Guna2Button2.Visible = True
            Else
                Guna2Button1.Visible = True
                Guna2Button2.Visible = False
            End If
        End If
    End Sub
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonVisible()
        getAlbums()
        Guna2Panel1.Hide()
        imageHandler.LoadImage(Guna2CirclePictureBox1, userId)
        Label1.Text = userName
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Artistsg As New ArtistSignup(Me) ' Pass reference to current instance
        Artistsg.Show()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' upload song button
        Guna2Panel1.Show()
    End Sub

    Public Sub getAlbums()
        sql.AddParam("@artist", artistId)
        sql.ExecQuery("SELECT Title FROM ALBUMS WHERE ArtistID = @artist")

        If sql.RecordCount > 0 Then
            For Each r As DataRow In sql.SQLDS.Tables(0).Rows
                Guna2ComboBox1.Items.Add(r("Title"))
            Next
            Guna2ComboBox1.SelectedIndex = 0
        ElseIf sql.Exception <> "" Then
            MsgBox(sql.Exception)
        End If
    End Sub
    Public Sub clearAlbum()
        Guna2ComboBox1.Items.Clear()
        sql.SQLDS.Clear()
    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim create As New CreateAlbum(Me)
        create.Show()
    End Sub
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the file dialog properties
        openFileDialog.Title = "Select a Music File"
        openFileDialog.Filter = "Music Files|*.mp3;*.wav;*.aac|All Files|*.*"
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        openFileDialog.Multiselect = False ' Allow only single file selection

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path and display it
            selectedFilePath = openFileDialog.FileName
            Guna2TextBox1.Text = selectedFilePath
        End If
    End Sub
    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        imageHandler.musicSave(selectedFilePath, Guna2ComboBox1, Guna2TextBox2)
    End Sub
End Class
