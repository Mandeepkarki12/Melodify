Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports NAudio.Midi
Public Class SignIn
    Public sql As New SQLControl
    Dim Gender As String = ""
    Dim filePath As String = ""
    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
        openFileDialog1.Title = "Select an Image File"
        ' Show the dialog and check if the user clicked OK
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog1.FileName
            ' Load the selected image into PictureBox
            Try
                Dim img As Image = Image.FromFile(filePath)
                Guna2CirclePictureBox1.Image = img
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Function addUser(path As String) As Boolean
        If String.IsNullOrEmpty(TxtEmail.Text) Or String.IsNullOrEmpty(TxtUsername.Text) Or String.IsNullOrEmpty(TxtPassword.Text) Or String.IsNullOrEmpty(filePath) Then
            MsgBox("Please fillup your all information")
            Return False
        End If
        If MaleButton.Checked = False And FemaleButton.Checked = False Then
            MsgBox("Please fillup your all information")
            Return False
        End If
        Dim img As Image = Image.FromFile(path)
        Dim ms As New MemoryStream()
        img.Save(ms, img.RawFormat)
        Dim buffer As Byte() = ms.GetBuffer
        sql.AddParam("@image", buffer)
        sql.AddParam("@email", TxtEmail.Text)
        sql.AddParam("@user", TxtUsername.Text)
        sql.AddParam("@password", TxtPassword.Text)
        sql.AddParam("@gender", Gender)
        sql.ExecQuery("INSERT INTO USERS (UserName, Password , Email , Gender , ProfilePicture ) VALUES (@user,@password,@email,@gender ,@image)")
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return False
        End If
        Return True
    End Function
    Private Sub GetStartedButton_Click(sender As Object, e As EventArgs) Handles GetStartedButton.Click
        If addUser(filePath) = True Then
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