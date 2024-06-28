<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
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
        Me.ShowPass = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaleButton = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GetStartedButton = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FemaleButton = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'ShowPass
        '
        Me.ShowPass.AutoSize = True
        Me.ShowPass.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPass.Location = New System.Drawing.Point(775, 403)
        Me.ShowPass.Name = "ShowPass"
        Me.ShowPass.Size = New System.Drawing.Size(144, 24)
        Me.ShowPass.TabIndex = 9
        Me.ShowPass.Text = "Show Password"
        Me.ShowPass.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(606, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gender : "
        '
        'MaleButton
        '
        Me.MaleButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaleButton.CheckedState.BorderThickness = 0
        Me.MaleButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaleButton.CheckedState.InnerColor = System.Drawing.Color.White
        Me.MaleButton.Location = New System.Drawing.Point(747, 463)
        Me.MaleButton.Name = "MaleButton"
        Me.MaleButton.Size = New System.Drawing.Size(16, 29)
        Me.MaleButton.TabIndex = 16
        Me.MaleButton.Text = "MaleButton"
        Me.MaleButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.MaleButton.UncheckedState.BorderThickness = 2
        Me.MaleButton.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.MaleButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(972, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 20
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Image = Global.Melodify.My.Resources.Resources.LogoName1
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(-1, 12)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(583, 576)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox2.TabIndex = 21
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Guna2CirclePictureBox1.Image = Global.Melodify.My.Resources.Resources.image_plus_svgrepo_com
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(705, 46)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(109, 105)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 19
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.Melodify.My.Resources.Resources.FemaleIcon
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(788, 461)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(30, 31)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 17
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Melodify.My.Resources.Resources.MaleIcon
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(711, 461)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(36, 34)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 14
        Me.Guna2PictureBox1.TabStop = False
        '
        'GetStartedButton
        '
        Me.GetStartedButton.BorderRadius = 5
        Me.GetStartedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GetStartedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GetStartedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GetStartedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GetStartedButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.GetStartedButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GetStartedButton.ForeColor = System.Drawing.Color.White
        Me.GetStartedButton.Image = Global.Melodify.My.Resources.Resources.LoginIcon1
        Me.GetStartedButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GetStartedButton.Location = New System.Drawing.Point(653, 543)
        Me.GetStartedButton.Name = "GetStartedButton"
        Me.GetStartedButton.Size = New System.Drawing.Size(238, 45)
        Me.GetStartedButton.TabIndex = 11
        Me.GetStartedButton.Text = "Get Started"
        '
        'TxtUsername
        '
        Me.TxtUsername.BorderThickness = 2
        Me.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUsername.DefaultText = ""
        Me.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.TxtUsername.IconLeft = Global.Melodify.My.Resources.Resources.UserIcon
        Me.TxtUsername.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.TxtUsername.Location = New System.Drawing.Point(601, 255)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsername.PlaceholderText = "Username"
        Me.TxtUsername.SelectedText = ""
        Me.TxtUsername.Size = New System.Drawing.Size(318, 46)
        Me.TxtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtUsername.TabIndex = 10
        Me.TxtUsername.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderThickness = 2
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.DefaultText = ""
        Me.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.TxtPassword.IconLeft = Global.Melodify.My.Resources.Resources.PassWordIcon
        Me.TxtPassword.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.TxtPassword.Location = New System.Drawing.Point(601, 335)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.PlaceholderText = "Password"
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.Size = New System.Drawing.Size(318, 46)
        Me.TxtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtPassword.TabIndex = 5
        Me.TxtPassword.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderThickness = 2
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.DefaultText = ""
        Me.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.TxtEmail.IconLeft = Global.Melodify.My.Resources.Resources.EmailIcon
        Me.TxtEmail.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.TxtEmail.Location = New System.Drawing.Point(601, 176)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderText = "Email"
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(318, 46)
        Me.TxtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtEmail.TabIndex = 4
        Me.TxtEmail.TextOffset = New System.Drawing.Point(10, 0)
        '
        'FemaleButton
        '
        Me.FemaleButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FemaleButton.CheckedState.BorderThickness = 0
        Me.FemaleButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FemaleButton.CheckedState.InnerColor = System.Drawing.Color.White
        Me.FemaleButton.Location = New System.Drawing.Point(824, 461)
        Me.FemaleButton.Name = "FemaleButton"
        Me.FemaleButton.Size = New System.Drawing.Size(16, 29)
        Me.FemaleButton.TabIndex = 22
        Me.FemaleButton.Text = "Guna2CustomRadioButton1"
        Me.FemaleButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.FemaleButton.UncheckedState.BorderThickness = 2
        Me.FemaleButton.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.FemaleButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.Melodify.My.Resources.Resources.back_svgrepo_com__1_
        Me.Guna2Button1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(42, 29)
        Me.Guna2Button1.TabIndex = 23
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 684)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.FemaleButton)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.MaleButton)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetStartedButton)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.ShowPass)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ShowPass As CheckBox
    Friend WithEvents GetStartedButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents MaleButton As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents FemaleButton As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
