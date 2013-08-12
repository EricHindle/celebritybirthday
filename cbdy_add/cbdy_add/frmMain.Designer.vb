<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.txtCurrentText = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCurrentExcerpt = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDied = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnGenFullText = New System.Windows.Forms.Button
        Me.btnGenExcerpt = New System.Windows.Forms.Button
        Me.btnCopyFull = New System.Windows.Forms.Button
        Me.btnCopyExcerpt = New System.Windows.Forms.Button
        Me.btnClrNew = New System.Windows.Forms.Button
        Me.btnClrCurr = New System.Windows.Forms.Button
        Me.btnClrExcerpt = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.cboDay = New System.Windows.Forms.ComboBox
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.lbPeople = New System.Windows.Forms.ListBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.btnDown = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtImgName = New System.Windows.Forms.TextBox
        Me.txtImgType = New System.Windows.Forms.TextBox
        Me.btnMakeImgName = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClearList = New System.Windows.Forms.Button
        Me.btnReloadSel = New System.Windows.Forms.Button
        Me.btnLoadTable = New System.Windows.Forms.Button
        Me.btnUpdateSel = New System.Windows.Forms.Button
        Me.btnUpdateAll = New System.Windows.Forms.Button
        Me.txtShortDesc = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblID = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnPicSave = New System.Windows.Forms.Button
        Me.txtLoadYr = New System.Windows.Forms.TextBox
        Me.txtLoadMth = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FindPeopleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnLoadUpd = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnFindImage = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbDateAmend = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AllowDrop = True
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(124, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(542, 24)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Year born"
        '
        'txtYear
        '
        Me.txtYear.AllowDrop = True
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(124, 118)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(114, 24)
        Me.txtYear.TabIndex = 3
        '
        'txtCurrentText
        '
        Me.txtCurrentText.AllowDrop = True
        Me.txtCurrentText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentText.Location = New System.Drawing.Point(14, 410)
        Me.txtCurrentText.Multiline = True
        Me.txtCurrentText.Name = "txtCurrentText"
        Me.txtCurrentText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCurrentText.Size = New System.Drawing.Size(657, 197)
        Me.txtCurrentText.TabIndex = 16
        Me.txtCurrentText.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Current Text"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 671)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Current Excerpt"
        '
        'txtCurrentExcerpt
        '
        Me.txtCurrentExcerpt.AllowDrop = True
        Me.txtCurrentExcerpt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentExcerpt.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentExcerpt.Location = New System.Drawing.Point(14, 692)
        Me.txtCurrentExcerpt.Multiline = True
        Me.txtCurrentExcerpt.Name = "txtCurrentExcerpt"
        Me.txtCurrentExcerpt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCurrentExcerpt.Size = New System.Drawing.Size(657, 148)
        Me.txtCurrentExcerpt.TabIndex = 21
        Me.txtCurrentExcerpt.WordWrap = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(936, 846)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 40)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.AllowDrop = True
        Me.txtDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesc.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(124, 152)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(542, 75)
        Me.txtDesc.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Description"
        '
        'txtDied
        '
        Me.txtDied.AllowDrop = True
        Me.txtDied.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDied.Location = New System.Drawing.Point(412, 118)
        Me.txtDied.Name = "txtDied"
        Me.txtDied.Size = New System.Drawing.Size(114, 24)
        Me.txtDied.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(332, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Year died"
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(14, 614)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(119, 40)
        Me.btnLoad.TabIndex = 17
        Me.btnLoad.Text = "Load People"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnGenFullText
        '
        Me.btnGenFullText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenFullText.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenFullText.Location = New System.Drawing.Point(177, 614)
        Me.btnGenFullText.Name = "btnGenFullText"
        Me.btnGenFullText.Size = New System.Drawing.Size(86, 40)
        Me.btnGenFullText.TabIndex = 18
        Me.btnGenFullText.Text = "Generate"
        Me.btnGenFullText.UseVisualStyleBackColor = True
        '
        'btnGenExcerpt
        '
        Me.btnGenExcerpt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenExcerpt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenExcerpt.Location = New System.Drawing.Point(177, 846)
        Me.btnGenExcerpt.Name = "btnGenExcerpt"
        Me.btnGenExcerpt.Size = New System.Drawing.Size(86, 40)
        Me.btnGenExcerpt.TabIndex = 22
        Me.btnGenExcerpt.Text = "Generate"
        Me.btnGenExcerpt.UseVisualStyleBackColor = True
        '
        'btnCopyFull
        '
        Me.btnCopyFull.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopyFull.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyFull.Location = New System.Drawing.Point(438, 614)
        Me.btnCopyFull.Name = "btnCopyFull"
        Me.btnCopyFull.Size = New System.Drawing.Size(61, 40)
        Me.btnCopyFull.TabIndex = 19
        Me.btnCopyFull.Text = "Copy"
        Me.btnCopyFull.UseVisualStyleBackColor = True
        '
        'btnCopyExcerpt
        '
        Me.btnCopyExcerpt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopyExcerpt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyExcerpt.Location = New System.Drawing.Point(438, 846)
        Me.btnCopyExcerpt.Name = "btnCopyExcerpt"
        Me.btnCopyExcerpt.Size = New System.Drawing.Size(61, 40)
        Me.btnCopyExcerpt.TabIndex = 23
        Me.btnCopyExcerpt.Text = "Copy"
        Me.btnCopyExcerpt.UseVisualStyleBackColor = True
        '
        'btnClrNew
        '
        Me.btnClrNew.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrNew.Location = New System.Drawing.Point(598, 326)
        Me.btnClrNew.Name = "btnClrNew"
        Me.btnClrNew.Size = New System.Drawing.Size(85, 40)
        Me.btnClrNew.TabIndex = 15
        Me.btnClrNew.Text = "Clear"
        Me.btnClrNew.UseVisualStyleBackColor = True
        '
        'btnClrCurr
        '
        Me.btnClrCurr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClrCurr.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrCurr.Location = New System.Drawing.Point(583, 614)
        Me.btnClrCurr.Name = "btnClrCurr"
        Me.btnClrCurr.Size = New System.Drawing.Size(85, 40)
        Me.btnClrCurr.TabIndex = 20
        Me.btnClrCurr.Text = "Clear"
        Me.btnClrCurr.UseVisualStyleBackColor = True
        '
        'btnClrExcerpt
        '
        Me.btnClrExcerpt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClrExcerpt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrExcerpt.Location = New System.Drawing.Point(583, 846)
        Me.btnClrExcerpt.Name = "btnClrExcerpt"
        Me.btnClrExcerpt.Size = New System.Drawing.Size(85, 40)
        Me.btnClrExcerpt.TabIndex = 24
        Me.btnClrExcerpt.Text = "Clear"
        Me.btnClrExcerpt.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(23, 326)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(86, 40)
        Me.btnInsert.TabIndex = 10
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'cboDay
        '
        Me.cboDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDay.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboDay.Location = New System.Drawing.Point(699, 42)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(69, 33)
        Me.cboDay.TabIndex = 25
        '
        'cboMonth
        '
        Me.cboMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMonth.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(785, 42)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(233, 33)
        Me.cboMonth.TabIndex = 26
        '
        'lbPeople
        '
        Me.lbPeople.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPeople.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPeople.FormattingEnabled = True
        Me.lbPeople.ItemHeight = 18
        Me.lbPeople.Location = New System.Drawing.Point(699, 81)
        Me.lbPeople.Name = "lbPeople"
        Me.lbPeople.Size = New System.Drawing.Size(272, 544)
        Me.lbPeople.TabIndex = 27
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(205, 35)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 48)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Person"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUp.Location = New System.Drawing.Point(977, 81)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(43, 40)
        Me.btnUp.TabIndex = 28
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDown.Location = New System.Drawing.Point(976, 127)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(42, 40)
        Me.btnDown.TabIndex = 29
        Me.btnDown.Text = "Dn"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Image Name"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(434, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Image Type"
        '
        'txtImgName
        '
        Me.txtImgName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImgName.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgName.Location = New System.Drawing.Point(124, 270)
        Me.txtImgName.Name = "txtImgName"
        Me.txtImgName.Size = New System.Drawing.Size(269, 24)
        Me.txtImgName.TabIndex = 7
        '
        'txtImgType
        '
        Me.txtImgType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImgType.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgType.Location = New System.Drawing.Point(527, 270)
        Me.txtImgType.Name = "txtImgType"
        Me.txtImgType.Size = New System.Drawing.Size(83, 24)
        Me.txtImgType.TabIndex = 9
        Me.txtImgType.Text = ".jpg"
        '
        'btnMakeImgName
        '
        Me.btnMakeImgName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMakeImgName.Location = New System.Drawing.Point(399, 270)
        Me.btnMakeImgName.Name = "btnMakeImgName"
        Me.btnMakeImgName.Size = New System.Drawing.Size(30, 24)
        Me.btnMakeImgName.TabIndex = 8
        Me.btnMakeImgName.Text = "<"
        Me.btnMakeImgName.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClearList)
        Me.GroupBox1.Controls.Add(Me.btnReloadSel)
        Me.GroupBox1.Controls.Add(Me.btnLoadTable)
        Me.GroupBox1.Controls.Add(Me.btnUpdateSel)
        Me.GroupBox1.Controls.Add(Me.btnUpdateAll)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(701, 695)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 148)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database"
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(205, 89)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(86, 48)
        Me.btnClearList.TabIndex = 5
        Me.btnClearList.Text = "Clear list"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'btnReloadSel
        '
        Me.btnReloadSel.Location = New System.Drawing.Point(113, 89)
        Me.btnReloadSel.Name = "btnReloadSel"
        Me.btnReloadSel.Size = New System.Drawing.Size(86, 48)
        Me.btnReloadSel.TabIndex = 3
        Me.btnReloadSel.Text = "Reload table item"
        Me.btnReloadSel.UseVisualStyleBackColor = True
        '
        'btnLoadTable
        '
        Me.btnLoadTable.Location = New System.Drawing.Point(113, 35)
        Me.btnLoadTable.Name = "btnLoadTable"
        Me.btnLoadTable.Size = New System.Drawing.Size(86, 48)
        Me.btnLoadTable.TabIndex = 2
        Me.btnLoadTable.Text = "Reload Full Table"
        Me.btnLoadTable.UseVisualStyleBackColor = True
        '
        'btnUpdateSel
        '
        Me.btnUpdateSel.Location = New System.Drawing.Point(21, 89)
        Me.btnUpdateSel.Name = "btnUpdateSel"
        Me.btnUpdateSel.Size = New System.Drawing.Size(86, 48)
        Me.btnUpdateSel.TabIndex = 1
        Me.btnUpdateSel.Text = "Update db selected"
        Me.btnUpdateSel.UseVisualStyleBackColor = True
        '
        'btnUpdateAll
        '
        Me.btnUpdateAll.Location = New System.Drawing.Point(21, 35)
        Me.btnUpdateAll.Name = "btnUpdateAll"
        Me.btnUpdateAll.Size = New System.Drawing.Size(86, 48)
        Me.btnUpdateAll.TabIndex = 0
        Me.btnUpdateAll.Text = "Update db  All"
        Me.btnUpdateAll.UseVisualStyleBackColor = True
        '
        'txtShortDesc
        '
        Me.txtShortDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShortDesc.Location = New System.Drawing.Point(124, 234)
        Me.txtShortDesc.Name = "txtShortDesc"
        Me.txtShortDesc.Size = New System.Drawing.Size(506, 25)
        Me.txtShortDesc.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Short desc"
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(124, 75)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(253, 25)
        Me.txtForename.TabIndex = 1
        '
        'txtSurname
        '
        Me.txtSurname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSurname.Location = New System.Drawing.Point(385, 75)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(282, 25)
        Me.txtSurname.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 892)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1034, 22)
        Me.StatusStrip1.TabIndex = 43
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(14, 79)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 18)
        Me.lblID.TabIndex = 44
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(177, 326)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 40)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(317, 316)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(412, 316)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'btnPicSave
        '
        Me.btnPicSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPicSave.Location = New System.Drawing.Point(317, 381)
        Me.btnPicSave.Name = "btnPicSave"
        Me.btnPicSave.Size = New System.Drawing.Size(60, 23)
        Me.btnPicSave.TabIndex = 12
        Me.btnPicSave.Text = "Save"
        Me.btnPicSave.UseVisualStyleBackColor = True
        '
        'txtLoadYr
        '
        Me.txtLoadYr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoadYr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoadYr.Location = New System.Drawing.Point(868, 667)
        Me.txtLoadYr.Name = "txtLoadYr"
        Me.txtLoadYr.Size = New System.Drawing.Size(71, 22)
        Me.txtLoadYr.TabIndex = 13
        '
        'txtLoadMth
        '
        Me.txtLoadMth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoadMth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoadMth.Location = New System.Drawing.Point(814, 667)
        Me.txtLoadMth.Name = "txtLoadMth"
        Me.txtLoadMth.Size = New System.Drawing.Size(48, 22)
        Me.txtLoadMth.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(641, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 24)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(88, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 24)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(88, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 24)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = ">"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(719, 667)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Load date"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ImagesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1034, 24)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindPeopleToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "Search"
        '
        'FindPeopleToolStripMenuItem
        '
        Me.FindPeopleToolStripMenuItem.Name = "FindPeopleToolStripMenuItem"
        Me.FindPeopleToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.FindPeopleToolStripMenuItem.Text = "Find People in Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ImagesToolStripMenuItem
        '
        Me.ImagesToolStripMenuItem.Name = "ImagesToolStripMenuItem"
        Me.ImagesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ImagesToolStripMenuItem.Text = "Images"
        '
        'btnLoadUpd
        '
        Me.btnLoadUpd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadUpd.Location = New System.Drawing.Point(959, 665)
        Me.btnLoadUpd.Name = "btnLoadUpd"
        Me.btnLoadUpd.Size = New System.Drawing.Size(45, 25)
        Me.btnLoadUpd.TabIndex = 54
        Me.btnLoadUpd.Text = "Upd"
        Me.btnLoadUpd.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 868)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 18)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Label11"
        '
        'btnFindImage
        '
        Me.btnFindImage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindImage.Location = New System.Drawing.Point(506, 326)
        Me.btnFindImage.Name = "btnFindImage"
        Me.btnFindImage.Size = New System.Drawing.Size(60, 40)
        Me.btnFindImage.TabIndex = 56
        Me.btnFindImage.Text = "Find Image"
        Me.btnFindImage.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(288, 316)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Wp"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(383, 316)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "File"
        '
        'cbDateAmend
        '
        Me.cbDateAmend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDateAmend.AutoSize = True
        Me.cbDateAmend.Location = New System.Drawing.Point(763, 631)
        Me.cbDateAmend.Name = "cbDateAmend"
        Me.cbDateAmend.Size = New System.Drawing.Size(124, 22)
        Me.cbDateAmend.TabIndex = 59
        Me.cbDateAmend.Text = "Date amended"
        Me.cbDateAmend.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1034, 914)
        Me.Controls.Add(Me.cbDateAmend)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnFindImage)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnLoadUpd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtLoadMth)
        Me.Controls.Add(Me.txtLoadYr)
        Me.Controls.Add(Me.btnPicSave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtShortDesc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMakeImgName)
        Me.Controls.Add(Me.txtImgType)
        Me.Controls.Add(Me.txtImgName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.lbPeople)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnClrExcerpt)
        Me.Controls.Add(Me.btnClrCurr)
        Me.Controls.Add(Me.btnClrNew)
        Me.Controls.Add(Me.btnCopyExcerpt)
        Me.Controls.Add(Me.btnCopyFull)
        Me.Controls.Add(Me.btnGenExcerpt)
        Me.Controls.Add(Me.btnGenFullText)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtDied)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCurrentExcerpt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurrentText)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1048, 950)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Celebrity Birthday Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentExcerpt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDied As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnGenFullText As System.Windows.Forms.Button
    Friend WithEvents btnGenExcerpt As System.Windows.Forms.Button
    Friend WithEvents btnCopyFull As System.Windows.Forms.Button
    Friend WithEvents btnCopyExcerpt As System.Windows.Forms.Button
    Friend WithEvents btnClrNew As System.Windows.Forms.Button
    Friend WithEvents btnClrCurr As System.Windows.Forms.Button
    Friend WithEvents btnClrExcerpt As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lbPeople As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImgName As System.Windows.Forms.TextBox
    Friend WithEvents txtImgType As System.Windows.Forms.TextBox
    Friend WithEvents btnMakeImgName As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtShortDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents btnReloadSel As System.Windows.Forms.Button
    Friend WithEvents btnLoadTable As System.Windows.Forms.Button
    Friend WithEvents btnUpdateSel As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAll As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPicSave As System.Windows.Forms.Button
    Friend WithEvents txtLoadYr As System.Windows.Forms.TextBox
    Friend WithEvents txtLoadMth As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindPeopleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLoadUpd As System.Windows.Forms.Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnFindImage As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ImagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbDateAmend As System.Windows.Forms.CheckBox

End Class
