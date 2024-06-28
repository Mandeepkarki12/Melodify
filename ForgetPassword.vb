Imports System.Net
Imports System.Net.Mail
Imports System.Net.WebRequestMethods
Imports System.Security.Cryptography

Public Class ForgetPassword
    Private sql As New SQLControl

    Private Sub ForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel2.Hide()
    End Sub
    Private Function GenerateRandomNumber() As Integer
        ' Create a new instance of the Random class
        Dim rnd As New Random()
        ' Generate a random number between 4 and 9 (inclusive)
        Dim randomNumber As Integer = rnd.Next(4, 8)
        ' Return the generated number
        Return randomNumber
    End Function
    Private Function GenerateOTP(length As Integer) As Integer
        ' Ensure the length is within a reasonable range
        If length <= 0 OrElse length > 9 Then
            Throw New ArgumentException("OTP length should be between 1 and 9")
        End If
        Dim otp As Integer = 0
        Dim multiplier As Integer = 1
        ' Use a secure random number generator
        Using rng As New RNGCryptoServiceProvider()
            For i As Integer = 1 To length
                ' Generate a random byte
                Dim buffer As Byte() = New Byte(0) {}
                rng.GetBytes(buffer)
                ' Convert byte to a digit (0-9)
                Dim digit As Integer = buffer(0) Mod 10
                ' Calculate the OTP by adding the digit to the appropriate place value
                otp += digit * multiplier
                multiplier *= 10
            Next
        End Using
        ' Return the generated OTP as an integer
        Return otp
    End Function
    Private otpNum As Integer
    Private Function send() As Integer
        Dim otp As Integer = GenerateOTP(GenerateRandomNumber())
        Return otp
    End Function
    Private Sub SendEmail(toAddress As String, subject As String, body As String)
        Try
            Dim mail As New MailMessage()
            ' Set the sender address
            mail.From = New MailAddress("melodify823@gmail.com")
            ' Set the recipient address
            mail.To.Add(toAddress)
            ' Set the subject
            mail.Subject = subject
            ' Set the body
            mail.Body = body
            ' Set the body format to HTML (optional)
            mail.IsBodyHtml = True
            ' Configure the SMTP client
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            ' Use your email and App Password
            Dim email As String = "melodify823@gmail.com"
            Dim appPassword As String = "uwpm xtwl oyad eovr" ' Replace this with your App Password
            ' Set the credentials
            smtp.Credentials = New NetworkCredential(email, appPassword)
            ' Send the email
            smtp.Send(mail)
            MsgBox("Email sent successfully.")
        Catch ex As SmtpException
            MsgBox("SMTP error occurred while sending the email: " & ex.Message)
        Catch ex As FormatException
            MsgBox("Invalid email address format: " & ex.Message)
        Catch ex As Exception
            MsgBox("An error occurred while sending the email: " & ex.Message)
        End Try
    End Sub
    Private Sub GetStartedButton_Click_1(sender As Object, e As EventArgs) Handles GetStartedButton.Click
        If String.IsNullOrEmpty(TxtUsername.Text) Or String.IsNullOrEmpty(TxtEmail.Text) Then
            MsgBox("Please Fill Your Information !")
            Exit Sub
        End If
        If authentication() = True Then
            otpNum = send()
            Dim subject As String = "Melodify OTP"
            Dim body As String = "Please Donot Share this Otp to Other's . Your Otp is :  " & otpNum & "."
            SendEmail(TxtEmail.Text, subject, body)
            Guna2Panel2.Show()
            Guna2Panel1.Hide()
        Else
            MsgBox("Wrong Email Or Username !!")
        End If
    End Sub
    Private Function authentication() As Boolean
        If sql.SQLDS IsNot Nothing Then
            sql.SQLDS.Clear()
        End If
        sql.AddParam("@User", TxtUsername.Text)
        sql.AddParam("@email", TxtEmail.Text)
        sql.ExecQuery("SELECT UserId " & "FROM USERS WHERE UserName = @User AND Email = @email COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS")
        If sql.RecordCount = 1 Then
            userName = TxtUsername.Text
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
    Private Sub GetStartedButton_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub OTPButton_Click(sender As Object, e As EventArgs) Handles OTPButton.Click
        If otpNum.ToString = TxtOTP.Text Then
            Dim changepass As New ChangePassword
            Me.Close()
            changepass.Show()
        Else
            MsgBox("Wrong Otp")
        End If
    End Sub
End Class