<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPlaylist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DescTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Melodify.My.Resources.Resources.playlist_add_svgrepo_com__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(233, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(129, 103)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'TitleTxt
        '
        Me.TitleTxt.BorderThickness = 2
        Me.TitleTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TitleTxt.DefaultText = ""
        Me.TitleTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TitleTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TitleTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TitleTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TitleTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.TitleTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TitleTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.TitleTxt.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.TitleTxt.Location = New System.Drawing.Point(149, 110)
        Me.TitleTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TitleTxt.PlaceholderText = " "
        Me.TitleTxt.SelectedText = ""
        Me.TitleTxt.Size = New System.Drawing.Size(318, 46)
        Me.TitleTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TitleTxt.TabIndex = 4
        Me.TitleTxt.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.LoginButton.Location = New System.Drawing.Point(203, 265)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(197, 45)
        Me.LoginButton.TabIndex = 7
        Me.LoginButton.Text = "Create"
        '
        'DescTxt
        '
        Me.DescTxt.BorderThickness = 2
        Me.DescTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescTxt.DefaultText = ""
        Me.DescTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DescTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DescTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.DescTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DescTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.DescTxt.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.DescTxt.Location = New System.Drawing.Point(149, 184)
        Me.DescTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DescTxt.Name = "DescTxt"
        Me.DescTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescTxt.PlaceholderText = " "
        Me.DescTxt.SelectedText = ""
        Me.DescTxt.Size = New System.Drawing.Size(318, 46)
        Me.DescTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.DescTxt.TabIndex = 8
        Me.DescTxt.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(580, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(37, 29)
        Me.Guna2ControlBox1.TabIndex = 9
        '
        'AddPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(616, 344)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.DescTxt)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.TitleTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPlaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPlaylist"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DescTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
