<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageMaint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImageMaint))
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLoadMth = New System.Windows.Forms.TextBox
        Me.txtLoadYr = New System.Windows.Forms.TextBox
        Me.btnPicSave = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.txtImgType = New System.Windows.Forms.TextBox
        Me.txtImgName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblWordPress = New System.Windows.Forms.Label
        Me.lblFilename = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnGetImages = New System.Windows.Forms.Button
        Me.dgvPeople = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PersonName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtLoadDay = New System.Windows.Forms.TextBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(622, 432)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 28)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Load date"
        '
        'txtLoadMth
        '
        Me.txtLoadMth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoadMth.Location = New System.Drawing.Point(200, 148)
        Me.txtLoadMth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLoadMth.Name = "txtLoadMth"
        Me.txtLoadMth.Size = New System.Drawing.Size(55, 22)
        Me.txtLoadMth.TabIndex = 60
        '
        'txtLoadYr
        '
        Me.txtLoadYr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoadYr.Location = New System.Drawing.Point(278, 148)
        Me.txtLoadYr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLoadYr.Name = "txtLoadYr"
        Me.txtLoadYr.Size = New System.Drawing.Size(82, 22)
        Me.txtLoadYr.TabIndex = 59
        '
        'btnPicSave
        '
        Me.btnPicSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPicSave.Location = New System.Drawing.Point(12, 337)
        Me.btnPicSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPicSave.Name = "btnPicSave"
        Me.btnPicSave.Size = New System.Drawing.Size(70, 28)
        Me.btnPicSave.TabIndex = 58
        Me.btnPicSave.Text = "Save"
        Me.btnPicSave.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(147, 313)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 74)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(147, 215)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 74)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(306, 63)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(374, 22)
        Me.txtSurname.TabIndex = 54
        '
        'txtForename
        '
        Me.txtForename.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForename.Location = New System.Drawing.Point(119, 63)
        Me.txtForename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(179, 22)
        Me.txtForename.TabIndex = 53
        '
        'txtImgType
        '
        Me.txtImgType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgType.Location = New System.Drawing.Point(583, 108)
        Me.txtImgType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtImgType.Name = "txtImgType"
        Me.txtImgType.Size = New System.Drawing.Size(96, 22)
        Me.txtImgType.TabIndex = 57
        Me.txtImgType.Text = ".jpg"
        '
        'txtImgName
        '
        Me.txtImgName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgName.Location = New System.Drawing.Point(119, 108)
        Me.txtImgName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtImgName.Name = "txtImgName"
        Me.txtImgName.Size = New System.Drawing.Size(457, 22)
        Me.txtImgName.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Image Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(113, 313)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "File"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(113, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Wp"
        '
        'lblWordPress
        '
        Me.lblWordPress.AutoSize = True
        Me.lblWordPress.Location = New System.Drawing.Point(235, 241)
        Me.lblWordPress.Name = "lblWordPress"
        Me.lblWordPress.Size = New System.Drawing.Size(47, 17)
        Me.lblWordPress.TabIndex = 68
        Me.lblWordPress.Text = "Label2"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(235, 325)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(47, 17)
        Me.lblFilename.TabIndex = 69
        Me.lblFilename.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(119, 11)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(116, 22)
        Me.txtId.TabIndex = 71
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(321, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 33)
        Me.btnSearch.TabIndex = 72
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(116, 426)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 34)
        Me.btnUpdate.TabIndex = 73
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(291, 426)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 34)
        Me.btnDelete.TabIndex = 74
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(721, 22)
        Me.StatusStrip1.TabIndex = 75
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'btnGetImages
        '
        Me.btnGetImages.Location = New System.Drawing.Point(390, 142)
        Me.btnGetImages.Name = "btnGetImages"
        Me.btnGetImages.Size = New System.Drawing.Size(89, 33)
        Me.btnGetImages.TabIndex = 76
        Me.btnGetImages.Text = "Get Images"
        Me.btnGetImages.UseVisualStyleBackColor = True
        '
        'dgvPeople
        '
        Me.dgvPeople.AllowUserToAddRows = False
        Me.dgvPeople.AllowUserToDeleteRows = False
        Me.dgvPeople.AllowUserToResizeRows = False
        Me.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeople.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Year, Me.PersonName})
        Me.dgvPeople.Location = New System.Drawing.Point(404, 215)
        Me.dgvPeople.MultiSelect = False
        Me.dgvPeople.Name = "dgvPeople"
        Me.dgvPeople.ReadOnly = True
        Me.dgvPeople.RowHeadersVisible = False
        Me.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPeople.Size = New System.Drawing.Size(305, 172)
        Me.dgvPeople.TabIndex = 77
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 50
        '
        'Year
        '
        Me.Year.HeaderText = "Year"
        Me.Year.Name = "Year"
        Me.Year.ReadOnly = True
        Me.Year.Width = 50
        '
        'PersonName
        '
        Me.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PersonName.HeaderText = "Name"
        Me.PersonName.Name = "PersonName"
        Me.PersonName.ReadOnly = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(554, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 78
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtLoadDay
        '
        Me.txtLoadDay.Location = New System.Drawing.Point(119, 146)
        Me.txtLoadDay.Name = "txtLoadDay"
        Me.txtLoadDay.Size = New System.Drawing.Size(49, 24)
        Me.txtLoadDay.TabIndex = 79
        '
        'frmImageMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(721, 497)
        Me.Controls.Add(Me.txtLoadDay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvPeople)
        Me.Controls.Add(Me.btnGetImages)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.lblWordPress)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLoadMth)
        Me.Controls.Add(Me.txtLoadYr)
        Me.Controls.Add(Me.btnPicSave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtImgType)
        Me.Controls.Add(Me.txtImgName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmImageMaint"
        Me.Text = "Maintain Image Details"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvPeople, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLoadMth As System.Windows.Forms.TextBox
    Friend WithEvents txtLoadYr As System.Windows.Forms.TextBox
    Friend WithEvents btnPicSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtImgType As System.Windows.Forms.TextBox
    Friend WithEvents txtImgName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblWordPress As System.Windows.Forms.Label
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnGetImages As System.Windows.Forms.Button
    Friend WithEvents dgvPeople As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtLoadDay As System.Windows.Forms.TextBox
End Class
