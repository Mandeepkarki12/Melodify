Public Class Form1
    Dim SQL As New SQLControl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.hasConnection = True Then
            MsgBox("Connected Sucessfully !!")
        End If
    End Sub
End Class
