Public Class ArtistSignup
    Private sql As New SQLControl
    Private settingsForm As Setting ' Reference to Setting form
    Public Sub New(ByRef settings As Setting)
        InitializeComponent()
        settingsForm = settings
    End Sub
    Private Function SignUp() As Boolean
        If String.IsNullOrEmpty(BioTxt.Text) Or String.IsNullOrEmpty(GenreTxt.Text) Then
            MsgBox("Please fill up all your information.")
            Return False
        End If
        sql.AddParam("@user", userId)
        sql.AddParam("@Bio", BioTxt.Text)
        sql.AddParam("@Genre", GenreTxt.Text)
        sql.ExecQuery("INSERT INTO ARTISTS (UserId, ArtistBIO, Genre) VALUES (@user, @Bio, @Genre)")
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return False
        End If
        ' Retrieve ArtistId
        sql.SQLDS.Clear()
        sql.AddParam("@user", userId)
        sql.ExecQuery("SELECT ArtistId FROM ARTISTS WHERE UserId = @user")
        If sql.RecordCount = 1 Then
            artistId = Convert.ToInt32(sql.SQLDS.Tables(0).Rows(0)("ArtistId"))
            MsgBox("Artist ID: " & artistId)
        Else
            MsgBox("No ArtistId found for this user.")
            Return False
        End If
        Return True
    End Function
    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        If SignUp() Then
            ' Update Users table to set ArtistCheck = 1
            sql.AddParam("@user", userId)
            sql.ExecQuery("UPDATE Users SET ArtistCheck = 1 WHERE UserId = @user")
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MsgBox("Error updating Users table: " & sql.Exception)
                Exit Sub ' Exit if there's an error
            End If
            ' Insert into ARTISTS table
            sql.AddParam("@user", userId)
            sql.AddParam("@Bio", BioTxt.Text)
            sql.AddParam("@Genre", GenreTxt.Text)
            sql.ExecQuery("INSERT INTO ARTISTS (UserId, ArtistBIO, Genre) VALUES (@user, @Bio, @Genre)")
            If Not String.IsNullOrEmpty(sql.Exception) Then
                MsgBox("Error inserting into ARTISTS table: " & sql.Exception)
                Exit Sub ' Exit if there's an error
            End If
            ' Update visibility in the existing instance of Setting form
            settingsForm.buttonVisible()
            settingsForm.Refresh() ' Optional: Refresh the form if needed
            Me.Close()
        Else
            MsgBox("Failed to sign up.")
        End If
    End Sub
    Private Sub ArtistSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(userId)
    End Sub
End Class
