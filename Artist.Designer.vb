<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Artist
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
        Me.searchBtn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 109)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1006, 504)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'searchBtn
        '
        Me.searchBtn.Animated = True
        Me.searchBtn.BorderThickness = 2
        Me.searchBtn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchBtn.DefaultText = ""
        Me.searchBtn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBtn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBtn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.searchBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.searchBtn.IconLeft = Global.Melodify.My.Resources.Resources.search_svgrepo_com
        Me.searchBtn.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.searchBtn.Location = New System.Drawing.Point(264, 23)
        Me.searchBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBtn.PlaceholderText = "Search by Artist's Name"
        Me.searchBtn.SelectedText = ""
        Me.searchBtn.Size = New System.Drawing.Size(729, 46)
        Me.searchBtn.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.searchBtn.TabIndex = 5
        Me.searchBtn.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Artist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 612)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Artist"
        Me.Text = "Artist"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2TextBox
End Class
