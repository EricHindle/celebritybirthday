<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCbDesc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCbDesc))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtCaption = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.txtUrl = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.btnUpdateDesc = New System.Windows.Forms.Button
        Me.txtPersonId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbAutoUpdate = New System.Windows.Forms.CheckBox
        Me.cbForename = New System.Windows.Forms.CheckBox
        Me.cbSurname = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 333)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(531, 65)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(29, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Get Desc"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(17, 281)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(478, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtCaption
        '
        Me.txtCaption.Location = New System.Drawing.Point(17, 307)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(478, 20)
        Me.txtCaption.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox1.Location = New System.Drawing.Point(19, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(63, 26)
        Me.ComboBox1.TabIndex = 5
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox2.Location = New System.Drawing.Point(127, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 26)
        Me.ComboBox2.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(395, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 31)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Get Date"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(19, 173)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(478, 21)
        Me.ComboBox3.TabIndex = 8
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(19, 62)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(63, 20)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(103, 62)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(63, 20)
        Me.NumericUpDown2.TabIndex = 11
        Me.NumericUpDown2.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(194, 62)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {2015, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(63, 20)
        Me.NumericUpDown3.TabIndex = 12
        Me.NumericUpDown3.Value = New Decimal(New Integer() {2013, 0, 0, 0})
        '
        'txtUrl
        '
        Me.txtUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUrl.Location = New System.Drawing.Point(19, 97)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(523, 20)
        Me.txtUrl.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 23)
        Me.Label1.TabIndex = 14
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.Location = New System.Drawing.Point(11, 404)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(455, 46)
        Me.RichTextBox2.TabIndex = 15
        Me.RichTextBox2.Text = ""
        '
        'btnUpdateDesc
        '
        Me.btnUpdateDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateDesc.Location = New System.Drawing.Point(472, 404)
        Me.btnUpdateDesc.Name = "btnUpdateDesc"
        Me.btnUpdateDesc.Size = New System.Drawing.Size(70, 46)
        Me.btnUpdateDesc.TabIndex = 16
        Me.btnUpdateDesc.Text = "Update Description#"
        Me.btnUpdateDesc.UseVisualStyleBackColor = True
        '
        'txtPersonId
        '
        Me.txtPersonId.Location = New System.Drawing.Point(395, 218)
        Me.txtPersonId.Name = "txtPersonId"
        Me.txtPersonId.Size = New System.Drawing.Size(100, 20)
        Me.txtPersonId.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Person Id"
        '
        'cbAutoUpdate
        '
        Me.cbAutoUpdate.AutoSize = True
        Me.cbAutoUpdate.Location = New System.Drawing.Point(480, 458)
        Me.cbAutoUpdate.Name = "cbAutoUpdate"
        Me.cbAutoUpdate.Size = New System.Drawing.Size(48, 17)
        Me.cbAutoUpdate.TabIndex = 19
        Me.cbAutoUpdate.Text = "Auto"
        Me.cbAutoUpdate.UseVisualStyleBackColor = True
        '
        'cbForename
        '
        Me.cbForename.AutoSize = True
        Me.cbForename.Checked = True
        Me.cbForename.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbForename.Location = New System.Drawing.Point(117, 221)
        Me.cbForename.Name = "cbForename"
        Me.cbForename.Size = New System.Drawing.Size(73, 17)
        Me.cbForename.TabIndex = 20
        Me.cbForename.Text = "Forename"
        Me.cbForename.UseVisualStyleBackColor = True
        '
        'cbSurname
        '
        Me.cbSurname.AutoSize = True
        Me.cbSurname.Checked = True
        Me.cbSurname.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSurname.Location = New System.Drawing.Point(209, 220)
        Me.cbSurname.Name = "cbSurname"
        Me.cbSurname.Size = New System.Drawing.Size(68, 17)
        Me.cbSurname.TabIndex = 21
        Me.cbSurname.Text = "Surname"
        Me.cbSurname.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(19, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 31)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Update All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmCbDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(555, 499)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cbSurname)
        Me.Controls.Add(Me.cbForename)
        Me.Controls.Add(Me.cbAutoUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPersonId)
        Me.Controls.Add(Me.btnUpdateDesc)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtCaption)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCbDesc"
        Me.Text = "CB Description"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtCaption As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnUpdateDesc As System.Windows.Forms.Button
    Friend WithEvents txtPersonId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbAutoUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents cbForename As System.Windows.Forms.CheckBox
    Friend WithEvents cbSurname As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
