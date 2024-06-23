Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedPanel
    Inherits Panel

    Private _cornerRadius As Integer = 20

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As GraphicsPath = GetRoundedRect(rect, _cornerRadius)

        Me.Region = New Region(path)

        Using pen As New Pen(Me.BackColor, 0)
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        Dim diameter As Integer = radius * 2
        Dim arcRect As New Rectangle(rect.Location, New Size(diameter, diameter))

        ' Top left arc
        path.AddArc(arcRect, 180, 90)

        ' Top right arc
        arcRect.X = rect.Right - diameter
        path.AddArc(arcRect, 270, 90)

        ' Bottom right arc
        arcRect.Y = rect.Bottom - diameter
        path.AddArc(arcRect, 0, 90)

        ' Bottom left arc
        arcRect.X = rect.Left
        path.AddArc(arcRect, 90, 90)

        path.CloseFigure()

        Return path
    End Function
End Class
