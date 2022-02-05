<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signForm))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.showChk = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.signBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.passTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.nameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.startBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.showChk)
        Me.Panel4.Controls.Add(Me.signBtn)
        Me.Panel4.Controls.Add(Me.passTxt)
        Me.Panel4.Controls.Add(Me.nameTxt)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.startBtn)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(503, 671)
        Me.Panel4.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(10, 300)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(484, 32)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "VIETNAM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'showChk
        '
        Me.showChk.AutoSize = True
        Me.showChk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.showChk.CheckedState.BorderRadius = 2
        Me.showChk.CheckedState.BorderThickness = 0
        Me.showChk.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.showChk.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.showChk.ForeColor = System.Drawing.Color.White
        Me.showChk.Location = New System.Drawing.Point(226, 567)
        Me.showChk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.showChk.Name = "showChk"
        Me.showChk.Size = New System.Drawing.Size(102, 17)
        Me.showChk.TabIndex = 112
        Me.showChk.Text = "Show Password"
        Me.showChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.showChk.UncheckedState.BorderRadius = 2
        Me.showChk.UncheckedState.BorderThickness = 0
        Me.showChk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.showChk.UseVisualStyleBackColor = True
        '
        'signBtn
        '
        Me.signBtn.Animated = True
        Me.signBtn.AutoRoundedCorners = True
        Me.signBtn.BorderRadius = 20
        Me.signBtn.CheckedState.Parent = Me.signBtn
        Me.signBtn.CustomImages.Parent = Me.signBtn
        Me.signBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.signBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signBtn.ForeColor = System.Drawing.Color.White
        Me.signBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.signBtn.HoverState.Parent = Me.signBtn
        Me.signBtn.Location = New System.Drawing.Point(165, 609)
        Me.signBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.signBtn.Name = "signBtn"
        Me.signBtn.ShadowDecoration.Parent = Me.signBtn
        Me.signBtn.Size = New System.Drawing.Size(178, 42)
        Me.signBtn.TabIndex = 111
        Me.signBtn.Text = "SIGN IN"
        '
        'passTxt
        '
        Me.passTxt.BorderRadius = 10
        Me.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passTxt.DefaultText = ""
        Me.passTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passTxt.DisabledState.Parent = Me.passTxt
        Me.passTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passTxt.FocusedState.Parent = Me.passTxt
        Me.passTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passTxt.HoverState.Parent = Me.passTxt
        Me.passTxt.Location = New System.Drawing.Point(226, 532)
        Me.passTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTxt.PlaceholderText = ""
        Me.passTxt.SelectedText = ""
        Me.passTxt.ShadowDecoration.Parent = Me.passTxt
        Me.passTxt.Size = New System.Drawing.Size(176, 29)
        Me.passTxt.TabIndex = 110
        '
        'nameTxt
        '
        Me.nameTxt.BorderRadius = 10
        Me.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nameTxt.DefaultText = ""
        Me.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nameTxt.DisabledState.Parent = Me.nameTxt
        Me.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nameTxt.FocusedState.Parent = Me.nameTxt
        Me.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nameTxt.HoverState.Parent = Me.nameTxt
        Me.nameTxt.Location = New System.Drawing.Point(226, 479)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.PlaceholderText = ""
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.ShadowDecoration.Parent = Me.nameTxt
        Me.nameTxt.Size = New System.Drawing.Size(176, 29)
        Me.nameTxt.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(97, 540)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 22)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Password   : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 487)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Username   : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 431)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 22)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "==================="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(269, 431)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 22)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "==================="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(200, 431)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 22)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "staff"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startBtn
        '
        Me.startBtn.Animated = True
        Me.startBtn.AutoRoundedCorners = True
        Me.startBtn.BorderRadius = 20
        Me.startBtn.CheckedState.Parent = Me.startBtn
        Me.startBtn.CustomImages.Parent = Me.startBtn
        Me.startBtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBtn.ForeColor = System.Drawing.Color.White
        Me.startBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.startBtn.HoverState.Parent = Me.startBtn
        Me.startBtn.Location = New System.Drawing.Point(101, 344)
        Me.startBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.ShadowDecoration.Parent = Me.startBtn
        Me.startBtn.Size = New System.Drawing.Size(301, 42)
        Me.startBtn.TabIndex = 102
        Me.startBtn.Text = "LETS TRAVEL -->"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel3.Controls.Add(Me.IconButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 48)
        Me.Panel3.TabIndex = 2
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(438, 2)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(56, 46)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(8, 267)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO HO CHI MINH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(157, 57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'signForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 671)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "signForm"
        Me.Text = "IMRAI TOUR"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents startBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents nameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents signBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents showChk As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label7 As Label
End Class
