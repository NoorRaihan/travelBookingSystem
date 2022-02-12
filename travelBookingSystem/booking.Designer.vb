<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.printBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.receiptTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.comboAddon2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.comboAddon1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pkgLbl = New System.Windows.Forms.Label()
        Me.cancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.bookBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.confirmBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dateTxt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.adultTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.childTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.seniorTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.icTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.phoneTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.emailTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.nameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pdDocument = New System.Drawing.Printing.PrintDocument()
        Me.printDialogprev = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(479, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Booking Form"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel3.Controls.Add(Me.backBtn)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1178, 74)
        Me.Panel3.TabIndex = 6
        '
        'backBtn
        '
        Me.backBtn.FlatAppearance.BorderSize = 0
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.ForeColor = System.Drawing.Color.White
        Me.backBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft
        Me.backBtn.IconColor = System.Drawing.Color.White
        Me.backBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.backBtn.Location = New System.Drawing.Point(1109, 18)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(60, 51)
        Me.backBtn.TabIndex = 2
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 74)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(29, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1456, 66)
        Me.Panel2.TabIndex = 78
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(772, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(146, 29)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "..................."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(455, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(323, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Booking Form"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(304, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 29)
        Me.Label18.TabIndex = 79
        Me.Label18.Text = "..................."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Choose Your Package"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(930, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Succesfully Booked"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(442, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(394, 42)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Choose Your Package"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(116, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 24)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Booking Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(60, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 20)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Name                       : "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel4.Controls.Add(Me.printBtn)
        Me.Panel4.Controls.Add(Me.receiptTxt)
        Me.Panel4.Controls.Add(Me.comboAddon2)
        Me.Panel4.Controls.Add(Me.comboAddon1)
        Me.Panel4.Controls.Add(Me.pkgLbl)
        Me.Panel4.Controls.Add(Me.cancelBtn)
        Me.Panel4.Controls.Add(Me.bookBtn)
        Me.Panel4.Controls.Add(Me.confirmBtn)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.dateTxt)
        Me.Panel4.Controls.Add(Me.adultTxt)
        Me.Panel4.Controls.Add(Me.childTxt)
        Me.Panel4.Controls.Add(Me.seniorTxt)
        Me.Panel4.Controls.Add(Me.icTxt)
        Me.Panel4.Controls.Add(Me.phoneTxt)
        Me.Panel4.Controls.Add(Me.emailTxt)
        Me.Panel4.Controls.Add(Me.nameTxt)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1178, 676)
        Me.Panel4.TabIndex = 7
        '
        'printBtn
        '
        Me.printBtn.Animated = True
        Me.printBtn.AutoRoundedCorners = True
        Me.printBtn.BorderRadius = 20
        Me.printBtn.CheckedState.Parent = Me.printBtn
        Me.printBtn.CustomImages.Parent = Me.printBtn
        Me.printBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBtn.ForeColor = System.Drawing.Color.White
        Me.printBtn.HoverState.Parent = Me.printBtn
        Me.printBtn.Location = New System.Drawing.Point(764, 622)
        Me.printBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.ShadowDecoration.Parent = Me.printBtn
        Me.printBtn.Size = New System.Drawing.Size(190, 42)
        Me.printBtn.TabIndex = 108
        Me.printBtn.Text = "PRINT RECEIPT"
        '
        'receiptTxt
        '
        Me.receiptTxt.BorderRadius = 10
        Me.receiptTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.receiptTxt.DefaultText = ""
        Me.receiptTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.receiptTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.receiptTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.receiptTxt.DisabledState.Parent = Me.receiptTxt
        Me.receiptTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.receiptTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.receiptTxt.FocusedState.Parent = Me.receiptTxt
        Me.receiptTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptTxt.ForeColor = System.Drawing.Color.Black
        Me.receiptTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.receiptTxt.HoverState.Parent = Me.receiptTxt
        Me.receiptTxt.Location = New System.Drawing.Point(583, 333)
        Me.receiptTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.receiptTxt.Multiline = True
        Me.receiptTxt.Name = "receiptTxt"
        Me.receiptTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.receiptTxt.PlaceholderText = ""
        Me.receiptTxt.ReadOnly = True
        Me.receiptTxt.SelectedText = ""
        Me.receiptTxt.ShadowDecoration.Parent = Me.receiptTxt
        Me.receiptTxt.Size = New System.Drawing.Size(563, 282)
        Me.receiptTxt.TabIndex = 107
        Me.receiptTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comboAddon2
        '
        Me.comboAddon2.BackColor = System.Drawing.Color.Transparent
        Me.comboAddon2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboAddon2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAddon2.FocusedColor = System.Drawing.Color.Empty
        Me.comboAddon2.FocusedState.Parent = Me.comboAddon2
        Me.comboAddon2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboAddon2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboAddon2.FormattingEnabled = True
        Me.comboAddon2.HoverState.Parent = Me.comboAddon2
        Me.comboAddon2.ItemHeight = 30
        Me.comboAddon2.ItemsAppearance.Parent = Me.comboAddon2
        Me.comboAddon2.Location = New System.Drawing.Point(974, 255)
        Me.comboAddon2.Margin = New System.Windows.Forms.Padding(2)
        Me.comboAddon2.Name = "comboAddon2"
        Me.comboAddon2.ShadowDecoration.Parent = Me.comboAddon2
        Me.comboAddon2.Size = New System.Drawing.Size(174, 36)
        Me.comboAddon2.TabIndex = 106
        '
        'comboAddon1
        '
        Me.comboAddon1.BackColor = System.Drawing.Color.Transparent
        Me.comboAddon1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboAddon1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAddon1.FocusedColor = System.Drawing.Color.Empty
        Me.comboAddon1.FocusedState.Parent = Me.comboAddon1
        Me.comboAddon1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboAddon1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboAddon1.FormattingEnabled = True
        Me.comboAddon1.HoverState.Parent = Me.comboAddon1
        Me.comboAddon1.ItemHeight = 30
        Me.comboAddon1.ItemsAppearance.Parent = Me.comboAddon1
        Me.comboAddon1.Location = New System.Drawing.Point(777, 254)
        Me.comboAddon1.Margin = New System.Windows.Forms.Padding(2)
        Me.comboAddon1.Name = "comboAddon1"
        Me.comboAddon1.ShadowDecoration.Parent = Me.comboAddon1
        Me.comboAddon1.Size = New System.Drawing.Size(174, 36)
        Me.comboAddon1.TabIndex = 105
        '
        'pkgLbl
        '
        Me.pkgLbl.BackColor = System.Drawing.Color.Transparent
        Me.pkgLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pkgLbl.ForeColor = System.Drawing.Color.White
        Me.pkgLbl.Location = New System.Drawing.Point(773, 211)
        Me.pkgLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pkgLbl.Name = "pkgLbl"
        Me.pkgLbl.Size = New System.Drawing.Size(177, 28)
        Me.pkgLbl.TabIndex = 104
        '
        'cancelBtn
        '
        Me.cancelBtn.Animated = True
        Me.cancelBtn.AutoRoundedCorners = True
        Me.cancelBtn.BorderRadius = 20
        Me.cancelBtn.CheckedState.Parent = Me.cancelBtn
        Me.cancelBtn.CustomImages.Parent = Me.cancelBtn
        Me.cancelBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.White
        Me.cancelBtn.HoverState.Parent = Me.cancelBtn
        Me.cancelBtn.Location = New System.Drawing.Point(570, 622)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.ShadowDecoration.Parent = Me.cancelBtn
        Me.cancelBtn.Size = New System.Drawing.Size(190, 42)
        Me.cancelBtn.TabIndex = 103
        Me.cancelBtn.Text = "CANCEL"
        '
        'bookBtn
        '
        Me.bookBtn.Animated = True
        Me.bookBtn.AutoRoundedCorners = True
        Me.bookBtn.BorderRadius = 20
        Me.bookBtn.CheckedState.Parent = Me.bookBtn
        Me.bookBtn.CustomImages.Parent = Me.bookBtn
        Me.bookBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookBtn.ForeColor = System.Drawing.Color.White
        Me.bookBtn.HoverState.Parent = Me.bookBtn
        Me.bookBtn.Location = New System.Drawing.Point(958, 622)
        Me.bookBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.bookBtn.Name = "bookBtn"
        Me.bookBtn.ShadowDecoration.Parent = Me.bookBtn
        Me.bookBtn.Size = New System.Drawing.Size(190, 42)
        Me.bookBtn.TabIndex = 102
        Me.bookBtn.Text = "BOOK NOW"
        '
        'confirmBtn
        '
        Me.confirmBtn.Animated = True
        Me.confirmBtn.AutoRoundedCorners = True
        Me.confirmBtn.BorderRadius = 20
        Me.confirmBtn.CheckedState.Parent = Me.confirmBtn
        Me.confirmBtn.CustomImages.Parent = Me.confirmBtn
        Me.confirmBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBtn.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.HoverState.Parent = Me.confirmBtn
        Me.confirmBtn.Location = New System.Drawing.Point(194, 622)
        Me.confirmBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.ShadowDecoration.Parent = Me.confirmBtn
        Me.confirmBtn.Size = New System.Drawing.Size(190, 42)
        Me.confirmBtn.TabIndex = 101
        Me.confirmBtn.Text = "CONFIRM"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(773, 305)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(163, 24)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = "Booking Receipt"
        '
        'dateTxt
        '
        Me.dateTxt.BorderRadius = 10
        Me.dateTxt.CheckedState.Parent = Me.dateTxt
        Me.dateTxt.FillColor = System.Drawing.Color.White
        Me.dateTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateTxt.HoverState.Parent = Me.dateTxt
        Me.dateTxt.Location = New System.Drawing.Point(252, 414)
        Me.dateTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.dateTxt.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateTxt.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.ShadowDecoration.Parent = Me.dateTxt
        Me.dateTxt.Size = New System.Drawing.Size(197, 30)
        Me.dateTxt.TabIndex = 98
        Me.dateTxt.Value = New Date(2022, 1, 31, 1, 19, 49, 433)
        '
        'adultTxt
        '
        Me.adultTxt.BorderRadius = 10
        Me.adultTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adultTxt.DefaultText = ""
        Me.adultTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.adultTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.adultTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adultTxt.DisabledState.Parent = Me.adultTxt
        Me.adultTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adultTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adultTxt.FocusedState.Parent = Me.adultTxt
        Me.adultTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adultTxt.HoverState.Parent = Me.adultTxt
        Me.adultTxt.Location = New System.Drawing.Point(252, 534)
        Me.adultTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.adultTxt.Name = "adultTxt"
        Me.adultTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.adultTxt.PlaceholderText = ""
        Me.adultTxt.SelectedText = ""
        Me.adultTxt.ShadowDecoration.Parent = Me.adultTxt
        Me.adultTxt.Size = New System.Drawing.Size(150, 29)
        Me.adultTxt.TabIndex = 97
        '
        'childTxt
        '
        Me.childTxt.BorderRadius = 10
        Me.childTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.childTxt.DefaultText = ""
        Me.childTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.childTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.childTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.childTxt.DisabledState.Parent = Me.childTxt
        Me.childTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.childTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.childTxt.FocusedState.Parent = Me.childTxt
        Me.childTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.childTxt.HoverState.Parent = Me.childTxt
        Me.childTxt.Location = New System.Drawing.Point(252, 569)
        Me.childTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.childTxt.Name = "childTxt"
        Me.childTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.childTxt.PlaceholderText = ""
        Me.childTxt.SelectedText = ""
        Me.childTxt.ShadowDecoration.Parent = Me.childTxt
        Me.childTxt.Size = New System.Drawing.Size(150, 29)
        Me.childTxt.TabIndex = 96
        '
        'seniorTxt
        '
        Me.seniorTxt.BorderRadius = 10
        Me.seniorTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.seniorTxt.DefaultText = ""
        Me.seniorTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.seniorTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.seniorTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.seniorTxt.DisabledState.Parent = Me.seniorTxt
        Me.seniorTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.seniorTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seniorTxt.FocusedState.Parent = Me.seniorTxt
        Me.seniorTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seniorTxt.HoverState.Parent = Me.seniorTxt
        Me.seniorTxt.Location = New System.Drawing.Point(252, 498)
        Me.seniorTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.seniorTxt.Name = "seniorTxt"
        Me.seniorTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.seniorTxt.PlaceholderText = ""
        Me.seniorTxt.SelectedText = ""
        Me.seniorTxt.ShadowDecoration.Parent = Me.seniorTxt
        Me.seniorTxt.Size = New System.Drawing.Size(150, 29)
        Me.seniorTxt.TabIndex = 95
        '
        'icTxt
        '
        Me.icTxt.BorderRadius = 10
        Me.icTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.icTxt.DefaultText = ""
        Me.icTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.icTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.icTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.icTxt.DisabledState.Parent = Me.icTxt
        Me.icTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.icTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.icTxt.FocusedState.Parent = Me.icTxt
        Me.icTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.icTxt.HoverState.Parent = Me.icTxt
        Me.icTxt.Location = New System.Drawing.Point(252, 314)
        Me.icTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.icTxt.Name = "icTxt"
        Me.icTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.icTxt.PlaceholderText = ""
        Me.icTxt.SelectedText = ""
        Me.icTxt.ShadowDecoration.Parent = Me.icTxt
        Me.icTxt.Size = New System.Drawing.Size(282, 29)
        Me.icTxt.TabIndex = 94
        '
        'phoneTxt
        '
        Me.phoneTxt.BorderRadius = 10
        Me.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phoneTxt.DefaultText = ""
        Me.phoneTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phoneTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phoneTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneTxt.DisabledState.Parent = Me.phoneTxt
        Me.phoneTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phoneTxt.FocusedState.Parent = Me.phoneTxt
        Me.phoneTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phoneTxt.HoverState.Parent = Me.phoneTxt
        Me.phoneTxt.Location = New System.Drawing.Point(252, 363)
        Me.phoneTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneTxt.Name = "phoneTxt"
        Me.phoneTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phoneTxt.PlaceholderText = ""
        Me.phoneTxt.SelectedText = ""
        Me.phoneTxt.ShadowDecoration.Parent = Me.phoneTxt
        Me.phoneTxt.Size = New System.Drawing.Size(282, 29)
        Me.phoneTxt.TabIndex = 93
        '
        'emailTxt
        '
        Me.emailTxt.BorderRadius = 10
        Me.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailTxt.DefaultText = ""
        Me.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailTxt.DisabledState.Parent = Me.emailTxt
        Me.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailTxt.FocusedState.Parent = Me.emailTxt
        Me.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailTxt.HoverState.Parent = Me.emailTxt
        Me.emailTxt.Location = New System.Drawing.Point(252, 264)
        Me.emailTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailTxt.PlaceholderText = ""
        Me.emailTxt.SelectedText = ""
        Me.emailTxt.ShadowDecoration.Parent = Me.emailTxt
        Me.emailTxt.Size = New System.Drawing.Size(282, 29)
        Me.emailTxt.TabIndex = 92
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
        Me.nameTxt.Location = New System.Drawing.Point(252, 214)
        Me.nameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.PlaceholderText = ""
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.ShadowDecoration.Parent = Me.nameTxt
        Me.nameTxt.Size = New System.Drawing.Size(282, 29)
        Me.nameTxt.TabIndex = 91
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(154, 577)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 20)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Child    : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(154, 507)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 20)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Senior  : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(154, 542)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 20)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Adult    : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(60, 471)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(183, 20)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "Number of People    :-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(579, 264)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Selected add-on      : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(579, 214)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 20)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Selected Package   : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(60, 424)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 20)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Date                         : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(60, 372)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 20)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Phone Number         : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(60, 322)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 20)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "IC Number               : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(60, 273)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 20)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Email                       : "
        '
        'pdDocument
        '
        '
        'printDialogprev
        '
        Me.printDialogprev.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printDialogprev.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printDialogprev.ClientSize = New System.Drawing.Size(400, 300)
        Me.printDialogprev.Document = Me.pdDocument
        Me.printDialogprev.Enabled = True
        Me.printDialogprev.Icon = CType(resources.GetObject("printDialogprev.Icon"), System.Drawing.Icon)
        Me.printDialogprev.Name = "printDialogprev"
        Me.printDialogprev.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'bookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1178, 676)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "bookForm"
        Me.Text = "IMRAI TOUR"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dateTxt As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents adultTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents childTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents seniorTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents icTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents phoneTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents emailTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents nameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents confirmBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label20 As Label
    Friend WithEvents cancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bookBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents comboAddon2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents comboAddon1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents pkgLbl As Label
    Friend WithEvents backBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents receiptTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents printBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pdDocument As Printing.PrintDocument
    Friend WithEvents printDialogprev As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
