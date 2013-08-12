<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageStore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImageStore))
        Me.PicBrowser = New System.Windows.Forms.WebBrowser
        Me.picStatus = New System.Windows.Forms.Label
        Me.btnSavepic = New System.Windows.Forms.Button
        Me.btnNextpic = New System.Windows.Forms.Button
        Me.btnPrevpic = New System.Windows.Forms.Button
        Me.cbOrig = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'PicBrowser
        '
        Me.PicBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBrowser.Location = New System.Drawing.Point(3, 30)
        Me.PicBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PicBrowser.Name = "PicBrowser"
        Me.PicBrowser.Size = New System.Drawing.Size(805, 442)
        Me.PicBrowser.TabIndex = 57
        '
        'picStatus
        '
        Me.picStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picStatus.AutoSize = True
        Me.picStatus.Location = New System.Drawing.Point(330, 529)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(56, 13)
        Me.picStatus.TabIndex = 65
        Me.picStatus.Text = "No picture"
        '
        'btnSavepic
        '
        Me.btnSavepic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSavepic.Location = New System.Drawing.Point(143, 524)
        Me.btnSavepic.Name = "btnSavepic"
        Me.btnSavepic.Size = New System.Drawing.Size(49, 23)
        Me.btnSavepic.TabIndex = 64
        Me.btnSavepic.Text = "Save"
        Me.btnSavepic.UseVisualStyleBackColor = True
        '
        'btnNextpic
        '
        Me.btnNextpic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNextpic.Location = New System.Drawing.Point(76, 524)
        Me.btnNextpic.Name = "btnNextpic"
        Me.btnNextpic.Size = New System.Drawing.Size(49, 23)
        Me.btnNextpic.TabIndex = 63
        Me.btnNextpic.Text = "Next"
        Me.btnNextpic.UseVisualStyleBackColor = True
        '
        'btnPrevpic
        '
        Me.btnPrevpic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevpic.Location = New System.Drawing.Point(12, 524)
        Me.btnPrevpic.Name = "btnPrevpic"
        Me.btnPrevpic.Size = New System.Drawing.Size(49, 23)
        Me.btnPrevpic.TabIndex = 62
        Me.btnPrevpic.Text = "Prev"
        Me.btnPrevpic.UseVisualStyleBackColor = True
        '
        'cbOrig
        '
        Me.cbOrig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbOrig.AutoSize = True
        Me.cbOrig.Location = New System.Drawing.Point(198, 528)
        Me.cbOrig.Name = "cbOrig"
        Me.cbOrig.Size = New System.Drawing.Size(126, 17)
        Me.cbOrig.TabIndex = 67
        Me.cbOrig.Text = "Include original name"
        Me.cbOrig.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(713, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(12, 495)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(186, 23)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Set default image folder"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 500)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Label2"
        '
        'frmImageStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(811, 549)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbOrig)
        Me.Controls.Add(Me.picStatus)
        Me.Controls.Add(Me.btnSavepic)
        Me.Controls.Add(Me.btnNextpic)
        Me.Controls.Add(Me.btnPrevpic)
        Me.Controls.Add(Me.PicBrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImageStore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Store Image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents picStatus As System.Windows.Forms.Label
    Friend WithEvents btnSavepic As System.Windows.Forms.Button
    Friend WithEvents btnNextpic As System.Windows.Forms.Button
    Friend WithEvents btnPrevpic As System.Windows.Forms.Button
    Friend WithEvents cbOrig As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
