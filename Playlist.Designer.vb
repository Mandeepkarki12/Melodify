<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Playlist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 100)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1005, 512)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'LoginButton
        '
        Me.LoginButton.BorderRadius = 5
        Me.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Image = Global.Melodify.My.Resources.Resources.LoginIcon1
        Me.LoginButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LoginButton.Location = New System.Drawing.Point(22, 21)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(269, 51)
        Me.LoginButton.TabIndex = 7
        Me.LoginButton.Text = "Add Playlist"
        '
        'Playlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 612)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.LoginButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Playlist"
        Me.Text = "Playlist"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2Button
End Class
