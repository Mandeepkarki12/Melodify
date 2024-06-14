Imports System.Diagnostics.Eventing.Reader
Public Class SignIn
    Public sql As New SQLControl
    Dim Gender As String = ""
    Private Function addUser() As Boolean
        If String.IsNullOrEmpty(TxtEmail.Text) Or String.IsNullOrEmpty(TxtUsername.Text) Or String.IsNullOrEmpty(TxtPassword.Text) Then
            MsgBox("Please fillup your all information")
            Return False
        End If
        If MaleButton.Checked = False And FemaleButton.Checked = False Then
            MsgBox("Please fillup your all information")
            Return False
        End If
        sql.AddParam("@email", TxtEmail.Text)
        sql.AddParam("@user", TxtUsername.Text)
        sql.AddParam("@password", TxtPassword.Text)
        sql.AddParam("@gender", Gender)
        sql.ExecQuery("INSERT INTO USERS (UserName, Password , Email , Gender ) VALUES (@user,@password,@email,@gender)")
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return False
        End If
        Return True
    End Function
    Private Sub GetStartedButton_Click(sender As Object, e As EventArgs) Handles GetStartedButton.Click
        If addUser() = True Then
            MsgBox("User added Sucessfully")
            Me.Hide()
            Dim login As New Login
            login.Show()
        Else
            MsgBox("Failed to add user")
        End If
    End Sub
    Private Sub MaleButton_CheckedChanged(sender As Object, e As EventArgs) Handles MaleButton.CheckedChanged
        Gender = "Male"
    End Sub
    Private Sub FemaleButton_CheckedChanged(sender As Object, e As EventArgs) Handles FemaleButton.CheckedChanged
        Gender = "Female"
    End Sub
    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPass.CheckedChanged
        If ShowPass.Checked = True Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()

    End Sub

End Class