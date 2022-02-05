<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.repoBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.logoutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.manageBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.clearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.conLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.hireDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.nameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.posTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.salaryTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.idTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.firstBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.lastBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.prevBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.nextBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.saveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.updBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.delBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Guna2ShadowPanel3.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.repoBtn)
        Me.Panel1.Controls.Add(Me.logoutBtn)
        Me.Panel1.Controls.Add(Me.manageBtn)
        Me.Panel1.Controls.Add(Me.dashBtn)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 757)
        Me.Panel1.TabIndex = 3
        '
        'repoBtn
        '
        Me.repoBtn.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.repoBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.repoBtn.CheckedState.Parent = Me.repoBtn
        Me.repoBtn.CustomImages.Parent = Me.repoBtn
        Me.repoBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.repoBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.repoBtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repoBtn.ForeColor = System.Drawing.Color.White
        Me.repoBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.repoBtn.HoverState.Parent = Me.repoBtn
        Me.repoBtn.Image = CType(resources.GetObject("repoBtn.Image"), System.Drawing.Image)
        Me.repoBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.repoBtn.ImageSize = New System.Drawing.Size(30, 30)
        Me.repoBtn.Location = New System.Drawing.Point(0, 184)
        Me.repoBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.repoBtn.Name = "repoBtn"
        Me.repoBtn.ShadowDecoration.Parent = Me.repoBtn
        Me.repoBtn.Size = New System.Drawing.Size(319, 69)
        Me.repoBtn.TabIndex = 8
        Me.repoBtn.Text = "Report Summary"
        Me.repoBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'logoutBtn
        '
        Me.logoutBtn.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.logoutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.logoutBtn.CheckedState.Parent = Me.logoutBtn
        Me.logoutBtn.CustomImages.Parent = Me.logoutBtn
        Me.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logoutBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.logoutBtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.logoutBtn.HoverState.Parent = Me.logoutBtn
        Me.logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), System.Drawing.Image)
        Me.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logoutBtn.ImageSize = New System.Drawing.Size(30, 30)
        Me.logoutBtn.Location = New System.Drawing.Point(0, 688)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.ShadowDecoration.Parent = Me.logoutBtn
        Me.logoutBtn.Size = New System.Drawing.Size(319, 69)
        Me.logoutBtn.TabIndex = 7
        Me.logoutBtn.Text = "Logout"
        Me.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'manageBtn
        '
        Me.manageBtn.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.manageBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manageBtn.CheckedState.Parent = Me.manageBtn
        Me.manageBtn.CustomImages.Parent = Me.manageBtn
        Me.manageBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.manageBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.manageBtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBtn.ForeColor = System.Drawing.Color.White
        Me.manageBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manageBtn.HoverState.Parent = Me.manageBtn
        Me.manageBtn.Image = CType(resources.GetObject("manageBtn.Image"), System.Drawing.Image)
        Me.manageBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.manageBtn.ImageSize = New System.Drawing.Size(30, 30)
        Me.manageBtn.Location = New System.Drawing.Point(0, 115)
        Me.manageBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.manageBtn.Name = "manageBtn"
        Me.manageBtn.ShadowDecoration.Parent = Me.manageBtn
        Me.manageBtn.Size = New System.Drawing.Size(319, 69)
        Me.manageBtn.TabIndex = 6
        Me.manageBtn.Text = "Management"
        Me.manageBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dashBtn
        '
        Me.dashBtn.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.dashBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dashBtn.CheckedState.Parent = Me.dashBtn
        Me.dashBtn.CustomImages.Parent = Me.dashBtn
        Me.dashBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dashBtn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashBtn.ForeColor = System.Drawing.Color.White
        Me.dashBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dashBtn.HoverState.Parent = Me.dashBtn
        Me.dashBtn.Image = CType(resources.GetObject("dashBtn.Image"), System.Drawing.Image)
        Me.dashBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashBtn.ImageSize = New System.Drawing.Size(30, 30)
        Me.dashBtn.Location = New System.Drawing.Point(0, 46)
        Me.dashBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dashBtn.Name = "dashBtn"
        Me.dashBtn.ShadowDecoration.Parent = Me.dashBtn
        Me.dashBtn.Size = New System.Drawing.Size(319, 69)
        Me.dashBtn.TabIndex = 5
        Me.dashBtn.Text = "Dashboard"
        Me.dashBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(319, 46)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel4.Controls.Add(Me.clearBtn)
        Me.Panel4.Controls.Add(Me.conLbl)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.hireDate)
        Me.Panel4.Controls.Add(Me.nameTxt)
        Me.Panel4.Controls.Add(Me.posTxt)
        Me.Panel4.Controls.Add(Me.salaryTxt)
        Me.Panel4.Controls.Add(Me.idTxt)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.firstBtn)
        Me.Panel4.Controls.Add(Me.lastBtn)
        Me.Panel4.Controls.Add(Me.prevBtn)
        Me.Panel4.Controls.Add(Me.nextBtn)
        Me.Panel4.Controls.Add(Me.saveBtn)
        Me.Panel4.Controls.Add(Me.updBtn)
        Me.Panel4.Controls.Add(Me.delBtn)
        Me.Panel4.Controls.Add(Me.Guna2ShadowPanel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 89)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1473, 757)
        Me.Panel4.TabIndex = 5
        '
        'clearBtn
        '
        Me.clearBtn.Animated = True
        Me.clearBtn.BackColor = System.Drawing.Color.Transparent
        Me.clearBtn.BorderRadius = 20
        Me.clearBtn.CheckedState.Parent = Me.clearBtn
        Me.clearBtn.CustomImages.Parent = Me.clearBtn
        Me.clearBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.clearBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.clearBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.clearBtn.HoverState.Image = CType(resources.GetObject("clearBtn.HoverState.Image"), System.Drawing.Image)
        Me.clearBtn.HoverState.Parent = Me.clearBtn
        Me.clearBtn.Image = CType(resources.GetObject("clearBtn.Image"), System.Drawing.Image)
        Me.clearBtn.Location = New System.Drawing.Point(1163, 225)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.ShadowDecoration.Parent = Me.clearBtn
        Me.clearBtn.Size = New System.Drawing.Size(211, 52)
        Me.clearBtn.TabIndex = 107
        Me.clearBtn.Text = "CLEAR RECORD"
        '
        'conLbl
        '
        Me.conLbl.AutoSize = True
        Me.conLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conLbl.ForeColor = System.Drawing.Color.White
        Me.conLbl.Location = New System.Drawing.Point(1320, 7)
        Me.conLbl.Name = "conLbl"
        Me.conLbl.Size = New System.Drawing.Size(0, 25)
        Me.conLbl.TabIndex = 106
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1135, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 25)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Connection : "
        '
        'hireDate
        '
        Me.hireDate.BorderRadius = 10
        Me.hireDate.CheckedState.Parent = Me.hireDate
        Me.hireDate.FillColor = System.Drawing.Color.White
        Me.hireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.hireDate.HoverState.Parent = Me.hireDate
        Me.hireDate.Location = New System.Drawing.Point(1140, 107)
        Me.hireDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.hireDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.hireDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.hireDate.Name = "hireDate"
        Me.hireDate.ShadowDecoration.Parent = Me.hireDate
        Me.hireDate.Size = New System.Drawing.Size(245, 37)
        Me.hireDate.TabIndex = 104
        Me.hireDate.Value = New Date(2022, 1, 31, 1, 19, 49, 433)
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
        Me.nameTxt.Location = New System.Drawing.Point(636, 108)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.PlaceholderText = ""
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.ShadowDecoration.Parent = Me.nameTxt
        Me.nameTxt.Size = New System.Drawing.Size(245, 36)
        Me.nameTxt.TabIndex = 103
        '
        'posTxt
        '
        Me.posTxt.BorderRadius = 10
        Me.posTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.posTxt.DefaultText = ""
        Me.posTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.posTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.posTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.posTxt.DisabledState.Parent = Me.posTxt
        Me.posTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.posTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.posTxt.FocusedState.Parent = Me.posTxt
        Me.posTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.posTxt.HoverState.Parent = Me.posTxt
        Me.posTxt.Location = New System.Drawing.Point(636, 160)
        Me.posTxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.posTxt.Name = "posTxt"
        Me.posTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.posTxt.PlaceholderText = ""
        Me.posTxt.SelectedText = ""
        Me.posTxt.ShadowDecoration.Parent = Me.posTxt
        Me.posTxt.Size = New System.Drawing.Size(245, 36)
        Me.posTxt.TabIndex = 102
        '
        'salaryTxt
        '
        Me.salaryTxt.BorderRadius = 10
        Me.salaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.salaryTxt.DefaultText = ""
        Me.salaryTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.salaryTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.salaryTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.salaryTxt.DisabledState.Parent = Me.salaryTxt
        Me.salaryTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.salaryTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.salaryTxt.FocusedState.Parent = Me.salaryTxt
        Me.salaryTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.salaryTxt.HoverState.Parent = Me.salaryTxt
        Me.salaryTxt.Location = New System.Drawing.Point(1140, 55)
        Me.salaryTxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.salaryTxt.Name = "salaryTxt"
        Me.salaryTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.salaryTxt.PlaceholderText = ""
        Me.salaryTxt.SelectedText = ""
        Me.salaryTxt.ShadowDecoration.Parent = Me.salaryTxt
        Me.salaryTxt.Size = New System.Drawing.Size(245, 36)
        Me.salaryTxt.TabIndex = 101
        '
        'idTxt
        '
        Me.idTxt.BorderRadius = 10
        Me.idTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idTxt.DefaultText = ""
        Me.idTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.idTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.idTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idTxt.DisabledState.Parent = Me.idTxt
        Me.idTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idTxt.FocusedState.Parent = Me.idTxt
        Me.idTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idTxt.HoverState.Parent = Me.idTxt
        Me.idTxt.Location = New System.Drawing.Point(636, 55)
        Me.idTxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idTxt.PlaceholderText = ""
        Me.idTxt.SelectedText = ""
        Me.idTxt.ShadowDecoration.Parent = Me.idTxt
        Me.idTxt.Size = New System.Drawing.Size(245, 36)
        Me.idTxt.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(401, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 25)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Position                : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(907, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 25)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Salary                    : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(907, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 25)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Date of Hire          : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(401, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 25)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Staff ID                 : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(401, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 25)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Staff Name           : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(852, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 29)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Staff Details"
        '
        'firstBtn
        '
        Me.firstBtn.Animated = True
        Me.firstBtn.CheckedState.Parent = Me.firstBtn
        Me.firstBtn.CustomImages.Parent = Me.firstBtn
        Me.firstBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.firstBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.firstBtn.ForeColor = System.Drawing.Color.White
        Me.firstBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.firstBtn.HoverState.Parent = Me.firstBtn
        Me.firstBtn.Image = CType(resources.GetObject("firstBtn.Image"), System.Drawing.Image)
        Me.firstBtn.ImageSize = New System.Drawing.Size(25, 25)
        Me.firstBtn.Location = New System.Drawing.Point(1381, 341)
        Me.firstBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.firstBtn.Name = "firstBtn"
        Me.firstBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.firstBtn.ShadowDecoration.Parent = Me.firstBtn
        Me.firstBtn.Size = New System.Drawing.Size(52, 46)
        Me.firstBtn.TabIndex = 13
        '
        'lastBtn
        '
        Me.lastBtn.Animated = True
        Me.lastBtn.CheckedState.Parent = Me.lastBtn
        Me.lastBtn.CustomImages.Parent = Me.lastBtn
        Me.lastBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.lastBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lastBtn.ForeColor = System.Drawing.Color.White
        Me.lastBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.lastBtn.HoverState.Parent = Me.lastBtn
        Me.lastBtn.Image = CType(resources.GetObject("lastBtn.Image"), System.Drawing.Image)
        Me.lastBtn.ImageSize = New System.Drawing.Size(25, 25)
        Me.lastBtn.Location = New System.Drawing.Point(1381, 683)
        Me.lastBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lastBtn.Name = "lastBtn"
        Me.lastBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.lastBtn.ShadowDecoration.Parent = Me.lastBtn
        Me.lastBtn.Size = New System.Drawing.Size(52, 46)
        Me.lastBtn.TabIndex = 12
        '
        'prevBtn
        '
        Me.prevBtn.Animated = True
        Me.prevBtn.CheckedState.Parent = Me.prevBtn
        Me.prevBtn.CustomImages.Parent = Me.prevBtn
        Me.prevBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.prevBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.prevBtn.ForeColor = System.Drawing.Color.White
        Me.prevBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.prevBtn.HoverState.Parent = Me.prevBtn
        Me.prevBtn.Image = CType(resources.GetObject("prevBtn.Image"), System.Drawing.Image)
        Me.prevBtn.ImageSize = New System.Drawing.Size(25, 25)
        Me.prevBtn.Location = New System.Drawing.Point(357, 341)
        Me.prevBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.prevBtn.Name = "prevBtn"
        Me.prevBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.prevBtn.ShadowDecoration.Parent = Me.prevBtn
        Me.prevBtn.Size = New System.Drawing.Size(52, 46)
        Me.prevBtn.TabIndex = 11
        '
        'nextBtn
        '
        Me.nextBtn.Animated = True
        Me.nextBtn.CheckedState.Parent = Me.nextBtn
        Me.nextBtn.CustomImages.Parent = Me.nextBtn
        Me.nextBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.nextBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nextBtn.ForeColor = System.Drawing.Color.White
        Me.nextBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.nextBtn.HoverState.Parent = Me.nextBtn
        Me.nextBtn.Image = CType(resources.GetObject("nextBtn.Image"), System.Drawing.Image)
        Me.nextBtn.ImageSize = New System.Drawing.Size(25, 25)
        Me.nextBtn.Location = New System.Drawing.Point(358, 683)
        Me.nextBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.nextBtn.ShadowDecoration.Parent = Me.nextBtn
        Me.nextBtn.Size = New System.Drawing.Size(52, 46)
        Me.nextBtn.TabIndex = 1
        '
        'saveBtn
        '
        Me.saveBtn.Animated = True
        Me.saveBtn.BackColor = System.Drawing.Color.Transparent
        Me.saveBtn.BorderRadius = 20
        Me.saveBtn.CheckedState.Parent = Me.saveBtn
        Me.saveBtn.CustomImages.Parent = Me.saveBtn
        Me.saveBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.saveBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.saveBtn.HoverState.Image = CType(resources.GetObject("saveBtn.HoverState.Image"), System.Drawing.Image)
        Me.saveBtn.HoverState.Parent = Me.saveBtn
        Me.saveBtn.Image = CType(resources.GetObject("saveBtn.Image"), System.Drawing.Image)
        Me.saveBtn.Location = New System.Drawing.Point(515, 225)
        Me.saveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.ShadowDecoration.Parent = Me.saveBtn
        Me.saveBtn.Size = New System.Drawing.Size(211, 52)
        Me.saveBtn.TabIndex = 10
        Me.saveBtn.Text = "SAVE RECORD"
        '
        'updBtn
        '
        Me.updBtn.Animated = True
        Me.updBtn.BackColor = System.Drawing.Color.Transparent
        Me.updBtn.BorderRadius = 20
        Me.updBtn.CheckedState.Parent = Me.updBtn
        Me.updBtn.CustomImages.Parent = Me.updBtn
        Me.updBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.updBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.updBtn.ForeColor = System.Drawing.Color.White
        Me.updBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.updBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.updBtn.HoverState.Image = CType(resources.GetObject("updBtn.HoverState.Image"), System.Drawing.Image)
        Me.updBtn.HoverState.Parent = Me.updBtn
        Me.updBtn.Image = CType(resources.GetObject("updBtn.Image"), System.Drawing.Image)
        Me.updBtn.Location = New System.Drawing.Point(731, 225)
        Me.updBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.updBtn.Name = "updBtn"
        Me.updBtn.ShadowDecoration.Parent = Me.updBtn
        Me.updBtn.Size = New System.Drawing.Size(211, 52)
        Me.updBtn.TabIndex = 9
        Me.updBtn.Text = "UPDATE RECORD"
        '
        'delBtn
        '
        Me.delBtn.Animated = True
        Me.delBtn.BackColor = System.Drawing.Color.Transparent
        Me.delBtn.BorderRadius = 20
        Me.delBtn.CheckedState.Parent = Me.delBtn
        Me.delBtn.CustomImages.Parent = Me.delBtn
        Me.delBtn.FillColor = System.Drawing.Color.DarkViolet
        Me.delBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.delBtn.ForeColor = System.Drawing.Color.White
        Me.delBtn.HoverState.FillColor = System.Drawing.Color.MediumOrchid
        Me.delBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.delBtn.HoverState.Image = CType(resources.GetObject("delBtn.HoverState.Image"), System.Drawing.Image)
        Me.delBtn.HoverState.Parent = Me.delBtn
        Me.delBtn.Image = CType(resources.GetObject("delBtn.Image"), System.Drawing.Image)
        Me.delBtn.Location = New System.Drawing.Point(947, 225)
        Me.delBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.ShadowDecoration.Parent = Me.delBtn
        Me.delBtn.Size = New System.Drawing.Size(211, 52)
        Me.delBtn.TabIndex = 8
        Me.delBtn.Text = "DELETE RECORD"
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.dataGrid)
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(413, 297)
        Me.Guna2ShadowPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.Padding = New System.Windows.Forms.Padding(5, 1, 5, 5)
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel3.ShadowDepth = 40
        Me.Guna2ShadowPanel3.ShadowShift = 3
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(965, 437)
        Me.Guna2ShadowPanel3.TabIndex = 3
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.Color.White
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid.Location = New System.Drawing.Point(5, 1)
        Me.dataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.RowHeadersWidth = 51
        Me.dataGrid.Size = New System.Drawing.Size(955, 431)
        Me.dataGrid.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "STAFF_ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 101
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "STAFF_NAME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "POSITION"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 102
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "SALARY"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 91
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "HIRE_DATE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 114
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1473, 89)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 89)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(28, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(779, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Management"
        '
        'staffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1473, 846)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "staffForm"
        Me.Text = "IMRAI TOUR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents repoBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents saveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents delBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents firstBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents lastBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents prevBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents nextBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents posTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents salaryTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents idTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents hireDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents conLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents clearBtn As Guna.UI2.WinForms.Guna2Button
End Class
