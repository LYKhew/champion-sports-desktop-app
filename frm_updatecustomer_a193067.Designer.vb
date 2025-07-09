<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomer_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatecustomer_a193067))
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_updatecustomer = New System.Windows.Forms.DataGridView()
        Me.lbl_instructions = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_contactnumber = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_contactnumber = New System.Windows.Forms.Label()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.txt_customerID = New System.Windows.Forms.TextBox()
        Me.lbl_customerID = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.grd_updatecustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_brand.Location = New System.Drawing.Point(3, 9)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(307, 23)
        Me.lbl_brand.TabIndex = 20
        Me.lbl_brand.Text = "CHAMPION SPORTS"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(325, 59)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(402, 44)
        Me.lbl_title.TabIndex = 21
        Me.lbl_title.Text = "Update Customer"
        '
        'grd_updatecustomer
        '
        Me.grd_updatecustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updatecustomer.Location = New System.Drawing.Point(139, 162)
        Me.grd_updatecustomer.MultiSelect = False
        Me.grd_updatecustomer.Name = "grd_updatecustomer"
        Me.grd_updatecustomer.ReadOnly = True
        Me.grd_updatecustomer.RowHeadersWidth = 51
        Me.grd_updatecustomer.RowTemplate.Height = 24
        Me.grd_updatecustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_updatecustomer.Size = New System.Drawing.Size(751, 241)
        Me.grd_updatecustomer.TabIndex = 22
        '
        'lbl_instructions
        '
        Me.lbl_instructions.AutoSize = True
        Me.lbl_instructions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instructions.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instructions.ForeColor = System.Drawing.Color.Red
        Me.lbl_instructions.Location = New System.Drawing.Point(299, 132)
        Me.lbl_instructions.Name = "lbl_instructions"
        Me.lbl_instructions.Size = New System.Drawing.Size(445, 27)
        Me.lbl_instructions.TabIndex = 46
        Me.lbl_instructions.Text = "* Please select the data below. *"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(605, 612)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(233, 22)
        Me.txt_email.TabIndex = 45
        '
        'txt_contactnumber
        '
        Me.txt_contactnumber.Location = New System.Drawing.Point(605, 481)
        Me.txt_contactnumber.Name = "txt_contactnumber"
        Me.txt_contactnumber.Size = New System.Drawing.Size(233, 22)
        Me.txt_contactnumber.TabIndex = 44
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(601, 560)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(88, 22)
        Me.lbl_email.TabIndex = 43
        Me.lbl_email.Text = "Email :"
        '
        'lbl_contactnumber
        '
        Me.lbl_contactnumber.AutoSize = True
        Me.lbl_contactnumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contactnumber.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contactnumber.Location = New System.Drawing.Point(601, 433)
        Me.lbl_contactnumber.Name = "lbl_contactnumber"
        Me.lbl_contactnumber.Size = New System.Drawing.Size(199, 22)
        Me.lbl_contactnumber.TabIndex = 42
        Me.lbl_contactnumber.Text = "Contact Number:"
        '
        'txt_customername
        '
        Me.txt_customername.Location = New System.Drawing.Point(213, 612)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(227, 22)
        Me.txt_customername.TabIndex = 41
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customername.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.Location = New System.Drawing.Point(209, 560)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(193, 22)
        Me.lbl_customername.TabIndex = 40
        Me.lbl_customername.Text = "Customer Name:"
        '
        'txt_customerID
        '
        Me.txt_customerID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_customerID.Location = New System.Drawing.Point(213, 491)
        Me.txt_customerID.Name = "txt_customerID"
        Me.txt_customerID.ReadOnly = True
        Me.txt_customerID.Size = New System.Drawing.Size(227, 22)
        Me.txt_customerID.TabIndex = 39
        '
        'lbl_customerID
        '
        Me.lbl_customerID.AutoSize = True
        Me.lbl_customerID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerID.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerID.Location = New System.Drawing.Point(209, 433)
        Me.lbl_customerID.Name = "lbl_customerID"
        Me.lbl_customerID.Size = New System.Drawing.Size(149, 22)
        Me.lbl_customerID.TabIndex = 38
        Me.lbl_customerID.Text = "CustomerID:"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_update.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_update.Location = New System.Drawing.Point(429, 655)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(175, 59)
        Me.btn_update.TabIndex = 47
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'frm_updatecustomer_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 738)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_instructions)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_contactnumber)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_contactnumber)
        Me.Controls.Add(Me.txt_customername)
        Me.Controls.Add(Me.lbl_customername)
        Me.Controls.Add(Me.txt_customerID)
        Me.Controls.Add(Me.lbl_customerID)
        Me.Controls.Add(Me.grd_updatecustomer)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_brand)
        Me.DoubleBuffered = True
        Me.Name = "frm_updatecustomer_a193067"
        Me.Text = "frm_updatecustomer_a193067"
        CType(Me.grd_updatecustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_updatecustomer As DataGridView
    Friend WithEvents lbl_instructions As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_contactnumber As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_contactnumber As Label
    Friend WithEvents txt_customername As TextBox
    Friend WithEvents lbl_customername As Label
    Friend WithEvents txt_customerID As TextBox
    Friend WithEvents lbl_customerID As Label
    Friend WithEvents btn_update As Button
End Class
