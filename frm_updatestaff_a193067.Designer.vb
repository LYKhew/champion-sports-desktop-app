<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatestaff_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatestaff_a193067))
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_updatestaff = New System.Windows.Forms.DataGridView()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_contactnumber = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_contactnumber = New System.Windows.Forms.Label()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.lbl_staffname = New System.Windows.Forms.Label()
        Me.txt_staffID = New System.Windows.Forms.TextBox()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.lbl_instructions = New System.Windows.Forms.Label()
        CType(Me.grd_updatestaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_brand.Location = New System.Drawing.Point(12, 18)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(307, 23)
        Me.lbl_brand.TabIndex = 21
        Me.lbl_brand.Text = "CHAMPION SPORTS"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(334, 76)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(318, 44)
        Me.lbl_title.TabIndex = 22
        Me.lbl_title.Text = "Update Staff"
        '
        'grd_updatestaff
        '
        Me.grd_updatestaff.AllowUserToAddRows = False
        Me.grd_updatestaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updatestaff.Location = New System.Drawing.Point(122, 177)
        Me.grd_updatestaff.MultiSelect = False
        Me.grd_updatestaff.Name = "grd_updatestaff"
        Me.grd_updatestaff.ReadOnly = True
        Me.grd_updatestaff.RowHeadersWidth = 51
        Me.grd_updatestaff.RowTemplate.Height = 24
        Me.grd_updatestaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_updatestaff.Size = New System.Drawing.Size(751, 241)
        Me.grd_updatestaff.TabIndex = 23
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_update.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_update.Location = New System.Drawing.Point(411, 712)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(175, 59)
        Me.btn_update.TabIndex = 56
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(557, 664)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(233, 22)
        Me.txt_email.TabIndex = 55
        '
        'txt_contactnumber
        '
        Me.txt_contactnumber.Location = New System.Drawing.Point(557, 527)
        Me.txt_contactnumber.Name = "txt_contactnumber"
        Me.txt_contactnumber.Size = New System.Drawing.Size(233, 22)
        Me.txt_contactnumber.TabIndex = 54
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(553, 590)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(88, 22)
        Me.lbl_email.TabIndex = 53
        Me.lbl_email.Text = "Email :"
        '
        'lbl_contactnumber
        '
        Me.lbl_contactnumber.AutoSize = True
        Me.lbl_contactnumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contactnumber.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contactnumber.Location = New System.Drawing.Point(553, 467)
        Me.lbl_contactnumber.Name = "lbl_contactnumber"
        Me.lbl_contactnumber.Size = New System.Drawing.Size(199, 22)
        Me.lbl_contactnumber.TabIndex = 52
        Me.lbl_contactnumber.Text = "Contact Number:"
        '
        'txt_staffname
        '
        Me.txt_staffname.Location = New System.Drawing.Point(209, 664)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(227, 22)
        Me.txt_staffname.TabIndex = 51
        '
        'lbl_staffname
        '
        Me.lbl_staffname.AutoSize = True
        Me.lbl_staffname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffname.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffname.Location = New System.Drawing.Point(205, 599)
        Me.lbl_staffname.Name = "lbl_staffname"
        Me.lbl_staffname.Size = New System.Drawing.Size(151, 22)
        Me.lbl_staffname.TabIndex = 50
        Me.lbl_staffname.Text = "Staff Name:"
        '
        'txt_staffID
        '
        Me.txt_staffID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_staffID.Location = New System.Drawing.Point(209, 527)
        Me.txt_staffID.Name = "txt_staffID"
        Me.txt_staffID.ReadOnly = True
        Me.txt_staffID.Size = New System.Drawing.Size(227, 22)
        Me.txt_staffID.TabIndex = 49
        '
        'lbl_staffID
        '
        Me.lbl_staffID.AutoSize = True
        Me.lbl_staffID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffID.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.Location = New System.Drawing.Point(205, 467)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(114, 22)
        Me.lbl_staffID.TabIndex = 48
        Me.lbl_staffID.Text = "Staff ID:"
        '
        'lbl_instructions
        '
        Me.lbl_instructions.AutoSize = True
        Me.lbl_instructions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instructions.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instructions.ForeColor = System.Drawing.Color.Red
        Me.lbl_instructions.Location = New System.Drawing.Point(267, 147)
        Me.lbl_instructions.Name = "lbl_instructions"
        Me.lbl_instructions.Size = New System.Drawing.Size(445, 27)
        Me.lbl_instructions.TabIndex = 57
        Me.lbl_instructions.Text = "* Please select the data below. *"
        '
        'frm_updatestaff_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1021, 792)
        Me.Controls.Add(Me.lbl_instructions)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_contactnumber)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_contactnumber)
        Me.Controls.Add(Me.txt_staffname)
        Me.Controls.Add(Me.lbl_staffname)
        Me.Controls.Add(Me.txt_staffID)
        Me.Controls.Add(Me.lbl_staffID)
        Me.Controls.Add(Me.grd_updatestaff)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_brand)
        Me.DoubleBuffered = True
        Me.Name = "frm_updatestaff_a193067"
        Me.Text = "frm_updatestaff_a193067"
        CType(Me.grd_updatestaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_updatestaff As DataGridView
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_contactnumber As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_contactnumber As Label
    Friend WithEvents txt_staffname As TextBox
    Friend WithEvents lbl_staffname As Label
    Friend WithEvents txt_staffID As TextBox
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents lbl_instructions As Label
End Class
