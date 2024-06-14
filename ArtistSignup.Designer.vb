<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtistSignup
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
        Me.Guna2ImageButton20 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GenreTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BioTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Bio = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.SignUpButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ImageButton20
        '
        Me.Guna2ImageButton20.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton20.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton20.HoverState.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton20.Image = Global.Melodify.My.Resources.Resources.Account1
        Me.Guna2ImageButton20.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton20.ImageRotate = 0!
        Me.Guna2ImageButton20.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton20.Location = New System.Drawing.Point(194, 22)
        Me.Guna2ImageButton20.Name = "Guna2ImageButton20"
        Me.Guna2ImageButton20.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton20.Size = New System.Drawing.Size(80, 65)
        Me.Guna2ImageButton20.TabIndex = 23
        Me.Guna2ImageButton20.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Genre"
        '
        'GenreTxt
        '
        Me.GenreTxt.BorderThickness = 2
        Me.GenreTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GenreTxt.DefaultText = ""
        Me.GenreTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GenreTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GenreTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GenreTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GenreTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.GenreTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GenreTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.GenreTxt.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.GenreTxt.Location = New System.Drawing.Point(111, 114)
        Me.GenreTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GenreTxt.Name = "GenreTxt"
        Me.GenreTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GenreTxt.PlaceholderText = ""
        Me.GenreTxt.SelectedText = ""
        Me.GenreTxt.Size = New System.Drawing.Size(300, 34)
        Me.GenreTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.GenreTxt.TabIndex = 25
        Me.GenreTxt.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BioTxt
        '
        Me.BioTxt.BorderThickness = 2
        Me.BioTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BioTxt.DefaultText = ""
        Me.BioTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BioTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BioTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BioTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BioTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.BioTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BioTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BioTxt.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.BioTxt.Location = New System.Drawing.Point(111, 179)
        Me.BioTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BioTxt.Name = "BioTxt"
        Me.BioTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BioTxt.PlaceholderText = ""
        Me.BioTxt.SelectedText = ""
        Me.BioTxt.Size = New System.Drawing.Size(300, 34)
        Me.BioTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.BioTxt.TabIndex = 27
        Me.BioTxt.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Bio
        '
        Me.Bio.AutoSize = True
        Me.Bio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bio.Location = New System.Drawing.Point(54, 185)
        Me.Bio.Name = "Bio"
        Me.Bio.Size = New System.Drawing.Size(30, 18)
        Me.Bio.TabIndex = 26
        Me.Bio.Text = "Bio"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(410, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(49, 37)
        Me.Guna2ControlBox1.TabIndex = 28
        '
        'SignUpButton
        '
        Me.SignUpButton.BorderRadius = 5
        Me.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SignUpButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.SignUpButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpButton.ForeColor = System.Drawing.Color.White
        Me.SignUpButton.Image = Global.Melodify.My.Resources.Resources.LoginIcon1
        Me.SignUpButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SignUpButton.Location = New System.Drawing.Point(164, 245)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(151, 39)
        Me.SignUpButton.TabIndex = 29
        Me.SignUpButton.Text = "SignUp"
        '
        'ArtistSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(457, 312)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.BioTxt)
        Me.Controls.Add(Me.Bio)
        Me.Controls.Add(Me.GenreTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ImageButton20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "ArtistSignup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArtistSignup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ImageButton20 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BioTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Bio As Label
    Friend WithEvents GenreTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents SignUpButton As Guna.UI2.WinForms.Guna2Button
End Class
