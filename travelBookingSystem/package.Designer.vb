<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class packageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(packageForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.confirmBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.packageCBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.packageBBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.packageABtn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel3.Controls.Add(Me.backBtn)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1473, 71)
        Me.Panel3.TabIndex = 4
        '
        'backBtn
        '
        Me.backBtn.FlatAppearance.BorderSize = 0
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.White
        Me.backBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft
        Me.backBtn.IconColor = System.Drawing.Color.White
        Me.backBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.backBtn.Location = New System.Drawing.Point(1403, 14)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(59, 49)
        Me.backBtn.TabIndex = 6
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 71)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(31, 5)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(203, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(597, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Your Package"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cancelBtn)
        Me.Panel4.Controls.Add(Me.confirmBtn)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.packageCBtn)
        Me.Panel4.Controls.Add(Me.packageBBtn)
        Me.Panel4.Controls.Add(Me.packageABtn)
        Me.Panel4.Controls.Add(Me.btnConfirm)
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1473, 992)
        Me.Panel4.TabIndex = 5
        '
        'cancelBtn
        '
        Me.cancelBtn.Animated = True
        Me.cancelBtn.AutoRoundedCorners = True
        Me.cancelBtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelBtn.BorderColor = System.Drawing.Color.Transparent
        Me.cancelBtn.BorderRadius = 22
        Me.cancelBtn.CheckedState.Parent = Me.cancelBtn
        Me.cancelBtn.CustomImages.Parent = Me.cancelBtn
        Me.cancelBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.White
        Me.cancelBtn.HoverState.Parent = Me.cancelBtn
        Me.cancelBtn.Location = New System.Drawing.Point(1007, 921)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.ShadowDecoration.Parent = Me.cancelBtn
        Me.cancelBtn.Size = New System.Drawing.Size(180, 46)
        Me.cancelBtn.TabIndex = 154
        Me.cancelBtn.Text = "CANCEL"
        '
        'confirmBtn
        '
        Me.confirmBtn.Animated = True
        Me.confirmBtn.AutoRoundedCorners = True
        Me.confirmBtn.BackColor = System.Drawing.Color.Transparent
        Me.confirmBtn.BorderColor = System.Drawing.Color.Transparent
        Me.confirmBtn.BorderRadius = 22
        Me.confirmBtn.CheckedState.Parent = Me.confirmBtn
        Me.confirmBtn.CustomImages.Parent = Me.confirmBtn
        Me.confirmBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBtn.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.HoverState.Parent = Me.confirmBtn
        Me.confirmBtn.Location = New System.Drawing.Point(1212, 921)
        Me.confirmBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.ShadowDecoration.Parent = Me.confirmBtn
        Me.confirmBtn.Size = New System.Drawing.Size(180, 46)
        Me.confirmBtn.TabIndex = 153
        Me.confirmBtn.Text = "CONFIRM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Location = New System.Drawing.Point(4, 69)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1820, 75)
        Me.Panel2.TabIndex = 78
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(355, 20)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(173, 30)
        Me.Label18.TabIndex = 79
        Me.Label18.Text = "..................."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Choose Your Package"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(565, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Booking Form"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1136, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(341, 55)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Succesfully Booked"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(929, 20)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(199, 30)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "..................."
        '
        'packageCBtn
        '
        Me.packageCBtn.Animated = True
        Me.packageCBtn.AutoRoundedCorners = True
        Me.packageCBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.packageCBtn.BorderColor = System.Drawing.Color.Transparent
        Me.packageCBtn.BorderRadius = 22
        Me.packageCBtn.CheckedState.Parent = Me.packageCBtn
        Me.packageCBtn.CustomImages.Parent = Me.packageCBtn
        Me.packageCBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.packageCBtn.ForeColor = System.Drawing.Color.White
        Me.packageCBtn.HoverState.Parent = Me.packageCBtn
        Me.packageCBtn.Location = New System.Drawing.Point(1147, 837)
        Me.packageCBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.packageCBtn.Name = "packageCBtn"
        Me.packageCBtn.ShadowDecoration.Parent = Me.packageCBtn
        Me.packageCBtn.Size = New System.Drawing.Size(180, 46)
        Me.packageCBtn.TabIndex = 83
        Me.packageCBtn.Text = "BOOK NOW"
        '
        'packageBBtn
        '
        Me.packageBBtn.Animated = True
        Me.packageBBtn.AutoRoundedCorners = True
        Me.packageBBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.packageBBtn.BorderColor = System.Drawing.Color.Transparent
        Me.packageBBtn.BorderRadius = 22
        Me.packageBBtn.CheckedState.Parent = Me.packageBBtn
        Me.packageBBtn.CustomImages.Parent = Me.packageBBtn
        Me.packageBBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.packageBBtn.ForeColor = System.Drawing.Color.White
        Me.packageBBtn.HoverState.Parent = Me.packageBBtn
        Me.packageBBtn.Location = New System.Drawing.Point(644, 837)
        Me.packageBBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.packageBBtn.Name = "packageBBtn"
        Me.packageBBtn.ShadowDecoration.Parent = Me.packageBBtn
        Me.packageBBtn.Size = New System.Drawing.Size(180, 46)
        Me.packageBBtn.TabIndex = 82
        Me.packageBBtn.Text = "BOOK NOW"
        '
        'packageABtn
        '
        Me.packageABtn.Animated = True
        Me.packageABtn.AutoRoundedCorners = True
        Me.packageABtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.packageABtn.BorderColor = System.Drawing.Color.Transparent
        Me.packageABtn.BorderRadius = 22
        Me.packageABtn.CheckedState.Parent = Me.packageABtn
        Me.packageABtn.CustomImages.Parent = Me.packageABtn
        Me.packageABtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.packageABtn.ForeColor = System.Drawing.Color.White
        Me.packageABtn.HoverState.Parent = Me.packageABtn
        Me.packageABtn.Location = New System.Drawing.Point(148, 837)
        Me.packageABtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.packageABtn.Name = "packageABtn"
        Me.packageABtn.ShadowDecoration.Parent = Me.packageABtn
        Me.packageABtn.Size = New System.Drawing.Size(180, 46)
        Me.packageABtn.TabIndex = 81
        Me.packageABtn.Text = "BOOK NOW"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.White
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(629, 1056)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(151, 44)
        Me.btnConfirm.TabIndex = 48
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(13, 167)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(467, 748)
        Me.PictureBox5.TabIndex = 73
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(487, 167)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(503, 748)
        Me.PictureBox2.TabIndex = 79
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(997, 166)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(475, 750)
        Me.PictureBox3.TabIndex = 80
        Me.PictureBox3.TabStop = False
        '
        'packageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1473, 992)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "packageForm"
        Me.Text = "IMRAI TOUR"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents packageCBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents packageBBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents packageABtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents confirmBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents backBtn As FontAwesome.Sharp.IconButton
End Class
