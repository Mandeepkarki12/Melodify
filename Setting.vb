Imports Guna.UI2.WinForms
Public Class Setting
    Dim sql As New SQLControl
    Public userName As String
    Private ArtistCheck As Boolean
    Public ImageMusic As New Func
    Dim selectedFilePath As String
    Dim emailName As String
    Dim filepath As String = ""
    Public Sub buttonVisible()
        sql.AddParam("@user", userId)
        sql.ExecQuery("SELECT UserName, ArtistCheck , Email FROM USERS WHERE UserId = @user")
        If sql.RecordCount = 1 Then
            userName = Convert.ToString(sql.SQLDS.Tables(0).Rows(0)("UserName"))
            emailName = Convert.ToString(sql.SQLDS.Tables(0).Rows(0)("Email"))
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
        If userId > 0 Then
            ' If user is logged in, load user-specific data
            buttonVisible()
            getAlbums()
            Guna2Panel1.Hide()
            ImageMusic.LoadImage(Guna2CirclePictureBox1, userId)
            Label1.Text = userName
            Label2.Text = emailName
        Else
            ' If no user is logged in, reset UI elements
            Guna2Button1.Visible = False
            Guna2Button2.Visible = False
            Guna2ComboBox1.Items.Clear()
            Guna2TextBox1.Clear()
            Guna2TextBox2.Clear()
            Guna2Panel1.Hide()
            Label1.Text = "Guest"
        End If
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
    Private Sub getAlbumID(txt As Guna2ComboBox)
        Try
            sql.AddParam("@AlbumName", txt.Text)
            sql.ExecQuery("SELECT AlbumID FROM ALBUMS WHERE Title = @AlbumName")
            If sql.RecordCount = 1 Then
                albumId = Convert.ToInt32(sql.SQLDS.Tables(0).Rows(0)("AlbumID"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
        If String.IsNullOrEmpty(filepath) Or String.IsNullOrEmpty(Guna2TextBox1.Text) Or String.IsNullOrEmpty(Guna2TextBox2.Text) Or String.IsNullOrEmpty(Guna2ComboBox1.Text) Then
            MsgBox("Fill all the information !!")
        Else
            getAlbumID(Guna2ComboBox1)
            ImageMusic.musicSave(selectedFilePath, Guna2ComboBox1, Guna2TextBox2, filepath)
            Guna2Panel1.Hide()
            Guna2TextBox1.Clear()
            Guna2TextBox2.Clear()
        End If
    End Sub
    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        logout()
    End Sub
    Private Sub logout()
        ' Reset user IDs
        userId = 0
        artistId = 0
        ' Get the parent form (Home)
        Dim homeForm As Home = TryCast(Me.ParentForm, Home)
        If homeForm IsNot Nothing Then
            ' Close the Home form
            homeForm.Close()
        End If
        ' Show the Login form
        Dim loginForm As New Login()
        loginForm.Show()
        ' Close the current Setting form
        Me.Close()
    End Sub
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete your Account ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            delUsers()
        Else
            ' Optionally, handle the case where the user chooses No
            MessageBox.Show("Operation canceled.")
        End If
    End Sub
    Private Sub delUsers()
        If artistId > 0 Then
            ' Delete songs associated with the artist
            sql.AddParam("@artist", artistId)
            sql.ExecQuery("DELETE FROM SONGS WHERE ArtistID = @artist")
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MsgBox(sql.Exception)
            End If

            ' Delete albums associated with the artist
            sql.AddParam("@artist", artistId)
            sql.ExecQuery("DELETE FROM ALBUMS WHERE ArtistID = @artist")
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MsgBox(sql.Exception)
            End If
            ' Delete artist record
            sql.AddParam("@user", userId)
            sql.ExecQuery("DELETE FROM ARTISTS WHERE UserID = @user")
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MsgBox(sql.Exception)
            End If
        End If
        ' Delete user record
        sql.AddParam("@user", userId)
        sql.ExecQuery("DELETE FROM USERS WHERE UserId = @user")
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
        Else
            MsgBox("User Deleted Successfully !!")
            ' Reset user and artist IDs
            userId = 0
            artistId = 0
            ' Clear any cached data
            clearAlbum()
            sql.SQLDS.Clear()
            logout()
        End If
    End Sub

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
        openFileDialog1.Title = "Select an Image File"
        ' Show the dialog and check if the user clicked OK
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog1.FileName
            ' Load the selected image into PictureBox
            Try
                Dim img As Image = Image.FromFile(filePath)
                Guna2CirclePictureBox2.Image = img
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
