Imports System.Security.Cryptography
Public Class Form1
    Dim SQL As New SQLControl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.hasConnection = True Then
            LoadingTimer.Start()
        End If
    End Sub
    Private Sub CloseButtonB_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Dim TimerCount As Integer = 0
    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        TimerCount += 1
        If TimerCount = 5 Then
            LoadingTimer.Stop()
            LoadingTimer.Dispose()
            Me.Hide()
            Dim loginPage As New Login
            loginPage.Show()
        End If
    End Sub
End Class
