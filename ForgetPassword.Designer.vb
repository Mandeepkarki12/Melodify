<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgetPassword
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
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.OTPButton = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtOTP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GetStartedButton = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(610, -2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(49, 37)
        Me.Guna2ControlBox1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Change Password"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.GetStartedButton)
        Me.Guna2Panel1.Controls.Add(Me.TxtUsername)
        Me.Guna2Panel1.Controls.Add(Me.TxtEmail)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 111)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(659, 290)
        Me.Guna2Panel1.TabIndex = 29
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.OTPButton)
        Me.Guna2Panel2.Controls.Add(Me.TxtOTP)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(659, 287)
        Me.Guna2Panel2.TabIndex = 30
        '
        'OTPButton
        '
        Me.OTPButton.BorderRadius = 3
        Me.OTPButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.OTPButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.OTPButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.OTPButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.OTPButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.OTPButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.OTPButton.ForeColor = System.Drawing.Color.White
        Me.OTPButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OTPButton.Location = New System.Drawing.Point(249, 170)
        Me.OTPButton.Name = "OTPButton"
        Me.OTPButton.Size = New System.Drawing.Size(157, 45)
        Me.OTPButton.TabIndex = 12
        Me.OTPButton.Text = "Submit"
        '
        'TxtOTP
        '
        Me.TxtOTP.BorderThickness = 2
        Me.TxtOTP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOTP.DefaultText = ""
        Me.TxtOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.TxtOTP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.TxtOTP.IconLeft = Global.Melodify.My.Resources.Resources.PassWordIcon
        Me.TxtOTP.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.TxtOTP.Location = New System.Drawing.Point(202, 60)
        Me.TxtOTP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtOTP.Name = "TxtOTP"
        Me.TxtOTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOTP.PlaceholderText = "Enter OTP"
        Me.TxtOTP.SelectedText = ""
        Me.TxtOTP.Size = New System.Drawing.Size(246, 46)
        Me.TxtOTP.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtOTP.TabIndex = 6
        Me.TxtOTP.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.GetStartedButton.Location = New System.Drawing.Point(249, 197)
        Me.GetStartedButton.Name = "GetStartedButton"
        Me.GetStartedButton.Size = New System.Drawing.Size(157, 45)
        Me.GetStartedButton.TabIndex = 29
        Me.GetStartedButton.Text = "Next"
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
        Me.TxtUsername.Location = New System.Drawing.Point(170, 21)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsername.PlaceholderText = "Username"
        Me.TxtUsername.SelectedText = ""
        Me.TxtUsername.Size = New System.Drawing.Size(318, 46)
        Me.TxtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtUsername.TabIndex = 24
        Me.TxtUsername.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.TxtEmail.Location = New System.Drawing.Point(170, 99)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderText = "Email"
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(318, 46)
        Me.TxtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtEmail.TabIndex = 27
        Me.TxtEmail.TextOffset = New System.Drawing.Point(10, 0)
        '
        'ForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 399)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgetPassword"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GetStartedButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtOTP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OTPButton As Guna.UI2.WinForms.Guna2Button
End Class
