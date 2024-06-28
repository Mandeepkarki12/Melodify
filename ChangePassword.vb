Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Public Class ChangePassword
    Private sql As New SQLControl
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2CirclePictureBox2.Image = loadImage()
    End Sub
    Private Function loadImage() As Image
        Dim pic As Image
        sql.AddParam("@user", userName)
        sql.ExecQuery("SELECT ProfilePicture FROM USERS WHERE UserName=@user")
        Dim buffer As Byte() = DirectCast((sql.SQLDS.Tables(0).Rows(0)("ProfilePicture")), Byte())
        If buffer IsNot Nothing Then
            Using ms As New MemoryStream(buffer, 0, buffer.Length)
                ms.Write(buffer, 0, buffer.Length)
                pic = System.Drawing.Image.FromStream(ms, True)
            End Using
        End If
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return Nothing
        End If
        Return pic
    End Function
    Private Sub OTPButton_Click(sender As Object, e As EventArgs) Handles OTPButton.Click
        If String.IsNullOrEmpty(TxtPassword.Text) Or String.IsNullOrEmpty(Guna2TextBox1.Text) Then
            MsgBox("Please FillUp Information !!")
            Exit Sub
        End If
        If check() = True And changeDone() = True Then
            MsgBox("Password Changed Sucessfully !!")
            Dim login As New Login
            Me.Close()
            login.Show()
        Else
            MsgBox("Password didnt matched !")
        End If
    End Sub
    Private Function changeDone() As Boolean
        sql.AddParam("@pass", TxtPassword.Text)
        sql.AddParam("@user", userName)
        sql.ExecQuery("UPDATE USERS SET password=@pass WHERE UserName =@user")
        If Not String.IsNullOrEmpty(sql.Exception) Then
            MsgBox(sql.Exception)
            Return False
        End If
        Return True
    End Function
    Private Function check() As Boolean
        If TxtPassword.Text = Guna2TextBox1.Text Then
            Return True
        Else
            Return False
        End If
    End Function
End Class