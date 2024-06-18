Imports Guna.UI2.WinForms
Public Class Login
    Public sql As New SQLControl
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Signin As New SignIn
        Me.Hide()
        Signin.Show()
    End Sub
    Public Function authentication() As Boolean
        If sql.SQLDS IsNot Nothing Then
            sql.SQLDS.Clear()
        End If
        sql.AddParam("@User", TxtUsername.Text)
        sql.AddParam("@Password", TxtPassword.Text)
        sql.ExecQuery("SELECT UserId " & "FROM USERS WHERE UserName = @User AND Password = @Password COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS")
        If sql.RecordCount = 1 Then
            userId = Convert.ToInt32(sql.SQLDS.Tables(0).Rows(0)("UserId"))
            MsgBox(userId)
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If authentication() Then
            MsgBox("Login Successful")
            Try
                ' Retrieve Artist ID
                sql.SQLDS.Clear()
                sql.AddParam("@user", userId)
                sql.ExecQuery("SELECT ArtistId FROM ARTISTS WHERE UserId = @user")

                If sql.RecordCount = 1 Then
                    artistId = Convert.ToInt32(sql.SQLDS.Tables(0).Rows(0)("ArtistId"))
                    MsgBox("Artist ID: " & artistId)
                Else
                    MsgBox("No artist ID found for this user.")
                End If
                ' Navigate to Home form
                Dim home As New Home
                Me.Hide()
                home.Show()

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            End Try

        Else
            MsgBox("Login Failed")
        End If
    End Sub


    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPass.CheckedChanged
        If ShowPass.Checked = True Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class