<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertCustomer_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertCustomer_a193067))
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_insertcustomer = New System.Windows.Forms.DataGridView()
        Me.lbl_instructions = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_contactnumber = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_contactnumber = New System.Windows.Forms.Label()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.txt_customerID = New System.Windows.Forms.TextBox()
        Me.lbl_customerID = New System.Windows.Forms.Label()
        CType(Me.grd_insertcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_brand.Location = New System.Drawing.Point(12, 9)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(307, 23)
        Me.lbl_brand.TabIndex = 19
        Me.lbl_brand.Text = "CHAMPION SPORTS"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(328, 50)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(388, 44)
        Me.lbl_title.TabIndex = 20
        Me.lbl_title.Text = "Insert Customer"
        '
        'grd_insertcustomer
        '
        Me.grd_insertcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertcustomer.Location = New System.Drawing.Point(146, 113)
        Me.grd_insertcustomer.Name = "grd_insertcustomer"
        Me.grd_insertcustomer.RowHeadersWidth = 51
        Me.grd_insertcustomer.RowTemplate.Height = 24
        Me.grd_insertcustomer.Size = New System.Drawing.Size(751, 241)
        Me.grd_insertcustomer.TabIndex = 21
        '
        'lbl_instructions
        '
        Me.lbl_instructions.AutoSize = True
        Me.lbl_instructions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instructions.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instructions.ForeColor = System.Drawing.Color.Red
        Me.lbl_instructions.Location = New System.Drawing.Point(284, 371)
        Me.lbl_instructions.Name = "lbl_instructions"
        Me.lbl_instructions.Size = New System.Drawing.Size(448, 27)
        Me.lbl_instructions.TabIndex = 37
        Me.lbl_instructions.Text = "* Please insert the data below. *"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_insert.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_insert.Location = New System.Drawing.Point(416, 657)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(175, 59)
        Me.btn_insert.TabIndex = 36
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(557, 592)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(233, 22)
        Me.txt_email.TabIndex = 33
        '
        'txt_contactnumber
        '
        Me.txt_contactnumber.Location = New System.Drawing.Point(557, 477)
        Me.txt_contactnumber.Name = "txt_contactnumber"
        Me.txt_contactnumber.Size = New System.Drawing.Size(233, 22)
        Me.txt_contactnumber.TabIndex = 31
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(553, 547)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(88, 22)
        Me.lbl_email.TabIndex = 30
        Me.lbl_email.Text = "Email :"
        '
        'lbl_contactnumber
        '
        Me.lbl_contactnumber.AutoSize = True
        Me.lbl_contactnumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contactnumber.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contactnumber.Location = New System.Drawing.Point(553, 433)
        Me.lbl_contactnumber.Name = "lbl_contactnumber"
        Me.lbl_contactnumber.Size = New System.Drawing.Size(199, 22)
        Me.lbl_contactnumber.TabIndex = 26
        Me.lbl_contactnumber.Text = "Contact Number:"
        '
        'txt_customername
        '
        Me.txt_customername.Location = New System.Drawing.Point(227, 592)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(227, 22)
        Me.txt_customername.TabIndex = 25
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customername.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.Location = New System.Drawing.Point(223, 547)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(193, 22)
        Me.lbl_customername.TabIndex = 24
        Me.lbl_customername.Text = "Customer Name:"
        '
        'txt_customerID
        '
        Me.txt_customerID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_customerID.Location = New System.Drawing.Point(227, 477)
        Me.txt_customerID.Name = "txt_customerID"
        Me.txt_customerID.ReadOnly = True
        Me.txt_customerID.Size = New System.Drawing.Size(227, 22)
        Me.txt_customerID.TabIndex = 23
        '
        'lbl_customerID
        '
        Me.lbl_customerID.AutoSize = True
        Me.lbl_customerID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerID.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerID.Location = New System.Drawing.Point(223, 433)
        Me.lbl_customerID.Name = "lbl_customerID"
        Me.lbl_customerID.Size = New System.Drawing.Size(149, 22)
        Me.lbl_customerID.TabIndex = 22
        Me.lbl_customerID.Text = "CustomerID:"
        '
        'frm_insertCustomer_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1057, 767)
        Me.Controls.Add(Me.lbl_instructions)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_contactnumber)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_contactnumber)
        Me.Controls.Add(Me.txt_customername)
        Me.Controls.Add(Me.lbl_customername)
        Me.Controls.Add(Me.txt_customerID)
        Me.Controls.Add(Me.lbl_customerID)
        Me.Controls.Add(Me.grd_insertcustomer)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_brand)
        Me.DoubleBuffered = True
        Me.Name = "frm_insertCustomer_a193067"
        Me.Text = "frm_insertCustomer_a193067"
        CType(Me.grd_insertcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_insertcustomer As DataGridView
    Friend WithEvents lbl_instructions As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_contactnumber As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_contactnumber As Label
    Friend WithEvents txt_customername As TextBox
    Friend WithEvents lbl_customername As Label
    Friend WithEvents txt_customerID As TextBox
    Friend WithEvents lbl_customerID As Label
End Class
