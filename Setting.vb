Public Class Setting
    Dim sql As New SQLControl
    Public userName As String
    Private ArtistCheck As Boolean
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.AddParam("@user", userId)
        sql.ExecQuery("SELECT UserName , ArtistCheck FROM USERS WHERE UserId = @user")
        If sql.RecordCount = 1 Then
            userName = Convert.ToString(sql.SQLDS.Tables(0).Rows(0)("UserName"))
            ArtistCheck = Convert.ToBoolean(sql.SQLDS.Tables(0).Rows(0)("ArtistCheck"))
        End If
        If ArtistCheck Then
            Guna2Button1.Hide()
        Else
            Guna2Button1.Show()
        End If
        Label1.Text = userName
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Artistsg As New ArtistSignup
        Artistsg.Show()
    End Sub


End Class