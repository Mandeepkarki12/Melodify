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
        sql.ExecQuery("SELECT UserName " & "FROM USERS WHERE UserName = @User AND Password = @Password COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS")
        If sql.RecordCount = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If authentication() = True Then
            Dim home As New Home
            MsgBox("login Sucessfull")
            Me.Hide()
            home.Show()
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
End Class